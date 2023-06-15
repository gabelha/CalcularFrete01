using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFrete.Controller
{
    internal class Frete
    {
        private decimal valor;
        private decimal frete;
        private string UF;
        private string TipoEntrega;
        public Frete() 
        {
            
        }

        public decimal Calcular(string uf, decimal valor)
        { 
            this.UF = uf;
            this.valor = valor;
            this.frete = 0;

            switch (uf)
            {
                case "SP":
                    this.frete = 0.06m;
                    break;
                case "RJ":
                    this.frete = 0.07m;
                    break;
                case "BA":
                    this.frete = 0.08m;
                break;
                case "MG":
                    this.frete = 0.06m;
                    break;
                case "PE":
                    this.frete = 0.06m;
                    break;
                case "PA":
                    this.frete = 0.06m;
                    break;
                case "RS":
                    this.frete = 0.06m;
                    break;

            }
            valor = frete * valor;

            return valor; 
        }


        public string LimparTela()
        {
            return "OK";
        }


    }
    
}
