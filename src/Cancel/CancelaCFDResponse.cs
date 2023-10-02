using System;
using System.IO;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using Jaeger.SAT.CFDI.Services;

namespace Jaeger.SAT.CFDI.Cancel {
    /// <comentarios />
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [GeneratedCode("xsd", "4.0.30319.33440")]
    [Serializable]
    [XmlRoot(Namespace = "http://cancelacfd.sat.gob.mx", IsNullable = false)]
    [XmlType(AnonymousType = true, Namespace = "http://cancelacfd.sat.gob.mx")]
    public class CancelaCFDResponse {
        private Acuse cancelaCFDResultField;

        public Acuse CancelaCFDResult {
            get {
                return this.cancelaCFDResultField;
            }
            set {
                this.cancelaCFDResultField = value;
            }
        }

        [DebuggerNonUserCode]
        public CancelaCFDResponse() {
        }

        public static CancelaCFDResponse Load(string fileName) {
            string stringXml = File.ReadAllText(fileName);
            CancelaCFDResponse objEnvelope = new CancelaCFDResponse();
            try {
                objEnvelope = XmlSerializerService.DeserializeObject<CancelaCFDResponse>(stringXml);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            return objEnvelope;
        }

        public static CancelaCFDResponse LoadXml(string stringXml) {
            CancelaCFDResponse loadXml;
            try {
                loadXml = XmlSerializerService.DeserializeObject<CancelaCFDResponse>(stringXml);
                return loadXml;
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            loadXml = null;
            return loadXml;
        }

        public string Xml() {
            return XmlSerializerService.SerializeObject<CancelaCFDResponse>(this);
        }
    }
}