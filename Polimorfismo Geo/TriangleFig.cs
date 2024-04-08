using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Geo
{
    internal class TriangleFig
    {
        public class Triangulo : FiguraGeometrica
        {
            private double baseTriangulo;
            private double altura;

            public Triangulo(double baseTriangulo, double altura)
            {
                this.baseTriangulo = baseTriangulo;
                this.altura = altura;
            }

            public override double CalcularArea()
            {
                return (baseTriangulo * altura) / 2;
            }

            public override double CalcularDiametro()
            {
               
                return baseTriangulo + altura + Math.Sqrt((baseTriangulo * baseTriangulo) + (altura * altura));
            }
        }



    }
}
