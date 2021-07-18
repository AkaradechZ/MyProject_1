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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        private MySqlConnection databaseConnection()
        {
            String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_001;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void creatnewpass_Box1_Click(object sender, EventArgs e)
        {
            if (newpass_Box1.Text == connewpass_Box2.Text)
            {
                MySqlConnection conn = databaseConnection();

                String sql = "UPDATE login_table001 SET password = '" + newpass_Box1.Text + "' WHERE id = '" + Program.emailid + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {                   
                    MessageBox.Show("สร้างรหัสใหม่สำเร็จ");
                }
                login_form a = new login_form();
                this.Hide();
                a.Show();
            }
            else
            {
                MessageBox.Show("รหัสไม่ถูกต้อง");
            }
        }

        private void newpass_Box1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void connewpass_Box2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }
    }
}
