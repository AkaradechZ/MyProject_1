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
using System.Net;
using System.Net.Mail;

namespace MyProject
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        string randomCode;
        public static string to, user;
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_001;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        private void con_otp_Box1_Click(object sender, EventArgs e)
        {
            if (randomCode == otp_textBox2.Text)
            {
                Form9 a = new Form9();
                this.Hide();
                a.Show();
            }
            else
            {
                MessageBox.Show("รหัส OTP ไม่ถูกต้อง");
            }
        }

        private void entermail_textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void otp_textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void send_otp_Box1_Click(object sender, EventArgs e)
        {
            Program.yoloemail = entermail_textBox1.Text;
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM login_table001 WHERE email=\"{entermail_textBox1.Text}\"";
            MySqlDataReader rowss = cmd.ExecuteReader();
            rowss.Read();
            if (rowss.HasRows)
            {
                Program.emailid = rowss.GetString("id");
                string from, pass, messagebody;
                Random ran = new Random();
                string randText = "0123456789";
                int Length_randText = randText.Length;
                for (int i = 0; i <= 5; i++)
                {
                    randomCode += randText[ran.Next(Length_randText)];
                }
                MailMessage message = new MailMessage();
                to = entermail_textBox1.Text.ToString();
                from = "hotdogzaza100345@gmail.com";
                pass = "Stampzaza100345";
                messagebody = "You have requested to reset your password. Enter this \"" + randomCode + "\" - code to change your password";
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messagebody;
                message.Subject = "Password resetting request";
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.EnableSsl = true;
                smtpClient.Port = 587;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtpClient.Send(message);
                    MessageBox.Show("ส่งรหัส OTP ไปที่ e-mail ของท่านแล้ว :)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }   
            else
            {
                MessageBox.Show("ไม่พบอีเมลที่สมัคร", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
        }
    }

}   
