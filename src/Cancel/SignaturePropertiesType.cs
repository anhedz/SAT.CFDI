using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Jaeger.SAT.CFDI.Cancel {
    /// <comentarios />
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [GeneratedCode("xsd", "4.0.30319.33440")]
    [Serializable]
    [XmlRoot("SignatureProperties", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class SignaturePropertiesType {
        private SignaturePropertyType[] signaturePropertyField;

        private string idField;

        [XmlAttribute(DataType = "ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <comentarios />
        [XmlElement("SignatureProperty")]
        public SignaturePropertyType[] SignatureProperty {
            get {
                return this.signaturePropertyField;
            }
            set {
                this.signaturePropertyField = value;
            }
        }

        [DebuggerNonUserCode]
        public SignaturePropertiesType() {
        }
    }
}