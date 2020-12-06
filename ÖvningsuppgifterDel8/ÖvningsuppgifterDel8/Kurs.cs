using System;
using System.Collections.Generic;
using System.Text;

namespace ÖvningsuppgifterDel8
{
    class Kurs
    {
        private string name;
        private int amount;

        public string Name{
            get { return name; }
            set { name = value;}
        }
        
        public int Amount
        {
            get { return amount; }
            set
            {
                if(value < 0)
                {
                    amount = 0;
                } else
                {
                    amount = value;
                }
            }
        }
    }

}
