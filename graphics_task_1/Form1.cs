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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DrawForm(g);
        }

        public void DrawForm(Graphics g)
        {
            /*brushes and pens*/
            Pen blackPen_1 = new Pen(Color.Black, 1);
            Pen blackPen_2 = new Pen(Color.Black, 2);
            Pen blackPen_6 = new Pen(Color.Black, 6);
            Pen greenPen_3 = new Pen(Color.Green, 3);
            Pen lightYellowPen_3 = new Pen(Color.LightYellow, 3);


            Brush blueSolidBrush = new SolidBrush(Color.Blue);
            Brush lightBlueBrush = new SolidBrush(Color.LightBlue);
            Brush steelBlueBrush = new SolidBrush(Color.SteelBlue);

            Brush greenYellowSolidBrush = new SolidBrush(Color.GreenYellow);
            Brush greenSolidBrush = new SolidBrush(Color.Green);
            Brush seaGreenBrush = new SolidBrush(Color.SeaGreen);

            Brush yellowBrush = new SolidBrush(Color.Yellow);

            Brush saddleBrownBrush = new SolidBrush(Color.SaddleBrown);
            Brush sandyBrownBrush = new SolidBrush(Color.SandyBrown);
            Brush brownBrush = new SolidBrush(Color.Brown);


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
            Point skyPoint1 = new Point(0, 475);
            Point skyPoint2 = new Point(150, 485);
            Point skyPoint3 = new Point(300, 500);
            Point skyPoint4 = new Point(450, 500);
            Point skyPoint5 = new Point(600, 490);
            Point skyPoint6 = new Point(750, 485);
            Point skyPoint7 = new Point(900, 470);
            Point skyPoint8 = new Point(1000, 470);
            Point skyPoint9 = new Point(1000, 0);
            Point skyPoint10 = new Point(0, 0);
            Point[] skyPoints = { skyPoint1, skyPoint2, skyPoint3, skyPoint4, skyPoint5, skyPoint6, skyPoint7, skyPoint8, skyPoint9, skyPoint10 };

            RectangleF drawSkyTextRect = new RectangleF(200, 50, 200, 100);
            String skyText = "Небо";

            float tensionSky = 0.1F;
            g.FillClosedCurve(lightBlueBrush, skyPoints, newFillMode, tensionSky);
            g.DrawString(skyText, arialFont, blueSolidBrush, drawSkyTextRect);

            /*******************/

            /*fence*/
            for (byte i = 0; i < 6; i++)
            {
                int xHelpValue = i * 50;
                Point fencePoint1 = new Point(xHelpValue, 430);
                Point fencePoint2 = new Point(xHelpValue, 530);
                Point fencePoint3 = new Point(xHelpValue + 50, 530);
                Point fencePoint4 = new Point(xHelpValue + 50, 430);
                Point fencePoint5 = new Point(xHelpValue + 25, 380);
                Point[] fencePoints = { fencePoint1, fencePoint2, fencePoint3, fencePoint4, fencePoint5 };

                g.FillPolygon(brownBrush, fencePoints);
                g.DrawPolygon(blackPen_2, fencePoints);
            }
            /*******************/

            /*house wall*/
            Rectangle drawHouseWallRect = new Rectangle(250, 250, 450, 300);
            g.FillRectangle(saddleBrownBrush, drawHouseWallRect);
            g.DrawRectangle(blackPen_2, drawHouseWallRect);


            for (byte i = 1; i <= 6; i++)
            {
                Rectangle drawHouseWallPlanksRect = new Rectangle(250, 250, 450, 50 * i);
                g.DrawRectangle(blackPen_1, drawHouseWallPlanksRect);
            }

            Rectangle drawHouseWallWindowRect = new Rectangle(300, 325, 150, 150);
            g.FillRectangle(steelBlueBrush, drawHouseWallWindowRect);
            g.DrawRectangle(blackPen_6, drawHouseWallWindowRect);


            Point windowPoint1 = new Point(375, 325);
            Point windowPoint2 = new Point(375, 475);
            Point windowPoint3 = new Point(300, 400);
            Point windowPoint4 = new Point(450, 400);
            g.DrawLine(blackPen_6, windowPoint1, windowPoint2);
            g.DrawLine(blackPen_6, windowPoint3, windowPoint4);

            Rectangle drawHouseWallDoorRect = new Rectangle(550, 350, 100, 200);
            g.FillRectangle(sandyBrownBrush, drawHouseWallDoorRect);
            g.DrawRectangle(blackPen_2, drawHouseWallDoorRect);
            /*******************/

            /*roof*/
            Point roofPoint1 = new Point(225, 250);
            Point roofPoint2 = new Point(725, 250);
            Point roofPoint3 = new Point(475, 100);
            Point[] roofPoints = { roofPoint1, roofPoint2, roofPoint3 };

            g.FillPolygon(brownBrush, roofPoints);
            g.DrawPolygon(blackPen_2, roofPoints);
            /*******************/

            /*tree*/
            Rectangle drawTreeRect = new Rectangle(850, 325, 30, 200);
            g.FillRectangle(saddleBrownBrush, drawTreeRect);
            g.DrawRectangle(blackPen_2, drawTreeRect);

            Rectangle drawTreeLeavesRect = new Rectangle(765, 170, 200, 250);
            g.FillEllipse(seaGreenBrush, drawTreeLeavesRect);
            g.DrawEllipse(greenPen_3, drawTreeLeavesRect);
            /*******************/

            /*sun*/
            Rectangle drawSunRect = new Rectangle(850, 20, 100, 100);
            g.FillEllipse(yellowBrush, drawSunRect);
            g.DrawEllipse(lightYellowPen_3, drawSunRect);
            /*******************/
        }

        private void Form1_Resize(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            DrawForm(g);
        }
    }
}
