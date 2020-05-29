using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            // რამდენი კოორინატიც დაგვჭირდება შემოვიტან იმდენ კორდიანტს ცალცალკე ამ შემთხვევაში სამკუთხედისთვის შემოგვაქვს 6.

            Console.Write("shemoitanet Ax: ");
            double axx = double.Parse(Console.ReadLine());
            Console.Write("shemoitanet Ay: ");
            double ayy = double.Parse(Console.ReadLine());
            Console.Write("shemoitanet Bx: ");
            double bxx = double.Parse(Console.ReadLine());
            Console.Write("shemoitanet BY: ");
            double byy = double.Parse(Console.ReadLine());
            Console.Write("shemoitanet Cx: ");
            double cxx = double.Parse(Console.ReadLine());
            Console.Write("shemoitanet Cy: ");
            double cyy = double.Parse(Console.ReadLine());
            


            Shapes myshape = new Triangle(axx, ayy, bxx, byy, cxx, cyy);

            ShapeArea(myshape);

            Console.ReadKey();
        }

        public static void ShapeArea(Shapes crc)
        {
            Console.WriteLine("Fartobi: " + crc.Area());
            Console.WriteLine("Perimetri: " + crc.Perimeter());

        }


    }
}
