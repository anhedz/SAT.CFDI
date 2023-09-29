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
    [XmlRoot("SPKIData", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class SPKIDataType {
        private byte[][] sPKISexpField;

        private XmlElement anyField;

        /// <comentarios />
        [XmlAnyElement]
        public XmlElement Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }

        [XmlElement("SPKISexp", DataType = "base64Binary")]
        public byte[][] SPKISexp {
            get {
                return this.sPKISexpField;
            }
            set {
                this.sPKISexpField = value;
            }
        }

        [DebuggerNonUserCode]
        public SPKIDataType() {
        }
    }
}