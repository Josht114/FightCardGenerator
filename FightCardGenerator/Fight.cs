using FightCardGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightCardGenerator
{
   public class Fight
    {
        Fighter fighter1 = new Fighter("N/A", 0, 0);
        Fighter fighter2 = new Fighter("N/A", 0, 0);
        int weight;


        // comment for test pull


        public Fight(Fighter a, Fighter b)
        {
            fighter1 = a;
            fighter2 = b;

        }

        public Fight()
        {

        }


        public Fighter getFighter1()
        {
            return fighter1;
        }

        public Fighter getFighter2()
        {
            return fighter2;
        }


        public void setFighter1(Fighter a)
        {
            fighter1 = a;

        }

        public void setFighter2(Fighter b)
        {
            fighter2 = b;
        }

        public void setweight(int w)
        {
            weight = w;
        }

        public int getWeight()
        {
            return weight;
        }

        public string getStringWeight()
        {
            return weight.ToString();
        }

        public string getStringWeightClass()
        {
            if(weight == 265)
            {
                return "Heavyweight";
            }
            else if (weight == 205)
            {
                return "Lightheavyweight";
            }
            else if (weight == 185)
            {
                return "middleweight";
            }
            else if (weight == 170)
            {
                return "Welteryweight";
            }
            else if (weight == 155)
            {
                return "Lightweight";
            }
            else if (weight == 145)
            {
                return "Featherweight";
            }
            else if (weight == 135)
            {
                return "Bantamweight";
            }
            else
            {
                return "Catchweight";
            }
        }
    }
}
