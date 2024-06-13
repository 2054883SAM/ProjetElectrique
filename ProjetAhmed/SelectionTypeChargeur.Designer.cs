
namespace ProjetAhmed
{
    partial class SelectionTypeChargeur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_chargeurUnePhase = new System.Windows.Forms.Button();
            this.btn_chargeur2Phase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quel est le type de chargeur?";
            // 
            // btn_chargeurUnePhase
            // 
            this.btn_chargeurUnePhase.Location = new System.Drawing.Point(153, 134);
            this.btn_chargeurUnePhase.Name = "btn_chargeurUnePhase";
            this.btn_chargeurUnePhase.Size = new System.Drawing.Size(185, 44);
            this.btn_chargeurUnePhase.TabIndex = 1;
            this.btn_chargeurUnePhase.Text = "Chargeur à une phase";
            this.btn_chargeurUnePhase.UseVisualStyleBackColor = true;
            this.btn_chargeurUnePhase.Click += new System.EventHandler(this.btn_chargeurUnePhase_Click);
            // 
            // btn_chargeur2Phase
            // 
            this.btn_chargeur2Phase.Location = new System.Drawing.Point(153, 203);
            this.btn_chargeur2Phase.Name = "btn_chargeur2Phase";
            this.btn_chargeur2Phase.Size = new System.Drawing.Size(185, 38);
            this.btn_chargeur2Phase.TabIndex = 2;
            this.btn_chargeur2Phase.Text = "Chargeur à deux phase";
            this.btn_chargeur2Phase.UseVisualStyleBackColor = true;
            // 
            // SelectionTypeChargeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 375);
            this.Controls.Add(this.btn_chargeur2Phase);
            this.Controls.Add(this.btn_chargeurUnePhase);
            this.Controls.Add(this.label1);
            this.Name = "SelectionTypeChargeur";
            this.Text = "SelectionTypeChargeur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_chargeurUnePhase;
        private System.Windows.Forms.Button btn_chargeur2Phase;
    }
}