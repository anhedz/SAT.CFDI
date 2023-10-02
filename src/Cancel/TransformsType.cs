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
    [XmlRoot("Transforms", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class TransformsType {
        private TransformType[] transformField;

        [XmlElement("Transform")]
        public TransformType[] Transform {
            get {
                return this.transformField;
            }
            set {
                this.transformField = value;
            }
        }

        [DebuggerNonUserCode]
        public TransformsType() {
        }
    }
}