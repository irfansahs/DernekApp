using BusinessLayer;
using EntityLayer.Entities;
using System.Data;
using System.Data.OleDb;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms.VisualStyles;
using System.Reflection.Metadata;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using iText.Layout.Element;


namespace DernekApp
{
    public partial class MainPage : Form
    {
        DernekManager dm = new DernekManager();
        AidatManager am = new AidatManager();
        UyeManager um = new UyeManager();

        public MainPage()
        {
            InitializeComponent();
        }

        public void yenile()
        {
            dataGridView1.DataSource = dm.ListAll();
            AidatGridView2.DataSource = am.ListAll();
            BorcluUyelerGridView.DataSource = dm.ListAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            yenile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uye uye = new Uye
            {
                tc = txtSecNumber.Text,
                isim = txtName.Text,
                soyisim = txtSurname.Text,
                sehir = txtCity.Text,
                kanGrubu = cbxBloodType.Text,
                dogTarih = DateTime.Parse(BirthDay.Text),
                durum = checkboxState.Checked,
            };

            um.Insert(uye);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDelete.Text);

            dm.DeleteById(id);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AidatGuncelle_Click(object sender, EventArgs e)
        {

            aidat.Text = "awd";

            Aidat a = new Aidat
            {
                aidat = 100,
            };

            am.Update(a);
        }

        private void AidatGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.AidatGridView2.Rows[e.RowIndex];

            aidat.Text = row.Cells["aidat"].Value.ToString();



        }

        private void BorcluUyelereMailGonder_Click(object sender, EventArgs e)
        {

            EmailMessage email = new EmailMessage
            {
                FromAddress = "gonderen@example.com",
                Password = "gonderenin_sifresi",
                ToAddress = "black969691@gmail.com",
                Subject = MailSubject.Text,
                Body = MailBody.Text
            };

            try
            {
                EmailService emailService = new EmailService();
                emailService.SendEmail(email);
            }
            catch (Exception)
            {
                MessageBox.Show("Mail Adersi Doðru deðil");
            }


        }

        private static void ExportDataTableToPdf(DataTable dataTable, string filePath)
        {
            /*
            using (PdfWriter writer = new PdfWriter(filePath))
            using (PdfDocument pdf = new PdfDocument(writer))
            using (Document document = new Document(pdf))
            {
                Table table = new Table(dataTable.Columns.Count);

                // Ýlk satýr baþlýk olacak
                foreach (DataColumn column in dataTable.Columns)
                {
                    table.AddHeaderCell(new Cell().Add(new Paragraph(column.ColumnName)));
                }

                // Diðer satýrlar verileri içerecek
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(item.ToString())));
                    }
                }

                // Tabloyu belgeye ekle
                pdf.Add((iTextSharp.text.IElement)table);
            }
            */

        }

        private void pdfal_Click(object sender, EventArgs e)
        {
            // DataGridView'daki verileri bir DataTable'a al
            DataTable dataTable = new DataTable();
            foreach (DataGridViewColumn column in BorcluUyelerGridView.Columns)
            {
                dataTable.Columns.Add(column.HeaderText, column.ValueType);
            }

            foreach (DataGridViewRow row in BorcluUyelerGridView.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value;
                }
                dataTable.Rows.Add(dataRow);
            }

            // DataTable'ý PDF'e dönüþtür
            string pdfFilePath = "C:\\awdawdawdawdawd";
            ExportDataTableToPdf(dataTable, pdfFilePath);

            MessageBox.Show("PDF dosyasý oluþturuldu: " + pdfFilePath);
        }

        private void Search_Click(object sender, EventArgs e)
        {

            var bloodType = BloodType.SelectedIndex;

            var city = City.Text;

            bool durum = status.Checked;

            SearchGridView.DataSource = um.Search("Ahmet", "Kemal", "");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SearchGridView.DataSource = um.Search("Ahmet", "Kemal", "");// getById ile borclu olan uyenin aidatlarýný göstereceðiz
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
