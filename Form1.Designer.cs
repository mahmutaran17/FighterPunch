
namespace example
{
    partial class Form1
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
            this.TxtOyuncu = new System.Windows.Forms.Label();
            this.TxtIrk = new System.Windows.Forms.Label();
            this.txtBrans = new System.Windows.Forms.Label();
            this.txtSilah = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.lblOpponent = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPunch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtOyuncu
            // 
            this.TxtOyuncu.AutoSize = true;
            this.TxtOyuncu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOyuncu.Location = new System.Drawing.Point(58, 41);
            this.TxtOyuncu.Name = "TxtOyuncu";
            this.TxtOyuncu.Size = new System.Drawing.Size(115, 24);
            this.TxtOyuncu.TabIndex = 0;
            this.TxtOyuncu.Text = "Oyuncu İsmi";
            // 
            // TxtIrk
            // 
            this.TxtIrk.AutoSize = true;
            this.TxtIrk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtIrk.Location = new System.Drawing.Point(58, 85);
            this.TxtIrk.Name = "TxtIrk";
            this.TxtIrk.Size = new System.Drawing.Size(29, 24);
            this.TxtIrk.TabIndex = 1;
            this.TxtIrk.Text = "Irk";
            // 
            // txtBrans
            // 
            this.txtBrans.AutoSize = true;
            this.txtBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBrans.Location = new System.Drawing.Point(58, 128);
            this.txtBrans.Name = "txtBrans";
            this.txtBrans.Size = new System.Drawing.Size(58, 24);
            this.txtBrans.TabIndex = 2;
            this.txtBrans.Text = "Brans";
            // 
            // txtSilah
            // 
            this.txtSilah.AutoSize = true;
            this.txtSilah.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSilah.Location = new System.Drawing.Point(58, 173);
            this.txtSilah.Name = "txtSilah";
            this.txtSilah.Size = new System.Drawing.Size(51, 24);
            this.txtSilah.TabIndex = 3;
            this.txtSilah.Text = "Silah";
            this.txtSilah.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(206, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(206, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 24);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(206, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 24);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(206, 173);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 24);
            this.textBox4.TabIndex = 7;
            // 
            // btnSec
            // 
            this.btnSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSec.Location = new System.Drawing.Point(416, 72);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(118, 52);
            this.btnSec.TabIndex = 8;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOpponent
            // 
            this.lblOpponent.BackColor = System.Drawing.Color.Red;
            this.lblOpponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOpponent.Location = new System.Drawing.Point(588, 174);
            this.lblOpponent.Name = "lblOpponent";
            this.lblOpponent.Size = new System.Drawing.Size(300, 24);
            this.lblOpponent.TabIndex = 9;
            this.lblOpponent.TextChanged += new System.EventHandler(this.lblOpponent_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::example.Properties.Resources.Bare_knuckle_Boxing_Match;
            this.pictureBox1.Location = new System.Drawing.Point(588, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnPunch
            // 
            this.btnPunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPunch.Location = new System.Drawing.Point(206, 257);
            this.btnPunch.Name = "btnPunch";
            this.btnPunch.Size = new System.Drawing.Size(210, 131);
            this.btnPunch.TabIndex = 11;
            this.btnPunch.Text = "Punch";
            this.btnPunch.UseVisualStyleBackColor = true;
            this.btnPunch.Click += new System.EventHandler(this.btnPunch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.btnPunch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblOpponent);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSilah);
            this.Controls.Add(this.txtBrans);
            this.Controls.Add(this.TxtIrk);
            this.Controls.Add(this.TxtOyuncu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtOyuncu;
        private System.Windows.Forms.Label TxtIrk;
        private System.Windows.Forms.Label txtBrans;
        private System.Windows.Forms.Label txtSilah;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.TextBox lblOpponent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPunch;
    }
}

