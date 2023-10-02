namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
    public partial class CartaPorteFiguraTransportePropietario {

        private CartaPorteFiguraTransportePropietarioDomicilio domicilioField;

        private string rFCPropietarioField;

        private string nombrePropietarioField;

        private string numRegIdTribPropietarioField;

        private string residenciaFiscalPropietarioField; //c_Pais

        private bool residenciaFiscalPropietarioFieldSpecified;

        /// <remarks/>
        public CartaPorteFiguraTransportePropietarioDomicilio Domicilio {
            get {
                return this.domicilioField;
            }
            set {
                this.domicilioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RFCPropietario {
            get {
                return this.rFCPropietarioField;
            }
            set {
                this.rFCPropietarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NombrePropietario {
            get {
                return this.nombrePropietarioField;
            }
            set {
                this.nombrePropietarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumRegIdTribPropietario {
            get {
                return this.numRegIdTribPropietarioField;
            }
            set {
                this.numRegIdTribPropietarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResidenciaFiscalPropietario {
            get {
                return this.residenciaFiscalPropietarioField;
            }
            set {
                this.residenciaFiscalPropietarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResidenciaFiscalPropietarioSpecified {
            get {
                return this.residenciaFiscalPropietarioFieldSpecified;
            }
            set {
                this.residenciaFiscalPropietarioFieldSpecified = value;
            }
        }
    }
}