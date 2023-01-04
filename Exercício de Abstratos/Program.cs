using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercício_de_Abstratos.Entities;

namespace Exercício_de_Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o numero de contribuintes: ");
            int numeroDeContribuintes = int.Parse(Console.ReadLine());

            List<Contribuinte> list = new List<Contribuinte>();

            for (int i = 1; i <= numeroDeContribuintes; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Contribuinte #" + i + " Informações:");
                Console.WriteLine("Pessoa Física(1) ou jurídica(2)?");
                Console.Write("Resposta: ");
                int tipoDeContribuinte = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda Anual: ");
                double rendaAnual = double.Parse(Console.ReadLine());
                if (tipoDeContribuinte == 1)
                {
                    Console.Write("Gasto com Saúde: ");
                    double gastoDeSaude = double.Parse(Console.ReadLine());
                    list.Add(new PessoaFisica(nome, rendaAnual, gastoDeSaude));
                }
                else if (tipoDeContribuinte == 2)
                {
                    Console.Write("Quantidade de Funcionários: ");
                    int qntFuncionarios = int.Parse(Console.ReadLine());

                    list.Add(new PessoaJuridica(nome, rendaAnual, qntFuncionarios));
                }
            }
            Console.WriteLine();
            double impostoTotal = 0;
            Console.WriteLine("Tabela de Impostos:");
            foreach (Contribuinte x in list)
            {
                Console.WriteLine(x.Nome + ": $ " + x.Imposto().ToString("F2"));
                impostoTotal += x.Imposto();
            }
            Console.WriteLine("Imposto Total: $ " + impostoTotal.ToString("F2"));
            Console.ReadLine();
        }
    }
}
