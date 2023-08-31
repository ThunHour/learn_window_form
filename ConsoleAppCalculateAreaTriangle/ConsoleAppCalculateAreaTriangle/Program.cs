using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalculateAreaTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaTriangle AreaTrian = new AreaTriangle(10,10,10);
            Console.WriteLine(AreaTrian.Area().ToString());
            Console.ReadKey();
        }
        public class AreaTriangle {
            private float _SideA;
            private float _SideB;
            private float _SideC;
            public AreaTriangle(float sideA,float sideB,float sideC)
            {
                _SideA = sideA;
                _SideB = sideB;
                _SideC = sideC;

            }
            public float getProportion()
            {
                return (_SideA + _SideB + _SideC)/2;
            }
            public float Area()
            {
                float temp_area = 0.0f;
                float p = getProportion();
                temp_area = (float)Math.Sqrt(p * (p-_SideA) * (p-_SideB) * (p-_SideC));
                return temp_area;
            }

        }

    }
}
