using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace BKV_lab_Economy.Views
{
    /// <summary>
    /// Логика взаимодействия для EconomyWindow.xaml
    /// </summary>
    public partial class EconomyWindow : Window
    {
        public EconomyWindow()
        {
            InitializeComponent();
        }

        private void GetEconomy(object sender, RoutedEventArgs e)
        {
            try
            {
                int countDays, firstCount, secondCount, costDifference;
                FirstItemNameLabel.Text = FirstItemName.Text;
                SecondItemNameLabel.Text = SecondItemName.Text;

                countDays = Convert.ToInt32(CountDays.Text);
                firstCount = Convert.ToInt32(FirstItemCost.Text);
                secondCount = Convert.ToInt32(SecondItemCost.Text);


                if (firstCount < secondCount)
                {
                    costDifference = (secondCount - firstCount) * countDays;
                    MostDefferenceItem.Text = FirstItemName.Text;
                }
                else
                {
                    costDifference = (firstCount - secondCount) * countDays;
                    MostDefferenceItem.Text = SecondItemName.Text;
                }
                EconomyValue.Text = costDifference.ToString();

                DayCountTextBlock.Text = CountDays.Text;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BoyNextDoor(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
