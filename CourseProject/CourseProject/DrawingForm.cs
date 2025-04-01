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
        private Button colorButton;

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

            colorButton = new Button();
            colorButton.Text = "Избери цвят";
            colorButton.Location = new Point(10, 10);
            colorButton.Click += btnColor_Click;
            this.Controls.Add(colorButton);
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
            if (shape is Circle circle)
            {
                g.FillRectangle(Brushes.Red,
                    circle.X + circle.Radius - HandleSize / 2,
                    circle.Y + circle.Radius - HandleSize / 2,
                    HandleSize, HandleSize);
            }
            else if (shape is Rectangle rect)
            {
                g.FillRectangle(Brushes.Red,
                    rect.X + rect.Width - HandleSize / 2,
                    rect.Y + rect.Height - HandleSize / 2,
                    HandleSize, HandleSize);
            }
            else if (shape is Square square)
            {
                g.FillRectangle(Brushes.Red,
                    square.X + square.A - HandleSize / 2,
                    square.Y + square.A - HandleSize / 2,
                    HandleSize, HandleSize);
            }
            else if (shape is Triangle triangle)
            {
                g.FillRectangle(Brushes.Red,
                    triangle.X + triangle.BaseLength / 2 - HandleSize / 2,
                    triangle.Y - triangle.Height - HandleSize / 2,
                    HandleSize, HandleSize);
            }
        }

        private void DrawingForm_Load(object sender, EventArgs e)
        {
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
                    int newRadius = circle.Radius + deltaX;

                    if (circle.X - newRadius >= 0 && circle.X + newRadius <= this.ClientSize.Width &&
                        circle.Y - newRadius >= 0 && circle.Y + newRadius <= this.ClientSize.Height)
                    {
                        circle.Radius = newRadius;
                    }
                }
                else if (shape is Rectangle rect)
                {
                    int newWidth = rect.Width + deltaX;
                    int newHeight = rect.Height + deltaY;

                    if (rect.X + newWidth <= this.ClientSize.Width && rect.Y + newHeight <= this.ClientSize.Height)
                    {
                        rect.Width = newWidth > 0 ? newWidth : rect.Width;
                        rect.Height = newHeight > 0 ? newHeight : rect.Height;
                    }
                }
                else if (shape is Square square)
                {
                    int newSize = square.A + Math.Min(deltaX, deltaY);

                    if (square.X + newSize <= this.ClientSize.Width && square.Y + newSize <= this.ClientSize.Height)
                    {
                        square.A = newSize > 0 ? newSize : square.A;
                    }
                }
                else if (shape is Triangle triangle)
                {
                    int newBaseLength = triangle.BaseLength + deltaX;
                    int newHeight = triangle.Height + deltaY;

                    if (triangle.X + newBaseLength / 2 <= this.ClientSize.Width &&
                        triangle.X - newBaseLength / 2 >= 0 &&
                        triangle.Y - newHeight >= 0)
                    {
                        triangle.BaseLength = newBaseLength > 0 ? newBaseLength : triangle.BaseLength;
                        triangle.Height = newHeight > 0 ? newHeight : triangle.Height;
                    }
                }

                lastMousePosition = e.Location;

                this.Invalidate();
            }
            else if (isDragging && shape != null)
            {
                int deltaX = e.X - lastMousePosition.X;
                int deltaY = e.Y - lastMousePosition.Y;

                if (shape is Circle circle)
                {
                    int newX = circle.X + deltaX;
                    int newY = circle.Y + deltaY;

                    if (newX - circle.Radius >= 0 && newX + circle.Radius <= this.ClientSize.Width &&
                        newY - circle.Radius >= 0 && newY + circle.Radius <= this.ClientSize.Height)
                    {
                        circle.X = newX;
                        circle.Y = newY;
                    }
                }
                else if (shape is Rectangle rect)
                {
                    int newX = rect.X + deltaX;
                    int newY = rect.Y + deltaY;

                    if (newX >= 0 && newX + rect.Width <= this.ClientSize.Width &&
                        newY >= 0 && newY + rect.Height <= this.ClientSize.Height)
                    {
                        rect.X = newX;
                        rect.Y = newY;
                    }
                }
                else if (shape is Square square)
                {
                    int newX = square.X + deltaX;
                    int newY = square.Y + deltaY;

                    if (newX >= 0 && newX + square.A <= this.ClientSize.Width &&
                        newY >= 0 && newY + square.A <= this.ClientSize.Height)
                    {
                        square.X = newX;
                        square.Y = newY;
                    }
                }
                else if (shape is Triangle triangle)
                {
                    int newX = triangle.X + deltaX;
                    int newY = triangle.Y + deltaY;

                    if (newX + triangle.BaseLength / 2 <= this.ClientSize.Width &&
                        newX - triangle.BaseLength / 2 >= 0 &&
                        newY >= triangle.Height)
                    {
                        triangle.X = newX;
                        triangle.Y = newY;
                    }
                }

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
                int handleX = circle.X + circle.Radius;
                int handleY = circle.Y + circle.Radius;
                return Math.Abs(mousePosition.X - handleX) <= HandleSize &&
                       Math.Abs(mousePosition.Y - handleY) <= HandleSize;
            }
            else if (shape is Rectangle rect)
            {
                int handleX = rect.X + rect.Width;
                int handleY = rect.Y + rect.Height;
                return Math.Abs(mousePosition.X - handleX) <= HandleSize &&
                       Math.Abs(mousePosition.Y - handleY) <= HandleSize;
            }
            else if (shape is Square square)
            {
                int handleX = square.X + square.A;
                int handleY = square.Y + square.A;
                return Math.Abs(mousePosition.X - handleX) <= HandleSize &&
                       Math.Abs(mousePosition.Y - handleY) <= HandleSize;
            }
            else if (shape is Triangle triangle)
            {
                int handleX = triangle.X + triangle.BaseLength / 2;
                int handleY = triangle.Y - triangle.Height;
                return Math.Abs(mousePosition.X - handleX) <= HandleSize &&
                       Math.Abs(mousePosition.Y - handleY) <= HandleSize;
            }
            return false;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedColor = colorDialog.Color;
                    this.Invalidate();
                }
            }
        }
    }
}
