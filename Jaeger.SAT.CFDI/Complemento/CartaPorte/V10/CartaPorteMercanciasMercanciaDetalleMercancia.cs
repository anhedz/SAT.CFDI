namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
    public partial class CartaPorteMercanciasMercanciaDetalleMercancia {

        private string unidadPesoField;//c_ClaveUnidadPeso

        private decimal pesoBrutoField;

        private decimal pesoNetoField;

        private decimal pesoTaraField;

        private int numPiezasField;

        private bool numPiezasFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnidadPeso {
            get {
                return this.unidadPesoField;
            }
            set {
                this.unidadPesoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PesoBruto {
            get {
                return this.pesoBrutoField;
            }
            set {
                this.pesoBrutoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PesoNeto {
            get {
                return this.pesoNetoField;
            }
            set {
                this.pesoNetoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PesoTara {
            get {
                return this.pesoTaraField;
            }
            set {
                this.pesoTaraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int NumPiezas {
            get {
                return this.numPiezasField;
            }
            set {
                this.numPiezasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumPiezasSpecified {
            get {
                return this.numPiezasFieldSpecified;
            }
            set {
                this.numPiezasFieldSpecified = value;
            }
        }
    }
}