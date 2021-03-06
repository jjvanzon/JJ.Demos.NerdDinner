﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NerdDinner.Resources {
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
    public class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NerdDinner.Resources.Messages", typeof(Messages).Assembly);
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
        ///   Looks up a localized string similar to {0} cannot be below {1}..
        /// </summary>
        public static string CannotBeBelow {
            get {
                return ResourceManager.GetString("CannotBeBelow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} must be above {1}..
        /// </summary>
        public static string MustBeAbove {
            get {
                return ResourceManager.GetString("MustBeAbove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} must be at least {1}..
        /// </summary>
        public static string MustBeAtLeast {
            get {
                return ResourceManager.GetString("MustBeAtLeast", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} must be below {1}..
        /// </summary>
        public static string MustBeBelow {
            get {
                return ResourceManager.GetString("MustBeBelow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry - but only the host of the dinner can modify it..
        /// </summary>
        public static string OnlyHostCanModify {
            get {
                return ResourceManager.GetString("OnlyHostCanModify", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Phone number does not match country..
        /// </summary>
        public static string PhoneAndCountryDoNotMatch {
            get {
                return ResourceManager.GetString("PhoneAndCountryDoNotMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please correct the errors and try again..
        /// </summary>
        public static string PleaseCorrectErrors {
            get {
                return ResourceManager.GetString("PleaseCorrectErrors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} required..
        /// </summary>
        public static string Required {
            get {
                return ResourceManager.GetString("Required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RSVP for this event.
        /// </summary>
        public static string Rsvp {
            get {
                return ResourceManager.GetString("Rsvp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thanks - we&apos;ll see you there!.
        /// </summary>
        public static string RsvpConfirmation {
            get {
                return ResourceManager.GetString("RsvpConfirmation", resourceCulture);
            }
        }
    }
}
