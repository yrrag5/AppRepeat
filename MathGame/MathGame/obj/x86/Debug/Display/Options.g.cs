﻿#pragma checksum "C:\Users\College\Desktop\MA\AppRepeat\MathGame\MathGame\Display\Options.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "59E50963FD29C2D1B046BF8ECCCA88A4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MathGame.Display
{
    partial class Options : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.home = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 361 "..\..\..\Display\Options.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.home).Click += this.home_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.slider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    #line 357 "..\..\..\Display\Options.xaml"
                    ((global::Windows.UI.Xaml.Controls.Slider)this.slider).ValueChanged += this.slider_ValueChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.DiffSelectH = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 349 "..\..\..\Display\Options.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.DiffSelectH).Checked += this.DiffSelectH_Checked;
                    #line default
                }
                break;
            case 4:
                {
                    this.DiffSelectE = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 350 "..\..\..\Display\Options.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.DiffSelectE).Checked += this.DiffSelectE_Checked;
                    #line default
                }
                break;
            case 5:
                {
                    this.Title = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

