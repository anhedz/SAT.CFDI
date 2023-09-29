using System.Xml.Serialization;

namespace Jaeger.SAT.CFDI.V40 {
    /// <summary>
    /// Nodo requerido para registrar la información detallada de un bien o servicio amparado en el comprobante.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConcepto {

        private ComprobanteConceptoImpuestos impuestosField;

        private ComprobanteConceptoACuentaTerceros aCuentaTercerosField;

        private ComprobanteConceptoInformacionAduanera[] informacionAduaneraField;

        private ComprobanteConceptoCuentaPredial[] cuentaPredialField;

        private ComprobanteConceptoComplementoConcepto complementoConceptoField;

        private ComprobanteConceptoParte[] parteField;

        private string claveProdServField;

        private string noIdentificacionField;

        private decimal cantidadField;

        private string claveUnidadField;

        private string unidadField;

        private string descripcionField;

        private decimal valorUnitarioField;

        private decimal importeField;

        private decimal descuentoField;

        private bool descuentoFieldSpecified;

        private string objetoImpField;

        /// <summary>
        /// Nodo condicional para capturar los impuestos aplicables al presente concepto.
        /// </summary>
        public ComprobanteConceptoImpuestos Impuestos {
            get {
                return this.impuestosField;
            }
            set {
                this.impuestosField = value;
            }
        }

