using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace InsectopiaHelper
{
    /// <summary>
    /// Logique d'interaction pour BlatteRollerPanel.xaml
    /// </summary>
    public partial class BlatteRollerPanel : UserControl
    {
        ObservableCollection<Blatte> blatteResult = new ObservableCollection<Blatte>();
        public BlatteRollerPanel()
        {
            InitializeComponent();

            blatteResult.Add(new Blatte(true));
            blatteResult.Add(new Blatte(true));
            blatteResult.Add(new Blatte(true));
            icBlatteResult.ItemsSource = blatteResult;
        }
        private void btnRoll_Click(object sender, RoutedEventArgs e)
        {
            blatteResult.Add(new Blatte(true));
        }

        private void btnRollMultiple_Click(object sender, RoutedEventArgs e)
        {
            blatteResult.Clear();
            if (int.TryParse(tboxRollNumber.Text, out int rollNumber))
            {
                for (int i = 0; i < rollNumber; i++)
                {
                    blatteResult.Add(new Blatte(true));
                }
            }
        }

        private void SetColor_Randomize(object sender, RoutedEventArgs e)
        {
            Blatte blatte = (sender as FrameworkElement).Tag as Blatte;
            if(blatte != null)
            {
                blatte.RandomizeColor();
            }
        }

        private void SetColor_Upgrade(object sender, RoutedEventArgs e)
        {
            Blatte blatte = (sender as FrameworkElement).Tag as Blatte;
            if (blatte != null)
            {
                blatte.Upgrade();
            }
        }

        private void SetColor_Downgrade(object sender, RoutedEventArgs e)
        {
            Blatte blatte = (sender as FrameworkElement).Tag as Blatte;
            if (blatte != null)
            {
                blatte.Downgrade();
            }
        }

        private void SetColor_Black(object sender, RoutedEventArgs e)
        {
            Blatte blatte = (sender as FrameworkElement).Tag as Blatte;
            if (blatte != null)
            {
                blatte.Color = BlatteColor.Black;
            }
        }

        private void SetColor_White(object sender, RoutedEventArgs e)
        {
            Blatte blatte = (sender as FrameworkElement).Tag as Blatte;
            if (blatte != null)
            {
                blatte.Color = BlatteColor.White;
            }
        }

        private void SetColor_Blue(object sender, RoutedEventArgs e)
        {
            Blatte blatte = (sender as FrameworkElement).Tag as Blatte;
            if (blatte != null)
            {
                blatte.Color = BlatteColor.Blue;
            }
        }

        private void SetColor_Green(object sender, RoutedEventArgs e)
        {
            Blatte blatte = (sender as FrameworkElement).Tag as Blatte;
            if (blatte != null)
            {
                blatte.Color = BlatteColor.Green;
            }
        }

        private void SetColor_Red(object sender, RoutedEventArgs e)
        {
            Blatte blatte = (sender as FrameworkElement).Tag as Blatte;
            if (blatte != null)
            {
                blatte.Color = BlatteColor.Red;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            blatteResult.Clear();
        }
    }
}
