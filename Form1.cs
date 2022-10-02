using System.Runtime.InteropServices;

namespace Wurzelbot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Click c = new Click();
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnWasser_Click_1(object sender, EventArgs e)
        {
            Point p = new Point();
            p.X = 1425;
            p.Y = 300;

            c.leftClick(p);
        }
    }
}