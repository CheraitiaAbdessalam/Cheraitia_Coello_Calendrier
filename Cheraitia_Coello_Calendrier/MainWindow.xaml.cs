using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Cheraitia_Coello_Calendrier.Views;

namespace Cheraitia_Coello_Calendrier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

        }

        private void Parametre_Click(object sender, RoutedEventArgs e)
        {

            ContentArea.Children.Clear();
            ParametrePage parametrePage = new ParametrePage();
            ContentArea.Children.Add(parametrePage);




        }

        private void MenuDesCartes_Click(object sender, RoutedEventArgs e)
        {
            ContentArea.Children.Clear();
            MenudescartePage menudescartesPage = new MenudescartePage();
            ContentArea.Children.Add(menudescartesPage);


        }

        private void CarteDuJour_Click(object sender, RoutedEventArgs e)
        {
           

        }
    }
}