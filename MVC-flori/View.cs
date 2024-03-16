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
            Console.WriteLine("Apsasati tasta 2 ca sa se afiseze toate buchetele la un pret anume");
            Console.WriteLine("Apasati tasta 3 si introduceti buchetul pe care il doriti");
            Console.WriteLine("Apasati tasta 4 pentru adauga un buchet nou");
            Console.WriteLine("Apasati tasta 5 pentru a edita un cate fire are un buchet ");
            Console.WriteLine("Apasati tasta 6 pentru a edita pretul la un buchet");
            Console.WriteLine("Apasati tasta 7 pentru a edita florile dintr un buchet");
            Console.WriteLine("Apasati tasta 8 pentru a afisa toate florile de acelasi tip de flori inserat");
            Console.WriteLine("Apasati tasta 9 pentru a afisa toate florile la acelasi pret inserat");
        }

        public void play()
        {
            bool running = true;

            floriService.LoadData();
            while(running)
            {
                Meniu();
                string alegere = Console.ReadLine();

                switch (alegere)
                {
                    case "1":
                        floriService.AfisareFlori();
                        break;
                    case "2":
                        ShowFlowersAtSamePrice();
                        break;

                    case "3":
                        BuyFlowers();
                        break;

                    case "4":
                        AddFlowers();
                        break;

                    case "5":
                        EditFireBuchet();
                        break;

                    case "6":
                        EditBuchetTipFlori();
                        break;

                    case "7":
                        EditBuchetNewPrice();
                        break;
                }
            }
        }

        public void ShowFlowersAtSamePrice()
        {
            Console.WriteLine("La ce pret doriti un buchet?");
            int buchetePrice = Int32.Parse(Console.ReadLine());

            if(floriService.FindBucheteByPrice(buchetePrice) != -1)
            {
                Console.WriteLine("Avem la acest pret!");

            }
            else
            {
                Console.WriteLine("Nu avem la acest pret");
            }

            
        }

        public void BuyFlowers()
        {
            Console.WriteLine("Ce flori doriti sa cumparati din lista de mai jos?");
            floriService.AfisareFlori();
            string floriDorite = Console.ReadLine();

            if(floriService.BuyFlowerSSh(floriDorite) != false)
            {
                Console.WriteLine("Florile au fost achizitionate cu succes!");
            }
            else
            {
                Console.WriteLine("Florile nu au fost achizitionate");
            }
        }

        public void AddFlowers()
        {
            Console.WriteLine("Introduceți numărul de fire:");
            int numarFlori = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduceți prețul total al buchetului:");
            int pretPerFloare = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduceți tipul de flori:");
            string tipFlori = Console.ReadLine();

            Console.WriteLine("Buchetul a fost adaugat cu succes!");
        }

        public void EditFireBuchet()
        {
            Console.WriteLine("Ce flori doriti sa editati");
            string wantedFlori = Console.ReadLine();

            Console.WriteLine("Cu cate fire doriti sa modificati buchetul");
            int buchetNewFire = Int32.Parse(Console.ReadLine());

            if (floriService.EditBuchetFire(wantedFlori, buchetNewFire))
            {
                Console.WriteLine("Buchetul a fost editat cu succes");
            }
            else
            {
                Console.WriteLine("Buchetul nu a putut fi editat");
            }
        }

        public void EditBuchetTipFlori()
        {
            Console.WriteLine("Ce flori doriti sa editati");
            string wantedFlori = Console.ReadLine();

            Console.WriteLine("Cu ce tip de flori doriti sa modificati buchetul");
            string buchetNeuTipFlori = Console.ReadLine();

            if (floriService.EditBuchetTipFlori(wantedFlori, buchetNeuTipFlori))
            {
                Console.WriteLine("Buchetul a fost editat cu succes");
            }
            else
            {
                Console.WriteLine("Buchetul nu a putut fi editat");
            }
        }

        public void EditBuchetNewPrice()
        {
            Console.WriteLine("Ce flori doriti sa editati");
            string wantedFlori = Console.ReadLine();

            Console.WriteLine("Cu ce pret doriti sa modificati buchetul");
            int buchetNewPrice = Int32.Parse(Console.ReadLine());

            if (floriService.EditBuchetNewPrice(wantedFlori, buchetNewPrice))
            {
                Console.WriteLine("Buchetul a fost editat cu succes");
            }
            else
            {
                Console.WriteLine("Buchetul nu a putut fi editat");
            }
        }

    }
}
