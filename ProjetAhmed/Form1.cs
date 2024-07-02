using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetAhmed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Chargeur(object sender, EventArgs e)
        {
            SelectionPhaseChargeur selectionPhaseChargeur = new SelectionPhaseChargeur();
            selectionPhaseChargeur.Show();
        }
    }
}
