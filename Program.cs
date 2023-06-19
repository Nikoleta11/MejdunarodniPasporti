using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MejdunarodniPasporti11d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int count=int.Parse(Console.ReadLine());
                List<Pasport>listPasport=new List<Pasport>();
                for (int i = 0; i < count; i++)
                {
                    var danni = Console.ReadLine().Split();
                    Pasport pasport = new Pasport(danni[0], int.Parse(danni[1]), int.Parse(danni[2]), int.Parse(danni[3]), int.Parse(danni[4]));
                    listPasport.Add(pasport);
                }
                //listPasport.OrderBy(egn);
                Console.WriteLine(listPasport.Select(x=>x.Egn).Min());
            }
            catch(ArgumentException exception)
            {
                Console.WriteLine($"ArgException: {exception.Message}");
                throw;
            }
        }
    }
}
