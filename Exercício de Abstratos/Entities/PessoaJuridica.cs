using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_de_Abstratos.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int QntFuncionarios { get; set; }

        public PessoaJuridica()
        {
        }

        public PessoaJuridica(string nome, double rendaAnual, int qntFuncionarios) 
            : base(nome, rendaAnual)
        {
            QntFuncionarios = qntFuncionarios;
        }

        public override double Imposto()
        {
            if (QntFuncionarios < 11)
            {
                return RendaAnual * 0.16;
            }
            else
            {
                return RendaAnual * 0.14;
            }
        }
    }
}
