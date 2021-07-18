
namespace MyProject
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.showdata = new System.Windows.Forms.DataGridView();
            this.serch_TextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.konha_Box1 = new System.Windows.Forms.PictureBox();
            this.datekonha_button1 = new System.Windows.Forms.Button();
            this.จำแนกประเภทขอมลToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.รายรบToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.รายจายToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ทงหมดToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.บคคลToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.กรอกชอผบนทกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.วดปToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.กรอกวดปToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rairub_Box2 = new System.Windows.Forms.PictureBox();
            this.table_Box2 = new System.Windows.Forms.PictureBox();
            this.edit_Box1 = new System.Windows.Forms.PictureBox();
            this.exit_Box2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.konha_Box2 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.showdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konha_Box1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rairub_Box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_Box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_Box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.konha_Box2)).BeginInit();
            this.SuspendLayout();
            // 
            // showdata
            // 
            this.showdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdata.Location = new System.Drawing.Point(73, 97);
            this.showdata.Margin = new System.Windows.Forms.Padding(4);
            this.showdata.Name = "showdata";
            this.showdata.RowHeadersWidth = 51;
            this.showdata.Size = new System.Drawing.Size(801, 636);
            this.showdata.TabIndex = 0;
            // 
            // serch_TextBox1
            // 
            this.serch_TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serch_TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.serch_TextBox1.Location = new System.Drawing.Point(1028, 134);
            this.serch_TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.serch_TextBox1.Name = "serch_TextBox1";
            this.serch_TextBox1.Size = new System.Drawing.Size(319, 27);
            this.serch_TextBox1.TabIndex = 1;
            // 
            // konha_Box1
            // 
            this.konha_Box1.BackColor = System.Drawing.Color.Transparent;
            this.konha_Box1.Location = new System.Drawing.Point(1387, 114);
            this.konha_Box1.Margin = new System.Windows.Forms.Padding(4);
            this.konha_Box1.Name = "konha_Box1";
            this.konha_Box1.Size = new System.Drawing.Size(60, 68);
            this.konha_Box1.TabIndex = 3;
            this.konha_Box1.TabStop = false;
            this.konha_Box1.Click += new System.EventHandler(this.konha_Box1_Click);
            // 
            // datekonha_button1
            // 
            this.datekonha_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.datekonha_button1.Location = new System.Drawing.Point(1233, 63);
            this.datekonha_button1.Margin = new System.Windows.Forms.Padding(4);
            this.datekonha_button1.Name = "datekonha_button1";
            this.datekonha_button1.Size = new System.Drawing.Size(39, 42);
            this.datekonha_button1.TabIndex = 6;
            this.datekonha_button1.Text = "ไป";
            this.datekonha_button1.UseVisualStyleBackColor = false;
            this.datekonha_button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // จำแนกประเภทขอมลToolStripMenuItem
            // 
            this.จำแนกประเภทขอมลToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.รายรบToolStripMenuItem,
            this.รายจายToolStripMenuItem,
            this.ทงหมดToolStripMenuItem});
            this.จำแนกประเภทขอมลToolStripMenuItem.Name = "จำแนกประเภทขอมลToolStripMenuItem";
            this.จำแนกประเภทขอมลToolStripMenuItem.Size = new System.Drawing.Size(186, 29);
            this.จำแนกประเภทขอมลToolStripMenuItem.Text = "จำแนกประเภทข้อมูล";
            // 
            // รายรบToolStripMenuItem
            // 
            this.รายรบToolStripMenuItem.Name = "รายรบToolStripMenuItem";
            this.รายรบToolStripMenuItem.Size = new System.Drawing.Size(157, 30);
            this.รายรบToolStripMenuItem.Text = "รายรับ";
            this.รายรบToolStripMenuItem.Click += new System.EventHandler(this.รายรบToolStripMenuItem_Click);
            // 
            // รายจายToolStripMenuItem
            // 
            this.รายจายToolStripMenuItem.Name = "รายจายToolStripMenuItem";
            this.รายจายToolStripMenuItem.Size = new System.Drawing.Size(157, 30);
            this.รายจายToolStripMenuItem.Text = "รายจ่าย";
            this.รายจายToolStripMenuItem.Click += new System.EventHandler(this.รายจายToolStripMenuItem_Click);
            // 
            // ทงหมดToolStripMenuItem
            // 
            this.ทงหมดToolStripMenuItem.Name = "ทงหมดToolStripMenuItem";
            this.ทงหมดToolStripMenuItem.Size = new System.Drawing.Size(157, 30);
            this.ทงหมดToolStripMenuItem.Text = "ทั้งหมด";
            this.ทงหมดToolStripMenuItem.Click += new System.EventHandler(this.ทงหมดToolStripMenuItem_Click);
            // 
            // บคคลToolStripMenuItem
            // 
            this.บคคลToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.กรอกชอผบนทกToolStripMenuItem});
            this.บคคลToolStripMenuItem.Name = "บคคลToolStripMenuItem";
            this.บคคลToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.บคคลToolStripMenuItem.Text = "บุคคล";
            // 
            // กรอกชอผบนทกToolStripMenuItem
            // 
            this.กรอกชอผบนทกToolStripMenuItem.Name = "กรอกชอผบนทกToolStripMenuItem";
            this.กรอกชอผบนทกToolStripMenuItem.Size = new System.Drawing.Size(223, 30);
            this.กรอกชอผบนทกToolStripMenuItem.Text = "กรอกชื่อผู้บันทึก";
            this.กรอกชอผบนทกToolStripMenuItem.Click += new System.EventHandler(this.กรอกชอผบนทกToolStripMenuItem_Click);
            // 
            // วดปToolStripMenuItem
            // 
            this.วดปToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.กรอกวดปToolStripMenuItem});
            this.วดปToolStripMenuItem.Name = "วดปToolStripMenuItem";
            this.วดปToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.วดปToolStripMenuItem.Text = "ว/ด/ป";
            // 
            // กรอกวดปToolStripMenuItem
            // 
            this.กรอกวดปToolStripMenuItem.Name = "กรอกวดปToolStripMenuItem";
            this.กรอกวดปToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.กรอกวดปToolStripMenuItem.Text = "กรอก ว/ด/ป";
            this.กรอกวดปToolStripMenuItem.Click += new System.EventHandler(this.กรอกวดปToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.จำแนกประเภทขอมลToolStripMenuItem,
            this.บคคลToolStripMenuItem,
            this.วดปToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1480, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rairub_Box2
            // 
            this.rairub_Box2.BackColor = System.Drawing.Color.Transparent;
            this.rairub_Box2.Location = new System.Drawing.Point(1173, 401);
            this.rairub_Box2.Margin = new System.Windows.Forms.Padding(4);
            this.rairub_Box2.Name = "rairub_Box2";
            this.rairub_Box2.Size = new System.Drawing.Size(235, 49);
            this.rairub_Box2.TabIndex = 7;
            this.rairub_Box2.TabStop = false;
            this.rairub_Box2.Click += new System.EventHandler(this.rairub_Box2_Click);
            // 
            // table_Box2
            // 
            this.table_Box2.BackColor = System.Drawing.Color.Transparent;
            this.table_Box2.Location = new System.Drawing.Point(1173, 471);
            this.table_Box2.Margin = new System.Windows.Forms.Padding(4);
            this.table_Box2.Name = "table_Box2";
            this.table_Box2.Size = new System.Drawing.Size(216, 46);
            this.table_Box2.TabIndex = 8;
            this.table_Box2.TabStop = false;
            this.table_Box2.Click += new System.EventHandler(this.table_Box2_Click);
            // 
            // edit_Box1
            // 
            this.edit_Box1.BackColor = System.Drawing.Color.Transparent;
            this.edit_Box1.Location = new System.Drawing.Point(1193, 543);
            this.edit_Box1.Margin = new System.Windows.Forms.Padding(4);
            this.edit_Box1.Name = "edit_Box1";
            this.edit_Box1.Size = new System.Drawing.Size(196, 44);
            this.edit_Box1.TabIndex = 9;
            this.edit_Box1.TabStop = false;
            this.edit_Box1.Click += new System.EventHandler(this.edit_Box1_Click);
            // 
            // exit_Box2
            // 
            this.exit_Box2.BackColor = System.Drawing.Color.Transparent;
            this.exit_Box2.Location = new System.Drawing.Point(1209, 631);
            this.exit_Box2.Margin = new System.Windows.Forms.Padding(4);
            this.exit_Box2.Name = "exit_Box2";
            this.exit_Box2.Size = new System.Drawing.Size(157, 46);
            this.exit_Box2.TabIndex = 10;
            this.exit_Box2.TabStop = false;
            this.exit_Box2.Click += new System.EventHandler(this.exit_Box2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1111, 219);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // konha_Box2
            // 
            this.konha_Box2.BackColor = System.Drawing.Color.Transparent;
            this.konha_Box2.Location = new System.Drawing.Point(1387, 114);
            this.konha_Box2.Margin = new System.Windows.Forms.Padding(4);
            this.konha_Box2.Name = "konha_Box2";
            this.konha_Box2.Size = new System.Drawing.Size(72, 73);
            this.konha_Box2.TabIndex = 12;
            this.konha_Box2.TabStop = false;
            this.konha_Box2.Click += new System.EventHandler(this.konha_Box2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1010, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1480, 799);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.konha_Box2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit_Box2);
            this.Controls.Add(this.edit_Box1);
            this.Controls.Add(this.table_Box2);
            this.Controls.Add(this.rairub_Box2);
            this.Controls.Add(this.datekonha_button1);
            this.Controls.Add(this.konha_Box1);
            this.Controls.Add(this.serch_TextBox1);
            this.Controls.Add(this.showdata);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1498, 846);
            this.MinimumSize = new System.Drawing.Size(1365, 819);
            this.Name = "Form4";
            this.Text = "showdata";
            this.Load += new System.EventHandler(this.showdata_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konha_Box1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rairub_Box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_Box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_Box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_Box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.konha_Box2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView showdata;
        private System.Windows.Forms.MaskedTextBox serch_TextBox1;
        private System.Windows.Forms.PictureBox konha_Box1;
        private System.Windows.Forms.Button datekonha_button1;
        private System.Windows.Forms.ToolStripMenuItem จำแนกประเภทขอมลToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem รายรบToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem รายจายToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem บคคลToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem วดปToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem กรอกวดปToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox rairub_Box2;
        private System.Windows.Forms.PictureBox table_Box2;
        private System.Windows.Forms.PictureBox edit_Box1;
        private System.Windows.Forms.PictureBox exit_Box2;
        private System.Windows.Forms.ToolStripMenuItem ทงหมดToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem กรอกชอผบนทกToolStripMenuItem;
        private System.Windows.Forms.PictureBox konha_Box2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}