#pragma checksum "..\..\..\Teacher\PafeAddElevation.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "070E4AD790509BBA9E4E5E9939E7066FEB4BAA94B466D6B661F417C71DD4600B"
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
    /// PafeAddElevation
    /// </summary>
    public partial class PafeAddElevation : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Teacher\PafeAddElevation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cmb_Course;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Teacher\PafeAddElevation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cmb_Group;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Teacher\PafeAddElevation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cmb_Student;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Teacher\PafeAddElevation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cmb_Object;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Teacher\PafeAddElevation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txb_Evaluation;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Teacher\PafeAddElevation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_AddEvaluation;
        
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
            System.Uri resourceLocater = new System.Uri("/ElectronicJournal2;component/teacher/pafeaddelevation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Teacher\PafeAddElevation.xaml"
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
            this.Cmb_Course = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\..\Teacher\PafeAddElevation.xaml"
            this.Cmb_Course.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Cmb_Course_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Cmb_Group = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\..\Teacher\PafeAddElevation.xaml"
            this.Cmb_Group.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Cmb_Group_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Cmb_Student = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.Cmb_Object = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.Txb_Evaluation = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Btn_AddEvaluation = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\Teacher\PafeAddElevation.xaml"
            this.Btn_AddEvaluation.Click += new System.Windows.RoutedEventHandler(this.Btn_AddEvaluation_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

