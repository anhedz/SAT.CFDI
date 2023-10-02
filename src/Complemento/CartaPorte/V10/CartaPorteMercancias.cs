namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
    public partial class CartaPorteMercancias {

        private CartaPorteMercanciasMercancia[] mercanciaField;

        private CartaPorteMercanciasAutotransporteFederal autotransporteFederalField;

        private CartaPorteMercanciasTransporteMaritimo transporteMaritimoField;

        private CartaPorteMercanciasTransporteAereo transporteAereoField;

        private CartaPorteMercanciasTransporteFerroviario transporteFerroviarioField;

        private decimal pesoBrutoTotalField;

        private bool pesoBrutoTotalFieldSpecified;

        private string unidadPesoField; //c_ClaveUnidadPeso

        private bool unidadPesoFieldSpecified;

        private decimal pesoNetoTotalField;

        private bool pesoNetoTotalFieldSpecified;

        private int numTotalMercanciasField;

        private decimal cargoPorTasacionField;

        private bool cargoPorTasacionFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Mercancia")]
        public CartaPorteMercanciasMercancia[] Mercancia {
            get {
                return this.mercanciaField;
            }
            set {
                this.mercanciaField = value;
            }
        }

        /// <remarks/>
        public CartaPorteMercanciasAutotransporteFederal AutotransporteFederal {
            get {
                return this.autotransporteFederalField;
            }
            set {
                this.autotransporteFederalField = value;
            }
        }

        /// <remarks/>
        public CartaPorteMercanciasTransporteMaritimo TransporteMaritimo {
            get {
                return this.transporteMaritimoField;
            }
            set {
                this.transporteMaritimoField = value;
            }
        }

        /// <remarks/>
        public CartaPorteMercanciasTransporteAereo TransporteAereo {
            get {
                return this.transporteAereoField;
            }
            set {
                this.transporteAereoField = value;
            }
        }

        /// <remarks/>
        public CartaPorteMercanciasTransporteFerroviario TransporteFerroviario {
            get {
                return this.transporteFerroviarioField;
            }
            set {
                this.transporteFerroviarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PesoBrutoTotal {
            get {
                return this.pesoBrutoTotalField;
            }
            set {
                this.pesoBrutoTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PesoBrutoTotalSpecified {
            get {
                return this.pesoBrutoTotalFieldSpecified;
            }
            set {
                this.pesoBrutoTotalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnidadPeso {
            get {
                return this.unidadPesoField;
            }
            set {
                this.unidadPesoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnidadPesoSpecified {
            get {
                return this.unidadPesoFieldSpecified;
            }
            set {
                this.unidadPesoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PesoNetoTotal {
            get {
                return this.pesoNetoTotalField;
            }
            set {
                this.pesoNetoTotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PesoNetoTotalSpecified {
            get {
                return this.pesoNetoTotalFieldSpecified;
            }
            set {
                this.pesoNetoTotalFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int NumTotalMercancias {
            get {
                return this.numTotalMercanciasField;
            }
            set {
                this.numTotalMercanciasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal CargoPorTasacion {
            get {
                return this.cargoPorTasacionField;
            }
            set {
                this.cargoPorTasacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CargoPorTasacionSpecified {
            get {
                return this.cargoPorTasacionFieldSpecified;
            }
            set {
                this.cargoPorTasacionFieldSpecified = value;
            }
        }
    }
}