#pragma checksum "..\..\..\Teacher\TeacherMainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "07C4E56DF05B6C6B4990B24CA5CDD97B079D1DD871BD1C0AAE5781E8603B00F6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ElectronicJournal2.Teacher;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ElectronicJournal2.Teacher {
    
    
    /// <summary>
    /// TeacherMainPage
    /// </summary>
    public partial class TeacherMainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Teacher\TeacherMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_ChoiceJournal;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Teacher\TeacherMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_EvaluationAdd;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Teacher\TeacherMainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_CloseApp;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ElectronicJournal2;component/teacher/teachermainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Teacher\TeacherMainPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Btn_ChoiceJournal = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Teacher\TeacherMainPage.xaml"
            this.Btn_ChoiceJournal.Click += new System.Windows.RoutedEventHandler(this.Btn_ChoiceJournal_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Btn_EvaluationAdd = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Teacher\TeacherMainPage.xaml"
            this.Btn_EvaluationAdd.Click += new System.Windows.RoutedEventHandler(this.Btn_EvaluationAdd_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Btn_CloseApp = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Teacher\TeacherMainPage.xaml"
            this.Btn_CloseApp.Click += new System.Windows.RoutedEventHandler(this.Btn_CloseApp_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

