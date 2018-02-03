using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LakeOfSorrowProduction
{
    public class Rectangle
    {
        public Rectangle(double[] x_param, double[] y_param)
        {
            SetVertices(x_param, y_param);
        }

        public void SetVertices(double[] x_param, double[] y_param) //Торвальдс покарает меня за этот код
        {
            this.x = x_param;
            this.y = y_param;
            this.a = this.x[1] - this.x[0];
            this.b = this.y[1] - this.y[2];
        }

        public double Diagonal()
        {
            if ((x.Length != 4) || (y.Length != 4))
            {
                throw new ArgumentException("Неверно заданы вершины, это не прямоугольник");
            }



            return Math.Sqrt(Math.Pow(this.b, 2) + Math.Pow(this.a, 2)); //Эксепшны сверху
        }

        private double[] x;
        private double[] y;
        double a, b;
    }
}
