using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightCardGenerator
{
    //parent card class
   public class Card
    {

        // creates a roster, and random variable  and a list of fighter who had been booken on the card already

        Roster cardRoster;
        Random rnd = new Random();

        List<Fighter> bookedFighters = new List<Fighter>();

        //constructor that take a roster
        public Card(Roster r)
        {
            cardRoster = r;
        }

        // takes in a list of fighters (usually a weight class and a fight
        //loops through list, check if they have already been booked and moves fighter out of list and into list of booked fighter, booking them


        public void setFight(List<Fighter> f, Fight f1)
        {
            List<Fighter> toRemove = new List<Fighter>();

            // adds non booked figher to list of fighters to be removed from the given lists

            foreach (Fighter fi in f)
            {
                if ( bookedFighters.Contains(fi))
                {
                    toRemove.Add(fi);
                }
            }

            // removes all fighter to be removed from the given list

            foreach (Fighter fi in toRemove)
            {
                if (bookedFighters.Contains(fi))
                {
                    f.Remove(fi);
                }
            }


            //if the given list is not empty

            if (f.Count > 1)
            {
                // get a random fighter from th elist
                int rando = rnd.Next(f.Count);
                Fighter g = f.ElementAt(rando);

                //keep picking a random fighter until you get one not already booked
                while (bookedFighters.Contains(g))
                {
                    rando = rnd.Next(f.Count);
                    g = f.ElementAt(rando);
                }

                // add the fighter to the fight and the booked list
                // remove them from the give list

                f1.setFighter1(g);
                bookedFighters.Add(g);
                f.Remove(g);

                // get a second random fighter

                int rando2 = rnd.Next(f.Count);
                Fighter h = f.ElementAt(rando2);

                //keep picking random second fighter until you get unbooked fighter
                while (bookedFighters.Contains(h))
                {
                    rando2 = rnd.Next(f.Count);
                    g = f.ElementAt(rando2);
                }

                // add the fighter to the fight and the booked list
                // remove them from the give list
                f1.setFighter2(h);
                bookedFighters.Add(h);
                f.Remove(h);

            }
        }

    }

}
