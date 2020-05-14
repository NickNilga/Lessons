namespace Lab04.Garage
{
	public class Wheel
	{
		private readonly string _model;
		private readonly int _radius;
		private readonly int _width;


		public Wheel(string model, int radius, int width)
		{
			_model = model;
			_radius = radius;
			_width = width;
		}

		public override string ToString()
		{
			return $"Model {_model}; R={_radius}''; W={_width}mm";
		}
	}
}