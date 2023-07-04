using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCalculadora.modelo
{
    class Calculadora
    {
        public string Visor { get; set; }

        private string op;
        public string Op
        {
            get { return op; }
            set
            {
                aux1 = Double.Parse(Visor);
                aux2 = 0;
                Visor = "0";
                op = value;
            }
        }

        private double aux1;
        private double aux2;

        public Calculadora()
        {
            Visor = "0";
            aux1 = 0;
            aux2 = 0;
            op ="";
        }

        public void setDigito(string digito)
        {
            if (Visor.Equals("0")) Visor = digito;
            else Visor += digito;
        }


        public void backspace()
        {
            Visor = Visor.Substring(0, Visor.Length - 1);
            if (Visor.Equals("")) Visor = "0";
        }

        public void pontoDecimal()
        {
            if (!Visor.Contains(",")) Visor += ",";
        }

        public void inverterSinal()
        {
            double num = Double.Parse(Visor) * -1;
            Visor = num.ToString();
        }

        public void calcular()
        {
            if (aux2 == 0) aux2 = Double.Parse(Visor);

            if (Op.Equals("+")) aux1 = aux1 + aux2;
            if (Op.Equals("-")) aux1 = aux1 - aux2;
            if (Op.Equals("x")) aux1 = aux1 * aux2;
            if (Op.Equals("/")) aux1 = aux1 / aux2;

            if (Op.Equals("x^y")) aux1 = Math.Pow(aux1,aux2);

            Visor = aux1.ToString();

        }

        public void Raiz()
        {
            Visor = Math.Sqrt(Double.Parse(Visor)).ToString("N5");
        }

        public void seno()
        {
            double rad = Math.PI * Double.Parse(Visor) / 180;
            Visor = Math.Sin(rad).ToString();
        }
        public void cosseno()
        {
            double rad = Math.PI * Double.Parse(Visor) / 180;
            Visor = Math.Cos(rad).ToString();
        }
        public void tangente()
        {
            double rad = Math.PI * Double.Parse(Visor) / 180;
            Visor = Math.Tan(rad).ToString();
        }

        public void fracao()
        {
            Visor = (1 / Double.Parse(Visor)).ToString();
        }

        public void porcentagem()
        {
            Visor = (aux1 * Double.Parse(Visor) / 100).ToString();
        }
      
    }
}
