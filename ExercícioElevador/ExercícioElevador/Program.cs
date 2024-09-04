using ExercícioElevador.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ExercícioElevador
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator Elevador1 = new Elevator();

            int quit = 0;

            Console.WriteLine("Qual a capacidade máxima de pessoas no elevador?");
            Elevador1.Capacidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos andares existem?");
            Elevador1.TotalAndar = int.Parse(Console.ReadLine());


            Console.WriteLine("Iniciando Elevador...");
            // Define o tempo total de carregamento em segundos

            int totalTimeInSeconds = 3;
            // Define o intervalo de atualização da barra em milissegundos

            int updateIntervalInMilliseconds = 100; // Atualiza a cada 100 ms

            // Calcula o número total de atualizações
            int totalUpdates = totalTimeInSeconds * 1000 / updateIntervalInMilliseconds;

            for (int i = 0; i <= totalUpdates; i++)
            {
                // Calcula a porcentagem concluída
                double progress = (i / (double)totalUpdates) * 100;

                // Cria a barra de carregamento
                string progressBar = new string('#', i * 50 / totalUpdates) + new string('-', 50 - i * 50 / totalUpdates);

                // Move o cursor para o início da linha
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write($"[{progressBar}] {progress:0.00}%");

                // Aguarda o próximo intervalo de atualização
                Thread.Sleep(updateIntervalInMilliseconds);
            }
            // Adiciona uma nova linha após a barra de carregamento

            Console.WriteLine();
            Console.WriteLine("Carregamento concluído!");
            int n_case;
            Console.Clear();
            while (quit != 5)
            {
                Console.WriteLine($"|1 - Entrar\n|2 - Sair\n|3 - Subir\n|4 - Descer\n|5 - Fechar Menu");
                n_case = int.Parse(Console.ReadLine());
                quit = n_case;
                if (n_case > 0 && n_case <= 5)
                {
                    switch (n_case)
                    {
                        case 1:
                            Console.Write(Elevador1.Entrar());

                            break;
                        case 2:
                            Console.Write(Elevador1.Sair());

                            break;
                        case 3:
                            if (Elevador1.Valor == Elevador1.TotalAndar)
                            {
                                Console.WriteLine("Você já está no último andar.");
                            }
                            else
                            {
                                Console.WriteLine("Deseja subir para qual andar?");
                                Elevador1.Valor = int.Parse(Console.ReadLine());
                                Console.Write(Elevador1.Subir());
                            }
                            break;
                        case 4:
                            if (Elevador1.Valor == 0)
                            {
                                Console.WriteLine("Você já está no térreo.");
                            }
                            else
                            {
                                Console.WriteLine("Deseja descer para qual andar?");
                                Elevador1.Valor = int.Parse(Console.ReadLine());
                                Console.Write(Elevador1.Descer());
                            }
                            break;

                    }
                    Console.WriteLine("Aperte uma tecla para continuar...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Não há essa opção, selecione novamente!");
                    Console.WriteLine("Aperte uma tecla para continuar...");
                    Console.ReadKey();
                }
                Console.Clear();
            }
            Console.WriteLine("Encerrando Elevador...");
            // Define o tempo total de carregamento em segundos

            totalTimeInSeconds = 3;
            // Define o intervalo de atualização da barra em milissegundos

            updateIntervalInMilliseconds = 100; // Atualiza a cada 100 ms

            // Calcula o número total de atualizações
            totalUpdates = totalTimeInSeconds * 1000 / updateIntervalInMilliseconds;

            for (int i = 0; i <= totalUpdates; i++)
            {
                // Calcula a porcentagem concluída
                double progress = (i / (double)totalUpdates) * 100;

                // Cria a barra de carregamento
                string progressBar = new string('#', i * 50 / totalUpdates) + new string('-', 50 - i * 50 / totalUpdates);

                // Move o cursor para o início da linha
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write($"[{progressBar}] {progress:0.00}%");

                // Aguarda o próximo intervalo de atualização
                Thread.Sleep(updateIntervalInMilliseconds);
            }
            // Adiciona uma nova linha após a barra de carregamento

            Console.WriteLine();
            Console.WriteLine("Encerrado com Sucesso!");
            Console.ReadKey();

        }
    }
}
