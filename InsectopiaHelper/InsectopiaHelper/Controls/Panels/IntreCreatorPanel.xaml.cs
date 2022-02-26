using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
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
    /// Logique d'interaction pour IntreCreatorPanel.xaml
    /// </summary>
    public partial class IntreCreatorPanel : UserControl, INotifyPropertyChanged
    {
        
        public ObservableCollection<IntreVM> LoadedIntres = new ObservableCollection<IntreVM>();

        public event PropertyChangedEventHandler PropertyChanged;

        private IntreVM currentIntre;
        public IntreVM CurrentIntre
        {
            get => currentIntre; set
            {
                currentIntre = value;
                svIntrePanel.Visibility = currentIntre == null ? Visibility.Collapsed : Visibility.Visible;
                DataContext = currentIntre;
                NotifyPropertyChanged();
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public IntreCreatorPanel()
        {
            
            InitializeComponent();


            CurrentIntre = new IntreVM(RandomUtility.GenerateIntre());
            // DataContext = currentIntre;
            icLoadedIntres.ItemsSource = LoadedIntres;
            ReloadLoadedIntres();
        }

        private void SetCurrentIntre(Intre intre) => CurrentIntre = new IntreVM(intre);

        private void btnLoadedCharacter_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {
                IntreVM intre = button.DataContext as IntreVM;

                if (intre != null)
                {
                    SetCurrentIntre(intre.Intre);
                }
            }
        }

        private void btnDeleteIntre_Click(object sender, RoutedEventArgs e)
        {
            SaveUtility.DeleteCharacter(currentIntre.Intre);
            CurrentIntre = null;
            ReloadLoadedIntres();
        }

        private void btnSaveIntre_Click(object sender, RoutedEventArgs e)
        {
            if (currentIntre == null) return;

            
            SaveUtility.SaveCharacter(currentIntre.Intre);
            ReloadLoadedIntres();
        }

        private void ReloadLoadedIntres()
        {
            LoadedIntres.Clear();
            foreach (Intre intre in SaveUtility.LoadCharacters())
            {
                LoadedIntres.Add(new IntreVM(intre));
            }
        }

        private void btnNewIntre_Click(object sender, RoutedEventArgs e)
        {
            Intre newIntre = new Intre(true) { Name = "Generated Intre" };
            SaveUtility.SaveCharacter(newIntre);
            SetCurrentIntre(newIntre);

            ReloadLoadedIntres();
        }
    }
}
