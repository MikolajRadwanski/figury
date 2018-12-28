using System;

namespace csharp
{
	class Trojkat : Figura
	{

        private double a;
        private double h;

        public Trojkat(double a, double h) {
           this.a = a;
           this.h = h;
        }
		public override double powierzchnia()
		{
			return (this.a * this.h) / 2;
		}
	}
}
