using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo6
{
    public partial class frmAffiche : Form
    {
        private GroupBox grpStagiaire;
        private TextBox textBox6;
        private TextBox textBox4;
        private Label lblAdresse;
        private Label lblVille;
        private TextBox textBox7;
        private Label lblCP;
        private TextBox textBox5;
        private Label label1;
        private TextBox textBox2;
        private Label lblPrenom;
        private TextBox textBox1;
        private Label lblOSia;
        private Button btnDernier;
        private Button btnSuivant;
        private Button btnPrecedent;
        private Button btnPremeier;
        private Button btnAjouter;
        private Button btnQuitter;
        private GroupBox grpSeDeplacer;

        public frmAffiche()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.grpStagiaire = new System.Windows.Forms.GroupBox();
            this.grpSeDeplacer = new System.Windows.Forms.GroupBox();
            this.lblOSia = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnPremeier = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.grpStagiaire.SuspendLayout();
            this.grpSeDeplacer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStagiaire
            // 
            this.grpStagiaire.Controls.Add(this.textBox6);
            this.grpStagiaire.Controls.Add(this.textBox4);
            this.grpStagiaire.Controls.Add(this.lblAdresse);
            this.grpStagiaire.Controls.Add(this.lblVille);
            this.grpStagiaire.Controls.Add(this.textBox7);
            this.grpStagiaire.Controls.Add(this.lblCP);
            this.grpStagiaire.Controls.Add(this.textBox5);
            this.grpStagiaire.Controls.Add(this.label1);
            this.grpStagiaire.Controls.Add(this.textBox2);
            this.grpStagiaire.Controls.Add(this.lblPrenom);
            this.grpStagiaire.Controls.Add(this.textBox1);
            this.grpStagiaire.Controls.Add(this.lblOSia);
            this.grpStagiaire.Location = new System.Drawing.Point(12, 12);
            this.grpStagiaire.Name = "grpStagiaire";
            this.grpStagiaire.Size = new System.Drawing.Size(709, 205);
            this.grpStagiaire.TabIndex = 0;
            this.grpStagiaire.TabStop = false;
            this.grpStagiaire.Text = "Stagiaire";
            // 
            // grpSeDeplacer
            // 
            this.grpSeDeplacer.Controls.Add(this.btnDernier);
            this.grpSeDeplacer.Controls.Add(this.btnSuivant);
            this.grpSeDeplacer.Controls.Add(this.btnPrecedent);
            this.grpSeDeplacer.Controls.Add(this.btnPremeier);
            this.grpSeDeplacer.Location = new System.Drawing.Point(175, 245);
            this.grpSeDeplacer.Name = "grpSeDeplacer";
            this.grpSeDeplacer.Size = new System.Drawing.Size(546, 62);
            this.grpSeDeplacer.TabIndex = 1;
            this.grpSeDeplacer.TabStop = false;
            this.grpSeDeplacer.Text = "Se Deplacer";
            // 
            // lblOSia
            // 
            this.lblOSia.AutoSize = true;
            this.lblOSia.Location = new System.Drawing.Point(7, 22);
            this.lblOSia.Name = "lblOSia";
            this.lblOSia.Size = new System.Drawing.Size(60, 17);
            this.lblOSia.TabIndex = 0;
            this.lblOSia.Text = "N° OSIA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(521, 22);
            this.textBox2.TabIndex = 3;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(7, 78);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(57, 17);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(149, 132);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(521, 22);
            this.textBox4.TabIndex = 7;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(7, 135);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(34, 17);
            this.lblVille.TabIndex = 6;
            this.lblVille.Text = "Ville";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(149, 47);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(521, 22);
            this.textBox5.TabIndex = 3;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(7, 107);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(60, 17);
            this.lblAdresse.TabIndex = 6;
            this.lblAdresse.Text = "Adresse";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(149, 104);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(521, 22);
            this.textBox6.TabIndex = 7;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(7, 163);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(84, 17);
            this.lblCP.TabIndex = 4;
            this.lblCP.Text = "Code Postal";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(149, 160);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(118, 22);
            this.textBox7.TabIndex = 5;
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(238, 21);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(103, 23);
            this.btnSuivant.TabIndex = 2;
            this.btnSuivant.Text = ">Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(347, 21);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(103, 23);
            this.btnDernier.TabIndex = 3;
            this.btnDernier.Text = ">>Dernier";
            this.btnDernier.UseVisualStyleBackColor = true;
            // 
            // btnPremeier
            // 
            this.btnPremeier.Location = new System.Drawing.Point(20, 21);
            this.btnPremeier.Name = "btnPremeier";
            this.btnPremeier.Size = new System.Drawing.Size(103, 23);
            this.btnPremeier.TabIndex = 0;
            this.btnPremeier.Text = "<<Premier";
            this.btnPremeier.UseVisualStyleBackColor = true;
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(129, 22);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(103, 23);
            this.btnPrecedent.TabIndex = 1;
            this.btnPrecedent.Text = "<Precedent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(456, 331);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(550, 331);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // frmAffiche
            // 
            this.ClientSize = new System.Drawing.Size(733, 369);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.grpSeDeplacer);
            this.Controls.Add(this.grpStagiaire);
            this.Name = "frmAffiche";
            this.Text = "Affiche Stagiaire";
            this.grpStagiaire.ResumeLayout(false);
            this.grpStagiaire.PerformLayout();
            this.grpSeDeplacer.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
