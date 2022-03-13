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
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            //Grundeinstellung wiederherstellen:
            radioButton_Quadrat.Checked = true;
            radioButton_AnimationNo.Checked = true;
            trackBar_Size.Value = 2;
            //Canvas leeren:
            //canvas.clear
        }
    }
}
