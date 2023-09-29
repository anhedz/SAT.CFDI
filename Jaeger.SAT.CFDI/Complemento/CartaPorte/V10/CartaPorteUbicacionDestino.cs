namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
    public partial class CartaPorteUbicacionDestino {

        private string iDDestinoField;

        private string rFCDestinatarioField;

        private string nombreDestinatarioField;

        private string numRegIdTribField;

        private string residenciaFiscalField;//c_Pais

        private bool residenciaFiscalFieldSpecified;

        private string numEstacionField; //c_Estaciones

        private bool numEstacionFieldSpecified;

        private string nombreEstacionField;

        private CartaPorteUbicacionDestinoNavegacionTrafico navegacionTraficoField;

        private bool navegacionTraficoFieldSpecified;

        private System.DateTime fechaHoraProgLlegadaField;

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
        public string RFCDestinatario {
            get {
                return this.rFCDestinatarioField;
            }
            set {
                this.rFCDestinatarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NombreDestinatario {
            get {
                return this.nombreDestinatarioField;
            }
            set {
                this.nombreDestinatarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumRegIdTrib {
            get {
                return this.numRegIdTribField;
            }
            set {
                this.numRegIdTribField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResidenciaFiscal {
            get {
                return this.residenciaFiscalField;
            }
            set {
                this.residenciaFiscalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResidenciaFiscalSpecified {
            get {
                return this.residenciaFiscalFieldSpecified;
            }
            set {
                this.residenciaFiscalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumEstacion {
            get {
                return this.numEstacionField;
            }
            set {
                this.numEstacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumEstacionSpecified {
            get {
                return this.numEstacionFieldSpecified;
            }
            set {
                this.numEstacionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NombreEstacion {
            get {
                return this.nombreEstacionField;
            }
            set {
                this.nombreEstacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CartaPorteUbicacionDestinoNavegacionTrafico NavegacionTrafico {
            get {
                return this.navegacionTraficoField;
            }
            set {
                this.navegacionTraficoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NavegacionTraficoSpecified {
            get {
                return this.navegacionTraficoFieldSpecified;
            }
            set {
                this.navegacionTraficoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime FechaHoraProgLlegada {
            get {
                return this.fechaHoraProgLlegadaField;
            }
            set {
                this.fechaHoraProgLlegadaField = value;
            }
        }
    }
}