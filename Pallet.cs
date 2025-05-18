using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawApp
{
    public partial class Pallet : Form
    {
        int figureType;  // 図形の種類


        // 図形の種類を取得
        public int GetFigureType()
        {
            return figureType;
        }

        // ペンの太さを取得する
        public int GetPenSize()
        {
            int size;
            if (int.TryParse(this.penSizeBox.Text, out size))
            {
                return size;
            }
            else 
            {
                return 1;
            }
        }


        // 図形の色を取得
        public Color GetColor()
        {
            return colorButton.BackColor;
        }

        public Pallet()
        {
            InitializeComponent();
            this.figureType = 1;
        }

        private void CircleButtonClicked(object sender, EventArgs e)
        {
            this.figureType = 1;
        }

        private void RectButtonClicked(object sender, EventArgs e)
        {
            this.figureType = 2;
        }

        private void LineButtonClicked(object sender, EventArgs e)
        {
            this.figureType = 3;
        }

        private void ColorButtonClicked(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // 選択した色をボタンに設定する
                colorButton.BackColor = colorDialog.Color;
            }
        }

    }
}
