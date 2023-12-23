namespace DernekApp
{
    partial class MainPage
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
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            txtName = new TextBox();
            txtDelete = new TextBox();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            label8 = new Label();
            txtPhoneNumber = new TextBox();
            checkboxState = new CheckBox();
            cbxBloodType = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            txtMonthlyPayment = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtCity = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtSecNumber = new TextBox();
            label1 = new Label();
            txtSurname = new TextBox();
            lblName = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            AidatGuncelle = new Button();
            aidat = new TextBox();
            AidatGridView2 = new DataGridView();
            tabPage3 = new TabPage();
            MailBody = new RichTextBox();
            MailSubject = new TextBox();
            label10 = new Label();
            label9 = new Label();
            pdfal = new Button();
            BorcluUyelereMailGonder = new Button();
            BorcluUyelerGridView = new DataGridView();
            tabPage4 = new TabPage();
            Search = new Button();
            SearchGridView = new DataGridView();
            label11 = new Label();
            textBox1 = new TextBox();
            BorcluUyeyiGoster = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AidatGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BorcluUyelerGridView).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(767, 192);
            dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(210, 159);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(82, 22);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // txtDelete
            // 
            txtDelete.Location = new Point(635, 224);
            txtDelete.Name = "txtDelete";
            txtDelete.Size = new Size(46, 23);
            txtDelete.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(595, 224);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(34, 20);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(checkboxState);
            groupBox1.Controls.Add(cbxBloodType);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMonthlyPayment);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtCity);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSecNumber);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSurname);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtName);
            groupBox1.Location = new Point(6, 204);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(527, 209);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Üye";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 138);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 21;
            label8.Text = "Telefon";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(82, 138);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(100, 23);
            txtPhoneNumber.TabIndex = 20;
            // 
            // checkboxState
            // 
            checkboxState.AutoSize = true;
            checkboxState.Location = new Point(354, 115);
            checkboxState.Name = "checkboxState";
            checkboxState.Size = new Size(51, 19);
            checkboxState.TabIndex = 19;
            checkboxState.Text = "Aktif";
            checkboxState.UseVisualStyleBackColor = true;
            // 
            // cbxBloodType
            // 
            cbxBloodType.FormattingEnabled = true;
            cbxBloodType.Location = new Point(354, 54);
            cbxBloodType.Name = "cbxBloodType";
            cbxBloodType.Size = new Size(100, 23);
            cbxBloodType.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 115);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 17;
            label4.Text = "Durum";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(278, 86);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 15;
            label5.Text = "Aidat";
            // 
            // txtMonthlyPayment
            // 
            txtMonthlyPayment.Location = new Point(354, 83);
            txtMonthlyPayment.Name = "txtMonthlyPayment";
            txtMonthlyPayment.Size = new Size(100, 23);
            txtMonthlyPayment.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(278, 57);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 13;
            label6.Text = "Kan Grubu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(278, 28);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 11;
            label7.Text = "Şehir";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(354, 25);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 112);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 9;
            label3.Text = "E-Posta";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(82, 109);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 83);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 7;
            label2.Text = "TC Numarası";
            // 
            // txtSecNumber
            // 
            txtSecNumber.Location = new Point(82, 80);
            txtSecNumber.Name = "txtSecNumber";
            txtSecNumber.Size = new Size(100, 23);
            txtSecNumber.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 54);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Soyad";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(82, 51);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(100, 23);
            txtSurname.TabIndex = 4;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(6, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(22, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Ad";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(795, 610);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(txtDelete);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(787, 582);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Üye Yönetimi";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(AidatGuncelle);
            tabPage2.Controls.Add(aidat);
            tabPage2.Controls.Add(AidatGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(787, 582);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Aidat Yönetimi";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // AidatGuncelle
            // 
            AidatGuncelle.Location = new Point(464, 157);
            AidatGuncelle.Name = "AidatGuncelle";
            AidatGuncelle.Size = new Size(100, 23);
            AidatGuncelle.TabIndex = 2;
            AidatGuncelle.Text = "Güncelle";
            AidatGuncelle.UseVisualStyleBackColor = true;
            AidatGuncelle.Click += AidatGuncelle_Click;
            // 
            // aidat
            // 
            aidat.Location = new Point(464, 103);
            aidat.Name = "aidat";
            aidat.Size = new Size(100, 23);
            aidat.TabIndex = 1;
            // 
            // AidatGridView2
            // 
            AidatGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AidatGridView2.Location = new Point(38, 38);
            AidatGridView2.Name = "AidatGridView2";
            AidatGridView2.RowTemplate.Height = 25;
            AidatGridView2.Size = new Size(368, 346);
            AidatGridView2.TabIndex = 0;
            AidatGridView2.CellClick += AidatGridView2_CellClick;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(BorcluUyeyiGoster);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(MailBody);
            tabPage3.Controls.Add(MailSubject);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(pdfal);
            tabPage3.Controls.Add(BorcluUyelereMailGonder);
            tabPage3.Controls.Add(BorcluUyelerGridView);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(787, 582);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Borclu Uyeler";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // MailBody
            // 
            MailBody.Location = new Point(156, 344);
            MailBody.Name = "MailBody";
            MailBody.Size = new Size(196, 77);
            MailBody.TabIndex = 6;
            MailBody.Text = "";
            // 
            // MailSubject
            // 
            MailSubject.Location = new Point(156, 275);
            MailSubject.Name = "MailSubject";
            MailSubject.Size = new Size(196, 23);
            MailSubject.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(83, 376);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 4;
            label10.Text = "Mail İçeriği";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(83, 278);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 3;
            label9.Text = "Mail Başlığı";
            // 
            // pdfal
            // 
            pdfal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            pdfal.Location = new Point(490, 461);
            pdfal.Name = "pdfal";
            pdfal.Size = new Size(173, 63);
            pdfal.TabIndex = 2;
            pdfal.Text = "PDF Olarak Al";
            pdfal.UseVisualStyleBackColor = true;
            pdfal.Click += pdfal_Click;
            // 
            // BorcluUyelereMailGonder
            // 
            BorcluUyelereMailGonder.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BorcluUyelereMailGonder.Location = new Point(134, 461);
            BorcluUyelereMailGonder.Name = "BorcluUyelereMailGonder";
            BorcluUyelereMailGonder.Size = new Size(235, 63);
            BorcluUyelereMailGonder.TabIndex = 1;
            BorcluUyelereMailGonder.Text = "Borclu Kullanıcılara Mail Gönder";
            BorcluUyelereMailGonder.UseVisualStyleBackColor = true;
            BorcluUyelereMailGonder.Click += BorcluUyelereMailGonder_Click;
            // 
            // BorcluUyelerGridView
            // 
            BorcluUyelerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BorcluUyelerGridView.Location = new Point(41, 41);
            BorcluUyelerGridView.Name = "BorcluUyelerGridView";
            BorcluUyelerGridView.RowTemplate.Height = 25;
            BorcluUyelerGridView.Size = new Size(695, 200);
            BorcluUyelerGridView.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(Search);
            tabPage4.Controls.Add(SearchGridView);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(787, 582);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Sorgu Ekranı";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            Search.Location = new Point(486, 328);
            Search.Name = "Search";
            Search.Size = new Size(149, 56);
            Search.TabIndex = 1;
            Search.Text = "Sorgula";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // SearchGridView
            // 
            SearchGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SearchGridView.Location = new Point(72, 54);
            SearchGridView.Name = "SearchGridView";
            SearchGridView.RowTemplate.Height = 25;
            SearchGridView.Size = new Size(639, 160);
            SearchGridView.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(490, 278);
            label11.Name = "label11";
            label11.Size = new Size(46, 15);
            label11.TabIndex = 7;
            label11.Text = "Uye No";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(542, 275);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 8;
            // 
            // BorcluUyeyiGoster
            // 
            BorcluUyeyiGoster.Location = new Point(490, 344);
            BorcluUyeyiGoster.Name = "BorcluUyeyiGoster";
            BorcluUyeyiGoster.Size = new Size(173, 39);
            BorcluUyeyiGoster.TabIndex = 9;
            BorcluUyeyiGoster.Text = "Boru Olan Uyeyi Göster";
            BorcluUyeyiGoster.UseVisualStyleBackColor = true;
            BorcluUyeyiGoster.Click += button1_Click_1;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 610);
            Controls.Add(tabControl1);
            Name = "MainPage";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AidatGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BorcluUyelerGridView).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SearchGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
        private TextBox txtName;
        private TextBox txtDelete;
        private Button btnDelete;
        private GroupBox groupBox1;
        private Label lblName;
        private CheckBox checkboxState;
        private ComboBox cbxBloodType;
        private Label label4;
        private Label label5;
        private TextBox txtMonthlyPayment;
        private Label label6;
        private Label label7;
        private TextBox txtCity;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtSecNumber;
        private Label label1;
        private TextBox txtSurname;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label8;
        private TextBox txtPhoneNumber;
        private Button AidatGuncelle;
        private TextBox aidat;
        private DataGridView AidatGridView2;
        private TabPage tabPage3;
        private Button BorcluUyelereMailGonder;
        private DataGridView BorcluUyelerGridView;
        private Button pdfal;
        private TabPage tabPage4;
        private Button Search;
        private DataGridView SearchGridView;
        private RichTextBox MailBody;
        private TextBox MailSubject;
        private Label label10;
        private Label label9;
        private Button BorcluUyeyiGoster;
        private TextBox textBox1;
        private Label label11;
    }
}
