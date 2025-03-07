using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class SecondForm : Form
    {
        private int x, y, width, height;
        public SecondForm(int x, int y, int width, int height)
        {
            InitializeComponent();
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;

            this.Text = "Draw Form";
            this.BackColor = Color.White;
            this.Size = new Size(400, 400);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);

            g.DrawRectangle(pen, x, y, width, height);
        }
        private void SecondForm_Load(object sender, EventArgs e)
        {

        }
    }
}
