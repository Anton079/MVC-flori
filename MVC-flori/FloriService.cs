using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_flori
{
    public class FloriService
    {
        private List<Flori> _FloriList;

        public FloriService()
        {
            _FloriList = new List<Flori>();
            this.LoadData();
        }

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

            this._FloriList.Add(buchet1);
            this._FloriList.Add(buchet2);
            this._FloriList.Add(buchet3);
            this._FloriList.Add(buchet4);
            this._FloriList.Add(buchet5);
        }


        //CRUD
        public void AfisareFlori()
        {
            foreach (Flori x in _FloriList)
            {
                Console.WriteLine(x.BuchetFlori());
            }
        }

        public int FindFloriByType(string tipFlori)
        {
            for (int i = 0; i < _FloriList.Count; i++)
            {
                if (_FloriList[i].flori == tipFlori)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool AddFloriInList(Flori BuchetNou)
        {
            if (FindFloriByType(BuchetNou.flori) == -1)
            {
                this._FloriList.Add(BuchetNou);
                return true;
            }
            return false;
        }

        public bool RemoveFloriByType(string BuchetCautat)
        {
            int BuchetulCautatIndex = FindFloriByType(BuchetCautat);
            if (BuchetulCautatIndex != -1)
            {
                _FloriList.RemoveAt(BuchetulCautatIndex);
                return true;
            }
            return false;
        }

        //View

        public int FindBucheteByPrice(int buchetePret)
        {
            for(int i = 0; i < _FloriList.Count; i++)
            {
                if (_FloriList[i].pret == buchetePret)
                {
                    Console.WriteLine(i);
                    return 1;
                }
            }
            return -1;
        }

        public bool BuyFlowerSSh(string BuchetDorit)
        {
            for(int i = 0;i < _FloriList.Count; i++)
            {
                if (_FloriList[i].flori == BuchetDorit) 
                {
                    _FloriList.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public bool AddFlowersInList(Flori FLoriNoi)
        {
            if(FindFloriByType(FLoriNoi.flori) != -1)
            {
                this._FloriList.Add(FLoriNoi);
                return true;
            }
            return false;
        }

        //EDIT

        public bool EditBuchetFire(string floriAlese, int fire)
        {
            foreach (Flori x in _FloriList)
            {
                if (x.flori.Equals(floriAlese))
                {
                    x.fire = fire;
                    return true;
                }
            }
            return false;
        }   

        public bool EditBuchetTipFlori(string floriAlese, string tipFLoriNou)
        {
            foreach (Flori x in _FloriList)
            {
                if (x.flori.Equals(floriAlese))
                {
                    x.flori = tipFLoriNou;
                    return true;
                }
            }
            return false;
        }

        public bool EditBuchetNewPrice(string floriAlese, int newPrice)
        {
            foreach (Flori x in _FloriList)
            {
                if (x.flori.Equals(floriAlese))
                {
                    x.pret = newPrice;
                    return true;
                }
            }
            return false;
        }
    }
}
