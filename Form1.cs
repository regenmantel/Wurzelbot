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

        /*
        Notes:

        Gesamt Screen : 0px x 0px -> 2560px x 1080px (Widescreen)
        Gie�en 1425 x 300;
        Feld Start: 1070 x 390
        +40 f�r jedes Feld
        */

        Click c = new Click();

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

            int xEnd = 1750;
            int yEnd = 830;

            while (go)
            {
                if (p.X >= xEnd && p.Y == 390)
                {
                    go = false;
                }
                else
                {
                    c.move(p);

                    if (Convert.ToInt32(cBoxFields.Items[cBoxFields.SelectedIndex]) == 1)
                    {
                        c.leftClick(p);
                        p.Y += 40;
                        Thread.Sleep(Convert.ToInt32(cBoxSpeed.Items[cBoxSpeed.SelectedIndex].ToString()));

                        if (p.Y > yEnd)
                        {
                            p.X += 40;
                            p.Y = 390;
                        }
                    }
                    else if (Convert.ToInt32(cBoxFields.Items[cBoxFields.SelectedIndex]) == 2)
                    {
                        c.leftClick(p);
                        p.Y += 40;
                        Thread.Sleep(Convert.ToInt32(cBoxSpeed.Items[cBoxSpeed.SelectedIndex].ToString()));

                        if (p.Y > yEnd)
                        {
                            p.X += 80;
                            p.Y = 390;
                        }
                    }
                    else if (Convert.ToInt32(cBoxFields.Items[cBoxFields.SelectedIndex]) == 4)
                    {
                        c.leftClick(p);
                        p.Y += 80;
                        Thread.Sleep(Convert.ToInt32(cBoxSpeed.Items[cBoxSpeed.SelectedIndex].ToString()));

                        if (p.Y > yEnd)
                        {
                            p.X += 80;
                            p.Y = 390;
                        }
                    }
                }
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

        private void WurzelBot_Load(object sender, EventArgs e)
        {

        }
    }
}