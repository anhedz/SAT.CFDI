namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/ComercioExterior11")]
    public partial class ComercioExteriorMercanciaDescripcionesEspecificas {

        private string marcaField;

        private string modeloField;

        private string subModeloField;

        private string numeroSerieField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Marca {
            get {
                return this.marcaField;
            }
            set {
                this.marcaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Modelo {
            get {
                return this.modeloField;
            }
            set {
                this.modeloField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubModelo {
            get {
                return this.subModeloField;
            }
            set {
                this.subModeloField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumeroSerie {
            get {
                return this.numeroSerieField;
            }
            set {
                this.numeroSerieField = value;
            }
        }
    }
}