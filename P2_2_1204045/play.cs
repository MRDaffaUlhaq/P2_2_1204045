using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204045
{
    class play
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("APLIKASI PENENTUAN BERAT BADAN IDEAL\n====================================");
            Console.WriteLine("");

            //deklarasi dan inisiasi variabel
            int gender = 0;
            Console.WriteLine("Pilih jenis kelamin : \n1. Pria \n2. Wanita");
            Console.WriteLine("");
            Console.Write("Masukkan jenis kelamin anda(1/ 2) : ");
            gender = Convert.ToInt32(Console.ReadLine());

            Cek count = new Cek();

            if (gender == 1 || gender == 2)
            {
                int tb = 0;
                Console.Write("Masukkan tinggi badan anda(Cm) : ");
                tb = Convert.ToInt32(Console.ReadLine());

              

                if (tb >= 150)//validasi
                {
                    if (gender == 1)
                    {

                        // Memanggil method yang ada di class Cek
                        count.Normal(tb);
                        count.Ideal(tb);
                        count.output();

                    }
                    else if (gender == 2)
                    {

                        // Memanggil method yang ada di class Cek
                        count.Normal(tb);
                        count.Idealw(tb);
                        count.outputw();

                    }
                }
                else
                {
                    Console.WriteLine("Ups, tinggi badan harus diatas 150 Cm");
                }

                int Bb = 0;
                Console.WriteLine("");
                Console.Write("Masukkan berat badan anda saat ini (Kg) : ");

                count.bbnow(Bb);
            }
            else
            {
                Console.WriteLine("Ups, harap masukkan gender menggunakan angka ya (1/ 2)");
            }
           

            Console.ReadKey(true);
        }
    }
}
