using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Xml;

namespace Jaeger.SAT.CFDI.Services {
    [DebuggerStepThrough]
    public class XmlResolverService : XmlResolver {
        public override ICredentials Credentials {
            set {
                throw new NotImplementedException();
            }
        }

        public XmlResolverService() {
        }

        public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            object getEntity = (
                from resourceName in executingAssembly.GetManifestResourceNames()
                where resourceName.EndsWith(string.Concat(".", absoluteUri.LocalPath))
                select executingAssembly.GetManifestResourceStream(resourceName) into xslt
                where xslt != null
                select XmlReader.Create(new StreamReader(xslt), null, absoluteUri.LocalPath)).FirstOrDefault<XmlReader>();
            return getEntity;
        }

        public override Uri ResolveUri(Uri baseUri, string relativeUri) {
            return new Uri(string.Concat("tdb:", relativeUri));
        }
    }
}
