using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace convertor
{
    internal class Program
    {
        int Inches = 12;
        int Feet = 3;
        int Yards = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter:\n 1) for Lenghth\n or\n 2) for Volume");
            int num = 0;
            int.TryParse(Console.ReadLine(), out num);

            //=======================================

            if (num == 1)
            {
                Console.WriteLine("Enter: First Mesurment of Length:\n 3 for Inches\n 4 for Feet\n 5 for Yards");
                int FLengthUnit = 0;
                int.TryParse(Console.ReadLine(), out num);
            }

            //if (num == 2)
            //{
            //    Console.WriteLine("Enter First Mesurment of Volume:\n 8 for Cup\n 9 for Pint\n 10 for Quart\n 11 for Galon");
            //    int FVolumeUnit = 0;
            //    int.TryParse(Console.ReadLine(), out num);
            //}


            //=======================================

            if (num == 3)
            {
                Console.WriteLine("Enter the Number of Inches");
                int Inches = 12;
                int.TryParse(Console.ReadLine(), out Inches);
            }

            if (num == 4)
            {
                Console.WriteLine("Enter the Number of Feet");
                int Feet = 3;
                int.TryParse(Console.ReadLine(), out Feet);
            }

            if (num == 1)
            {
                Console.WriteLine("Enter the Number of Yards");
                int Yards = 1;
                int.TryParse(Console.ReadLine(), out Yards);
            }

            //=======================================
            //public string.FLengthUnit();

            Console.WriteLine("Enter Second Mesurment of Length:\n 3 for Inches\n 4 for Feet\n 5 for Yards");
            int SLengthUnit = 0;
            int.TryParse(Console.ReadLine(), out num);

            //=======================================

            if (num == 3)
            {
                Console.WriteLine("Enter the Number of Inches");
                int Inches = 12;
                int.TryParse(Console.ReadLine(), out Inches);
            }

            if (num == 4)
            {
                Console.WriteLine("Enter the Number of Feet");
                int Feet = 3;
                int.TryParse(Console.ReadLine(), out Feet);
            }

            if (num == 5)
            {
                Console.WriteLine("Enter the Number of Yards");
                int Yards = 1;
                int.TryParse(Console.ReadLine(), out Yards);
            }


            
            switch (num)
            {
                case 3:
                    Console.WriteLine(FLengthUnit / Inches  + "Inches");
                    break;

                case 4:
                    Console.WriteLine(Meeters * 39 + "Inches");
                    break;

                case 5:
                    Console.WriteLine( *  + "Inches");
                    break;

                default:
                    Console.WriteLine("Invalid Units");
                    break;

            }

            Console.ReadLine();
        }
    }
}



         