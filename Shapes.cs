using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class Shapes
    {
        public abstract double Area();

        public abstract double Perimeter();

    }

    public class Circle : Shapes
    {
        public Circle(double CenterX, double CenterY, double PointX, double PointY)
        {
            CircleRad = Math.Pow((Math.Pow((PointY - CenterY), 2) + Math.Pow((PointX - CenterX), 2)), 0.5);
        }
        public double CircleRad { get; set; }
        public override double Area()
        {
            return CircleRad * CircleRad * Math.PI;
        }

        public override double Perimeter()
        {
            return CircleRad * 2 * Math.PI;

        }

    }

    public class Triangle : Shapes
    {
        public Triangle(double axx, double ayy, double bxx, double byy, double cxx, double cyy)
        {
            Ax = axx;
            Ay = ayy;
            Bx = bxx;
            By = byy;
            Cx = cxx;
            Cy = cyy;
        }
        public double Ax { get; set; }
        public double Ay { get; set; }
        public double Bx { get; set; }
        public double By { get; set; }
        public double Cx { get; set; }
        public double Cy { get; set; }


        public override double Area()
        {
            return Math.Abs((Ax * (By - Cy) + Bx * (Cy - Ay) + Cx * (Ay - By)) / 2);
        }

        public override double Perimeter()
        {

            double ab = Math.Pow((Math.Pow((By - Ay), 2) + Math.Pow((Bx - Ax), 2)), 0.5);
            double bc = Math.Pow((Math.Pow((Cy - By), 2) + Math.Pow((Cx - Bx), 2)), 0.5);
            double ca = Math.Pow((Math.Pow((Ay - Cy), 2) + Math.Pow((Ax - Cx), 2)), 0.5);


            return ab + bc + ca;
        }



    }


    public class Rectangle : Shapes
    {
        public Rectangle(double axx, double ayy, double bxx, double byy, double cxx, double cyy, double dxx, double dyy)
        {
            Ax = axx;
            Ay = ayy;
            Bx = bxx;
            By = byy;
            Cx = cxx;
            Cy = cyy;
            Dx = dxx;
            Dy = dyy;
        }

        public double Ax { get; set; }
        public double Ay { get; set; }
        public double Bx { get; set; }
        public double By { get; set; }
        public double Cx { get; set; }
        public double Cy { get; set; }
        public double Dx { get; set; }
        public double Dy { get; set; }

        public override double Perimeter()
        {

            double ab = Math.Pow((Math.Pow((By - Ay), 2) + Math.Pow((Bx - Ax), 2)), 0.5);
            double bc = Math.Pow((Math.Pow((Cy - By), 2) + Math.Pow((Cx - Bx), 2)), 0.5);
            double cd = Math.Pow((Math.Pow((Dy - Cy), 2) + Math.Pow((Dx - Cx), 2)), 0.5);
            double da = Math.Pow((Math.Pow((Ay - Dy), 2) + Math.Pow((Ax - Dx), 2)), 0.5);


            return ab + bc + cd + da;
        }

        public override double Area()
        {

            // ABC  და  ACD სამკუთხედების ფართობების ჯამი
            double areaoption1 = Math.Abs((Ax * (By - Cy) + Bx * (Cy - Ay) + Cx * (Ay - By)) / 2) + Math.Abs((Ax * (Cy - Dy) + Cx * (Dy - Ay) + Dx * (Ay - Cy)) / 2);

            // ABD და BCD სამკუთხედების ფართობების ჯამი
            double areaoption2 = Math.Abs((Ax * (By - Dy) + Bx * (Dy - Ay) + Dx * (Ay - By)) / 2) + Math.Abs((Bx * (Cy - Dy) + Cx * (Dy - By) + Dx * (By - Cy)) / 2);


            //თუ ეს ორი ვარიანტი ტოლია ესეიგი ჩვეულებრივი ოთხკუთხედია, თუ არარის ტოლი ესეიგი ჩაზნექილი აქვს კუთხე შიგნით და რომელი ვარიანტის ფართობიც ნაკლებია ის იქნება ოთხკუთხედის ფართობი

            if (areaoption1 < areaoption2)
            {
                return areaoption1;
            }

            else
            {
                return areaoption2;
            }
        }


    }
}

    