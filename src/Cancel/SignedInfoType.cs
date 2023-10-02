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
    [XmlRoot("SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class SignedInfoType {
        private CanonicalizationMethodType canonicalizationMethodField;

        private SignatureMethodType signatureMethodField;

        private ReferenceType[] referenceField;

        private string idField;

        /// <comentarios />
        public CanonicalizationMethodType CanonicalizationMethod {
            get {
                return this.canonicalizationMethodField;
            }
            set {
                this.canonicalizationMethodField = value;
            }
        }

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
        [XmlElement("Reference")]
        public ReferenceType[] Reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }

        public SignatureMethodType SignatureMethod {
            get {
                return this.signatureMethodField;
            }
            set {
                this.signatureMethodField = value;
            }
        }

        [DebuggerNonUserCode]
        public SignedInfoType() {
        }
    }
}