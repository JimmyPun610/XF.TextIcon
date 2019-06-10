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
                case IconTypes.FontAwesomeSolid:
                    ttfName = TTFNames.FontAwesome5FreeSolid;
                    fontFamilyName = FontFamilyNames.FontAwesome5FreeSolid;
                    break;
                case IconTypes.FontAwesomeRegular:
                    ttfName = TTFNames.FontAwesome5FreeRegular;
                    fontFamilyName = FontFamilyNames.FontAwesome5FreeRegular;
                    break;
                case IconTypes.FontAwesomeBrand:
                    ttfName = TTFNames.FontAwesome5FreeBrand;
                    fontFamilyName = FontFamilyNames.FontAwesome5FreeBrand;
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
