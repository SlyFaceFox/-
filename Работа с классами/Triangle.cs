using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работа_с_классами
{
    internal class Triangle
    {
        public Triangle(double angle, double rand)
        {
            Angle1 = angle;
            Angle2 = 180 - angle - rand;
            Angle3 = 180 - angle - (180 - angle - rand);

        }

        public double Angle1 { get; set; }                          
        public double Angle2 { get; set; }
        public double Angle3 { get; set; }

        public override string ToString()
        {
            return "(" +Angle1 + "+" + Angle2 + "+" + Angle3+ ")";
        }
    }
    



}
