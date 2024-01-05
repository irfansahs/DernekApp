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
using iTextSharp.text;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using ZedGraph;
using System.ComponentModel;


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
            dataGridView1.DataSource = um.ListAll();
            AidatGridView2.DataSource = am.ListAll();
            BorcluUyelerGridView.DataSource = dm.ListAll();
            SearchGridView.DataSource = um.ListAll();
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
                email = txtEmail.Text,
                sehir = txtCity.Text,
                kanGrubu = cbxBloodType.Text,
                dogTarih = DateTime.Parse(BirthDay.Text),
                durum = checkboxState.Checked,
            };
            Dernek borcListesi = new Dernek
            {
                tc = txtSecNumber.Text,
                email = txtEmail.Text
            };
            try
            {
                um.Insert(uye);
                dm.Insert(borcListesi);

            }
            catch (Exception)
            {

                throw;
            }

            dataGridView1.DataSource = um.ListAll();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(txtDelete.Text);
                dm.DeleteById(id);


            }
            catch (Exception)
            {

                MessageBox.Show("Üye silerken hata oluþtu. Lütfen üyenin ID'sini doðru girin!");
            }
            dataGridView1.DataSource = um.ListAll();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AidatGuncelle_Click(object sender, EventArgs e)
        {


            Aidat a = new Aidat
            {
                aidat = Int32.Parse(txtAidat.Text)
            };


            am.Update(a);
        }

        private void AidatGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.AidatGridView2.Rows[e.RowIndex];
            txtAidat.Text = row.Cells["aidat"].Value.ToString();
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
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                using (iTextSharp.text.Document document = new iTextSharp.text.Document())
                {
                    PdfWriter writer = PdfWriter.GetInstance(document, stream);

                    document.Open();
                    PdfPTable pdfTable = new PdfPTable(dataTable.Columns.Count);

                    foreach (DataColumn column in dataTable.Columns)
                    {
                        pdfTable.AddCell(new Phrase(column.ColumnName));
                    }

                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            pdfTable.AddCell(new Phrase(item.ToString()));
                        }
                    }

                    document.Add(pdfTable);
                    document.Close();
                }
            }
        }

        private void pdfal_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            foreach (DataGridViewColumn column in BorcluUyelerGridView.Columns)
            {
                dataTable.Columns.Add(column.HeaderText, typeof(string));
            }

            foreach (DataGridViewRow row in BorcluUyelerGridView.Rows)
            {
                if (row.IsNewRow) continue;
                DataRow dataRow = dataTable.NewRow();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    dataRow[i] = row.Cells[i].Value?.ToString() ?? "";
                }
                dataTable.Rows.Add(dataRow);
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Dosyalarý|*.pdf";
            saveFileDialog.Title = "PDF Dosyasýný Kaydet";
            saveFileDialog.FileName = "deneme.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pdfFilePath = saveFileDialog.FileName;
                ExportDataTableToPdf(dataTable, pdfFilePath);

                MessageBox.Show("PDF dosyasý oluþturuldu: " + pdfFilePath);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BorcluUyelerGridView.DataSource = dm.Borclular();
        }
        private void Search_Click(object sender, EventArgs e)
        {

            string bloodType = BloodType.Text;
            bool durum = status.Checked;

            SearchGridView.DataSource = um.SearchByBloodTypeAndStatus(bloodType, durum);
        }

        private void btnCitySearch_Click(object sender, EventArgs e)
        {
            string sehir = txtSearchCity.Text;
            bool durum = status.Checked;

            SearchGridView.DataSource = um.SearchByCityAndStatus(sehir, durum);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell selectedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (selectedCell.Value != null)
                {
                    txtDelete.Text = selectedCell.Value.ToString();
                }
            }
        }

        private void btnPayBills_Click(object sender, EventArgs e)
        {
            Dernek dernek = new Dernek
            {
                tc = txtUserIdForPayment.Text,
                odemeTarihi = DateOnly.Parse(dateTimePaymentDate.Text),
                odenenBorc = Int32.Parse(txtPaymentAmount.Text),
            };

            int result = dm.BorcOde(dernek);
            if (result > 0)
            {
                MessageBox.Show("Ödeme baþarýlý.");
            }
            else
            {
                MessageBox.Show("Ödeme baþarýsýz. Lütfen bilgileri kontrol edin.");
            }


        }

        private void BorcluUyelerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell selectedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (selectedCell.Value != null)
                {
                    txtUserIdForPayment.Text = selectedCell.Value.ToString();
                }
            }
        }
    }
}

