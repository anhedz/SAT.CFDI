namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V20 {
    /// <summary>
    /// Nodo condicional para registrar la información que permita la identificación del transporte aéreo por medio del cual se trasladan los bienes y/o mercancías.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteMercanciasTransporteAereo {

        private string permSCTField; //c_TipoPermiso

        private string numPermisoSCTField;

        private string matriculaAeronaveField;

        private string nombreAsegField;

        private string numPolizaSeguroField;

        private string numeroGuiaField;

        private string lugarContratoField;

        private string codigoTransportistaField; //c_CodigoTransporteAereo

        private string rFCEmbarcadorField;

        private string numRegIdTribEmbarcField;

        private string residenciaFiscalEmbarcField; //c_Pais

        private bool residenciaFiscalEmbarcFieldSpecified;

        private string nombreEmbarcadorField;

        /// <summary>
        /// Atributo requerido para registrar la clave del permiso proporcionado por la SCT o la autoridad análoga, la cual debe corresponder con la aeronave que se está utilizando para realizar el traslado de los bienes y/o mercancías por vía aérea.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PermSCT {
            get {
                return this.permSCTField;
            }
            set {
                this.permSCTField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para registrar el número de permiso o valor análogo proporcionado por la SCT o la autoridad análoga, según corresponda, para el transporte de bienes y/o mercancías por vía aérea.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumPermisoSCT {
            get {
                return this.numPermisoSCTField;
            }
            set {
                this.numPermisoSCTField = value;
            }
        }

        /// <summary>
        /// Atributo opcional para registrar el número de la matrícula de la aeronave con la que se realiza el traslado de los bienes y/o mercancías en territorio nacional el cual tiene una longitud de 10 posiciones y se compone de valores alfanuméricos, más el carácter especial denominado guion medio
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MatriculaAeronave {
            get {
                return this.matriculaAeronaveField;
            }
            set {
                this.matriculaAeronaveField = value;
            }
        }

        /// <summary>
        /// Atributo opcional para registrar el nombre de la aseguradora que cubre los riesgos de la aeronave con la que transportan los bienes y/o mercancías.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NombreAseg {
            get {
                return this.nombreAsegField;
            }
            set {
                this.nombreAsegField = value;
            }
        }

        /// <summary>
        /// Atributo opcional para registrar el número de póliza asignado por la aseguradora que cubre la protección e indemnización por responsabilidad civil de la aeronave que transporta los bienes y/o mercancías
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumPolizaSeguro {
            get {
                return this.numPolizaSeguroField;
            }
            set {
                this.numPolizaSeguroField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para registrar el número de guía aérea con el que se trasladan los bienes y/o mercancías.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumeroGuia {
            get {
                return this.numeroGuiaField;
            }
            set {
                this.numeroGuiaField = value;
            }
        }

        /// <summary>
        /// Atributo opcional para registrar el lugar, entidad, región, localidad o análogo, donde se celebró el contrato para realizar el traslado de los bienes y/o mercancías
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LugarContrato {
            get {
                return this.lugarContratoField;
            }
            set {
                this.lugarContratoField = value;
            }
        }

        /// <summary>
        /// Atributo requerido para registrar el valor del código que tiene asignado el transportista el cual debe contener alguna de las claves contenidas en el catálogo correspondiente.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodigoTransportista {
            get {
                return this.codigoTransportistaField;
            }
            set {
                this.codigoTransportistaField = value;
            }
        }

        /// <summary>
        /// Atributo opcional para registrar el RFC del embarcador de los bienes y/o mercancías que se trasladan.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RFCEmbarcador {
            get {
                return this.rFCEmbarcadorField;
            }
            set {
                this.rFCEmbarcadorField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para incorporar el número de identificación o registro fiscal del país de residencia cuando el embarcador sea residente en el extranjero para los efectos fiscales correspondientes de los bienes y/o mercancías que se trasladan.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumRegIdTribEmbarc {
            get {
                return this.numRegIdTribEmbarcField;
            }
            set {
                this.numRegIdTribEmbarcField = value;
            }
        }

        /// <summary>
        /// Atributo condicional para registrar la clave del país de residencia para efectos fiscales del embarcador de los bienes y/o mercancías.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResidenciaFiscalEmbarc {
            get {
                return this.residenciaFiscalEmbarcField;
            }
            set {
                this.residenciaFiscalEmbarcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResidenciaFiscalEmbarcSpecified {
            get {
                return this.residenciaFiscalEmbarcFieldSpecified;
            }
            set {
                this.residenciaFiscalEmbarcFieldSpecified = value;
            }
        }

        /// <summary>
        /// Atributo opcional para registrar el nombre del embarcador de los bienes y/o mercancías que se trasladan, ya sea nacional o extranjero.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NombreEmbarcador {
            get {
                return this.nombreEmbarcadorField;
            }
            set {
                this.nombreEmbarcadorField = value;
            }
        }
    }
}