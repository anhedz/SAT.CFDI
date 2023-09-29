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
    [XmlType(AnonymousType = true, Namespace = "http://cancelacfd.sat.gob.mx")]
    public class AcuseFolios {
        private string uUIDField;

        private string estatusUUIDField;

        /// <comentarios />
        public string EstatusUUID {
            get {
                return this.estatusUUIDField;
            }
            set {
                this.estatusUUIDField = value;
            }
        }

        public string UUID {
            get {
                return this.uUIDField;
            }
            set {
                this.uUIDField = value;
            }
        }

        [DebuggerNonUserCode]
        public AcuseFolios() {
        }
    }
}