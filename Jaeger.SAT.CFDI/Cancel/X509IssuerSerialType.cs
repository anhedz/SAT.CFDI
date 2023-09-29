using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Jaeger.SAT.CFDI.Cancel {
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [GeneratedCode("xsd", "4.0.30319.33440")]
    [Serializable]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class X509IssuerSerialType {
        private string x509IssuerNameField;

        private string x509SerialNumberField;

        public string X509IssuerName {
            get {
                return this.x509IssuerNameField;
            }
            set {
                this.x509IssuerNameField = value;
            }
        }

        /// <comentarios />
        [XmlElement(DataType = "integer")]
        public string X509SerialNumber {
            get {
                return this.x509SerialNumberField;
            }
            set {
                this.x509SerialNumberField = value;
            }
        }

        [DebuggerNonUserCode]
        public X509IssuerSerialType() {
        }
    }
}