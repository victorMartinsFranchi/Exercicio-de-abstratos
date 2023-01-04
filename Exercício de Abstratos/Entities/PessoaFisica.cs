using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_de_Abstratos.Entities
{
    class PessoaFisica : Contribuinte
    {
        public double GastoDeSaude { get; set; }

        public PessoaFisica()
        {
        }

        public PessoaFisica(string nome, double rendaAnual, double gastoDeSaude)
            : base(nome, rendaAnual)
        {
            GastoDeSaude = gastoDeSaude;
        }

        public override double Imposto()
        {
            if (RendaAnual < 20000)
            {
                return RendaAnual * 0.15 - GastoDeSaude * 0.5;
            }
            else
            {
                return RendaAnual * 0.25 - GastoDeSaude * 0.5;
            }
        }
    }
}
