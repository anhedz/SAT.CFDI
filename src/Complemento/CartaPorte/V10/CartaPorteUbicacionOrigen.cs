namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <summary>
    /// Nodo condicional para registrar la información detallada del Origen de los bienes o mercancías que se trasladan
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
    public partial class CartaPorteUbicacionOrigen {

        private string iDOrigenField;

        private string rFCRemitenteField;

        private string nombreRemitenteField;

        private string numRegIdTribField;

        private string residenciaFiscalField; //c_Pais

        private bool residenciaFiscalFieldSpecified;

        private string numEstacionField; //c_Estaciones

        private bool numEstacionFieldSpecified;

        private string nombreEstacionField;

        private CartaPorteUbicacionOrigenNavegacionTrafico navegacionTraficoField;

        private bool navegacionTraficoFieldSpecified;

        private System.DateTime fechaHoraSalidaField;

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
        public string RFCRemitente {
            get {
                return this.rFCRemitenteField;
            }
            set {
                this.rFCRemitenteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NombreRemitente {
            get {
                return this.nombreRemitenteField;
            }
            set {
                this.nombreRemitenteField = value;
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
        public CartaPorteUbicacionOrigenNavegacionTrafico NavegacionTrafico {
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
        public System.DateTime FechaHoraSalida {
            get {
                return this.fechaHoraSalidaField;
            }
            set {
                this.fechaHoraSalidaField = value;
            }
        }
    }
}