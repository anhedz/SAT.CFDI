namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
    public partial class CartaPorteFiguraTransporte {

        private CartaPorteFiguraTransporteOperadoresOperador[][] operadoresField;

        private CartaPorteFiguraTransportePropietario[] propietarioField;

        private CartaPorteFiguraTransporteArrendatario[] arrendatarioField;

        private CartaPorteFiguraTransporteNotificado[] notificadoField;

        private c_CveTransporte cveTransporteField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Operador", typeof(CartaPorteFiguraTransporteOperadoresOperador), IsNullable = false)]
        public CartaPorteFiguraTransporteOperadoresOperador[][] Operadores {
            get {
                return this.operadoresField;
            }
            set {
                this.operadoresField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Propietario")]
        public CartaPorteFiguraTransportePropietario[] Propietario {
            get {
                return this.propietarioField;
            }
            set {
                this.propietarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Arrendatario")]
        public CartaPorteFiguraTransporteArrendatario[] Arrendatario {
            get {
                return this.arrendatarioField;
            }
            set {
                this.arrendatarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Notificado")]
        public CartaPorteFiguraTransporteNotificado[] Notificado {
            get {
                return this.notificadoField;
            }
            set {
                this.notificadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public c_CveTransporte CveTransporte {
            get {
                return this.cveTransporteField;
            }
            set {
                this.cveTransporteField = value;
            }
        }
    }
}