using System;
using System.Windows.Forms;
namespace HCI___lab_sheet_4___Multiple_classes_and_Forms
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (f2 == null)
            {
                f2 = new Form2();
                f2.textBox1.Text = "Set from form1";
                f2.FormClosed += delegate { f2 = null; };
            }
            f2.Show();
        }
    }
}
