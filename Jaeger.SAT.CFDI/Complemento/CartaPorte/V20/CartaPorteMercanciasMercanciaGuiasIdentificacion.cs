namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V20 {
    /// <summary>
    /// Nodo condicional para registrar la información del(los) número(s) de guía(s) que se encuentre(n) asociado(s) al(los) paquete(s) que se traslada(n) dentro del territorio nacional.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteMercanciasMercanciaGuiasIdentificacion {

        private string numeroGuiaIdentificacionField;

        private string descripGuiaIdentificacionField;

        private decimal pesoGuiaIdentificacionField;

        /// <summary>
        /// Atributo requerido para expresar el número de guía de cada paquete que se encuentra asociado con el traslado de los bienes y/o mercancías en territorio nacional.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumeroGuiaIdentificacion {
            get {
                return this.numeroGuiaIdentificacionField;
            }
            set {
                this.numeroGuiaIdentificacionField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar la descripción del contenido del paquete o carga registrada en la guía, o en el número de identificación, que se encuentra asociado con el
        /// traslado de los bienes y/o mercancías dentro del territorio nacional.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DescripGuiaIdentificacion {
            get {
                return this.descripGuiaIdentificacionField;
            }
            set {
                this.descripGuiaIdentificacionField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para indicar en kilogramos, el peso del paquete o carga que se está trasladando en territorio nacional  y que se encuentra registrado en la guía o el número de identificación correspondiente.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PesoGuiaIdentificacion {
            get {
                return this.pesoGuiaIdentificacionField;
            }
            set {
                this.pesoGuiaIdentificacionField = value;
            }
        }
    }
}