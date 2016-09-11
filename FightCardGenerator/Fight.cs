using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightCardGenerator
{
    class Fight
    {
        Fighter fighter1;
        Fighter fighter2;
        public Fight(Fighter a, Fighter b)
        {
            fighter1 = a;
            fighter2 = b;

        }

        public Fight()
        {

        }


        public Fighter getFighter1()
        {
            return fighter1;
        }

        public Fighter getFighter2()
        {
            return fighter2;
        }


        public void setFighter1(Fighter a)
        {
            fighter1 = a;

        }

        public void setFighter2(Fighter b)
        {
            fighter2 = b;
        }
    }
}
