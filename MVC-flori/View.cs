using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_flori
{
    public class View
    {
        FloriService floriService = new FloriService();

        public void Meniu()
        {
            Console.WriteLine("Apasati tasta 1 pentru a afisa toate florile");
            Console.WriteLine("Apsasati tasta 2 ca sa se afiseze toate buchetele la acelasi pret");
            Console.WriteLine("Apasati tasta 3 si introduceti buchetul pe care il doriti");
            Console.WriteLine("Apasati tasta 4 pentru adauga un buchet nou");
        }

        public void play()
        {
            bool running = true;

            floriService.LoadData();
            string alegere = Console.ReadLine();

            switch(alegere)
            {
                case "1":
                    floriService.AfisareFlori();
                    break;
            }
        }
    }
}
