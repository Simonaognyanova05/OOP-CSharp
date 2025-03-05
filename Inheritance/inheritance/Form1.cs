using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Pen pen = new Pen(Color.Red, 2);
            Graphics graphics = e.Graphics;

            graphics.DrawLine(pen, 60, 160, 90, 90);
            graphics.DrawLine(pen, 60, 160, 30, 90);
            graphics.DrawLine(pen, 30, 90, 90, 90);


        }
    }
}
