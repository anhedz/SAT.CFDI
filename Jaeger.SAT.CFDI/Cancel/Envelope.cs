using System;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;
using Jaeger.SAT.CFDI.Services;

namespace Jaeger.SAT.CFDI.Cancel {
    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Envelope {
        private Body mBody;

        private string mS;

        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public Body Body {
            get {
                return this.mBody;
            }
            set {
                this.mBody = value;
            }
        }

        [XmlAttribute(AttributeName = "s", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string S {
            get {
                return this.mS;
            }
            set {
                this.mS = value;
            }
        }

        [DebuggerNonUserCode]
        public Envelope() {
        }

        public Envelope Load(FileInfo fileName) {
            Envelope load;
            if (fileName.Exists) {
                string stringXml = File.ReadAllText(fileName.FullName, System.Text.Encoding.UTF8);
                Envelope objEnvelope = new Envelope();
                try {
                    objEnvelope = XmlSerializerService.DeserializeObject<Envelope>(stringXml);
                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
                load = objEnvelope;
            }
            else {
                load = null;
            }
            return load;
        }

        public Envelope LoadXml(string stringXml) {
            Envelope loadXml;
            try {
                loadXml = XmlSerializerService.DeserializeObject<Envelope>(stringXml);
                return loadXml;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            loadXml = null;
            return loadXml;
        }

        public string Xml() {
            return XmlSerializerService.SerializeObject<Envelope>(this);
        }
    }
}