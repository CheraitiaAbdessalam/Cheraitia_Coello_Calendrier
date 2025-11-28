using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cheraitia_Coello_Calendrier.MenuCarte
{
    /// <summary>
    /// Logique d'interaction pour MenuCartes.xaml
    /// </summary>
    public partial class MenuCartes : UserControl
    {
        public ObservableCollection<string> Cartes { get; set; }

        public MenuCartes()
        {
        InitializeComponent();
            Cartes = new ObservableCollection<string>
            {
            };

            CardsListBox.ItemsSource = Cartes;

        }
        public class Carte
        {
            public string ImagePath { get; set; }
            public string Titre { get; set; }
        }
    }
}
