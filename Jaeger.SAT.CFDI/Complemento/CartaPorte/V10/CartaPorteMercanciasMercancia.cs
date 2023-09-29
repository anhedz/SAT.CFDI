namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V10 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte")]
    public partial class CartaPorteMercanciasMercancia {

        private CartaPorteMercanciasMercanciaCantidadTransporta[] cantidadTransportaField;

        private CartaPorteMercanciasMercanciaDetalleMercancia detalleMercanciaField;

        private string bienesTranspField; //c_ClaveProdServCP

        private bool bienesTranspFieldSpecified;

        private string claveSTCCField; //c_ClaveProdSTCC

        private bool claveSTCCFieldSpecified;

        private string descripcionField;

        private decimal cantidadField;

        private bool cantidadFieldSpecified;

        private string claveUnidadField; //c_ClaveUnidad

        private bool claveUnidadFieldSpecified;

        private string unidadField;

        private string dimensionesField;

        private CartaPorteMercanciasMercanciaMaterialPeligroso materialPeligrosoField;

        private bool materialPeligrosoFieldSpecified;

        private string cveMaterialPeligrosoField; //c_MaterialPeligroso

        private bool cveMaterialPeligrosoFieldSpecified;

        private string embalajeField; //c_TipoEmbalaje

        private bool embalajeFieldSpecified;

        private string descripEmbalajeField;

        private decimal pesoEnKgField;

        private decimal valorMercanciaField;

        private bool valorMercanciaFieldSpecified;

        private string monedaField; //c_Moneda

        private bool monedaFieldSpecified;

        private string fraccionArancelariaField; //c_FraccionArancelaria

        private bool fraccionArancelariaFieldSpecified;

        private string uUIDComercioExtField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CantidadTransporta")]
        public CartaPorteMercanciasMercanciaCantidadTransporta[] CantidadTransporta {
            get {
                return this.cantidadTransportaField;
            }
            set {
                this.cantidadTransportaField = value;
            }
        }

        /// <remarks/>
        public CartaPorteMercanciasMercanciaDetalleMercancia DetalleMercancia {
            get {
                return this.detalleMercanciaField;
            }
            set {
                this.detalleMercanciaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BienesTransp {
            get {
                return this.bienesTranspField;
            }
            set {
                this.bienesTranspField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BienesTranspSpecified {
            get {
                return this.bienesTranspFieldSpecified;
            }
            set {
                this.bienesTranspFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaveSTCC {
            get {
                return this.claveSTCCField;
            }
            set {
                this.claveSTCCField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ClaveSTCCSpecified {
            get {
                return this.claveSTCCFieldSpecified;
            }
            set {
                this.claveSTCCFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Cantidad {
            get {
                return this.cantidadField;
            }
            set {
                this.cantidadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CantidadSpecified {
            get {
                return this.cantidadFieldSpecified;
            }
            set {
                this.cantidadFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ClaveUnidad {
            get {
                return this.claveUnidadField;
            }
            set {
                this.claveUnidadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ClaveUnidadSpecified {
            get {
                return this.claveUnidadFieldSpecified;
            }
            set {
                this.claveUnidadFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Unidad {
            get {
                return this.unidadField;
            }
            set {
                this.unidadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Dimensiones {
            get {
                return this.dimensionesField;
            }
            set {
                this.dimensionesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CartaPorteMercanciasMercanciaMaterialPeligroso MaterialPeligroso {
            get {
                return this.materialPeligrosoField;
            }
            set {
                this.materialPeligrosoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaterialPeligrosoSpecified {
            get {
                return this.materialPeligrosoFieldSpecified;
            }
            set {
                this.materialPeligrosoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CveMaterialPeligroso {
            get {
                return this.cveMaterialPeligrosoField;
            }
            set {
                this.cveMaterialPeligrosoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CveMaterialPeligrosoSpecified {
            get {
                return this.cveMaterialPeligrosoFieldSpecified;
            }
            set {
                this.cveMaterialPeligrosoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Embalaje {
            get {
                return this.embalajeField;
            }
            set {
                this.embalajeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EmbalajeSpecified {
            get {
                return this.embalajeFieldSpecified;
            }
            set {
                this.embalajeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DescripEmbalaje {
            get {
                return this.descripEmbalajeField;
            }
            set {
                this.descripEmbalajeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PesoEnKg {
            get {
                return this.pesoEnKgField;
            }
            set {
                this.pesoEnKgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ValorMercancia {
            get {
                return this.valorMercanciaField;
            }
            set {
                this.valorMercanciaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorMercanciaSpecified {
            get {
                return this.valorMercanciaFieldSpecified;
            }
            set {
                this.valorMercanciaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Moneda {
            get {
                return this.monedaField;
            }
            set {
                this.monedaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MonedaSpecified {
            get {
                return this.monedaFieldSpecified;
            }
            set {
                this.monedaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FraccionArancelaria {
            get {
                return this.fraccionArancelariaField;
            }
            set {
                this.fraccionArancelariaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FraccionArancelariaSpecified {
            get {
                return this.fraccionArancelariaFieldSpecified;
            }
            set {
                this.fraccionArancelariaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UUIDComercioExt {
            get {
                return this.uUIDComercioExtField;
            }
            set {
                this.uUIDComercioExtField = value;
            }
        }
    }
}