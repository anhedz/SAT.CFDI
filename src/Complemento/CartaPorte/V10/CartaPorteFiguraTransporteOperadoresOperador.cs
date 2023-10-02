namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
    public partial class CartaPorteFiguraTransporteOperadoresOperador {

        private CartaPorteFiguraTransporteOperadoresOperadorDomicilio domicilioField;

        private string rFCOperadorField;

        private string numLicenciaField;

        private string nombreOperadorField;

        private string numRegIdTribOperadorField;

        private string residenciaFiscalOperadorField; //c_Pais

        private bool residenciaFiscalOperadorFieldSpecified;

        /// <remarks/>
        public CartaPorteFiguraTransporteOperadoresOperadorDomicilio Domicilio {
            get {
                return this.domicilioField;
            }
            set {
                this.domicilioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RFCOperador {
            get {
                return this.rFCOperadorField;
            }
            set {
                this.rFCOperadorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumLicencia {
            get {
                return this.numLicenciaField;
            }
            set {
                this.numLicenciaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NombreOperador {
            get {
                return this.nombreOperadorField;
            }
            set {
                this.nombreOperadorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumRegIdTribOperador {
            get {
                return this.numRegIdTribOperadorField;
            }
            set {
                this.numRegIdTribOperadorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResidenciaFiscalOperador {
            get {
                return this.residenciaFiscalOperadorField;
            }
            set {
                this.residenciaFiscalOperadorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResidenciaFiscalOperadorSpecified {
            get {
                return this.residenciaFiscalOperadorFieldSpecified;
            }
            set {
                this.residenciaFiscalOperadorFieldSpecified = value;
            }
        }
    }
}