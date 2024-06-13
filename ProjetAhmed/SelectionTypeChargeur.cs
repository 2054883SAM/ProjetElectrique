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
    }
}
