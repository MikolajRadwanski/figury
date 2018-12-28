using System;

namespace csharp
{
	class Prostokat : Figura
	{
        private double a;
        private double b;

        public Prostokat(double a, double b) {
            this.a = a;
            this.b = b;
        }

		public override double powierzchnia()
		{
			return this.a * this.b;
		}
	}
}
