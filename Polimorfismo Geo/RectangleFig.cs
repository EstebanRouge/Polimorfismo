using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Geo
{
    internal class RectangleFig
    {
        public class Rectangulo : FiguraGeometrica
        {
            private double baseRectangulo;
            private double altura;

            public Rectangulo(double baseRectangulo, double altura)
            {
                this.baseRectangulo = baseRectangulo;
                this.altura = altura;
            }

            public override double CalcularArea()
            {
                return baseRectangulo * altura;
            }

            public override double CalcularDiametro()
            {
                return 2 * (baseRectangulo + altura);
            }
        }


    }
}
