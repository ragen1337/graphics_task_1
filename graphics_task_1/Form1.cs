using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics_task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 1000;
            this.Height = 700;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            /*brushes and pens*/
            Pen blackPen = new Pen(Color.Black);
            Brush blueSolidBrush = new SolidBrush(Color.Blue);
            Brush greenYellowSolidBrush = new SolidBrush(Color.GreenYellow);
            Brush greenSolidBrush = new SolidBrush(Color.Green);
            Brush lightBlueBrush = new SolidBrush(Color.LightBlue);

            FillMode newFillMode = FillMode.Winding;
            /*******************/

            /*fonts*/
            Font arialFont = new Font("Arial", 16);
            /*******************/

            /*grass*/
            PointF grassPoint1 = new PointF(0, 475);
            PointF grassPoint2 = new PointF(150, 485);
            PointF grassPoint3 = new PointF(300, 500);
            PointF grassPoint4 = new PointF(450, 500);
            PointF grassPoint5 = new PointF(600, 490);
            PointF grassPoint6 = new PointF(750, 485);
            PointF grassPoint7 = new PointF(900, 470);
            PointF grassPoint8 = new PointF(1000, 470);
            PointF grassPoint9 = new PointF(1000, 700);
            PointF grassPoint10 = new PointF(0, 700);
            PointF[] grassPoints = { grassPoint1, grassPoint2, grassPoint3, grassPoint4, grassPoint5, grassPoint6, grassPoint7, grassPoint8, grassPoint9, grassPoint10 };

            RectangleF drawGrassTextRect = new RectangleF(500, 600, 200, 100);
            String grassText = "Трава";

            float tensionGrass = 0.1F;
            g.FillClosedCurve(greenYellowSolidBrush, grassPoints, newFillMode, tensionGrass);
            g.DrawString(grassText, arialFont, greenSolidBrush, drawGrassTextRect);
            /*******************/

            /*sky*/
            PointF skyPoint1 = new PointF(0, 475);
            PointF skyPoint2 = new PointF(150, 485);
            PointF skyPoint3 = new PointF(300, 500);
            PointF skyPoint4 = new PointF(450, 500);
            PointF skyPoint5 = new PointF(600, 490);
            PointF skyPoint6 = new PointF(750, 485);
            PointF skyPoint7 = new PointF(900, 470);
            PointF skyPoint8 = new PointF(1000, 470);
            PointF skyPoint9 = new PointF(1000, 0);
            PointF skyPoint10 = new PointF(0, 0);
            PointF[] skyPoints = { skyPoint1, skyPoint2, skyPoint3, skyPoint4, skyPoint5, skyPoint6, skyPoint7, skyPoint8, skyPoint9, skyPoint10 };

            RectangleF drawSkyTextRect = new RectangleF(200, 50, 200, 100);
            String skyText = "Небо";

            float tensionSky = 0.1F;
            g.FillClosedCurve(lightBlueBrush, skyPoints, newFillMode, tensionSky);
            g.DrawString(skyText, arialFont, blueSolidBrush, drawSkyTextRect);
            /*******************/
        }
    }
}
