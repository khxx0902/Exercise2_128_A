using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exercise2
{
    class program
    {  
        private int[] a = new int[25];
        private int n;
        public void read()
        {
            while (true)
            {
                Console.Write("Masukkan banyaknya data pada int");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nData dapat memiliki maksimal 7 elemen.\n");

            }
            Console.WriteLine("");
            Console.WriteLine("==============================================================");
            Console.WriteLine(" Masukkan jumlah elemen data ");
            Console.WriteLine("==============================================================");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            Console.WriteLine("");
            Console.WriteLine("==================================================");
            Console.WriteLine(" Elemen Data Yang Terstruktur");
            Console.WriteLine("==================================================");
            for (int mk = 0; mk < n; mk++)
            {
                Console.WriteLine(a[mk]);
            }
            Console.WriteLine("");
        }
        public void sort_data()
        {
            for (int i = 1; i < n; i++) // For n -1 passes
            {
                // Pada pass i, bandingkan n - 1 elemen pertama dengan elemen selanjutnya
                for (int j = 0; j < n - i; j++)
                {
                    if (a[j] > a[j + 1]) // jika elemen tidak dalam urutan yang benar
                    {
                        // Tukar elemen
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
    }
}

        



