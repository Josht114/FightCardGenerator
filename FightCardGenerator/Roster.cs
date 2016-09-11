using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightCardGenerator
{
    class Roster
    {
        List<Fighter> allFighters = new List<Fighter>();
        List<Fighter> heavyweights = new List<Fighter>();
        List<Fighter> lightheavyweights = new List<Fighter>();
        List<Fighter> middleweights = new List<Fighter>();
        List<Fighter> welterweights = new List<Fighter>();
        List<Fighter> lightweights = new List<Fighter>();
        List<Fighter> featherweights = new List<Fighter>();
        List<Fighter> bantamweights = new List<Fighter>();



        public void addFighter(Fighter f)
        {
            allFighters.Add(f);

            // SHOULD EMPTY LISTS HERE BEFORE RE-ADDING ALL AGAIN

         //   initializeRoster();

        }


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

        public List<Fighter> getBamtamweights()
        {
            return bantamweights;

        }

        public List<Fighter> getFeathermweights()
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

    }
}
