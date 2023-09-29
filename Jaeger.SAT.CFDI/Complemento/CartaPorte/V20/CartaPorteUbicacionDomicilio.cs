namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V20 {
    /// <summary>
    /// Nodo condicional para registrar información del domicilio de origen y/o destino de los bienes y/o mercancías que se trasladan a través de los distintos medios de transporte.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteUbicacionDomicilio {

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

        /// <summary>
        /// Atributo opcional para registrar la calle en la que está ubicado el domicilio de origen y/o destino de los bienes y/o mercancías que se trasladan en los distintos medios de transporte
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Calle {
            get {
                return this.calleField;
            }
            set {
                this.calleField = value;
            }
        }

        /// <summary>
        /// Atributo opcional que sirve para registrar el número exterior del domicilio de origen y/o destino de los bienes y/o mercancías que se trasladan en los distintos medios del transporte
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumeroExterior {
            get {
                return this.numeroExteriorField;
            }
            set {
                this.numeroExteriorField = value;
            }
        }

        /// <summary>
        /// Atributo opcional que sirve para registrar el número interior, en caso de existir, del domicilio de origen y/o destino de los bienes y/o mercancías que se trasladan en los distintos medios de transporte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumeroInterior {
            get {
                return this.numeroInteriorField;
            }
            set {
                this.numeroInteriorField = value;
            }
        }

        /// <summary>
        /// Atributo opcional que sirve para registrar la clave de la colonia o dato análogo, del domicilio de origen y/o destino de los bienes y/o mercancías que se trasladan en los distintos medios de transporte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Colonia {
            get {
                return this.coloniaField;
            }
            set {
                this.coloniaField = value;
            }
        }

        /// <summary>
        /// Atributo opcional que sirve para registrar la ciudad, población, o dato análogo del domicilio de origen y/o destino de los bienes y/o mercancías que se trasladan en los distintos medios de transporte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Localidad {
            get {
                return this.localidadField;
            }
            set {
                this.localidadField = value;
            }
        }

        /// <summary>
        /// Atributo opcional para registrar una referencia geográfica adicional que permita una fácil o precisa ubicación del domicilio de origen y/o destino de los bienes y/o mercancías que se trasladan en los 
        /// distintos medios de transporte; por ejemplo, las coordenadas del GPS.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Referencia {
            get {
                return this.referenciaField;
            }
            set {
                this.referenciaField = value;
            }
        }

        /// <summary>
        /// Atributo opcional que sirve para registrar el municipio, delegación o alcaldía, condado o dato análogo del domicilio de origen y/o destino de los bienes y/o mercancías que se trasladan en los distintos medios de transporte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Municipio {
            get {
                return this.municipioField;
            }
            set {
                this.municipioField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para registrar el estado, entidad, región, comunidad, o dato análogo en donde se encuentra ubicado el domicilio del origen y/o destino de los bienes y/o mercancías que se trasladan en los distintos medios de transporte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
            }
        }

        /// <summary>
        /// Atributo requerido que sirve para registrar la clave del país en donde se encuentra ubicado el domicilio del origen y/o destino de los bienes y/o mercancías que se trasladan en los distintos medios de transporte, conforme con el 
        /// catálogo de c_Pais del CFDI, publicado en el portal del SAT en Internet de acuerdo a la especificación ISO 3166-1.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Pais {
            get {
                return this.paisField;
            }
            set {
                this.paisField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para registrar el código postal en donde se encuentra el domicilio del origen y/o destino de los bienes y/o mercancías que se trasladan en los distintos medios de transporte.
        /// </summary>
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