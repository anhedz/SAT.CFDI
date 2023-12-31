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
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Jaeger.SAT.CFDI.Services;

namespace Jaeger.SAT.CFDI {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/spei")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/spei", IsNullable = false)]
    public partial class Complemento_SPEI {
        private Complemento_SPEISPEI_Tercero[] sPEI_TerceroField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SPEI_Tercero")]
        public Complemento_SPEISPEI_Tercero[] SPEI_Tercero {
            get {
                return this.sPEI_TerceroField;
            }
            set {
                this.sPEI_TerceroField = value;
            }
        }

        #region serializacion

        private static XmlSerializer objSerializer;

        [XmlIgnore]
        public string OriginalXmlString {
            get;
            set;
        }

        /// <summary>
        /// tipo de comprobante (emitido, recibido, nomina, etc.)
        /// </summary>
        //[XmlIgnore]
        //public EnumCfdiSubType Type { get;set; }

        private static XmlSerializer Serializer {
            get {
                if (Complemento_SPEI.objSerializer == null) {
                    Complemento_SPEI.objSerializer = (new XmlSerializerFactory()).CreateSerializer(typeof(Complemento_SPEI));
                }
                return Complemento_SPEI.objSerializer;
            }
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        public static Complemento_SPEI Deserialize(string input) {
            Complemento_SPEI objComprobante;
            using (StringReader stringReader = new StringReader(input)) {
                Complemento_SPEI objComprobante1 = (Complemento_SPEI)Complemento_SPEI.Serializer.Deserialize(XmlReader.Create(stringReader));
                objComprobante1.OriginalXmlString = input;
                objComprobante = objComprobante1;
            }
            return objComprobante;
        }

        public static Complemento_SPEI Load(string fileName) {
            Complemento_SPEI comprobante;
            UTF8Encoding objUtf8WithoutBom = new UTF8Encoding(false);
            try {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read)) {
                    using (StreamReader streamReader = new StreamReader(fileStream, objUtf8WithoutBom)) {
                        comprobante = Complemento_SPEI.Deserialize(streamReader.ReadToEnd());
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
        public static Complemento_SPEI LoadXml(string xmlString) {
            try {
                return Complemento_SPEI.Deserialize(xmlString);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        #endregion
    }
}

namespace Jaeger.SAT.CFDI {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/spei")]
    [System.Xml.Serialization.XmlRoot("SPEI_Tercero")]
    public partial class Complemento_SPEISPEI_Tercero {
        private Complemento_SPEISPEI_TerceroOrdenante ordenanteField;

        private Complemento_SPEISPEI_TerceroBeneficiario beneficiarioField;

        private System.DateTime fechaOperacionField;

        private System.DateTime horaField;

        private string claveSPEIField;

        private string selloField;

        private string numeroCertificadoField;

        private string cadenaCDAField;

        /// <remarks/>
        [XmlElementAttribute("Beneficiario")]
        public Complemento_SPEISPEI_TerceroBeneficiario Beneficiario {
            get {
                return this.beneficiarioField;
            }
            set {
                this.beneficiarioField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("Ordenante")]
        public Complemento_SPEISPEI_TerceroOrdenante Ordenante {
            get {
                return this.ordenanteField;
            }
            set {
                this.ordenanteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime FechaOperacion {
            get {
                return this.fechaOperacionField;
            }
            set {
                this.fechaOperacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "time")]
        public System.DateTime Hora {
            get {
                return this.horaField;
            }
            set {
                this.horaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string ClaveSPEI {
            get {
                return this.claveSPEIField;
            }
            set {
                this.claveSPEIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string sello {
            get {
                return this.selloField;
            }
            set {
                this.selloField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string numeroCertificado {
            get {
                return this.numeroCertificadoField;
            }
            set {
                this.numeroCertificadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cadenaCDA {
            get {
                return this.cadenaCDAField;
            }
            set {
                this.cadenaCDAField = value;
            }
        }

        #region serializacion

        private static XmlSerializer objSerializer;

        [XmlIgnore]
        public string OriginalXmlString {
            get;
            set;
        }

        private static XmlSerializer Serializer {
            get {
                if (Complemento_SPEISPEI_Tercero.objSerializer == null) {
                    Complemento_SPEISPEI_Tercero.objSerializer = (new XmlSerializerFactory()).CreateSerializer(typeof(Complemento_SPEISPEI_Tercero));
                }
                return Complemento_SPEISPEI_Tercero.objSerializer;
            }
        }

        /// <summary>
        /// Deserialize
        /// </summary>
        public static Complemento_SPEISPEI_Tercero Deserialize(string input) {
            Complemento_SPEISPEI_Tercero objComprobante;
            using (StringReader stringReader = new StringReader(input)) {
                Complemento_SPEISPEI_Tercero objComprobante1 = (Complemento_SPEISPEI_Tercero)Complemento_SPEISPEI_Tercero.Serializer.Deserialize(XmlReader.Create(stringReader));
                objComprobante1.OriginalXmlString = input;
                objComprobante = objComprobante1;
            }
            return objComprobante;
        }

        public static Complemento_SPEISPEI_Tercero Load(string fileName) {
            Complemento_SPEISPEI_Tercero comprobante;
            UTF8Encoding objUtf8WithoutBom = new UTF8Encoding(false);
            try {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read)) {
                    using (StreamReader streamReader = new StreamReader(fileStream, objUtf8WithoutBom)) {
                        comprobante = Complemento_SPEISPEI_Tercero.Deserialize(streamReader.ReadToEnd());
                    }
                }
                return comprobante;
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public static Complemento_SPEISPEI_Tercero LoadX(string input) {
            StreamReader oStreamReader = new StreamReader(input);
            try {
                return XmlSerializerService.DeserializeObject<Complemento_SPEISPEI_Tercero>(oStreamReader.ReadToEnd());
            } catch (Exception) {
                return null;
            } finally {
                oStreamReader.Close();
            }
        }

        /// <summary>
        /// cargar
        /// </summary>
        public static Complemento_SPEISPEI_Tercero LoadXml(string xmlString) {
            try {
                return Complemento_SPEISPEI_Tercero.Deserialize(xmlString);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        #endregion
    }
}

namespace Jaeger.SAT.CFDI {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/spei")]
    [System.Xml.Serialization.XmlRoot("Ordenante")]
    public partial class Complemento_SPEISPEI_TerceroOrdenante {
        private string bancoEmisorField;

        private string nombreField;

        private decimal tipoCuentaField;

        private decimal cuentaField;

        private string rFCField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BancoEmisor {
            get {
                return this.bancoEmisorField;
            }
            set {
                this.bancoEmisorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TipoCuenta {
            get {
                return this.tipoCuentaField;
            }
            set {
                this.tipoCuentaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Cuenta {
            get {
                return this.cuentaField;
            }
            set {
                this.cuentaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RFC {
            get {
                return this.rFCField;
            }
            set {
                this.rFCField = value;
            }
        }
    }
}

namespace Jaeger.SAT.CFDI {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/spei")]
    [System.Xml.Serialization.XmlRoot("Beneficiario")]
    public partial class Complemento_SPEISPEI_TerceroBeneficiario {
        private string bancoReceptorField;

        private string nombreField;

        private decimal tipoCuentaField;

        private decimal cuentaField;

        private string rFCField;

        private string conceptoField;

        private decimal iVAField;

        private bool iVAFieldSpecified;

        private decimal montoPagoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BancoReceptor {
            get {
                return this.bancoReceptorField;
            }
            set {
                this.bancoReceptorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TipoCuenta {
            get {
                return this.tipoCuentaField;
            }
            set {
                this.tipoCuentaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Cuenta {
            get {
                return this.cuentaField;
            }
            set {
                this.cuentaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RFC {
            get {
                return this.rFCField;
            }
            set {
                this.rFCField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Concepto {
            get {
                return this.conceptoField;
            }
            set {
                this.conceptoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal IVA {
            get {
                return this.iVAField;
            }
            set {
                this.iVAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IVASpecified {
            get {
                return this.iVAFieldSpecified;
            }
            set {
                this.iVAFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MontoPago {
            get {
                return this.montoPagoField;
            }
            set {
                this.montoPagoField = value;
            }
        }
    }
}