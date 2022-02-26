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
    /// Logique d'interaction pour TextBoxLabel.xaml
    /// </summary>
    public partial class TextBoxLabel : UserControl, INotifyPropertyChanged
    {
        public string LabelText 
        {
            get => (string)GetValue(LabelTextProperty);
            set => SetValue(LabelTextProperty, value); 
        }
        public double LabelWidth
        {
            get => (double)GetValue(LabelWidthProperty);
            set => SetValue(LabelWidthProperty, value);
        }

        public string TextBoxText
        {
            get => (string)GetValue(TextBoxTextProperty);
            set
            {
                SetValue(TextBoxTextProperty, value);
            }
        }

        public static DependencyProperty LabelTextProperty = DependencyProperty.Register(nameof(LabelText), typeof(string), typeof(TextBoxLabel));

        public static DependencyProperty LabelWidthProperty = DependencyProperty.Register(nameof(LabelWidth), typeof(double), typeof(TextBoxLabel));

        public static DependencyProperty TextBoxTextProperty = DependencyProperty.Register(nameof(TextBoxText), typeof(string), typeof(TextBoxLabel), new PropertyMetadata("", propCallBack));

        public event PropertyChangedEventHandler PropertyChanged;

        //public string InputText => tblText.Text;

        private static void propCallBack(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var dep = d as TextBoxLabel;
            if (dep == null) return;
            dep.TextBoxText = (string)e.NewValue;
            dep.OnPropertyChanged(nameof(TextBoxText));
        }

        private void OnPropertyChanged(string propName = "") =>
       PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));

        public TextBoxLabel()
        {
            InitializeComponent();
        }
    }
}
