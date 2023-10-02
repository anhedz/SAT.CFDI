namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
    public partial class CartaPorteMercanciasAutotransporteFederalIdentificacionVehicular {

        private c_ConfigAutotransporte configVehicularField;

        private string placaVMField;

        private int anioModeloVMField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_ConfigAutotransporte ConfigVehicular {
            get {
                return this.configVehicularField;
            }
            set {
                this.configVehicularField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PlacaVM {
            get {
                return this.placaVMField;
            }
            set {
                this.placaVMField = value;
            }
        }

        /// <remarks/>
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