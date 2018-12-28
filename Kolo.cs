using System;

namespace csharp
{
    class  Kolo : Figura {
        private double r;
        public Kolo(double r) {
            this.r = r;
        }
		public override double powierzchnia()
		{
			return Math.PI * (r * r);
		}
	}
}
