namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
    public partial class CartaPorteMercanciasTransporteMaritimoContenedor {

        private string matriculaContenedorField;

        private string tipoContenedorField; //c_ContenedorMaritimo

        private string numPrecintoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MatriculaContenedor {
            get {
                return this.matriculaContenedorField;
            }
            set {
                this.matriculaContenedorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoContenedor {
            get {
                return this.tipoContenedorField;
            }
            set {
                this.tipoContenedorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumPrecinto {
            get {
                return this.numPrecintoField;
            }
            set {
                this.numPrecintoField = value;
            }
        }
    }
}