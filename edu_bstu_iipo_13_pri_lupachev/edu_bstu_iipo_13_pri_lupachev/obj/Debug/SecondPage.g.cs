﻿

#pragma checksum "C:\Users\jon-a\Documents\Mobile-plat-wp8.1\edu_bstu_iipo_13_pri_lupachev\edu_bstu_iipo_13_pri_lupachev\SecondPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2826BA64E8A149F61E8922414DE3C286"
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
    partial class SecondPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 13 "..\..\SecondPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.AppBarButton_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 34 "..\..\SecondPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.addAssoc_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 35 "..\..\SecondPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.image_Tapped;
                 #line default
                 #line hidden
                #line 36 "..\..\SecondPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerPressed += this.animatedGrid_PointerPressed;
                 #line default
                 #line hidden
                #line 36 "..\..\SecondPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerReleased += this.animatedGrid_PointerReleased;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 46 "..\..\SecondPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.button_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


