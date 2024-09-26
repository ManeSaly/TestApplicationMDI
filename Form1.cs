using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApplicationMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enfant oEnfant = new Enfant();  
            oEnfant.MdiParent = this; // oEnfant, son parent est this(formulaire)
            oEnfant.Show(); // Non modale

            // oEnfant.ShowDialog(); Ne marche pas
        }
    }
}
