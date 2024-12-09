using BKV_lab_Economy.Views;
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

namespace BKV_lab_Economy
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

        private void Button_OpenSoManyWindowsToStartEconomy(object sender, RoutedEventArgs e)
        {

            try
            {
               
                int economyWindowsCount = Convert.ToInt32(EconomyWindowsCount.Text);

                if (economyWindowsCount == 0)
                {
                    MessageBox.Show("ЭЭ дружище, там цифры должны быть да!");
                    return;
                }

                for (int i = 0; i < economyWindowsCount; i++)
                {
                    EconomyWindow economyWindow = new EconomyWindow();
                    economyWindow.ShowDialog();
                }

            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}