using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contas contas = new Contas();
            Console.Write("Opções:\n[ 1 ] Depositar\n[ 2 ] Sacar\nescolha: ");
            int escolha = int.Parse(Console.ReadLine());

            while (escolha < 1 || escolha > 2)
            {
                Console.WriteLine("Valor Invalido!");
                Console.Write("Opções:\n[ 1 ] Depositar\n[ 2 ] Sacar\n[ 3 ] Valor na conta\nescolha: ");
                escolha = int.Parse(Console.ReadLine());
            }

            if (escolha == 1) 
            {
                Console.Write("Valor do deposito: ");
                decimal depositar = decimal.Parse(Console.ReadLine());
                contas.Depositar(depositar);
                
            }
            if (escolha == 2) 
            {
                Console.Write("Valor do saque: ");
                decimal sacar = decimal.Parse(Console.ReadLine());
                contas.Sacar(sacar);

            }
            Console.ReadKey();
        }
    }
}
