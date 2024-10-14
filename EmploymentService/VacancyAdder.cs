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
    public partial class VacancyAdder : Form
    {
        Database database = new Database();

        public VacancyAdder()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            try
            {
                // Заповнення комбобоксу спеціальностями
                var specialtiesQuery = "SELECT Ід, Назва FROM Спеціальності";
                var specialtiesCommand = new SqlCommand(specialtiesQuery, database.getConnection());
                var specialtiesAdapter = new SqlDataAdapter(specialtiesCommand);
                var specialtiesTable = new DataTable();
                specialtiesAdapter.Fill(specialtiesTable);
                comboBox_Specialty.DataSource = specialtiesTable;
                comboBox_Specialty.DisplayMember = "Назва";
                comboBox_Specialty.ValueMember = "Ід";

                // Заповнення комбобоксу роботодавцями
                var employersQuery = "SELECT Ід, НазваОрганізації FROM Роботодавці";
                var employersCommand = new SqlCommand(employersQuery, database.getConnection());
                var employersAdapter = new SqlDataAdapter(employersCommand);
                var employersTable = new DataTable();
                employersAdapter.Fill(employersTable);
                comboBox_Employer.DataSource = employersTable;
                comboBox_Employer.DisplayMember = "НазваОрганізації";
                comboBox_Employer.ValueMember = "Ід";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження даних: " + ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AddVac_Click(object sender, EventArgs e)
        {
            // Validate user input
            if (string.IsNullOrWhiteSpace(textBox_Name.Text) ||
                string.IsNullOrWhiteSpace(textBox_Status.Text) ||
                string.IsNullOrWhiteSpace(textBox_Tip.Text) ||
                string.IsNullOrWhiteSpace(textBox_Address.Text) ||
                string.IsNullOrWhiteSpace(textBox_Req.Text) ||
                string.IsNullOrWhiteSpace(textBox_Descr.Text) ||
                comboBox_Specialty.SelectedValue == null ||
                comboBox_Employer.SelectedValue == null ||
                !int.TryParse(textBox_Salary.Text, out int salary))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля правильно.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var name = textBox_Name.Text;
            var status = textBox_Status.Text;
            var typ = textBox_Tip.Text;
            var adress = textBox_Address.Text;
            var vimogi = textBox_Req.Text;
            var descr = textBox_Descr.Text;
            var date = dateTimePicker_Date.Value;
            var specialtyId = (int)comboBox_Specialty.SelectedValue;
            var employerId = (int)comboBox_Employer.SelectedValue;

            try
            {
                database.openConnection();

                var addQuery = "INSERT INTO Вакансії (Назва, ЗаробітнаПлата, Статус, ТипЗайнятості, МісцеРоботи, Вимоги, Опис, ДатаДодавання, ІдСпеціальності, ІдРоботодавця) " +
                               "VALUES (@name, @salary, @status, @typ, @adress, @vimogi, @descr, @date, @specialtyId, @employerId)";

                using (var command = new SqlCommand(addQuery, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@salary", salary);
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@typ", typ);
                    command.Parameters.AddWithValue("@adress", adress);
                    command.Parameters.AddWithValue("@vimogi", vimogi);
                    command.Parameters.AddWithValue("@descr", descr);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@specialtyId", specialtyId);
                    command.Parameters.AddWithValue("@employerId", employerId);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Вакансію успішно додано", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void VacancyAdder_Load(object sender, EventArgs e)
        {
            this.спеціальностіTableAdapter.Fill(this.dBemploymentDataSet.Спеціальності);
        }
    }
}

