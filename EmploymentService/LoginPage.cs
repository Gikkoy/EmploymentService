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
    public partial class LoginPage : Form
    {
        Database database = new Database();
        public LoginPage()
        {
            InitializeComponent();
            StartPosition=FormStartPosition.CenterScreen;
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '☻';
            pictureBox1_open.Visible = false;
            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var loginUser=textBox_login.Text;
            var passUser=textBox_password.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            string queryString = $"select Ід, Логін, Пароль from Реєстрація where Логін='{loginUser}' and  Пароль = '{passUser}' ";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Ви успішно увійшли!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainWindow main= new MainWindow();
                this.Hide();
                main.ShowDialog();
            }
            else MessageBox.Show("Такого акаунту не існує!", "Акаунту не існує!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            textBox_login.Text="";
            textBox_password.Text="";
        }


        private void pictureBox1_open_Click(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '\0';
            pictureBox1_open.Visible = false;
            pictureBox2_close.Visible = true;
        }

        private void pictureBox2_close_Click(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '☻';
            pictureBox1_open.Visible = true;
            pictureBox2_close.Visible = false;
        }
    }
}
