// See https://aka.ms/new-console-template for more information
class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kalkulator");

        int angka1;
        int angka2;
        int pil;
        int total;

        Console.WriteLine("1. Penjumlahan");
        Console.WriteLine("2. Pengurangan");
        Console.WriteLine("3. Perkalian");
        Console.WriteLine("4. Pembagian");

        Console.WriteLine("Pilih menu kalkulator : ");
        pil = int.Parse(Console.ReadLine());

        if (pil ==1)
        {
            Console.WriteLine("Masukkan angka pertama :");
            angka1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan angka kedua :");
            angka2 = Convert.ToInt32(Console.ReadLine());

            total = angka1 + angka2;
            Console.WriteLine("Hasil : " + total);
        }
        else if (pil == 2)
        {
            Console.WriteLine("Masukkan angka pertama :");
            angka1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan angka kedua :");
            angka2 = Convert.ToInt32(Console.ReadLine());

            total = angka1 - angka2;
            Console.WriteLine("Hasil : " + total);
        }
        else if (pil == 3)
        {
            Console.WriteLine("Masukkan angka pertama :");
            angka1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan angka kedua :");
            angka2 = Convert.ToInt32(Console.ReadLine());

            total = angka1 * angka2;
            Console.WriteLine("Hasil : " + total);
        }
        else if (pil == 4)
        {
            Console.WriteLine("Masukkan angka pertama :");
            angka1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukkan angka kedua :");
            angka2 = Convert.ToInt32(Console.ReadLine());

            total = angka1 / angka2;
            Console.WriteLine("Hasil : " + total);
        }
        else if (pil == 5)
        {
            Console.WriteLine("Maaf, menu yang Anda pilih tidak tersedia");
        }
        Console.WriteLine("\nTekan sembarang key untuk keluar");
        Console.ReadKey();
    }
}
