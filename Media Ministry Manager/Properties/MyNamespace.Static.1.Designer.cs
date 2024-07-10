// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;

/* TODO ERROR: Skipped IfDirectiveTrivia
#If TARGET = "module" AndAlso _MYTYPE = "" Then
*//* TODO ERROR: Skipped DisabledTextTrivia
#Const _MYTYPE="Empty"
*//* TODO ERROR: Skipped EndIfDirectiveTrivia
#End If
*/
/* TODO ERROR: Skipped IfDirectiveTrivia
#If _MYTYPE = "WindowsForms" Then
*/
/* TODO ERROR: Skipped DefineDirectiveTrivia
#Const _MYFORMS = True
*//* TODO ERROR: Skipped DefineDirectiveTrivia
#Const _MYWEBSERVICES = True
*//* TODO ERROR: Skipped DefineDirectiveTrivia
#Const _MYUSERTYPE = "Windows"
*//* TODO ERROR: Skipped DefineDirectiveTrivia
#Const _MYCOMPUTERTYPE = "Windows"
*//* TODO ERROR: Skipped DefineDirectiveTrivia
#Const _MYAPPLICATIONTYPE = "WindowsForms"
*/
/* TODO ERROR: Skipped ElifDirectiveTrivia
#ElseIf _MYTYPE = "WindowsFormsWithCustomSubMain" Then
*//* TODO ERROR: Skipped DisabledTextTrivia

#Const _MYFORMS = True
#Const _MYWEBSERVICES = True
#Const _MYUSERTYPE = "Windows"
#Const _MYCOMPUTERTYPE = "Windows"
#Const _MYAPPLICATIONTYPE = "Console"

*//* TODO ERROR: Skipped ElifDirectiveTrivia
#ElseIf _MYTYPE = "Windows" OrElse _MYTYPE = "" Then
*//* TODO ERROR: Skipped DisabledTextTrivia

#Const _MYWEBSERVICES = True
#Const _MYUSERTYPE = "Windows"
#Const _MYCOMPUTERTYPE = "Windows"
#Const _MYAPPLICATIONTYPE = "Windows"

*//* TODO ERROR: Skipped ElifDirectiveTrivia
#ElseIf _MYTYPE = "Console" Then
*//* TODO ERROR: Skipped DisabledTextTrivia

#Const _MYWEBSERVICES = True
#Const _MYUSERTYPE = "Windows"
#Const _MYCOMPUTERTYPE = "Windows"
#Const _MYAPPLICATIONTYPE = "Console"

*//* TODO ERROR: Skipped ElifDirectiveTrivia
#ElseIf _MYTYPE = "Web" Then
*//* TODO ERROR: Skipped DisabledTextTrivia

#Const _MYFORMS = False
#Const _MYWEBSERVICES = False
#Const _MYUSERTYPE = "Web"
#Const _MYCOMPUTERTYPE = "Web"

*//* TODO ERROR: Skipped ElifDirectiveTrivia
#ElseIf _MYTYPE = "WebControl" Then
*//* TODO ERROR: Skipped DisabledTextTrivia

#Const _MYFORMS = False
#Const _MYWEBSERVICES = True
#Const _MYUSERTYPE = "Web"
#Const _MYCOMPUTERTYPE = "Web"

*//* TODO ERROR: Skipped ElifDirectiveTrivia
#ElseIf _MYTYPE = "Custom" Then
*//* TODO ERROR: Skipped DisabledTextTrivia

*//* TODO ERROR: Skipped ElifDirectiveTrivia
#ElseIf _MYTYPE <> "Empty" Then
*//* TODO ERROR: Skipped DisabledTextTrivia

#Const _MYTYPE = "Empty"

*//* TODO ERROR: Skipped EndIfDirectiveTrivia
#End If
*/
/* TODO ERROR: Skipped IfDirectiveTrivia
#If _MYTYPE <> "Empty" Then
*/
namespace M3App.My
{

    /* TODO ERROR: Skipped IfDirectiveTrivia
    #If _MYAPPLICATIONTYPE = "WindowsForms" OrElse _MYAPPLICATIONTYPE = "Windows" OrElse _MYAPPLICATIONTYPE = "Console" Then
    */
    [System.CodeDom.Compiler.GeneratedCode("MyTemplate", "11.0.0.0")]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]

    /* TODO ERROR: Skipped IfDirectiveTrivia
    #If _MYAPPLICATIONTYPE = "WindowsForms" Then
    */
    internal partial class MyApplication : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
    {
        /* TODO ERROR: Skipped IfDirectiveTrivia
        #If TARGET = "winexe" Then
        */
        //[STAThread()]
        //[DebuggerHidden()]
        //[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        //internal static void Main(string[] Args)
        //{
        //    try
        //    {
        //        Application.SetCompatibleTextRenderingDefault(UseCompatibleTextRendering);
        //    }
        //    finally
        //    {
        //    }
        //    MyProject.Application.Run(Args);
        //}
        /* TODO ERROR: Skipped EndIfDirectiveTrivia
        #End If
        */
        /* TODO ERROR: Skipped ElifDirectiveTrivia
        #ElseIf _MYAPPLICATIONTYPE = "Windows" Then
        *//* TODO ERROR: Skipped DisabledTextTrivia
                Inherits Global.Microsoft.VisualBasic.ApplicationServices.ApplicationBase
        *//* TODO ERROR: Skipped ElifDirectiveTrivia
        #ElseIf _MYAPPLICATIONTYPE = "Console" Then
        *//* TODO ERROR: Skipped DisabledTextTrivia
                Inherits Global.Microsoft.VisualBasic.ApplicationServices.ConsoleApplicationBase	
        *//* TODO ERROR: Skipped EndIfDirectiveTrivia
        #End If '_MYAPPLICATIONTYPE = "WindowsForms"
        */
    }

    /* TODO ERROR: Skipped EndIfDirectiveTrivia
    #End If '#If _MYAPPLICATIONTYPE = "WindowsForms" Or _MYAPPLICATIONTYPE = "Windows" or _MYAPPLICATIONTYPE = "Console"
    */
    /* TODO ERROR: Skipped IfDirectiveTrivia
    #If _MYCOMPUTERTYPE <> "" Then
    */
    [System.CodeDom.Compiler.GeneratedCode("MyTemplate", "11.0.0.0")]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]

    /* TODO ERROR: Skipped IfDirectiveTrivia
    #If _MYCOMPUTERTYPE = "Windows" Then
    */
    internal partial class MyComputer : Microsoft.VisualBasic.Devices.Computer
    {
        /* TODO ERROR: Skipped ElifDirectiveTrivia
        #ElseIf _MYCOMPUTERTYPE = "Web" Then
        *//* TODO ERROR: Skipped DisabledTextTrivia
                Inherits Global.Microsoft.VisualBasic.Devices.ServerComputer
        *//* TODO ERROR: Skipped EndIfDirectiveTrivia
        #End If
        */
        [DebuggerHidden()]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public MyComputer() : base()
        {
        }
    }
}
/* TODO ERROR: Skipped EndIfDirectiveTrivia
#End If
*/
