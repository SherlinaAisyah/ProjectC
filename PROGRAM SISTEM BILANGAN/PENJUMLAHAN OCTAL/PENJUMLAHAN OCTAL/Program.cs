using System;

namespace PENJUMLAHAN_OCTAL
{
    class Program
    {
             int mB2D(int OCT)
        {   int DEC = 0, X = 0;
            while (OCT > 0)
            {
            DEC += (int) (OCT % 10 * Math.Pow(8, X++));
            OCT /= 10;
            }
            return DEC;
        }
        int mD2B(int DEC)
            {
                int OCT = 0, X = 0;
                while(DEC > 0)
            {
        OCT += (int)(DEC % 8 * Math.Pow(10, X++));
        DEC /= 8;               }
            return OCT;
             }
        static void Main(string[] args)
        {
            int OCT, OCT1, OCT2, DEC, DEC1, DEC2;
            Console.WriteLine("     PENJUMLAHAN OCTAL ");
            Console.WriteLine("   Oleh : Sherli - XT3/33");
            Console.Write("\n     BIl. OCT 1  = ");
            OCT1 = int.Parse(Console.ReadLine());
            Console.Write("\n     Bil. OCT 2  = ");
            OCT2 = int.Parse(Console.ReadLine());

            Program n1 = new Program();
            DEC1 = n1.mB2D(OCT1);
            DEC2 = n1.mB2D(OCT2);
            DEC = DEC1 + DEC2;

            Program n2 = new Program();
            OCT = n2.mD2B(DEC);

            Console.Write("\n   OCT.1 + OCT.2 = " + OCT);
            Console.ReadKey();
           
        }
    }
}
        