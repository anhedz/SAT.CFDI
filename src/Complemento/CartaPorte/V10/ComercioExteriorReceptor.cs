namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/ComercioExterior11")]
    public partial class ComercioExteriorReceptor {

        private ComercioExteriorReceptorDomicilio domicilioField;

        private string numRegIdTribField;

        /// <remarks/>
        public ComercioExteriorReceptorDomicilio Domicilio {
            get {
                return this.domicilioField;
            }
            set {
                this.domicilioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumRegIdTrib {
            get {
                return this.numRegIdTribField;
            }
            set {
                this.numRegIdTribField = value;
            }
        }
    }
}