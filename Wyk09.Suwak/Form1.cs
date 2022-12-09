using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyk09.Suwak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.DoubleBuffered= true;
            InitializeComponent();
        }

        private void ChangeColor(Panel panel)
        {
            panel.BackColor = Color.FromArgb(trackBar4.Value,
                trackBar1.Value,
                trackBar2.Value,
                trackBar3.Value);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ChangeColor(panel1);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == '\u001b')
            //{
            //    Application.Exit();
            //}
        }

        private void IncrementTrackBarValue(TrackBar trackBar)
        {
            trackBar.Value += trackBar.Value < trackBar.Maximum ? 1 : 0;
        }       
        
        private void DecrementTrackBarValue(TrackBar trackBar)
        {
            trackBar.Value -= trackBar.Value > trackBar.Minimum ? 1 : 0;
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            
            switch(e.KeyCode)
            {
                case Keys.R: IncrementTrackBarValue(trackBar1); break; 
                case Keys.G: IncrementTrackBarValue(trackBar2); break; 
                case Keys.B: IncrementTrackBarValue(trackBar3); break; 
                case Keys.E: DecrementTrackBarValue(trackBar1); break; 
                case Keys.F: DecrementTrackBarValue(trackBar2); break; 
                case Keys.V: DecrementTrackBarValue(trackBar3); break;
                
            }

            ChangeColor(panel1);
        }
    }
}
