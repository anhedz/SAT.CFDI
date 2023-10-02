namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
    public partial class CartaPorteMercanciasAutotransporteFederal {

        private CartaPorteMercanciasAutotransporteFederalIdentificacionVehicular identificacionVehicularField;

        private CartaPorteMercanciasAutotransporteFederalRemolque[] remolquesField;

        private string permSCTField; //c_TipoPermiso

        private string numPermisoSCTField;

        private string nombreAsegField;

        private string numPolizaSeguroField;

        /// <remarks/>
        public CartaPorteMercanciasAutotransporteFederalIdentificacionVehicular IdentificacionVehicular {
            get {
                return this.identificacionVehicularField;
            }
            set {
                this.identificacionVehicularField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Remolque", IsNullable = false)]
        public CartaPorteMercanciasAutotransporteFederalRemolque[] Remolques {
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NombreAseg {
            get {
                return this.nombreAsegField;
            }
            set {
                this.nombreAsegField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumPolizaSeguro {
            get {
                return this.numPolizaSeguroField;
            }
            set {
                this.numPolizaSeguroField = value;
            }
        }
    }
}