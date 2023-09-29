namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
    public partial class CartaPorteMercanciasMercanciaCantidadTransporta {

        private decimal cantidadField;

        private string iDOrigenField;

        private string iDDestinoField;

        private c_CveTransporte cvesTransporteField;

        private bool cvesTransporteFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Cantidad {
            get {
                return this.cantidadField;
            }
            set {
                this.cantidadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IDOrigen {
            get {
                return this.iDOrigenField;
            }
            set {
                this.iDOrigenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IDDestino {
            get {
                return this.iDDestinoField;
            }
            set {
                this.iDDestinoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_CveTransporte CvesTransporte {
            get {
                return this.cvesTransporteField;
            }
            set {
                this.cvesTransporteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CvesTransporteSpecified {
            get {
                return this.cvesTransporteFieldSpecified;
            }
            set {
                this.cvesTransporteFieldSpecified = value;
            }
        }
    }
}