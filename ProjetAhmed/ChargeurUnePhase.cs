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
    // Cette classe représente le formulaire pour un chargeur monophasé
    public partial class ChargeurUnePhase : Form
    {
    
        public ChargeurUnePhase()
        {
            InitializeComponent();
        }

     
        private void ChargeurUnePhase_Load(object sender, EventArgs e)
        {
          
        }

        // Méthode pour calculer la puissance électrique en fonction de la tension et de la résistance
        public double CalculerPuissance(double tension, double resistance)
        {
            // Vérifie si la résistance est nulle pour éviter la division par zéro
            if (resistance == 0)
            {
                throw new ArgumentException("La résistance ne peut pas être nulle.");
            }

            // Calcul de l'intensité du courant à partir de la tension et de la résistance (loi d'Ohm)
            double courant = tension / resistance;

            // Calcul de la puissance électrique (P = U * I)
            double puissance = tension * courant;

            return puissance;
        }

        // Gestionnaire d'événements pour le clic sur le bouton de test
        private void Test_Click(object sender, EventArgs e)
        {
            // Récupération des valeurs de tension et de résistance à partir des champs de texte
            string tensionS = InputTest1.Text;
            string resistanceS = InputTest2.Text;

            // Conversion des valeurs de texte en doubles
            double tension = int.Parse(tensionS);
            double resistance = int.Parse(resistanceS);

            // Calcul de la puissance en utilisant la méthode CalculerPuissance
            double puissance = CalculerPuissance(tension, resistance);

            // Affichage du résultat dans le champ de sortie
            OutputTest1.Text = puissance.ToString() + " puissance";
        }

      
        private void InputTest1_TextChanged(object sender, EventArgs e)
        {
 
        }
    }
}
