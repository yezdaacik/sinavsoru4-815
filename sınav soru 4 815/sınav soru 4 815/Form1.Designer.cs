namespace sınav_soru_4_815
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
            this.lbSayilar2 = new System.Windows.Forms.ListBox();
            this.btnSayi = new System.Windows.Forms.Button();
            this.btnUret = new System.Windows.Forms.Button();
            this.lbSayilar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbSayilar2
            // 
            this.lbSayilar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSayilar2.FormattingEnabled = true;
            this.lbSayilar2.ItemHeight = 16;
            this.lbSayilar2.Location = new System.Drawing.Point(302, 86);
            this.lbSayilar2.Name = "lbSayilar2";
            this.lbSayilar2.Size = new System.Drawing.Size(127, 244);
            this.lbSayilar2.TabIndex = 7;
            // 
            // btnSayi
            // 
            this.btnSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSayi.Location = new System.Drawing.Point(184, 189);
            this.btnSayi.Name = "btnSayi";
            this.btnSayi.Size = new System.Drawing.Size(112, 51);
            this.btnSayi.TabIndex = 6;
            this.btnSayi.Text = "50-70 Arası Sayılar >>>";
            this.btnSayi.UseVisualStyleBackColor = true;
            this.btnSayi.Click += new System.EventHandler(this.btnSayi_Click);
            // 
            // btnUret
            // 
            this.btnUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUret.Location = new System.Drawing.Point(51, 29);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(127, 35);
            this.btnUret.TabIndex = 5;
            this.btnUret.Text = "Sayı Üret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // lbSayilar
            // 
            this.lbSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSayilar.FormattingEnabled = true;
            this.lbSayilar.ItemHeight = 16;
            this.lbSayilar.Location = new System.Drawing.Point(51, 86);
            this.lbSayilar.Name = "lbSayilar";
            this.lbSayilar.Size = new System.Drawing.Size(127, 244);
            this.lbSayilar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 369);
            this.Controls.Add(this.lbSayilar2);
            this.Controls.Add(this.btnSayi);
            this.Controls.Add(this.btnUret);
            this.Controls.Add(this.lbSayilar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSayilar2;
        private System.Windows.Forms.Button btnSayi;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.ListBox lbSayilar;
    }
}

