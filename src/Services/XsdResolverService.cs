using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using Jaeger.SAT.CFDI.Helper;

namespace Jaeger.SAT.CFDI.Services {
    public class XsdResolverService  {

        public XsdResolverService() {
        }

        public XmlReader GetEntity(string absoluteUri) {
            var d0 = Assembly.GetExecutingAssembly().GetManifestResourceStream("Jaeger.SAT.CFDI.xsd." + absoluteUri);
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            XmlReader getEntity = (
                from resourceName in executingAssembly.GetManifestResourceNames()
                where resourceName.EndsWith(string.Concat(".", absoluteUri))
                select executingAssembly.GetManifestResourceStream(resourceName) into xslt
                where xslt != null
                select XmlReader.Create(new StreamReader(xslt), null, absoluteUri)).FirstOrDefault<XmlReader>();
            return getEntity;
        }

        public XmlReader GetEntity1(string resource) {
            var d0 = Assembly.GetExecutingAssembly().GetManifestResourceStream("Jaeger.SAT.CFDI.xsd." + resource);
            try {
                using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Jaeger.SAT.CFDI.xsd." + resource)) {
                    if (manifestResourceStream != null) {
                        return XmlReader.Create(new StreamReader(manifestResourceStream), null, resource);
                    }
                }
            } catch (Exception ex) {
                ex.LogWrite("Resource: ");
                LogErrorService.LogWrite("Resource: " + resource);
            }
            return null;
        }
    }
}
