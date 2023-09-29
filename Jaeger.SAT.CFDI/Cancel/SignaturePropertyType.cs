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
    [XmlRoot("SignatureProperty", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class SignaturePropertyType {
        private XmlElement[] itemsField;

        private string[] textField;

        private string targetField;

        private string idField;

        /// <comentarios />
        [XmlAttribute(DataType = "ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        [XmlAnyElement]
        public XmlElement[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }

        [XmlAttribute(DataType = "anyURI")]
        public string Target {
            get {
                return this.targetField;
            }
            set {
                this.targetField = value;
            }
        }

        /// <comentarios />
        [XmlText]
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }

        [DebuggerNonUserCode]
        public SignaturePropertyType() {
        }
    }
}