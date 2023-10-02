using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Xml;
using System;
using Jaeger.SAT.CFDI.Services;

namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/CartaPorte", IsNullable = false)]
    public partial class CartaPorte {
        [XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string XsiSchemaLocation;

        private CartaPorteUbicacion[] ubicacionesField;

        private CartaPorteMercancias mercanciasField;

        private CartaPorteFiguraTransporte figuraTransporteField;

        private string versionField;

        private CartaPorteTranspInternac transpInternacField;

        private CartaPorteEntradaSalidaMerc entradaSalidaMercField;

        private bool entradaSalidaMercFieldSpecified;

        private c_CveTransporte viaEntradaSalidaField;

        private bool viaEntradaSalidaFieldSpecified;

        private decimal totalDistRecField;

        private bool totalDistRecFieldSpecified;

        private static XmlSerializer objSerializer;

        public CartaPorte() {
            this.versionField = "1.0";
        }

        /// <summary>
        /// Nodo requerido para registrar las distintas ubicaciones que sirven para reflejar el domicilio del origen y/o destino que tienen los bienes o mercancías que se trasladan por distintos medios de transporte.
        /// </summary>
        [System.Xml.Serialization.XmlArrayItemAttribute("Ubicacion", IsNullable = false)]
        public CartaPorteUbicacion[] Ubicaciones {
            get {
                return this.ubicacionesField;
            }
            set {
                this.ubicacionesField = value;
            }
        }

        /// <summary>
        /// Nodo requerido para registrar la información de los bienes o mercancías que se trasladan en los distintos medios de transporte.
        /// </summary>
        public CartaPorteMercancias Mercancias {
            get {
                return this.mercanciasField;
            }
            set {
                this.mercanciasField = value;
            }
        }

        /// <summary>
        /// Nodo opcional para indicar los datos de la figura del transporte que interviene en el traslado de los bienes o mercancías, cuando el dueño del medio de transporte es diferente del emisor del comprobante con el complemento carta porte.
        /// </summary>
        public CartaPorteFiguraTransporte FiguraTransporte {
            get {
                return this.figuraTransporteField;
            }
            set {
                this.figuraTransporteField = value;
            }
        }

        /// <summary>
        /// Atributo requerido con valor prefijado que indica la versión del complemento Carta Porte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar si los bienes o mercancías que son transportadas ingresan o salen del territorio nacional.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CartaPorteTranspInternac TranspInternac {
            get {
                return this.transpInternacField;
            }
            set {
                this.transpInternacField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para precisar si los bienes o mercancías ingresan o salen del territorio nacional.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CartaPorteEntradaSalidaMerc EntradaSalidaMerc {
            get {
                return this.entradaSalidaMercField;
            }
            set {
                this.entradaSalidaMercField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EntradaSalidaMercSpecified {
            get {
                return this.entradaSalidaMercFieldSpecified;
            }
            set {
                this.entradaSalidaMercFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo condicional para precisar la vía de ingreso o salida de los bienes o mercancías en territorio nacional.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_CveTransporte ViaEntradaSalida {
            get {
                return this.viaEntradaSalidaField;
            }
            set {
                this.viaEntradaSalidaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ViaEntradaSalidaSpecified {
            get {
                return this.viaEntradaSalidaFieldSpecified;
            }
            set {
                this.viaEntradaSalidaFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo condicional para registrar la suma de las distancias recorridas en kilómetros, registradas en el atributo “Ubicaciones:Ubicacion:DistanciaRecorrida” para el traslado de los bienes o mercancías.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TotalDistRec {
            get {
                return this.totalDistRecField;
            }
            set {
                this.totalDistRecField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalDistRecSpecified {
            get {
                return this.totalDistRecFieldSpecified;
            }
            set {
                this.totalDistRecFieldSpecified = value;
            }
        }

        #region Serializacion

        [XmlIgnore]
        public string CadenaOriginal {
            get {
                string outOriginalString;
                using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Jaeger.CartaPorte.xslt")) {
                    if (manifestResourceStream == null) {
                        outOriginalString = null;
                    } else {
                        XmlDocument xmlDocument = new XmlDocument();
                        xmlDocument.Load(manifestResourceStream);
                        using (StringWriter stringWriter = new StringWriter()) {
                            using (XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter)) {
                                XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
                                xslCompiledTransform.Load(xmlDocument, null, new XmlResolverService());
                                xslCompiledTransform.Transform(new XPathDocument(new StringReader(this.Serialize())), null, xmlTextWriter);
                                outOriginalString = stringWriter.ToString();
                            }
                        }
                    }
                }
                return outOriginalString;
            }
        }

        public static XmlSerializer Serializer {
            get {
                if (CartaPorte.objSerializer == null) {
                    CartaPorte.objSerializer = (new XmlSerializerFactory()).CreateSerializer(typeof(CartaPorte));
                }
                return CartaPorte.objSerializer;
            }
        }

        public static bool Deserialize(string input, out CartaPorte obj, out Exception exception) {
            bool flag;
            exception = null;
            obj = null;
            try {
                obj = CartaPorte.Deserialize(input);
                flag = true;
            } catch (Exception exception1) {
                exception = exception1;
                flag = false;
            }
            return flag;
        }

        public static bool Deserialize(string input, out CartaPorte obj) {
            Exception exception = new Exception();
            return CartaPorte.Deserialize(input, out obj, out exception);
        }

        public static CartaPorte Deserialize(string input) {
            StringReader objStringReader = new StringReader(input);
            CartaPorte objPagos = (CartaPorte)CartaPorte.Serializer.Deserialize(XmlReader.Create(objStringReader));
            return objPagos;
        }

        public static CartaPorte Deserialize(Stream s) {
            return (CartaPorte)CartaPorte.Serializer.Deserialize(s);
        }

        public virtual string Serialize() {
            string end;
            StreamReader streamReader = null;
            MemoryStream memoryStream = null;
            try {
                memoryStream = new MemoryStream();
                XmlWriterSettings xmlWriterSetting = new XmlWriterSettings() {
                    Encoding = Encoding.UTF8,
                    Indent = true
                };
                XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSetting);
                XmlSerializerNamespaces xmlSerializerNamespace = new XmlSerializerNamespaces();
                xmlSerializerNamespace.Add("pagos20", "http://www.sat.gob.mx/Pagos");
                xmlSerializerNamespace.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
                this.XsiSchemaLocation = "http://www.sat.gob.mx/Pagos http://www.sat.gob.mx/sitio_internet/cfd/Pagos/Pagos20.xsd";
                CartaPorte.Serializer.Serialize(xmlWriter, this, xmlSerializerNamespace);
                memoryStream.Seek((long)0, SeekOrigin.Begin);
                streamReader = new StreamReader(memoryStream, Encoding.UTF8);
                end = streamReader.ReadToEnd();
            } finally {
                if (streamReader != null) {
                    streamReader.Dispose();
                }
                if (memoryStream != null) {
                    memoryStream.Dispose();
                }
            }
            return end;
        }

        #endregion
    }
}