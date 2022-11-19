namespace UrunStok
{
    partial class homePage2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtSepetTutari = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSepettekiUrunSayisi = new System.Windows.Forms.Label();
            this.btnSepet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.txtSepetTutari);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSepettekiUrunSayisi);
            this.groupBox1.Controls.Add(this.btnSepet);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(636, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(123, 80);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(23, 16);
            this.label23.TabIndex = 5;
            this.label23.Text = "TL";
            // 
            // txtSepetTutari
            // 
            this.txtSepetTutari.AutoSize = true;
            this.txtSepetTutari.Location = new System.Drawing.Point(96, 80);
            this.txtSepetTutari.Name = "txtSepetTutari";
            this.txtSepetTutari.Size = new System.Drawing.Size(14, 16);
            this.txtSepetTutari.TabIndex = 4;
            this.txtSepetTutari.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sepet Tutarı:";
            // 
            // txtSepettekiUrunSayisi
            // 
            this.txtSepettekiUrunSayisi.AutoSize = true;
            this.txtSepettekiUrunSayisi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSepettekiUrunSayisi.Location = new System.Drawing.Point(123, 38);
            this.txtSepettekiUrunSayisi.Name = "txtSepettekiUrunSayisi";
            this.txtSepettekiUrunSayisi.Size = new System.Drawing.Size(14, 16);
            this.txtSepettekiUrunSayisi.TabIndex = 2;
            this.txtSepettekiUrunSayisi.Text = "0";
            // 
            // btnSepet
            // 
            this.btnSepet.Location = new System.Drawing.Point(51, 21);
            this.btnSepet.Name = "btnSepet";
            this.btnSepet.Size = new System.Drawing.Size(101, 50);
            this.btnSepet.TabIndex = 1;
            this.btnSepet.Text = "Sepet";
            this.btnSepet.UseVisualStyleBackColor = true;
            this.btnSepet.Click += new System.EventHandler(this.btnSepet_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kullanıcı Bilgileri";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 22);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 51);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Ara";
            // 
            // homePage2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "homePage2";
            this.Text = "homePage2";
            this.Load += new System.EventHandler(this.homePage2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label txtSepetTutari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtSepettekiUrunSayisi;
        private System.Windows.Forms.Button btnSepet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}