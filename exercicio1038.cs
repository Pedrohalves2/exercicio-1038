using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal PrecoCachorroQuente = 4.00M;
            decimal PrecoXsalada = 4.50M;
            decimal PrecoXbacon = 5.00M;
            decimal PrecoTorradasSimples = 2.00M;
            decimal PrecoRefrigerante = 1.50M;
            decimal total = 0;
            int codigo, quantidade;
            codigo = int.Parse(Console.ReadLine());
            quantidade = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    total = PrecoCachorroQuente * quantidade; break;
                case 2:
                    total = PrecoXsalada * quantidade; break;
                case 3:
                    total = PrecoXbacon * quantidade; break;
                case 4:
                    total = PrecoTorradasSimples * quantidade; break;
                case 5:
                    total = PrecoRefrigerante * quantidade; break;
            }
            Console.WriteLine("Total  " + total.ToString("C2"));
            Console.ReadLine();












        }
    }
}
