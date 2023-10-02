using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Jaeger.SAT.CFDI.Services;

namespace Jaeger.SAT.CFDI.Cancel {
    /// <comentarios />
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [GeneratedCode("xsd", "4.0.30319.33440")]
    [Serializable]
    [XmlType(Namespace = "http://cancelacfd.sat.gob.mx")]
    public class Acuse {
        private AcuseFolios[] foliosField;

        private SignatureType signatureField;

        private string codEstatusField;

        private DateTime fechaField;

        private string rfcEmisorField;

        [XmlAttribute]
        public string CodEstatus {
            get {
                return this.codEstatusField;
            }
            set {
                this.codEstatusField = value;
            }
        }

        /// <comentarios />
        [XmlAttribute]
        public DateTime Fecha {
            get {
                return this.fechaField;
            }
            set {
                this.fechaField = value;
            }
        }

        [XmlElement("Folios")]
        public AcuseFolios[] Folios {
            get {
                return this.foliosField;
            }
            set {
                this.foliosField = value;
            }
        }

        [XmlAttribute]
        public string RfcEmisor {
            get {
                return this.rfcEmisorField;
            }
            set {
                this.rfcEmisorField = value;
            }
        }

        /// <comentarios />
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
        public Acuse() {
        }

        public static Acuse LoadXml(string stringXml) {
            Acuse loadXml;
            try {
                loadXml = XmlSerializerService.DeserializeObject<Acuse>(stringXml);
                return loadXml;
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            loadXml = null;
            return loadXml;
        }

        public static Acuse Load(string fileName) {
            Acuse comprobante;
            UTF8Encoding objUtf8WithoutBom = new UTF8Encoding(false);
            try {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read)) {
                    using (StreamReader streamReader = new StreamReader(fileStream, objUtf8WithoutBom)) {
                        comprobante = Acuse.LoadXml(streamReader.ReadToEnd());
                    }
                }
                return comprobante;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}