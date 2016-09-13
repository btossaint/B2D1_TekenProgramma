using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TekenProgramma_001
{
    public partial class Form1 : Form
    {        
        private Graphics canvas;
        private List<Vierkant> vierkanten;

        public Form1()
        {
            InitializeComponent();             
            //Vierkant vkVierkant = new Vierkant();           
            vierkanten = new List<Vierkant>();
            //vierkanten.Add(vkVierkant);
            canvas = pbCanvas.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }        

        private void bTeken_Click(object sender, EventArgs e)
        {
            //Voeg vierkant toe aan lijst
            int x = 5*vierkanten.Count;
            int y = 10*vierkanten.Count;

            ColorDialog cd = new ColorDialog();

            DialogResult result = cd.ShowDialog();
            Color k = cd.Color;

            Vierkant nieuwVierkant = new Vierkant(x,y,k);

            vierkanten.Add(nieuwVierkant);

            //Teken de vierkanten
            //canvas.Clear(Color.White);
            foreach (var vk in vierkanten)
            {
                int x1 = vk.X;
                int y1 = vk.Y;
                Color k1 = vk.Kleur;

                Rectangle vierkantPlaatje = new Rectangle(x1,y1,50,30);
                Pen pen = new Pen(k1);
                canvas.DrawRectangle(pen, vierkantPlaatje);
            }
                                       
        }
        
    }
}
