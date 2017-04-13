using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace kalevala
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page
    {
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Here Player names come to GamePage
            if (e.Parameter is Player)
            {
                Player player = (Player)e.Parameter;
                Playername1.Text = player.Name1;
                Playername2.Text = player.Name2;
                
            }
            else
            {
                //How can i get something here...
                Playername1.Text= "Unknown";
                Playername2.Text = "tuntematon";
            }
            base.OnNavigatedTo(e);
        }
        int count = 0;
        private int ClickCounter()
        {
            
            count++;
            Debug.WriteLine(count);
            if (count == 30)
            {
                Debug.WriteLine("END GAME");
            }
            return count;
        }
        private void InitializeComponents()
        {
            
        }
        public GamePage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
        
        // kokeillaan saako tällä jotain aikaan napin painamisen suhteen
        /*private void waterbuttonUnchecked(object sender,RoutedEventArgs e)
        {
            SetImage("/Assets/water.png");
        }
        private void waterbuttonChecked(object sender, RoutedEventArgs e)
        {
            SetImage("/Assets/ahven");
        }
        */

        private void WaterButton_Click(object sender, RoutedEventArgs e)
        {
            
            // painettu kuva
            Image image = sender as Image;
            BitmapImage BitmapImage = new BitmapImage();
            //image.Source = new BitmapImage(new Uri("ms-appx:///Assets/ahven.png"));

            Debug.WriteLine("testi");
            //if(clickedWaterButton != null)
           // {
                Random random = new Random();
                int rand = random.Next(0, 100);
                if (rand < 49)
                {
                if (rand < 49 && rand > 40) { Debug.WriteLine("nuuskamuikkunen"); }
                else if (rand > 29 && rand < 39) { Debug.WriteLine("haisuli"); }
                else { image.Source = new BitmapImage(new Uri("ms-appx:///Assets/ahven.png"));  }// laita naihin tapahtumaan oikeita asioita
                }
                else {
                image.Source = new BitmapImage(new Uri("ms-appx:///Assets/wave.png"));
                        Debug.WriteLine("ei kalaa"); }
            //}

            int counter = ClickCounter();
        }

        private void EndGame_Click(object sender, RoutedEventArgs e)
        {
            Frame RootFrame = Window.Current.Content as Frame;
            if (RootFrame == null) return;
            if (RootFrame.CanGoBack)
            {
                RootFrame.GoBack();
            }
        }
    }
}
