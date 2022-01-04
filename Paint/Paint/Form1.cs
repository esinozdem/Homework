using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        private Point _startPoint;
        private Pen _pen;
        private Graphics _graphics;
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            this._graphics = pictureBox.CreateGraphics();
            this._pen = new Pen(Color.Black, 2);
            this.ChangeColor(this._pen.Color);

            pictureBox.MouseDown += PictureBox_MouseDown;
            pictureBox.MouseMove += PictureBox_MouseMove;
            pictureBox.MouseUp += PictureBox_MouseUp;
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            this._startPoint = Point.Empty;
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!this._startPoint.IsEmpty)
            {
                this._graphics.DrawLine(this._pen, this._startPoint, e.Location);
                this._startPoint = e.Location;
            }
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            this._startPoint = e.Location;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ChangeColor(Color color)
        {
            btnActiveColor.BackColor = color;
            this._pen.Color = color;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            this.ChangeColor(Color.Red);
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            this.ChangeColor(Color.Blue);
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            this.ChangeColor(Color.Yellow);
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            this.ChangeColor(Color.Black);
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            this.ChangeColor(Color.White);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Close();
        }
    }
}
