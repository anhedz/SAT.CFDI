namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
    public partial class CartaPorteMercanciasAutotransporteFederalRemolque {

        private string subTipoRemField; //c_SubTipoRem

        private string placaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubTipoRem { 
            get {
                return this.subTipoRemField;
            }
            set {
                this.subTipoRemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Placa {
            get {
                return this.placaField;
            }
            set {
                this.placaField = value;
            }
        }
    }
}