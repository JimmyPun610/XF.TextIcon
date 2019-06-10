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
        public IconCodeDictionary()
        {
            initIonicIcon();
        }
        

        private void initIonicIcon()
        {
            string json = FontResources.ResourceHelpers.GetEmbeddedResource("FontResources/IonicIcon/IonicIconMapping.json");
            IonicIconCodeMap = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }

        public string GetIconCode(string key, IconTypes iconTypes)
        {
            switch (iconTypes)
            {
                case IconTypes.IonicIcon:
                    if (IonicIconCodeMap.ContainsKey(key))
                        return IonicIconCodeMap[key];
                    else return string.Empty;
                default:
                    return string.Empty;
            }

        }
    }
}
