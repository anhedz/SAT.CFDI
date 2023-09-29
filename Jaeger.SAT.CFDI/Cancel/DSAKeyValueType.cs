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
    [XmlRoot("DSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class DSAKeyValueType {
        private byte[] pField;

        private byte[] qField;

        private byte[] gField;

        private byte[] yField;

        private byte[] jField;

        private byte[] seedField;

        private byte[] pgenCounterField;

        [XmlElement(DataType = "base64Binary")]
        public byte[] G {
            get {
                return this.gField;
            }
            set {
                this.gField = value;
            }
        }

        [XmlElement(DataType = "base64Binary")]
        public byte[] J {
            get {
                return this.jField;
            }
            set {
                this.jField = value;
            }
        }

        [XmlElement(DataType = "base64Binary")]
        public byte[] P {
            get {
                return this.pField;
            }
            set {
                this.pField = value;
            }
        }

        [XmlElement(DataType = "base64Binary")]
        public byte[] PgenCounter {
            get {
                return this.pgenCounterField;
            }
            set {
                this.pgenCounterField = value;
            }
        }

        /// <comentarios />
        [XmlElement(DataType = "base64Binary")]
        public byte[] Q {
            get {
                return this.qField;
            }
            set {
                this.qField = value;
            }
        }

        /// <comentarios />
        [XmlElement(DataType = "base64Binary")]
        public byte[] Seed {
            get {
                return this.seedField;
            }
            set {
                this.seedField = value;
            }
        }

        /// <comentarios />
        [XmlElement(DataType = "base64Binary")]
        public byte[] Y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
            }
        }

        [DebuggerNonUserCode]
        public DSAKeyValueType() {
        }
    }
}