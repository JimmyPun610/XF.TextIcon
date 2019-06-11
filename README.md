# XF.TextIcon
Xamarin Forms Library for Icon font


# Setup
1. Forms Project
  - Install Nuget Package
  ```
  Install-Package XF.TextIcon.Forms -Version 1.0.0.0
  ```

2. Android Project
  - Add Fonts to Asset Folder and make sure Build Action is AndroidAsset
 
3. iOS Project
  - Add Fonts to Resources folder and make sure Build Action is BundleResource
  - Insert below to info.plist
  ```xml
  <key>UIAppFonts</key>
	<array>
		<string>ionicons.ttf</string>
    <string>icons8-win10.ttf</string>
    <string>icofont.ttf</string>
    <string>GoogleMaterial.ttf</string>
    <string>FontAwesome5FreeRegular.otf</string>
    <string>FontAwesome5FreeSolid.otf</string>
    <string>FontAwesome5FreeBrand.otf</string>
  </array>
 ```
  
  
#How to use
To use in xaml, you may set the icon as below. The IconName can be check from CheatSheet.
 ```xaml
   <Label>
            <Label.FormattedText>
                <FormattedString>
                    <texticon:IconSpan IconType="IonicIcon" IconName="ion-ios-arrow-round-forward" FontSize="Large"/>
                    <texticon:IconSpan IconType="Icon8Win10" IconName="icons8-win10-clipboard" FontSize="Large"/>
                    <texticon:IconSpan IconType="IcoFont" IconName="icofont-gift-box" FontSize="Large"/>
                    <texticon:IconSpan IconType="GoogleMaterial" IconName="material-add_shopping_cart" FontSize="Large"/>
                    <texticon:IconSpan IconType="FontAwesomeBrand" IconName="fontawesome5-free-brand-facebook" FontSize="Large"/>
                    <texticon:IconSpan IconType="FontAwesomeRegular" IconName="fontawesome5-free-regular-calendar-check" FontSize="Large"/>
                    <texticon:IconSpan IconType="FontAwesomeSolid" IconName="fontawesome5-free-solid-angry" FontSize="Large"/>
                </FormattedString>
            </Label.FormattedText>
        </Label>
        <texticon:IconLabel IconType="FontAwesomeSolid" IconName="fontawesome5-free-solid-angry" FontSize="Large"/>
  ```
  
  
  
  #Further improvement
  Please let me know if any request on different fonts, providing the otf / ttf file will be nice.
