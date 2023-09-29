namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V20 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteMercanciasTransporteFerroviarioCarro {

        private CartaPorteMercanciasTransporteFerroviarioCarroContenedor[] contenedorField;

        private string tipoCarroField; //c_TipoCarro

        private string matriculaCarroField;

        private string guiaCarroField;

        private decimal toneladasNetasCarroField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Contenedor")]
        public CartaPorteMercanciasTransporteFerroviarioCarroContenedor[] Contenedor {
            get {
                return this.contenedorField;
            }
            set {
                this.contenedorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoCarro {
            get {
                return this.tipoCarroField;
            }
            set {
                this.tipoCarroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MatriculaCarro {
            get {
                return this.matriculaCarroField;
            }
            set {
                this.matriculaCarroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GuiaCarro {
            get {
                return this.guiaCarroField;
            }
            set {
                this.guiaCarroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ToneladasNetasCarro {
            get {
                return this.toneladasNetasCarroField;
            }
            set {
                this.toneladasNetasCarroField = value;
            }
        }
    }
}