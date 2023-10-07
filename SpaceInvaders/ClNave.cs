using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    internal class ClNave
    {
        Form fMain;
        Panel pnl;

        const int WIDTH = 100;
        const int HEIGHT = 20;

        const int velocity = 10;

        public ClNave(Form formulariPrincipal) 
        {
            fMain = formulariPrincipal;
            pnl = new Panel();

            pnl.BackColor = Color.White;

            pnl.Width = WIDTH;
            pnl.Height = HEIGHT;

            pnl.Location = new Point((formulariPrincipal.Width/2) - (WIDTH/2) , formulariPrincipal.Height-HEIGHT-10);

            fMain.Controls.Add(pnl);
        }
   
       public void moverIzquierda() 
        { 
            pnl.Left += velocity; 
            if(pnl.Right >= fMain.Width) { pnl.Left = (fMain.Width - WIDTH); }
        }

        public void moverDerecha() 
        { 
            pnl.Left -= velocity; 
            if (pnl.Left <= 0) { pnl.Left = (0); }
        }

        public Panel panelNau() { return pnl; }
    }
}