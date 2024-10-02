using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    internal class Contas
    {
        private decimal _total;
        

        public Contas()
        {
            _total = 100;
        }

        public decimal Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
            }
        }

        public void ExibirTotalConta()
        {
            Console.Write("Você deseja ver o total da sua conta? (s/n): ");
            char valorConta = char.Parse(Console.ReadLine());
            while (valorConta != 's' && valorConta != 'n')
            {
                Console.WriteLine("Valor Invalido!");
                Console.Write("Você deseja ver o total da sua conta? (s/n): ");
                valorConta = char.Parse(Console.ReadLine());
            }
            if (valorConta == 's')
            {
                Console.WriteLine($"Você tem {_total}R$ na sua conta");
            }
            else
            {
                Console.WriteLine("caixa fechado");
            }
        }

        public decimal Depositar(decimal deposito)
        {
            if (deposito <= 0)
            {
                Console.WriteLine("Deposito menor ou igual a zero não é permitido!!");
                Console.Write("Gostaria de depositar outro valor? (s/n): ");
                char escolha = char.Parse(Console.ReadLine());
                while (escolha != 's' && escolha != 'n')
                {
                    Console.WriteLine("Valor Invalido!!");
                    Console.Write("Gostaria de depositar outro valor? (s/n): ");
                    escolha = char.Parse(Console.ReadLine());
                }
                if (escolha == 's')
                {
                    Console.Write("Valor do deposito: ");
                    decimal novoDeposito = decimal.Parse(Console.ReadLine());
                    Total += novoDeposito;
                    Console.WriteLine($"Você depositou {novoDeposito}R$ na sua conta.");

                }
                else
                {
                    
                    Console.WriteLine("caixa fechado");
                }
            }
            else
            {
                Total += deposito;
                Console.WriteLine($"Você depositou {deposito}R$ na sua conta.");
     
            }
            ExibirTotalConta();
            return _total;
        }

        public decimal Sacar(decimal saque)
        {
            if(_total >= saque)
            {
                Total  -= saque;
                Console.WriteLine($"Você fez um saque de {saque}R$ ");
               
            }
            else
            {
                Console.WriteLine("Você não tem todo o dinheiro na sua conta para esse saque!");
                Console.Write("Deseja tentar novamente outro saque? (s/n): ");
                char OutroSaque = char.Parse(Console.ReadLine());
                while(OutroSaque != 's'&&  OutroSaque != 'n')
                {
                    Console.WriteLine("Valor Invalido!");
                    Console.Write("Deseja tentar novamente outro saque? (s/n): ");
                    OutroSaque = char.Parse(Console.ReadLine());
                }
                if (OutroSaque == 's')
                {
                    Console.Write("Valor do saque: ");
                    decimal saqueNovo = decimal.Parse(Console.ReadLine());
                    return Sacar(saqueNovo);
                }
                else
                {
                    OutroSaque = 'n';
                    Console.WriteLine("caixa fechado");
                }
            }
            ExibirTotalConta();
            return _total;
        }
        
    }
}
