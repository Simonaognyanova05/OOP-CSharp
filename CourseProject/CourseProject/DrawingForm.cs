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
        private bool isResizing = false;
        private Point lastMousePosition;
        private const int HandleSize = 10;
        private Color selectedColor = Color.Black; 

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

            Button btnColor = new Button { Text = "Choose Color", Dock = DockStyle.Top };
            btnColor.Click += BtnColor_Click;
            this.Controls.Add(btnColor);
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedColor = colorDialog.Color;
                    shape.ShapeColor = selectedColor;
                    this.Invalidate();
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (shape != null)
            {
                shape.Draw(e.Graphics);
                DrawResizeHandle(e.Graphics);
            }
        }

        private void DrawResizeHandle(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color.Red))
            {
                if (shape is Circle circle)
                {
                    g.FillRectangle(brush,
                        circle.X + circle.Radius - HandleSize / 2,
                        circle.Y + circle.Radius - HandleSize / 2,
                        HandleSize, HandleSize);
                }
                else if (shape is Rectangle rect)
                {
                    g.FillRectangle(brush,
                        rect.X + rect.Width - HandleSize / 2,
                        rect.Y + rect.Height - HandleSize / 2,
                        HandleSize, HandleSize);
                }
                else if (shape is Square square)
                {
                    g.FillRectangle(brush,
                        square.X + square.A - HandleSize / 2,
                        square.Y + square.A - HandleSize / 2,
                        HandleSize, HandleSize);
                }
                else if (shape is Triangle triangle)
                {
                    g.FillRectangle(brush,
                        triangle.X + triangle.BaseLength / 2 - HandleSize / 2,
                        triangle.Y - triangle.Height - HandleSize / 2,
                        HandleSize, HandleSize);
                }
            }
        }

        private void DrawingForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsMouseOverResizeHandle(e.Location))
            {
                isResizing = true;
                lastMousePosition = e.Location;
            }
            else if (IsMouseOverShape(e.Location))
            {
                isDragging = true;
                lastMousePosition = e.Location;
            }
        }

        private void DrawingForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isResizing && shape != null)
            {
                int deltaX = e.X - lastMousePosition.X;
                int deltaY = e.Y - lastMousePosition.Y;

                if (shape is Circle circle)
                {
                    circle.Radius += deltaX;
                }
                else if (shape is Rectangle rect)
                {
                    rect.Width += deltaX;
                    rect.Height += deltaY;
                }
                else if (shape is Square square)
                {
                    square.A += Math.Min(deltaX, deltaY);
                }
                else if (shape is Triangle triangle)
                {
                    triangle.BaseLength += deltaX;
                    triangle.Height += deltaY;
                }

                lastMousePosition = e.Location;
                this.Invalidate();
            }
            else if (isDragging && shape != null)
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
            isResizing = false;
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

        private bool IsMouseOverResizeHandle(Point mousePosition)
        {
            if (shape is Circle circle)
            {
                return Math.Abs(mousePosition.X - (circle.X + circle.Radius)) <= HandleSize &&
                       Math.Abs(mousePosition.Y - (circle.Y + circle.Radius)) <= HandleSize;
            }
            else if (shape is Rectangle rect)
            {
                return Math.Abs(mousePosition.X - (rect.X + rect.Width)) <= HandleSize &&
                       Math.Abs(mousePosition.Y - (rect.Y + rect.Height)) <= HandleSize;
            }
            else if (shape is Square square)
            {
                return Math.Abs(mousePosition.X - (square.X + square.A)) <= HandleSize &&
                       Math.Abs(mousePosition.Y - (square.Y + square.A)) <= HandleSize;
            }
            else if (shape is Triangle triangle)
            {
                return Math.Abs(mousePosition.X - (triangle.X + triangle.BaseLength / 2)) <= HandleSize &&
                       Math.Abs(mousePosition.Y - (triangle.Y - triangle.Height)) <= HandleSize;
            }
            return false;
        }

        private void DrawingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
