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
        Gießen 1425 x 300;
        Feld Start: 1070 x 390
        +40 für jedes Feld
        */

        Click c = new Click();

        private void btnGiessen_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            p.X = 1100;
            p.Y = 300;

            c.leftClick(p);
            Thread.Sleep(1000);
            run();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            Point p = new Point();
            p.X = 1000;
            p.Y = 300;

            c.leftClick(p);
            Thread.Sleep(1000);
            run();
        }

        public void run()
        {
            bool go = true;

            int yStart = 0;
            int xStart = 0;
            int xEnd = 0;
            int yEnd = 0;

            if (rBtnWideScreen.Checked == true)
            {
                yStart = 1070;
                xStart = 390;

                xEnd = 1750;
                yEnd = 830;
            }
            else if (rBtnNormalScreen.Checked == true)
            {
                yStart = 760;
                xStart = 410;

                xEnd = 1440;
                yEnd = 850;
            }

            Point p = new Point();

            p.X = yStart;
            p.Y = xStart;

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

        private void WurzelBot_Load(object sender, EventArgs e)
        {
            rBtnNormalScreen.Checked = true;
            cBoxFields.SelectedIndex = 0;
            cBoxSpeed.SelectedIndex = 0;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Form2 help = new Form2();
            help.Show();
        }

        private void WurzelBot_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }
    }
}