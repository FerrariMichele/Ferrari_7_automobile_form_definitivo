using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferrari_7_automobile
{
    public partial class Form1 : Form
    {
        Automobile auto = new Automobile();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFrena_Click(object sender, EventArgs e)
        {
            auto.Decelerare();
            UpdateUI();
        }
        private void buttonAccelera_Click(object sender, EventArgs e)
        {
            auto.Accelerare();
            UpdateUI();
        }
        private void buttonMarciaSu_Click(object sender, EventArgs e)
        {
            auto.AumentaMarcia();
            UpdateUI();
        }
        private void buttonMarciaGiu_Click(object sender, EventArgs e)
        {
            auto.DiminuisciMarcia();
            UpdateUI();
        }
        private void buttonOnOff_Click(object sender, EventArgs e)
        {
            auto.AccendiSpegniMotore();
            UpdateUI();
        }
        private void UpdateUI()
        {
            labelOnOff.Text = auto.MotoreAcceso ? "Acceso" : "Spento";
            labelVelocita.Text = auto.Velocita.ToString();
            labelGiriMin.Text = auto.GiriMotore.ToString();
            labelMarcia.Text = auto.Marcia.ToString();
        }
    }
}