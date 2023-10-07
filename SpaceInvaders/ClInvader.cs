using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization.Configuration;

namespace SpaceInvaders
{
    internal class ClInvader
    {
        Form fMain;
        Timer crono = new Timer();
       
        PictureBox image = new PictureBox();

        Bitmap xmapA;
        Bitmap xmapB;

        Point posicio = new Point();

        const int WIDTH = 100;
        const int HEIGHT = 100;

        public ClInvader(Form formulariPrincipal, Bitmap mapA, Bitmap mapB) 
        {
            Random R = new Random();

            fMain = formulariPrincipal;
            
            image.Size = new Size(WIDTH,HEIGHT);

            xmapA = mapA;
            xmapB = mapB;

            image.Image = mapA;

            image.BackColor = Color.Transparent;

            posicio.X = R.Next(0, fMain.Width - WIDTH);
            posicio.Y = R.Next(0, fMain.Height-300);

            image.Location = posicio;
            
            initChangeImg();
            iniTimer();
            initMover();

            fMain.Controls.Add(image);
        }

        private void initMover() {
            crono.Interval = 500;
            crono.Tick += new EventHandler(mover);
            crono.Start();
        }

        private void mover(object sender, EventArgs e)
        {
            const int moviment = 20;
            Random R = new Random();
            int direcion = R.Next(1, 5);
            
            //Si dirrecion = 1 arriba
            if(direcion == 1){
                image.Top -= moviment;
                if(image.Top <= 0) { image.Top = 0; }
            }
            // Si direccion = 2 derecha
            if(direcion == 2){
                image.Left += moviment;
                if(image.Left >= fMain.Width - image.Width){ image.Left = fMain.Width - image.Width; }
            }
            // Si direccion = 3 abajo
            if(direcion == 3){
                image.Top += moviment;
                if(image.Top >= fMain.Height-300){ image.Top = fMain.Height-300;}
            }
            // Si direccion = 4 izquierda
            if(direcion == 4){
                image.Left -= moviment;
                if(image.Left <= 0){ image.Left = 0; }
            }
        }

        private void iniTimer()
        {
            crono.Interval = 250;
            crono.Start();
        }

        private void initChangeImg()
        {
            crono.Interval = 250;
            crono.Tick += new EventHandler(cmabiarImg);
            crono.Start();
        }

        private void cmabiarImg(object sender, EventArgs e)
        {
            if(image.Image == xmapA) { 
                image.Image = xmapB;
            }
            else{
                image.Image = xmapA;
            }
        }

        public Rectangle rectangle()
        {
            // Obtén la ubicación del PictureBox
            Point pictureBoxLocation = image.Location;

            // Crea un rectángulo usando la ubicación del PictureBox y su tamaño
            Rectangle rectangle = new Rectangle(pictureBoxLocation, image.Size);
            
            return rectangle;
        }

       public PictureBox pb()
        {
            return image;
        }
    }
}
