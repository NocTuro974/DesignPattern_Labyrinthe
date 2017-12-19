using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Labyrinthe
{
    class Items : ItemPerson
    {
        private int damages;

        public int Damages
        {
            get
            {
                return damages;
            }

            set
            {
                damages = value;
            }
        }
        public Items(int damages)
        {
            this.Damages = damages;
        }
    }
}
