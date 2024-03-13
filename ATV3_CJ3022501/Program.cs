using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace ATV3_CJ3022501
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCÍCIO 1
            int num;

            Console.WriteLine("Insira um número: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("O número inserido {0} é par.", num);
            }
            else
            {
                Console.WriteLine("O número inserido {0} é ímpar.", num);
            }
            //EXERCÍCIO 2
            Console.WriteLine();
            float lado1, lado2, lado3;

            Console.WriteLine("Insera os comprimentos dos três lados do triângulo: ");

            Console.WriteLine("Lado 1: ");
            lado1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Lado 2: ");
            lado2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Lado 3: ");
            lado3 = float.Parse(Console.ReadLine());

            if (lado1 + lado2 > lado3 && lado2 + lado3 > lado1 && lado1 + lado3 > lado2)
            {
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("O triângulo é equilátero.");
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("O triângulo é isósceles.");
                }
                else
                {
                    Console.WriteLine("O triângulo é escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Não é possível formar um triângulo com esses lados.");
            }

            Console.WriteLine();



            //EXERCÍCIO 3
            int numero, tentativa;

            Random gerador = new Random();
            numero = gerador.Next(1, 100);

            Console.WriteLine("Digite e tente adivinhar um número aleatório entre 1 a 100");
            tentativa = int.Parse(Console.ReadLine());

            if (numero == tentativa)
            {
                Console.WriteLine("parabéns, você acertou de primeira");
            }
            else
            {
                if (numero < tentativa)
                {
                    Console.WriteLine("O número é menor do que {0}", tentativa);
                }
                else
                {
                    Console.WriteLine("O número é maior do que {0}", tentativa);
                }
                Console.WriteLine("Digite e tente adivinhar um número aleatório entre 1 a 100");
                tentativa = int.Parse(Console.ReadLine());
                if (numero == tentativa)
                {
                    Console.WriteLine("Acertou de segunda!");
                }
                else
                {
                    if (numero < tentativa)
                    {
                        Console.WriteLine("O número é menor do que {0}", tentativa);
                    }
                    else
                    {
                        Console.WriteLine("O número é maior do que {0}", tentativa);
                    }
                    Console.WriteLine("Digite e tente adivinhar um número aleatório entre 1 a 100");
                    tentativa = int.Parse(Console.ReadLine());
                    if (numero == tentativa)
                    {
                        Console.WriteLine("Acertou de terceira!");
                    }
                    else
                    {
                        Console.WriteLine("suas tentativas acabaram");
                        Console.WriteLine("O número era {0}",numero);
                    }
                }




            }






            //EXERCÍCIO 4
            String nome, senha;

            Console.WriteLine("Insira o seu nome para o nosso sistema de autenticação: ");
            nome = Console.ReadLine();
            Console.WriteLine("Agora, crie uma senha: ");
            senha = Console.ReadLine();



            if (nome == "admin" && senha == "admin123")
            {
                Console.WriteLine("O seu acesso ao nosso sistema foi concedido!");
            }
            else
            {
                Console.WriteLine("O seu acesso ao nosso sistema foi negado!");
            }
            //EXERCÍCIO 5
            Console.WriteLine();
            float nota;
            string conceito;

            Console.WriteLine("Insira uma nota de 0 a 100: ");
            nota = float.Parse(Console.ReadLine());

            if (nota > 100 || nota < 0)
            {
                Console.WriteLine("Nota inválida");
            }
            else 
            {
            if (nota >= 90)
            {
                conceito = "A";
            }
            else if (nota >= 80)
            {
                conceito = "B";
            }
            else if (nota >= 70)
            {
                conceito = "C";
            }
            else if (nota >= 60)
            {
                conceito = "D";
            }
            else
            {
                conceito = "F";
            }
            Console.WriteLine("A nota {0} corresponde ao conceito {1}", nota, conceito);
            }
                //EXERCÍCIO 6
            Console.WriteLine();

            int jogador, computador;
            Random geretor = new Random();
            Console.WriteLine("escolha entre 1-papel, 2-tesoura ou 3-pedra");
            jogador = int.Parse(Console.ReadLine());
            computador = geretor.Next(1, 3);

            if (jogador == computador)
            {
                Console.WriteLine("Deu empate, o computador escolheu{0}",computador);
            }
            else
            {
                if (jogador == 1 && computador == 2)
                {
                    Console.WriteLine("Você perdeu, o computador escolheu{0}",computador);
                }
                else if (jogador == 1 && computador == 3)
                {
                    Console.WriteLine("Você ganhou, o computador escolheu{0}",computador);

                }
                else if (jogador == 2 && computador == 3)
                {
                    Console.WriteLine("Voce perdeu, o computador escolheu{0}",computador);
                }
                else if (jogador == 2 && computador == 1)
                {
                    Console.WriteLine("Voce ganhou, o computador escolheu{0}",computador);
                }
                else if (jogador == 3 && computador == 1)
                {
                    Console.WriteLine("Voce perdeu, o computador escolheu{0}",computador);
                }
                else if (jogador == 3 && computador == 2)
                {
                    Console.WriteLine("Voce ganhou, o computador escolheù{0}",computador);
                }
                Console.WriteLine();


                //EXERCÍCIO 7
                Console.WriteLine();
                float valorTotal, desconto = 0;

                Console.WriteLine("Insira o valor total da compra: ");
                valorTotal = float.Parse(Console.ReadLine());


                if (valorTotal > 100 && valorTotal <= 200)
                {
                    desconto = 0.1f;
                }
                else if (valorTotal > 200 && valorTotal <= 300)
                {
                    desconto = 0.2f;
                }
                else if (valorTotal > 300 && valorTotal <= 400)
                {
                    desconto = 0.3f;
                }
                else if (valorTotal > 400)
                {
                    desconto = 0.4f;
                }

                float valorComDesconto = valorTotal - (valorTotal * desconto);

                Console.WriteLine("O valor total da compra é: R$ {0}", valorTotal);
                Console.WriteLine("O desconto aplicado é: {0}%", desconto * 100);
                Console.WriteLine("O valor final com desconto é: R$ {0}", valorComDesconto);

                //EXERCÍCIO 8
                float peso1, altura, IMC;
                string categoria;

                Console.WriteLine("Insira seu peso (em kg): ");
                peso1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Insira sua altura (em metros): ");
                altura = float.Parse(Console.ReadLine());

                IMC = peso1 / (altura * altura);

                if (IMC < 18.5)
                {
                    categoria = "abaixo do peso";
                }
                else if (IMC >= 18.5f && IMC <= 24.9f)
                {
                    categoria = "peso normal";
                }
                else if (IMC >= 25 && IMC <= 29.9f)
                {
                    categoria = "sobrepeso";
                }
                else if (IMC >= 30 && IMC <= 34.9f)
                {
                    categoria = "obesidade grau I";
                }
                else if (IMC >= 35 && IMC <= 39.9f)
                {
                    categoria = "obesidade grau II";
                }
                else
                {
                    categoria = "obesidade grau III";
                }
                Console.WriteLine("A categoria na qual você se encaixa é {0}", categoria);
            }
        }
    }
}
