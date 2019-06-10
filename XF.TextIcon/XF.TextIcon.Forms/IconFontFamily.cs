using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XF.TextIcon.Forms.FontName;

namespace XF.TextIcon.Forms
{
    internal static class IconFontFamily
    {
        public static string GetFontFamily(IconTypes iconType)
        {
            string ttfName = string.Empty;
            string fontFamilyName = string.Empty;
            switch (iconType)
            {
                case IconTypes.IonicIcon:
                    ttfName = TTFNames.IonicIcon;
                    fontFamilyName = FontFamilyNames.IonicIcon;
                    break;
                case IconTypes.Icon8Win10:
                    ttfName = TTFNames.Icon8Windows10;
                    fontFamilyName = FontFamilyNames.Icon8Windows10;
                    break;
                case IconTypes.IcoFont:
                    ttfName = TTFNames.IcoFont;
                    fontFamilyName = FontFamilyNames.IcoFont;
                    break;
                case IconTypes.GoogleMaterial:
                    ttfName = TTFNames.GoolgeMaterial;
                    fontFamilyName = FontFamilyNames.GoogleMaterial;
                    break;
                default:
                    ttfName = TTFNames.IonicIcon;
                    fontFamilyName = FontFamilyNames.IonicIcon;
                    break;
            }

            if (Device.RuntimePlatform == Device.iOS)
                return fontFamilyName;
            else return $"{ttfName}#{fontFamilyName}";
        }
    
    }
}
