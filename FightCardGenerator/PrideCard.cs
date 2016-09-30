using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightCardGenerator
{
    public class PrideCard : Card
    {
        Roster cardRoster;
        static Random rnd = new Random();


        Fight fight1 = new Fight();
        Fight fight2 = new Fight();
        Fight fight3 = new Fight();
        Fight fight4 = new Fight();
        Fight fight5 = new Fight();


        public PrideCard(Roster r) : base(r)
        {
            cardRoster = r;

            setFight(cardRoster.getHeavyweights(), fight1);
            fight1.setweight(265);


            setFight(cardRoster.getLightheavyweights(), fight2);
            fight2.setweight(205);


            setFight(cardRoster.getWelterweights(), fight3);
            fight3.setweight(170);


            setFight(cardRoster.getLightweights(), fight4);
            fight4.setweight(155);

            int rando = rnd.Next(4);

            File.AppendAllText("D:\\log.txt", rando.ToString());

            if (rando == 0)
            {
                setFight(cardRoster.getLightweights(), fight5);
                fight5.setweight(155);
                File.AppendAllText("D:\\log.txt", "lightweight");
            }
            if (rando == 1)
            {
                setFight(cardRoster.getWelterweights(), fight5);
                fight5.setweight(170);
                File.AppendAllText("D:\\log.txt", "welterweight");
            }
            if (rando == 2)
            {
                setFight(cardRoster.getLightheavyweights(), fight5);
                fight5.setweight(205);
                File.AppendAllText("D:\\log.txt", "lightheavyweight");
            }
            if (rando == 3)
            {
                setFight(cardRoster.getHeavyweights(), fight5);
                fight5.setweight(265);
                File.AppendAllText("D:\\log.txt", "heavyweight");
            }


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
