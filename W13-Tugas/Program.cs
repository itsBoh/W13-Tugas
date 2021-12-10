using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        List<string> scrolls = new List<string>() { "Book of Peace", "Scroll of Swords", "Silence Guide Book" };
        while (true)
        {
            int berapaMasukan = 0;
            int urutanMasukan = 0;
            Console.Write("1. My scroll list \n2. Add scroll\n3. Search scroll\n4. Remove scroll\nChoose what to do : ");
            int pilih = Convert.ToInt32(Console.ReadLine());
            if (pilih == 1)
            {
                Console.WriteLine("\nScroll to learn list : ");
                for (int i = 0; i < scrolls.Count; i++)
                    Console.WriteLine($"Scroll {i + 1}: {scrolls[i]}");
            }
            else if (pilih == 2)
            {
                Console.WriteLine("How many scroll to add:");
                berapaMasukan = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("In what number of queue?");
                urutanMasukan = Convert.ToInt32(Console.ReadLine()) - 1;
                if (urutanMasukan < 1)
                    urutanMasukan = 0;
                if (urutanMasukan > scrolls.Count)
                    urutanMasukan = scrolls.Count;
                for (int i = 0; i < berapaMasukan; i++)
                {
                    Console.WriteLine($"Scroll {i + 1} name:");
                    scrolls.Insert(urutanMasukan + i, Console.ReadLine());
                }
            }
            else if (pilih == 3)
            {
                string cari = null;
                int hitung = 0;
                int cek  = 0;
                Console.WriteLine("Insert scroll name :");
                cari = Console.ReadLine();
                for (int i = 0; i < scrolls.Count; i++)
                {
                    hitung++;
                    if (scrolls[i].ToLower() == cari.ToLower())
                    {
                        cek = 1;
                        break;
                    }
                }
                if (cek == 1)
                    Console.WriteLine($"Book found. Queue number: {hitung}");
                else
                    Console.WriteLine("Book not found ");
            }
            else if (pilih == 4)
            {
                ConsoleKey remove = 0;
                while (remove != ConsoleKey.Y && remove != ConsoleKey.N)
                {
                    Console.WriteLine("Remove from list by scroll name? Y/N:");
                    remove = Console.ReadKey().Key;
                    Console.WriteLine();
                }
                if (remove == ConsoleKey.Y)
                {
                    Console.WriteLine("Input scroll name : ");
                    string hapus = Console.ReadLine();
                    int cek = 0;
                    for (int i = 0; i < scrolls.Count; i++)
                    {
                        if (scrolls[i].ToLower() == hapus.ToLower())
                        {
                            scrolls.RemoveAt(i);
                            Console.WriteLine("Book Removed !");
                            cek = 1;
                        }
                    }
                    if (cek == 0)
                    {
                        Console.WriteLine("Book not found");
                    }
                }
                else if (remove == ConsoleKey.N)
                {
                    while (true)
                    {
                        Console.WriteLine("Input scroll queue :");
                        int queue = Convert.ToInt32(Console.ReadLine());
                        if (queue > 0 && queue < scrolls.Count)
                        {
                            scrolls.RemoveAt(queue - 1);
                            Console.WriteLine("Book Removed !");
                            break;
                        }
                        else
                            Console.Write("Queue not found.");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}