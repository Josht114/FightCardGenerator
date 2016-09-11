using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightCardGenerator
{
    class PrideCard : Card
    {
        Roster cardRoster;
        static Random rnd = new Random();

      //  Fighter a = new Fighter("UnknownA", 0, 265);
      //  Fighter b = new Fighter("UnknownB", 0, 265);

        Fight fight1 = new Fight();
        Fight fight2 = new Fight();
        Fight fight3 = new Fight();
        Fight fight4 = new Fight();
        Fight fight5 = new Fight();


        public PrideCard(Roster r) : base(r)
        {
            cardRoster = r;

            // NEED TO CHECK THAT IF A FIGHTER IS IN MULTIPLE DIVISION THEY DO NOT GET PUT IN TWO FIGHTS

            setFight(cardRoster.getHeavyweights(), fight1);
            setFight(cardRoster.getLightheavyweights(), fight2);
            setFight(cardRoster.getWelterweights(), fight3);
            setFight(cardRoster.getLightweights(), fight4);

            int rando = rnd.Next(4);
            if (rando == 1)
            {
                setFight(cardRoster.getLightweights(), fight5);
            }
            if (rando == 2)
            {
                setFight(cardRoster.getWelterweights(), fight5);
            }
            if (rando == 3)
            {
                setFight(cardRoster.getLightheavyweights(), fight5);
            }
            else
            {
                setFight(cardRoster.getHeavyweights(), fight5);
            }




        }

        public void creatAllFights()
        {
            // MOVE STUFF FROM ABOVE INTO HERE
        }



        public Fight getFight1()
        {
            return fight1;
        }

        public Fight getFight2()
        {
            return fight2;
        }
        public Fight getFight3()
        {
            return fight3;
        }
        public Fight getFight4()
        {
            return fight4;
        }
        public Fight getFight5()
        {
            return fight5;
        }


    }
}
