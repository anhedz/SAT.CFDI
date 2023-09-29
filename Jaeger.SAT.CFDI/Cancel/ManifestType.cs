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
    [XmlRoot("Manifest", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class ManifestType {
        private ReferenceType[] referenceField;

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

        [XmlElement("Reference")]
        public ReferenceType[] Reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }

        [DebuggerNonUserCode]
        public ManifestType() {
        }
    }
}