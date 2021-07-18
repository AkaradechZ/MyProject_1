
namespace MyProject
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.entermail_textBox1 = new System.Windows.Forms.TextBox();
            this.otp_textBox2 = new System.Windows.Forms.TextBox();
            this.send_otp_Box1 = new System.Windows.Forms.PictureBox();
            this.con_otp_Box1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.send_otp_Box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.con_otp_Box1)).BeginInit();
            this.SuspendLayout();
            // 
            // entermail_textBox1
            // 
            this.entermail_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entermail_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.entermail_textBox1.Location = new System.Drawing.Point(34, 109);
            this.entermail_textBox1.Name = "entermail_textBox1";
            this.entermail_textBox1.Size = new System.Drawing.Size(291, 20);
            this.entermail_textBox1.TabIndex = 0;
            this.entermail_textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.entermail_textBox1_KeyPress);
            // 
            // otp_textBox2
            // 
            this.otp_textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.otp_textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.otp_textBox2.Location = new System.Drawing.Point(95, 288);
            this.otp_textBox2.Name = "otp_textBox2";
            this.otp_textBox2.Size = new System.Drawing.Size(167, 20);
            this.otp_textBox2.TabIndex = 1;
            this.otp_textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.otp_textBox2_KeyPress);
            // 
            // send_otp_Box1
            // 
            this.send_otp_Box1.BackColor = System.Drawing.Color.Transparent;
            this.send_otp_Box1.Location = new System.Drawing.Point(121, 153);
            this.send_otp_Box1.Name = "send_otp_Box1";
            this.send_otp_Box1.Size = new System.Drawing.Size(119, 43);
            this.send_otp_Box1.TabIndex = 2;
            this.send_otp_Box1.TabStop = false;
            this.send_otp_Box1.Click += new System.EventHandler(this.send_otp_Box1_Click);
            // 
            // con_otp_Box1
            // 
            this.con_otp_Box1.BackColor = System.Drawing.Color.Transparent;
            this.con_otp_Box1.Location = new System.Drawing.Point(121, 349);
            this.con_otp_Box1.Name = "con_otp_Box1";
            this.con_otp_Box1.Size = new System.Drawing.Size(113, 45);
            this.con_otp_Box1.TabIndex = 3;
            this.con_otp_Box1.TabStop = false;
            this.con_otp_Box1.Click += new System.EventHandler(this.con_otp_Box1_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(428, 506);
            this.Controls.Add(this.con_otp_Box1);
            this.Controls.Add(this.send_otp_Box1);
            this.Controls.Add(this.otp_textBox2);
            this.Controls.Add(this.entermail_textBox1);
            this.DoubleBuffered = true;
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.send_otp_Box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.con_otp_Box1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox entermail_textBox1;
        private System.Windows.Forms.TextBox otp_textBox2;
        private System.Windows.Forms.PictureBox send_otp_Box1;
        private System.Windows.Forms.PictureBox con_otp_Box1;
    }
}