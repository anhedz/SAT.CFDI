namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V20 {
    /// <summary>
    /// Nodo condicional para indicar los datos del(los) tipo(s) de figura(s) que participan en el traslado de los bienes y/o mercancías en los distintos medios de transporte.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteTiposFigura {

        private CartaPorteTiposFiguraPartesTransporte[] partesTransporteField;

        private CartaPorteTiposFiguraDomicilio domicilioField;

        private string tipoFiguraField; //c_FiguraTransporte

        private string rFCFiguraField;

        private string numLicenciaField;

        private string nombreFiguraField;

        private string numRegIdTribFiguraField;

        private string residenciaFiscalFiguraField; //c_Pais

        private bool residenciaFiscalFiguraFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PartesTransporte")]
        public CartaPorteTiposFiguraPartesTransporte[] PartesTransporte {
            get {
                return this.partesTransporteField;
            }
            set {
                this.partesTransporteField = value;
            }
        }

        /// <remarks/>
        public CartaPorteTiposFiguraDomicilio Domicilio {
            get {
                return this.domicilioField;
            }
            set {
                this.domicilioField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para registrar la clave de la figura de transporte que interviene en el traslado de los bienes y/o mercancías.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoFigura {
            get {
                return this.tipoFiguraField;
            }
            set {
                this.tipoFiguraField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para registrar el RFC de la figura de transporte que interviene en el traslado de los bienes y/o mercancías.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RFCFigura {
            get {
                return this.rFCFiguraField;
            }
            set {
                this.rFCFiguraField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar el número de la licencia o el permiso otorgado al operador del autotransporte de carga en el que realiza el traslado de los bienes y/o mercancías.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumLicencia {
            get {
                return this.numLicenciaField;
            }
            set {
                this.numLicenciaField = value;
            }
        }

        /// <summary>
        /// Atributo opcional para registrar el nombre de la figura de transporte que interviene en el traslado de los bienes y/o mercancías.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NombreFigura {
            get {
                return this.nombreFiguraField;
            }
            set {
                this.nombreFiguraField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para registrar el número de identificación o registro fiscal del país de residencia de la figura de transporte que interviene en el traslado de los bienes y/o mercancías, cuando se trate de residentes en el extranjero para los efectos fiscales correspondientes.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumRegIdTribFigura {
            get {
                return this.numRegIdTribFiguraField;
            }
            set {
                this.numRegIdTribFiguraField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para registrar la clave del país de residencia de la figura de transporte que interviene en el traslado de los bienes y/o mercancías para los efectos fiscales correspondientes
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResidenciaFiscalFigura {
            get {
                return this.residenciaFiscalFiguraField;
            }
            set {
                this.residenciaFiscalFiguraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResidenciaFiscalFiguraSpecified {
            get {
                return this.residenciaFiscalFiguraFieldSpecified;
            }
            set {
                this.residenciaFiscalFiguraFieldSpecified = value;
            }
        }
    }
}