using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass04.Interfaces
{
    internal class Circle : ICircle
    {
        public int Area { get; set ; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"hello from circle and area = {Area}");
        }
    }
}
