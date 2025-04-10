﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class DrawingForm : Form
    {
        private List<Shape> shapes;
        private Shape selectedShape;
        private bool isDragging = false;
        private bool isResizing = false;
        private Point lastMousePosition;
        private const int HandleSize = 10;

        private string currentFigureType = "Rectangle";
        private bool drawingMode = false;
        private Point drawStartPoint;

        private Stack<List<Shape>> undoStack = new Stack<List<Shape>>();
        private Stack<List<Shape>> redoStack = new Stack<List<Shape>>();

        public DrawingForm(List<Shape> shapes)
        {
            InitializeComponent();
            this.shapes = shapes;
            this.Text = "Draw Shape";
            this.BackColor = Color.White;
            this.Size = new Size(500, 500);
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);

            this.MouseDown += DrawingForm_MouseDown;
            this.MouseMove += DrawingForm_MouseMove;
            this.MouseUp += DrawingForm_MouseUp;

            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.Shift) drawingMode = true;
                if (e.Control && e.KeyCode == Keys.Z)
                {
                    Undo();
                }
                if (e.Control && e.KeyCode == Keys.Y)
                {
                    Redo();
                }
            };
            this.KeyUp += (s, e) => { drawingMode = false; };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);
            }

            if (selectedShape != null)
            {
                DrawResizeHandle(e.Graphics);
            }
        }

        private void DrawResizeHandle(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color.Red))
            {
                if (selectedShape is Circle circle)
                {
                    g.FillRectangle(brush, circle.X + circle.Radius - HandleSize / 2, circle.Y + circle.Radius - HandleSize / 2, HandleSize, HandleSize);
                }
                else if (selectedShape is Rectangle rect)
                {
                    g.FillRectangle(brush, rect.X + rect.Width - HandleSize / 2, rect.Y + rect.Height - HandleSize / 2, HandleSize, HandleSize);
                }
                else if (selectedShape is Square square)
                {
                    g.FillRectangle(brush, square.X + square.A - HandleSize / 2, square.Y + square.A - HandleSize / 2, HandleSize, HandleSize);
                }
                else if (selectedShape is Triangle triangle)
                {
                    g.FillRectangle(brush, triangle.X + triangle.BaseLength / 2 - HandleSize / 2, triangle.Y - triangle.Height - HandleSize / 2, HandleSize, HandleSize);
                }
            }
        }

        private void DrawingForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (ModifierKeys == Keys.Shift)
            {
                string selectedType = comboBoxShapes.SelectedItem?.ToString();

                Shape newShape = null;

                switch (selectedType)
                {
                    case "Circle":
                        newShape = new Circle(e.X, e.Y, 40);
                        break;
                    case "Rectangle":
                        newShape = new Rectangle(e.X, e.Y, 80, 50);
                        break;
                    case "Square":
                        newShape = new Square(e.X, e.Y, 50);
                        break;
                    case "Triangle":
                        newShape = new Triangle(e.X, e.Y, 60, 50);
                        break;
                }

                if (newShape != null)
                {
                    PushToUndoStack();
                    shapes.Add(newShape);
                    selectedShape = newShape;
                    Invalidate();
                }

                return;
            }

            selectedShape = null;

            foreach (var shape in shapes)
            {
                if (IsMouseOverShape(e.Location, shape))
                {
                    selectedShape = shape;
                    break;
                }
            }

            if (selectedShape != null && IsMouseOverResizeHandle(e.Location))
            {
                isResizing = true;
            }
            else if (selectedShape != null)
            {
                isDragging = true;
            }

            lastMousePosition = e.Location;
        }

        private void DrawingForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isResizing && selectedShape != null)
            {
                int deltaX = e.X - lastMousePosition.X;
                int deltaY = e.Y - lastMousePosition.Y;

                // Промени за ограничаване на размерите
                if (selectedShape is Rectangle rect)
                {
                    rect.Width = Math.Max(0, rect.Width + deltaX);
                    rect.Height = Math.Max(0, rect.Height + deltaY);
                }
                else if (selectedShape is Square square)
                {
                    square.A = Math.Max(0, square.A + Math.Min(deltaX, deltaY));
                }
                else if (selectedShape is Circle circle)
                {
                    circle.Radius = Math.Max(0, circle.Radius + deltaX);
                }
                else if (selectedShape is Triangle triangle)
                {
                    triangle.BaseLength = Math.Max(0, triangle.BaseLength + deltaX);
                    triangle.Height = Math.Max(0, triangle.Height + deltaY);
                }

                lastMousePosition = e.Location;
                this.Invalidate();  // Преключва повторно рисуването на екрана
            }
            else if (isDragging && selectedShape != null)
            {
                int deltaX = e.X - lastMousePosition.X;
                int deltaY = e.Y - lastMousePosition.Y;

                selectedShape.X += deltaX;
                selectedShape.Y += deltaY;

                lastMousePosition = e.Location;
                this.Invalidate();  // Преключва повторно рисуването на екрана
            }
        }



        private void DrawingForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawingMode)
            {
                int x = Math.Min(drawStartPoint.X, e.X);
                int y = Math.Min(drawStartPoint.Y, e.Y);
                int width = Math.Abs(e.X - drawStartPoint.X);
                int height = Math.Abs(e.Y - drawStartPoint.Y);

                Shape newShape = null;

                switch (currentFigureType)
                {
                    case "Rectangle":
                        newShape = new Rectangle(width, height, x, y);
                        break;
                    case "Circle":
                        int radius = (int)(Math.Sqrt(width * width + height * height) / 2);
                        int centerX = x + width / 2;
                        int centerY = y + height / 2;
                        newShape = new Circle(centerX, centerY, radius);
                        break;
                    case "Square":
                        int side = Math.Min(width, height);
                        newShape = new Square(x, y, side);
                        break;
                    case "Triangle":
                        newShape = new Triangle(width, height, x + width / 2, y + height);
                        break;
                }

                if (newShape != null)
                {
                    PushToUndoStack();
                    shapes.Add(newShape);
                    this.Invalidate();
                }

                return;
            }

            isDragging = false;
            isResizing = false;
        }

        private bool IsMouseOverShape(Point mousePosition, Shape shape)
        {
            return shape.Contains(mousePosition);
        }

        private bool IsMouseOverResizeHandle(Point mousePosition)
        {
            if (selectedShape is Circle circle)
            {
                return Math.Abs(mousePosition.X - (circle.X + circle.Radius)) <= HandleSize &&
                       Math.Abs(mousePosition.Y - (circle.Y + circle.Radius)) <= HandleSize;
            }
            else if (selectedShape is Rectangle rect)
            {
                return Math.Abs(mousePosition.X - (rect.X + rect.Width)) <= HandleSize &&
                       Math.Abs(mousePosition.Y - (rect.Y + rect.Height)) <= HandleSize;
            }
            else if (selectedShape is Square square)
            {
                return Math.Abs(mousePosition.X - (square.X + square.A)) <= HandleSize &&
                       Math.Abs(mousePosition.Y - (square.Y + square.A)) <= HandleSize;
            }
            else if (selectedShape is Triangle triangle)
            {
                return Math.Abs(mousePosition.X - (triangle.X + triangle.BaseLength / 2)) <= HandleSize &&
                       Math.Abs(mousePosition.Y - (triangle.Y - triangle.Height)) <= HandleSize;
            }
            return false;
        }

        private void PushToUndoStack()
        {
            undoStack.Push(shapes.Select(s => s.Clone()).ToList());
            redoStack.Clear();
        }

        private void Undo()
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push(shapes.Select(s => s.Clone()).ToList());
                shapes = undoStack.Pop();

                lstCommandHistory.Items.Add("Undo executed");
                this.Invalidate();
            }
            else
            {
                lstCommandHistory.Items.Add("No actions to undo");
            }
        }

        private void Redo()
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push(shapes.Select(s => s.Clone()).ToList());
                shapes = redoStack.Pop();

                lstCommandHistory.Items.Add("Redo executed");
                this.Invalidate();
            }
            else
            {
                lstCommandHistory.Items.Add("No actions to redo");
            }
        }


        private void DrawingForm_Load(object sender, EventArgs e) { }

        private void btnFillColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK && selectedShape != null)
                {
                    PushToUndoStack();
                    selectedShape.FillColor = colorDialog.Color;
                    this.Invalidate();
                }
            }
        }

        private void btnBorderColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK && selectedShape != null)
                {
                    PushToUndoStack();
                    selectedShape.BorderColor = colorDialog.Color;
                    this.Invalidate();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedShape != null)
            {
                PushToUndoStack();
                shapes.Remove(selectedShape);
                selectedShape = null;
                MessageBox.Show("Shape has been deleted.");
                this.Invalidate();
            }
            else
            {
                MessageBox.Show("No shape selected to delete.");
            }
        }
    }
}
