using BusinessLayer;
using EntityLayer.Entities;
using System.Data;

namespace DernekApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DernekManager dm = new DernekManager();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource =  dm.ListAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataTable dataTable = new DataTable();

            dm.Insert(dataTable);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dm.DeleteById(1);
        }
    }
}
