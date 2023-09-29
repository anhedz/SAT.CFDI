using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Xml;

namespace Jaeger.SAT.CFDI.Services {
    public class GetXsd {
        public string NameSpace {
            get;
            set;
        }

        public XmlReader XmlReader {
            get;
            set;
        }

        public GetXsd(string resourceName) {
            Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(string.Concat("Jaeger.SAT.CFDI.xsd.", resourceName));
            if (manifestResourceStream != null) {
                this.XmlReader = XmlReader.Create(manifestResourceStream);
                this.XmlReader.Read();
                //while (this.XmlReader.Read()) {
                //    if ((!this.XmlReader.IsStartElement() || this.XmlReader.Name == "xs:schema")) {
                //        this.NameSpace = this.XmlReader["targetNamespace"];
                //        break;
                //    }
                //}
            }
        }
    }
}
