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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        Database database = new Database();
        private void Register_Load(object sender, EventArgs e)
        {
            textBox_password2.PasswordChar = '☻';
            pictureBox1_open.Visible = false;
            textBox_login2.MaxLength = 50;
            textBox_password2.MaxLength = 50;
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {

            var login = textBox_login2.Text;
            var pass = textBox_password2.Text;

            string querystring = $"insert into Реєстрація (Логін, Пароль) values('{login}', '{pass}')";
            SqlCommand command = new SqlCommand(querystring, database.getConnection());
            database.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Акаунт успішно створено!", "Успіх!");
                LoginPage loginPage = new LoginPage();
                this.Hide();
                loginPage.ShowDialog();
            }
            else MessageBox.Show("Акаунт не було створено!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            database.closeConnection();
        }
        private Boolean checkUser()
        {
            var loginUser = textBox_login2.Text;
            var password = textBox_password2.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select Ід, Логін, Пароль from Реєстрація where Логін='{loginUser}' and  Пароль = '{password}' ";
            SqlCommand command = new SqlCommand(querystring, database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Користувач вже існує");
                return true;
            } else return false;


        }

        private void pictureBox2_close_Click(object sender, EventArgs e)
        {
            textBox_password2.PasswordChar = '☻';
            pictureBox1_open.Visible = true;
            pictureBox2_close.Visible = false;
        }

        private void pictureBox1_open_Click(object sender, EventArgs e)
        {
            textBox_password2.PasswordChar = '\0';
            pictureBox1_open.Visible = false;
            pictureBox2_close.Visible = true;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            textBox_login2.Text = "";
            textBox_password2.Text = "";
        }
    }

}
