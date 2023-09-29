namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V20 {
    /// <summary>
    /// Nodo condicional para registrar la información que permita la identificación del autotransporte de carga, por medio del cual se trasladan los bienes y/o mercancías, que transitan a través de las carreteras del territorio nacional.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteMercanciasAutotransporteIdentificacionVehicular {
        private string configVehicularField; //c_ConfigAutotransporte
        private string placaVMField;
        private int anioModeloVMField;

        /// <summary>
        /// Atributo requerido para expresar la clave de nomenclatura del autotransporte que es utilizado para transportar los bienes y/o mercancías.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ConfigVehicular {
            get {
                return this.configVehicularField;
            }
            set {
                this.configVehicularField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para registrar solo los caracteres alfanuméricos, sin guiones ni espacios de la placa vehicular del autotransporte que es utilizado para transportar los bienes y/o mercancías.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PlacaVM {
            get {
                return this.placaVMField;
            }
            set {
                this.placaVMField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para registrar el año del autotransporte que es utilizado para transportar los bienes y/o mercancías.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int AnioModeloVM {
            get {
                return this.anioModeloVMField;
            }
            set {
                this.anioModeloVMField = value;
            }
        }
    }
}