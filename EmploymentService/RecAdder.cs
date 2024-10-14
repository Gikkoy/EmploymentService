using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmploymentService
{
    public partial class RecAdder : Form
    {
        Database database = new Database();
        int selectedRowVAC;
        int selectedRowUN;

        public RecAdder()
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
            string querystring = "SELECT * FROM Вакансії";
            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            try
            {
                database.openConnection();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ReadSingleRow(dwg, reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження даних вакансій: " + ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
        }

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
            string querystring = "SELECT * FROM Безробітні";
            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            try
            {
                database.openConnection();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ReadSingleRowUN(dwg, reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження даних безробітних: " + ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
        }

        private void dataGridView_unemployed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowUN = e.RowIndex;
            if (selectedRowUN >= 0)
            {
                DataGridViewRow row = dataGridView_unemployed.Rows[selectedRowUN];
                textBox_idBezrob.Text = row.Cells[0].Value.ToString();
            }
        }

        private void dataGridView_vacancies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowVAC = e.RowIndex;
            if (selectedRowVAC >= 0)
            {
                DataGridViewRow row = dataGridView_vacancies.Rows[selectedRowVAC];
                textBox_idVacans.Text = row.Cells[0].Value.ToString();
            }
        }

        private void SearchUnemployed(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = "SELECT * FROM Безробітні WHERE CONCAT(Ід, ПІБ, НомерТелефону, Пошта, Адреса, Статус, ДатаПостановкиОбліку) LIKE '%" + searchUn.Text + "%'";
            SqlCommand command = new SqlCommand(searchString, database.getConnection());

            try
            {
                database.openConnection();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ReadSingleRowUN(dgw, reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка пошуку безробітних: " + ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
        }

        private void searchUn_TextChanged(object sender, EventArgs e)
        {
            SearchUnemployed(dataGridView_unemployed);
        }

        private void SearchVacancy(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = "SELECT * FROM Вакансії WHERE CONCAT(Ід, Назва, ДатаДодавання, Опис, Вимоги, ТипЗайнятості, Статус, МісцеРоботи, ЗаробітнаПлата) LIKE '%" + searchVac.Text + "%'";
            SqlCommand command = new SqlCommand(searchString, database.getConnection());

            try
            {
                database.openConnection();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ReadSingleRow(dgw, reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка пошуку вакансій: " + ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
        }

        private void searchVac_TextChanged(object sender, EventArgs e)
        {
            SearchVacancy(dataGridView_vacancies);
        }

        private void btn_AddRec_Click(object sender, EventArgs e)
        {
            // Validate user input
            if (string.IsNullOrWhiteSpace(textBox_idBezrob.Text) ||
                string.IsNullOrWhiteSpace(textBox_idVacans.Text) ||
                string.IsNullOrWhiteSpace(textBox_statusRec.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля правильно.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox_idBezrob.Text, out int idUn) || !int.TryParse(textBox_idVacans.Text, out int idVac))
            {
                MessageBox.Show("ID повинні мати числовий формат!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var status = textBox_statusRec.Text;
            var date = dateTimePicker_Date.Value;

            try
            {
                database.openConnection();

                var addQuery = "INSERT INTO Заявки (ІдВакансії, ІдБезробітного, Статус, ДатаПодачі) " +
                               "VALUES (@idVac, @idUn, @status, @date)";

                using (var command = new SqlCommand(addQuery, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@idVac", idVac);
                    command.Parameters.AddWithValue("@idUn", idUn);
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@date", date);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Заявку успішно додано", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Виникла помилка бази даних: " + sqlEx.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void RecAdder_Load(object sender, EventArgs e)
        {
            CreateColumns();
            CreateColumnsUN();
            RefreshDataGrid(dataGridView_vacancies);
            RefreshDataGridUN(dataGridView_unemployed);
        }
    }
}

