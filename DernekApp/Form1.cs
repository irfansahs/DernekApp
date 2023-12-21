using BusinessLayer;
using EntityLayer.Entities;
using System.Data;

namespace DernekApp
{
    public partial class Form1 : Form
    {
        DernekManager dm = new DernekManager(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource =  dm.ListAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dernek d = new Dernek();

            dm.Insert(d);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dm.DeleteById(1);
        }
    }
}
