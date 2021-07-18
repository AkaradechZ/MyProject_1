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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private MySqlConnection databaseConnection()
        {
            String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_001;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void cleartext()
        {
            //dateTimePicker1.();
            list_textBox.Clear();
            money_textBox.Clear();
        }
        private void checktext()
        {
            
            if(list_textBox.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
            }
            else if(money_textBox.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
            }
            else
            {
                insertdata();
            }
        }
        private void insertdata()
        {
            MySqlConnection conn = databaseConnection();
            String sql = "INSERT INTO list_001(date,list,money,inex,recorder) VALUES('" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "','" + list_textBox.Text + "','" + Convert.ToInt32(money_textBox.Text) + "','" + Program.inorex + "','" + Program.user + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            if (rows > 0)
            {                
                MessageBox.Show(" เพิ่มข้อมูลำเร็จ");
                cleartext();
            }
        }

        private void exit_Box1_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            login_form a = new login_form();
            this.Hide();
            a.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            user_textBox.Text = Program.user+"  "+Program.user2;
        }

        private void rub_Box_Click(object sender, EventArgs e)
        {
            Program.inorex = "รายรับ";
            checktext();
        }

        private void jay_Box_Click(object sender, EventArgs e)
        {
            Program.inorex = "รายจ่าย";
            checktext();
        }

        private void table_Box1_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            this.Hide();
            a.Show();
        }

        private void rairub_Box1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("คุณได้อยู่หน้านี้แล้ว");
        }

        private void edit_Box1_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            this.Hide();
            a.Show();
        }

        private void money_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void date_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
