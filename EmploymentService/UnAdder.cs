using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmploymentService
{
    public partial class UnAdder : Form
    {
        private readonly Database _database = new Database();

        public UnAdder()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            LoadSpecialties();
        }
        private void UnAdder_Load(object sender, EventArgs e)
        {
        }
        private void LoadSpecialties()
        {
            const string specialtiesQuery = "SELECT Ід, Назва FROM Спеціальності";
            try
            {
                var specialtiesTable = GetDataTable(specialtiesQuery);
                comboBox_Specialty.DataSource = specialtiesTable;
                comboBox_Specialty.DisplayMember = "Назва";
                comboBox_Specialty.ValueMember = "Ід";
            }
            catch (Exception ex)
            {
                ShowError("Помилка завантаження спеціальностей", ex);
            }
        }

        private DataTable GetDataTable(string query)
        {
            using (var command = new SqlCommand(query, _database.getConnection()))
            {
                var adapter = new SqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        private void btn_AddVac_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs(out int dosvid)) return;

            try
            {
                _database.openConnection();
                int newId = InsertBezrob(pib: textBox_PIB.Text, phone: textBox_phoneNum.Text, poshta: textBox_poshta.Text,
                                         address: textBox_addressUn.Text, status: textBox_statusUn.Text,
                                         rivenOsv: textBox_riven.Text, dateBirth: dateTimePicker_BIRTH.Value,
                                         dateAdd: dateTimePicker_Date.Value);
                InsertBezrobSpecialty(newId, (int)comboBox_Specialty.SelectedValue, dosvid);
                MessageBox.Show("Безробітного успішно додано", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlEx)
            {
                ShowError("Виникла помилка бази даних", sqlEx);
            }
            catch (Exception ex)
            {
                ShowError("Виникла помилка", ex);
            }
            finally
            {
                _database.closeConnection();
            }
        }

        private bool ValidateInputs(out int dosvid)
        {
            dosvid = 0;
            if (string.IsNullOrWhiteSpace(textBox_PIB.Text) ||
                string.IsNullOrWhiteSpace(textBox_phoneNum.Text) ||
                string.IsNullOrWhiteSpace(textBox_poshta.Text) ||
                string.IsNullOrWhiteSpace(textBox_addressUn.Text) ||
                string.IsNullOrWhiteSpace(textBox_statusUn.Text) ||
                string.IsNullOrWhiteSpace(textBox_riven.Text) ||
                comboBox_Specialty.SelectedValue == null ||
                !int.TryParse(textBox_dosvid.Text, out dosvid))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля правильно.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private int InsertBezrob(string pib, string phone, string poshta, string address, string status, string rivenOsv, DateTime dateBirth, DateTime dateAdd)
        {
            const string addQuery = @"
                INSERT INTO Безробітні (ПІБ, НомерТелефону, Пошта, Адреса, Статус, РівеньОсвіти, ДатаНародження, ДатаПостановкиОбліку) 
                VALUES (@pib, @phone, @poshta, @address, @status, @rivenOsv, @dateBirth, @dateAdd);
                SELECT SCOPE_IDENTITY();";

            using (var command = new SqlCommand(addQuery, _database.getConnection()))
            {
                command.Parameters.AddWithValue("@pib", pib);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@poshta", poshta);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@rivenOsv", rivenOsv);
                command.Parameters.AddWithValue("@dateBirth", dateBirth);
                command.Parameters.AddWithValue("@dateAdd", dateAdd);

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        private void InsertBezrobSpecialty(int bezrobId, int specialtyId, int dosvid)
        {
            const string addSpecQuery = @"
                INSERT INTO БезробітнийСпеціальність (ІдБезробітного, ІдСпеціальності, Досвід) 
                VALUES (@idBezrob, @idSpec, @dosvid)";

            using (var command = new SqlCommand(addSpecQuery, _database.getConnection()))
            {
                command.Parameters.AddWithValue("@idBezrob", bezrobId);
                command.Parameters.AddWithValue("@idSpec", specialtyId);
                command.Parameters.AddWithValue("@dosvid", dosvid);
                command.ExecuteNonQuery();
            }
        }

        private void ShowError(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}


