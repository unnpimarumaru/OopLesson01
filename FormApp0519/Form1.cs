using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp0519
{
    public partial class Form1 : Form
    {//コンストラクタ
        public Form1()
        {
            InitializeComponent();
        }
        //フォームがロードされるタイミングで実行されるイベントハンドラ
        private void Form1_Load(object sender, EventArgs e)
        {
            labelMessage.Text = "";
        }
        //イベントハンドラ
        private void buttonDisp_Click(object sender, EventArgs e)
        {
            labelMessage.Text = "私の名前は"+nametextBox.Text+"です";
        }
    }
}