        /// <remarks/>
        public ComprobanteConceptoACuentaTerceros ACuentaTerceros {
            get {
                return this.aCuentaTercerosField;
            }
            set {
                this.aCuentaTercerosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InformacionAduanera")]
        public ComprobanteConceptoInformacionAduanera[] InformacionAduanera {
            get {
                return this.informacionAduaneraField;
            }
            set {
                this.informacionAduaneraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CuentaPredial")]
        public ComprobanteConceptoCuentaPredial[] CuentaPredial {
            get {
                return this.cuentaPredialField;
            }
            set {
                this.cuentaPredialField = value;
            }
        }

        /// <remarks/>
        public ComprobanteConceptoComplementoConcepto ComplementoConcepto {
            get {
                return this.complementoConceptoField;
            }
            set {
                this.complementoConceptoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parte")]
        public ComprobanteConceptoParte[] Parte {
            get {
                return this.parteField;
            }
            set {
                this.parteField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar la clave del producto o del servicio amparado por el presente concepto. Es requerido y deben utilizar las claves del 
        /// catálogo de productos y servicios, cuando los conceptos que registren por sus actividades correspondan con dichos conceptos.
        /// </summary>
        [XmlAttributeAttribute()]
        public string ClaveProdServ {
            get {
                return this.claveProdServField;
            }
            set {
                this.claveProdServField = value;
            }
        }

        /// <summary>
        /// Atributo opcional para expresar el número de parte, identificador del producto o del servicio, la clave de producto o servicio, SKU o equivalente, propia de la operación del emisor, amparado por el presente concepto. Opcionalmente se puede utilizar claves del estándar GTIN.
        /// </summary>
        [XmlAttributeAttribute()]
        public string NoIdentificacion {
            get {
                return this.noIdentificacionField;
            }
            set {
                this.noIdentificacionField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para precisar la cantidad de bienes o servicios del tipo particular definido por el presente concepto.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal Cantidad {
            get {
                return this.cantidadField;
            }
            set {
                this.cantidadField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para precisar la clave de unidad de medida estandarizada aplicable para la cantidad expresada en el concepto. La unidad debe corresponder con la descripción del concepto
        /// </summary>
        [XmlAttributeAttribute()]
        public string ClaveUnidad {
            get {
                return this.claveUnidadField;
            }
            set {
                this.claveUnidadField = value;
            }
        }

        /// <summary>
        /// Atributo opcional para precisar la unidad de medida propia de la operación del emisor, aplicable para la cantidad expresada en el concepto. La unidad debe corresponder con la descripción del concepto.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Unidad {
            get {
                return this.unidadField;
            }
            set {
                this.unidadField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para precisar la descripción del bien o servicio cubierto por el presente concepto.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para precisar el valor o precio unitario del bien o servicio cubierto por el presente concepto.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal ValorUnitario {
            get {
                return this.valorUnitarioField;
            }
            set {
                this.valorUnitarioField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para precisar el importe total de los bienes o servicios del presente concepto. Debe ser equivalente al resultado de multiplicar la cantidad por el valor unitario expresado en el concepto. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal Importe {
            get {
                return this.importeField;
            }
            set {
                this.importeField = value;
            }
        }

        /// <summary>
        /// Atributo opcional para representar el importe de los descuentos aplicables al concepto. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal Descuento {
            get {
                return this.descuentoField;
            }
            set {
                this.descuentoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DescuentoSpecified {
            get {
                return this.descuentoFieldSpecified;
            }
            set {
                this.descuentoFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar si la operación comercial es objeto o no de impuesto.
        /// </summary>
        [XmlAttributeAttribute()]
        public string ObjetoImp {
            get {
                return this.objetoImpField;
            }
            set {
                this.objetoImpField = value;
            }
        }
    }

    /// <summary>
    /// Nodo condicional para capturar los impuestos aplicables al presente concepto.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoImpuestos {

        private ComprobanteConceptoImpuestosTraslado[] trasladosField;

        private ComprobanteConceptoImpuestosRetencion[] retencionesField;

        /// <summary>
        /// Nodo opcional para asentar los impuestos trasladados aplicables al presente concepto.
        /// </summary>
        [System.Xml.Serialization.XmlArrayItemAttribute("Traslado", IsNullable = false)]
        public ComprobanteConceptoImpuestosTraslado[] Traslados {
            get {
                return this.trasladosField;
            }
            set {
                this.trasladosField = value;
            }
        }

        /// <summary>
        /// Nodo opcional para asentar los impuestos retenidos aplicables al presente concepto.
        /// </summary>
        [System.Xml.Serialization.XmlArrayItemAttribute("Retencion", IsNullable = false)]
        public ComprobanteConceptoImpuestosRetencion[] Retenciones {
            get {
                return this.retencionesField;
            }
            set {
                this.retencionesField = value;
            }
        }
    }

    /// <summary>
    /// Nodo requerido para asentar la información detallada de un traslado de impuestos aplicable al presente concepto.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoImpuestosTraslado {

        private decimal baseField;

        private string impuestoField;

        private string tipoFactorField;

        private decimal tasaOCuotaField;

        private bool tasaOCuotaFieldSpecified;

        private decimal importeField;

        private bool importeFieldSpecified;

        /// <summary>
        /// Atributo requerido para señalar la base para el cálculo del impuesto, la determinación de la base se realiza de acuerdo con las disposiciones fiscales vigentes. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal Base {
            get {
                return this.baseField;
            }
            set {
                this.baseField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para señalar la clave del tipo de impuesto trasladado aplicable al concepto.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Impuesto {
            get {
                return this.impuestoField;
            }
            set {
                this.impuestoField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para señalar la clave del tipo de factor que se aplica a la base del impuesto.
        /// </summary>
        [XmlAttributeAttribute()]
        public string TipoFactor {
            get {
                return this.tipoFactorField;
            }
            set {
                this.tipoFactorField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para señalar el valor de la tasa o cuota del impuesto que se traslada para el presente concepto. Es requerido cuando el atributo TipoFactor tenga una clave que corresponda a Tasa o Cuota.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal TasaOCuota {
            get {
                return this.tasaOCuotaField;
            }
            set {
                this.tasaOCuotaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TasaOCuotaSpecified {
            get {
                return this.tasaOCuotaFieldSpecified;
            }
            set {
                this.tasaOCuotaFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo condicional para señalar el importe del impuesto trasladado que aplica al concepto. No se permiten valores negativos. Es requerido cuando TipoFactor sea Tasa o Cuota.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal Importe {
            get {
                return this.importeField;
            }
            set {
                this.importeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImporteSpecified {
            get {
                return this.importeFieldSpecified;
            }
            set {
                this.importeFieldSpecified = value;
            }
        }
    }

    /// <summary>
    /// Nodo requerido para asentar la información detallada de una retención de impuestos aplicable al presente concepto.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoImpuestosRetencion {

        private decimal baseField;

        private string impuestoField;

        private string tipoFactorField;

        private decimal tasaOCuotaField;

        private decimal importeField;

        /// <summary>
        /// Atributo requerido para señalar la base para el cálculo de la retención, la determinación de la base se realiza de acuerdo con las disposiciones fiscales vigentes. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal Base {
            get {
                return this.baseField;
            }
            set {
                this.baseField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para señalar la clave del tipo de impuesto retenido aplicable al concepto.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Impuesto {
            get {
                return this.impuestoField;
            }
            set {
                this.impuestoField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para señalar la clave del tipo de factor que se aplica a la base del impuesto.
        /// </summary>
        [XmlAttributeAttribute()]
        public string TipoFactor {
            get {
                return this.tipoFactorField;
            }
            set {
                this.tipoFactorField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para señalar la tasa o cuota del impuesto que se retiene para el presente concepto.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal TasaOCuota {
            get {
                return this.tasaOCuotaField;
            }
            set {
                this.tasaOCuotaField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para señalar el importe del impuesto retenido que aplica al concepto. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal Importe {
            get {
                return this.importeField;
            }
            set {
                this.importeField = value;
            }
        }
    }

    /// <summary>
    /// Nodo opcional para registrar información del contribuyente Tercero, a cuenta del que se realiza la operación.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoACuentaTerceros {

        private string rfcACuentaTercerosField;

        private string nombreACuentaTercerosField;

        private string regimenFiscalACuentaTercerosField;

        private string domicilioFiscalACuentaTercerosField;

        /// <summary>
        /// Atributo requerido para registrar la Clave del Registro Federal de Contribuyentes del contribuyente Tercero, a cuenta del que se realiza la operación.
        /// </summary>
        [XmlAttributeAttribute()]
        public string RfcACuentaTerceros {
            get {
                return this.rfcACuentaTercerosField;
            }
            set {
                this.rfcACuentaTercerosField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para registrar el nombre, denominación o razón social del contribuyente Tercero correspondiente con el Rfc, a cuenta del que se realiza la operación.
        /// </summary>
        [XmlAttributeAttribute()]
        public string NombreACuentaTerceros {
            get {
                return this.nombreACuentaTercerosField;
            }
            set {
                this.nombreACuentaTercerosField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para incorporar la clave del régimen del contribuyente Tercero, a cuenta del que se realiza la operación.
        /// </summary>
        [XmlAttributeAttribute()]
        public string RegimenFiscalACuentaTerceros {
            get {
                return this.regimenFiscalACuentaTercerosField;
            }
            set {
                this.regimenFiscalACuentaTercerosField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para incorporar el código postal del domicilio fiscal del Tercero, a cuenta del que se realiza la operación.
        /// </summary>
        [XmlAttributeAttribute()]
        public string DomicilioFiscalACuentaTerceros {
            get {
                return this.domicilioFiscalACuentaTercerosField;
            }
            set {
                this.domicilioFiscalACuentaTercerosField = value;
            }
        }
    }

    /// <summary>
    /// Nodo opcional para introducir la información aduanera aplicable cuando se trate de ventas de primera mano de mercancías importadas o se trate de operaciones de comercio exterior con bienes o servicios.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoInformacionAduanera {

        private string numeroPedimentoField;

        /// <summary>
        /// Atributo requerido para expresar el número del pedimento que ampara la importación del bien que se expresa en el siguiente formato: últimos 2 dígitos del año de validación 
        /// seguidos por dos espacios, 2 dígitos de la aduana de despacho seguidos por dos espacios, 4 dígitos del número de la patente seguidos por dos espacios, 1 dígito que corresponde 
        /// al último dígito del año en curso, salvo que se trate de un pedimento consolidado iniciado en el año inmediato anterior o del pedimento original de una rectificación, seguido 
        /// de 6 dígitos de la numeración progresiva por aduana.
        /// </summary>
        [XmlAttributeAttribute()]
        public string NumeroPedimento {
            get {
                return this.numeroPedimentoField;
            }
            set {
                this.numeroPedimentoField = value;
            }
        }
    }

    /// <summary>
    /// Nodo opcional para asentar el número de cuenta predial con el que fue registrado el inmueble, en el sistema catastral de la entidad federativa de que trate, o bien para 
    /// incorporar los datos de identificación del certificado de participación inmobiliaria no amortizable.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoCuentaPredial {

        private string numeroField;

        /// <summary>
        /// Atributo requerido para precisar el número de la cuenta predial del inmueble cubierto por el presente concepto, o bien para incorporar los datos de identificación 
        /// del certificado de participación inmobiliaria no amortizable, tratándose de arrendamiento.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Numero {
            get {
                return this.numeroField;
            }
            set {
                this.numeroField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoComplementoConcepto {

        private System.Xml.XmlElement[] anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }

    /// <summary>
    /// Nodo opcional para expresar las partes o componentes que integran la totalidad del concepto expresado en el comprobante fiscal digital por Internet.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoParte {

        private ComprobanteConceptoParteInformacionAduanera[] informacionAduaneraField;

        private string claveProdServField;

        private string noIdentificacionField;

        private decimal cantidadField;

        private string unidadField;

        private string descripcionField;

        private decimal valorUnitarioField;

        private bool valorUnitarioFieldSpecified;

        private decimal importeField;

        private bool importeFieldSpecified;

        /// <summary>
        /// Nodo opcional para introducir la información aduanera aplicable cuando se trate de ventas de primera mano de mercancías importadas o se trate de operaciones de comercio exterior con bienes o servicios.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("InformacionAduanera")]
        public ComprobanteConceptoParteInformacionAduanera[] InformacionAduanera {
            get {
                return this.informacionAduaneraField;
            }
            set {
                this.informacionAduaneraField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar la clave del producto o del servicio amparado por la presente parte. Es requerido y deben utilizar las claves del 
        /// catálogo de productos y servicios, cuando los conceptos que registren por sus actividades correspondan con dichos conceptos.
        /// </summary>
        [XmlAttributeAttribute()]
        public string ClaveProdServ {
            get {
                return this.claveProdServField;
            }
            set {
                this.claveProdServField = value;
            }
        }

        /// <summary>
        /// Atributo opcional para expresar el número de serie, número de parte del bien o identificador del producto o del servicio amparado por la presente 
        /// parte. Opcionalmente se puede utilizar claves del estándar GTIN.
        /// </summary>
        [XmlAttributeAttribute()]
        public string NoIdentificacion {
            get {
                return this.noIdentificacionField;
            }
            set {
                this.noIdentificacionField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para precisar la cantidad de bienes o servicios del tipo particular definido por la presente parte.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal Cantidad {
            get {
                return this.cantidadField;
            }
            set {
                this.cantidadField = value;
            }
        }

        /// <summary>
        /// Atributo opcional para precisar la unidad de medida propia de la operación del emisor, aplicable para la cantidad expresada en la parte. La unidad debe corresponder con la descripción de la parte.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Unidad {
            get {
                return this.unidadField;
            }
            set {
                this.unidadField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para precisar la descripción del bien o servicio cubierto por la presente parte.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
            }
        }

        /// <summary>
        /// Atributo opcional para precisar el valor o precio unitario del bien o servicio cubierto por la presente parte. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal ValorUnitario {
            get {
                return this.valorUnitarioField;
            }
            set {
                this.valorUnitarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorUnitarioSpecified {
            get {
                return this.valorUnitarioFieldSpecified;
            }
            set {
                this.valorUnitarioFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo opcional para precisar el importe total de los bienes o servicios de la presente parte. Debe ser equivalente al resultado de multiplicar la cantidad por el valor unitario expresado en la parte. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal Importe {
            get {
                return this.importeField;
            }
            set {
                this.importeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImporteSpecified {
            get {
                return this.importeFieldSpecified;
            }
            set {
                this.importeFieldSpecified = value;
            }
        }
    }

    /// <summary>
    /// Nodo opcional para introducir la información aduanera aplicable cuando se trate de ventas de primera mano de mercancías importadas o se trate de operaciones de comercio exterior con bienes o servicios.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteConceptoParteInformacionAduanera {

        private string numeroPedimentoField;

        /// <summary>
        /// Atributo requerido para expresar el número del pedimento que ampara la importación del bien que se expresa en el siguiente formato: últimos 2 dígitos del año de validación 
        /// seguidos por dos espacios, 2 dígitos de la aduana de despacho seguidos por dos espacios, 4 dígitos del número de la patente seguidos por dos espacios, 1 dígito que corresponde
        /// al último dígito del año en curso, salvo que se trate de un pedimento consolidado iniciado en el año inmediato anterior o del pedimento original de una rectificación, seguido 
        /// de 6 dígitos de la numeración progresiva por aduana.
        /// </summary>
        [XmlAttributeAttribute()]
        public string NumeroPedimento {
            get {
                return this.numeroPedimentoField;
            }
            set {
                this.numeroPedimentoField = value;
            }
        }
    }
}
