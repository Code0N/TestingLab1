using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LakeOfSorrowProduction
{
    public class Rectangle
    {
        public double A;
        public double B;
        public double C;
        public double D;

        public Rectangle(double[] x_param, double[] y_param)
        {
            SetVertices(x_param, y_param);
        }

        public Rectangle()
        {
            
        }

        public void SetVertices(double[] x_param, double[] y_param) //Торвальдс покарает меня за этот код
        {
            this.x = x_param;
            this.y = y_param;
            if ((x.Length != 4) || (y.Length != 4))
            {
                throw new ArgumentException("Неверно заданы вершины, это не прямоугольник");
            }
            //this.a = Math.Sqrt(Math.Pow(this.x[0] - this.x[1], 2) + Math.Pow(this.y[0] - this.y[1], 2));
            //this.b = Math.Sqrt(Math.Pow(this.x[2] - this.x[1], 2) + Math.Pow(this.y[2] - this.y[1], 2));
            //MessageBox.Show(a.ToString() + " " + b.ToString()); //For debug
            //if (Math.Abs((this.x[1] - this.x[0]) * (this.x[2] - this.x[1]) + (this.y[1] - this.y[0]) * (this.y[2] - this.y[1])) > 1e-10)

            
            //this.a = this.x[1] - this.x[0];
            //this.b = this.y[1] - this.y[2];
            A = Math.Sqrt(Math.Pow((x[1] - x[0]), 2) + Math.Pow((y[1] - y[0]), 2));
            B = Math.Sqrt(Math.Pow((x[2] - x[1]), 2) + Math.Pow((y[2] - y[1]), 2));
            C = Math.Sqrt(Math.Pow((x[3] - x[2]), 2) + Math.Pow((y[3] - y[2]), 2));
            D = Math.Sqrt(Math.Pow((x[0] - x[3]), 2) + Math.Pow((y[0] - y[3]), 2));

            if ((A != C) || (B != D))
            {
                throw new ArgumentException("Это не прямоугольник");
            }
            //TODO: Вставить эксепшн
        }

        public double Diagonal()
        {
            //return Math.Sqrt(Math.Pow(this.b, 2) + Math.Pow(this.a, 2)); //Эксепшны сверху
            return Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
        }

        private double[] x;
        private double[] y;
        //double a, b;
    }
}
