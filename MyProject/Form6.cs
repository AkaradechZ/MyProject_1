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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private MySqlConnection databaseConnection()
        {
            String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_001;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void showEquipment()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM list_001";

            MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
            adpter.Fill(ds);

            conn.Close();

            showdata.DataSource = ds.Tables[0].DefaultView;
        }
        private void showEquipment2()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM list_001 WHERE recorder=\"{Program.user}\"";

            MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
            adpter.Fill(ds);

            conn.Close();

            showdata.DataSource = ds.Tables[0].DefaultView;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            if(Program.user == "admin")
            {
                showEquipment();
            }
            else
            {
                showEquipment2();
            }
            
        }

        private void exit_Box3_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            login_form a = new login_form();
            this.Hide();
            a.Show();
        }

        private void rairub_Box3_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            this.Hide();
            a.Show();
        }

        private void table_Box3_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            this.Hide();
            a.Show();
        }

        private void edit_Box1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("คุณได้อยู่หน้านี้แล้ว");
        }

        private void serchdate_Box1_Click(object sender, EventArgs e)
        {
            if(Program.user == "admin")
            {
                MySqlConnection conn = databaseConnection();
                DataSet ds = new DataSet();
                conn.Open();

                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM list_001 WHERE date=\"{dateTimePicker1.Value.ToString("dd/MM/yyyy")}\"";

                MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
                adpter.Fill(ds);

                conn.Close();

                showdata.DataSource = ds.Tables[0].DefaultView;
            }
            else
            {
                MySqlConnection conn = databaseConnection();
                DataSet ds = new DataSet();
                conn.Open();

                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM list_001 WHERE date=\"{dateTimePicker1.Value.ToString("dd/MM/yyyy")}\" and recorder=\"{Program.user}\"";

                MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
                adpter.Fill(ds);

                conn.Close();

                showdata.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void serchlist_Box1_Click(object sender, EventArgs e)
        {
            if (Program.user == "admin")
            {
                MySqlConnection conn = databaseConnection();
                DataSet ds = new DataSet();
                conn.Open();

                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM list_001 WHERE list=\"{list_Box2.Text}\"";

                MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
                adpter.Fill(ds);

                conn.Close();

                showdata.DataSource = ds.Tables[0].DefaultView;
            }
            else
            {
                MySqlConnection conn = databaseConnection();
                DataSet ds = new DataSet();
                conn.Open();

                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM list_001 WHERE list=\"{list_Box2.Text}\" and recorder=\"{Program.user}\"";

                MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
                adpter.Fill(ds);

                conn.Close();

                showdata.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void money_Box1_Click(object sender, EventArgs e)
        {
            if (Program.user == "admin")
            {
                MySqlConnection conn = databaseConnection();
                DataSet ds = new DataSet();
                conn.Open();

                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM list_001 WHERE money=\"{money_Box2.Text}\"";

                MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
                adpter.Fill(ds);

                conn.Close();

                showdata.DataSource = ds.Tables[0].DefaultView;
            }
            else
            {
                MySqlConnection conn = databaseConnection();
                DataSet ds = new DataSet();
                conn.Open();

                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM list_001 WHERE money=\"{money_Box2.Text}\" and recorder=\"{Program.user}\"";

                MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
                adpter.Fill(ds);

                conn.Close();

                showdata.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void serchrairub_Box1_Click(object sender, EventArgs e)
        {
            if (Program.user == "admin")
            {
                MySqlConnection conn = databaseConnection();
                DataSet ds = new DataSet();
                conn.Open();

                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM list_001 WHERE inex=\"{rairub_Box2.Text}\"";

                MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
                adpter.Fill(ds);

                conn.Close();

                showdata.DataSource = ds.Tables[0].DefaultView;
            }
            else
            {
                MySqlConnection conn = databaseConnection();
                DataSet ds = new DataSet();
                conn.Open();

                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM list_001 WHERE inex=\"{rairub_Box2.Text}\" and recorder=\"{Program.user}\"";

                MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
                adpter.Fill(ds);

                conn.Close();

                showdata.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void serchrecorder_Box1_Click(object sender, EventArgs e)
        {
            if (Program.user == "admin")
            {
                MySqlConnection conn = databaseConnection();
                DataSet ds = new DataSet();
                conn.Open();

                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM list_001 WHERE recorder=\"{recorder_Box2.Text}\"";

                MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
                adpter.Fill(ds);

                conn.Close();

                showdata.DataSource = ds.Tables[0].DefaultView;
            }
            else
            {
                MessageBox.Show("ดูได้เฉพาะของตัวเองเท่านั้น");
            }
        }

        private void showdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showdata.CurrentRow.Selected = true;
            //date_Box2.Text = showdata.Rows[e.RowIndex].Cells["date"].FormattedValue.ToString();
            list_Box2.Text = showdata.Rows[e.RowIndex].Cells["list"].FormattedValue.ToString();
            money_Box2.Text = showdata.Rows[e.RowIndex].Cells["money"].FormattedValue.ToString();
            rairub_Box2.Text = showdata.Rows[e.RowIndex].Cells["inex"].FormattedValue.ToString();
            recorder_Box2.Text = showdata.Rows[e.RowIndex].Cells["recorder"].FormattedValue.ToString();
        }

        private void editbutton_Box1_Click(object sender, EventArgs e)
        {
            int selectedRow = showdata.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(showdata.Rows[selectedRow].Cells["id"].Value);

            if (Program.user == "admin")
            {
                MySqlConnection conn = databaseConnection();

                String sql = "UPDATE list_001 SET date = '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "',list = '" + list_Box2.Text + "',money = '" + money_Box2.Text + "',inex ='" + rairub_Box2.Text + "',recorder = '" + recorder_Box2.Text + "' WHERE id = '" + editId + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);


                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                    showEquipment();
                    MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
                    cleartext();
                }
            }
            else
            {
                MySqlConnection conn = databaseConnection();

                String sql = "UPDATE list_001 SET date = '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "',list = '" + list_Box2.Text + "',money = '" + money_Box2.Text + "',inex ='" + rairub_Box2.Text + "' WHERE id = '" + editId + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);


                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                    showEquipment2();
                    MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
                    cleartext();
                }
            }
        }

        private void deletebuttom_Box1_Click(object sender, EventArgs e)
        {
            int selectedRow = showdata.CurrentCell.RowIndex;
            int deleteId = Convert.ToInt32(showdata.Rows[selectedRow].Cells["id"].Value);

            MySqlConnection conn = databaseConnection();

            String sql = "DELETE FROM list_001 WHERE id = '" + deleteId + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            if (rows > 0)
            {
                if(Program.user == "admin")
                {
                    showEquipment();
                    MessageBox.Show("ลบข้อมูลสำเร็จ");
                    cleartext();
                }
                else
                {
                    showEquipment2();
                    MessageBox.Show("ลบข้อมูลสำเร็จ");
                    cleartext();
                }
            }

        }

        private void money_Box2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void rairub_Box2_KeyPress(object sender, KeyPressEventArgs e)
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
        private void cleartext()
        {
            //date_Box2.Clear();
            list_Box2.Clear();
            money_Box2.Clear();
            rairub_Box2.Clear();
            recorder_Box2.Clear();
        }
    }
}
    
