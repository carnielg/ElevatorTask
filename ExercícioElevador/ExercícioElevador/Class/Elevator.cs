using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioElevador.Class
{
    class Elevator
    {

        public int Capacidade { get; set; }
        public int Andar { get; set; }
        public int TotalAndar { get; set; }
        public int Pessoas { get; set; }


        public Elevator()
        {
            Andar = 0;
            Pessoas = 0;
        }

        public void Incializar(int totalandares, int capacidade)
        {
            this.Capacidade = capacidade;
            this.TotalAndar = totalandares;
      
        }
        public string Entrar()
        {
            if (Pessoas >= Capacidade)
            {
                return
                    "A capacidade do elevador foi excedida!\n";
            }
            else
            {
                Pessoas++;
            }
            return
                $"Há {Pessoas} pessoas no elevador.\n";

        }
        public string Sair()
        {
            if (Pessoas <= 0)
            {
                return
                    "Não há pessoas no elevador.\n";
            }
            else
            {
                Pessoas--;
                return
                  $"Há {Pessoas} pessoas no elevador.\n";
            }

        }
        public int Valor { get; set; }
        public string Subir()//int valor determina o andar que a pessoa quer ir
        {
            if (Valor > TotalAndar)
            {
                return
                    $"Só é possível subir até o andar {Valor}.\n";
            }
            else
            {
                if (Andar >= TotalAndar)
                {
                    return
                        $"O elevador está no último andar.\n";
                }
                else
                {
                    if (Valor > Andar)
                    {
                        Andar = Valor;
                        return
                            $"Você está no andar {Andar}\n";
                    }
                    else
                    {
                        return
                        "Só é possível subir.\n";
                    }
                }
            }
        }
        public string Descer()
        {
            if (Valor < 0)
            {
                return
                    "Só é possível ir até o andar 0\n";
            }
            else 
            {
                if (Andar <= 0)
                {
                    return
                        $"O elevador está no térreo.\n";
                }
                else
                {
                    if (Valor < Andar)
                    {
                        Andar = Valor;
                        return
                            $"Você está no andar {Andar}\n";
                    }
                    else
                    {
                        return
                        "Só é possível descer.\n";
                    }
                }
            }
        }


    }
}
