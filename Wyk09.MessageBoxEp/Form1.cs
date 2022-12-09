using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyk09.MessageBoxEp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0;
                int b = 4 / a;
            }
            catch (Exception ex)
            {
                var result = MessageBox.Show($"Użytkowniku wykonałeś nieprawidłową akcję! Zawartość: {ex.Message}",
                    "UWAGA",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    //todo: if yes
                } else if (result == DialogResult.No)
                {
                    //todo: if no
                }
                else if (result == DialogResult.Cancel)
                {
                    //todo: if cancel
                }
                else
                {
                    //todo: others
                }
            }


        }
    }
}
