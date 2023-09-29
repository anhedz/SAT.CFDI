namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
    public partial class CartaPorteFiguraTransporteArrendatario {

        private CartaPorteFiguraTransporteArrendatarioDomicilio domicilioField;

        private string rFCArrendatarioField;

        private string nombreArrendatarioField;

        private string numRegIdTribArrendatarioField;

        private string residenciaFiscalArrendatarioField; //c_Pais

        private bool residenciaFiscalArrendatarioFieldSpecified;

        /// <remarks/>
        public CartaPorteFiguraTransporteArrendatarioDomicilio Domicilio {
            get {
                return this.domicilioField;
            }
            set {
                this.domicilioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RFCArrendatario {
            get {
                return this.rFCArrendatarioField;
            }
            set {
                this.rFCArrendatarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NombreArrendatario {
            get {
                return this.nombreArrendatarioField;
            }
            set {
                this.nombreArrendatarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumRegIdTribArrendatario {
            get {
                return this.numRegIdTribArrendatarioField;
            }
            set {
                this.numRegIdTribArrendatarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResidenciaFiscalArrendatario {
            get {
                return this.residenciaFiscalArrendatarioField;
            }
            set {
                this.residenciaFiscalArrendatarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResidenciaFiscalArrendatarioSpecified {
            get {
                return this.residenciaFiscalArrendatarioFieldSpecified;
            }
            set {
                this.residenciaFiscalArrendatarioFieldSpecified = value;
            }
        }
    }
}