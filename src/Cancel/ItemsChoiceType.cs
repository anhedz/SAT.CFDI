using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Jaeger.SAT.CFDI.Cancel {
    [GeneratedCode("xsd", "4.0.30319.33440")]
    [Serializable]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
    public enum ItemsChoiceType {
        [XmlEnum("##any:")]
        Item,
        /// <comentarios />
        X509CRL,
        X509Certificate,
        /// <comentarios />
        X509IssuerSerial,
        X509SKI,
        /// <comentarios />
        X509SubjectName
    }
}