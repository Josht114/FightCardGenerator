using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightCardGenerator
{
   public class Fighter
    {
        String name;
        int upperWeight;
        int lowerWeight;
        Boolean isBantam = false;
        Boolean isFeather = false;
        Boolean isLight = false;
        Boolean isWelter = false;
        Boolean isMiddle = false;
        Boolean isLightHeavy = false;
        Boolean isHeavy = false;


        //Fighter constructor
        public Fighter(String FighterName, int upWeight, int lowWeight)
        {
            name =  FighterName;
            upperWeight = upWeight;
            lowerWeight = lowWeight;
            calcWeightClasses();
        }


        public String getName()
        {
            return name;
        }

        public int getUpperWeight()
        {
            return upperWeight;
        }

        public int getLowerWeight()
        {
            return lowerWeight;
        }

        public void calcWeightClasses()
        {
            if (upperWeight > 205 || lowerWeight > 205)
            {
                isHeavy = true;
            }


            if (isWeight(206, 185))
            {
                isLightHeavy = true;
            }

            if (isWeight(186, 170))
            {
                isMiddle = true;
            }

            if (isWeight(171, 155))
            {
                isWelter = true;
            }

            if (isWeight(156, 145))
            {
                isLight = true;
            }

            if (isWeight(146, 135))
            {
                isFeather = true;
            }

            if (isWeight(136, 125))
            {
                isBantam = true;
            }
        }



        public Boolean isWeight(int up, int low)
        {
            if ((lowerWeight < up || upperWeight < up) && (lowerWeight > low || upperWeight > low))
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        public Boolean getIsBantam()
        {
            return isBantam;
        }

        public Boolean getIsFeather()
        {
            return isFeather;
        }

        public Boolean getIsLight()
        {
            return isLight;
        }

        public Boolean getIsWelter()
        {
            return isWelter;
        }

        public Boolean getIsMiddle()
        {
            return isMiddle;
        }

        public Boolean getIsLightHeavy()
        {
            return isLightHeavy;
        }

        public Boolean getIsHeavy()
        {
            return isHeavy;
        }

        public String getWeightClasses()
        {
            String listOfWeights = "";

            if(getIsHeavy())
            {
                listOfWeights = listOfWeights + "Heavy, ";
            }
            if (getIsLightHeavy())
            {
                listOfWeights = listOfWeights + "Lightheavy, ";
            }
            if (getIsMiddle())
            {
                listOfWeights = listOfWeights + "middle, ";
            }
            if (getIsWelter())
            {
                listOfWeights = listOfWeights + "Welter, ";
            }
            if (getIsLight())
            {
                listOfWeights = listOfWeights + "Light, ";
            }
            if (getIsFeather())
            {
                listOfWeights = listOfWeights + "Feather, ";
            }
            if (getIsBantam())
            {
                listOfWeights = listOfWeights + "Bantam, ";
            }


            return listOfWeights;
        }



    }
}
