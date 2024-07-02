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
    public partial class SelectionTypeChargeur : Form
    {
        public SelectionTypeChargeur()
        {
            InitializeComponent();
        }

        private void btn_chargeurUnePhase_Click(object sender, EventArgs e)
        {
            ChargeurUnePhase chargeurUnePhase = new ChargeurUnePhase();
            chargeurUnePhase.Show();
        }

        private void btn_chargeurDeuxPhases_Click(object sender, EventArgs e)
        {
            ChargeurDeuxPhase chargeurDeuxPhase = new ChargeurDeuxPhase();
            chargeurDeuxPhase.Show();
        }

        private void btn_chargeurTroisPhases_Click(object sender, EventArgs e)
        {
            ChargeurTroisPhase chargeurTroisPhase = new ChargeurTroisPhase();
            chargeurTroisPhase.Show();
        }

        private void btn_chargeurQuatrePhases_Click(object sender, EventArgs e)
        {
            ChargeurQuatrePhase chargeurQuatrePhase = new ChargeurQuatrePhase();
            chargeurQuatrePhase.Show();
        }
    }
}
