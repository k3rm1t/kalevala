﻿using System;
using System.Collections.Generic;
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
            if(clickedWaterButton != null) { }
            /* IsPlaying = false;
             Random rand = new Random();
             if (IsPlaying == false)
             {
                 WaterButton.Source = 
             }*/
           // waterbuttonUnchecked();
            //waterbuttonChecked();

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
