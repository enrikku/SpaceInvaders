using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class FormMain : Form
    {
        ClNave Nave;
        ClInvader a;
        Timer crono = new Timer();
        public bool iniciar = false;
        List<ClProyectil> llProyectilList = new List<ClProyectil>();
        
        List<ClInvader>llInvader = new List<ClInvader>();
        List<Bitmap> llImagesA = new List<Bitmap>();
        List<Bitmap> llImagesB = new List<Bitmap>();

        SoundPlayer shoot = new SoundPlayer(Application.StartupPath + @"\..\..\bloop.wav");

        private void imagesA(){
            llImagesA.Add(Properties.Resources.spi01a);
            llImagesA.Add(Properties.Resources.spi02a);
            llImagesA.Add(Properties.Resources.spi03a);
        }

        private void imagesB(){
            llImagesB.Add(Properties.Resources.spi01b);
            llImagesB.Add(Properties.Resources.spi02b);
            llImagesB.Add(Properties.Resources.spi03b);
        }

        public FormMain(){
            InitializeComponent();
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }

            if (e.KeyCode == Keys.Right) { Nave.moverIzquierda(); }
            if (e.KeyCode == Keys.Left) { Nave.moverDerecha(); }

            if (e.KeyCode == Keys.Space){
                if (!iniciar){
                    iniciar = true;
                    this.BackgroundImage = null;
                    Nave = new ClNave(this);
                }else{
                    //TODO
                    // * Falta añador sonido disparo
                    llProyectilList.Add(new ClProyectil(this, Nave, llInvader));
                    // AL ultimo elemento de la lista le damos el evento
                    llProyectilList[llProyectilList.Count - 1].borrarProyectil += new EventHandler<Panel>(borrarProyectil);

                    shoot.Play();
                }
            }
        }

        private void borrarProyectil(object sender, Panel e){
            llProyectilList.Remove((ClProyectil)sender);
            this.Controls.Remove(e);
            totalProyectiles.Text = llProyectilList.Count.ToString();
        }

        private void FormMain_Load(object sender, EventArgs e){
            imagesA();
            imagesB();
            
            initTimer();
        }

        private void initTimer(){
            crono.Interval = 2000;
            crono.Tick += new EventHandler(crearInvader);
            crono.Start();
        }

        private void crearInvader(object sender, EventArgs e){
           if(iniciar){
                Random R = new Random();
                int pos = R.Next(0, llImagesA.Count - 1);
                System.Threading.Thread.Sleep(10);
                llInvader.Add(new ClInvader(this, llImagesA[pos], llImagesB[pos]));
            }
        }
    }
}