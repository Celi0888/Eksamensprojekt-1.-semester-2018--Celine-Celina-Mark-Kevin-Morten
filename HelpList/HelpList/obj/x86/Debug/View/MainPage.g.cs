﻿#pragma checksum "C:\Users\cecce\source\repos\Celi0888\Eksamensprojekt-1.-semester-2018--Celine-Celina-Mark-Kevin-Morten\HelpList\HelpList\View\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6CE78F7292CEC1F1E8C6FA86A6FBC7A4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelpList
{
    partial class MainPage : 
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
            case 1: // View\MainPage.xaml line 32
                {
                    this.TextBox_Ex = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2: // View\MainPage.xaml line 33
                {
                    this.TextBox_Email = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // View\MainPage.xaml line 41
                {
                    this.TextBox_Code = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 4: // View\MainPage.xaml line 52
                {
                    this.LoginStudent = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.LoginStudent).Click += this.LoginStudent_Click;
                }
                break;
            case 5: // View\MainPage.xaml line 65
                {
                    this.LoginTeacher = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.LoginTeacher).Click += this.LoginTeacher_Click;
                }
                break;
            case 6: // View\MainPage.xaml line 77
                {
                    global::Windows.UI.Xaml.Controls.Button element6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element6).Click += this.Button_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

