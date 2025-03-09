using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawFigures
{
    public partial class DrawForm : Form
    {
        private Shape shape;

        public DrawForm(Shape shape)
        {
            InitializeComponent();
            this.shape = shape;

            // Настройки на формата
            this.Text = "Draw Shape";
            this.BackColor = Color.White;
            this.Size = new Size(500, 500);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (shape != null)
            {
                shape.Draw(e.Graphics);
            }
        }

        private void DrawForm_Load(object sender, EventArgs e)
        {

        }
    }
}
