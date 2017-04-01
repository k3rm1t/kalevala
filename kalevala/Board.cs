using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
/// <summary>
/// This is Board. Here it is programmed
/// Teemu Joutulainen alias k3rm1t
/// K2600 
/// 16/3/17
/// </summary>
namespace kalevala
{
    class Board:Panel
    {
        Panel Clicked = null;
        Random rand = new Random();
        List<string> pictures = new List<string>()
        {
            "/Assets/ahven.png",
            "/Assets/vainamoinen.png",
            "/Assets/wave.png"
        };
        /*
        private void AssingFishToGamePage()
        {
            foreach(Control button in GamePage.Controls)
            {
                Panel iconPanel = control as Panel;
                if (iconPanel != null)
                {
                    int randomNumber = rand.Next(iconButton.Count);
                    iconPanel.image = pictures[randomPicture];
                    pictures.RemoveAt(RandomNumber);
                }
            }
        }*/
    }
}
