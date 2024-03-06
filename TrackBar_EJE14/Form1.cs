using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackBar_EJE14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar_Tamaño_Scroll(object sender, EventArgs e)
        {
            lbl_Texto.Font = new System.Drawing.Font(lbl_Texto.Font.FontFamily, trackBar_Tamaño.Value);
            lbl_Valor.Text = trackBar_Tamaño.Value.ToString(); 

        }
    }
}
