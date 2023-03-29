using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("======MENU======");
            Console.WriteLine("1 - exercicio 1 ");
            Console.WriteLine("2 - exercicio 2 ");
            Console.WriteLine("3 - exercicio 3 ");
            Console.WriteLine("4 - exercicio 4 ");
            Console.WriteLine("5 - exercicio 5 ");
            Console.WriteLine("6 - exercicio 6 ");

            numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    int dia;
                    Console.WriteLine("digite um numero para saber o dia da semana a partir de segunda");
                    dia = int.Parse(Console.ReadLine());
                    switch (dia)
                    {
                        case 1:
                            Console.WriteLine("é seguinda feira ");
                            break;
                        case 2:
                            Console.WriteLine("é terca feira ");
                            break;
                        case 3:
                            Console.WriteLine("é quarta feira ");
                            break;
                        case 4:
                            Console.WriteLine("é quinta feira ");
                            break;
                        case 5:
                            Console.WriteLine("é sexta feira ");
                            break;
                        case 6:
                            Console.WriteLine("é sabado ");
                            break;
                        case 7:
                            Console.WriteLine("é domingo ");
                            break;
                        default:
                            Console.WriteLine("não existe dia da semana representado por este numero");
                            break;
                    }

                    break;
                case 2:
                    double valor, res, fp, ress;
                    Console.WriteLine("qual o valor");
                    valor = double.Parse(Console.ReadLine());
                    Console.WriteLine("qual a forma de pagamento? 1- PIX 2-dinheiro 3- debito 4-credito");
                    fp = double.Parse(Console.ReadLine());
                    switch (fp)
                    {
                        case 1:
                            res = valor * 0.10;
                            ress = valor - res;

                            Console.WriteLine("o valor do desconto sera de: " + res + " e o valor final sera de: " + ress);
                            break;
                        case 2:
                            res = valor * 0.15;
                            ress = valor - res;

                            Console.WriteLine("o valor do desconto sera de: " + res + " e o valor final sera de: " + ress);
                            break;
                        case 3:
                            res = valor * 0.05;
                            ress = valor + res;

                            Console.WriteLine("o valor do desconto sera de: " + res + " e o valor final sera de: " + ress);
                            break;
                        case 4:
                            res = valor * 0.10;
                            ress = valor + res;

                            Console.WriteLine("o valor do desconto sera de: " + res + " e o valor final sera de: " + ress);
                            break;

                        default:
                            Console.WriteLine(" nao possue esta opção");
                            break;
                    }

                    break;

                case 3:
                    int ano, fev;
                    Console.WriteLine("entre com o numero do mes de 1 a 12");
                    ano = int.Parse(Console.ReadLine());

                    switch (ano)
                    {
                        case 1:
                            Console.WriteLine(" 1- JANEIRO: 31 dias ");
                            break;
                        case 2:
                            Console.WriteLine(" 2- FEVEREIRO: ==== INFORME O ANO=== ");
                            Console.WriteLine("informe o ano: ");
                            fev = int.Parse(Console.ReadLine());

                            if ((fev % 4 == 0 && fev % 100 != 0) || (fev % 400 == 0))
                            {
                                Console.WriteLine(fev + " 28 dias");
                            }
                            else
                            {
                                Console.WriteLine(fev + " 29 dias");
                            }
                            break;
                        case 3:
                            Console.WriteLine(" 3- MARÇO: 31 DIAS ");
                            break;
                        case 4:
                            Console.WriteLine(" 3- ABRIL: 30 dias ");
                            break;
                        case 5:
                            Console.WriteLine(" 5- MAIO: 31 dias ");
                            break;
                        case 6:
                            Console.WriteLine(" 6- JUNHO: 30 dias ");
                            break;
                        case 7:
                            Console.WriteLine(" 7- JULHO: 30 dias ");
                            break;
                        case 8:
                            Console.WriteLine(" 8- AGOSTO: 31 dias ");
                            break;
                        case 9:
                            Console.WriteLine(" 9- SETEMBRO: 30 dias ");
                            break;
                        case 10:
                            Console.WriteLine(" 10- OUTUBROO: 31 dias ");
                            break;
                        case 11:
                            Console.WriteLine(" 11-NOVEMBRO: 30 dias ");
                            break;
                        case 12:
                            Console.WriteLine(" 12- DEZEMBRO: 31 dias ");
                            break;
                    }
                    break;
                        case 4:
                            int num1, num2, resul;
                            char op;
                            Console.WriteLine("qual o primeiro numero?");
                            num1=int.Parse(Console.ReadLine());
                            Console.WriteLine("qual o segundo numero?");
                            num2=int.Parse(Console.ReadLine());
                            Console.Write("Digite o operador (+, -, *, / ou ^): ");
                            op= char.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case '+':
                            resul = num1 + num2;
                            Console.WriteLine("o resultado sera: "+resul);
                            break;
                        case '-':
                            resul = num1 - num2;
                            Console.WriteLine("o resultado sera: " + resul);
                            break;
                        case '*':
                            resul = num1 * num2;
                            Console.WriteLine("o resultado sera: " + resul);
                            break;
                        case '/':
                            resul = num1 / num2;
                            Console.WriteLine("o resultado sera: " + resul);
                            break;
                       
                        default:
                            Console.WriteLine("operador invalido");
                            return;
                    }
                    break;
                    case 5:
                    double sal, x, aumento, diferenca,xr;
                    Console.WriteLine("digite o salario: ");
                    sal = double.Parse(Console.ReadLine());
                    Console.WriteLine("digite o codigo do cargo do funcionario: ");
                    x = double.Parse(Console.ReadLine());

                    switch(x)
                    {
                        case 101:
                            aumento = 0.075*sal;
                            xr = aumento + sal;
                            
                            Console.WriteLine("o salario antigo era de "+sal+" com o ajuste ficou "+xr+" a diferença é de "+aumento);
                            break;
                        case 102:
                            aumento = 0.097*sal;
                            xr = aumento + sal;

                            Console.WriteLine("o salario antigo era de " + sal + " com o ajuste ficou " + xr + " a diferença é de " + aumento);
                            break;
                        case 103:
                            aumento = 0.117*sal;
                            xr = aumento + sal;

                            Console.WriteLine("o salario antigo era de " + sal + " com o ajuste ficou " + xr + " a diferença é de " + aumento);
                            break;
                        case 204:
                            aumento = 0.089*sal;
                            xr = aumento + sal;

                            Console.WriteLine("o salario antigo era de " + sal + " com o ajuste ficou " + xr + " a diferença é de " + aumento);
                            break;
                        case 206:
                            aumento = 0.1324*sal;
                            xr = aumento + sal;

                            Console.WriteLine("o salario antigo era de " + sal + " com o ajuste ficou " + xr + " a diferença é de " + aumento);
                            break;
                        case 301:
                            aumento = 0.104*sal;
                            xr = aumento + sal;

                            Console.WriteLine("o salario antigo era de " + sal + " com o ajuste ficou " + xr + " a diferença é de " + aumento);
                            break;
                        case 302:
                            aumento = 0.146 * sal;
                            xr = aumento + sal;

                            Console.WriteLine("o salario antigo era de " + sal + " com o ajuste ficou " + xr + " a diferença é de " + aumento);
                            break;
                        default:
                            Console.WriteLine("codigo nao encontrado");
                            break;

                    }
                    break;
                case 6:
                    double sala, resultado, imp, imp2;
                    Console.WriteLine("Imposto de Renda dos cidadãos brasileiros");
                    Console.WriteLine("1- Até R$ 1.903,98");
                    Console.WriteLine("2- Entre R$ 1.903,99 e R$ 2.826,65");
                    Console.WriteLine("3- Entre R$ 2.826,66 e R$ 3.751,05");
                    Console.WriteLine("4- Entre R$ 3.751,06 e R$ 4.664,68");
                    Console.WriteLine("5- Acima de R$ 4.664,68");
                    Console.WriteLine("escolha a opcao que se encaixa na sua situaçãao: ");
                    sala=double.Parse(Console.ReadLine());

                    switch (sala)
                    {
                        case 1:
                            Console.WriteLine("seu salario sera o mesmo sem impostos");
                            break;
                        case 2: 
                            Console.WriteLine("qual o seu salario?");
                            imp=double.Parse(Console.ReadLine());

                            resultado = imp * 0.075f;
                            imp2 = imp - resultado;

                            Console.WriteLine("seu salario menos os impostos sera de: "+imp2+" o valor total de imposto sera de: "+resultado);
                            break;
                        case 3:
                            Console.WriteLine("qual o seu salario?");
                            imp = double.Parse(Console.ReadLine());

                            resultado = imp * 0.15f;
                            imp2 = imp - resultado;

                            Console.WriteLine("seu salario menos os impostos sera de: " + imp2 + " o valor total de imposto sera de: " + resultado);
                            break;
                        case 4:
                            Console.WriteLine("qual o seu salario?");
                            imp = double.Parse(Console.ReadLine());

                            resultado = imp * 0.225f;
                            imp2 = imp - resultado;

                            Console.WriteLine("seu salario menos os impostos sera de: " + imp2 + " o valor total de imposto sera de: " + resultado);
                            break;
                        case 5:
                            Console.WriteLine("qual o seu salario?");
                            imp = double.Parse(Console.ReadLine());

                            resultado = imp * 0.275f;
                            imp2 = imp - resultado;

                            Console.WriteLine("seu salario menos os impostos sera de: " + imp2 + " o valor total de imposto sera de: " + resultado);
                            break;


                    }
                    break;


                default:
                    Console.WriteLine("opção invalida");
                    break;
            }
            Console.ReadKey();

        }
    }
}