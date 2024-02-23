using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_flori
{
    public class FloriService
    {
        public List<Flori> FloriList = new List<Flori>();

        public void LoadData()
        {
            Flori buchet1 = new Flori();
            buchet1.pret = 200;
            buchet1.fire = 50;
            buchet1.flori = "Lalele";

            Flori buchet2 = new Flori();
            buchet2.pret = 10;
            buchet2.fire = 22;
            buchet2.flori = "Zambile";

            Flori buchet3 = new Flori();
            buchet3.pret = 500;
            buchet3.fire = 50;
            buchet3.flori = "Trandafiri";

            Flori buchet4 = new Flori();
            buchet4.pret = 250;
            buchet4.fire = 55;
            buchet4.flori = "Crizanteme";

            Flori buchet5 = new Flori();
            buchet5.pret = 250;
            buchet5.fire = 65;
            buchet5.flori = "Trandafiri";

            this.FloriList.Add(buchet1);
            this.FloriList.Add(buchet2);
            this.FloriList.Add(buchet3);
            this.FloriList.Add(buchet4);
            this.FloriList.Add(buchet5);
        }

        public void AfisareFlori()
        {
            foreach (Flori x in FloriList)
            {
                Console.WriteLine(x.BuchetFlori());
            }
        }
    }
}
