﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Code52.i18n.MVCFour.Sample.CSharp.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Books {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Books() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Code52.i18n.MVCFour.Sample.CSharp.Resources.Books", typeof(Books).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Author.
        /// </summary>
        public static string Book_Author {
            get {
                return ResourceManager.GetString("Book_Author", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Author field is required.
        /// </summary>
        public static string Book_Author_Required {
            get {
                return ResourceManager.GetString("Book_Author_Required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Title.
        /// </summary>
        public static string Book_Title {
            get {
                return ResourceManager.GetString("Book_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Title field is required.
        /// </summary>
        public static string Book_Title_Required {
            get {
                return ResourceManager.GetString("Book_Title_Required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Book.
        /// </summary>
        public static string Books_Book {
            get {
                return ResourceManager.GetString("Books_Book", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Books.
        /// </summary>
        public static string Books_Books {
            get {
                return ResourceManager.GetString("Books_Books", resourceCulture);
            }
        }
    }
}
