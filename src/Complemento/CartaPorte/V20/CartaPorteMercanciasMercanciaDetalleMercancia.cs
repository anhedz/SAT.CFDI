namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V20 {
    /// <summary>
    /// Nodo condicional para registrar especificaciones de los bienes y/o mercancías que se trasladan a través de los distintos medios de transporte.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteMercanciasMercanciaDetalleMercancia {

        private string unidadPesoMercField; //c_ClaveUnidadPeso

        private decimal pesoBrutoField;

        private decimal pesoNetoField;

        private decimal pesoTaraField;

        private int numPiezasField;

        private bool numPiezasFieldSpecified;

        /// <summary>
        /// Atributo requerido para registrar la clave de la unidad de medida estandarizada del peso de los bienes y/o mercancías que se trasladan en los distintos medios de transporte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnidadPesoMerc {
            get {
                return this.unidadPesoMercField;
            }
            set {
                this.unidadPesoMercField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para registrar el peso bruto total de los bienes y/o mercancías que se trasladan a través de los diferentes medios de transporte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PesoBruto {
            get {
                return this.pesoBrutoField;
            }
            set {
                this.pesoBrutoField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para registrar el peso neto total de los bienes y/o mercancías que se trasladan en los distintos  medios de transporte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PesoNeto {
            get {
                return this.pesoNetoField;
            }
            set {
                this.pesoNetoField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para registrar el peso bruto, menos el peso neto de los bienes y/o mercancías que se trasladan a través de los distintos medios de transporte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PesoTara {
            get {
                return this.pesoTaraField;
            }
            set {
                this.pesoTaraField = value;
            }
        }

        /// <summary>
        /// Atributo opcional para registrar el número de piezas de los bienes y/o mercancías que se trasladan en los distintos medios de transporte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int NumPiezas {
            get {
                return this.numPiezasField;
            }
            set {
                this.numPiezasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumPiezasSpecified {
            get {
                return this.numPiezasFieldSpecified;
            }
            set {
                this.numPiezasFieldSpecified = value;
            }
        }
    }
}