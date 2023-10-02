using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Jaeger.SAT.CFDI.Cancel {
    /// <comentarios />
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [GeneratedCode("xsd", "4.0.30319.33440")]
    [Serializable]
    [XmlRoot("KeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class KeyValueType {
        private object itemField;

        private string[] textField;

        /// <comentarios />
        [XmlAnyElement]
        [XmlElement("DSAKeyValue", typeof(DSAKeyValueType))]
        [XmlElement("RSAKeyValue", typeof(RSAKeyValueType))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = RuntimeHelpers.GetObjectValue(value);
            }
        }

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
        public KeyValueType() {
        }
    }
}