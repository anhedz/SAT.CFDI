namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/ComercioExterior11")]
    public partial class ComercioExteriorEmisorDomicilio {

        private string calleField;

        private string numeroExteriorField;

        private string numeroInteriorField;

        private string coloniaField; //c_Colonia

        private bool coloniaFieldSpecified;

        private string localidadField;//c_Localidad

        private bool localidadFieldSpecified;

        private string referenciaField;

        private string municipioField;//c_Municipio

        private bool municipioFieldSpecified;

        private string estadoField;//c_Estado

        private string paisField; //c_Pais

        private string codigoPostalField; //c_CodigoPostal

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Calle {
            get {
                return this.calleField;
            }
            set {
                this.calleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumeroExterior {
            get {
                return this.numeroExteriorField;
            }
            set {
                this.numeroExteriorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumeroInterior {
            get {
                return this.numeroInteriorField;
            }
            set {
                this.numeroInteriorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Colonia {
            get {
                return this.coloniaField;
            }
            set {
                this.coloniaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ColoniaSpecified {
            get {
                return this.coloniaFieldSpecified;
            }
            set {
                this.coloniaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Localidad {
            get {
                return this.localidadField;
            }
            set {
                this.localidadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LocalidadSpecified {
            get {
                return this.localidadFieldSpecified;
            }
            set {
                this.localidadFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Referencia {
            get {
                return this.referenciaField;
            }
            set {
                this.referenciaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Municipio {
            get {
                return this.municipioField;
            }
            set {
                this.municipioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MunicipioSpecified {
            get {
                return this.municipioFieldSpecified;
            }
            set {
                this.municipioFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Pais {
            get {
                return this.paisField;
            }
            set {
                this.paisField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodigoPostal {
            get {
                return this.codigoPostalField;
            }
            set {
                this.codigoPostalField = value;
            }
        }
    }
}