using System;
namespace PENJUMLAHAN_BINER
{
    class Program
    {
        int mB2D(int BIN)
        {
            int DEC = 0, X = 0;
            while (BIN > 0)
            {
                DEC += (int)(BIN % 10 * Math.Pow(2, X++));
                BIN /= 10;
            }
            return DEC;
        }
        int mD2B(int DEC)
        {
            int BIN = 0, X = 0;
            while (DEC > 0)
            {
                BIN += (int)(DEC % 2 * Math.Pow(10, X++));
                DEC /= 2;
            }
            return BIN;
        }
        static void Main()
        {
            int BIN, BIN1, BIN2, DEC, DEC1, DEC2;
            Console.WriteLine("     PENJUMLAHAN BINER ");
            Console.WriteLine("   Oleh : Sherli - XT3/33");
            Console.Write("\n     BIl. BIN 1  = ");
            BIN1 = int.Parse(Console.ReadLine());
            Console.Write("\n     Bil. BIN 2  = ");
            BIN2 = int.Parse(Console.ReadLine());

            Program n1 = new Program();
            DEC1 = n1.mB2D(BIN1);
            DEC2 = n1.mB2D(BIN2);
            DEC = DEC1 + DEC2;

            Program n2 = new Program();
            BIN = n2.mD2B(DEC);

            Console.Write("\n     BIN1 + BIN2 = " + BIN);
            Console.ReadKey();
           
        }
    }
}
       
