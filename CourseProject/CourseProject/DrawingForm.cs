using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class DrawingForm : Form
    {
        private Shape shape;
        private bool isDragging = false; 
        private Point lastMousePosition;

        public DrawingForm(Shape shape)
        {
            InitializeComponent();
            this.shape = shape;
            this.Text = "Draw Shape";
            this.BackColor = Color.White;
            this.Size = new Size(500, 500);

            this.MouseDown += DrawingForm_MouseDown;
            this.MouseMove += DrawingForm_MouseMove;
            this.MouseUp += DrawingForm_MouseUp;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (shape != null)
            {
                shape.Draw(e.Graphics);
            }
        }

        private void DrawingForm_Load(object sender, EventArgs e)
        {
        }
        private void DrawingForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (shape != null &&
                IsMouseOverShape(e.Location))
            {
                isDragging = true;
                lastMousePosition = e.Location;
            }
        }
        private void DrawingForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && shape != null)
            {
                int deltaX = e.X - lastMousePosition.X;
                int deltaY = e.Y - lastMousePosition.Y;

                shape.X += deltaX;
                shape.Y += deltaY;

                lastMousePosition = e.Location;

                this.Invalidate();
            }
        }

        private void DrawingForm_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private bool IsMouseOverShape(Point mousePosition)
        {
            if (shape is Circle circle)
            {
                int dx = mousePosition.X - circle.X;
                int dy = mousePosition.Y - circle.Y;
                return dx * dx + dy * dy <= circle.Radius * circle.Radius;
            }
            else if (shape is Rectangle rect)
            {
                return mousePosition.X >= rect.X && mousePosition.X <= rect.X + rect.Width &&
                       mousePosition.Y >= rect.Y && mousePosition.Y <= rect.Y + rect.Height;
            }
            else if (shape is Square square)
            {
                return mousePosition.X >= square.X && mousePosition.X <= square.X + square.A &&
                       mousePosition.Y >= square.Y && mousePosition.Y <= square.Y + square.A;
            }
            else if (shape is Triangle triangle)
            {
                int baseX = triangle.X;
                int baseY = triangle.Y;
                return mousePosition.Y <= baseY && mousePosition.Y >= baseY - triangle.Height &&
                       mousePosition.X >= baseX - triangle.BaseLength / 2 &&
                       mousePosition.X <= baseX + triangle.BaseLength / 2;
            }
            return false;
        }
    }
}
