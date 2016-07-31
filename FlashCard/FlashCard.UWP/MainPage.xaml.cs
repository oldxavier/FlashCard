using FlashCard.UWP.Models;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FlashCard.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public Card CurrentCard { get; set; }
        public CardCollection CurrentCollection { get; set; }

        public MainPage()
        {
            this.InitializeComponent();

            this.CurrentCard = new Card("Magyarország", "Budapest");

            this.CurrentCollection = new CardCollection("Kepler-törvények");
            CurrentCollection.Cards.Add(new Card(
                "Kepler első törvénye", 
                "A bolygók pályája ellipszis, és annak egyik gyújtópontjában van a Nap."));
            CurrentCollection.Cards.Add(new Card(
                 "Kepler második törvénye",
                  "A bolygók vezérsugara (a bolygót a Nappal összekötő szakasz) azonos idő alatt azonos területet súrol."));
            CurrentCollection.Cards.Add(new Card(
                "Kepler harmadik törvénye",
                "A bolygók Naptól való átlagos távolságainak (a, a pálya fél nagytengelyeinek) köbei úgy aránylanak egymáshoz, mint a keringési idejük (T) négyzetei."));


        }
    }
}
