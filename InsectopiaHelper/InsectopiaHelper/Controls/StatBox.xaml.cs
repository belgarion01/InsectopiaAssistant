using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Logique d'interaction pour StatBox.xaml
    /// </summary>
    public partial class StatBox : UserControl, INotifyPropertyChanged
    {
        public int StatValue
        {
            get => (int)GetValue(StatValueProperty);
            set => SetValue(StatValueProperty, value);
        }

        public string StatName
        {
            get => (string)GetValue(StatValueProperty);
            set => SetValue(StatValueProperty, value);
        }

        public static DependencyProperty StatValueProperty = DependencyProperty.Register(nameof(StatValue), typeof(int), typeof(StatBox), new PropertyMetadata(0, StatTextPropCb));

        public static DependencyProperty StatNameProperty = DependencyProperty.Register(nameof(StatName), typeof(string), typeof(StatBox));

        public event PropertyChangedEventHandler PropertyChanged;

        private static void StatTextPropCb(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var dep = d as StatBox;
            if (dep == null) return;
            dep.StatValue = (int)e.NewValue;
            dep.OnPropertyChanged(nameof(StatValue));
        }

        private void OnPropertyChanged(string propName = "") =>
       PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));

        public StatBox()
        {
            InitializeComponent();
        }

        private void btnUpStat_Click(object sender, RoutedEventArgs e)
        {
            StatValue++;
        }

        private void btnDownStat_Click(object sender, RoutedEventArgs e)
        {
            StatValue--;
        }
    }
}
