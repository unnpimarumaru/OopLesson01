using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListColklectionSample
{
    public partial class Form1 : Form
    {
        //車を入れるバインティングリスト
        BindingList<Car> cars = new BindingList<Car>();

        public Image Nothing { get; private set; }

        public Form1()
        {
            InitializeComponent();
            dgvCarData.DataSource = cars;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
           

            if(tbName.Text == "")
            {
                MessageBox.Show("車名を入力してください");
            }
            else
            {
                Car car = new Car()
                {

                    Name = tbName.Text,

                    Maker = cbMaker.Text,

                    Category = tbCategory.Text,

                    carPic = pdImage.Image,
                };
                //メーカーをコンボボックスの入力候補に登録
                setcomboboxMaker(cbMaker.Text);

                cars.Insert(0, car);

                AllClearMethod();

                initButton();

                nullCurrent();

            }

        }

        //入力項目全クリア
        private void AllClearMethod()
        {

            tbName.Clear();
            cbMaker.Text = ("");
            tbCategory.Clear();
            pdImage.Image = null;
        }

        //メーカーコンボボックスの入力候補登録
        private void setcomboboxMaker(string maker)
        {//!で条件反転
            if (!cbMaker.Items.Contains(maker))
            {
                //コンボボックスの追加
                cbMaker.Items.Add(maker);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //選択した画像をピクチャーボックスに表示
                pdImage.Image = Image.FromFile(openFileDialog1.FileName);
                //ピクチャーボックスのサイズに画像を調整
                pdImage.SizeMode = PictureBoxSizeMode.StretchImage;


            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            pdImage.Image = null;
        }

        private void dgvCarData_Click(object sender, EventArgs e)
        {
            //選択したレコードを取り出す
            //データグリッドビューで選択した行のインデックスを元に
            //BindingListのデータを取得する
            Car selectedCar = cars[dgvCarData.CurrentRow.Index];

            tbName.Text = selectedCar.Name;
            cbMaker.Text= selectedCar.Maker;
            tbCategory.Text = selectedCar.Category;
            pdImage.Image = selectedCar.carPic;

            initButton();
        }
        //選択したレコードの変更
        private void btModify_Click(object sender, EventArgs e)
        {
            //変更対象のレコード
            Car ChengeCar = cars[dgvCarData.CurrentRow.Index];

            ChengeCar.Name = tbName.Text;
            ChengeCar.Maker = cbMaker.Text ;
            ChengeCar.Category = tbCategory.Text;
            ChengeCar.carPic=  pdImage.Image;

            dgvCarData.Refresh(); //データグリッドビューの再読み込み
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initButton();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            cars.RemoveAt(dgvCarData.CurrentRow.Index);
            initButton();
            nullCurrent();
            AllClearMethod();
        }


        private void initButton()
        {
            if(cars.Count <= 0 )
            {
                btModify.Enabled = false;
                btDelete.Enabled = false;
            }
            else
            {
                btModify.Enabled = true;
                btDelete.Enabled = true;
            }
        }
        private void nullCurrent()
        {
            dgvCarData.CurrentCell = null;
            btDelete.Enabled = false;
            btModify.Enabled = false;

        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 新規入力ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllClearMethod();
        }
    }
}
