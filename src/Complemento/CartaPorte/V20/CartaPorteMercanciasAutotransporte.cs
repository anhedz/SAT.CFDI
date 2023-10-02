namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V20 {
    /// <summary>
    /// Nodo condicional para registrar la información que permita la identificación del autotransporte de carga, por medio del cual se trasladan los bienes y/o mercancías, que transitan a través de las carreteras del territorio nacional.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteMercanciasAutotransporte {
        private CartaPorteMercanciasAutotransporteIdentificacionVehicular identificacionVehicularField;
        private CartaPorteMercanciasAutotransporteSeguros segurosField;
        private CartaPorteMercanciasAutotransporteRemolque[] remolquesField;
        private string permSCTField; //c_TipoPermiso
        private string numPermisoSCTField;

        /// <summary>
        /// Nodo requerido para registrar los datos de identificación del autotransporte en el que se trasladan los bienes y/o mercancías.
        /// </summary>
        public CartaPorteMercanciasAutotransporteIdentificacionVehicular IdentificacionVehicular {
            get {
                return this.identificacionVehicularField;
            }
            set {
                this.identificacionVehicularField = value;
            }
        }

        /// <remarks/>
        public CartaPorteMercanciasAutotransporteSeguros Seguros {
            get {
                return this.segurosField;
            }
            set {
                this.segurosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Remolque", IsNullable = false)]
        public CartaPorteMercanciasAutotransporteRemolque[] Remolques {
            get {
                return this.remolquesField;
            }
            set {
                this.remolquesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PermSCT {
            get {
                return this.permSCTField;
            }
            set {
                this.permSCTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumPermisoSCT {
            get {
                return this.numPermisoSCTField;
            }
            set {
                this.numPermisoSCTField = value;
            }
        }
    }
}