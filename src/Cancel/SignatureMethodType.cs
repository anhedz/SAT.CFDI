using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Jaeger.SAT.CFDI.Cancel {
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [GeneratedCode("xsd", "4.0.30319.33440")]
    [Serializable]
    [XmlRoot("SignatureMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class SignatureMethodType {
        private string hMACOutputLengthField;

        private XmlNode[] anyField;

        private string algorithmField;

        /// <comentarios />
        [XmlAttribute(DataType = "anyURI")]
        public string Algorithm {
            get {
                return this.algorithmField;
            }
            set {
                this.algorithmField = value;
            }
        }

        [XmlAnyElement]
        [XmlText]
        public XmlNode[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }

        /// <comentarios />
        [XmlElement(DataType = "integer")]
        public string HMACOutputLength {
            get {
                return this.hMACOutputLengthField;
            }
            set {
                this.hMACOutputLengthField = value;
            }
        }

        [DebuggerNonUserCode]
        public SignatureMethodType() {
        }
    }
}