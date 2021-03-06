﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// PRIDECARD HAVE NO MIDDLEWEIGHT OR FEATHERWEIGHT AND BELOW
// HAS ONE FIGHT OF IN EACH WEIGHT PLUS 1 RANDOM WEIGHT FIGHT

namespace FightCardGenerator
{
    // inherits from car class
    public class PrideCard : Card
    {
        // creates a roster, a random variable and 5 empty fights



        // constructor takes in a roster and sets 5 fights, 1 for each weight 
        // class and 1 at a random weight
        // also gives each fight its weight class
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



            // log to debug text file
            //       File.AppendAllText("D:\\log.txt", rando.ToString());

            //5th random weight class is set by creating a random between 0-4
            // each number coresponds to a different weight class to set the fight to
            // ADD CHECK THAT IF CAN'T MAKE FIGHT IN THAT CLASS PICK ANOTHER

            int rando = rnd.Next(4);

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

    }
}
