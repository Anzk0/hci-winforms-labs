using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI___lab_sheet_5___Programming_review_calculator
{
    public partial class simpleCalc : Form
    {
        public simpleCalc()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Calculator myCalc = new Calculator();
            double n1 = System.Convert.ToDouble(number1.Text);
            double n2 = System.Convert.ToDouble(number2.Text);
            resultLbl.Text = myCalc.Add(n1, n2).ToString();
        }
    }
}
