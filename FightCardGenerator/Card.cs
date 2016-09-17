using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightCardGenerator
{
   public class Card
    {
        Roster cardRoster;
        Random rnd = new Random();

        List<Fighter> bookedFighters = new List<Fighter>();


        public Card(Roster r)
        {
            cardRoster = r;

        }


        public void setFight(List<Fighter> f, Fight f1)
        {
            int rando = rnd.Next(f.Count);
            Fighter g = f.ElementAt(rando);

            while (bookedFighters.Contains(g))
            {
                rando = rnd.Next(f.Count);
                g = f.ElementAt(rando);
            }

            f1.setFighter1(g);
            bookedFighters.Add(g);
            f.Remove(g);



            int rando2 = rnd.Next(f.Count);
            Fighter h = f.ElementAt(rando2);

            while (bookedFighters.Contains(h))
            {
                rando2 = rnd.Next(f.Count);
                g = f.ElementAt(rando2);
            }

            f1.setFighter2(h);
            bookedFighters.Add(h);
            f.Remove(h);


        }

    }

}
