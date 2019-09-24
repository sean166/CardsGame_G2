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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace CardsGame_G2
{
    public sealed partial class Card : UserControl
    {
        public Card()
        {
            this.InitializeComponent();
        }

        private void HideAllCards()
        {
            AD.Visibility = Visibility.Collapsed;
            Card2D.Visibility = Visibility.Collapsed;
            Card3D.Visibility = Visibility.Collapsed;
            Card4D.Visibility = Visibility.Collapsed;
            Card5D.Visibility = Visibility.Collapsed;
            Card6D.Visibility = Visibility.Collapsed;
            Card7D.Visibility = Visibility.Collapsed;
            Card8D.Visibility = Visibility.Collapsed;
            Card9D.Visibility = Visibility.Collapsed;
            Card10D.Visibility = Visibility.Collapsed;
            CardJD.Visibility = Visibility.Collapsed;
            CardQD.Visibility = Visibility.Collapsed;
            CardKD.Visibility = Visibility.Collapsed;

        }

        public void DisplayCard(int card)
        {
            HideAllCards();
            switch (card)
            {
                case 1:
                    AD.Visibility = Visibility.Visible;
                    break;
                case 2:
                    Card2D.Visibility = Visibility.Visible;
                    break;
                case 3:
                    Card3D.Visibility = Visibility.Visible;
                    break;
                case 4:
                    Card4D.Visibility = Visibility.Visible;
                    break;
                case 5:
                    Card5D.Visibility = Visibility.Visible;
                    break;
                case 6:
                    Card6D.Visibility = Visibility.Visible;
                    break;
                case 7:
                    Card7D.Visibility = Visibility.Visible;
                    break;
                case 8:
                    Card8D.Visibility = Visibility.Visible;
                    break;
                case 9:
                    Card9D.Visibility = Visibility.Visible;
                    break;
                case 10:
                    Card10D.Visibility = Visibility.Visible;
                    break;
                case 11:
                    CardJD.Visibility = Visibility.Visible;
                    break;
                case 12:
                    CardQD.Visibility = Visibility.Visible;
                    break;
                case 13:
                    CardKD.Visibility = Visibility.Visible;
                    break;

            }
        }

    }
}
