using System;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Xml.Xsl;
using System.Xml.XPath;
using Jaeger.SAT.CFDI.Services;

namespace Jaeger.SAT.CFDI.V40 {
    // 
    // Este código fuente fue generado automáticamente por xsd, Versión=4.8.3928.0.
    // 
    /// <summary>
    /// Estándar de Comprobante Fiscal Digital por Internet.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/cfd/4", IsNullable = false)]
    public partial class Comprobante {
        [XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string XsiSchemaLocation;

        private ComprobanteInformacionGlobal informacionGlobalField;

        private ComprobanteCfdiRelacionados[] cfdiRelacionadosField;

        private ComprobanteEmisor emisorField;

        private ComprobanteReceptor receptorField;

        private ComprobanteConcepto[] conceptosField;

        private ComprobanteImpuestos impuestosField;

        private ComprobanteComplemento complementoField;

        private ComprobanteAddenda addendaField;

        private string versionField;

        private string serieField;

        private string folioField;

        private System.DateTime fechaField;

        private string selloField;

        private string formaPagoField;

        private bool formaPagoFieldSpecified;

        private string noCertificadoField;

        private string certificadoField;

        private string condicionesDePagoField;

        private decimal subTotalField;

        private decimal descuentoField;

        private bool descuentoFieldSpecified;

        private string monedaField;

        private decimal tipoCambioField;

        private bool tipoCambioFieldSpecified;

        private decimal totalField;

        private string tipoDeComprobanteField;

        private string exportacionField;

        private string metodoPagoField;

        private bool metodoPagoFieldSpecified;

        private string lugarExpedicionField;

        private string confirmacionField;

        public Comprobante() {
            this.versionField = "4.0";
        }

        /// <summary>
        /// Nodo condicional para precisar la información relacionada con el comprobante global.
        /// </summary>
        public ComprobanteInformacionGlobal InformacionGlobal {
            get {
                return this.informacionGlobalField;
            }
            set {
                this.informacionGlobalField = value;
            }
        }

        /// <summary>
        /// Nodo opcional para precisar la información de los comprobantes relacionados.
        /// </summary>
        [XmlElementAttribute("CfdiRelacionados")]
        public ComprobanteCfdiRelacionados[] CfdiRelacionados {
            get {
                return this.cfdiRelacionadosField;
            }
            set {
                this.cfdiRelacionadosField = value;
            }
        }

        /// <summary>
        /// Nodo requerido para expresar la información del contribuyente emisor del comprobante.
        /// </summary>
        public ComprobanteEmisor Emisor {
            get {
                return this.emisorField;
            }
            set {
                this.emisorField = value;
            }
        }

        /// <summary>
        /// Nodo requerido para precisar la información del contribuyente receptor del comprobante.
        /// </summary>
        public ComprobanteReceptor Receptor {
            get {
                return this.receptorField;
            }
            set {
                this.receptorField = value;
            }
        }

        /// <summary>
        /// Nodo requerido para listar los conceptos cubiertos por el comprobante.
        /// </summary>
        [XmlArrayItemAttribute("Concepto", IsNullable = false)]
        public ComprobanteConcepto[] Conceptos {
            get {
                return this.conceptosField;
            }
            set {
                this.conceptosField = value;
            }
        }

        /// <summary>
        /// Nodo condicional para expresar el resumen de los impuestos aplicables.
        /// </summary>
        public ComprobanteImpuestos Impuestos {
            get {
                return this.impuestosField;
            }
            set {
                this.impuestosField = value;
            }
        }

        /// <summary>
        /// Nodo opcional donde se incluye el complemento Timbre Fiscal Digital de manera obligatoria y los nodos complementarios determinados por el SAT, de acuerdo con las disposiciones particulares para un sector o actividad específica.
        /// </summary>
        public ComprobanteComplemento Complemento {
            get {
                return this.complementoField;
            }
            set {
                this.complementoField = value;
            }
        }

        /// <summary>
        /// Nodo opcional para recibir las extensiones al presente formato que sean de utilidad al contribuyente. Para las reglas de uso del mismo, referirse al formato origen.
        /// </summary>
        public ComprobanteAddenda Addenda {
            get {
                return this.addendaField;
            }
            set {
                this.addendaField = value;
            }
        }

        /// <summary>
        /// Atributo requerido con valor prefijado a 4.0 que indica la versión del estándar bajo el que se encuentra expresado el comprobante.
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

        /// <summary>
        /// Atributo opcional para precisar la serie para control interno del contribuyente. Este atributo acepta una cadena de caracteres.
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
        /// Atributo opcional para control interno del contribuyente que expresa el folio del comprobante, acepta una cadena de caracteres.
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
        /// Atributo requerido para la expresión de la fecha y hora de expedición del Comprobante Fiscal Digital por Internet. Se expresa en la forma AAAA-MM-DDThh:mm:ss y debe corresponder con la hora local donde se expide el comprobante.
        /// </summary>
        [XmlAttributeAttribute()]
        public System.DateTime Fecha {
            get {
                return this.fechaField;
            }
            set {
                this.fechaField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para contener el sello digital del comprobante fiscal, al que hacen referencia las reglas de resolución miscelánea vigente. El sello debe ser expresado como una cadena de texto en formato Base 64.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Sello {
            get {
                return this.selloField;
            }
            set {
                this.selloField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar la clave de la forma de pago de los bienes o servicios amparados por el comprobante.
        /// </summary>
        [XmlAttributeAttribute()]
        public string FormaPago {
            get {
                return this.formaPagoField;
            }
            set {
                this.formaPagoField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool FormaPagoSpecified {
            get {
                return this.formaPagoFieldSpecified;
            }
            set {
                this.formaPagoFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar el número de serie del certificado de sello digital que ampara al comprobante, de acuerdo con el acuse correspondiente a 20 posiciones otorgado por el sistema del SAT.
        /// </summary>
        [XmlAttributeAttribute()]
        public string NoCertificado {
            get {
                return this.noCertificadoField;
            }
            set {
                this.noCertificadoField = value;
            }
        }

        /// <summary>
        /// Atributo requerido que sirve para incorporar el certificado de sello digital que ampara al comprobante, como texto en formato base 64.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Certificado {
            get {
                return this.certificadoField;
            }
            set {
                this.certificadoField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar las condiciones comerciales aplicables para el pago del comprobante fiscal digital por Internet. Este atributo puede ser condicionado mediante atributos o complementos.
        /// </summary>
        [XmlAttributeAttribute()]
        public string CondicionesDePago {
            get {
                return this.condicionesDePagoField;
            }
            set {
                this.condicionesDePagoField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para representar la suma de los importes de los conceptos antes de descuentos e impuesto. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal SubTotal {
            get {
                return this.subTotalField;
            }
            set {
                this.subTotalField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para representar el importe total de los descuentos aplicables antes de impuestos. No se permiten valores negativos. Se debe registrar cuando existan conceptos con descuento
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
        [XmlIgnoreAttribute()]
        public bool DescuentoSpecified {
            get {
                return this.descuentoFieldSpecified;
            }
            set {
                this.descuentoFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo requerido para identificar la clave de la moneda utilizada para expresar los montos, cuando se usa moneda nacional se registra MXN. Conforme con la especificación ISO 4217.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Moneda {
            get {
                return this.monedaField;
            }
            set {
                this.monedaField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para representar el tipo de cambio FIX conforme con la moneda usada. Es requerido cuando la clave de moneda es distinta de MXN y de XXX. El valor debe reflejar el 
        /// número de pesos mexicanos que equivalen a una unidad de la divisa señalada en el atributo moneda. Si el valor está fuera del porcentaje aplicable a la moneda tomado del catálogo c_Moneda, 
        /// el emisor debe obtener del PAC que vaya a timbrar el CFDI, de manera no automática, una clave de confirmación para ratificar que el valor es correcto e integrar dicha clave en el atributo 
        /// Confirmacion.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal TipoCambio {
            get {
                return this.tipoCambioField;
            }
            set {
                this.tipoCambioField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TipoCambioSpecified {
            get {
                return this.tipoCambioFieldSpecified;
            }
            set {
                this.tipoCambioFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo requerido para representar la suma del subtotal, menos los descuentos aplicables, más las contribuciones recibidas (impuestos trasladados - federales y/o locales, derechos, 
        /// productos, aprovechamientos, aportaciones de seguridad social, contribuciones de mejoras) menos los impuestos retenidos federales y/o locales. Si el valor es superior al límite que 
        /// establezca el SAT en la Resolución Miscelánea Fiscal vigente, el emisor debe obtener del PAC que vaya a timbrar el CFDI, de manera no automática, una clave de confirmación para 
        /// ratificar que el valor es correcto e integrar dicha clave en el atributo Confirmacion. No se permiten valores negativos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal Total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar la clave del efecto del comprobante fiscal para el contribuyente emisor.
        /// </summary>
        [XmlAttributeAttribute()]
        public string TipoDeComprobante {
            get {
                return this.tipoDeComprobanteField;
            }
            set {
                this.tipoDeComprobanteField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar si el comprobante ampara una operación de exportación.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Exportacion {
            get {
                return this.exportacionField;
            }
            set {
                this.exportacionField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para precisar la clave del método de pago que aplica para este comprobante fiscal digital por Internet, conforme al Artículo 29-A fracción VII incisos a y b del CFF.
        /// </summary>
        [XmlAttributeAttribute()]
        public string MetodoPago {
            get {
                return this.metodoPagoField;
            }
            set {
                this.metodoPagoField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool MetodoPagoSpecified {
            get {
                return this.metodoPagoFieldSpecified;
            }
            set {
                this.metodoPagoFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo requerido para incorporar el código postal del lugar de expedición del comprobante (domicilio de la matriz o de la sucursal).
        /// </summary>
        [XmlAttributeAttribute()]
        public string LugarExpedicion {
            get {
                return this.lugarExpedicionField;
            }
            set {
                this.lugarExpedicionField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para registrar la clave de confirmación que entregue el PAC para expedir el comprobante con importes grandes, con un tipo de cambio fuera del rango establecido o con 
        /// ambos casos. Es requerido cuando se registra un tipo de cambio o un total fuera del rango establecido.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Confirmacion {
            get {
                return this.confirmacionField;
            }
            set {
                this.confirmacionField = value;
            }
        }

        #region serializacion

        private static XmlSerializer objSerializer;

        [XmlIgnore]
        public string OriginalXmlString { get; set; }

        private static XmlSerializer Serializer {
            get {
                if (Comprobante.objSerializer == null) {
                    Comprobante.objSerializer = (new XmlSerializerFactory()).CreateSerializer(typeof(Comprobante));
                }
                return Comprobante.objSerializer;
            }
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        public static Comprobante Deserialize(string input) {
            Comprobante objComprobante;
            using (StringReader stringReader = new StringReader(input)) {
                Comprobante objComprobante1 = (Comprobante)Comprobante.Serializer.Deserialize(XmlReader.Create(stringReader));
                objComprobante1.OriginalXmlString = input;
                objComprobante = objComprobante1;
            }
            return objComprobante;
        }

        public static Comprobante Load(string fileName) {
            Comprobante comprobante;
            UTF8Encoding objUtf8WithoutBom = new UTF8Encoding(false);
            try {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read)) {
                    using (StreamReader streamReader = new StreamReader(fileStream, objUtf8WithoutBom)) {
                        comprobante = Comprobante.Deserialize(streamReader.ReadToEnd());
                    }
                }
                return comprobante;
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        /// <summary>
        /// cargar
        /// </summary>
        public static Comprobante LoadXml(string xmlString) {
            try {
                return Comprobante.Deserialize(xmlString);
            } catch (Exception ex) {
                Console.WriteLine(string.Concat("V40_LoadXML: ", ex.Message));
                return null;
            }
        }

        /// <summary>
        /// cargar xml de un arreglo de bytes
        /// </summary>
        public static Comprobante LoadBytes(byte[] xmlBytes) {
            Comprobante outComprobante;
            try {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Comprobante));
                XmlTextReader xmlTextReader = new XmlTextReader(new MemoryStream(xmlBytes));
                Comprobante t1 = (Comprobante)xmlSerializer.Deserialize(xmlTextReader);
                t1.OriginalXmlString = UTF8Encoding.UTF8.GetString(xmlBytes);
                xmlTextReader.Close();
                outComprobante = t1;
            } catch (Exception ex) {
                Console.WriteLine("CFDIv33: " + ex.Message);
                return null;
            }
            return outComprobante;
        }

        public static Comprobante LoadBase64(string base64) {
            var encodedString = Convert.FromBase64String(base64);
            return LoadBytes(encodedString);
        }

        public static Comprobante Load(Stream input) {
            using (var ms = new MemoryStream()) {
                input.CopyTo(ms);
                return LoadBytes(ms.ToArray());
            }
        }

        public virtual void Save(string fileName) {
            using (StreamWriter streamWriter = new StreamWriter(fileName, false, new UTF8Encoding(false))) {
                streamWriter.WriteLine(this.Serialize());
            }
        }

        public virtual string Serialize() {
            string end;
            List<XmlElement>.Enumerator enumerator = new List<XmlElement>.Enumerator();
            XmlWriterSettings xmlWriterSetting = new XmlWriterSettings() {
                Encoding = Encoding.UTF8,
                Indent = true,
                CloseOutput = false,
                OmitXmlDeclaration = false
            };
            using (MemoryStream memoryStream = new MemoryStream()) {
                XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSetting);
                XmlSerializerNamespaces xmlSerializerNamespace = new XmlSerializerNamespaces();
                xmlSerializerNamespace.Add("cfdi", "http://www.sat.gob.mx/cfd/4");
                xmlSerializerNamespace.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
                this.XsiSchemaLocation = "http://www.sat.gob.mx/cfd/4 http://www.sat.gob.mx/sitio_internet/cfd/4/cfdv40.xsd";
                if (this.Complemento != null) {
                    try {
                        enumerator = this.Complemento.Any.GetEnumerator();
                        while (enumerator.MoveNext()) {
                            string name = enumerator.Current.Name;
                            string str = name;
                            if (name != null) {
                                if (str == "nomina12:Nomina") {
                                    xmlSerializerNamespace.Add("nomina12", "http://www.sat.gob.mx/nomina12");
                                    this.XsiSchemaLocation = string.Concat(this.XsiSchemaLocation, " http://www.sat.gob.mx/nomina http://www.sat.gob.mx/sitio_internet/cfd/nomina/nomina12.xsd");
                                } else if (str == "pago20:Pagos") {
                                    xmlSerializerNamespace.Add("pagos20", "http://www.sat.gob.mx/Pagos");
                                    this.XsiSchemaLocation = string.Concat(this.XsiSchemaLocation, "http://www.sat.gob.mx/Pagos http://www.sat.gob.mx/sitio_internet/cfd/Pagos/Pagos20.xsd");
                                } else if (str == "implocal:ImpuestosLocales") {
                                    xmlSerializerNamespace.Add("implocal", "http://www.sat.gob.mx/implocal");
                                    this.XsiSchemaLocation = string.Concat(this.XsiSchemaLocation, " http://www.sat.gob.mx/implocal http://www.sat.gob.mx/sitio_internet/cfd/implocal/implocal.xsd");
                                }
                            }
                        }
                    } finally {
                        ((IDisposable)enumerator).Dispose();
                    }
                }
                this.Addenda = null;
                Comprobante.Serializer.Serialize(xmlWriter, this, xmlSerializerNamespace);
                memoryStream.Seek((long)0, SeekOrigin.Begin);
                using (StreamReader streamReader = new StreamReader(memoryStream, Encoding.UTF8)) {
                    end = streamReader.ReadToEnd();
                }
            }
            return end;
        }

        /// <summary>
        /// metodo para validar el sello del emisor del CFDI
        /// </summary>
        [XmlIgnore]
        public bool SelloValido {
            get {
                X509Certificate2 x509Certificate2 = new X509Certificate2();
                x509Certificate2.Import(Convert.FromBase64String(this.certificadoField));
                RSACryptoServiceProvider key = (RSACryptoServiceProvider)x509Certificate2.PublicKey.Key;
                bool selloValido = key.VerifyData(Encoding.UTF8.GetBytes(this.CadenaOriginal), CryptoConfig.MapNameToOID("SHA256"), Convert.FromBase64String(this.Sello));
                return selloValido;
            }
        }

        /// <summary>
        /// metodo para obtener cadena original en linea
        /// </summary>
        [XmlIgnore]
        public string CadenaOriginal {
            get {
                try {
                    string outOriginalString;
                    using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Jaeger.SAT.CFDI.xslt.cadenaoriginal_4_0.xslt")) {
                        if (manifestResourceStream == null) {
                            outOriginalString = null;
                        } else {
                            XmlDocument xmlDocument = new XmlDocument();
                            xmlDocument.Load(manifestResourceStream);
                            using (StringWriter stringWriter = new StringWriter()) {
                                using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter)) {
                                    XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
                                    xslCompiledTransform.Load(xmlDocument);
                                    xslCompiledTransform.Transform(new XPathDocument(new StringReader(this.Serialize())), null, xmlTextWriter);
                                    outOriginalString = stringWriter.ToString().Replace("&amp;", "&");
                                }
                            }
                        }
                    }
                    return outOriginalString;
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                    throw;
                }

            }
        }

        /// <summary>
        /// metodo para obtener cadena original con recursos locales
        /// </summary>
        [XmlIgnore]
        public string CadenaOriginalOff {
            get {
                string outOriginalString;
                using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Jaeger.SAT.CFDI.xslt.cadenaoriginal_4_0_offline.xslt")) {
                    if (manifestResourceStream == null) {
                        outOriginalString = null;
                    } else {
                        var localXslt = new XmlDocument();
                        localXslt.Load(manifestResourceStream);
                        using (StringWriter stringWriter = new StringWriter()) {
                            using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter)) {
                                XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
                                xslCompiledTransform.Load(localXslt, null, new XmlResolverService());
                                xslCompiledTransform.Transform(new XPathDocument(new StringReader(this.Serialize())), null, xmlTextWriter);
                                outOriginalString = stringWriter.ToString().Replace("&amp;", "&");
                            }
                        }
                    }
                }
                return outOriginalString;
            }
        }

        [XmlIgnore]
        public string CadenaOriginal2Off {
            get {
                string outOriginalString;
                using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Jaeger.SAT.CFDI.xslt.cadenaoriginal_4_0_offline.xslt")) {
                    if (manifestResourceStream == null) {
                        outOriginalString = null;
                    } else {
                        var localXslt = new XmlDocument();
                        localXslt.Load(manifestResourceStream);
                        using (StringWriter stringWriter = new StringWriter()) {
                            using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter)) {
                                XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
                                xslCompiledTransform.Load(localXslt, null, new XmlResolverService());
                                xslCompiledTransform.Transform(new XPathDocument(new StringReader(this.OriginalXmlString)), null, xmlTextWriter);
                                outOriginalString = stringWriter.ToString().Replace("&amp;", "&");
                            }
                        }
                    }
                }
                return outOriginalString;
            }
        }

        #endregion
    }

    /// <summary>
    /// Nodo opcional para precisar la información de los comprobantes relacionados.<
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteCfdiRelacionados {

        private ComprobanteCfdiRelacionadosCfdiRelacionado[] cfdiRelacionadoField;

        private string tipoRelacionField;

        /// <summary>
        /// Nodo requerido para precisar la información de los comprobantes relacionados.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("CfdiRelacionado")]
        public ComprobanteCfdiRelacionadosCfdiRelacionado[] CfdiRelacionado {
            get {
                return this.cfdiRelacionadoField;
            }
            set {
                this.cfdiRelacionadoField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para indicar la clave de la relación que existe entre éste que se está generando y el o los CFDI previos.
        /// </summary>
        [XmlAttributeAttribute()]
        public string TipoRelacion {
            get {
                return this.tipoRelacionField;
            }
            set {
                this.tipoRelacionField = value;
            }
        }
    }

    /// <summary>
    /// Nodo requerido para precisar la información de los comprobantes relacionados.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteCfdiRelacionadosCfdiRelacionado {

        private string uUIDField;

        /// <summary>
        /// Atributo requerido para registrar el folio fiscal (UUID) de un CFDI relacionado con el presente comprobante, por ejemplo: Si el CFDI relacionado es un comprobante de traslado 
        /// que sirve para registrar el movimiento de la mercancía. Si este comprobante se usa como nota de crédito o nota de débito del comprobante relacionado. Si este comprobante es 
        /// una devolución sobre el comprobante relacionado. Si éste sustituye a una factura cancelada.
        /// </summary>
        [XmlAttributeAttribute()]
        public string UUID {
            get {
                return this.uUIDField;
            }
            set {
                this.uUIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteEmisor {

        private string rfcField;

        private string nombreField;

        private string regimenFiscalField;

        private string facAtrAdquirenteField;

        /// <summary>
        /// Atributo requerido para registrar la Clave del Registro Federal de Contribuyentes correspondiente al contribuyente emisor del comprobante.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Rfc {
            get {
                return this.rfcField;
            }
            set {
                this.rfcField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para registrar el nombre, denominación o razón social del contribuyente inscrito en el RFC, del emisor del comprobante.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para incorporar la clave del régimen del contribuyente emisor al que aplicará el efecto fiscal de este comprobante.
        /// </summary>
        [XmlAttributeAttribute()]
        public string RegimenFiscal {
            get {
                return this.regimenFiscalField;
            }
            set {
                this.regimenFiscalField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar el número de operación proporcionado por el SAT cuando se trate de un comprobante a través de un PCECFDI o un PCGCFDISP.
        /// </summary>
        [XmlAttributeAttribute()]
        public string FacAtrAdquirente {
            get {
                return this.facAtrAdquirenteField;
            }
            set {
                this.facAtrAdquirenteField = value;
            }
        }
    }

    /// <summary>
    /// Nodo requerido para precisar la información del contribuyente receptor del comprobante.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteReceptor {

        private string rfcField;

        private string nombreField;

        private string domicilioFiscalReceptorField;

        private string residenciaFiscalField;

        private bool residenciaFiscalFieldSpecified;

        private string numRegIdTribField;

        private string regimenFiscalReceptorField;

        private string usoCFDIField;

        /// <summary>
        /// Atributo requerido para registrar la Clave del Registro Federal de Contribuyentes correspondiente al contribuyente receptor del comprobante.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Rfc {
            get {
                return this.rfcField;
            }
            set {
                this.rfcField = value;
            }
        }

        /// <summary>
        /// Se debe registrar el nombre, primer apellido, segundo apellido, según corresponda denominación o razón social registrados en el RFC del contribuyente receptor del comprobante.
        /// En el caso de personas morales se debe adicionar el régimen societario.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
            }
        }

        /// <summary>
        /// Se debe registrar el código postal del domicilio fiscal del receptor del comprobante. El código postal, en caso de que sea diferente de los RFC genéricos, debe estar asociado a 
        /// la clave de RFC registrado en el campo Rfc de este Nodo.
        /// </summary>
        [XmlAttributeAttribute()]
        public string DomicilioFiscalReceptor {
            get {
                return this.domicilioFiscalReceptorField;
            }
            set {
                this.domicilioFiscalReceptorField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para registrar la clave del país de residencia para efectos fiscales del receptor del comprobante, cuando se trate de un extranjero, y que es conforme con 
        /// la especificación ISO 3166-1 alpha-3. Es requerido cuando se incluya el complemento de comercio exterior o se registre el atributo NumRegIdTrib.
        /// </summary>
        [XmlAttributeAttribute()]
        public string ResidenciaFiscal {
            get {
                return this.residenciaFiscalField;
            }
            set {
                this.residenciaFiscalField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool ResidenciaFiscalSpecified {
            get {
                return this.residenciaFiscalFieldSpecified;
            }
            set {
                this.residenciaFiscalFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar el número de registro de identidad fiscal del receptor cuando sea residente en el extranjero. Es requerido cuando se incluya el complemento de 
        /// comercio exterior.
        /// </summary>
        [XmlAttributeAttribute()]
        public string NumRegIdTrib {
            get {
                return this.numRegIdTribField;
            }
            set {
                this.numRegIdTribField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para incorporar la clave del régimen fiscal del contribuyente receptor al que aplicará el efecto fiscal de este comprobante.
        /// </summary>
        [XmlAttributeAttribute()]
        public string RegimenFiscalReceptor {
            get {
                return this.regimenFiscalReceptorField;
            }
            set {
                this.regimenFiscalReceptorField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar la clave del uso que dará a esta factura el receptor del CFDI.
        /// </summary>
        [XmlAttributeAttribute()]
        public string UsoCFDI {
            get {
                return this.usoCFDIField;
            }
            set {
                this.usoCFDIField = value;
            }
        }
    }

    /// <summary>
    /// Nodo condicional para expresar el resumen de los impuestos aplicables.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteImpuestos {

        private ComprobanteImpuestosRetencion[] retencionesField;

        private ComprobanteImpuestosTraslado[] trasladosField;

        private decimal totalImpuestosRetenidosField;

        private bool totalImpuestosRetenidosFieldSpecified;

        private decimal totalImpuestosTrasladadosField;

        private bool totalImpuestosTrasladadosFieldSpecified;

        /// <summary>
        /// Nodo condicional para capturar los impuestos retenidos aplicables. Es requerido cuando en los conceptos se registre algún impuesto retenido.
        /// </summary>
        [System.Xml.Serialization.XmlArrayItemAttribute("Retencion", IsNullable = false)]
        public ComprobanteImpuestosRetencion[] Retenciones {
            get {
                return this.retencionesField;
            }
            set {
                this.retencionesField = value;
            }
        }

        /// <summary>
        /// Nodo condicional para capturar los impuestos trasladados aplicables. Es requerido cuando en los conceptos se registre un impuesto trasladado.
        /// </summary>
        [System.Xml.Serialization.XmlArrayItemAttribute("Traslado", IsNullable = false)]
        public ComprobanteImpuestosTraslado[] Traslados {
            get {
                return this.trasladosField;
            }
            set {
                this.trasladosField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar el total de los impuestos retenidos que se desprenden de los conceptos expresados en el comprobante fiscal 
        /// digital por Internet. No se permiten valores negativos. Es requerido cuando en los conceptos se registren impuestos retenidos.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal TotalImpuestosRetenidos {
            get {
                return this.totalImpuestosRetenidosField;
            }
            set {
                this.totalImpuestosRetenidosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalImpuestosRetenidosSpecified {
            get {
                return this.totalImpuestosRetenidosFieldSpecified;
            }
            set {
                this.totalImpuestosRetenidosFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo condicional para expresar el total de los impuestos trasladados que se desprenden de los conceptos expresados en el comprobante fiscal 
        /// digital por Internet. No se permiten valores negativos. Es requerido cuando en los conceptos se registren impuestos trasladados.
        /// </summary>
        [XmlAttributeAttribute()]
        public decimal TotalImpuestosTrasladados {
            get {
                return this.totalImpuestosTrasladadosField;
            }
            set {
                this.totalImpuestosTrasladadosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalImpuestosTrasladadosSpecified {
            get {
                return this.totalImpuestosTrasladadosFieldSpecified;
            }
            set {
                this.totalImpuestosTrasladadosFieldSpecified = value;
            }
        }
    }

    /// <summary>
    /// Nodo requerido para la información detallada de una retención de impuesto específico.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteImpuestosRetencion {

        private string impuestoField;

        private decimal importeField;

        /// <summary>
        /// Atributo requerido para señalar la clave del tipo de impuesto retenido.
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
        /// Atributo requerido para señalar el monto del impuesto retenido. No se permiten valores negativos.
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
    /// Nodo requerido para la información detallada de un traslado de impuesto específico.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteImpuestosTraslado {

        private decimal baseField;

        private string impuestoField;

        private string tipoFactorField;

        private decimal tasaOCuotaField;

        private bool tasaOCuotaFieldSpecified;

        private decimal importeField;

        private bool importeFieldSpecified;

        /// <summary>
        /// Atributo requerido para señalar la suma de los atributos Base de los conceptos del impuesto trasladado. No se permiten valores negativos.
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
        /// Atributo requerido para señalar la clave del tipo de impuesto trasladado.
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
        /// Atributo condicional para señalar el valor de la tasa o cuota del impuesto que se traslada por los conceptos amparados en el comprobante.
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
        /// Atributo condicional para señalar la suma del importe del impuesto trasladado, agrupado por impuesto, TipoFactor y TasaOCuota. No se permiten valores negativos.
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
}
