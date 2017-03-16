using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// This is Board. Here it is programmed
/// Teemu Joutulainen alias k3rm1t
/// K2600 
/// 16/3/17
/// </summary>
namespace kalevala
{
    class Board
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int PointCounter { get; set; }
        public List<Panel> Panels { get; set; }
        public GameStatus Status { get; set; }
        public GameBoard(int width, int height, int fishes)
        {
            Width = width;
            Height = height;
            //PointCounter = points;
            Panels = new List<Panel>();
            int id = 1;
            for (int i=1; i<= height; i++)
            {
                for (int j = 1; j<=width; j++)
                {
                    Panels.Add(new Panel(id, j, i));
                    id++;
                }
            }
            Status = GameStatus.InProgress;
        }
        public enum GameStatus
        {
            InProgress,
            Failed,
            Completed
        }
        public void PlaceFishes(int x, int y, Random rand)
        {
           
            foreach (var fishCoord in GameBoard)
            {
                Panels.Single(panel => panel.X == 0);
            }
            
        }
    }
}
