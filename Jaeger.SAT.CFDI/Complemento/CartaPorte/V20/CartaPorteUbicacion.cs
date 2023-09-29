namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V20 {
    /// <summary>
    /// Nodo requerido para registrar la ubicación que sirve para indicar el domicilio del origen y/o destino parcial o final, que tienen los bienes y/o mercancías que se trasladan a través de los distintos medios de transporte.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteUbicacion {

        private CartaPorteUbicacionDomicilio domicilioField;

        private string tipoUbicacionField; //CartaPorteUbicacionTipoUbicacion

        private string iDUbicacionField;

        private string rFCRemitenteDestinatarioField;

        private string nombreRemitenteDestinatarioField;

        private string numRegIdTribField;

        private string residenciaFiscalField; //c_Pais

        private bool residenciaFiscalFieldSpecified;

        private string numEstacionField; //c_Estaciones

        private bool numEstacionFieldSpecified;

        private string nombreEstacionField;

        private string navegacionTraficoField; //CartaPorteUbicacionNavegacionTrafico

        private bool navegacionTraficoFieldSpecified;

        private System.DateTime fechaHoraSalidaLlegadaField;

        private string tipoEstacionField; //c_TipoEstacion

        private bool tipoEstacionFieldSpecified;

        private decimal distanciaRecorridaField;

        private bool distanciaRecorridaFieldSpecified;

        /// <summary>
        /// Nodo condicional para registrar información del domicilio de origen y/o destino de los bienes y/o mercancías que se trasladan a través de los distintos medios de transporte.
        /// </summary>
        public CartaPorteUbicacionDomicilio Domicilio {
            get {
                return this.domicilioField;
            }
            set {
                this.domicilioField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para precisar si el tipo de ubicación corresponde al origen o destino de las ubicaciones para el traslado de los bienes y/o mercancías en los distintos medios de transporte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoUbicacion {
            get {
                return this.tipoUbicacionField;
            }
            set {
                this.tipoUbicacionField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para registrar una clave que sirva para identificar el punto de salida o entrada de los bienes y/o mercancías que se trasladan a través de los distintos medios de transporte, la cual estará integrada de la siguiente forma: para origen el acrónimo “OR” o para destino el acrónimo “DE” seguido de 6 dígitos numéricos asignados por el contribuyente que emite el comprobante para su identificación.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IDUbicacion {
            get {
                return this.iDUbicacionField;
            }
            set {
                this.iDUbicacionField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para registrar el RFC del remitente o destinatario de los bienes y/o mercancías que se trasladan a través de los distintos medios de transporte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RFCRemitenteDestinatario {
            get {
                return this.rFCRemitenteDestinatarioField;
            }
            set {
                this.rFCRemitenteDestinatarioField = value;
            }
        }

        /// <summary>
        /// Atributo opcional para registrar el nombre del remitente o destinatario de los bienes y/o mercancías que se trasladan a través de los distintos medios de transporte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NombreRemitenteDestinatario {
            get {
                return this.nombreRemitenteDestinatarioField;
            }
            set {
                this.nombreRemitenteDestinatarioField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para registrar el número de identificación o registro fiscal del país de residencia, para los efectos fiscales del remitente o destinatario de los bienes y/o mercancías que se trasladan cuando se trate de residentes en el extranjero.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumRegIdTrib {
            get {
                return this.numRegIdTribField;
            }
            set {
                this.numRegIdTribField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para registrar la clave del país de residencia para efectos fiscales del remitente o destinatario de los bienes y/o mercancías, conforme el catálogo de CFDI c_Pais publicado en el portal del SAT en Internet de acuerdo a la especificación ISO 3166-1.
        /// </summary>
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

        /// <summary>
        /// Atributo condicional para registrar la clave de la estación de origen o destino para el traslado de los bienes y/o mercancías que se realiza a través de los distintos medios de transporte, esto de acuerdo al valor de la columna
        /// “Clave identificación” del catálogo c_Estaciones del complemento Carta Porte que permita asociarla al tipo de transporte.
        /// </summary>
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

        /// <summary>
        /// Atributo condicional para registrar el nombre de la estación de origen o destino por la que se pasa para efectuar el traslado de los bienes y/o mercancías a través de los distintos medios de transporte, conforme al catálogo c_Estaciones del complemento Carta Porte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NombreEstacion {
            get {
                return this.nombreEstacionField;
            }
            set {
                this.nombreEstacionField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para registrar el tipo de puerto de origen o destino en el cual se documentan los bienes y/o mercancías que se trasladan vía marítima.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NavegacionTrafico {
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

        /// <summary>
        /// Atributo requerido para registrar la fecha y hora estimada en la que salen o llegan los bienes y/o mercancías de origen o al destino, respectivamente. Se expresa en la forma AAAA-MM-DDThh:mm:ss.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime FechaHoraSalidaLlegada {
            get {
                return this.fechaHoraSalidaLlegadaField;
            }
            set {
                this.fechaHoraSalidaLlegadaField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para registrar el tipo de estación por el que pasan los bienes y/o mercancías durante su traslado a través de los distintos medios de transporte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoEstacion {
            get {
                return this.tipoEstacionField;
            }
            set {
                this.tipoEstacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TipoEstacionSpecified {
            get {
                return this.tipoEstacionFieldSpecified;
            }
            set {
                this.tipoEstacionFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo condicional para registrar en kilómetros la distancia recorrida entre la ubicación de origen y la de destino parcial o final, por los distintos medios de transporte que trasladan los bienes y/o mercancías.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal DistanciaRecorrida {
            get {
                return this.distanciaRecorridaField;
            }
            set {
                this.distanciaRecorridaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DistanciaRecorridaSpecified {
            get {
                return this.distanciaRecorridaFieldSpecified;
            }
            set {
                this.distanciaRecorridaFieldSpecified = value;
            }
        }
    }
}