using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using XF.TextIcon.Forms.FontName;

namespace XF.TextIcon.Forms
{
    public class IconCodeDictionary
    {
        private Dictionary<string, string> IonicIconCodeMap = new Dictionary<string, string>();
        private Dictionary<string, string> Icon8Win10CodeMap = new Dictionary<string, string>();
        private Dictionary<string, string> IcoFontCodeMap = new Dictionary<string, string>();
        private Dictionary<string, string> GoogleMaterialIconCodeMap = new Dictionary<string, string>();
        private Dictionary<string, string> FontAwesome5FreeRegularCodeMap = new Dictionary<string, string>();
        private Dictionary<string, string> FontAwesome5FreeSolidCodeMap = new Dictionary<string, string>();
        private Dictionary<string, string> FontAwesome5FreeBrandCodeMap = new Dictionary<string, string>();


        private static IconCodeDictionary _instance { get; set; }
        public static IconCodeDictionary Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new IconCodeDictionary();
                return _instance;
            }
        }
     
        public IconCodeDictionary()
        {
            initIonicIcon();
            initIcon8Windows10Icon();
            initIcoFontIcon();
            initGoogleMaterialIcon();
            initFontAwesome5FreeBrandIcon();
            initFontAwesome5FreeRegularIcon();
            initFontAwesome5FreeSolidIcon();
        }
        

        private void initIonicIcon()
        {
            string json = FontResources.ResourceHelpers.GetEmbeddedResource("FontResources/IonicIconMapping.json");
            IonicIconCodeMap = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }
        private void initIcon8Windows10Icon()
        {
            string json = FontResources.ResourceHelpers.GetEmbeddedResource("FontResources/Icons8Windows10IconMapping.json");
            Icon8Win10CodeMap = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }
        private void initIcoFontIcon()
        {
            string json = FontResources.ResourceHelpers.GetEmbeddedResource("FontResources/IcoFontIconMapping.json");
            IcoFontCodeMap = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }
        private void initGoogleMaterialIcon()
        {
            string json = FontResources.ResourceHelpers.GetEmbeddedResource("FontResources/GoogleMaterialIconMapping.json");
            GoogleMaterialIconCodeMap = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }
        private void initFontAwesome5FreeRegularIcon()
        {
            string json = FontResources.ResourceHelpers.GetEmbeddedResource("FontResources/FontAwesome5Free-Regular.json");
            FontAwesome5FreeRegularCodeMap = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }
        private void initFontAwesome5FreeSolidIcon()
        {
            string json = FontResources.ResourceHelpers.GetEmbeddedResource("FontResources/FontAwesome5Free-Solid.json");
            FontAwesome5FreeSolidCodeMap = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }
        private void initFontAwesome5FreeBrandIcon()
        {
            string json = FontResources.ResourceHelpers.GetEmbeddedResource("FontResources/FontAwesome5Free-Brand.json");
            FontAwesome5FreeBrandCodeMap = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }

        public string GetIconCode(string key, IconTypes iconTypes)
        {
            switch (iconTypes)
            {
                case IconTypes.IonicIcon:
                    if (IonicIconCodeMap.ContainsKey(key))
                        return IonicIconCodeMap[key];
                    else return string.Empty;
                case IconTypes.Icon8Win10:
                    if (Icon8Win10CodeMap.ContainsKey(key))
                        return Icon8Win10CodeMap[key];
                    else return string.Empty;
                case IconTypes.IcoFont:
                    if (IcoFontCodeMap.ContainsKey(key))
                        return IcoFontCodeMap[key];
                    else return string.Empty;
                case IconTypes.GoogleMaterial:
                    if (GoogleMaterialIconCodeMap.ContainsKey(key))
                        return GoogleMaterialIconCodeMap[key];
                    else return string.Empty;
                case IconTypes.FontAwesomeBrand:
                    if (FontAwesome5FreeBrandCodeMap.ContainsKey(key))
                        return FontAwesome5FreeBrandCodeMap[key];
                    else return string.Empty;
                case IconTypes.FontAwesomeSolid:
                    if (FontAwesome5FreeSolidCodeMap.ContainsKey(key))
                        return FontAwesome5FreeSolidCodeMap[key];
                    else return string.Empty;
                case IconTypes.FontAwesomeRegular:
                    if (FontAwesome5FreeRegularCodeMap.ContainsKey(key))
                        return FontAwesome5FreeRegularCodeMap[key];
                    else return string.Empty;
                default:
                    return string.Empty;
            }

        }
    }
}
