namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/ComercioExterior11")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/ComercioExterior11", IsNullable = false)]
    public partial class ComercioExterior {

        private ComercioExteriorEmisor emisorField;

        private ComercioExteriorPropietario[] propietarioField;

        private ComercioExteriorReceptor receptorField;

        private ComercioExteriorDestinatario[] destinatarioField;

        private ComercioExteriorMercancia[] mercanciasField;

        private string versionField;

        private string motivoTrasladoField; //c_MotivoTraslado

        private bool motivoTrasladoFieldSpecified;

        private string tipoOperacionField; //c_TipoOperacion

        private string claveDePedimentoField; //c_ClavePedimento

        private bool claveDePedimentoFieldSpecified;

        private int certificadoOrigenField;

        private bool certificadoOrigenFieldSpecified;

        private string numCertificadoOrigenField;

        private string numeroExportadorConfiableField;

        private string incotermField; //c_INCOTERM

        private bool incotermFieldSpecified;

        private int subdivisionField;

        private bool subdivisionFieldSpecified;

        private string observacionesField;

        private decimal tipoCambioUSDField;

        private bool tipoCambioUSDFieldSpecified;

        private decimal totalUSDField;

        private bool totalUSDFieldSpecified;

        public ComercioExterior() {
            this.versionField = "1.1";
        }

        /// <remarks/>
        public ComercioExteriorEmisor Emisor {
            get {
                return this.emisorField;
            }
            set {
                this.emisorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Propietario")]
        public ComercioExteriorPropietario[] Propietario {
            get {
                return this.propietarioField;
            }
            set {
                this.propietarioField = value;
            }
        }

        /// <remarks/>
        public ComercioExteriorReceptor Receptor {
            get {
                return this.receptorField;
            }
            set {
                this.receptorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Destinatario")]
        public ComercioExteriorDestinatario[] Destinatario {
            get {
                return this.destinatarioField;
            }
            set {
                this.destinatarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Mercancia", IsNullable = false)]
        public ComercioExteriorMercancia[] Mercancias {
            get {
                return this.mercanciasField;
            }
            set {
                this.mercanciasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MotivoTraslado {
            get {
                return this.motivoTrasladoField;
            }
            set {
                this.motivoTrasladoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MotivoTrasladoSpecified {
            get {
                return this.motivoTrasladoFieldSpecified;
            }
            set {
                this.motivoTrasladoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoOperacion {
            get {
                return this.tipoOperacionField;
            }
            set {
                this.tipoOperacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaveDePedimento {
            get {
                return this.claveDePedimentoField;
            }
            set {
                this.claveDePedimentoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ClaveDePedimentoSpecified {
            get {
                return this.claveDePedimentoFieldSpecified;
            }
            set {
                this.claveDePedimentoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int CertificadoOrigen {
            get {
                return this.certificadoOrigenField;
            }
            set {
                this.certificadoOrigenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CertificadoOrigenSpecified {
            get {
                return this.certificadoOrigenFieldSpecified;
            }
            set {
                this.certificadoOrigenFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumCertificadoOrigen {
            get {
                return this.numCertificadoOrigenField;
            }
            set {
                this.numCertificadoOrigenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumeroExportadorConfiable {
            get {
                return this.numeroExportadorConfiableField;
            }
            set {
                this.numeroExportadorConfiableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Incoterm {
            get {
                return this.incotermField;
            }
            set {
                this.incotermField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncotermSpecified {
            get {
                return this.incotermFieldSpecified;
            }
            set {
                this.incotermFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Subdivision {
            get {
                return this.subdivisionField;
            }
            set {
                this.subdivisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SubdivisionSpecified {
            get {
                return this.subdivisionFieldSpecified;
            }
            set {
                this.subdivisionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Observaciones {
            get {
                return this.observacionesField;
            }
            set {
                this.observacionesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TipoCambioUSD {
            get {
                return this.tipoCambioUSDField;
            }
            set {
                this.tipoCambioUSDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TipoCambioUSDSpecified {
            get {
                return this.tipoCambioUSDFieldSpecified;
            }
            set {
                this.tipoCambioUSDFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalUSD {
            get {
                return this.totalUSDField;
            }
            set {
                this.totalUSDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalUSDSpecified {
            get {
                return this.totalUSDFieldSpecified;
            }
            set {
                this.totalUSDFieldSpecified = value;
            }
        }
    }
}