﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace i18n {
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
    public class ValidationStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ValidationStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FACEBAND.WEB.Globalization.Shared.ValidationStrings", typeof(ValidationStrings).Assembly);
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
        ///   Looks up a localized string similar to Ingrese un email válido.
        /// </summary>
        public static string CampoEmail {
            get {
                return ResourceManager.GetString("CampoEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El campo debe tener más de {1} caracteres..
        /// </summary>
        public static string CampoLongitudMinima {
            get {
                return ResourceManager.GetString("CampoLongitudMinima", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ingrese un Número de Documento Válido.
        /// </summary>
        public static string CampoNroDocumento {
            get {
                return ResourceManager.GetString("CampoNroDocumento", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Su Contraseña es requerida.
        /// </summary>
        public static string CampoPassword {
            get {
                return ResourceManager.GetString("CampoPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Este campo es requerido.
        /// </summary>
        public static string CampoRequerido {
            get {
                return ResourceManager.GetString("CampoRequerido", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Su Usuario es requerido.
        /// </summary>
        public static string CampoUsuario {
            get {
                return ResourceManager.GetString("CampoUsuario", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Intoduzca una cantidad mayor o igual a {1}.
        /// </summary>
        public static string CampoValorPositivo {
            get {
                return ResourceManager.GetString("CampoValorPositivo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Algunos Datos son Requeridos.
        /// </summary>
        public static string DatosIncompletos {
            get {
                return ResourceManager.GetString("DatosIncompletos", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Existen Campos Incompletos.
        /// </summary>
        public static string DatosIncorrectos {
            get {
                return ResourceManager.GetString("DatosIncorrectos", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to El campo debe tener menos de {1} caracteres...
        /// </summary>
        public static string CampoLongitudMaxima
        {
            get
            {
                return ResourceManager.GetString("CampoLongitudMaxima", resourceCulture);
            }
        }
    }
}
