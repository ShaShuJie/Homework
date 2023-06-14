using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public partial class Utility
    {   
        public struct ForPos
        {
            public string ProductName { get; set; }//get讀值 ;set存入
            public int ProductUnitPrice { get; set; }
        }

        public struct Score
        {
            public string Name { get; set; }//get讀值 ;set存入
            public double CHScore { get; set; }
            public double ENScore { get; set; }
            public double MEScore { get; set; }
        }
    }
}

