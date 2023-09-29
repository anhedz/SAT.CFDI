using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.Xml;
using System;
using Jaeger.SAT.CFDI.Services;

namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V20 {
    /// <summary>
    /// Complemento para incorporar al Comprobante Fiscal Digital por Internet (CFDI), la información relacionada a los bienes y/o mercancías, ubicaciones de origen, puntos intermedios y destinos, así como lo 
    /// referente al medio por el que se transportan; ya sea por vía terrestre (autotransporte y férrea), marítima y/o aérea; además de incluir el traslado de hidrocarburos y petrolíferos.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.sat.gob.mx/CartaPorte20", IsNullable = false)]
    public partial class CartaPorte {
        [XmlAttribute("schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string XsiSchemaLocation;

        private static XmlSerializer objSerializer;

        private CartaPorteUbicacion[] ubicacionesField;

        private CartaPorteMercancias mercanciasField;

        private CartaPorteTiposFigura[] figuraTransporteField;

        private string versionField;

        private string transpInternacField; //CartaPorteTranspInternac

        private string entradaSalidaMercField; //CartaPorteEntradaSalidaMerc

        private bool entradaSalidaMercFieldSpecified;

        private string paisOrigenDestinoField; //c_Pais

        private bool paisOrigenDestinoFieldSpecified;

        private string viaEntradaSalidaField; //c_CveTransporte

        private bool viaEntradaSalidaFieldSpecified;

        private decimal totalDistRecField;

        private bool totalDistRecFieldSpecified;

        public CartaPorte() {
            this.versionField = "2.0";
        }

        /// <summary>
        /// Nodo requerido para registrar las distintas ubicaciones que sirven para indicar el domicilio del origen y/o destino que tienen los bienes y/o mercancías que se trasladan a través de los distintos medios de transporte.
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
        /// Nodo requerido para registrar la información de los bienes y/o mercancías que se trasladan en los distintos medios de transporte.
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
        /// Nodo condicional para indicar los datos de la(s) figura(s) del transporte que interviene(n) en el traslado de los bienes y/o mercancías realizado a través de los distintos medios de transporte dentro del territorio nacional, cuando el dueño de dicho medio sea diferente del emisor del comprobante con el complemento Carta Porte.
        /// </summary>
        [System.Xml.Serialization.XmlArrayItemAttribute("TiposFigura", IsNullable = false)]
        public CartaPorteTiposFigura[] FiguraTransporte {
            get {
                return this.figuraTransporteField;
            }
            set {
                this.figuraTransporteField = value;
            }
        }

        /// <summary>
        /// Atributo requerido con valor prefijado en el cual se indica la versión del complemento Carta Porte.
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
        /// Atributo requerido para expresar si los bienes y/o mercancías que son transportadas ingresan o salen del territorio nacional.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TranspInternac {
            get {
                return this.transpInternacField;
            }
            set {
                this.transpInternacField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para precisar si los bienes y/o mercancías ingresan o salen del territorio nacional.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EntradaSalidaMerc {
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
        /// Atributo condicional para registrar la clave del país de origen o destino de los bienes y/o mercancías que se trasladan a través de los distintos medios de transporte.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PaisOrigenDestino {
            get {
                return this.paisOrigenDestinoField;
            }
            set {
                this.paisOrigenDestinoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaisOrigenDestinoSpecified {
            get {
                return this.paisOrigenDestinoFieldSpecified;
            }
            set {
                this.paisOrigenDestinoFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo condicional para registrar la vía de ingreso o salida de los bienes y/o mercancías en territorio nacional.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ViaEntradaSalida {
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
        /// Atributo condicional para indicar en kilómetros, la suma de las distancias recorridas, registradas en el atributo “DistanciaRecorrida”, para el traslado de los bienes y/o mercancías.
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
                using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Jaeger.CartaPorte20.xslt")) {
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
                xmlSerializerNamespace.Add("cartaporte20", "http://www.sat.gob.mx/CartaPorte20");
                xmlSerializerNamespace.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
                this.XsiSchemaLocation = "http://www.sat.gob.mx/sitio_internet/cfd/CartaPorte/CartaPorte20.xsd";
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