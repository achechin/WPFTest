using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Classes
{
    class CalcRectangle
    {
        public float height;
        public float width;

        public CalcRectangle() 
        {
            height = 10.0f;
            width = 33.23f;
        }
        public float Area(float height,float width)
        {
            return height * width;
        }

        public float Perimeter(float height, float width)
        {
            return 2*(height +width);
        }
    }
}
