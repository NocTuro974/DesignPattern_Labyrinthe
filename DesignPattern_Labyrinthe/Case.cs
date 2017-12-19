using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Labyrinthe
{
    class Case
    {
        private ItemPerson itemPerson;
        private int type;
        private Items item;
        private bool fighter;



        internal Items Item
        {
            get
            {
                return item;
            }

            set
            {
                item = value;
            }
        }

        public bool Fighter
        {
            get
            {
                return fighter;
            }

            set
            {
                fighter = value;
            }
        }

        internal ItemPerson ItemPerson
        {
            get
            {
                return itemPerson;
            }

            set
            {
                itemPerson = value;
            }
        }

        public int Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
    }
}
