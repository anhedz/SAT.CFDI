﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------
// 
// Este código fuente fue generado automáticamente por xsd, Versión=4.6.1055.0.
// 

using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Xml.Xsl;
using Jaeger.SAT.CFDI.Services;

namespace Jaeger.SAT.CFDI.Complemento.Pagos.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/Pagos", IsNullable = false)]
    public partial class Pagos {
        [XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string XsiSchemaLocation;

        private PagosPago[] pagoField;

        private string versionField;

        private static XmlSerializer objSerializer;

        public Pagos() {
            this.versionField = "1.0";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Pago")]
        public PagosPago[] Pago {
            get {
                return this.pagoField;
            }
            set {
                this.pagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
                using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Jaeger.Pagos10.xslt")) {
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

        private static XmlSerializer Serializer {
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
                xmlSerializerNamespace.Add("pagos10", "http://www.sat.gob.mx/Pagos");
                xmlSerializerNamespace.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
                this.XsiSchemaLocation = "http://www.sat.gob.mx/Pagos http://www.sat.gob.mx/sitio_internet/cfd/Pagos/Pagos10.xsd";
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
}

namespace Jaeger.SAT.CFDI.Complemento.Pagos.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos")]
    public partial class PagosPago {
        private PagosPagoDoctoRelacionado[] doctoRelacionadoField;

        private PagosPagoImpuestos[] impuestosField;

        private System.DateTime fechaPagoField;

        private string formaDePagoPField; //c_FormaPago

        private string monedaPField; //c_Moneda

        private decimal tipoCambioPField;

        private bool tipoCambioPFieldSpecified;

        private decimal montoField;

        private string numOperacionField;

        private string rfcEmisorCtaOrdField;

        private string nomBancoOrdExtField;

        private string ctaOrdenanteField;

        private string rfcEmisorCtaBenField;

        private string ctaBeneficiarioField;

        private string tipoCadPagoField; //c_TipoCadenaPago

        private bool tipoCadPagoFieldSpecified;

        private byte[] certPagoField;

        private string cadPagoField;

        private byte[] selloPagoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DoctoRelacionado")]
        public PagosPagoDoctoRelacionado[] DoctoRelacionado {
            get {
                return this.doctoRelacionadoField;
            }
            set {
                this.doctoRelacionadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Impuestos")]
        public PagosPagoImpuestos[] Impuestos {
            get {
                return this.impuestosField;
            }
            set {
                this.impuestosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime FechaPago {
            get {
                return this.fechaPagoField;
            }
            set {
                this.fechaPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FormaDePagoP {
            get {
                return this.formaDePagoPField;
            }
            set {
                this.formaDePagoPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MonedaP {
            get {
                return this.monedaPField;
            }
            set {
                this.monedaPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TipoCambioP {
            get {
                return this.tipoCambioPField;
            }
            set {
                this.tipoCambioPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TipoCambioPSpecified {
            get {
                return this.tipoCambioPFieldSpecified;
            }
            set {
                this.tipoCambioPFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Monto {
            get {
                return this.montoField;
            }
            set {
                this.montoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumOperacion {
            get {
                return this.numOperacionField;
            }
            set {
                this.numOperacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RfcEmisorCtaOrd {
            get {
                return this.rfcEmisorCtaOrdField;
            }
            set {
                this.rfcEmisorCtaOrdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NomBancoOrdExt {
            get {
                return this.nomBancoOrdExtField;
            }
            set {
                this.nomBancoOrdExtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CtaOrdenante {
            get {
                return this.ctaOrdenanteField;
            }
            set {
                this.ctaOrdenanteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RfcEmisorCtaBen {
            get {
                return this.rfcEmisorCtaBenField;
            }
            set {
                this.rfcEmisorCtaBenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CtaBeneficiario {
            get {
                return this.ctaBeneficiarioField;
            }
            set {
                this.ctaBeneficiarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoCadPago {
            get {
                return this.tipoCadPagoField;
            }
            set {
                this.tipoCadPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TipoCadPagoSpecified {
            get {
                return this.tipoCadPagoFieldSpecified;
            }
            set {
                this.tipoCadPagoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "base64Binary")]
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
            get {
                if (this.CertPago != null)
                    return Convert.ToBase64String(this.CertPago);
                return null;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CadPago {
            get {
                return this.cadPagoField;
            }
            set {
                this.cadPagoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "base64Binary")]
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
            get {
                if (this.SelloPago != null)
                    return Convert.ToBase64String(this.SelloPago);
                return null;
            }
        }
    }
}

namespace Jaeger.SAT.CFDI.Complemento.Pagos.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos")]
    public partial class PagosPagoDoctoRelacionado {
        private string idDocumentoField;

        private string serieField;

        private string folioField;

        private string monedaDRField; //c_Moneda

        private decimal tipoCambioDRField;

        private bool tipoCambioDRFieldSpecified;

        private string metodoDePagoDRField; //c_MetodoPago

        private string numParcialidadField;

        private decimal impSaldoAntField;

        private bool impSaldoAntFieldSpecified;

        private decimal impPagadoField;

        private bool impPagadoFieldSpecified;

        private decimal impSaldoInsolutoField;

        private bool impSaldoInsolutoFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IdDocumento {
            get {
                return this.idDocumentoField;
            }
            set {
                this.idDocumentoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Serie {
            get {
                return this.serieField;
            }
            set {
                this.serieField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Folio {
            get {
                return this.folioField;
            }
            set {
                this.folioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MonedaDR {
            get {
                return this.monedaDRField;
            }
            set {
                this.monedaDRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TipoCambioDR {
            get {
                return this.tipoCambioDRField;
            }
            set {
                this.tipoCambioDRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TipoCambioDRSpecified {
            get {
                return this.tipoCambioDRFieldSpecified;
            }
            set {
                this.tipoCambioDRFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MetodoDePagoDR {
            get {
                return this.metodoDePagoDRField;
            }
            set {
                this.metodoDePagoDRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string NumParcialidad {
            get {
                return this.numParcialidadField;
            }
            set {
                this.numParcialidadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ImpSaldoAnt {
            get {
                return this.impSaldoAntField;
            }
            set {
                this.impSaldoAntField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImpSaldoAntSpecified {
            get {
                return this.impSaldoAntFieldSpecified;
            }
            set {
                this.impSaldoAntFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ImpPagado {
            get {
                return this.impPagadoField;
            }
            set {
                this.impPagadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImpPagadoSpecified {
            get {
                return this.impPagadoFieldSpecified;
            }
            set {
                this.impPagadoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ImpSaldoInsoluto {
            get {
                return this.impSaldoInsolutoField;
            }
            set {
                this.impSaldoInsolutoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ImpSaldoInsolutoSpecified {
            get {
                return this.impSaldoInsolutoFieldSpecified;
            }
            set {
                this.impSaldoInsolutoFieldSpecified = value;
            }
        }
    }
}

namespace Jaeger.SAT.CFDI.Complemento.Pagos.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos")]
    public partial class PagosPagoImpuestos {
        private PagosPagoImpuestosRetencion[] retencionesField;

        private PagosPagoImpuestosTraslado[] trasladosField;

        private decimal totalImpuestosRetenidosField;

        private bool totalImpuestosRetenidosFieldSpecified;

        private decimal totalImpuestosTrasladadosField;

        private bool totalImpuestosTrasladadosFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Retencion", IsNullable = false)]
        public PagosPagoImpuestosRetencion[] Retenciones {
            get {
                return this.retencionesField;
            }
            set {
                this.retencionesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Traslado", IsNullable = false)]
        public PagosPagoImpuestosTraslado[] Traslados {
            get {
                return this.trasladosField;
            }
            set {
                this.trasladosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
}

namespace Jaeger.SAT.CFDI.Complemento.Pagos.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos")]
    public partial class PagosPagoImpuestosRetencion {
        private string impuestoField; //c_Impuesto

        private decimal importeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Impuesto {
            get {
                return this.impuestoField;
            }
            set {
                this.impuestoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Importe {
            get {
                return this.importeField;
            }
            set {
                this.importeField = value;
            }
        }
    }
}

namespace Jaeger.SAT.CFDI.Complemento.Pagos.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/Pagos")]
    public partial class PagosPagoImpuestosTraslado {
        private string impuestoField; //c_Impuesto

        private string tipoFactorField; //c_TipoFactor

        private decimal tasaOCuotaField;

        private decimal importeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Impuesto {
            get {
                return this.impuestoField;
            }
            set {
                this.impuestoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoFactor {
            get {
                return this.tipoFactorField;
            }
            set {
                this.tipoFactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TasaOCuota {
            get {
                return this.tasaOCuotaField;
            }
            set {
                this.tasaOCuotaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Importe {
            get {
                return this.importeField;
            }
            set {
                this.importeField = value;
            }
        }
    }
}