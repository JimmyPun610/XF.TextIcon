using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using XF.TextIcon.Forms.FontName;

namespace XF.TextIcon.Forms.View
{
 
    public class IconLabel : Label, INotifyPropertyChanged
    {
        const string IonicTffFile = "ionicons.ttf";
        const string IonicFontFamily = "Ionicons";
        public IconLabel()
        {
            changeFontFamily();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (nameof(IconType) == propertyName)
            {
                changeFontFamily();
                getIconText();
            }
            else if (nameof(IconName) == propertyName)
            {
                getIconText();
            }
        }

        private void getIconText()
        {
            this.Text = IconCodeDictionary.Instance.GetIconCode(this.IconName, this.IconType);
        }
        private void changeFontFamily()
        {
            this.FontFamily = IconFontFamily.GetFontFamily(IconType);
        }

        public static readonly BindableProperty IconTypeProperty =
BindableProperty.Create<IconSpan, IconTypes>(w => w.IconType, IconTypes.IonicIcon);
        public IconTypes IconType
        {
            get { return (IconTypes)GetValue(IconTypeProperty); }
            set { SetValue(IconTypeProperty, value); }
        }

        public static readonly BindableProperty IconNameProperty =
BindableProperty.Create<IconSpan, string>(w => w.IconName, string.Empty);
        public string IconName
        {
            get { return (string)GetValue(IconNameProperty); }
            set { SetValue(IconNameProperty, value); }
        }
    }
}
