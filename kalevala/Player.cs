using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Teemu Joutulainen did this...
/// 13.3.2017
/// This is Player class. 
/// </summary>
namespace kalevala
{
    class Player
    {
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        // constructor
        public Player(string name1,string name2)
        {
            Player1 = name1;
            Player2 = name2;
        }
    }
}
