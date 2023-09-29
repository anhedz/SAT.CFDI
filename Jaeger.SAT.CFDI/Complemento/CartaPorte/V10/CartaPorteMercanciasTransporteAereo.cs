namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
    public partial class CartaPorteMercanciasTransporteAereo {

        private string permSCTField; //c_TipoPermiso

        private string numPermisoSCTField;

        private string matriculaAeronaveField;

        private string nombreAsegField;

        private string numPolizaSeguroField;

        private string numeroGuiaField;

        private string lugarContratoField;

        private string rFCTransportistaField;

        private string codigoTransportistaField; //c_CodigoTransporteAereo

        private string numRegIdTribTransporField;

        private string residenciaFiscalTransporField; //c_Pais

        private bool residenciaFiscalTransporFieldSpecified;

        private string nombreTransportistaField;

        private string rFCEmbarcadorField;

        private string numRegIdTribEmbarcField;

        private string residenciaFiscalEmbarcField; //c_Pais

        private bool residenciaFiscalEmbarcFieldSpecified;

        private string nombreEmbarcadorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PermSCT {
            get {
                return this.permSCTField;
            }
            set {
                this.permSCTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumPermisoSCT {
            get {
                return this.numPermisoSCTField;
            }
            set {
                this.numPermisoSCTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MatriculaAeronave {
            get {
                return this.matriculaAeronaveField;
            }
            set {
                this.matriculaAeronaveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NombreAseg {
            get {
                return this.nombreAsegField;
            }
            set {
                this.nombreAsegField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumPolizaSeguro {
            get {
                return this.numPolizaSeguroField;
            }
            set {
                this.numPolizaSeguroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumeroGuia {
            get {
                return this.numeroGuiaField;
            }
            set {
                this.numeroGuiaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LugarContrato {
            get {
                return this.lugarContratoField;
            }
            set {
                this.lugarContratoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RFCTransportista {
            get {
                return this.rFCTransportistaField;
            }
            set {
                this.rFCTransportistaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodigoTransportista {
            get {
                return this.codigoTransportistaField;
            }
            set {
                this.codigoTransportistaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumRegIdTribTranspor {
            get {
                return this.numRegIdTribTransporField;
            }
            set {
                this.numRegIdTribTransporField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResidenciaFiscalTranspor {
            get {
                return this.residenciaFiscalTransporField;
            }
            set {
                this.residenciaFiscalTransporField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResidenciaFiscalTransporSpecified {
            get {
                return this.residenciaFiscalTransporFieldSpecified;
            }
            set {
                this.residenciaFiscalTransporFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NombreTransportista {
            get {
                return this.nombreTransportistaField;
            }
            set {
                this.nombreTransportistaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RFCEmbarcador {
            get {
                return this.rFCEmbarcadorField;
            }
            set {
                this.rFCEmbarcadorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumRegIdTribEmbarc {
            get {
                return this.numRegIdTribEmbarcField;
            }
            set {
                this.numRegIdTribEmbarcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResidenciaFiscalEmbarc {
            get {
                return this.residenciaFiscalEmbarcField;
            }
            set {
                this.residenciaFiscalEmbarcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResidenciaFiscalEmbarcSpecified {
            get {
                return this.residenciaFiscalEmbarcFieldSpecified;
            }
            set {
                this.residenciaFiscalEmbarcFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NombreEmbarcador {
            get {
                return this.nombreEmbarcadorField;
            }
            set {
                this.nombreEmbarcadorField = value;
            }
        }
    }
}