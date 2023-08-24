using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AHoraDoPitch
{
    public class Alarm
    {
		public Alarm() 
		{ 
			this.Tempo = 3; // três minutos
			this.EfeitoSonoro = 200;
		}

        public Alarm(int tempo)
        {
            this.Tempo = tempo;
            
        }

        public Alarm(int tempo, int efeitoSonoro)
		{
			this.Tempo = tempo;
			this.EfeitoSonoro  = efeitoSonoro;
		}

		//controla o tempo do pitch
		private int tempo;

		public int Tempo
		{
			get { return this.tempo; }
			set { this.tempo = 1000 * 60 * value; }
		}

		public int EfeitoSonoro
		{
			get;
			set;
		}


		public void StartAlarm()
		{
			Thread.Sleep(this.Tempo);
			Console.Beep(this.EfeitoSonoro,1000);
		}

	}
}
