using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace InsectopiaHelper
{
    public class Blatte : INotifyPropertyChanged
    {
        private BlatteColor color;
        public BlatteColor Color
        {
            get => color;
            set => SetColor(value);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public string HexColor => Color.GetHex();
        public string ImageUri => GetImage();

        public Blatte(bool randomColor = false)
        {
            color = randomColor ? BlatteColorUtility.RandomColor() : BlatteColor.None;
        }

        public Blatte(BlatteColor blatteColor)
        {
            color = blatteColor;
        }

        private void SetColor(BlatteColor color)
        {
            this.color = color;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Color)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.HexColor)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.ImageUri)));
        }

        public void RandomizeColor()
        {
            SetColor(BlatteColorUtility.RandomColor());
        }

        public void Upgrade(int upgradeAmount = 1)
        {
            int upgradedNumber = (int)color + upgradeAmount;
            Color = (BlatteColor) Math.Clamp(upgradedNumber, (int)BlatteColor.Black, (int)BlatteColor.Red);
        }

        public void Downgrade(int downgradeAmount = 1)
        {
            int downgradedNumber = (int)color - downgradeAmount;
            Color = (BlatteColor)Math.Clamp(downgradedNumber, (int)BlatteColor.Black, (int)BlatteColor.Red);
        }

        public string GetImage()
        {
            return color.GetImage();
        }

        protected void OnPropertyChanged(string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
