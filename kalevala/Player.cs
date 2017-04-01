using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Player class
/// Takes 2 parameters Name1&Name2
/// 30.3.2017
/// Teemu 
/// </summary>
namespace kalevala
{
    class Player
    {
        
        
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        // constructor
        public Player() { }
        public Player(string name1, string name2)
        {
            Name1 = name1;
            Name2 = name2;
        }
        /*public override string ToString()
        {
            return Name1; //Name2
            //return base.ToString();
            
        }*/
    }
}
