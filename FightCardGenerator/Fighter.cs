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

            if (upperWeight < 206 && upperWeight > 185 || lowerWeight < 206 && (lowerWeight > 185 || upperWeight > 185))
            {
                isLightHeavy = true;
            }

            if (upperWeight < 186 && upperWeight > 170 || lowerWeight < 186 && (lowerWeight > 170 || upperWeight > 170))
            {
                isMiddle = true;
            }

            if (upperWeight < 171 && upperWeight > 155 || lowerWeight < 171 && (lowerWeight > 155 || upperWeight > 155))
            {
                isWelter = true;
            }

            if (upperWeight < 156 && upperWeight > 145 || lowerWeight < 156 && (lowerWeight > 145 || upperWeight > 145))
            {
                isLight = true;
            }

            if (upperWeight < 146 && upperWeight > 135 || lowerWeight < 146 && (lowerWeight > 135 || upperWeight > 135))
            {
                isFeather = true;
            }

            if (upperWeight < 136 && upperWeight > 125 || lowerWeight < 136 && (lowerWeight > 125 || upperWeight > 125))
            {
                isBantam = true;
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
