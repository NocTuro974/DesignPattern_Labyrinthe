using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Labyrinthe
{
    class Person : ItemPerson
    {
        private int attack;
        private int lifePoints;
        private bool mood;
        private List<Items> items;
        private int x;
        private int y;

        public int Attack
        {
            get
            {
                return attack;
            }

            set
            {
                attack = value;
            }
        }

        public int LifePoints
        {
            get
            {
                return lifePoints;
            }

            set
            {
                lifePoints = value;
            }
        }

        public bool Mood
        {
            get
            {
                return mood;
            }

            set
            {
                mood = value;
            }
        }

        internal List<Items> Items
        {
            get
            {
                return items;
            }

            set
            {
                items = value;
            }
        }

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public Person(bool mood, int x, int y)
        {
            this.Attack = 10;
            this.LifePoints = 100;
            this.Mood = mood;
            this.Items = new List<Items>();
            this.X = x;
            this.Y = y;
        }
    }
}

