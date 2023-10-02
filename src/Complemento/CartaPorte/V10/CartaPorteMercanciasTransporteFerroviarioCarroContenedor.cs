namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
    public partial class CartaPorteMercanciasTransporteFerroviarioCarroContenedor {

        private c_Contenedor tipoContenedorField;

        private decimal pesoContenedorVacioField;

        private decimal pesoNetoMercanciaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_Contenedor TipoContenedor {
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