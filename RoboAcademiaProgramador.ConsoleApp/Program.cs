using System;

namespace RoboAcademiaProgramador.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool resp;
            do
            {
                double x, y;

                Console.Write("Digite a coordenada x do canto superior da área: ");
                x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a coordenada y do canto superior da área: ");
                y = Convert.ToDouble(Console.ReadLine());

                char graus;
                string comando;
                double x2 = 0;
                double y2 = 0;


                Console.WriteLine("Digite as cordenadas do valor X inicial: ");
                x2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite as cordenadas do valor Y inicial: ");
                y2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a direção inicial do robô (N - Norte | S- Sul | L - Leste | O - Oeste): ");
                graus = Convert.ToChar(Console.ReadLine());

                Console.Write("Digite as isntruções do robô (M - Mover | E - Girar para a esquerda | D - Girar para a direita): ");
                comando = Convert.ToString(Console.ReadLine());

                char[] instrucoes = comando.ToCharArray();

                for (int i = 0; i < instrucoes.Length; i++)
                {
                    while (instrucoes[i] == 'E')
                    {
                        switch (graus)
                        {
                            case 'N':
                                graus = 'O';
                                break;
                            case 'S':
                                graus = 'L';
                                break;
                            case 'L':
                                graus = 'N';
                                break;
                            case 'O':
                                graus = 'S';
                                break;
                            default:
                                Console.WriteLine("Opção Invalida para o Robo! ");
                                break;
                        }
                        break;
                    }
                    while (instrucoes[i] == 'D')
                    {
                        switch (graus)
                        {
                            case 'N':
                                graus = 'L';
                                break;
                            case 'S':
                                graus = 'O';
                                break;
                            case 'L':
                                graus = 'S';
                                break;
                            case 'O':
                                graus = 'N';
                                break;
                            default:
                                Console.WriteLine("Opção Invalida para o Robo! ");
                                break;
                        }
                        break;
                    }

                    while (instrucoes[i] == 'M')
                    {
                        if (graus == 'N')
                        {
                            y2 = y2 + 1;
                            break;

                        }
                        else
                        {
                            if (graus == 'L')
                            {
                                x2 = x2 + 1;
                                break;
                            }
                            else
                            {
                                if (graus == 'S')
                                {
                                    y2 = y2 - 1;
                                    break;
                                }
                                else
                                {
                                    if (graus == 'O')
                                    {
                                        x2 = x2 - 1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }


                Console.WriteLine(x2 + " " + y2 + " " + graus);

                Console.Write("Fazer o processo novamente ? ( para continuar digite - S ) ");
                char retornar = Convert.ToChar(Console.ReadLine());

                resp = retornar == 'S';

                //consegui apenas fazer a primeira parte sozinho a parte do switch o Pedro Nunes me ajudou muito

            } while (resp == true);
        }
    }
}
