﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace M3App.My.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("M3App.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon App_Icon {
            get {
                object obj = ResourceManager.GetObject("App_Icon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap BannerImage {
            get {
                object obj = ResourceManager.GetObject("BannerImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Count: {0}.
        /// </summary>
        internal static string CountTemplate {
            get {
                return ResourceManager.GetString("CountTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] credentials {
            get {
                object obj = ResourceManager.GetObject("credentials", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///&lt;head&gt;
        ///&lt;link rel=&quot;stylesheet&quot; href=&quot;https://sppbc.herbivore.site/manager/css/emails.css&quot;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///
        ///&lt;p&gt;Hello {0},&lt;/p&gt;&lt;br&gt;
        ///
        ///{1}
        ///&lt;hr&gt;
        ///
        ///&lt;p&gt;&lt;strong&gt;Elder Bryon K Miller, Pastor&lt;/strong&gt;&lt;br&gt;
        ///		St. Paul Primitive Baptist Church&lt;br&gt;
        ///		Email Listening Ministry&lt;br&gt;
        ///		2209 East 14th Street&lt;br&gt;
        ///		Austin, TX. 78702&lt;/p&gt;
        ///&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string customMessageTemplate {
            get {
                return ResourceManager.GetString("customMessageTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///&lt;head&gt;
        ///&lt;link rel=&quot;stylesheet&quot; href=&quot;https://sppbc.herbivore.site/manager/css/emails.css&quot;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///
        ///&lt;p&gt;Hello {0},&lt;/p&gt;&lt;br&gt;
        ///
        ///{1}&lt;br&gt;
        ///
        ///&lt;a href=&quot;{2}&quot;&gt;Drive File&lt;/a&gt;
        ///
        ///&lt;hr&gt;
        ///
        ///&lt;p&gt;&lt;strong&gt;Elder Bryon K Miller, Pastor&lt;/strong&gt;&lt;br&gt;
        ///		St. Paul Primitive Baptist Church&lt;br&gt;
        ///		Email Listening Ministry&lt;br&gt;
        ///		2209 East 14th Street&lt;br&gt;
        ///		Austin, TX. 78702&lt;/p&gt;
        ///&lt;/body&gt;
        ///&lt;/html&gt;.
        /// </summary>
        internal static string customMessageWithDriveLink {
            get {
                return ResourceManager.GetString("customMessageWithDriveLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;a href=&quot;&quot;{0}&quot;&quot; class=&quot;&quot;drive-link&quot;&quot;&gt;{1}&lt;/a&gt;.
        /// </summary>
        internal static string DriveLinkHtml {
            get {
                return ResourceManager.GetString("DriveLinkHtml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://drive.google.com/file/d/{0}/view?usp=sharing.
        /// </summary>
        internal static string DriveShareLink {
            get {
                return ResourceManager.GetString("DriveShareLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ErrorImage {
            get {
                object obj = ResourceManager.GetObject("ErrorImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap HidePasswordIcon {
            get {
                object obj = ResourceManager.GetObject("HidePasswordIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Loading_Loop {
            get {
                object obj = ResourceManager.GetObject("Loading_Loop", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Loading_Loop_2 {
            get {
                object obj = ResourceManager.GetObject("Loading_Loop_2", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Loading_Loop_3 {
            get {
                object obj = ResourceManager.GetObject("Loading_Loop_3", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Logout {
            get {
                object obj = ResourceManager.GetObject("Logout", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!Doctype html&gt;
        ///&lt;html&gt;
        ///    &lt;head&gt;
        ///        &lt;link rel=&quot;stylesheet&quot; href=&quot;https://sppbc.herbivore.site/manager/css/emails.css&quot;&gt;
        ///    &lt;/head&gt;
        ///    &lt;body&gt;
        ///        &lt;p&gt;Blessings To You {0},&lt;/p&gt;
        ///
        ///		&lt;p&gt;Welcome to the St. Paul Primitive Baptist Church Email Listening Ministry. Thank you for becoming a Subscriber. You will receive Sunday&apos;s Messages from the St. Paul Primitive Baptist Church, Austin, TX. Morning Service each week; where Elder Bryon K. Miller is the Pastor. You will Receive your Sunday Morning Mes [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string newListener {
            get {
                return ResourceManager.GetString("newListener", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///    &lt;head&gt;
        ///        &lt;link rel=&quot;stylesheet&quot; href=&quot;https://sppbc.hopto.org/css/emails.css&quot; /&gt;
        ///    &lt;/head&gt;
        ///    &lt;body&gt;
        ///        &lt;p&gt;Good Afternoon {0},&lt;/p&gt;
        ///
        ///        &lt;p&gt;&lt;em&gt;Watch all our sermons on &lt;a href=&quot;https://www.youtube.com/channel/UCJ2c3QAAYu2KneiTvjRJEKg/videos&quot;&gt;YouTube&lt;/a&gt; and subscribe for easier access.&lt;/em&gt;&lt;/p&gt;
        ///        &lt;p&gt;Also, give us a follow on &lt;a href=&quot;https://facebook.com/bryon.miller436&quot;&gt;Facebook&lt;/a&gt;, where we host our weekly live streams&lt;/p&gt;
        ///        &lt;p&gt;You may gi [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string newSermon {
            get {
                return ResourceManager.GetString("newSermon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^(?:(?:\+?1\s*(?:[.-]\s*)?)?(?:\(\s*([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9])\s*\)|([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]))\s*(?:[.-]\s*)?)?([2-9]1[02-9]|[2-9][02-9]1|[2-9][02-9]{2})\s*(?:[.-]\s*)?([0-9]{4})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$.
        /// </summary>
        internal static string PhoneRegex {
            get {
                return ResourceManager.GetString("PhoneRegex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!Doctype html&gt;
        ///&lt;html&gt;
        ///    &lt;head&gt;
        ///        &lt;link rel=&quot;stylesheet&quot; href=&quot;https://sppbc.herbivore.site/manager/css/emails.css&quot;&gt;
        ///    &lt;/head&gt;
        ///    &lt;body&gt;
        ///
        ///	&lt;p&gt;Greetings {0},&lt;/p&gt;
        ///
        ///        &lt;p&gt;Thank you for your blessing of {1:C} for {2}.&lt;/p&gt;
        ///
        ///		&lt;p&gt;Thank You For Your Support.&lt;/p&gt;
        ///
        ///		&lt;p&gt;Be Blessed.&lt;/p&gt;
        ///
        ///		&lt;p class=&quot;center&quot;&gt;&lt;strong&gt;WE LOVE YOU AND AIN&apos;T NOTHING YOU CAN DO ABOUT IT!&lt;/strong&gt;&lt;br&gt;&lt;/p&gt;
        ///
        ///		&lt;hr&gt;
        ///		
        ///		&lt;p&gt;&lt;strong&gt;Elder Bryon K Miller, Pastor&lt;/strong&gt;&lt;br&gt;
        ///		St. Paul Primitive Baptist Church [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string receipt {
            get {
                return ResourceManager.GetString("receipt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ShowPasswordIcon {
            get {
                object obj = ResourceManager.GetObject("ShowPasswordIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
