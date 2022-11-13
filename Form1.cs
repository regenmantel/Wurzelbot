using System.Runtime.InteropServices;
using System.Threading;

namespace Wurzelbot
{
    public partial class WurzelBot : Form
    {
        public WurzelBot()
        {
            InitializeComponent();
        }

        Click c = new Click();
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnWasser_Click_1(object sender, EventArgs e)
        {
            Giessen();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            Pflanzen();
        }

        public void Pflanzen()
        {
            bool go = true;
            
            Point p = new Point();
            p.X = 1070;
            p.Y = 390;

            int xEnd = 1710;
            int yEnd = 830;

            while (go)
            {
                if (p.X == xEnd && p.Y == yEnd)
                    go = false;

                c.move(p);

                p.Y += 40;
                Thread.Sleep(Convert.ToInt32(cBoxSpeed.Items[cBoxSpeed.SelectedIndex].ToString()));

                if (p.Y > yEnd)
                {
                    p.X += 40;
                    p.Y = 390;
                }

                c.leftClick(p);
            }
        }

        public void Giessen()
        {
            bool go = true;

            Point p = new Point();

            p.X = 1425;
            p.Y = 300;

            c.move(p);
            c.leftClick(p);

            Thread.Sleep(2000);

            p.X = 1070;
            p.Y = 350;

            c.move(p);
            c.leftClick(p);

            int xEnd = 1710;
            int yEnd = 830;

            while (go)
            {
                if (p.X == xEnd && p.Y == yEnd)
                    go = false;

                p.Y += 40;
                Thread.Sleep(Convert.ToInt32(cBoxSpeed.Items[cBoxSpeed.SelectedIndex].ToString()));

                if (p.Y > yEnd)
                {
                    p.X += 40;
                    p.Y = 390;
                }

                c.leftClick(p);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }


        /*
        Notes:

        Gesamt Screen : 0px x 0px -> 2560px x 1080px


        Gieﬂen 1425 x 300;


        Feld: 1070 x 390

        nach unten!!
        +40 nach links und rechts

        430
        470
        510
        550
        590
        630
        670
        710
        750
        790
        830
        */
    }
}