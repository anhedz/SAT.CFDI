using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Jaeger.SAT.CFDI.Cancel {
    [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Body {
        private CancelaCFDResponse mCancelaCfdResponse;

        private string mXsi;

        private string mXsd;

        [XmlElement(ElementName = "CancelaCFDResponse", Namespace = "http://cancelacfd.sat.gob.mx")]
        public CancelaCFDResponse CancelaCFDResponse {
            get {
                return this.mCancelaCfdResponse;
            }
            set {
                this.mCancelaCfdResponse = value;
            }
        }

        [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsd {
            get {
                return this.mXsd;
            }
            set {
                this.mXsd = value;
            }
        }

        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi {
            get {
                return this.mXsi;
            }
            set {
                this.mXsi = value;
            }
        }

        [DebuggerNonUserCode]
        public Body() {
        }
    }
}