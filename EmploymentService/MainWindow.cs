using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmploymentService
{
    enum rowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class MainWindow : Form
    {
        Database database = new Database();
        int selectedRowVAC;
        int selectedRowUN;
        int selectedRowKU;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CreateColumns()
        {
            dataGridView_vacancies.Columns.Add("Ід", "ID");
            dataGridView_vacancies.Columns.Add("Назва", "Назва");
            dataGridView_vacancies.Columns.Add("ЗаробітнаПлата", "Заробітна плата");
            dataGridView_vacancies.Columns.Add("Статус", "Статус");
            dataGridView_vacancies.Columns.Add("ТипЗайнятості", "Тип зайнятості");
            dataGridView_vacancies.Columns.Add("Опис", "Опис");
            dataGridView_vacancies.Columns.Add("Вимоги", "Вимоги");
            dataGridView_vacancies.Columns.Add("ДатаДодавання", "Дата");
            dataGridView_vacancies.Columns.Add("Info", String.Empty);
        }
        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetDecimal(10), record.GetString(6), record.GetString(5), record.GetString(2), record.GetString(3), record.GetDateTime(4), rowState.ModifiedNew);
        
        }
 
        private void RefreshDataGrid(DataGridView dwg)
        {
            dwg.Rows.Clear();
            string querystring = $"select * from Вакансії";
            SqlCommand command = new SqlCommand(querystring, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dwg, reader);
            }
            reader.Close();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            CreateColumns();
            CreateColumnsUN();
            CreateColumnsB();
            CreateColumnsRec();
            CreateColumnsKU();
            RefreshDataGridKU(dataGridView_KU);
            RefreshDataGrid(dataGridView_vacancies);
            RefreshDataGridUN(dataGridView_unemployed);
            RefreshDataGridUN(dataGridView_B);
            RefreshDataGridRec(dataGridView_rec);
            CreateColumnsKursBezrob();

        }

        private void dataGridView_vacancies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowVAC = e.RowIndex;
            if (selectedRowVAC >= 0) { 
                DataGridViewRow row = dataGridView_vacancies.Rows[selectedRowVAC];
                textBox_ID.Text = row.Cells[0].Value.ToString();
                textBox_Name.Text = row.Cells[1].Value.ToString();
                textBox_Salary.Text = row.Cells[2].Value.ToString();
                textBox_Status.Text = row.Cells[3].Value.ToString();
                textBox_Tip.Text = row.Cells[4].Value.ToString();
                label_date.Text= row.Cells[7].Value.ToString();
            }
        }

        private void pictureBox_Update_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView_vacancies);
            clearFields();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedRowVAC >= 0)
            {
                DataGridViewRow row = dataGridView_vacancies.Rows[selectedRowVAC];
                string description = row.Cells[5].Value.ToString();
                string requirements = row.Cells[6].Value.ToString();

                MessageBox.Show($"Опис: \n{description}\n \nВимоги: \n{requirements}", "Деталі вакансії", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_addVacancy_Click(object sender, EventArgs e)
        {
            VacancyAdder vcn = new VacancyAdder();
            vcn.Show();
            clearFields();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from Вакансії where concat (Ід, Назва, ДатаДодавання, Опис, Вимоги, ТипЗайнятості, Статус, МісцеРоботи, ЗаробітнаПлата) like '%"+textBox_search.Text+"%'";
            SqlCommand command= new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }

            reader.Close();
        }
        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView_vacancies);
        }
        private void deleteRow()
        {
            int index = dataGridView_vacancies.CurrentCell.RowIndex;

            dataGridView_vacancies.Rows[index].Visible = false;

            if (dataGridView_vacancies.Rows[index].Cells[0].Value.ToString()==string.Empty)
            {
                dataGridView_vacancies.Rows[index].Cells[8].Value=rowState.Deleted;
                return;
            }
            dataGridView_vacancies.Rows[index].Cells[8].Value = rowState.Deleted;
        }

        private void btn_delVacancy_Click(object sender, EventArgs e)
        {
            deleteRow();
            clearFields();
        }
        private void updateChanges()
        {
            database.openConnection();
            for(int i = 0; i<dataGridView_vacancies.Rows.Count; i++)
            {
                var RowState = (rowState)dataGridView_vacancies.Rows[i].Cells[8].Value;
                if (RowState == rowState.Existed)
                {
                    continue;
                }
                if (RowState == rowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView_vacancies.Rows[i].Cells[0].Value);
                    var deleteQuery = $"delete from Вакансії where Ід = {id}";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if(RowState==rowState.Modified)
                {
                    var id = dataGridView_vacancies.Rows[i].Cells[0].Value.ToString();
                    var name = dataGridView_vacancies.Rows[i].Cells[1].Value.ToString();
                    var salary = dataGridView_vacancies.Rows[i].Cells[2].Value.ToString();
                    var status = dataGridView_vacancies.Rows[i].Cells[3].Value.ToString();
                    var typ = dataGridView_vacancies.Rows[i].Cells[4].Value.ToString();



                    var changeQuery = $"update Вакансії set Назва = '{name}', Статус = '{status}' , ТипЗайнятості = '{typ}', ЗаробітнаПлата = '{salary}' where Ід = '{id}'";
                    var command=new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Зміни збережено");
            database.closeConnection();
        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            updateChanges();
            clearFields();
        }
        private void Change()
        {
            var selectedRowIndex=dataGridView_vacancies.CurrentCell.RowIndex;
            var id = textBox_ID.Text;
            var name = textBox_Name.Text;
            var status = textBox_Status.Text;
            var typ = textBox_Tip.Text;
            decimal salary;

            if (dataGridView_vacancies.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (decimal.TryParse(textBox_Salary.Text, out salary)) { 
                    dataGridView_vacancies.Rows[selectedRowIndex].SetValues(id, name, salary, status, typ);
                    dataGridView_vacancies.Rows[selectedRowIndex].Cells[8].Value=rowState.Modified;
            } else
                {
                    MessageBox.Show("Зарплата повинна мати числовий формат!");
                }
            }

        }
        private void btn_editVacancy_Click(object sender, EventArgs e)
        {
            Change();
            clearFields();
        }
        private void clearFields()
        {
            textBox_ID.Text = "";
            textBox_Name.Text = "";
            textBox_Salary.Text = "";
            textBox_Status.Text = "";
            textBox_Tip.Text = "";
            label_date.Text = "";
        }

        private void pictureBox_Clean_Click(object sender, EventArgs e)
        {
            clearFields();
        }


        /*_____________________ЗАЯВКИ_____________________________________________________*/

        private void CreateColumnsRec()
        {
            dataGridView_rec.Columns.Clear();
            dataGridView_rec.Columns.Add("Ід", "ID");
            dataGridView_rec.Columns.Add("ДатаПодачі", "Дата подачі");
            dataGridView_rec.Columns.Add("Статус", "Статус");
            dataGridView_rec.Columns.Add("ІдБезробітного", "ID Безробітного");
            dataGridView_rec.Columns.Add("ІдВакансії", "ID Вакансії");
            dataGridView_rec.Columns.Add("Info", String.Empty);
        }
        private void ReadSingleRowRec(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetInt32(0),
                         record.GetDateTime(1),
                         record.GetString(2),
                         record.GetInt32(3),
                         record.GetInt32(4),
                         rowState.ModifiedNew);
        }
        private void RefreshDataGridRec(DataGridView dwg)
        {
            dwg.Rows.Clear();
            string querystring = "SELECT * FROM Заявки";
            SqlCommand command = new SqlCommand(querystring, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRowRec(dwg, reader);
            }
            reader.Close();
            database.closeConnection();
        }

        private void dataGridView_rec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowUN = e.RowIndex;
            if (selectedRowUN >= 0)
            {
                DataGridViewRow row = dataGridView_rec.Rows[selectedRowUN];
                textBox_idUREC.Text = row.Cells[0].Value.ToString();
                labe_.Text = row.Cells[1].Value.ToString();
                textBox_statusRec.Text = row.Cells[2].Value.ToString();
                textBox_idBezrob.Text = row.Cells[3].Value.ToString();
                textBox_idVacans.Text = row.Cells[4].Value.ToString();
            }
        }

        private void button_newRec_Click(object sender, EventArgs e)
        {
            RecAdder r = new RecAdder();
            r.Show();
            clearFields();
        }
        private void ChangeRec()
        {
            var selectedRowIndex = dataGridView_rec.CurrentCell.RowIndex;
            int id;
            int idUn;
            var status = textBox_statusRec.Text;
            int idVac;
            var date= labe_.Text;

            if (dataGridView_rec.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox_idUREC.Text, out id) && int.TryParse(textBox_idBezrob.Text, out idUn) && int.TryParse(textBox_idVacans.Text, out idVac))
                {
                    dataGridView_rec.Rows[selectedRowIndex].SetValues(id, date, status, idUn, idVac);
                    dataGridView_rec.Rows[selectedRowIndex].Cells[5].Value = rowState.Modified;
                }
                else
                {
                    MessageBox.Show("Всі ID повинні мати числовий формат!");
                }
            }

        }
        private void button_edit_Click(object sender, EventArgs e)
        {
            ChangeRec();
            clearFieldsRec();
        }
        private void deleteRowRec()
        {
            int index = dataGridView_rec.CurrentCell.RowIndex;

            dataGridView_rec.Rows[index].Visible = false;

            if (dataGridView_rec.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView_rec.Rows[index].Cells[5].Value = rowState.Deleted;
                return;
            }
            dataGridView_rec.Rows[index].Cells[5].Value = rowState.Deleted;
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            deleteRowRec();
            clearFieldsRec();
        }
        private void updateChangesRec()
        {
            database.openConnection();
            for (int i = 0; i < dataGridView_rec.Rows.Count; i++)
            {
                var RowState = (rowState)dataGridView_rec.Rows[i].Cells[5].Value;
                if (RowState == rowState.Existed)
                {
                    continue;
                }
                if (RowState == rowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView_rec.Rows[i].Cells[0].Value);
                    var deleteQuery = $"delete from Заявки where Ід = {id}";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (RowState == rowState.Modified)
                {
                    var id = dataGridView_rec.Rows[i].Cells[0].Value.ToString();
                    var date = dataGridView_rec.Rows[i].Cells[1].Value.ToString();
                    var status = dataGridView_rec.Rows[i].Cells[2].Value.ToString();
                    var idUn = dataGridView_rec.Rows[i].Cells[3].Value.ToString();
                    var idVac = dataGridView_rec.Rows[i].Cells[4].Value.ToString();
                    

                    var changeQuery = $"update Заявки set ДатаПодачі = '{date}', Статус = '{status}' , ІдВакансії = '{idVac}', ІдБезробітного = '{idUn}' where Ід = '{id}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Зміни збережено");
            database.closeConnection();
        }
        private void button_saveChange_Click(object sender, EventArgs e)
        {
            updateChangesRec();
            clearFieldsRec();
        }
        private void clearFieldsRec () {
            textBox_idUREC.Text = "";
            labe_.Text = "";
            textBox_statusRec.Text = "";
            textBox_idBezrob.Text = "";
            textBox_idVacans.Text = "";
        }

        private void pictureBox_updateRec_Click(object sender, EventArgs e)
        {
            RefreshDataGridRec(dataGridView_rec);
            clearFieldsRec();
        }
        private void SearchRec(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from Заявки where concat (Ід, ДатаПодачі, Статус, ІдБезробітного, ІдВакансії) like '%" + textBox_searchRec.Text + "%'";
            SqlCommand command = new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRowRec(dgw, reader);
            }

            reader.Close();
        }
        private void textBox_searchRec_TextChanged(object sender, EventArgs e)
        {
            SearchRec(dataGridView_rec);
        }

        private void btn_ShowVacancy_Click(object sender, EventArgs e)
        {
            int vacancyId;
            if (int.TryParse(textBox_idVacans.Text, out vacancyId))
            {
                string querystring = $"SELECT * FROM Вакансії WHERE Ід = {vacancyId}";
                SqlCommand command = new SqlCommand(querystring, database.getConnection());

                try
                {
                    database.openConnection();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string Назва = reader["Назва"].ToString();
                        string Опис = reader["Опис"].ToString();
                        decimal ЗаробітнаПлата = Convert.ToDecimal(reader["ЗаробітнаПлата"]);
                        string Вимоги = reader["Вимоги"].ToString();
                        DateTime ДатаДодавання = Convert.ToDateTime(reader["ДатаДодавання"]);
                        string ТипЗайнятості = reader["ТипЗайнятості"].ToString();
                        string Статус = reader["Статус"].ToString();
                        string МісцеРоботи = reader["МісцеРоботи"].ToString();

                        MessageBox.Show($"Інформація про вакансію:\n\nНазва: {Назва}\nОпис: {Опис}\nЗаробітна плата: {ЗаробітнаПлата}\nВимоги: {Вимоги}\nДата додавання: {ДатаДодавання.ToShortDateString()}\nТип зайнятості: {ТипЗайнятості}\nСтатус: {Статус}\nМісце роботи: {МісцеРоботи}");
                    }
                    else
                    {
                        MessageBox.Show("Вакансія з таким Ід не знайдена.");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}");
                }
                finally
                {
                    database.closeConnection();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректний Ід вакансії.");
            }
        }


        private void btn_ShowUnemployed_Click(object sender, EventArgs e)
        {
            int unemployedId;
            if (int.TryParse(textBox_idBezrob.Text, out unemployedId))
            {
                string querystring = $"SELECT * FROM Безробітні WHERE Ід = {unemployedId}";
                SqlCommand command = new SqlCommand(querystring, database.getConnection());

                try
                {
                    database.openConnection();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string ПІБ = reader["ПІБ"].ToString();
                        DateTime ДатаНародження = Convert.ToDateTime(reader["ДатаНародження"]);
                        string НомерТелефону = reader["НомерТелефону"].ToString();
                        string Пошта = reader["Пошта"].ToString();
                        string Адреса = reader["Адреса"].ToString();
                        string РівеньОсвіти = reader["РівеньОсвіти"].ToString();
                        string Статус = reader["Статус"].ToString();
                        DateTime ДатаПостановкиОбліку = Convert.ToDateTime(reader["ДатаПостановкиОбліку"]);

                        MessageBox.Show($"Інформація про безробітного:\n\nПІБ: {ПІБ}\nДата народження: {ДатаНародження.ToShortDateString()}\nТелефон: {НомерТелефону}\nПошта: {Пошта}\nАдреса: {Адреса}\nРівень освіти: {РівеньОсвіти}\nСтатус: {Статус}\nДата постановки на облік: {ДатаПостановкиОбліку.ToShortDateString()}");
                    }
                    else
                    {
                        MessageBox.Show("Безробітний з таким Ід не знайдений.");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка: {ex.Message}");
                }
                finally
                {
                    database.closeConnection();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректний Ід безробітного.");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            clearFieldsRec();   
        }

        /*_____________________БЕЗРОБІТНІ_____________________________________________________*/


        private void CreateColumnsUN()
        {
            dataGridView_unemployed.Columns.Add("Ід", "ID");
            dataGridView_unemployed.Columns.Add("ПІБ", "ПІБ");
            dataGridView_unemployed.Columns.Add("НомерТелефону", "Номер телефону");
            dataGridView_unemployed.Columns.Add("Пошта", "Пошта");
            dataGridView_unemployed.Columns.Add("Адреса", "Адреса");
            dataGridView_unemployed.Columns.Add("Статус", "Статус");
            dataGridView_unemployed.Columns.Add("ДатаПостановкиОбліку", "Дата");
            dataGridView_unemployed.Columns.Add("РівеньОсвіти", "Рівень освіти");
            dataGridView_unemployed.Columns.Add("Info", String.Empty);
        }
        private void ReadSingleRowUN(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), record.GetDateTime(7), record.GetString(8), rowState.ModifiedNew);

        }

        private void RefreshDataGridUN(DataGridView dwg)
        {
            dwg.Rows.Clear();
            string querystring = $"select * from Безробітні";
            SqlCommand command = new SqlCommand(querystring, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRowUN(dwg, reader);
            }
            reader.Close();
        }

        private void dataGridView_unemployed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowUN = e.RowIndex;
            if (selectedRowUN >= 0)
            {
                DataGridViewRow row = dataGridView_unemployed.Rows[selectedRowUN];
                textBox_idUnempl.Text = row.Cells[0].Value.ToString();
                textBox_PIB.Text = row.Cells[1].Value.ToString();
                textBox_phoneNum.Text = row.Cells[2].Value.ToString();
                textBox_poshta.Text = row.Cells[3].Value.ToString();
                textBox_addressUn.Text = row.Cells[4].Value.ToString();
                textBox_statusUn.Text = row.Cells[5].Value.ToString();
                label_dateOblik.Text = row.Cells[6].Value.ToString();
            }
        }

        private void pictureBox_updateUn_Click(object sender, EventArgs e)
        {
            RefreshDataGridUN(dataGridView_unemployed);
            clearFields();
        }

        private void btn_showDetails_Click(object sender, EventArgs e)
        {
            if (dataGridView_unemployed.CurrentCell != null && dataGridView_unemployed.CurrentCell.RowIndex >= 0)
            {
                int selectedRowIndex = dataGridView_unemployed.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridView_unemployed.Rows[selectedRowIndex];
                int bezrobId = Convert.ToInt32(selectedRow.Cells[0].Value);

                try
                {
                    database.openConnection();
                    string query = "SELECT s.Назва, bs.Досвід " +
                                   "FROM БезробітнийСпеціальність bs " +
                                   "JOIN Спеціальності s ON bs.ІдСпеціальності = s.Ід " +
                                   "WHERE bs.ІдБезробітного = @bezrobId";

                    SqlCommand command = new SqlCommand(query, database.getConnection());
                    command.Parameters.AddWithValue("@bezrobId", bezrobId);

                    SqlDataReader reader = command.ExecuteReader();

                    StringBuilder message = new StringBuilder();
                    while (reader.Read())
                    {
                        string specialty = reader["Назва"].ToString();
                        int experience = Convert.ToInt32(reader["Досвід"]);
                        message.AppendLine($"Спеціальність: {specialty}\nДосвід: {experience} роки/ів\n");
                    }

                    reader.Close();

                    if (message.Length > 0)
                    {
                        MessageBox.Show(message.ToString(), "Інформація про спеціальності", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Цей безробітний не має зареєстрованих спеціальностей.", "Інформація про спеціальності", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Виникла помилка: " + ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    database.closeConnection();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть безробітного зі списку.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void btn_newUn_Click(object sender, EventArgs e)
        {
            UnAdder un = new UnAdder();
            un.Show();
            clearFields();
        }
        private void ChangeUN()
        {
            var selectedRowIndex = dataGridView_unemployed.CurrentCell.RowIndex;
            var id = textBox_idUnempl.Text;
            var pib = textBox_PIB.Text;
            var num = textBox_phoneNum.Text;
            var pos = textBox_poshta.Text;
            var adr = textBox_addressUn.Text;
            var stat = textBox_statusUn.Text;


            if (dataGridView_unemployed.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {

                dataGridView_unemployed.Rows[selectedRowIndex].SetValues(id, pib, num, pos, adr, stat);
                dataGridView_unemployed.Rows[selectedRowIndex].Cells[8].Value = rowState.Modified;

            }

        }
        private void btn_editUn_Click(object sender, EventArgs e)
        {
            ChangeUN();
            clearFieldsUN();
        }
        private void clearFieldsUN()
        {
            textBox_idUnempl.Text = "";
            textBox_PIB.Text = "";
            textBox_phoneNum.Text = "";
            textBox_poshta.Text = "";
            textBox_addressUn.Text = "";
            textBox_statusUn.Text = "";
            label_dateOblik.Text = "";
        }
        private void btn_delUn_Click(object sender, EventArgs e)
        {
            deleteRowUN();
            clearFieldsUN();
        }
        private void deleteRowUN()
        {
            int index = dataGridView_unemployed.CurrentCell.RowIndex;

            dataGridView_unemployed.Rows[index].Visible = false;

            if (dataGridView_unemployed.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView_unemployed.Rows[index].Cells[8].Value = rowState.Deleted;
                return;
            }
            dataGridView_unemployed.Rows[index].Cells[8].Value = rowState.Deleted;
        }

        private void updateChangesUN()
        {
            database.openConnection();
            for (int i = 0; i < dataGridView_unemployed.Rows.Count; i++)
            {
                var RowState = (rowState)dataGridView_unemployed.Rows[i].Cells[8].Value;
                if (RowState == rowState.Existed)
                {
                    continue;
                }
                if (RowState == rowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView_unemployed.Rows[i].Cells[0].Value);

                    // Видалення записів з таблиці БезробітнийСпеціальність перед видаленням з таблиці Безробітні
                    var deleteSpecQuery = $"DELETE FROM БезробітнийСпеціальність WHERE ІдБезробітного = {id}";
                    var specCommand = new SqlCommand(deleteSpecQuery, database.getConnection());
                    specCommand.ExecuteNonQuery();

                    var deleteQuery = $"DELETE FROM Безробітні WHERE Ід = {id}";
                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();

                }

                if (RowState == rowState.Modified)
                {
                    var id = dataGridView_unemployed.Rows[i].Cells[0].Value.ToString();
                    var pib = dataGridView_unemployed.Rows[i].Cells[1].Value.ToString();
                    var tel = dataGridView_unemployed.Rows[i].Cells[2].Value.ToString();
                    var pos = dataGridView_unemployed.Rows[i].Cells[3].Value.ToString();
                    var adr = dataGridView_unemployed.Rows[i].Cells[4].Value.ToString();
                    var st = dataGridView_unemployed.Rows[i].Cells[5].Value.ToString();

                    var changeQuery = $"UPDATE Безробітні SET ПІБ = '{pib}', НомерТелефону = '{tel}', Пошта = '{pos}', Адреса = '{adr}', Статус = '{st}' WHERE Ід = '{id}'";
                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Зміни збережено");
            database.closeConnection();
        }

        private void btn_saveUn_Click(object sender, EventArgs e)
        {
            updateChangesUN();
            clearFieldsUN();
        }
        private void SearchUN(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from Безробітні where concat (Ід, ПІБ, НомерТелефону, Пошта, Адреса, Статус, ДатаПостановкиОбліку) like '%" + textBox_searchUn.Text + "%'";
            SqlCommand command = new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRowUN(dgw, reader);
            }

            reader.Close();
        }
        private void textBox_searchUn_TextChanged(object sender, EventArgs e)
        {
            SearchUN(dataGridView_unemployed);
        }

        private void pictureBox_clear_Click(object sender, EventArgs e)
        {
            clearFieldsUN();
        }

        /*_____________________КУРСИ_____________________________________________________*/
        private DataGridViewRow selectedUnemployedRow;
        private DataGridViewRow selectedCourseRow;
        private void CreateColumnsB()
        {
            dataGridView_B.Columns.Add("Ід", "ID");
            dataGridView_B.Columns.Add("ПІБ", "ПІБ");
            dataGridView_B.Columns.Add("НомерТелефону", "Номер телефону");
            dataGridView_B.Columns.Add("Пошта", "Пошта");
            dataGridView_B.Columns.Add("Адреса", "Адреса");
            dataGridView_B.Columns.Add("Статус", "Статус");
            dataGridView_B.Columns.Add("ДатаПостановкиОбліку", "Дата");
            dataGridView_B.Columns.Add("РівеньОсвіти", "Рівень освіти");
            dataGridView_B.Columns.Add("Info", String.Empty);
        }
        private void SearchB(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from Безробітні where concat (Ід, ПІБ, НомерТелефону, Пошта, Адреса, Статус, ДатаПостановкиОбліку) like '%" + textBox_SearchB.Text + "%'";
            SqlCommand command = new SqlCommand(searchString, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRowUN(dgw, reader);
            }

            reader.Close();
        }
        private void SearchKU(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchText = textBox_SearchKU.Text;
            string searchString = @"
        SELECT 
            k.Ід AS ІдКурсу, 
            k.Назва AS НазваКурсу, 
            k.Опис AS ОписКурсу, 
            k.ДатаПочатку, 
            k.ДатаЗавершення, 
            k.КількістьУчасників, 
            s.Назва AS НазваСпеціальності
        FROM Курси k
        JOIN СпеціальністьКурс sk ON k.Ід = sk.ІдКурсу
        JOIN Спеціальності s ON sk.ІдСпеціальності = s.Ід
        WHERE 
            CONCAT(k.Ід, k.Назва, k.Опис, k.ДатаПочатку, k.ДатаЗавершення, k.КількістьУчасників, s.Назва) 
            LIKE @searchText";

            SqlCommand command = new SqlCommand(searchString, database.getConnection());
            command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowKU(dgw, reader);
            }

            reader.Close();
            database.closeConnection();
        }

        private void textBox_SearchB_TextChanged(object sender, EventArgs e)
        {
            SearchB(dataGridView_B);
        }

        private void dataGridView_B_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowUN = e.RowIndex;
            if (selectedRowUN >= 0 && selectedRowUN < dataGridView_B.Rows.Count)
            {
                selectedUnemployedRow = dataGridView_B.Rows[selectedRowUN];
                if (selectedUnemployedRow.Cells[0].Value != null)
                {
                    textBox_BB.Text = selectedUnemployedRow.Cells[0].Value.ToString();
                }
                else
                {
                    textBox_BB.Text = "";
                }
            }
            else
            {
                textBox_BB.Text = "";
                selectedUnemployedRow = null;
            }
        }
        private void CreateColumnsKU()
        {
            dataGridView_KU.Columns.Add("ІдКурсу", "ID Курсу");
            dataGridView_KU.Columns.Add("НазваКурсу", "Назва Курсу");
            dataGridView_KU.Columns.Add("ОписКурсу", "Опис Курсу");
            dataGridView_KU.Columns.Add("ДатаПочатку", "Дата Початку");
            dataGridView_KU.Columns.Add("ДатаЗавершення", "Дата Завершення");
            dataGridView_KU.Columns.Add("КількістьУчасників", "Кількість Учасників");
            dataGridView_KU.Columns.Add("НазваСпеціальності", "Назва Спеціальності");
        }
        private void ReadSingleRowKU(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(
                record.GetInt32(0),  // ІдКурсу
                record.GetString(1), // НазваКурсу
                record.GetString(2), // ОписКурсу
                record.GetDateTime(3), // ДатаПочатку
                record.GetDateTime(4), // ДатаЗавершення
                record.GetInt32(5),  // КількістьУчасників
                record.GetString(6)  // НазваСпеціальності
            );
        }
        private void RefreshDataGridKU(DataGridView dwg)
        {
            dwg.Rows.Clear();
            string querystring = @"
        SELECT 
            k.Ід AS ІдКурсу, 
            k.Назва AS НазваКурсу, 
            k.Опис AS ОписКурсу, 
            k.ДатаПочатку, 
            k.ДатаЗавершення, 
            k.КількістьУчасників, 
            s.Назва AS НазваСпеціальності
        FROM Курси k
        JOIN СпеціальністьКурс sk ON k.Ід = sk.ІдКурсу
        JOIN Спеціальності s ON sk.ІдСпеціальності = s.Ід";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowKU(dwg, reader);
            }

            reader.Close();
            database.closeConnection();
        }

        private void textBox_SearchKU_TextChanged(object sender, EventArgs e)
        {
            SearchKU(dataGridView_KU);
        }

        private void dataGridView_KU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowKU = e.RowIndex;
            if (selectedRowKU >= 0 && selectedRowKU < dataGridView_KU.Rows.Count)
            {
                selectedCourseRow = dataGridView_KU.Rows[selectedRowKU];
                if (selectedCourseRow.Cells[0].Value != null)
                {
                    textBox_KUU.Text = selectedCourseRow.Cells[0].Value.ToString();
                }
                else
                {
                    textBox_KUU.Text = "";
                }
            }
            else
            {
                textBox_KUU.Text = "";
                selectedCourseRow = null;
            }
        }


        private void button_demoData_Click(object sender, EventArgs e)
        {
            if (selectedUnemployedRow != null && selectedCourseRow != null)
            {
                // Форматування і відображення інформації про обраного безробітного
                string unemployedInfo = $"ID: {selectedUnemployedRow.Cells["Ід"].Value}\n" +
                                        $"ПІБ: {selectedUnemployedRow.Cells["ПІБ"].Value}\n" +
                                        $"Номер телефону: {selectedUnemployedRow.Cells["НомерТелефону"].Value}\n" +
                                        $"Пошта: {selectedUnemployedRow.Cells["Пошта"].Value}\n" +
                                        $"Адреса: {selectedUnemployedRow.Cells["Адреса"].Value}\n" +
                                        $"Статус: {selectedUnemployedRow.Cells["Статус"].Value}\n" +
                                        $"Дата постановки на облік: {selectedUnemployedRow.Cells["ДатаПостановкиОбліку"].Value}\n" +
                                        $"Рівень освіти: {selectedUnemployedRow.Cells["РівеньОсвіти"].Value}";

                // Форматування і відображення інформації про обраний курс
                string courseInfo = $"ID Курсу: {selectedCourseRow.Cells["ІдКурсу"].Value}\n" +
                                    $"Назва Курсу: {selectedCourseRow.Cells["НазваКурсу"].Value}\n" +
                                    $"Опис Курсу: {selectedCourseRow.Cells["ОписКурсу"].Value}\n" +
                                    $"Дата Початку: {selectedCourseRow.Cells["ДатаПочатку"].Value}\n" +
                                    $"Дата Завершення: {selectedCourseRow.Cells["ДатаЗавершення"].Value}\n" +
                                    $"Кількість Учасників: {selectedCourseRow.Cells["КількістьУчасників"].Value}\n" +
                                    $"Назва Спеціальності: {selectedCourseRow.Cells["НазваСпеціальності"].Value}";

                // Відображення інформації у MessageBox або іншому елементі
                MessageBox.Show($"Інформація про безробітного:\n\n{unemployedInfo}\n\nІнформація про курс:\n\n{courseInfo}", "Детальна інформація");
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть безробітного та курс.", "Помилка");
            }
        }

        private void button_registerOnKU_Click(object sender, EventArgs e)
        {
            if (selectedUnemployedRow != null && selectedCourseRow != null)
            {
                try
                {
                    // Отримання ID безробітного та курсу
                    int idUnemployed = Convert.ToInt32(selectedUnemployedRow.Cells["Ід"].Value);
                    int idCourse = Convert.ToInt32(selectedCourseRow.Cells["ІдКурсу"].Value);

                    // Перевірка, чи вже зареєстровано безробітного на курсі
                    string checkQuery = @"
            SELECT COUNT(*)
            FROM БезробітнийКурс
            WHERE ІдКурсу = @idCourse AND ІдБезробітного = @idUnemployed";

                    SqlCommand checkCommand = new SqlCommand(checkQuery, database.getConnection());
                    checkCommand.Parameters.AddWithValue("@idCourse", idCourse);
                    checkCommand.Parameters.AddWithValue("@idUnemployed", idUnemployed);

                    database.openConnection();
                    int count = (int)checkCommand.ExecuteScalar();
                    database.closeConnection();

                    if (count > 0)
                    {
                        MessageBox.Show("Безробітного вже зареєстровано на цьому курсі.", "Помилка");
                        return;
                    }

                    // Перевірка ліміту учасників
                    string limitQuery = @"
            SELECT COUNT(bk.ІдБезробітного)
            FROM БезробітнийКурс bk
            WHERE bk.ІдКурсу = @idCourse";

                    SqlCommand limitCommand = new SqlCommand(limitQuery, database.getConnection());
                    limitCommand.Parameters.AddWithValue("@idCourse", idCourse);

                    database.openConnection();
                    int registeredCount = (int)limitCommand.ExecuteScalar();
                    database.closeConnection();

                    int participantLimit = Convert.ToInt32(selectedCourseRow.Cells["КількістьУчасників"].Value);
                    if (registeredCount >= participantLimit)
                    {
                        MessageBox.Show("Кількість зареєстрованих учасників перевищує ліміт.", "Помилка");
                        return;
                    }

                    // SQL-запит для вставки запису в таблицю БезробітнийКурс
                    string insertQuery = @"
            INSERT INTO БезробітнийКурс (ІдКурсу, ІдБезробітного)
            VALUES (@idCourse, @idUnemployed)";

                    SqlCommand command = new SqlCommand(insertQuery, database.getConnection());
                    command.Parameters.AddWithValue("@idCourse", idCourse);
                    command.Parameters.AddWithValue("@idUnemployed", idUnemployed);

                    // Відкриття з'єднання, виконання запиту та закриття з'єднання
                    database.openConnection();
                    command.ExecuteNonQuery();
                    database.closeConnection();

                    // Повідомлення про успішну реєстрацію
                    MessageBox.Show("Безробітного успішно зареєстровано на курсі.", "Успіх");
                    button_demo_Click(sender, e);
                }
                catch (Exception ex)
                {
                    // Повідомлення про помилку
                    MessageBox.Show($"Сталася помилка під час реєстрації: {ex.Message}", "Помилка");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть безробітного та курс перед реєстрацією.", "Помилка");
            }
        }


        private void CreateColumnsKursBezrob()
        {
            dataGridView_KursBezrob.Columns.Add("Ід", "ID");
            dataGridView_KursBezrob.Columns.Add("ПІБ", "ПІБ");
            dataGridView_KursBezrob.Columns.Add("НомерТелефону", "Номер телефону");
            dataGridView_KursBezrob.Columns.Add("Пошта", "Пошта");
            dataGridView_KursBezrob.Columns.Add("Адреса", "Адреса");
            dataGridView_KursBezrob.Columns.Add("Статус", "Статус");
            dataGridView_KursBezrob.Columns.Add("ДатаПостановкиОбліку", "Дата постановки на облік");
            dataGridView_KursBezrob.Columns.Add("РівеньОсвіти", "Рівень освіти");
        }

        private void button_demo_Click(object sender, EventArgs e)
        {
            if (selectedCourseRow != null)
            {
                try
                {
                    // Отримання ID курсу
                    int idCourse = Convert.ToInt32(selectedCourseRow.Cells["ІдКурсу"].Value);

                    // SQL-запит для отримання безробітних, зареєстрованих на курсі
                    string query = @"
                SELECT 
                    b.Ід, 
                    b.ПІБ, 
                    b.НомерТелефону, 
                    b.Пошта, 
                    b.Адреса, 
                    b.Статус, 
                    b.ДатаПостановкиОбліку, 
                    b.РівеньОсвіти 
                FROM Безробітні b
                JOIN БезробітнийКурс bk ON b.Ід = bk.ІдБезробітного
                WHERE bk.ІдКурсу = @idCourse";

                    SqlCommand command = new SqlCommand(query, database.getConnection());
                    command.Parameters.AddWithValue("@idCourse", idCourse);

                    // Відкриття з'єднання
                    database.openConnection();
                    SqlDataReader reader = command.ExecuteReader();

                    // Очищення DataGridView перед додаванням нових рядків
                    dataGridView_KursBezrob.Rows.Clear();

                    // Заповнення DataGridView
                    while (reader.Read())
                    {
                        dataGridView_KursBezrob.Rows.Add(
                            reader.GetInt32(0),  // Ід
                            reader.GetString(1), // ПІБ
                            reader.GetString(2), // НомерТелефону
                            reader.GetString(3), // Пошта
                            reader.GetString(4), // Адреса
                            reader.GetString(5), // Статус
                            reader.GetDateTime(6), // ДатаПостановкиОбліку
                            reader.GetString(7)  // РівеньОсвіти
                        );
                    }

                    // Закриття з'єднання та reader
                    reader.Close();
                    database.closeConnection();
                }
                catch (Exception ex)
                {
                    // Повідомлення про помилку
                    MessageBox.Show($"Сталася помилка під час отримання даних: {ex.Message}", "Помилка");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть курс перед відображенням переліку безробітних.", "Помилка");
            }
        }

        private void button_deleteFromKU_Click(object sender, EventArgs e)
        {
            if (selectedUnemployedRow != null && selectedCourseRow != null)
            {
                try
                {
                    // Отримання ID безробітного та курсу
                    int idUnemployed = Convert.ToInt32(selectedUnemployedRow.Cells["Ід"].Value);
                    int idCourse = Convert.ToInt32(selectedCourseRow.Cells["ІдКурсу"].Value);

                    // SQL-запит для видалення запису з таблиці БезробітнийКурс
                    string deleteQuery = @"
            DELETE FROM БезробітнийКурс
            WHERE ІдКурсу = @idCourse AND ІдБезробітного = @idUnemployed";

                    SqlCommand command = new SqlCommand(deleteQuery, database.getConnection());
                    command.Parameters.AddWithValue("@idCourse", idCourse);
                    command.Parameters.AddWithValue("@idUnemployed", idUnemployed);

                    // Відкриття з'єднання, виконання запиту та закриття з'єднання
                    database.openConnection();
                    int rowsAffected = command.ExecuteNonQuery();
                    database.closeConnection();

                    if (rowsAffected > 0)
                    {
                        // Повідомлення про успішне видалення
                        MessageBox.Show("Безробітного успішно видалено з курсу.", "Успіх");
                        // Оновлення даних у DataGridView
                        button_demo_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Безробітного не знайдено на курсі.", "Помилка");
                    }
                }
                catch (Exception ex)
                {
                    // Повідомлення про помилку
                    MessageBox.Show($"Сталася помилка під час видалення: {ex.Message}", "Помилка");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть безробітного та курс перед видаленням.", "Помилка");
            }
        }

    }
}
