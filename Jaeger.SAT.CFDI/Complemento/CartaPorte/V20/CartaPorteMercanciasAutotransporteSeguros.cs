namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V20 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteMercanciasAutotransporteSeguros {

        private string aseguraRespCivilField;

        private string polizaRespCivilField;

        private string aseguraMedAmbienteField;

        private string polizaMedAmbienteField;

        private string aseguraCargaField;

        private string polizaCargaField;

        private decimal primaSeguroField;

        private bool primaSeguroFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AseguraRespCivil {
            get {
                return this.aseguraRespCivilField;
            }
            set {
                this.aseguraRespCivilField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PolizaRespCivil {
            get {
                return this.polizaRespCivilField;
            }
            set {
                this.polizaRespCivilField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AseguraMedAmbiente {
            get {
                return this.aseguraMedAmbienteField;
            }
            set {
                this.aseguraMedAmbienteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PolizaMedAmbiente {
            get {
                return this.polizaMedAmbienteField;
            }
            set {
                this.polizaMedAmbienteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AseguraCarga {
            get {
                return this.aseguraCargaField;
            }
            set {
                this.aseguraCargaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PolizaCarga {
            get {
                return this.polizaCargaField;
            }
            set {
                this.polizaCargaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PrimaSeguro {
            get {
                return this.primaSeguroField;
            }
            set {
                this.primaSeguroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrimaSeguroSpecified {
            get {
                return this.primaSeguroFieldSpecified;
            }
            set {
                this.primaSeguroFieldSpecified = value;
            }
        }
    }
}