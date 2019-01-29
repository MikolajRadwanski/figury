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
		public Prostokat() {
            this.a = 233.5;
            this.b = 77.99;
        }

		public override double powierzchnia()
		{
			return this.a * this.b;
		}
	}
}
