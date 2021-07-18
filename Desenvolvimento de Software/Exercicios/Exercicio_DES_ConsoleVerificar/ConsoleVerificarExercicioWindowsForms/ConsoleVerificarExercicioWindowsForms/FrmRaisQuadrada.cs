using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleVerificarExercicio;

namespace ConsoleVerificarExercicioWindowsForms
{
    public partial class FrmRaisQuadrada : Form
    {
        ClassDados ca = new ClassDados();
        public FrmRaisQuadrada()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ca.X = double.Parse(txtNumero.Text);
            ca.Calcular();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtNumero.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
