using FlashCard.UWP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCard.UWP.ViewModels
{
    public class MainPageViewModel
    {
        public List<CardCollection> CardCollections { get; set; }

        public MainPageViewModel()
        {
            this.CardCollections = new List<CardCollection>();

            InitializeViewModel();
        }

        private void InitializeViewModel()
        {
            this.CardCollections.Add(
                new CardCollection("Kepler-törvények"));
            this.CardCollections[0].Cards.Add(
                new Card(
                    "Kepler első törvénye",
                    "A bolygók pályája ellipszis, és annak egyik gyújtópontjában van a Nap."));
            this.CardCollections[0].Cards.Add(
                new Card(
                    "Kepler második törvénye",
                    "A bolygók vezérsugara (a bolygót a Nappal összekötő szakasz) azonos idő alatt azonos területet súrol."));
            this.CardCollections[0].Cards.Add(
                new Card(
                    "Kepler harmadik törvénye",
                    "A bolygók Naptól való átlagos távolságainak (a, a pálya fél nagytengelyeinek) köbei úgy aránylanak egymáshoz, mint a keringési idejük (T) négyzetei."));
        }
    }
}
