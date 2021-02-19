using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // int - numeros inteiros
            // float - numeros decimais
            // bool - boolean 0/1 false/true
            // string - "texto comum entre asplas duplas"
            // char - 'c' one character

            // outros tipos de declaração: var - declara sem tipo
            var corFavorita = "vermelho"; //identifica automaticamente
            var valor = 3;
            dynamic cor = "azul"; // pode mudar o tipo da variavel usando dynamic
            cor = 12.1f; // dynamic alterado pra float

            const float PI = 3.14654165f; //const - declarar constante, valor que nao pode ser alterado.

            string corFav = "verde";
            int numFav = 60;
            float velFav = 182.3f;
            bool aconteceuSim = true;
            char unica = 'c';

            Console.WriteLine("A cor que vc escolheu foi: " + corFav);
            Console.WriteLine("Seu numero é: " + numFav +" "+ unica + " "+aconteceuSim );
            Console.WriteLine("Sua velocidade é: " + velFav);

            velFav = 200.21f;
            Console.WriteLine(velFav);

            Console.WriteLine("Escreva seu nome: ");
            string nome = Console.ReadLine(); // receber/capturar dados do usuário.
            Console.WriteLine("seu nome é: " + nome);




            Console.ReadLine();
        }
    }
}
