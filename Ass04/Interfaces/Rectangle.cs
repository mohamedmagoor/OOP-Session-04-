using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass04.Interfaces
{
    internal class Rectangle : IRectangle
    {
        public int Area { get ; set ; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"hello from rectangle and area = {Area}");
        }
    }
}
