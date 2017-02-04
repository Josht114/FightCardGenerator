using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightCardGenerator
{
   public class Roster
    {
        // creates a list of fighter for each weight class

        List<Fighter> allFighters = new List<Fighter>();
        List<Fighter> heavyweights = new List<Fighter>();
        List<Fighter> lightheavyweights = new List<Fighter>();
        List<Fighter> middleweights = new List<Fighter>();
        List<Fighter> welterweights = new List<Fighter>();
        List<Fighter> lightweights = new List<Fighter>();
        List<Fighter> featherweights = new List<Fighter>();
        List<Fighter> bantamweights = new List<Fighter>();


        // adds a fighter to the list of all fighters
        public void addFighter(Fighter f)
        {
            allFighters.Add(f);
        }

        //for each fighter in the all fighter list
        // check their weight and add them to the correct weight lass lists
        public void initializeRoster()
        {
            foreach (Fighter f in allFighters)
            {
                if (f.getIsBantam())
                {
                    bantamweights.Add(f);
                }

                if (f.getIsFeather())
                {
                    featherweights.Add(f);
                }

                if (f.getIsLight())
                {
                    lightweights.Add(f);
                }

                if (f.getIsWelter())
                {
                    welterweights.Add(f);
                }

                if (f.getIsMiddle())
                {
                    middleweights.Add(f);
                }

                if (f.getIsLightHeavy())
                {
                    lightheavyweights.Add(f);
                }

                if (f.getIsHeavy())
                {
                    heavyweights.Add(f);
                }
            }

        }

        // getters for each weight class list

        public List<Fighter> getBantamweights()
        {
            return bantamweights;
        }

        public List<Fighter> getFeatherweights()
        {
            return featherweights;
        }

        public List<Fighter> getLightweights()
        {
            return lightweights;
        }

        public List<Fighter> getWelterweights()
        {
            return welterweights;
        }

        public List<Fighter> getMiddleweights()
        {
            return middleweights;
        }

        public List<Fighter> getLightheavyweights()
        {
            return lightheavyweights;
        }

        public List<Fighter> getHeavyweights()
        {
            return heavyweights;
        }


        // returns a string list of all fighters

        public String stringAllFighters()
        {
            String allNames = "";

            foreach(Fighter f in allFighters)
            {
                allNames = allNames + " " + f.getName() + f.getWeightClasses() + " \n";
            }

            return allNames;

        }

        // string representation of all fighter in a given weight class

        public String stringAllIntWeight(List<Fighter> l)
        {
            String allNames = "";

            foreach (Fighter f in l)
            {
                allNames = allNames + " " + f.getName() + " ";
            }

            return allNames;

        }


    }
}
