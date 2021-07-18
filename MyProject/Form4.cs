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
    public partial class Form4 : Form
    {
        public Form4()
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
            Program.choice = "";
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
        private void showEquipment002()
        {
            Program.choice = Program.user;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showdata_form_Load(object sender, EventArgs e)
        {
            if (Program.user == "admin")
            {
                showEquipment();
            }
            else
            {
                showEquipment002();
            }                       
            dateTimePicker1.Hide();
            datekonha_button1.Hide();
            konha_Box2.Hide();
            Program.choice = "";
        }

        private void select_data()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM list_001 WHERE recorder=\"{Program.nameselect}\"";

            MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
            adpter.Fill(ds);

            conn.Close();

            showdata.DataSource = ds.Tables[0].DefaultView;
        }
        private void select_data2()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM list_001 WHERE inex=\"{Program.inexselect}\"";

            MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
            adpter.Fill(ds);

            conn.Close();

            showdata.DataSource = ds.Tables[0].DefaultView;
        }
        private void select_data3()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM list_001 WHERE inex=\"{Program.inexselect}\" and recorder=\"{Program.user}\"";

            MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
            adpter.Fill(ds);

            conn.Close();

            showdata.DataSource = ds.Tables[0].DefaultView;
        }
        private void รายรบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.inexselect = "รายรับ";
            Program.choice = "รายรับ";
            if (Program.user == "admin")
            {
                select_data2();
            }
            else
            {
                select_data3();
            }           
        }

        private void รายจายToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.inexselect = "รายจ่าย";
            Program.choice = "รายจ่าย";
            if (Program.user == "admin")
            {
                select_data2();
            }
            else
            {
                select_data3();
            }
        }
     
        private void กรอกวดปToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //yolo_pictureBox1.Hide();
            dateTimePicker1.Show();
            datekonha_button1.Show();

        }

        private void button1_Click(object sender, EventArgs e) // datekonha_button1
        {
            Program.choice = Convert.ToString(dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            if (Program.user == "admin")
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
                Program.choice = Convert.ToString(dateTimePicker1.Value.ToString("dd/MM/yyyy"));
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
                Program.choice = Convert.ToString(dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            }
        }

        private void konha_Box1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM list_001 WHERE list=\"{serch_TextBox1.Text}\"";

            MySqlDataAdapter adpter = new MySqlDataAdapter(cmd);
            adpter.Fill(ds);

            conn.Close();

            showdata.DataSource = ds.Tables[0].DefaultView;
            Program.choice = serch_TextBox1.Text;
        }

        private void exit_Box2_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            login_form a = new login_form();
            this.Hide();
            a.Show();
        }

        private void rairub_Box2_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            this.Hide();
            a.Show();
        }

        private void edit_Box1_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            this.Hide();
            a.Show();
        }

        private void table_Box2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("คุณได้อยู่หน้านี้แล้ว");
        }

        private void ทงหมดToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.user == "admin")
            {
                showEquipment();
            }
            else
            {
                showEquipment002();
            }           
            Program.choice = "";
        }
        private List<yolo> allbook = new List<yolo>();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            allbook.Clear();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image logo = Image.FromFile(@"D:\รูปงาน\yolo004.png");
            e.Graphics.DrawImage(logo, new PointF(165, 20));           
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 160));
            e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd / MM / yyyy   HH : mm : ss น."), new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 190));
            e.Graphics.DrawString("พิมพ์โดย " + Program.user, new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(400, 190));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 215));
            e.Graphics.DrawString("DATE", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(50, 235));
            e.Graphics.DrawString("LIST", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(250, 235));
            e.Graphics.DrawString("MONEY", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(430, 235));
            e.Graphics.DrawString("IN-EX", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(530, 235));
            e.Graphics.DrawString("RECORDER", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(630, 235));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 250));
            int y = 290;
            loaddata();
            foreach (var i in allbook)
            {
                e.Graphics.DrawString(i.date, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(50, y));
                e.Graphics.DrawString(i.list001, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(150, y));
                e.Graphics.DrawString(i.money, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(430, y));
                e.Graphics.DrawString(i.inex, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(530, y));
                e.Graphics.DrawString(i.recorder, new Font("TH SarabunPSK", 14, FontStyle.Regular), Brushes.Black, new PointF(630, y));
                y = y + 20;
            }
        }
        private void loaddata()
        {
            MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_001;");

            conn.Open();

            string name = Program.choice;
            string nameyolo = Program.user;
            if (nameyolo == "admin")
            {
                if(name == "")
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM list_001 ", conn);
                    MySqlDataReader adapter = cmd.ExecuteReader();

                    while (adapter.Read())
                    {
                        Program.date = adapter.GetString("date");
                        Program.list001 = adapter.GetString("list");
                        Program.money = adapter.GetString("money");
                        Program.inex = adapter.GetString("inex");
                        Program.recorder = adapter.GetString("recorder");
                        yolo item = new yolo()
                        {
                            date = Program.date,
                            list001 = Program.list001,
                            money = Program.money,
                            inex = Program.inex,
                            recorder = Program.recorder
                        };
                        allbook.Add(item);
                    }
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand($"SELECT * FROM list_001 WHERE date=\"{name}\" OR list=\"{name}\" OR money=\"{name}\" OR inex=\"{name}\" or recorder=\"{name}\"", conn);
                    MySqlDataReader adapter = cmd.ExecuteReader();

                    while (adapter.Read())
                    {
                        Program.date = adapter.GetString("date");
                        Program.list001 = adapter.GetString("list");
                        Program.money = adapter.GetString("money");
                        Program.inex = adapter.GetString("inex");
                        Program.recorder = adapter.GetString("recorder");
                        yolo item = new yolo()
                        {
                            date = Program.date,
                            list001 = Program.list001,
                            money = Program.money,
                            inex = Program.inex,
                            recorder = Program.recorder

                        };
                        allbook.Add(item);
                    }
                }
                
            }
            else
            {
                if(name == "")
                {
                    MySqlCommand cmd = new MySqlCommand($"SELECT * FROM list_001 WHERE  recorder=\"{nameyolo}\"", conn);
                    MySqlDataReader adapter = cmd.ExecuteReader();

                    while (adapter.Read())
                    {
                        Program.date = adapter.GetString("date");
                        Program.list001 = adapter.GetString("list");
                        Program.money = adapter.GetString("money");
                        Program.inex = adapter.GetString("inex");
                        Program.recorder = adapter.GetString("recorder");
                        yolo item = new yolo()
                        {
                            date = Program.date,
                            list001 = Program.list001,
                            money = Program.money,
                            inex = Program.inex,
                            recorder = Program.recorder
                        };
                        allbook.Add(item);
                    }
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand($"SELECT * FROM list_001 WHERE date=\"{name}\" OR list=\"{name}\" OR money=\"{name}\" OR inex=\"{name}\" and recorder=\"{nameyolo}\"", conn);
                    MySqlDataReader adapter = cmd.ExecuteReader();

                    while (adapter.Read())
                    {
                        Program.date = adapter.GetString("date");
                        Program.list001 = adapter.GetString("list");
                        Program.money = adapter.GetString("money");
                        Program.inex = adapter.GetString("inex");
                        Program.recorder = adapter.GetString("recorder");
                        yolo item = new yolo()
                        {
                            date = Program.date,
                            list001 = Program.list001,
                            money = Program.money,
                            inex = Program.inex,
                            recorder = Program.recorder

                        };
                        allbook.Add(item);
                    }
                }
            }       
        }

        private void กรอกชอผบนทกToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if(Program.user == "admin")
            {
                konha_Box2.Show();
            }
            else
            {
                MessageBox.Show("ดูได้เฉพาะของตัวเองเท่านั้น");
            }
                        
        }

        private void konha_Box2_Click(object sender, EventArgs e)
        {
            Program.nameselect = serch_TextBox1.Text;
            Program.choice = serch_TextBox1.Text;
            select_data();
            konha_Box2.Hide();
        }
    }
}


