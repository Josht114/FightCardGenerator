using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightCardGenerator
{
    class Card
    {
        Roster cardRoster;
        Random rnd = new Random();

        public Card(Roster r)
        {
            cardRoster = r;

        }



        public void what()
        {

        }

        public void setFight(List<Fighter> f, Fight f1)
        {



                int rando = rnd.Next(f.Count);
                f1.setFighter1(f.ElementAt(rando));
                f.RemoveAt(rando);

                int rando2 = rnd.Next(f.Count);
                f1.setFighter2(f.ElementAt(rando2));
                f.RemoveAt(rando2);

            }


        }

    }

