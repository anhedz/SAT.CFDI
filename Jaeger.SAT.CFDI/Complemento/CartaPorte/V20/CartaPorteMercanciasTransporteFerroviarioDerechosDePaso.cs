namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V20 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteMercanciasTransporteFerroviarioDerechosDePaso {

        private string tipoDerechoDePasoField; // c_DerechosDePaso

        private decimal kilometrajePagadoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoDerechoDePaso {
            get {
                return this.tipoDerechoDePasoField;
            }
            set {
                this.tipoDerechoDePasoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal KilometrajePagado {
            get {
                return this.kilometrajePagadoField;
            }
            set {
                this.kilometrajePagadoField = value;
            }
        }
    }
}