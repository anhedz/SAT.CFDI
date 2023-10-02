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
    [XmlType(Namespace = "http://cancelacfd.sat.gob.mx")]
    public class Cancelacion {
        private CancelacionFolios[] foliosField;

        private SignatureType signatureField;

        private string rfcEmisorField;

        private DateTime fechaField;

        [XmlAttribute]
        public DateTime Fecha {
            get {
                return this.fechaField;
            }
            set {
                this.fechaField = value;
            }
        }

        /// <comentarios />
        [XmlElement("Folios")]
        public CancelacionFolios[] Folios {
            get {
                return this.foliosField;
            }
            set {
                this.foliosField = value;
            }
        }

        /// <comentarios />
        [XmlAttribute]
        public string RfcEmisor {
            get {
                return this.rfcEmisorField;
            }
            set {
                this.rfcEmisorField = value;
            }
        }

        [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature {
            get {
                return this.signatureField;
            }
            set {
                this.signatureField = value;
            }
        }

        [DebuggerNonUserCode]
        public Cancelacion() {
        }
    }
}