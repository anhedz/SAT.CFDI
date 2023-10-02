namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <summary>
    /// Nodo requerido para registrar la ubicación que sirve para reflejar el domicilio del origen y/o destino parcial o final que tienen los bienes o mercancías que se trasladan por distintos medios de transporte.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
    public partial class CartaPorteUbicacion {

        private CartaPorteUbicacionOrigen origenField;

        private CartaPorteUbicacionDestino destinoField;

        private CartaPorteUbicacionDomicilio domicilioField;

        private c_TipoEstacion tipoEstacionField;

        private bool tipoEstacionFieldSpecified;

        private decimal distanciaRecorridaField;

        private bool distanciaRecorridaFieldSpecified;

        /// <summary>
        /// odo condicional para registrar la información detallada del Origen de los bienes o mercancías que se trasladan.
        /// </summary>
        public CartaPorteUbicacionOrigen Origen {
            get {
                return this.origenField;
            }
            set {
                this.origenField = value;
            }
        }

        /// <summary>
        /// Nodo condicional para registrar la información detallada del Destino de los bienes o mercancías que se trasladan.
        /// </summary>
        public CartaPorteUbicacionDestino Destino {
            get {
                return this.destinoField;
            }
            set {
                this.destinoField = value;
            }
        }

        /// <summary>
        /// Nodo condicional para registrar información del domicilio de origen y/o destino de los bienes o mercancías que se trasladan en los distintos medios de transporte
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
        /// Atributo condicional para precisar el tipo de estación por el que pasan los bienes o mercancías durante su traslado en los distintos medios de transporte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_TipoEstacion TipoEstacion {
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
        /// Atributo condicional para registrar la distancia recorrida en kilómetros de la ubicación de Origen a la de Destino parcial o final, de los distintos medios de transporte que trasladan los bienes o mercancías.
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