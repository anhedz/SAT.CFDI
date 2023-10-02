using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;
using System;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Xml.Xsl;
using Jaeger.SAT.CFDI.Services;

namespace Jaeger.SAT.CFDI.Complemento.Pagos.V20 {
    /// <summary>
    /// Complemento para el Comprobante Fiscal Digital por Internet (CFDI) para registrar información sobre la recepción de pagos. El emisor de este complemento para recepción de pagos debe ser quien 
    /// las leyes le obligue a expedir comprobantes por los actos o actividades que realicen, por los ingresos que se perciban o por las retenciones de contribuciones que efectúen.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    [XmlRootAttribute(Namespace = "http://www.sat.gob.mx/Pagos20", IsNullable = false)]
    public partial class Pagos {
        [XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string XsiSchemaLocation;

        private PagosTotales totalesField;

        private PagosPago[] pagoField;

        private string versionField;

        private static XmlSerializer objSerializer;

        public Pagos() {
            this.versionField = "2.0";
        }

        /// <summary>
        /// Nodo requerido para especificar el monto total de los pagos y el total de los impuestos, deben ser expresados en MXN.
        /// </summary>
        public PagosTotales Totales {
            get {
                return this.totalesField;
            }
            set {
                this.totalesField = value;
            }
        }

        /// <summary>
        /// Elemento requerido para incorporar la información de la recepción de pagos.
        /// </summary>
        [XmlElementAttribute("Pago")]
        public PagosPago[] Pago {
            get {
                return this.pagoField;
            }
            set {
                this.pagoField = value;
            }
        }

        /// <summary>
        /// Atributo requerido que indica la versión del complemento para recepción de pagos.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }

        #region Serializacion

        [XmlIgnore]
        public string CadenaOriginal {
            get {
                string outOriginalString;
                using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Jaeger.Pagos20.xslt")) {
                    if (manifestResourceStream == null) {
                        outOriginalString = null;
                    } else {
                        XmlDocument xmlDocument = new XmlDocument();
                        xmlDocument.Load(manifestResourceStream);
                        using (StringWriter stringWriter = new StringWriter()) {
                            using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter)) {
                                XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
                                xslCompiledTransform.Load(xmlDocument, null, new XmlResolverService());
                                xslCompiledTransform.Transform(new XPathDocument(new StringReader(this.Serialize())), null, xmlTextWriter);
                                outOriginalString = stringWriter.ToString();
                            }
                        }
                    }
                }
                return outOriginalString;
            }
        }

        public static XmlSerializer Serializer {
            get {
                if (Pagos.objSerializer == null) {
                    Pagos.objSerializer = (new XmlSerializerFactory()).CreateSerializer(typeof(Pagos));
                }
                return Pagos.objSerializer;
            }
        }

        public static bool Deserialize(string input, out Pagos obj, out Exception exception) {
            bool flag;
            exception = null;
            obj = null;
            try {
                obj = Pagos.Deserialize(input);
                flag = true;
            } catch (Exception exception1) {
                exception = exception1;
                flag = false;
            }
            return flag;
        }

        public static bool Deserialize(string input, out Pagos obj) {
            Exception exception = new Exception();
            return Pagos.Deserialize(input, out obj, out exception);
        }

        public static Pagos Deserialize(string input) {
            StringReader objStringReader = new StringReader(input);
            Pagos objPagos = (Pagos)Pagos.Serializer.Deserialize(XmlReader.Create(objStringReader));
            return objPagos;
        }

        public static Pagos Deserialize(Stream s) {
            return (Pagos)Pagos.Serializer.Deserialize(s);
        }

        public virtual string Serialize() {
            string end;
            StreamReader streamReader = null;
            MemoryStream memoryStream = null;
            try {
                memoryStream = new MemoryStream();
                XmlWriterSettings xmlWriterSetting = new XmlWriterSettings() {
                    Encoding = Encoding.UTF8,
                    Indent = true
                };
                XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSetting);
                XmlSerializerNamespaces xmlSerializerNamespace = new XmlSerializerNamespaces();
                xmlSerializerNamespace.Add("pago20", "http://www.sat.gob.mx/Pagos20");
                xmlSerializerNamespace.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
                this.XsiSchemaLocation = "http://www.sat.gob.mx/Pagos http://www.sat.gob.mx/sitio_internet/cfd/Pagos/Pagos20.xsd";
                Pagos.Serializer.Serialize(xmlWriter, this, xmlSerializerNamespace);
                memoryStream.Seek((long)0, SeekOrigin.Begin);
                streamReader = new StreamReader(memoryStream, Encoding.UTF8);
                end = streamReader.ReadToEnd();
            } finally {
                if (streamReader != null) {
                    streamReader.Dispose();
                }
                if (memoryStream != null) {
                    memoryStream.Dispose();
                }
            }
            return end;
        }

        #endregion
    }

    /// <summary>
    /// Nodo requerido para especificar el monto total de los pagos y el total de los impuestos, deben ser expresados en MXN.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosTotales {

        private decimal totalRetencionesIVAField;

        private bool totalRetencionesIVAFieldSpecified;

        private decimal totalRetencionesISRField;

        private bool totalRetencionesISRFieldSpecified;

        private decimal totalRetencionesIEPSField;

        private bool totalRetencionesIEPSFieldSpecified;

        private decimal totalTrasladosBaseIVA16Field;

        private bool totalTrasladosBaseIVA16FieldSpecified;

        private decimal totalTrasladosImpuestoIVA16Field;

        private bool totalTrasladosImpuestoIVA16FieldSpecified;

        private decimal totalTrasladosBaseIVA8Field;

        private bool totalTrasladosBaseIVA8FieldSpecified;

        private decimal totalTrasladosImpuestoIVA8Field;

        private bool totalTrasladosImpuestoIVA8FieldSpecified;

        private decimal totalTrasladosBaseIVA0Field;

        private bool totalTrasladosBaseIVA0FieldSpecified;

        private decimal totalTrasladosImpuestoIVA0Field;

        private bool totalTrasladosImpuestoIVA0FieldSpecified;

        private decimal totalTrasladosBaseIVAExentoField;

        private bool totalTrasladosBaseIVAExentoFieldSpecified;

        private decimal montoTotalPagosField;

        /// <summary>
        /// Atributo condicional para expresar el total de los impuestos retenidos de IVA que se desprenden de los pagos. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal TotalRetencionesIVA {
            get {
                return this.totalRetencionesIVAField;
            }
            set {
                this.totalRetencionesIVAField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalRetencionesIVASpecified {
            get {
                return this.totalRetencionesIVAFieldSpecified;
            }
            set {
                this.totalRetencionesIVAFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar el total de los impuestos retenidos de ISR que se desprenden de los pagos. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal TotalRetencionesISR {
            get {
                return this.totalRetencionesISRField;
            }
            set {
                this.totalRetencionesISRField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalRetencionesISRSpecified {
            get {
                return this.totalRetencionesISRFieldSpecified;
            }
            set {
                this.totalRetencionesISRFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar el total de los impuestos retenidos de IEPS que se desprenden de los pagos. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal TotalRetencionesIEPS {
            get {
                return this.totalRetencionesIEPSField;
            }
            set {
                this.totalRetencionesIEPSField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalRetencionesIEPSSpecified {
            get {
                return this.totalRetencionesIEPSFieldSpecified;
            }
            set {
                this.totalRetencionesIEPSFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar el total de la base de IVA trasladado a la tasa del 16% que se desprende de los pagos. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal TotalTrasladosBaseIVA16 {
            get {
                return this.totalTrasladosBaseIVA16Field;
            }
            set {
                this.totalTrasladosBaseIVA16Field = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalTrasladosBaseIVA16Specified {
            get {
                return this.totalTrasladosBaseIVA16FieldSpecified;
            }
            set {
                this.totalTrasladosBaseIVA16FieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar el total de los impuestos de IVA trasladado a la tasa del 16% que se desprenden de los pagos. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal TotalTrasladosImpuestoIVA16 {
            get {
                return this.totalTrasladosImpuestoIVA16Field;
            }
            set {
                this.totalTrasladosImpuestoIVA16Field = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalTrasladosImpuestoIVA16Specified {
            get {
                return this.totalTrasladosImpuestoIVA16FieldSpecified;
            }
            set {
                this.totalTrasladosImpuestoIVA16FieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar el total de la base de IVA trasladado a la tasa del 8% que se desprende de los pagos. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal TotalTrasladosBaseIVA8 {
            get {
                return this.totalTrasladosBaseIVA8Field;
            }
            set {
                this.totalTrasladosBaseIVA8Field = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalTrasladosBaseIVA8Specified {
            get {
                return this.totalTrasladosBaseIVA8FieldSpecified;
            }
            set {
                this.totalTrasladosBaseIVA8FieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar el total de los impuestos de IVA trasladado a la tasa del 8% que se desprenden de los pagos. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal TotalTrasladosImpuestoIVA8 {
            get {
                return this.totalTrasladosImpuestoIVA8Field;
            }
            set {
                this.totalTrasladosImpuestoIVA8Field = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalTrasladosImpuestoIVA8Specified {
            get {
                return this.totalTrasladosImpuestoIVA8FieldSpecified;
            }
            set {
                this.totalTrasladosImpuestoIVA8FieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar el total de la base de IVA trasladado a la tasa del 0% que se desprende de los pagos. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal TotalTrasladosBaseIVA0 {
            get {
                return this.totalTrasladosBaseIVA0Field;
            }
            set {
                this.totalTrasladosBaseIVA0Field = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalTrasladosBaseIVA0Specified {
            get {
                return this.totalTrasladosBaseIVA0FieldSpecified;
            }
            set {
                this.totalTrasladosBaseIVA0FieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar el total de los impuestos de IVA trasladado a la tasa del 0% que se desprenden de los pagos. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal TotalTrasladosImpuestoIVA0 {
            get {
                return this.totalTrasladosImpuestoIVA0Field;
            }
            set {
                this.totalTrasladosImpuestoIVA0Field = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalTrasladosImpuestoIVA0Specified {
            get {
                return this.totalTrasladosImpuestoIVA0FieldSpecified;
            }
            set {
                this.totalTrasladosImpuestoIVA0FieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar el total de la base de IVA trasladado exento que se desprende de los pagos. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal TotalTrasladosBaseIVAExento {
            get {
                return this.totalTrasladosBaseIVAExentoField;
            }
            set {
                this.totalTrasladosBaseIVAExentoField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TotalTrasladosBaseIVAExentoSpecified {
            get {
                return this.totalTrasladosBaseIVAExentoFieldSpecified;
            }
            set {
                this.totalTrasladosBaseIVAExentoFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar el total de los pagos que se desprenden de los nodos Pago. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal MontoTotalPagos {
            get {
                return this.montoTotalPagosField;
            }
            set {
                this.montoTotalPagosField = value;
            }
        }
    }

    /// <summary>
    /// Elemento requerido para incorporar la información de la recepción de pagos.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosPago {

        private PagosPagoDoctoRelacionado[] doctoRelacionadoField;

        private PagosPagoImpuestosP impuestosPField;

        private System.DateTime fechaPagoField;

        private string formaDePagoPField;

        private string monedaPField;

        private decimal tipoCambioPField;

        private bool tipoCambioPFieldSpecified;

        private decimal montoField;

        private string numOperacionField;

        private string rfcEmisorCtaOrdField;

        private string nomBancoOrdExtField;

        private string ctaOrdenanteField;

        private string rfcEmisorCtaBenField;

        private string ctaBeneficiarioField;

        private string tipoCadPagoField;

        private bool tipoCadPagoFieldSpecified;

        private byte[] certPagoField;

        private string cadPagoField;

        private byte[] selloPagoField;

        /// <summary>
        /// Nodo requerido para expresar la lista de documentos relacionados con los pagos. Por cada documento que se relacione se debe generar un nodo DoctoRelacionado.
        /// </summary>
        [XmlElementAttribute("DoctoRelacionado")]
        public PagosPagoDoctoRelacionado[] DoctoRelacionado {
            get {
                return this.doctoRelacionadoField;
            }
            set {
                this.doctoRelacionadoField = value;
            }
        }

        /// <summary>
        /// Nodo condicional para registrar el resumen de los impuestos aplicables conforme al monto del pago recibido, expresados a la moneda de pago.
        /// </summary>
        public PagosPagoImpuestosP ImpuestosP {
            get {
                return this.impuestosPField;
            }
            set {
                this.impuestosPField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar la fecha y hora en la que el beneficiario recibe el pago. Se expresa en la forma aaaa-mm-ddThh:mm:ss, de acuerdo con la especificación ISO 8601.En caso de no contar con la hora se debe registrar 12:00:00.
        /// </summary>
        [XmlAttributeAttribute()]
        public System.DateTime FechaPago {
            get {
                return this.fechaPagoField;
            }
            set {
                this.fechaPagoField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar la clave de la forma en que se realiza el pago.
        /// </summary>
        [XmlAttributeAttribute()]
        public string FormaDePagoP {
            get {
                return this.formaDePagoPField;
            }
            set {
                this.formaDePagoPField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para identificar la clave de la moneda utilizada para realizar el pago conforme a la especificación ISO 4217. Cuando se usa moneda nacional se registra MXN. El atributo Pagos:Pago:Monto debe ser expresado en la moneda registrada en este atributo.
        /// </summary>
        [XmlAttributeAttribute()]
        public string MonedaP {
            get {
                return this.monedaPField;
            }
            set {
                this.monedaPField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar el tipo de cambio de la moneda a la fecha en que se realizó el pago. El valor debe reflejar el número de pesos mexicanos que equivalen a una unidad de la divisa señalada en el atributo MonedaP. Es requerido cuando el atributo MonedaP es diferente a MXN.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal TipoCambioP {
            get {
                return this.tipoCambioPField;
            }
            set {
                this.tipoCambioPField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TipoCambioPSpecified {
            get {
                return this.tipoCambioPFieldSpecified;
            }
            set {
                this.tipoCambioPFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar el importe del pago.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal Monto {
            get {
                return this.montoField;
            }
            set {
                this.montoField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar el número de cheque, número de autorización, número de referencia, clave de rastreo en caso de ser SPEI, línea de captura o algún número de referencia análogo que identifique la operación que ampara el pago efectuado.
        /// </summary>
        [XmlAttributeAttribute()]
        public string NumOperacion {
            get {
                return this.numOperacionField;
            }
            set {
                this.numOperacionField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar la clave RFC de la entidad emisora de la cuenta origen, es decir, la operadora, el banco, la institución financiera, emisor de monedero electrónico, etc., en caso de ser extranjero colocar XEXX010101000, considerar las reglas de obligatoriedad publicadas en la página del SAT para éste atributo de acuerdo con el catálogo catCFDI:c_FormaPago.
        /// </summary>
        [XmlAttributeAttribute()]
        public string RfcEmisorCtaOrd {
            get {
                return this.rfcEmisorCtaOrdField;
            }
            set {
                this.rfcEmisorCtaOrdField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar el nombre del banco ordenante, es requerido en caso de ser extranjero. Considerar las reglas de obligatoriedad publicadas en la página del SAT para éste atributo de acuerdo con el catálogo catCFDI:c_FormaPago.
        /// </summary>
        [XmlAttributeAttribute()]
        public string NomBancoOrdExt {
            get {
                return this.nomBancoOrdExtField;
            }
            set {
                this.nomBancoOrdExtField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para incorporar el número de la cuenta con la que se realizó el pago. Considerar las reglas de obligatoriedad publicadas en la página del SAT para éste atributo de acuerdo con el catálogo catCFDI:c_FormaPago.
        /// </summary>
        [XmlAttributeAttribute()]
        public string CtaOrdenante {
            get {
                return this.ctaOrdenanteField;
            }
            set {
                this.ctaOrdenanteField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar la clave RFC de la entidad operadora de la cuenta destino, es decir, la operadora, el banco, la institución financiera, emisor de monedero electrónico, etc. Considerar las reglas de obligatoriedad publicadas en la página del SAT para éste atributo de acuerdo con el catálogo catCFDI:c_FormaPago.
        /// </summary>
        [XmlAttributeAttribute()]
        public string RfcEmisorCtaBen {
            get {
                return this.rfcEmisorCtaBenField;
            }
            set {
                this.rfcEmisorCtaBenField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para incorporar el número de cuenta en donde se recibió el pago. Considerar las reglas de obligatoriedad publicadas en la página del SAT para éste atributo de acuerdo con el catálogo catCFDI:c_FormaPago.
        /// </summary>
        [XmlAttributeAttribute()]
        public string CtaBeneficiario {
            get {
                return this.ctaBeneficiarioField;
            }
            set {
                this.ctaBeneficiarioField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para identificar la clave del tipo de cadena de pago que genera la entidad receptora del pago. Considerar las reglas de obligatoriedad publicadas en la página del SAT para éste atributo de acuerdo con el catálogo catCFDI:c_FormaPago.
        /// </summary>
        [XmlAttributeAttribute()]
        public string TipoCadPago {
            get {
                return this.tipoCadPagoField;
            }
            set {
                this.tipoCadPagoField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TipoCadPagoSpecified {
            get {
                return this.tipoCadPagoFieldSpecified;
            }
            set {
                this.tipoCadPagoFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo condicional que sirve para incorporar el certificado que ampara al pago, como una cadena de texto en formato base 64. Es requerido en caso de que el atributo TipoCadPago contenga información.
        /// </summary>
        [XmlAttributeAttribute(DataType = "base64Binary")]
        public byte[] CertPago {
            get {
                return this.certPagoField;
            }
            set {
                this.certPagoField = value;
            }
        }

        [XmlIgnore]
        public string CertPagoB64 {
            get { if (this.CertPago != null)
                    return Convert.ToBase64String(this.CertPago);
                return null;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar la cadena original del comprobante de pago generado por la entidad emisora de la cuenta beneficiaria. Es requerido en caso de que el atributo TipoCadPago contenga información.
        /// </summary>
        [XmlAttributeAttribute()]
        public string CadPago {
            get {
                return this.cadPagoField;
            }
            set {
                this.cadPagoField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para integrar el sello digital que se asocie al pago. La entidad que emite el comprobante de pago, ingresa una cadena original y el sello digital en una sección de dicho comprobante, este sello digital es el que se debe registrar en este atributo. Debe ser expresado como una cadena de texto en formato base 64. Es requerido en caso de que el atributo TipoCadPago contenga información.
        /// </summary>
        [XmlAttributeAttribute(DataType = "base64Binary")]
        public byte[] SelloPago {
            get {
                return this.selloPagoField;
            }
            set {
                this.selloPagoField = value;
            }
        }

        [XmlIgnore]
        public string SelloBase64 {
            get { if (this.SelloPago != null)
                    return Convert.ToBase64String(this.SelloPago);
                return null;
            }
        }
    }

    /// <summary>
    /// Nodo requerido para expresar la lista de documentos relacionados con los pagos. Por cada documento que se relacione se debe generar un nodo DoctoRelacionado.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosPagoDoctoRelacionado {

        private PagosPagoDoctoRelacionadoImpuestosDR impuestosDRField;

        private string idDocumentoField;

        private string serieField;

        private string folioField;

        private string monedaDRField;

        private decimal equivalenciaDRField;

        private bool equivalenciaDRFieldSpecified;

        private string numParcialidadField;

        private decimal impSaldoAntField;

        private decimal impPagadoField;

        private decimal impSaldoInsolutoField;

        private string objetoImpDRField;

        /// <summary>
        /// Nodo condicional para registrar los impuestos aplicables conforme al monto del pago recibido, expresados a la moneda del documento relacionado.
        /// </summary>
        public PagosPagoDoctoRelacionadoImpuestosDR ImpuestosDR {
            get {
                return this.impuestosDRField;
            }
            set {
                this.impuestosDRField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar el identificador del documento relacionado con el pago. Este dato puede ser un Folio Fiscal de la Factura Electrónica o bien el número de operación de un documento digital.
        /// </summary>
        [XmlAttributeAttribute()]
        public string IdDocumento {
            get {
                return this.idDocumentoField;
            }
            set {
                this.idDocumentoField = value;
            }
        }

        /// <summary>
        /// Atributo opcional para precisar la serie del comprobante para control interno del contribuyente, acepta una cadena de caracteres.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Serie {
            get {
                return this.serieField;
            }
            set {
                this.serieField = value;
            }
        }

        /// <summary>
        /// Atributo opcional para precisar el folio del comprobante para control interno del contribuyente, acepta una cadena de caracteres.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Folio {
            get {
                return this.folioField;
            }
            set {
                this.folioField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para identificar la clave de la moneda utilizada en los importes del documento relacionado, cuando se usa moneda nacional o el documento relacionado no especifica la moneda se registra MXN. Los importes registrados en los atributos “ImpSaldoAnt”, “ImpPagado” e “ImpSaldoInsoluto” de éste nodo, deben corresponder a esta moneda. Conforme con la especificación ISO 4217.
        /// </summary>
        [XmlAttributeAttribute()]
        public string MonedaDR {
            get {
                return this.monedaDRField;
            }
            set {
                this.monedaDRField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar el tipo de cambio conforme con la moneda registrada en el documento relacionado. Es requerido cuando la moneda del documento relacionado es distinta de la moneda de pago. Se debe registrar el número de unidades de la moneda señalada en el documento relacionado que equivalen a una unidad de la moneda del pago. Por ejemplo: El documento relacionado se registra en USD. El pago se realiza por 100 EUR. Este atributo se registra como 1.114700 USD/EUR. El importe pagado equivale a 100 EUR * 1.114700 USD/EUR = 111.47 USD.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal EquivalenciaDR {
            get {
                return this.equivalenciaDRField;
            }
            set {
                this.equivalenciaDRField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool EquivalenciaDRSpecified {
            get {
                return this.equivalenciaDRFieldSpecified;
            }
            set {
                this.equivalenciaDRFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar el número de parcialidad que corresponde al pago.
        /// </summary>
        [XmlAttributeAttribute(DataType = "integer")]
        public string NumParcialidad {
            get {
                return this.numParcialidadField;
            }
            set {
                this.numParcialidadField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar el monto del saldo insoluto de la parcialidad anterior. En el caso de que sea la primer parcialidad este atributo debe contener el importe total del documento relacionado.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal ImpSaldoAnt {
            get {
                return this.impSaldoAntField;
            }
            set {
                this.impSaldoAntField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar el importe pagado para el documento relacionado.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal ImpPagado {
            get {
                return this.impPagadoField;
            }
            set {
                this.impPagadoField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar la diferencia entre el importe del saldo anterior y el monto del pago.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal ImpSaldoInsoluto {
            get {
                return this.impSaldoInsolutoField;
            }
            set {
                this.impSaldoInsolutoField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar si el pago del documento relacionado es objeto o no de impuesto.
        /// </summary>
        [XmlAttributeAttribute()]
        public string ObjetoImpDR {
            get {
                return this.objetoImpDRField;
            }
            set {
                this.objetoImpDRField = value;
            }
        }
    }

    /// <summary>
    /// Nodo condicional para registrar los impuestos aplicables conforme al monto del pago recibido, expresados a la moneda del documento relacionado.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosPagoDoctoRelacionadoImpuestosDR {

        private PagosPagoDoctoRelacionadoImpuestosDRRetencionDR[] retencionesDRField;

        private PagosPagoDoctoRelacionadoImpuestosDRTrasladoDR[] trasladosDRField;

        /// <summary>
        /// Nodo requerido para registrar la información detallada de una retención de impuesto específico conforme al monto del pago recibido.
        /// </summary>
        [XmlArrayItemAttribute("RetencionDR", IsNullable = false)]
        public PagosPagoDoctoRelacionadoImpuestosDRRetencionDR[] RetencionesDR {
            get {
                return this.retencionesDRField;
            }
            set {
                this.retencionesDRField = value;
            }
        }

        /// <summary>
        /// Nodo opcional para capturar los impuestos trasladados aplicables conforme al monto del pago recibido.
        /// </summary>
        [XmlArrayItemAttribute("TrasladoDR", IsNullable = false)]
        public PagosPagoDoctoRelacionadoImpuestosDRTrasladoDR[] TrasladosDR {
            get {
                return this.trasladosDRField;
            }
            set {
                this.trasladosDRField = value;
            }
        }
    }

    /// <summary>
    /// Nodo requerido para registrar la información detallada de una retención de impuesto específico conforme al monto del pago recibido.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosPagoDoctoRelacionadoImpuestosDRRetencionDR {

        private decimal baseDRField;

        private string impuestoDRField;

        private string tipoFactorDRField;

        private decimal tasaOCuotaDRField;

        private decimal importeDRField;

        /// <summary>
        /// Atributo requerido para señalar la base para el cálculo de la retención conforme al monto del pago, aplicable al documento relacionado, la determinación de la base se realiza de acuerdo con las disposiciones fiscales vigentes. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal BaseDR {
            get {
                return this.baseDRField;
            }
            set {
                this.baseDRField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para señalar la clave del tipo de impuesto retenido conforme al monto del pago, aplicable al documento relacionado.
        /// </summary>
        [XmlAttributeAttribute()]
        public string ImpuestoDR {
            get {
                return this.impuestoDRField;
            }
            set {
                this.impuestoDRField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para señalar la clave del tipo de factor que se aplica a la base del impuesto.
        /// </summary>
        [XmlAttributeAttribute()]
        public string TipoFactorDR {
            get {
                return this.tipoFactorDRField;
            }
            set {
                this.tipoFactorDRField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para señalar el valor de la tasa o cuota del impuesto que se retiene.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal TasaOCuotaDR {
            get {
                return this.tasaOCuotaDRField;
            }
            set {
                this.tasaOCuotaDRField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para señalar el importe del impuesto retenido conforme al monto del pago, aplicable al documento relacionado. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal ImporteDR {
            get {
                return this.importeDRField;
            }
            set {
                this.importeDRField = value;
            }
        }
    }

    /// <summary>
    /// Nodo requerido para asentar la información detallada de un traslado de impuesto específico conforme al monto del pago recibido.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosPagoDoctoRelacionadoImpuestosDRTrasladoDR {

        private decimal baseDRField;

        private string impuestoDRField;

        private string tipoFactorDRField;

        private decimal tasaOCuotaDRField;

        private bool tasaOCuotaDRFieldSpecified;

        private decimal importeDRField;

        private bool importeDRFieldSpecified;

        /// <summary>
        /// Atributo requerido para señalar la base para el cálculo del impuesto trasladado conforme al monto del pago, aplicable al documento relacionado, la determinación de la base se realiza de acuerdo con las disposiciones fiscales vigentes. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal BaseDR {
            get {
                return this.baseDRField;
            }
            set {
                this.baseDRField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para señalar la clave del tipo de impuesto trasladado conforme al monto del pago, aplicable al documento relacionado.
        /// </summary>
        [XmlAttributeAttribute()]
        public string ImpuestoDR {
            get {
                return this.impuestoDRField;
            }
            set {
                this.impuestoDRField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para señalar la clave del tipo de factor que se aplica a la base del impuesto.
        /// </summary>
        [XmlAttributeAttribute()]
        public string TipoFactorDR {
            get {
                return this.tipoFactorDRField;
            }
            set {
                this.tipoFactorDRField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para señalar el valor de la tasa o cuota del impuesto que se traslada. Es requerido cuando el atributo TipoFactorDR contenga una clave que corresponda a Tasa o Cuota.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal TasaOCuotaDR {
            get {
                return this.tasaOCuotaDRField;
            }
            set {
                this.tasaOCuotaDRField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TasaOCuotaDRSpecified {
            get {
                return this.tasaOCuotaDRFieldSpecified;
            }
            set {
                this.tasaOCuotaDRFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo condicional para señalar el importe del impuesto trasladado conforme al monto del pago, aplicable al documento relacionado. No se permiten valores negativos. Es requerido cuando el tipo factor sea Tasa o Cuota.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal ImporteDR {
            get {
                return this.importeDRField;
            }
            set {
                this.importeDRField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ImporteDRSpecified {
            get {
                return this.importeDRFieldSpecified;
            }
            set {
                this.importeDRFieldSpecified = value;
            }
        }
    }

    /// <summary>
    /// Nodo condicional para registrar el resumen de los impuestos aplicables conforme al monto del pago recibido, expresados a la moneda de pago.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosPagoImpuestosP {

        private PagosPagoImpuestosPRetencionP[] retencionesPField;

        private PagosPagoImpuestosPTrasladoP[] trasladosPField;

        /// <summary>
        /// Nodo condicional para señalar los impuestos retenidos aplicables conforme al monto del pago recibido. Es requerido cuando en los documentos relacionados se registre algún impuesto retenido.
        /// </summary>
        [XmlArrayItemAttribute("RetencionP", IsNullable = false)]
        public PagosPagoImpuestosPRetencionP[] RetencionesP {
            get {
                return this.retencionesPField;
            }
            set {
                this.retencionesPField = value;
            }
        }

        /// <summary>
        /// Nodo requerido para señalar la información detallada de una retención de impuesto específico conforme al monto del pago recibido.
        /// </summary>
        [XmlArrayItemAttribute("TrasladoP", IsNullable = false)]
        public PagosPagoImpuestosPTrasladoP[] TrasladosP {
            get {
                return this.trasladosPField;
            }
            set {
                this.trasladosPField = value;
            }
        }
    }

    /// <summary>
    /// Nodo condicional para señalar los impuestos retenidos aplicables conforme al monto del pago recibido. Es requerido cuando en los documentos relacionados se registre algún impuesto retenido.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosPagoImpuestosPRetencionP {

        private string impuestoPField;

        private decimal importePField;

        /// <summary>
        /// Atributo requerido para señalar la clave del tipo de impuesto retenido conforme al monto del pago.
        /// </summary>
        [XmlAttributeAttribute()]
        public string ImpuestoP {
            get {
                return this.impuestoPField;
            }
            set {
                this.impuestoPField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para señalar el importe del impuesto retenido conforme al monto del pago. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal ImporteP {
            get {
                return this.importePField;
            }
            set {
                this.importePField = value;
            }
        }
    }

    /// <summary>
    /// Nodo requerido para señalar la información detallada de una retención de impuesto específico conforme al monto del pago recibido.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos20")]
    public partial class PagosPagoImpuestosPTrasladoP {

        private decimal basePField;

        private string impuestoPField;

        private string tipoFactorPField;

        private decimal tasaOCuotaPField;

        private bool tasaOCuotaPFieldSpecified;

        private decimal importePField;

        private bool importePFieldSpecified;

        /// <summary>
        /// Atributo requerido para señalar la suma de los atributos BaseDR de los documentos relacionados del impuesto trasladado. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal BaseP {
            get {
                return this.basePField;
            }
            set {
                this.basePField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para señalar la clave del tipo de impuesto trasladado conforme al monto del pago.
        /// </summary>
        [XmlAttributeAttribute()]
        public string ImpuestoP {
            get {
                return this.impuestoPField;
            }
            set {
                this.impuestoPField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para señalar la clave del tipo de factor que se aplica a la base del impuesto.
        /// </summary>
        [XmlAttributeAttribute()]
        public string TipoFactorP {
            get {
                return this.tipoFactorPField;
            }
            set {
                this.tipoFactorPField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para señalar el valor de la tasa o cuota del impuesto que se traslada en los documentos relacionados.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal TasaOCuotaP {
            get {
                return this.tasaOCuotaPField;
            }
            set {
                this.tasaOCuotaPField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TasaOCuotaPSpecified {
            get {
                return this.tasaOCuotaPFieldSpecified;
            }
            set {
                this.tasaOCuotaPFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo condicional para señalar la suma del impuesto trasladado, agrupado por ImpuestoP, TipoFactorP y TasaOCuotaP. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal ImporteP {
            get {
                return this.importePField;
            }
            set {
                this.importePField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ImportePSpecified {
            get {
                return this.importePFieldSpecified;
            }
            set {
                this.importePFieldSpecified = value;
            }
        }
    }
}