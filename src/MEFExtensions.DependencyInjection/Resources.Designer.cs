﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MEFExtensions.DependencyInjection {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal Resources() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MEFExtensions.DependencyInjection.Resources", typeof(Resources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
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
        ///    Looks up a localized string similar to Unable to resolve service for type &apos;{0}&apos; while attempting to activate &apos;{1}&apos;..
        /// </summary>
        public static string CannotResolveService {
            get {
                return ResourceManager.GetString("CannotResolveService", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to A suitable constructor for type &apos;{0}&apos; could not be located. Ensure the type is concrete and services are registered for all parameters of a public constructor..
        /// </summary>
        public static string NoConstructorMatch {
            get {
                return ResourceManager.GetString("NoConstructorMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to Cannot instantiate implementation type &apos;{0}&apos; for service type &apos;{1}&apos;..
        /// </summary>
        public static string TypeCannotBeActivated {
            get {
                return ResourceManager.GetString("TypeCannotBeActivated", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to No constructor for type &apos;{0}&apos; can be instantiated using services from the service container and default values..
        /// </summary>
        public static string UnableToActivateType {
            get {
                return ResourceManager.GetString("UnableToActivateType", resourceCulture);
            }
        }

        /// <summary>
        ///    Looks up a localized string similar to You can only add native MEF exports to an instance of MEFExtensions.DependencyInjection.ServiceCollection..
        /// </summary>
        public static string CannotAddNativeMefImports {
            get {
                return ResourceManager.GetString("CannotAddNativeMefImports", resourceCulture);
            }
        }
    }
}