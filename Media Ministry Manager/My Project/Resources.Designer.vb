﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("MediaMinistry.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        '''</summary>
        Friend ReadOnly Property App_Icon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("App_Icon", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property credentials() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("credentials", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property logout_button() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("logout button", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Media_Ministry_Logo() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Media Ministry Logo", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!Doctype html&gt;
        '''&lt;html&gt;
        '''    &lt;head&gt;
        '''        &lt;link rel=&quot;stylesheet&quot; href=&quot;https://sppbc.hopto.org/css/emails.css&quot;&gt;
        '''    &lt;/head&gt;
        '''    &lt;body&gt;
        '''        &lt;p&gt;Blessings To You {0},&lt;/p&gt;
        '''
        '''		&lt;p&gt;Welcome to the St. Paul Primitive Baptist Church Email Listening Ministry. Thank you for becoming a Subscriber. You will receive Sunday&apos;s Messages from the St. Paul Primitive Baptist Church, Austin, TX. Morning Service each week; where Elder Bryon K. Miller is the Pastor. You will Receive your Sunday Morning Message within 2 [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property newListener() As String
            Get
                Return ResourceManager.GetString("newListener", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!Doctype html&gt;
        '''&lt;html&gt;
        '''    &lt;head&gt;
        '''        &lt;link rel=&quot;stylesheet&quot; href=&quot;https://sppbc.hopto.org/css/emails.css&quot;&gt;
        '''    &lt;/head&gt;
        '''    &lt;body&gt;
        '''        &lt;p&gt;Good Afternoon {0},&lt;/p&gt;
        '''
        '''        &lt;p&gt;&lt;em&gt;Watch all our sermons on &lt;a href=&quot;https://www.youtube.com/channel/UCJ2c3QAAYu2KneiTvjRJEKg/videos&quot;&gt;YouTube&lt;/a&gt; and subscribe for easier access.&lt;/em&gt;&lt;/p&gt;
        '''        &lt;p&gt;Also, give us a follow on &lt;a href=&quot;https://facebook.com/bryon.miller436&quot;&gt;Facebook&lt;/a&gt;, where we host our weekly live streams&lt;/p&gt;
        '''        &lt;p&gt;You may give [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property newSermon() As String
            Get
                Return ResourceManager.GetString("newSermon", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
