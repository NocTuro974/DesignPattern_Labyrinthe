using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Labyrinthe
{
    class Labyrinth
    {
        private Case[,] shape;
        private int length;
        private int height;
        private enum type { libre = 0, mur = 1, sortie = 2 };

        public Case[,] Shape
        {
            get
            {
                return shape;
            }

            set
            {
                shape = value;
            }
        }

        public Labyrinth()
        {
            this.shape = new Case[length, height];
        }
        public void init()
        {
            //initialisation des cases (0 si libre, 1 si mur, 2 si sortie)

            //place les joueurs aléatoirement sur des cases libres

        }

        public void generateItems()
        {

            Random random = new Random();

            int i = random.Next(length - 1);
            int j = random.Next(height - 1);
            while (Shape[i, j].Type != 0)
            {
                i = random.Next(length - 1);
                j = random.Next(height - 1);
            }
            Items item = new Items(random.Next(10));
            shape[i, j].Item = item;

        }
    }
}
