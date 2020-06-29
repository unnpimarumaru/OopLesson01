using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
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
            Car car = new Car()
            {

                Name = tbName.Text,

                Maker = tbMaker.Text,

                Category = tbCategory.Text,

                carPic = pdImage.Image,
            };

            NewMethod(car);

        }
        //入力項目全クリア
        private void NewMethod(Car car)
        {
            cars.Insert(0, car);

            tbName.Clear();
            tbMaker.Clear();
            tbCategory.Clear();
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
            tbMaker.Text= selectedCar.Maker;
            tbCategory.Text = selectedCar.Category;
            pdImage.Image = selectedCar.carPic;
        }
        //選択したレコードの変更
        private void btModify_Click(object sender, EventArgs e)
        {
            //変更対象のレコード
            Car ChengeCar = cars[dgvCarData.CurrentRow.Index];

            ChengeCar.Name = tbName.Text;
            ChengeCar.Maker = tbMaker.Text ;
            ChengeCar.Category = tbCategory.Text;
            ChengeCar.carPic=  pdImage.Image;

            dgvCarData.Refresh(); //データグリッドビューの再読み込み
        }
              
    }
}
