using CardsGame_G2.GameEngine;
using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CardsGame_G2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Game game = new Game();

        public MainPage()
        {
            this.InitializeComponent();
            DisplayCards();
        }
        private void DisplayCards()
        {
            Card1.DisplayCard(game.PlayerCards[0]);
            Card2.DisplayCard(game.PlayerCards[1]);
            Card3.DisplayCard(game.PlayerCards[2]);
 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            game.Shuflle();
            DisplayCards();
        }


       

        private void Card1_Loaded_1(object sender, RoutedEventArgs e)
        {
            PlayerCard.DisplayCard(game.PlayerCards[0]);
            Card1.DisplayCard(0);
            Card1.IsEnabled = false;
            Shuffle_Button.IsEnabled = false;
            game.SetPlayerCard(game.PlayerCards[0]);
            ComputerCard.DisplayCard(game.ComputerSelectedCard);
        }

        //private void PlayerCard_Loaded(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
