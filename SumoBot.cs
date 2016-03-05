using System.Threading;
using System.Threading.Tasks;
using MonoBrickFirmware.Display;
using MonoBrickFirmware.Movement;
using MonoBrickFirmware.Sensors;
using MonoBrickFirmware.UserInput;

namespace Sumo
{
	public class SumoBot : BotBase
	{
		IRChannel[] channels = {IRChannel.One, IRChannel.Two, IRChannel.Three, IRChannel.Four};

		int channelIdx = 0;

		EV3IRSensor irSensor = new EV3IRSensor(SensorPort.In4);
		//			ManualResetEvent terminateProgram = new ManualResetEvent(false);
		//			var touchSensor = new EV3TouchSensor (SensorPort.In1);
		//			ButtonEvents bts = new ButtonEvents ();
		//			InfoDialog dialog = new InfoDialog ("Start?");
		//			dialog.Show ();//Wait for enter to be pressed

		//			Motor rightMotor = new Motor (MotorPort.OutB);
		//			Motor leftMotor = new Motor (MotorPort.OutC);

//		Vehicle vehicle = new Vehicle (MotorPort.OutC, MotorPort.OutA);

		public SumoBot() : base(0, 10)
		{
		}

		protected override void UpdateRobot ()
		{
			


			// Everything is backwards...

			//			WaitHandle waitHandle;

			channelIdx = (channelIdx+1)%channels.Length;
			irSensor.Channel = channels[channelIdx];

			LcdConsole.WriteLine("Channel is set to: " + channels[channelIdx]);

			LcdConsole.WriteLine("Distance " + irSensor.ReadDistance() +  " cm");

//			LcdConsole.WriteLine("Remote command " + irSensor.ReadRemoteCommand() + " on channel " + irSensor.Channel);									
//
//			BeaconLocation location  = irSensor.ReadBeaconLocation();
//			LcdConsole.WriteLine("Beacon location: " + location.Location + " Beacon distance: " + location.Distance + " cm"); 
//

		


//			LcdConsole.WriteLine(irSensor.ReadAsString());
		}

		protected override void StartRobot ()
		{
		}

		protected override void StopRobot ()
		{
		}

	}
}

