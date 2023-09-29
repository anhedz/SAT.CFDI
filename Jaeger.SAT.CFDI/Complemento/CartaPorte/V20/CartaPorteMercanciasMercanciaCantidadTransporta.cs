namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V20 {
    /// <summary>
    /// Nodo opcional para registrar la cantidad de los bienes y/o mercancías que se trasladan a través de los distintos medios de transporte, que será captada o distribuida en distintos puntos, a fin de identificar el punto de origen y destino correspondiente.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteMercanciasMercanciaCantidadTransporta {

        private decimal cantidadField;

        private string iDOrigenField;

        private string iDDestinoField;

        private string cvesTransporteField; //c_CveTransporte

        private bool cvesTransporteFieldSpecified;

        /// <summary>
        /// Atributo requerido para expresar el número de bienes y/o mercancías que se trasladan en los distintos medios de transporte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Cantidad {
            get {
                return this.cantidadField;
            }
            set {
                this.cantidadField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar la clave del identificador del origen de los bienes y/o mercancías que se trasladan por los distintos medios de transporte, de acuerdo al valor registrado en el atributo 
        /// “IDUbicacion”, del nodo “Ubicacion”.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IDOrigen {
            get {
                return this.iDOrigenField;
            }
            set {
                this.iDOrigenField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para registrar la clave del identificador del destino de los bienes y/o mercancías que se trasladan a través de los distintos medios de transporte, de acuerdo al valor registrado en el atributo “IDUbicacion”, del nodo “Ubicacion”.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IDDestino {
            get {
                return this.iDDestinoField;
            }
            set {
                this.iDDestinoField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para indicar la clave a través de la cual se identifica el medio por el que se transportan los bienes y/o mercancías.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CvesTransporte {
            get {
                return this.cvesTransporteField;
            }
            set {
                this.cvesTransporteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CvesTransporteSpecified {
            get {
                return this.cvesTransporteFieldSpecified;
            }
            set {
                this.cvesTransporteFieldSpecified = value;
            }
        }
    }
}