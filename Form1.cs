using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;  //アンチエイリアスを有効にするため

namespace DrawApp
{
    public partial class Form1 : Form
    {
        Point startPos, endPos;
        Pallet pallet;

        public Form1()
        {
            InitializeComponent();
            this.pallet = new Pallet();
            pallet.Show();
        }

        private void DrawFigures(object sender, PaintEventArgs e)
        {
            // アンチエイリアスを有効にしグラフィックを綺麗にする
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // 円を描画する
            //SolidBrush brush = new SolidBrush(Color.Purple);

            // 固定された円の表示
            //e.Graphics.FillEllipse(brush, 0, 0, 200, 200);

            // 円の自由な描画
            //int width = this.endPos.X - this.startPos.X;
            //int height = this.endPos.Y - this.startPos.Y;

            //e.Graphics.FillEllipse(brush,
            //    this.startPos.X, this.startPos.Y, width, height);


            //int type = 3;                // 図形の種類
            //Color color = Color.Purple;  // 図形の色
            //int penSize = 3;             // ペンの太さ

            // パレット情報を参照する
            int type = this.pallet.GetFigureType();
            Color color = this.pallet.GetColor();
            int penSize = this.pallet.GetPenSize();

            if (type == 1)              // 円を描画する
            {
                SolidBrush brush = new SolidBrush(color);

                int width = this.endPos.X - this.startPos.X;
                int height = this.endPos.Y - this.startPos.Y;

                e.Graphics.FillEllipse(brush,
                    this.startPos.X, this.startPos.Y, width, height);
            }
            else if (type == 2)              // 長方形を描画する
            {
                SolidBrush brush = new SolidBrush(color);

                int width = this.endPos.X - this.startPos.X;
                int height = this.endPos.Y - this.startPos.Y;

                e.Graphics.FillRectangle(brush,
                    this.startPos.X, this.startPos.Y, width, height);
            }
            else if (type == 3)              // 直線を描画する
            {
                Pen p = new Pen(color, penSize);

                e.Graphics.DrawLine(p, 
                    this.startPos.X, this.startPos.Y, 
                    this.endPos.X, this.endPos.Y);
            }
        }

        private void MousePressed(object sender, MouseEventArgs e)
        {
            // 円の支店座標をstartPosに保存する
            this.startPos = new Point(e.X, e.Y);
        }


        private void MouseDragged(object sender, MouseEventArgs e)
        {
            // ドラッグしている場合
            if (e.Button == MouseButtons.Left)
            {
                // 終点座標を更新する
                this.endPos = new Point(e.X, e.Y);
                Invalidate();  // 再描画を指示
            }
        }
    }
}
