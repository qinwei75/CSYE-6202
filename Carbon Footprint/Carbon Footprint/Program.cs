using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbon_Footprint
{
    class Program
    {
        public enum Type
        {
            None,
            Bicycle,
            Car,
            Building
        }
        public static Type TypeMapper(char c)
        {
            Type type = Type.None;

            // your implementation here
            switch (c)
            {
                default:
                    type = Type.None;
                    break;
                case 'B':
                case 'b':
                    type = Type.Bicycle;
                    break;
                case 'C':
                case 'c':
                    type = Type.Car;
                    break;
                case 'L':
                case 'l':
                    type = Type.Building;
                    break;
            }
            return type;
        }

        public static double OutputMapper(Type type)
        {
            var result = 0.0;
            // your implementation here
            switch (type)
            {
                //case Type.None:
                //   result = 0.0;
                //    break;
                case Type.Bicycle:
                    result = 0.0;
                    break;
                case Type.Car:
                    result = 20;
                    break;
                case Type.Building:
                    result = 50;
                    break;
            }
            return result;
        }
        static void Main(string[] args)
        {

        }
    }
}
