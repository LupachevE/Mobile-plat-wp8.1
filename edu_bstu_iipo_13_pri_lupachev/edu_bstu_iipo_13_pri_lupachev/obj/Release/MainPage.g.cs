﻿

#pragma checksum "C:\Users\jon-a\Documents\Visual Studio 2015\Projects\Mobilki\edu_bstu_iipo_13_pri_lupachev\edu_bstu_iipo_13_pri_lupachev\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "94968103EFA0AB8F41F7A8D895E39B2B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace edu_bstu_iipo_13_pri_lupachev
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 13 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.button_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 22 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.emailValue_Tapped;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 23 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.numberValue_Tapped;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 24 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).LostFocus += this.textBox_LostFocus;
                 #line default
                 #line hidden
                #line 24 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).GotFocus += this.textBox_GotFocus;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

