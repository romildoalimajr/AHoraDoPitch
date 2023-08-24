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
                Console.Clear();
                Console.WriteLine("A Hora do Pitch");
                Console.Write("Informe a duração do Pitch.: ");
                int tempo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe o efeito sonoro de 1 até 500.: ");
                int efeitoSonoro = Convert.ToInt32(Console.ReadLine());
                alarme.EfeitoSonoro = efeitoSonoro;

                alarme.Tempo = tempo;
                alarme.StartAlarm();
                Console.WriteLine("Que pena! O seu tempo acabou!");
                Console.WriteLine("Executar o programa novamente (S/N).: ");
                resposta = Console.ReadLine().ToUpper();
            }

            
        }
    }
}
