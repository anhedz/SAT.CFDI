using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Jaeger.SAT.CFDI.Cancel {
    [GeneratedCode("xsd", "4.0.30319.33440")]
    [Serializable]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema = false)]
    public enum ItemsChoiceType2 {
        [XmlEnum("##any:")]
        Item,
        /// <comentarios />
        KeyName,
        KeyValue,
        /// <comentarios />
        MgmtData,
        PGPData,
        /// <comentarios />
        RetrievalMethod,
        SPKIData,
        /// <comentarios />
        X509Data
    }
}