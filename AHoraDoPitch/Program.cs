using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHoraDoPitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alarm alarme = new Alarm();
            String resposta = "S";

            while(resposta != "N")
            {
                Console.WriteLine("A Hora do Pitch");
                Console.Write("Informe a duração do Pitch.: ");
                int tempo = Convert.ToInt32(Console.ReadLine());

                alarme.Tempo = tempo;
                alarme.StartAlarm();

                Console.WriteLine("Executar o programa novamente (S/N).: ");
                resposta = Console.ReadLine().ToUpper();
            }

            
        }
    }
}
