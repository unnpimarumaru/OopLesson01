using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddTax
{
    public partial class AddTax : Form
    {
        public AddTax()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void buttonAddTax_Click(object sender, EventArgs e)
        {
            //変数の宣言
            int money; 　　  　//お金作業用変数
            double addTax;　   //税込み金額格納用
            double tax = (int)numericUpDown1.Value * 0.01;  //消費税10％

            //「金額」　テキストボックスの値を整数型変数に取得
            money = int.Parse(textBoxMoney.Text);

            //消費税を加算し税込み金額を算出
            addTax = money;
            addTax *= (1 + tax);

            //整数型キャスト(明示的型変換）
            money = (int)addTax;
            
            //税込金額をラベルに表示
            labelAddTax.Text = money + "円";

        }

        private void labelAddTax_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
