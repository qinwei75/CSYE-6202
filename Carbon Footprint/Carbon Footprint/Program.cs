using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbon_Footprint
{
    class Program
    {
        public enum ItemType
        {
            None,
            Bicycle,
            Car,
            Building
        }
        public static ItemType TypeMapper(char c)
        {
            ItemType type = ItemType.None;

            // your implementation here
            switch (c)
            {
                default:
                    type = ItemType.None;
                    break;
                case 'B':
                case 'b':
                    type = ItemType.Bicycle;
                    break;
                case 'C':
                case 'c':
                    type = ItemType.Car;
                    break;
                case 'L':
                case 'l':
                    type = ItemType.Building;
                    break;
            }
            return type;
        }

        public static double OutputMapper(ItemType type)
        {
            var result = 0.0;
            // your implementation here
            switch (type)
            {
                //case Type.None:
                //   result = 0.0;
                //    break;
                case ItemType.Bicycle:
                    result = 0.0;
                    break;
                case ItemType.Car:
                    result = 20;
                    break;
                case ItemType.Building:
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
