using System.IO;
using System.Reflection;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Xml;
using System;

namespace Jaeger.SAT.CFDI.Services {
    /// <summary>
    /// Cadena Original
    /// </summary>
    public class CadenaOriginal {
        #region CFDI
        /// <summary>
        /// cadena original del comprobante fiscal digital (CFDI)
        /// </summary>
        /// <param name="xmlString"></param>
        /// <param name="version">version</param>
        public static string GetCFDIOff(string xmlString, string version) {
            var xsltResourceName = "Jaeger.SAT.CFDI.xslt.cadenaoriginal_4_0_offline.xslt";
            if (version == "3.2") {
                xsltResourceName = "Jaeger.SAT.CFDI.xslt.cadenaoriginal_3_2_offline.xslt";
            } else if (version == "3.3") {
                xsltResourceName = "Jaeger.SAT.CFDI.xslt.cadenaoriginal_3_3_offline.xslt";
            } else if (version == "4.0") {
                xsltResourceName = "Jaeger.SAT.CFDI.xslt.cadenaoriginal_4_0_offline.xslt";
            }
            string outOriginalString;
            using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(xsltResourceName)) {
                if (manifestResourceStream == null) {
                    outOriginalString = null;
                } else {
                    var localXslt = new XmlDocument();
                    localXslt.Load(manifestResourceStream);
                    using (StringWriter stringWriter = new StringWriter()) {
                        using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter)) {
                            XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
                            xslCompiledTransform.Load(localXslt, null, new XmlResolverService());
                            xslCompiledTransform.Transform(new XPathDocument(new StringReader(xmlString)), null, xmlTextWriter);
                            outOriginalString = stringWriter.ToString().Replace("&amp;", "&");
                        }
                    }
                }
            }
            return outOriginalString;
        }
        #endregion

        #region TFD
        /// <summary>
        /// cadena original del timbre fiscal digital
        /// </summary>
        /// <param name="xmlString"></param>
        /// <param name="version">version del timbre fiscal</param>
        public static string GetTDFOff(string xmlString, string version) {
            var xml = ExtractNodeTimbreFiscal(xmlString);
            var xsltResourceName = "Jaeger.SAT.CFDI.xslt.cadenaoriginal_TFD_1_1.xslt";
            if (version == "1.0") {
                xsltResourceName = "Jaeger.SAT.CFDI.xslt.cadenaoriginal_TFD_1_0.xslt";
            } else if (version == "1.1") {
                xsltResourceName = "Jaeger.SAT.CFDI.xslt.cadenaoriginal_TFD_1_1.xslt";
            }
            string outOriginalString;
            using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(xsltResourceName)) {
                if (manifestResourceStream == null) {
                    outOriginalString = null;
                } else {
                    var localXslt = new XmlDocument();
                    localXslt.Load(manifestResourceStream);
                    using (StringWriter stringWriter = new StringWriter()) {
                        using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter)) {
                            XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
                            xslCompiledTransform.Load(localXslt, null, new XmlResolverService());
                            xslCompiledTransform.Transform(new XPathDocument(new StringReader(xml)), null, xmlTextWriter);
                            outOriginalString = stringWriter.ToString().Replace("&amp;", "&");
                        }
                    }
                }
            }
            return outOriginalString;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xmlString"></param>
        /// <returns></returns>
        private static string ExtractNodeTimbreFiscal(string xmlString) {
            try {
                try {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(xmlString);
                    XmlNode itemOf = xmlDocument.GetElementsByTagName("TimbreFiscalDigital", "http://www.sat.gob.mx/TimbreFiscalDigital")[0];
                    return itemOf.OuterXml;
                } catch (Exception exception) {
                    throw new Exception(string.Concat("Error al generar cadena original.  | ", exception.Message));
                }
            } catch (Exception ex) {
                System.Console.WriteLine(ex.Message);
            } finally {

            }
            return string.Empty;
        }
        #endregion
    }
}
