namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
    public partial class CartaPorteFiguraTransporteNotificado {

        private CartaPorteFiguraTransporteNotificadoDomicilio domicilioField;

        private string rFCNotificadoField;

        private string nombreNotificadoField;

        private string numRegIdTribNotificadoField;

        private string residenciaFiscalNotificadoField; //c_Pais

        private bool residenciaFiscalNotificadoFieldSpecified;

        /// <remarks/>
        public CartaPorteFiguraTransporteNotificadoDomicilio Domicilio {
            get {
                return this.domicilioField;
            }
            set {
                this.domicilioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RFCNotificado {
            get {
                return this.rFCNotificadoField;
            }
            set {
                this.rFCNotificadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NombreNotificado {
            get {
                return this.nombreNotificadoField;
            }
            set {
                this.nombreNotificadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumRegIdTribNotificado {
            get {
                return this.numRegIdTribNotificadoField;
            }
            set {
                this.numRegIdTribNotificadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResidenciaFiscalNotificado {
            get {
                return this.residenciaFiscalNotificadoField;
            }
            set {
                this.residenciaFiscalNotificadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResidenciaFiscalNotificadoSpecified {
            get {
                return this.residenciaFiscalNotificadoFieldSpecified;
            }
            set {
                this.residenciaFiscalNotificadoFieldSpecified = value;
            }
        }
    }
}