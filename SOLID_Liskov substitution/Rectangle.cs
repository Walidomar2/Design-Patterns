using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Hight { get; set; }
        public Rectangle()
        {

        }
        public Rectangle(int width, int hight)
        {
            Width = width;
            Hight = hight;
        }
    }

    class Square : Rectangle
    {
        public override int Width { set { base.Width = value; base.Hight = value; } }
        public override int Hight { set { base.Width = value; base.Hight = value; } }
    }
}
