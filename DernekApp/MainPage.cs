using BusinessLayer;
using EntityLayer.Entities;
using System.Data;

namespace DernekApp
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        DernekManager dm = new DernekManager();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dm.ListAll();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable d = new DataTable();

            dm.Insert(d);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dm.DeleteById(1);
        }
    }
}
