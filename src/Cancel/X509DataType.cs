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
    [XmlRoot("X509Data", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class X509DataType {
        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        /// <comentarios />
        [XmlAnyElement]
        [XmlChoiceIdentifier("ItemsElementName")]
        [XmlElement("X509Certificate", typeof(byte[]), DataType = "base64Binary")]
        [XmlElement("X509CRL", typeof(byte[]), DataType = "base64Binary")]
        [XmlElement("X509IssuerSerial", typeof(X509IssuerSerialType))]
        [XmlElement("X509SKI", typeof(byte[]), DataType = "base64Binary")]
        [XmlElement("X509SubjectName", typeof(string))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }

        [XmlElement("ItemsElementName")]
        [XmlIgnore]
        public ItemsChoiceType[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }

        [DebuggerNonUserCode]
        public X509DataType() {
        }
    }
}