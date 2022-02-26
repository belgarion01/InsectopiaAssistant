using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace InsectopiaHelper 
{ 
    public class InitiativeRollerVM
    {
        public ObservableCollection<IntreVM> LoadedIntres = new ObservableCollection<IntreVM>();
        public ObservableCollection<IntreVM> IntrePool = new ObservableCollection<IntreVM>();

        public ObservableCollection<IntreVM> RedIntres = new ObservableCollection<IntreVM>();
        public ObservableCollection<IntreVM> GreenIntres = new ObservableCollection<IntreVM>();
        public ObservableCollection<IntreVM> BlueIntres = new ObservableCollection<IntreVM>();
        public ObservableCollection<IntreVM> WhiteIntres = new ObservableCollection<IntreVM>();
        public ObservableCollection<IntreVM> BlackIntres = new ObservableCollection<IntreVM>();

        public InitiativeRollerVM()
        {
            RedIntres = new ObservableCollection<IntreVM>
            {
                new IntreVM(new Intre(){Name="Euid"})
            };

            GreenIntres = new ObservableCollection<IntreVM>
            {
                new IntreVM(new Intre(){Name="Limace"}),
                new IntreVM(new Intre(){Name="Enemy"}),
            };

            BlueIntres = new ObservableCollection<IntreVM>
            {
                new IntreVM(new Intre(){Name="Mario"}),
                new IntreVM(new Intre(){Name="Euid"}),
                new IntreVM(new Intre(){Name="Mario"}),
            };

            WhiteIntres = new ObservableCollection<IntreVM>
            {
                new IntreVM(new Intre(){Name="Enemy"}),
                new IntreVM(new Intre(){Name="Enemy"}),
                new IntreVM(new Intre(){Name="Euid"}),
                new IntreVM(new Intre(){Name="Mario"}),
            };

            BlackIntres = new ObservableCollection<IntreVM>
            {
                new IntreVM(new Intre(){Name="Limace"})
            };

            IntrePool = new ObservableCollection<IntreVM>
            {
                new IntreVM(new Intre(){Name="Euid"}),
                new IntreVM(new Intre(){Name="Mario"}),
                new IntreVM(new Intre(){Name="Limace"}),
                new IntreVM(new Intre(){Name="Enemy"}),
            };
        }
    }
}
