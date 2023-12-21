using BusinessLayer;
using EntityLayer.Entities;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms.VisualStyles;

namespace DernekApp
{
    public partial class MainPage : Form
    {
        DernekManager dm = new DernekManager();

        public MainPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dm.ListAll();

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Dernek dernek = new Dernek
            {
                tc = txtSecNumber.Text,
                isim = txtName.Text,
                soyisim = txtSurname.Text,
                sehir = txtCity.Text,
                kanGrubu = txtCity.Text,
            };


            dm.Insert(dernek);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtDelete.Text);
            
            dm.DeleteById(id);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
