using BusinessLayer;
using EntityLayer.Entities;

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dernek d = new Dernek()
            {
                Ad = textBox1.Text
            };

            dm.Insert(d);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dm.DeleteById(1);
        }
    }
}
