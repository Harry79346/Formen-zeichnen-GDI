using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formen_zeichnen_GDI
{
    public partial class MainWindow : Form
    {
        //Die Felder
        //für die Zeichenfläche:
        Graphics canvas;
        //für die Größe der Zeichenfläche:
        Rectangle canvasSize;
        int canvasMaxX;
        //für die Figurgöße:
        int size;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            //Anwendung beenden
            Close();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //Grundeinstellung:
            radioButton_Quadrat.Checked = true;
            radioButton_AnimationNo.Checked = true;
            trackBar_Size.Value = 2;

            //Das panel_Canvas als Zeichenfläche übergeben:
            canvas = panel_Canvas.CreateGraphics();
            //die Größe ermitteln:
            canvasSize = panel_Canvas.ClientRectangle;
            //Maximaler X-Wert
            canvasMaxX = canvasSize.Right;
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            //Grundeinstellung wiederherstellen:
            radioButton_Quadrat.Checked = true;
            radioButton_AnimationNo.Checked = true;
            trackBar_Size.Value = 2;
            //Canvas leeren:
            canvas.Clear(Color.White);
        }

        private void button_Draw_Click(object sender, EventArgs e)
        {

            //Figurgöße ermitteln:
            switch (trackBar_Size.Value)
            {
                case 1:
                    size = 125;
                    break;
                case 2:
                    size = 100;
                    break;
                case 3:
                    size = 75;
                    break;
            }
            if (radioButton_Quadrat.Checked)
            {
                if (radioButton_AnimationNo.Checked)
                {
                    ZeichneQuadrat(size);
                }
                else
                {
                    MessageBox.Show("Die Rechteck-Animation fehlt leider noch.","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (radioButton_Kreis.Checked)
            {
                if (radioButton_AnimationNo.Checked)
                {
                    ZeichneKreis(size);
                }
                else
                {
                    MessageBox.Show("Die Kreis-Animation fehlt leider noch.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
        void ZeichneQuadrat(int value)
        {
            Pen myPen = new Pen(Color.Black, 2);
            canvas.DrawRectangle(myPen, canvasSize.Left + value, canvasSize.Top + value, canvasSize.Width - (value * 2), canvasSize.Bottom - (value * 2));
        }
        void ZeichneKreis(int value)
        {
            Pen myPen = new Pen(Color.Black, 2);
            canvas.DrawEllipse(myPen, canvasSize.Left + value, canvasSize.Top + value, canvasSize.Width - (value * 2), canvasSize.Bottom - (value * 2));
        }
    }
}
