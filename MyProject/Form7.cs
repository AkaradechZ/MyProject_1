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
using System.Text.RegularExpressions;
namespace MyProject
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private MySqlConnection databaseConnection()
        {
            String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_001;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
        private void register9()
        {
            MySqlConnection conn = databaseConnection();
            String sql = "INSERT INTO login_table001(username,password,fname,lname,status,email,phon) VALUES('" + user_textBox1.Text + "','" + pass_textBox2.Text + "','" + fname_textBox4.Text + "','" + lname_textBox5.Text + "','" + status_Box1.Text + "','" + email_textBox1.Text + "','" + phon_textBox8.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            if (rows > 0)
            {
                //showEquipment();
                MessageBox.Show(" เพิ่มข้อมูลำเร็จ");
                login_form a = new login_form();
                this.Hide();
                a.Show();
            }
        }
        private void register_Box1_Click(object sender, EventArgs e)
        {
            if(pass_textBox2.Text == con_textBox3.Text)
            {

                if (phon_textBox8.TextLength < 10)
                {
                    MessageBox.Show("กรุณากรอกเบอร์โทรศัพท์ให้ถูกต้อง", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (validateURL() == true)
                    {
                        register9();
                    }
                    
                }       
   
            }
            else
            {
                MessageBox.Show("รหัสผ่านไม่ถูกต้อง");
            }
        }

        private void user_textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void pass_textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
            
        }

        private void con_textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void fname_textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 44 && (int)e.KeyChar <= 57)
            {
                //MessageBox.Show("ไม่สามารถใส่ตัวเลขได้ !", "ตรวจพบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            else if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 122) || (int)e.KeyChar >= 161 || (int)e.KeyChar == 8 || (int)e.KeyChar == 13 || (int)e.KeyChar == 46 || (int)e.KeyChar == 32)
            {
                e.Handled = false;
            }
        }

        private void lname_textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 44 && (int)e.KeyChar <= 57)
            {
                //MessageBox.Show("ไม่สามารถใส่ตัวเลขได้ !", "ตรวจพบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
            else if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 122) || (int)e.KeyChar >= 161 || (int)e.KeyChar == 8 || (int)e.KeyChar == 13 || (int)e.KeyChar == 46 || (int)e.KeyChar == 32)
            {
                e.Handled = false;
            }
        }

        private void email_textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            /*if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                
                e.Handled = true;
            }*/
        }

        private void phon_textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private bool validateURL()
        {

            Regex urlCheck = new Regex("^[a-zA-Z0-9/@/./]+(com|org|net|mil|edu|COM|ORG|NET|MIL|EDU)$");

            if (urlCheck.IsMatch(email_textBox1.Text))
            {
                return true;
            }                
            else
            {
                MessageBox.Show("URL ไม่ถูกต้อง", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;

            }




        }
    }
    
}
