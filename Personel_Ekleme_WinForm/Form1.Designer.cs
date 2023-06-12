namespace Personel_Ekleme_WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtAd = new TextBox();
            cmbDepartmanlar = new ComboBox();
            btnKaydet = new Button();
            btnGoster = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 40);
            label1.Name = "label1";
            label1.Size = new Size(159, 15);
            label1.TabIndex = 0;
            label1.Text = "Lutfen Personel Adını Giriniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 106);
            label2.Name = "label2";
            label2.Size = new Size(139, 15);
            label2.TabIndex = 1;
            label2.Text = "Lutfen Dpartman Seciniz:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(50, 67);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(248, 23);
            txtAd.TabIndex = 2;
            // 
            // cmbDepartmanlar
            // 
            cmbDepartmanlar.FormattingEnabled = true;
            cmbDepartmanlar.Location = new Point(50, 135);
            cmbDepartmanlar.Name = "cmbDepartmanlar";
            cmbDepartmanlar.Size = new Size(248, 23);
            cmbDepartmanlar.TabIndex = 3;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(51, 188);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(247, 23);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "PERSONEL KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGoster
            // 
            btnGoster.Location = new Point(51, 235);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(247, 23);
            btnGoster.TabIndex = 5;
            btnGoster.Text = "KISILERI GOSTER";
            btnGoster.UseVisualStyleBackColor = true;
            btnGoster.Click += btnGoster_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 313);
            Controls.Add(btnGoster);
            Controls.Add(btnKaydet);
            Controls.Add(cmbDepartmanlar);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "PERSONEL EKLEME";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAd;
        private ComboBox cmbDepartmanlar;
        private Button btnKaydet;
        private Button btnGoster;
    }
}