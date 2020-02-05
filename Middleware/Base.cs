using System;

namespace Middleware
{
	public enum StatusCode
	{
		PASS,
		FAILED,
		FIRST_BENDED,
		SECOND_BENDED
	}
	public enum PhaseCode
	{
		A_PHASE,
		B_PHASE,
		C_PHASE,
		D_PHASE,
		E_PHASE,
		F_PHASE,
		G_PHASE
	}

	public struct SensorValue
	{
		public double Sensor1 { get; private set; }
		public double Sensor2 { get; private set; }

		public SensorValue(double sensor1, double sensor2)
		{
			Sensor1 = sensor1;
			Sensor2 = sensor2;
		}
	}

	public class SensorValueEventArgs : EventArgs
	{
		public StatusCode Status { get; private set; }
		public SensorValue Before { get; private set; }
		public SensorValue? After { get; private set; }
		public SensorValue? Delta { get; private set; }

		public SensorValueEventArgs(StatusCode status, SensorValue before, SensorValue? after, SensorValue? delta)
		{
			Status = status;
			Before = before;
			After = after;
			Delta = delta;
		}
	}
	public class RobotPhaseEventArgs : EventArgs
	{
		public PhaseCode Phase;

		public RobotPhaseEventArgs(PhaseCode phase)
		{
			Phase = phase;
		}
	}
}