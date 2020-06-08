using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0526
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttoninput_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(number1.Text); //数値１の値を格納
            int num2 = int.Parse(number2.Text);//数値１の値を格納

            int anser = num1 * num2;

            labelResult.Text = anser.ToString();
        }
    }
}
