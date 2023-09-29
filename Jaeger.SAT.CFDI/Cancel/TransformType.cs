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
    [XmlRoot("Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class TransformType {
        private object[] itemsField;

        private string[] textField;

        private string algorithmField;

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
        [XmlElement("XPath", typeof(string))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
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
        public TransformType() {
        }
    }
}