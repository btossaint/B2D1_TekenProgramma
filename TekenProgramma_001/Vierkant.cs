using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekenProgramma_001
{
    public class Vierkant
    {
        private int x;
        private int y;
        private int dikte;
        private Color kleur;

        // standaard constructor
        public Vierkant()
        {
            this.x = 50;
            this.y = 100;
            this.Kleur = Color.Crimson;                        
        }
        // tweede constructor
        public Vierkant(int x, int y, Color k)
        {
            this.x = x;
            this.y = y;
            this.kleur = k;                
        }

        public int X
        {
            get { return x; }
            //set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Color Kleur
        {
            get { return kleur; }
            set { kleur = value; }
        }

        public void Verplaatsen()
        {
            this.x += 50;
            this.y += 50;
        }

        public void Verplaatsen(int xwaarde, int ywaarde)
        {
            this.x = xwaarde;
            this.y = ywaarde;
        }
    }
}
