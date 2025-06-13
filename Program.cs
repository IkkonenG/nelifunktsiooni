using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Sisesta kujundi nimi (ruut, ristkülik, kolmnurk, ring):");
        string vorm = Console.ReadLine();

        if ( vorm == "ruut")
        {
            Console.Write("Külg: ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            Console.WriteLine($"Ümbermõõt: {4 * a}, Pindala: {a * a}");
        }
        else if (vorm == "ristkülik")
        {
            Console.Write("Laius: ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Kõrgus: ");
            int h = int.Parse(Console.ReadLine());

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < l; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            Console.WriteLine($"Ümbermõõt: {2 * (l + h)}, Pindala: {l * h}");
        }
        else if ( vorm == "kolmnurk")
        {
            Console.Write("Kõrgus: ");
            int h = int.Parse(Console.ReadLine());

            for (int i = 1; i <= h; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            double ümbermõõt = 2 * h + Math.Sqrt(2) * h;
            double pindala = 0.5 * h * h;

            Console.WriteLine($"Ümbermõõt: {ümbermõõt:F2}, Pindala: {pindala:F2}");
        }
        else if (vorm == "ring")
        {
            Console.Write("Raadius: ");
            int r = int.Parse(Console.ReadLine());

            for (int y = -r; y <= r; y++)
            {
                for (int x = -r; x <= r; x++)
                {
                    if (x * x + y * y <= r * r)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            double ümbermõõt = 2 * Math.PI * r;
            double pindala = Math.PI * r * r;

            Console.WriteLine($"Ümbermõõt: {ümbermõõt:F2}, Pindala: {pindala:F2}");
        }
        else
        {
            Console.WriteLine("Tundmatu kujund.");
        }

        Console.WriteLine("Valmis!");
    }
}
