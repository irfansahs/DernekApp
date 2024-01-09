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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            txtName = new TextBox();
            txtDelete = new TextBox();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            txtPhoneNumber = new MaskedTextBox();
            txtSecNumber = new MaskedTextBox();
            BirthDay = new DateTimePicker();
            label8 = new Label();
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
            label1 = new Label();
            txtSurname = new TextBox();
            lblName = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label20 = new Label();
            label19 = new Label();
            txtAidatID = new TextBox();
            AidatGuncelle = new Button();
            txtAidat = new TextBox();
            AidatGridView2 = new DataGridView();
            tabPage3 = new TabPage();
            groupBox3 = new GroupBox();
            dateTimePaymentDate = new DateTimePicker();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            btnPayBills = new Button();
            txtPaymentAmount = new TextBox();
            txtUserIdForPayment = new TextBox();
            groupBox2 = new GroupBox();
            MailBody = new RichTextBox();
            MailSubject = new TextBox();
            label10 = new Label();
            label9 = new Label();
            BorcluUyelereMailGonder = new Button();
            BorcluUyeyiGoster = new Button();
            textBox1 = new TextBox();
            label11 = new Label();
            pdfal = new Button();
            BorcluUyelerGridView = new DataGridView();
            tabPage4 = new TabPage();
            btnDateDiff = new Button();
            label18 = new Label();
            label17 = new Label();
            dateSecondDate = new DateTimePicker();
            dateFirstDate = new DateTimePicker();
            btnCitySearch = new Button();
            status = new CheckBox();
            txtSearchCity = new TextBox();
            label13 = new Label();
            label12 = new Label();
            BloodType = new ComboBox();
            btnSearchByBlood = new Button();
            SearchGridView = new DataGridView();
            tabPage5 = new TabPage();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AidatGridView2).BeginInit();
            tabPage3.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BorcluUyelerGridView).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(874, 192);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(278, 207);
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
            txtDelete.Location = new Point(638, 221);
            txtDelete.Name = "txtDelete";
            txtDelete.Size = new Size(78, 23);
            txtDelete.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(638, 256);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 28);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(txtSecNumber);
            groupBox1.Controls.Add(BirthDay);
            groupBox1.Controls.Add(label8);
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
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSurname);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtName);
            groupBox1.Location = new Point(6, 204);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(576, 295);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Üye";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(82, 138);
            txtPhoneNumber.Mask = "(999) 000 00 00";
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(100, 23);
            txtPhoneNumber.TabIndex = 24;
            // 
            // txtSecNumber
            // 
            txtSecNumber.Location = new Point(82, 80);
            txtSecNumber.Mask = "00000000000";
            txtSecNumber.Name = "txtSecNumber";
            txtSecNumber.Size = new Size(100, 23);
            txtSecNumber.TabIndex = 23;
            txtSecNumber.ValidatingType = typeof(int);
            // 
            // BirthDay
            // 
            BirthDay.CustomFormat = "Short";
            BirthDay.Location = new Point(278, 157);
            BirthDay.Name = "BirthDay";
            BirthDay.Size = new Size(200, 23);
            BirthDay.TabIndex = 22;
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
            cbxBloodType.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "0+", "0-" });
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
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(885, 545);
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
            tabPage1.Size = new Size(877, 517);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Üye Yönetimi";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label20);
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(txtAidatID);
            tabPage2.Controls.Add(AidatGuncelle);
            tabPage2.Controls.Add(txtAidat);
            tabPage2.Controls.Add(AidatGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(877, 517);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Aidat Yönetimi";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(580, 113);
            label20.Name = "label20";
            label20.Size = new Size(118, 15);
            label20.TabIndex = 5;
            label20.Text = "Güncellenecek Değer";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(580, 85);
            label19.Name = "label19";
            label19.Size = new Size(56, 15);
            label19.TabIndex = 4;
            label19.Text = "Hangi Ay";
            // 
            // txtAidatID
            // 
            txtAidatID.Location = new Point(712, 77);
            txtAidatID.Name = "txtAidatID";
            txtAidatID.Size = new Size(100, 23);
            txtAidatID.TabIndex = 3;
            // 
            // AidatGuncelle
            // 
            AidatGuncelle.Location = new Point(712, 147);
            AidatGuncelle.Name = "AidatGuncelle";
            AidatGuncelle.Size = new Size(100, 23);
            AidatGuncelle.TabIndex = 2;
            AidatGuncelle.Text = "Güncelle";
            AidatGuncelle.UseVisualStyleBackColor = true;
            AidatGuncelle.Click += AidatGuncelle_Click;
            // 
            // txtAidat
            // 
            txtAidat.Location = new Point(712, 106);
            txtAidat.Name = "txtAidat";
            txtAidat.Size = new Size(100, 23);
            txtAidat.TabIndex = 1;
            // 
            // AidatGridView2
            // 
            AidatGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AidatGridView2.Location = new Point(3, 3);
            AidatGridView2.Name = "AidatGridView2";
            AidatGridView2.RowTemplate.Height = 25;
            AidatGridView2.Size = new Size(537, 461);
            AidatGridView2.TabIndex = 0;
            AidatGridView2.CellClick += AidatGridView2_CellClick;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox3);
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Controls.Add(BorcluUyeyiGoster);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(pdfal);
            tabPage3.Controls.Add(BorcluUyelerGridView);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(877, 517);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Borclu Uyeler";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dateTimePaymentDate);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(btnPayBills);
            groupBox3.Controls.Add(txtPaymentAmount);
            groupBox3.Controls.Add(txtUserIdForPayment);
            groupBox3.Location = new Point(337, 254);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(249, 152);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ödeme Al";
            // 
            // dateTimePaymentDate
            // 
            dateTimePaymentDate.Location = new Point(104, 84);
            dateTimePaymentDate.Name = "dateTimePaymentDate";
            dateTimePaymentDate.Size = new Size(110, 23);
            dateTimePaymentDate.TabIndex = 7;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 88);
            label16.Name = "label16";
            label16.Size = new Size(77, 15);
            label16.TabIndex = 6;
            label16.Text = "Ödenen Tarih";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 59);
            label15.Name = "label15";
            label15.Size = new Size(41, 15);
            label15.TabIndex = 4;
            label15.Text = "Miktar";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 30);
            label14.Name = "label14";
            label14.Size = new Size(20, 15);
            label14.TabIndex = 3;
            label14.Text = "TC";
            // 
            // btnPayBills
            // 
            btnPayBills.Location = new Point(83, 121);
            btnPayBills.Name = "btnPayBills";
            btnPayBills.Size = new Size(75, 23);
            btnPayBills.TabIndex = 2;
            btnPayBills.Text = "Ödeme";
            btnPayBills.UseVisualStyleBackColor = true;
            btnPayBills.Click += btnPayBills_Click;
            // 
            // txtPaymentAmount
            // 
            txtPaymentAmount.Location = new Point(104, 51);
            txtPaymentAmount.Name = "txtPaymentAmount";
            txtPaymentAmount.Size = new Size(100, 23);
            txtPaymentAmount.TabIndex = 1;
            // 
            // txtUserIdForPayment
            // 
            txtUserIdForPayment.Location = new Point(104, 22);
            txtUserIdForPayment.Name = "txtUserIdForPayment";
            txtUserIdForPayment.Size = new Size(100, 23);
            txtUserIdForPayment.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(MailBody);
            groupBox2.Controls.Add(MailSubject);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(BorcluUyelereMailGonder);
            groupBox2.Location = new Point(13, 242);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(316, 258);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mail Gönder";
            // 
            // MailBody
            // 
            MailBody.Location = new Point(87, 70);
            MailBody.Name = "MailBody";
            MailBody.Size = new Size(196, 77);
            MailBody.TabIndex = 6;
            MailBody.Text = "";
            // 
            // MailSubject
            // 
            MailSubject.Location = new Point(87, 27);
            MailSubject.Name = "MailSubject";
            MailSubject.Size = new Size(196, 23);
            MailSubject.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 102);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 4;
            label10.Text = "Mail İçeriği";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 27);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 3;
            label9.Text = "Mail Başlığı";
            // 
            // BorcluUyelereMailGonder
            // 
            BorcluUyelereMailGonder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BorcluUyelereMailGonder.Location = new Point(73, 164);
            BorcluUyelereMailGonder.Name = "BorcluUyelereMailGonder";
            BorcluUyelereMailGonder.Size = new Size(210, 63);
            BorcluUyelereMailGonder.TabIndex = 1;
            BorcluUyelereMailGonder.Text = "Borclu Kullanıcılara Mail Gönder";
            BorcluUyelereMailGonder.UseVisualStyleBackColor = true;
            BorcluUyelereMailGonder.Click += BorcluUyelereMailGonder_Click;
            // 
            // BorcluUyeyiGoster
            // 
            BorcluUyeyiGoster.Location = new Point(627, 359);
            BorcluUyeyiGoster.Name = "BorcluUyeyiGoster";
            BorcluUyeyiGoster.Size = new Size(173, 39);
            BorcluUyeyiGoster.TabIndex = 9;
            BorcluUyeyiGoster.Text = "Borcu Olan Uyeyi Göster";
            BorcluUyeyiGoster.UseVisualStyleBackColor = true;
            BorcluUyeyiGoster.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(656, 261);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(604, 264);
            label11.Name = "label11";
            label11.Size = new Size(46, 15);
            label11.TabIndex = 7;
            label11.Text = "Uye No";
            // 
            // pdfal
            // 
            pdfal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pdfal.Location = new Point(643, 304);
            pdfal.Name = "pdfal";
            pdfal.Size = new Size(134, 37);
            pdfal.TabIndex = 2;
            pdfal.Text = "PDF Olarak Al";
            pdfal.UseVisualStyleBackColor = true;
            pdfal.Click += pdfal_Click;
            // 
            // BorcluUyelerGridView
            // 
            BorcluUyelerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BorcluUyelerGridView.Dock = DockStyle.Top;
            BorcluUyelerGridView.Location = new Point(3, 3);
            BorcluUyelerGridView.Name = "BorcluUyelerGridView";
            BorcluUyelerGridView.RowTemplate.Height = 25;
            BorcluUyelerGridView.Size = new Size(871, 195);
            BorcluUyelerGridView.TabIndex = 0;
            BorcluUyelerGridView.CellClick += BorcluUyelerGridView_CellClick;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btnDateDiff);
            tabPage4.Controls.Add(label18);
            tabPage4.Controls.Add(label17);
            tabPage4.Controls.Add(dateSecondDate);
            tabPage4.Controls.Add(dateFirstDate);
            tabPage4.Controls.Add(btnCitySearch);
            tabPage4.Controls.Add(status);
            tabPage4.Controls.Add(txtSearchCity);
            tabPage4.Controls.Add(label13);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(BloodType);
            tabPage4.Controls.Add(btnSearchByBlood);
            tabPage4.Controls.Add(SearchGridView);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(877, 517);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Sorgu Ekranı";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnDateDiff
            // 
            btnDateDiff.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDateDiff.Location = new Point(445, 335);
            btnDateDiff.Name = "btnDateDiff";
            btnDateDiff.Size = new Size(97, 33);
            btnDateDiff.TabIndex = 13;
            btnDateDiff.Text = "Sorgula";
            btnDateDiff.UseVisualStyleBackColor = true;
            btnDateDiff.Click += btnDateDiff_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(669, 255);
            label18.Name = "label18";
            label18.Size = new Size(44, 15);
            label18.TabIndex = 12;
            label18.Text = "2. Tarih";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(445, 255);
            label17.Name = "label17";
            label17.Size = new Size(44, 15);
            label17.TabIndex = 11;
            label17.Text = "1. Tarih";
            // 
            // dateSecondDate
            // 
            dateSecondDate.CustomFormat = "yyyy-MM-dd";
            dateSecondDate.Location = new Point(669, 289);
            dateSecondDate.Name = "dateSecondDate";
            dateSecondDate.Size = new Size(200, 23);
            dateSecondDate.TabIndex = 10;
            dateSecondDate.Value = new DateTime(2024, 1, 4, 0, 0, 0, 0);
            // 
            // dateFirstDate
            // 
            dateFirstDate.CustomFormat = "yyyy-MM-dd";
            dateFirstDate.Location = new Point(445, 289);
            dateFirstDate.Name = "dateFirstDate";
            dateFirstDate.Size = new Size(200, 23);
            dateFirstDate.TabIndex = 9;
            dateFirstDate.Value = new DateTime(2024, 1, 9, 0, 0, 0, 0);
            // 
            // btnCitySearch
            // 
            btnCitySearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCitySearch.Location = new Point(249, 338);
            btnCitySearch.Name = "btnCitySearch";
            btnCitySearch.Size = new Size(97, 33);
            btnCitySearch.TabIndex = 8;
            btnCitySearch.Text = "Sorgula";
            btnCitySearch.UseVisualStyleBackColor = true;
            btnCitySearch.Click += btnCitySearch_Click;
            // 
            // status
            // 
            status.AutoSize = true;
            status.Checked = true;
            status.CheckState = CheckState.Checked;
            status.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            status.Location = new Point(99, 383);
            status.Name = "status";
            status.Size = new Size(89, 29);
            status.TabIndex = 7;
            status.Text = "Durum";
            status.UseVisualStyleBackColor = true;
            // 
            // txtSearchCity
            // 
            txtSearchCity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchCity.Location = new Point(99, 335);
            txtSearchCity.Name = "txtSearchCity";
            txtSearchCity.Size = new Size(121, 33);
            txtSearchCity.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(38, 338);
            label13.Name = "label13";
            label13.Size = new Size(55, 25);
            label13.TabIndex = 4;
            label13.Text = "Şehir";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(49, 292);
            label12.Name = "label12";
            label12.Size = new Size(44, 25);
            label12.TabIndex = 3;
            label12.Text = "Kan";
            // 
            // BloodType
            // 
            BloodType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BloodType.FormattingEnabled = true;
            BloodType.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "0+", "0-" });
            BloodType.Location = new Point(99, 289);
            BloodType.Name = "BloodType";
            BloodType.Size = new Size(121, 33);
            BloodType.TabIndex = 2;
            // 
            // btnSearchByBlood
            // 
            btnSearchByBlood.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchByBlood.Location = new Point(249, 289);
            btnSearchByBlood.Name = "btnSearchByBlood";
            btnSearchByBlood.Size = new Size(97, 33);
            btnSearchByBlood.TabIndex = 1;
            btnSearchByBlood.Text = "Sorgula";
            btnSearchByBlood.UseVisualStyleBackColor = true;
            btnSearchByBlood.Click += Search_Click;
            // 
            // SearchGridView
            // 
            SearchGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SearchGridView.Location = new Point(49, 39);
            SearchGridView.Name = "SearchGridView";
            SearchGridView.RowTemplate.Height = 25;
            SearchGridView.Size = new Size(771, 160);
            SearchGridView.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(877, 517);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Grafikler";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 545);
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
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BorcluUyelerGridView).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
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
        private Label label1;
        private TextBox txtSurname;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label8;
        private Button AidatGuncelle;
        private TextBox txtAidat;
        private DataGridView AidatGridView2;
        private TabPage tabPage3;
        private Button BorcluUyelereMailGonder;
        private DataGridView BorcluUyelerGridView;
        private Button pdfal;
        private TabPage tabPage4;
        private Button btnSearchByBlood;
        private DataGridView SearchGridView;
        private RichTextBox MailBody;
        private TextBox MailSubject;
        private Label label10;
        private Label label9;
        private Button BorcluUyeyiGoster;
        private TextBox textBox1;
        private Label label11;
        private Label label12;
        private ComboBox BloodType;
        private TextBox txtSearchCity;
        private Label label13;
        private CheckBox status;
        private DateTimePicker BirthDay;
        private TabPage tabPage5;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnCitySearch;
        private MaskedTextBox txtPhoneNumber;
        private MaskedTextBox txtSecNumber;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DateTimePicker dateTimePaymentDate;
        private Label label16;
        private Label label15;
        private Label label14;
        private Button btnPayBills;
        private TextBox txtPaymentAmount;
        private TextBox txtUserIdForPayment;
        private TextBox txtAidatID;
        private Button btnDateDiff;
        private Label label18;
        private Label label17;
        private DateTimePicker dateSecondDate;
        private DateTimePicker dateFirstDate;
        private Label label20;
        private Label label19;
    }
}
