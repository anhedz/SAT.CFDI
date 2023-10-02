namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V20 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteTiposFiguraDomicilio {

        private string calleField;

        private string numeroExteriorField;

        private string numeroInteriorField;

        private string coloniaField;

        private string localidadField;

        private string referenciaField;

        private string municipioField;

        private string estadoField;

        private string paisField; //c_Pais

        private string codigoPostalField;

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

        public override string ToString() {
            string direccion = string.Empty;

            if (!(string.IsNullOrEmpty(this.Calle)))
                direccion = string.Concat("Calle ", this.Calle);

            if (!(string.IsNullOrEmpty(this.NumeroExterior)))
                direccion = string.Concat(direccion, " No. Ext. ", this.NumeroExterior);

            if (!(string.IsNullOrEmpty(this.NumeroInterior)))
                direccion = string.Concat(direccion, " No. Int. ", this.NumeroInterior);

            if (!(string.IsNullOrEmpty(this.Colonia)))
                direccion = string.Concat(direccion, " Col. ", this.Colonia);

            if (!(string.IsNullOrEmpty(this.CodigoPostal)))
                direccion = string.Concat(direccion, " C.P. ", this.CodigoPostal);

            if (!(string.IsNullOrEmpty(this.Municipio)))
                direccion = string.Concat(direccion, " ", this.Municipio);

            if (!(string.IsNullOrEmpty(this.Estado)))
                direccion = string.Concat(direccion, ", ", this.Estado);

            if (!(string.IsNullOrEmpty(this.Referencia)))
                direccion = string.Concat(direccion, ", Ref: ", this.Referencia);

            if (!(string.IsNullOrEmpty(this.Localidad)))
                direccion = string.Concat(direccion, ", Loc: ", this.Localidad);

            return direccion;
        }
    }
}