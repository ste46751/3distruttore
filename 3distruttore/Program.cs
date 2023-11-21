using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3distruttore
{
    internal class Program
    {
        public class esempio
        {
            private string nome;
            private int numero;

            //costruttore senza parametri
            public esempio()
            {
                nome = "Farro";
                numero = 10;
            }

            
            public void stampa()
            {
                Console.WriteLine($"Il prezzo di {nome} è {numero} ");
            }
            ~esempio()
            {
                Console.WriteLine($"{nome}  {numero} è stato eliminato");
            }

            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        }
        static void Main(string[] args)
        {
            esempio esempio = new esempio();
            esempio.stampa();
            

        }
    }
}
