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
		}

		public Alarm(int tempo)
		{
			this.Tempo = tempo;
		}

		//controla o tempo do pitch
		private int tempo;

		public int Tempo
		{
			get { return this.tempo; }
			set { this.tempo = 1000 * 60 * value; }
		}

		public void StartAlarm()
		{
			Thread.Sleep(this.Tempo);
			Console.Beep(250,1000);
		}

	}
}
