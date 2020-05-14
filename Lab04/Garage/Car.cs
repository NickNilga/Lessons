namespace Lab04.Garage
{
	public class Car:Vehicle
	{
		private readonly Wheel[] _wheels;
		private Radio _radio;

		public Car(
			string model,
			string make,
			Engine engine,
			string wheelModel,
			int wheelRadius,
			int wheelWidth)
			:base(make, model, engine)
			
		{
			_wheels = new Wheel[4];

			for (int i = 0; i < 4; i++)
			{
				_wheels[i] = new Wheel(wheelModel, wheelRadius, wheelWidth);
			}
		}

		public override string ToString()
		{
			string result = $"Car: {_make} model{_model}\n" +
			                $"Engine: {_engine}\n" +
			                $"Wheels: {_wheels[0]}\n";

			string radioString = "Radio: " + (_radio == null ? "none" : _radio.ToString());
			result += radioString;

			return result;
		}

		public void SetRadio(Radio radio)
		{
			_radio = radio;
		}

		public void RemoveRadio()
		{
			_radio = null;
		}
	}
}