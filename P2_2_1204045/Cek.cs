using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204045
{
    class Cek
    {
        //deklarasi variabel
        private int normal = 0;
        private int ideal = 0;
        private int idealw = 0;
        //end var

        
        //method
        public void Normal(int tbadan) //method untuk mengoprasikan berat badan normal
        {
            normal = Convert.ToInt32(tbadan - 100);
        }

        public void Ideal(int tbadan) //method untuk mengoprasikan berat badan ideal pria
        {
            ideal = Convert.ToInt32((tbadan - 100) - (10 % (tbadan - 100)));
        }
        public void Idealw(int tbadan) //method untuk mengoprasikan berat badan ideal wanita
        {
            idealw = Convert.ToInt32((tbadan - 100) - (15 % (tbadan - 100)));
        }

        public void output() //method untuk menampilkan hasil
        {
            
            Console.WriteLine("");
            Console.WriteLine("Berat badan normal anda : " + normal + " Kg");
            Console.WriteLine("Berat badan ideal untuk anda : " + ideal + " Kg");
  
        }
        public void outputw() //method untuk menampilkan hasil
        {

            Console.WriteLine("");
            Console.WriteLine("Berat badan normal anda : " + normal + " Kg");
            Console.WriteLine("Berat badan ideal untuk anda : " + idealw + " Kg");

        }
        //end method
    }
}
