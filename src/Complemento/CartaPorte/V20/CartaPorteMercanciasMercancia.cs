namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V20 {
    /// <summary>
    /// Nodo requerido para registrar detalladamente la información de los bienes y/o mercancías que se trasladan en los distintos medios de transporte
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteMercanciasMercancia {

        private CartaPorteMercanciasMercanciaPedimentos[] pedimentosField;

        private CartaPorteMercanciasMercanciaGuiasIdentificacion[] guiasIdentificacionField;

        private CartaPorteMercanciasMercanciaCantidadTransporta[] cantidadTransportaField;

        private CartaPorteMercanciasMercanciaDetalleMercancia detalleMercanciaField;

        private string bienesTranspField; //c_ClaveProdServCP

        private string claveSTCCField;

        private string descripcionField;

        private decimal cantidadField;

        private string claveUnidadField; //c_ClaveUnidad

        private string unidadField;

        private string dimensionesField;

        private string materialPeligrosoField; //CartaPorteMercanciasMercanciaMaterialPeligroso Sí - No

        private bool materialPeligrosoFieldSpecified;

        private string cveMaterialPeligrosoField; //c_MaterialPeligroso

        private bool cveMaterialPeligrosoFieldSpecified;

        private string embalajeField; //c_TipoEmbalaje

        private bool embalajeFieldSpecified;

        private string descripEmbalajeField;

        private decimal pesoEnKgField;

        private decimal valorMercanciaField;

        private bool valorMercanciaFieldSpecified;

        private string monedaField; //c_Moneda

        private bool monedaFieldSpecified;

        private string fraccionArancelariaField; //c_FraccionArancelaria

        private bool fraccionArancelariaFieldSpecified;

        private string uUIDComercioExtField;

        /// <summary>
        /// Nodo condicional para registrar la información del(los) número(s) de pedimento(s) de importación que se encuentra(n) asociado(s) al traslado de los bienes y/o mercancías de procedencia extranjera para acreditar 
        /// la legal estancia o tenencia durante su traslado en territorio nacional.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Pedimentos")]
        public CartaPorteMercanciasMercanciaPedimentos[] Pedimentos {
            get {
                return this.pedimentosField;
            }
            set {
                this.pedimentosField = value;
            }
        }

        /// <summary>
        /// Nodo condicional para registrar la información del(los) número(s) de guía(s) que se encuentre(n) asociado(s) al(los) paquete(s) que se traslada(n) dentro del territorio nacional.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("GuiasIdentificacion")]
        public CartaPorteMercanciasMercanciaGuiasIdentificacion[] GuiasIdentificacion {
            get {
                return this.guiasIdentificacionField;
            }
            set {
                this.guiasIdentificacionField = value;
            }
        }

        /// <summary>
        /// Nodo opcional para registrar la cantidad de los bienes y/o mercancías que se trasladan a través de los distintos medios de transporte, que será captada o distribuida en distintos puntos, a fin de identificar el punto de origen y destino correspondiente
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("CantidadTransporta")]
        public CartaPorteMercanciasMercanciaCantidadTransporta[] CantidadTransporta {
            get {
                return this.cantidadTransportaField;
            }
            set {
                this.cantidadTransportaField = value;
            }
        }

        /// <summary>
        /// Nodo condicional para registrar especificaciones de los bienes y/o mercancías que se trasladan a través de los distintos medios de transporte.
        /// </summary>
        public CartaPorteMercanciasMercanciaDetalleMercancia DetalleMercancia {
            get {
                return this.detalleMercanciaField;
            }
            set {
                this.detalleMercanciaField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para registrar la clave de producto de los bienes y/o mercancías que se trasladan en los distintos medios de transporte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BienesTransp {
            get {
                return this.bienesTranspField;
            }
            set {
                this.bienesTranspField = value;
            }
        }

        /// <summary>
        /// Atributo opcional para expresar la clave de producto de la STCC (por sus siglas en inglés, Standard Transportation Commodity Code), cuando el medio de transporte utilizado para el traslado de los bienes y/o mercancías sea ferroviario.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaveSTCC {
            get {
                return this.claveSTCCField;
            }
            set {
                this.claveSTCCField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para detallar las características de los bienes y/o mercancías que se trasladan en los distintos medios de transporte
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar la cantidad total de los bienes y/o mercancías que se trasladan a través de los distintos medios de transporte.
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
        /// Atributo requerido para registrar la clave de la unidad de medida estandarizada aplicable para la cantidad de los bienes y/o mercancías que se trasladan en los distintos medios de transporte. La unidad debe corresponder con la descripción de los bienes y/o mercancías registrados.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaveUnidad {
            get {
                return this.claveUnidadField;
            }
            set {
                this.claveUnidadField = value;
            }
        }

        /// <summary>
        /// Atributo opcional para registrar la unidad de medida propia para la cantidad de los bienes y/o mercancías que se trasladan a través de los distintos medios de transporte. La unidad debe corresponder con la descripción de los bienes y/o mercancías.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Unidad {
            get {
                return this.unidadField;
            }
            set {
                this.unidadField = value;
            }
        }

        /// <summary>
        /// Atributo opcional para expresar las medidas del empaque de los bienes y/o mercancías que se trasladan en los distintos medios de transporte. Se debe registrar la longitud, la altura y la anchura en centímetros o en pulgadas, separados dichos valores con una diagonal, i.e. 30/40/30cm.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Dimensiones {
            get {
                return this.dimensionesField;
            }
            set {
                this.dimensionesField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para precisar que los bienes y/o mercancías que se trasladan son considerados o clasificados como material peligroso.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MaterialPeligroso {
            get {
                return this.materialPeligrosoField;
            }
            set {
                this.materialPeligrosoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaterialPeligrosoSpecified {
            get {
                return this.materialPeligrosoFieldSpecified;
            }
            set {
                this.materialPeligrosoFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo condicional para indicar la clave del tipo de material peligroso que se transporta de acuerdo a la NOM-002-SCT/2011.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CveMaterialPeligroso {
            get {
                return this.cveMaterialPeligrosoField;
            }
            set {
                this.cveMaterialPeligrosoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CveMaterialPeligrosoSpecified {
            get {
                return this.cveMaterialPeligrosoFieldSpecified;
            }
            set {
                this.cveMaterialPeligrosoFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo condicional para precisar la clave del tipo de embalaje que se requiere para transportar el material o residuo peligroso.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Embalaje {
            get {
                return this.embalajeField;
            }
            set {
                this.embalajeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EmbalajeSpecified {
            get {
                return this.embalajeFieldSpecified;
            }
            set {
                this.embalajeFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo opcional para expresar la descripción del embalaje de los bienes y/o mercancías que se trasladan y que se consideran material o residuo peligroso.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DescripEmbalaje {
            get {
                return this.descripEmbalajeField;
            }
            set {
                this.descripEmbalajeField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para indicar en kilogramos el peso estimado de los bienes y/o mercancías que se trasladan en los distintos medios de transporte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PesoEnKg {
            get {
                return this.pesoEnKgField;
            }
            set {
                this.pesoEnKgField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar el monto del valor de los bienes y/o mercancías que se trasladan en los distintos medios de transporte, de acuerdo al valor mercado, al valor pactado en la contraprestación o bien al valor estimado que determine el contribuyente.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ValorMercancia {
            get {
                return this.valorMercanciaField;
            }
            set {
                this.valorMercanciaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorMercanciaSpecified {
            get {
                return this.valorMercanciaFieldSpecified;
            }
            set {
                this.valorMercanciaFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo condicional para identificar la clave de la moneda utilizada para expresar el valor de los bienes y/o mercancías que se trasladan en los distintos medios de transporte. Cuando se usa moneda nacional se registra MXN, de acuerdo a la especificación ISO 4217.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Moneda {
            get {
                return this.monedaField;
            }
            set {
                this.monedaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MonedaSpecified {
            get {
                return this.monedaFieldSpecified;
            }
            set {
                this.monedaFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo condicional que sirve para expresar la clave de la fracción arancelaria que corresponde con la descripción de los bienes y/o mercancías que se trasladan en los distintos medios de transporte
        /// </summary>
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

        /// <summary>
        /// Atributo opcional para expresar el folio fiscal (UUID) del comprobante de comercio exterior que se relaciona.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UUIDComercioExt {
            get {
                return this.uUIDComercioExtField;
            }
            set {
                this.uUIDComercioExtField = value;
            }
        }
    }
}