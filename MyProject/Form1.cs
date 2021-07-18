using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyProject
{
    public partial class login_form : Form
    {
        private MySqlConnection databaseConnection()
        {
            String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_001;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public login_form()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM login_table001 WHERE username = \"{username.Text}\" AND password = \"{password.Text}\"";
            

            MySqlDataReader row = cmd.ExecuteReader();
            //String name = username.Text;
            row.Read();
               
            if (row.HasRows)
            {
                Program.user = row.GetString("fname");
                Program.user2 = row.GetString("lname");
                Form2 a = new Form2();
                this.Hide();
                a.Show();
                //MessageBox.Show(" เข้าสู่ระบบสำเร็จ");
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้ หรือ รหัสผ่านไม่ถูกต้อง");
            }
            conn.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //string P = password.Text;
            //password.PasswordChar = '\0';

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string P = password.Text;
                password.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form7 a = new Form7();
            this.Hide();
            a.Show();
        }

        private void forgetpass_lebel_Click(object sender, EventArgs e)
        {
            Form8 a = new Form8();
            this.Hide();
            a.Show();
        }

        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || char.IsUpper(e.KeyChar);
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }
    }
}
