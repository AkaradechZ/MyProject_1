
namespace MyProject
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.newpass_Box1 = new System.Windows.Forms.TextBox();
            this.connewpass_Box2 = new System.Windows.Forms.TextBox();
            this.creatnewpass_Box1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.creatnewpass_Box1)).BeginInit();
            this.SuspendLayout();
            // 
            // newpass_Box1
            // 
            this.newpass_Box1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newpass_Box1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.newpass_Box1.Location = new System.Drawing.Point(106, 123);
            this.newpass_Box1.Name = "newpass_Box1";
            this.newpass_Box1.Size = new System.Drawing.Size(286, 17);
            this.newpass_Box1.TabIndex = 0;
            this.newpass_Box1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newpass_Box1_KeyPress);
            // 
            // connewpass_Box2
            // 
            this.connewpass_Box2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.connewpass_Box2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.connewpass_Box2.Location = new System.Drawing.Point(58, 241);
            this.connewpass_Box2.Name = "connewpass_Box2";
            this.connewpass_Box2.Size = new System.Drawing.Size(286, 17);
            this.connewpass_Box2.TabIndex = 1;
            this.connewpass_Box2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.connewpass_Box2_KeyPress);
            // 
            // creatnewpass_Box1
            // 
            this.creatnewpass_Box1.BackColor = System.Drawing.Color.Transparent;
            this.creatnewpass_Box1.Location = new System.Drawing.Point(142, 299);
            this.creatnewpass_Box1.Name = "creatnewpass_Box1";
            this.creatnewpass_Box1.Size = new System.Drawing.Size(120, 43);
            this.creatnewpass_Box1.TabIndex = 2;
            this.creatnewpass_Box1.TabStop = false;
            this.creatnewpass_Box1.Click += new System.EventHandler(this.creatnewpass_Box1_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(429, 499);
            this.Controls.Add(this.creatnewpass_Box1);
            this.Controls.Add(this.connewpass_Box2);
            this.Controls.Add(this.newpass_Box1);
            this.DoubleBuffered = true;
            this.Name = "Form9";
            this.Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)(this.creatnewpass_Box1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newpass_Box1;
        private System.Windows.Forms.TextBox connewpass_Box2;
        private System.Windows.Forms.PictureBox creatnewpass_Box1;
    }
}