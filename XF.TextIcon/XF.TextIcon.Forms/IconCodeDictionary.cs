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
        private Dictionary<string, string> IonicIconCodeMap = new Dictionary<string, string>();
        private Dictionary<string, string> Icon8Win10CodeMap = new Dictionary<string, string>();
        public IconCodeDictionary()
        {
            initIonicIcon();
            initIcon8Windows10Icon();
        }
        

        private void initIonicIcon()
        {
            string json = FontResources.ResourceHelpers.GetEmbeddedResource("FontResources/IonicIconMapping.json");
            IonicIconCodeMap = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }
        private void initIcon8Windows10Icon()
        {
            string json = FontResources.ResourceHelpers.GetEmbeddedResource("FontResources/Icon8Windows10IconMapping.json");
            Icon8Win10CodeMap = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
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
                default:
                    return string.Empty;
            }

        }
    }
}
