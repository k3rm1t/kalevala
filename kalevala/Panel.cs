using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Kalevala fishing game. 
/// Teemu did this
/// 13.3.2017
/// </summary>
namespace kalevala
{
    class Panel
    {
        public int ID { get; set; } // is this needed?
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsFish { get; set; }

        public Panel(int id, int x, int y)
        {

        }
    }
    
}
