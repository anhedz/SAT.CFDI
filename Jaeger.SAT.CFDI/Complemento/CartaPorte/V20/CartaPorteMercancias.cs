namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V20 {
    /// <summary>
    /// Nodo requerido para registrar la información de los bienes y/o mercancías que se trasladan en los distintos medios de transporte.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteMercancias {

        private CartaPorteMercanciasMercancia[] mercanciaField;

        private CartaPorteMercanciasAutotransporte autotransporteField;

        private CartaPorteMercanciasTransporteMaritimo transporteMaritimoField;

        private CartaPorteMercanciasTransporteAereo transporteAereoField;

        private CartaPorteMercanciasTransporteFerroviario transporteFerroviarioField;

        private decimal pesoBrutoTotalField;

        private string unidadPesoField; //c_ClaveUnidadPeso

        private decimal pesoNetoTotalField;

        private bool pesoNetoTotalFieldSpecified;

        private int numTotalMercanciasField;

        private decimal cargoPorTasacionField;

        private bool cargoPorTasacionFieldSpecified;

        /// <summary>
        /// Nodo requerido para registrar detalladamente la información de los bienes y/o mercancías que se trasladan en los distintos medios de transporte
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Mercancia")]
        public CartaPorteMercanciasMercancia[] Mercancia {
            get {
                return this.mercanciaField;
            }
            set {
                this.mercanciaField = value;
            }
        }

        /// <summary>
        /// Nodo condicional para registrar la información que permita la identificación del autotransporte de carga, por medio del cual se trasladan los bienes y/o mercancías, que transitan a través de las carreteras del territorio nacional.
        /// </summary>
        public CartaPorteMercanciasAutotransporte Autotransporte {
            get {
                return this.autotransporteField;
            }
            set {
                this.autotransporteField = value;
            }
        }

        /// <summary>
        /// Nodo condicional para registrar la información que permita la identificación de la embarcación a través de la cual se trasladan los bienes y/o mercancías por vía marítima.
        /// </summary>
        public CartaPorteMercanciasTransporteMaritimo TransporteMaritimo {
            get {
                return this.transporteMaritimoField;
            }
            set {
                this.transporteMaritimoField = value;
            }
        }

        /// <summary>
        /// Nodo condicional para registrar la información que permita la identificación del transporte aéreo por medio del cual se trasladan los bienes y/o mercancías.
        /// </summary>
        public CartaPorteMercanciasTransporteAereo TransporteAereo {
            get {
                return this.transporteAereoField;
            }
            set {
                this.transporteAereoField = value;
            }
        }

        /// <summary>
        /// Nodo condicional para registrar la información que permita la identificación del carro o contenedor en el que se trasladan los bienes y/o mercancías por vía férrea.
        /// </summary>
        public CartaPorteMercanciasTransporteFerroviario TransporteFerroviario {
            get {
                return this.transporteFerroviarioField;
            }
            set {
                this.transporteFerroviarioField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para registrar la suma del peso bruto total estimado de los bienes y/o mercancías que se trasladan en los distintos medios de transporte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PesoBrutoTotal {
            get {
                return this.pesoBrutoTotalField;
            }
            set {
                this.pesoBrutoTotalField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para registrar la clave de la unidad de medida estandarizada del peso de los bienes y/o mercancías que se trasladan a través de los distintos medios de transporte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnidadPeso {
            get {
                return this.unidadPesoField;
            }
            set {
                this.unidadPesoField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para registrar la suma de los valores indicados en el atributo “PesoNeto” del nodo “DetalleMercancia”.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PesoNetoTotal {
            get {
                return this.pesoNetoTotalField;
            }
            set {
                this.pesoNetoTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PesoNetoTotalSpecified {
            get {
                return this.pesoNetoTotalFieldSpecified;
            }
            set {
                this.pesoNetoTotalFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo requerido para registrar el número total de los bienes y/o mercancías que se trasladan en los distintos medios de transporte, identificándose por cada nodo "Mercancia" registrado en el complemento.</xs:documentation>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int NumTotalMercancias {
            get {
                return this.numTotalMercanciasField;
            }
            set {
                this.numTotalMercanciasField = value;
            }
        }

        /// <summary>
        /// Atributo opcional para expresar el monto del importe pagado por la tasación de los bienes y/o mercancías que se trasladan vía aérea.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal CargoPorTasacion {
            get {
                return this.cargoPorTasacionField;
            }
            set {
                this.cargoPorTasacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CargoPorTasacionSpecified {
            get {
                return this.cargoPorTasacionFieldSpecified;
            }
            set {
                this.cargoPorTasacionFieldSpecified = value;
            }
        }
    }
}