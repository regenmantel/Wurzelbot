using System;
using System.IO;
using Newtonsoft.Json;
using Wurzelbot.Structure;

namespace Wurzelbot
{
    public partial class WurzelBot : Form
    {
        public WurzelBot()
        {
            InitializeComponent();
        }

        Click c = new Click();

        readonly Base data = JsonConvert.DeserializeObject<Base>(GlobalVariables.JsonData);

        private void btnPlant_Click(object sender, EventArgs e)
        {
            int plantX = 0;
            int plantY = 0;
            Point p = new Point();

            if (rBtnWideScreen.Checked == true)
            {
                plantX = data.Bigger.plantX;
                plantY = data.Bigger.plantY;
            }

            p.X = plantX;
            p.Y = plantY;

            c.leftClick(p);
            Thread.Sleep(1000);
            ConsoleManager.Log("Started planting ...");
            run();
        }

        private void btnHarvest_Click(object sender, EventArgs e)
        {
            int harvestX = 0;
            int harvestY = 0;
            Point p = new Point();

            if (rBtnWideScreen.Checked == true)
            {
                harvestX = data.Bigger.harvestX;
                harvestY = data.Bigger.harvestY;
            }

            p.X = harvestX;
            p.Y = harvestY;

            c.leftClick(p);
            Thread.Sleep(1000);
            ConsoleManager.Log("Started harvesting ...");
            run();
        }

        private void btnWater_Click(object sender, EventArgs e)
        {
            int waterX = 0;
            int waterY = 0;
            Point p = new Point();

            if (rBtnWideScreen.Checked == true)
            {
                waterX = data.Bigger.waterX;
                waterY = data.Bigger.waterY;
            }

            p.X = waterX;
            p.Y = waterY;

            c.leftClick(p);
            Thread.Sleep(1000);
            ConsoleManager.Log("Started watering ...");
            run();
        }

        public void run()
        {
            bool go = true;

            int startX = 0;
            int startY = 0;
            int endX = 0;
            int endY = 0;

            if (rBtnWideScreen.Checked == true)
            {
                ConsoleManager.Log("Working with bigger mode");
                startX = data.Bigger.startX;
                startY = data.Bigger.startY;

                endX = data.Bigger.endX;
                endY = data.Bigger.endY;
            }
            else if (rBtnNormalScreen.Checked == true)
            {
                ConsoleManager.Log("Working with normal mode");
                startX = data.Normal.startX;
                startY = data.Normal.startY;

                endX = data.Normal.endX;
                endY = data.Normal.endY;
            }

            Point p = new Point();

            p.X = startY;
            p.Y = startX;

            while (go)
            {
                if (p.X >= endX && p.Y == 390)
                {
                    go = false;
                    ConsoleManager.Log("Finsihed working ...");
                }
                else
                {
                    c.move(p);

                    if (Convert.ToInt32(cBoxFields.Items[cBoxFields.SelectedIndex]) == 1)
                    {
                        c.leftClick(p);
                        p.Y += 40;
                        Thread.Sleep(Convert.ToInt32(cBoxSpeed.Items[cBoxSpeed.SelectedIndex].ToString()));

                        if (p.Y > endY)
                        {
                            p.X += 40;
                            p.Y = 390;
                        }
                        ConsoleManager.Log("Working on: X=" + p.X + "|" + p.Y);
                    }
                    else if (Convert.ToInt32(cBoxFields.Items[cBoxFields.SelectedIndex]) == 2)
                    {
                        c.leftClick(p);
                        p.Y += 40;
                        Thread.Sleep(Convert.ToInt32(cBoxSpeed.Items[cBoxSpeed.SelectedIndex].ToString()));

                        if (p.Y > endY)
                        {
                            p.X += 80;
                            p.Y = 390;
                        }
                        ConsoleManager.Log("Working on: X=" + p.X + "|" + p.Y);
                    }
                    else if (Convert.ToInt32(cBoxFields.Items[cBoxFields.SelectedIndex]) == 4)
                    {
                        c.leftClick(p);
                        p.Y += 80;
                        Thread.Sleep(Convert.ToInt32(cBoxSpeed.Items[cBoxSpeed.SelectedIndex].ToString()));

                        if (p.Y > endY)
                        {
                            p.X += 80;
                            p.Y = 390;
                        }
                        ConsoleManager.Log("Working on: " + p.X + "|" + p.Y);
                    }
                }
            }
        }

        private void WurzelBot_Load(object sender, EventArgs e)
        {
            ConsoleManager.EnableConsole();
            WelcomeMessage();
            rBtnNormalScreen.Checked = true;
            cBoxFields.SelectedIndex = 0;
            cBoxSpeed.SelectedIndex = 0;
        }

        private void WurzelBot_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }

        private void WelcomeMessage()
        {
            ConsoleManager.Log(" __          __                 _ ____        _   \r\n \\ \\        / /                | |  _ \\      | |  \r\n  \\ \\  /\\  / _   _ _ __ _______| | |_) | ___ | |_ \r\n   \\ \\/  \\/ | | | | '__|_  / _ | |  _ < / _ \\| __|\r\n    \\  /\\  /| |_| | |   / |  __| | |_) | (_) | |_ \r\n     \\/  \\/  \\__,_|_|  /___\\___|_|____/ \\___/ \\__|\r\n                                                  \r\n                                                  \r\n\r\n");
            ConsoleManager.Log("Willkommen beim WurzelBot! Ernte, pflanze und gieße deine Pflanzen ganz Entspannt mit nur ein paar wenigen Klicks.\n\n1. Entscheide dich für die Größe deines Bildschirms\n2. Bestimme, wie viele Felder deine Pflanze benötigt\n3. Passe die Arbeitsgeschwindigkeit des Bots nach deinen Vorstellungen an\n4. Starte den Vorgang, indem du einen beliebigen Button auswählst\n\nAchtung: Sobald du einen Button gedrückt hast, bewege deine Maus nicht und finger weg von der Tastaur.");
        }
    }
}