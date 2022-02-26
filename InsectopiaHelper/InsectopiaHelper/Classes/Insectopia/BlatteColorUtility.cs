using System.Collections.Generic;

namespace InsectopiaHelper
{
    public static class BlatteColorUtility
    {
        public static List<BlatteColor> GetBlatteColors()
        {
            return  new List<BlatteColor>()
            {
                BlatteColor.Black,
                BlatteColor.White,
                BlatteColor.Blue,
                BlatteColor.Green,
                BlatteColor.Red
            };
        }

        public static BlatteColor RandomColor()
        {
            int randomNumber = RandomUtility.r.Next(42) + 1;    // 42 Total

            if (randomNumber <= 3) return BlatteColor.Black;    // 3 Black
            if (randomNumber <= 21) return BlatteColor.White;   // 18 White
            if (randomNumber <= 33) return BlatteColor.Blue;    // 12 Blue
            if (randomNumber <= 39) return BlatteColor.Green;   // 6 Green
            if (randomNumber <= 42) return BlatteColor.Red;     // 3 Red

            return BlatteColor.None;
        }

        public static string GetHex(this BlatteColor blatteColor)
        {
            switch (blatteColor)
            {
                case BlatteColor.None:
                    return "#ff00e1"; // Pink
                case BlatteColor.Black:
                    return "#171717"; 
                case BlatteColor.White:
                    return "#c9c9c9"; 
                case BlatteColor.Blue:
                    return "#1d49db"; 
                case BlatteColor.Green:
                    return "#1ddb1d"; 
                case BlatteColor.Red:
                    return "#db1d20";
            }

            return "#ff00e1";
        }

        public static string GetImage(this BlatteColor blatteColor)
        {
            switch (blatteColor)
            {
                case BlatteColor.None:
                    return "/Resources/Application/Blatte_None.png";
                case BlatteColor.Black:
                    return "/Resources/Application/Blatte_Black.png";
                case BlatteColor.White:
                    return "/Resources/Application/Blatte_White.png";
                case BlatteColor.Blue:
                    return "/Resources/Application/Blatte_Blue.png";
                case BlatteColor.Green:
                    return "/Resources/Application/Blatte_Green.png";
                case BlatteColor.Red:
                    return "/Resources/Application/Blatte_Red.png";
            }

            return "/Resources/Application/Blatte_None.png";
        }
    }
}