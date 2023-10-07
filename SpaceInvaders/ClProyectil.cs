using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    internal class ClProyectil
    {
        Panel proyectil;
        Form fMain;


        const int WIDTH = 10;
        const int HEIGHT = 10;
        const int VELOCITY = 5;
        const int PUNTOS = 10;

        Timer timerMoviment = new Timer();

        List<ClProyectil> llProyectilList = new List<ClProyectil>();
        List<ClInvader>Invaders = new List<ClInvader>();
        
        public event EventHandler<Panel> borrarProyectil;

        public ClProyectil(Form form, ClNave nave, List<ClInvader>llInvader) 
        {
            proyectil = new Panel();
            fMain = form;

            Invaders = llInvader;

            proyectil.BackColor = Color.Red;

            proyectil.Width = WIDTH;
            proyectil.Height = HEIGHT;
            Panel panelNave = nave.panelNau();
             
            proyectil.Location = new Point(panelNave.Location.X + (panelNave.Width/2), panelNave.Location.Y);

            initTimer();

            fMain.Controls.Add(proyectil);
        }

        public void initTimer()
        {
            timerMoviment.Interval = 10;
            timerMoviment.Tick += new EventHandler(moverProyectil);
            timerMoviment.Start();
        }

        // Sender es el objeto ClProyectil
        private void moverProyectil(object sender, EventArgs e)
        {
            proyectil.Top -= VELOCITY;

            if (proyectil.Top < 0)
            {
                borrarProyectil(this, proyectil);
            }

            // Crear una lista para almacenar los invasores a eliminar
            List<ClInvader> invasoresAEliminar = new List<ClInvader>();

            // Iterar a través de los invasores
            foreach (var invader in Invaders)
            {
                Rectangle invaderRec = invader.rectangle();

                if (proyectil.Bounds.IntersectsWith(invaderRec))
                {
                    // Colisión detectada, agrega este invasor a la lista de los que serán eliminados
                    borrarProyectil(this, proyectil);
                    invasoresAEliminar.Add(invader);
                }
            }

            // Elimina los invasores de la lista de invasores
            foreach (var item in invasoresAEliminar)
            {
                Invaders.Remove(item);
                PictureBox img = item.pb();
                img.Dispose();
            }
        }
    }
}