using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightCardGenerator
{
  public class ShootoCard : Card
    {
        Roster cardRoster;
        static Random rnd = new Random();
        List<int> bookedWeights = new List<int>();

        Fight fight1 = new Fight();
        Fight fight2 = new Fight();
        Fight fight3 = new Fight();
        Fight fight4 = new Fight();
        Fight fight5 = new Fight();

        public ShootoCard(Roster r) : base(r)
        {
            cardRoster = r;





            int i = 0;

            while (i < 7)
            {

                int rando = rnd.Next(7);


                while (bookedWeights.Contains(rando))
                {
                    rando = rnd.Next(7);
                }

                bookedWeights.Add(rando);
                i++;
            }




            setupFight(fight1, bookedWeights[0]);
            setupFight(fight2, bookedWeights[1]);
            setupFight(fight3, bookedWeights[2]);
            setupFight(fight4, bookedWeights[3]);
            setupFight(fight5, bookedWeights[4]);



        }




        public void setupFight(Fight f, int weight)
        {
            if(weight == 0)
            {
                setFight(cardRoster.getHeavyweights(), f);
                f.setweight(265);
                File.AppendAllText("D:\\log.txt", "heavyweight");
            }

            if (weight == 1)
            {
                setFight(cardRoster.getLightheavyweights(), f);
                f.setweight(205);
                File.AppendAllText("D:\\log.txt", "lightheavyweight");
            }
            if (weight == 2)
            {
                setFight(cardRoster.getMiddleweights(), f);
                f.setweight(185);
                File.AppendAllText("D:\\log.txt", "Middleweight");
            }
            if (weight == 3)
            {
                setFight(cardRoster.getWelterweights(), f);
                f.setweight(170);
                File.AppendAllText("D:\\log.txt", "Welterweight");
            }
            if (weight == 4)
            {
                setFight(cardRoster.getLightweights(), f);
                f.setweight(155);
                File.AppendAllText("D:\\log.txt", "lightweight");
            }
            if (weight == 5)
            {
                setFight(cardRoster.getFeatherweights(), f);
                f.setweight(145);
                File.AppendAllText("D:\\log.txt", "Featherweight");
            }
            if (weight == 6)
            {
                setFight(cardRoster.getBantamweights(), f);
                f.setweight(135);
                File.AppendAllText("D:\\log.txt", "Bantamweight");
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
