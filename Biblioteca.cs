using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etapa5Aula1
{
    public abstract class Veiculo
    {

        private string _tipoCombustivel;

        public Veiculo()
        {

        }


        public Veiculo(string tipoCombustivel)
        {
            _tipoCombustivel = tipoCombustivel;
        }

        public abstract void Mover();

        public virtual void Abastecer()
        {
            Console.WriteLine("Abastecimento padrão");
        }

    }

    internal class Carro: Veiculo
    {

    public Carro(string tipoCombustivel):base(tipoCombustivel)
        {

        }
        public override void Mover()
        {
            Console.WriteLine("Ir para trás e ir para frente....");
        }

        public override void Abastecer()
        {
            Console.WriteLine("Carro Elétrico");
        }
    }

    internal class Aviao: Veiculo
    {
        public Aviao(string tipoCombustivel) : base(tipoCombustivel)
        {

        }
        public override void Mover()
        {
            Console.WriteLine("Avião só vai pra frente....");
        }
    }
}
