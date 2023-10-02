namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V20 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteMercanciasTransporteFerroviarioCarroContenedor {

        private string tipoContenedorField; //c_Contenedor

        private decimal pesoContenedorVacioField;

        private decimal pesoNetoMercanciaField;

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
        public decimal PesoContenedorVacio {
            get {
                return this.pesoContenedorVacioField;
            }
            set {
                this.pesoContenedorVacioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PesoNetoMercancia {
            get {
                return this.pesoNetoMercanciaField;
            }
            set {
                this.pesoNetoMercanciaField = value;
            }
        }
    }
}