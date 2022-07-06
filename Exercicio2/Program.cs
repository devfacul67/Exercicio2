using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número da cidade desejada: \n1 - Atibaia\n2 - Bragança Paulista\n" +
            "3 - Mairiporã\n4 - Nazaré\n5 - Terra Preta\n6 - Extrema\n7 - Vargem");
            int numerocidade = Convert.ToInt32(Console.ReadLine());

            string nomecidade = null;

            switch (numerocidade)
            {
                case 1: nomecidade = "Atibaia"; break;
                case 2: nomecidade = "Bragança Paulista"; break;
                case 3: nomecidade = "Mairiporã"; break;
                case 4: nomecidade = "Nazaré"; break;
                case 5: nomecidade = "Terra Preta"; break;
                case 6: nomecidade = "Extrema"; break;
                case 7: nomecidade = "Vargem"; break;
            }

            Console.WriteLine("Digite a data desejada(dd/mm/aaaa):");
            var datan = Convert.ToDateTime(Console.ReadLine());

            int datames, datadia, dataano;
            datames = datan.Month;
            datadia = datan.Day;
            dataano = datan.Year;

            string datadesejada = Dataextenso(datadia, datames, dataano);

            Console.WriteLine($"{nomecidade}, {datadesejada}.");

            Console.ReadKey();
        }
        static public string Dataextenso(int datadia, int datames, int dataano)
        {
            string mesexten = null;
            switch (datames)
            {
                case 1: mesexten = "Janeiro"; break;
                case 2: mesexten = "Fevereiro"; break;
                case 3: mesexten = "Março"; break;
                case 4: mesexten = "Abril"; break;
                case 5: mesexten = "Maio"; break;
                case 6: mesexten = "Junho"; break;
                case 7: mesexten = "Julho"; break;
                case 8: mesexten = "Agosto"; break;
                case 9: mesexten = "Setembro"; break;
                case 10: mesexten = "Outubro"; break;
                case 11: mesexten = "Novembro"; break;
                case 12: mesexten = "Dezembro"; break;
            }

            string dataconvertida = $"{datadia} de {mesexten} de {dataano}";

            return dataconvertida;
        }
    }
}
