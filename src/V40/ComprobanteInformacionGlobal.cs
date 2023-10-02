using System.Xml.Serialization;

namespace Jaeger.SAT.CFDI.V40 {
    /// <summary>
    /// Nodo condicional para precisar la información relacionada con el comprobante global.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteInformacionGlobal {

        private string periodicidadField;

        private string mesesField;

        private int añoField;

        /// <summary>
        /// Atributo requerido para expresar el período al que corresponde la información del comprobante global.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Periodicidad {
            get {
                return this.periodicidadField;
            }
            set {
                this.periodicidadField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar el mes o los meses al que corresponde la información del comprobante global.
        /// </summary>
        [XmlAttributeAttribute()]
        public string Meses {
            get {
                return this.mesesField;
            }
            set {
                this.mesesField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar el año al que corresponde la información del comprobante global.
        /// </summary>
        [XmlAttributeAttribute()]
        public int Año {
            get {
                return this.añoField;
            }
            set {
                this.añoField = value;
            }
        }
    }
}
