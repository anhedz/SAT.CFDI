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
    [XmlType(AnonymousType = true, Namespace = "http://cancelacfd.sat.gob.mx")]
    public class CancelacionFolios {
        private string uUIDField;

        public string UUID {
            get {
                return this.uUIDField;
            }
            set {
                this.uUIDField = value;
            }
        }

        [DebuggerNonUserCode]
        public CancelacionFolios() {
        }
    }
}