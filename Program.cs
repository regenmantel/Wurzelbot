namespace Wurzelbot
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
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