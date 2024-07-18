using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass04.Interfaces
{
    internal interface IShape
    {
        public int Area { get; set; }
        void DisplayShapeInfo();
    }
}
