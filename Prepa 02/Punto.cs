using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_02
{
    class Punto
    {
        private float x;
        private float y;
        public Punto()
        {

        }
        public Punto(float _x, float _y)
        {
            x = _x;
            y = _y;
        }

        public void SetX(float _x)
        {
            x = _x;
        }
        public void SetY(float _y)
        {
            y = _y;
        }
        public float GetX()
        {
            return x;
        }
        public float GetY()
        {
            return y;
        }

        ~Punto()
        {
            Console.WriteLine($"\nMe estoy destruyendo ({x},{y})");
            //Console.ReadLine();
        }
    }
}
