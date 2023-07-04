using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        modelo.Calculadora calc = new modelo.Calculadora();
        bool EstadoIgual = false;


        private void bt0_Click(object sender, EventArgs e)
        {
            testarIgual(sender, e);
            calc.setDigito(bt0.Text);
            lblVisor.Text = calc.Visor;
        }

        private void testarIgual(object sender, EventArgs e)
        {
            if (EstadoIgual)
            {
                btCE_Click(sender, e);
                EstadoIgual = false;
            }
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            testarIgual(sender, e);
            calc.setDigito(bt1.Text);
            lblVisor.Text = calc.Visor;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            testarIgual(sender, e);
            calc.setDigito(bt2.Text);
            lblVisor.Text = calc.Visor;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            testarIgual(sender, e);
            calc.setDigito(bt3.Text);
            lblVisor.Text = calc.Visor;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            testarIgual(sender, e);
            calc.setDigito(bt4.Text);
            lblVisor.Text = calc.Visor;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            testarIgual(sender, e);
            calc.setDigito(bt5.Text);
            lblVisor.Text = calc.Visor;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            testarIgual(sender, e);
            calc.setDigito(bt6.Text);
            lblVisor.Text = calc.Visor;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            testarIgual(sender, e);
            calc.setDigito(bt7.Text);
            lblVisor.Text = calc.Visor;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            testarIgual(sender, e);
            calc.setDigito(bt8.Text);
            lblVisor.Text = calc.Visor;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            testarIgual(sender, e);
            calc.setDigito(bt9.Text);
            lblVisor.Text = calc.Visor;
        }

        private void btC_Click(object sender, EventArgs e)
        {
            calc.Visor = "0";
            lblVisor.Text = calc.Visor;
        }

        private void btCE_Click(object sender, EventArgs e)
        {
            calc = new modelo.Calculadora();
            lblVisor.Text = calc.Visor;
        }

        private void btBackspace_Click(object sender, EventArgs e)
        {
            calc.backspace();
            lblVisor.Text = calc.Visor;
        }

        private void btPontoDecimal_Click(object sender, EventArgs e)
        {
            calc.pontoDecimal();
            lblVisor.Text = calc.Visor;
        }

        private void btInverterSinal_Click(object sender, EventArgs e)
        {
            calc.inverterSinal();
            lblVisor.Text = calc.Visor;
        }

        private void btSomar_Click(object sender, EventArgs e)
        {
            calc.Op = btSomar.Text;
        }

        private void btSubtrair_Click(object sender, EventArgs e)
        {
            calc.Op = btSubtrair.Text;
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            calc.Op ="x";
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            calc.Op = "/";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            EstadoIgual = true;
            calc.calcular();
            lblVisor.Text = calc.Visor;
        }

        private void btRaiz_Click(object sender, EventArgs e)
        {
            calc.Raiz();            
            lblVisor.Text = calc.Visor;
            EstadoIgual = true;
        }

        private void btSeno_Click(object sender, EventArgs e)
        {
            calc.seno();
            lblVisor.Text = calc.Visor;
            EstadoIgual = true;
        }

        private void btCosseno_Click(object sender, EventArgs e)
        {
            calc.cosseno();
            lblVisor.Text = calc.Visor;
            EstadoIgual = true;
        }

        private void btTangente_Click(object sender, EventArgs e)
        {
            calc.tangente();
            lblVisor.Text = calc.Visor;
            EstadoIgual = true;
        }

        private void btFracao_Click(object sender, EventArgs e)
        {
            calc.fracao();
            lblVisor.Text = calc.Visor;
            EstadoIgual = true;
        }

        private void btPorcentagem_Click(object sender, EventArgs e)
        {
            calc.porcentagem();
            lblVisor.Text = calc.Visor;
            EstadoIgual = true;
        }

        private void btPotencia_Click(object sender, EventArgs e)
        {
            calc.Op = btPotencia.Text;
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void FormCalculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;

            if (Char.IsDigit(tecla))
            {
                testarIgual(sender, e);
                calc.setDigito(tecla.ToString());
                lblVisor.Text = calc.Visor;
            }

            if (tecla == '+') btSomar_Click(sender, e);
            if (tecla == '-') btSubtrair_Click(sender, e);
            if (tecla == '*') btMultiplicar_Click(sender, e);
            if (tecla == '/') btDividir_Click(sender, e);
        }

        private void FormCalculadora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete  || e.KeyCode == Keys.Back)
            {
                btBackspace_Click(sender, e);
            }
            if (e.KeyCode == Keys.Oemplus)
            {
                btnCalcular_Click(sender, e);
            }
        }

        private void mnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
      
    }
}
