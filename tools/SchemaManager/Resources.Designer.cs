﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchemaManager {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SchemaManager.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Applies the specified SQL schema update to the supplied connection string for the given server..
        /// </summary>
        internal static string ApplyCommandDescription {
            get {
                return ResourceManager.GetString("ApplyCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Returns the available SQL schema versions for the given server..
        /// </summary>
        internal static string AvailableCommandDescription {
            get {
                return ResourceManager.GetString("AvailableCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The connection string of the SQL server to apply the schema update..
        /// </summary>
        internal static string ConnectionStringOptionDescription {
            get {
                return ResourceManager.GetString("ConnectionStringOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must include a connection string..
        /// </summary>
        internal static string ConnectionStringRequiredValidation {
            get {
                return ResourceManager.GetString("ConnectionStringRequiredValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Returns the current SQL schema version(s) from the given server..
        /// </summary>
        internal static string CurrentCommandDescription {
            get {
                return ResourceManager.GetString("CurrentCommandDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current version information is not available due to &quot;{0}&quot;..
        /// </summary>
        internal static string CurrentDefaultErrorDescription {
            get {
                return ResourceManager.GetString("CurrentDefaultErrorDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schema migration is run without validating the schema verison..
        /// </summary>
        internal static string ForceOptionDescription {
            get {
                return ResourceManager.GetString("ForceOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure to apply command with force option? Type &apos;yes&apos; to confirm..
        /// </summary>
        internal static string ForceWarning {
            get {
                return ResourceManager.GetString("ForceWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The versions between current version and latest available version to apply..
        /// </summary>
        internal static string LatestOptionDescription {
            get {
                return ResourceManager.GetString("LatestOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must include only one of the option from [version, next, latest]..
        /// </summary>
        internal static string MutuallyExclusiveValidation {
            get {
                return ResourceManager.GetString("MutuallyExclusiveValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The next version to apply..
        /// </summary>
        internal static string NextOptionDescritpion {
            get {
                return ResourceManager.GetString("NextOptionDescritpion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The root URL of the server to connect to..
        /// </summary>
        internal static string ServerOptionDescription {
            get {
                return ResourceManager.GetString("ServerOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must include a Server..
        /// </summary>
        internal static string ServerRequiredValidation {
            get {
                return ResourceManager.GetString("ServerRequiredValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The versions between current version and specified version to apply..
        /// </summary>
        internal static string VersionOptionDescription {
            get {
                return ResourceManager.GetString("VersionOptionDescription", resourceCulture);
            }
        }
    }
}
