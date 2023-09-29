namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/ComercioExterior11")]
    public partial class ComercioExteriorMercancia {

        private ComercioExteriorMercanciaDescripcionesEspecificas[] descripcionesEspecificasField;

        private string noIdentificacionField;

        private string fraccionArancelariaField;//c_FraccionArancelaria

        private bool fraccionArancelariaFieldSpecified;

        private decimal cantidadAduanaField;

        private bool cantidadAduanaFieldSpecified;

        private string unidadAduanaField;//c_UnidadAduana

        private bool unidadAduanaFieldSpecified;

        private decimal valorUnitarioAduanaField;

        private bool valorUnitarioAduanaFieldSpecified;

        private decimal valorDolaresField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DescripcionesEspecificas")]
        public ComercioExteriorMercanciaDescripcionesEspecificas[] DescripcionesEspecificas {
            get {
                return this.descripcionesEspecificasField;
            }
            set {
                this.descripcionesEspecificasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NoIdentificacion {
            get {
                return this.noIdentificacionField;
            }
            set {
                this.noIdentificacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FraccionArancelaria {
            get {
                return this.fraccionArancelariaField;
            }
            set {
                this.fraccionArancelariaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FraccionArancelariaSpecified {
            get {
                return this.fraccionArancelariaFieldSpecified;
            }
            set {
                this.fraccionArancelariaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal CantidadAduana {
            get {
                return this.cantidadAduanaField;
            }
            set {
                this.cantidadAduanaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CantidadAduanaSpecified {
            get {
                return this.cantidadAduanaFieldSpecified;
            }
            set {
                this.cantidadAduanaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnidadAduana {
            get {
                return this.unidadAduanaField;
            }
            set {
                this.unidadAduanaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnidadAduanaSpecified {
            get {
                return this.unidadAduanaFieldSpecified;
            }
            set {
                this.unidadAduanaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ValorUnitarioAduana {
            get {
                return this.valorUnitarioAduanaField;
            }
            set {
                this.valorUnitarioAduanaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorUnitarioAduanaSpecified {
            get {
                return this.valorUnitarioAduanaFieldSpecified;
            }
            set {
                this.valorUnitarioAduanaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ValorDolares {
            get {
                return this.valorDolaresField;
            }
            set {
                this.valorDolaresField = value;
            }
        }
    }
}