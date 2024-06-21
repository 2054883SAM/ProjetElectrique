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
    public partial class ChargeurUnePhase : Form
    {
        public ChargeurUnePhase()
        {
            InitializeComponent();
        }

        private void ChargeurUnePhase_Load(object sender, EventArgs e)
        {

        }

        private void Test_Click(object sender, EventArgs e)
        {
            string test1Text = InputTest1.Text;
            string test2Text = InputTest2.Text;

            int test1int = int.Parse(test1Text);
            int test2int = int.Parse(test2Text);

            int result = test1int * test2int;

            OutputTest1.Text = result.ToString();
        }
    }
}
