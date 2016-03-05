
using System;
using MonoBrickFirmware;
using MonoBrickFirmware.Display.Dialogs;
using MonoBrickFirmware.Display;
using MonoBrickFirmware.Movement;
using System.Threading;
using MonoBrickFirmware.UserInput;
using System.Threading.Tasks;

namespace Sumo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var terminateProgram = new ManualResetEvent(false);
			var sumoBot = new SumoBot();
			var bts = new ButtonEvents();

			bts.EscapePressed += () => terminateProgram.Set();

			Task.Factory.StartNew(sumoBot.Run);

			terminateProgram.WaitOne();
			sumoBot.Stop();
		}
	}
}

