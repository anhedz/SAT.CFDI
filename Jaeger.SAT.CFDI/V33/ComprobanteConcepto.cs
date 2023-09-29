using System.Xml.Serialization;

namespace Jaeger.SAT.CFDI.V33 {
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteConcepto {
        private ComprobanteConceptoImpuestos impuestosField;

        private ComprobanteConceptoInformacionAduanera[] informacionAduaneraField;

        private ComprobanteConceptoCuentaPredial cuentaPredialField;

        private ComprobanteConceptoComplementoConcepto complementoConceptoField;

        private ComprobanteConceptoParte[] parteField;

        private string claveProdServField;

        private string noIdentificacionField;

        private decimal cantidadField;

        private string claveUnidadField;

        private string unidadField;

        private string descripcionField;

        private decimal valorUnitarioField;

        private decimal importeField;

        private decimal descuentoField;

        private bool descuentoFieldSpecified;

        /// <comentarios/>
        public ComprobanteConceptoImpuestos Impuestos {
            get {
                return this.impuestosField;
            }
            set {
                this.impuestosField = value;
            }
        }

        /// <comentarios/>
        [XmlElementAttribute("InformacionAduanera")]
        public ComprobanteConceptoInformacionAduanera[] InformacionAduanera {
            get {
                return this.informacionAduaneraField;
            }
            set {
                this.informacionAduaneraField = value;
            }
        }

        /// <comentarios/>
        public ComprobanteConceptoCuentaPredial CuentaPredial {
            get {
                return this.cuentaPredialField;
            }
            set {
                this.cuentaPredialField = value;
            }
        }

        /// <comentarios/>
        public ComprobanteConceptoComplementoConcepto ComplementoConcepto {
            get {
                return this.complementoConceptoField;
            }
            set {
                this.complementoConceptoField = value;
            }
        }

        /// <comentarios/>
        [XmlElementAttribute("Parte")]
        public ComprobanteConceptoParte[] Parte {
            get {
                return this.parteField;
            }
            set {
                this.parteField = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public string ClaveProdServ {
            get {
                return this.claveProdServField;
            }
            set {
                this.claveProdServField = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public string NoIdentificacion {
            get {
                return this.noIdentificacionField;
            }
            set {
                this.noIdentificacionField = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public decimal Cantidad {
            get {
                return this.cantidadField;
            }
            set {
                this.cantidadField = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public string ClaveUnidad {
            get {
                return this.claveUnidadField;
            }
            set {
                this.claveUnidadField = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public string Unidad {
            get {
                return this.unidadField;
            }
            set {
                this.unidadField = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public string Descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public decimal ValorUnitario {
            get {
                return this.valorUnitarioField;
            }
            set {
                this.valorUnitarioField = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public decimal Importe {
            get {
                return this.importeField;
            }
            set {
                this.importeField = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public decimal Descuento {
            get {
                return this.descuentoField;
            }
            set {
                this.descuentoField = value;
            }
        }

        /// <comentarios/>
        [XmlIgnoreAttribute()]
        public bool DescuentoSpecified {
            get {
                return this.descuentoFieldSpecified;
            }
            set {
                this.descuentoFieldSpecified = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteConceptoImpuestos {
        private ComprobanteConceptoImpuestosTraslado[] trasladosField;

        private ComprobanteConceptoImpuestosRetencion[] retencionesField;

        /// <comentarios/>
        [XmlArrayItemAttribute("Traslado", IsNullable = false)]
        public ComprobanteConceptoImpuestosTraslado[] Traslados {
            get {
                return this.trasladosField;
            }
            set {
                this.trasladosField = value;
            }
        }

        /// <comentarios/>
        [XmlArrayItemAttribute("Retencion", IsNullable = false)]
        public ComprobanteConceptoImpuestosRetencion[] Retenciones {
            get {
                return this.retencionesField;
            }
            set {
                this.retencionesField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteConceptoImpuestosTraslado {
        private decimal baseField;

        private string impuestoField;

        private string tipoFactorField;

        private decimal tasaOCuotaField;

        private bool tasaOCuotaFieldSpecified;

        private decimal importeField;

        private bool importeFieldSpecified;

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public decimal Base {
            get {
                return this.baseField;
            }
            set {
                this.baseField = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public string Impuesto {
            get {
                return this.impuestoField;
            }
            set {
                this.impuestoField = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public string TipoFactor {
            get {
                return this.tipoFactorField;
            }
            set {
                this.tipoFactorField = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public decimal TasaOCuota {
            get {
                return this.tasaOCuotaField;
            }
            set {
                this.tasaOCuotaField = value;
            }
        }

        /// <comentarios/>
        [XmlIgnoreAttribute()]
        public bool TasaOCuotaSpecified {
            get {
                return this.tasaOCuotaFieldSpecified;
            }
            set {
                this.tasaOCuotaFieldSpecified = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public decimal Importe {
            get {
                return this.importeField;
            }
            set {
                this.importeField = value;
            }
        }

        /// <comentarios/>
        [XmlIgnoreAttribute()]
        public bool ImporteSpecified {
            get {
                return this.importeFieldSpecified;
            }
            set {
                this.importeFieldSpecified = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteConceptoImpuestosRetencion {
        private decimal baseField;

        private string impuestoField;//c_Impuesto

        private string tipoFactorField; //c_TipoFactor

        private decimal tasaOCuotaField;

        private decimal importeField;

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public decimal Base {
            get {
                return this.baseField;
            }
            set {
                this.baseField = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public string Impuesto {
            get {
                return this.impuestoField;
            }
            set {
                this.impuestoField = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public string TipoFactor {
            get {
                return this.tipoFactorField;
            }
            set {
                this.tipoFactorField = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public decimal TasaOCuota {
            get {
                return this.tasaOCuotaField;
            }
            set {
                this.tasaOCuotaField = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public decimal Importe {
            get {
                return this.importeField;
            }
            set {
                this.importeField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteConceptoInformacionAduanera {
        private string numeroPedimentoField;

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public string NumeroPedimento {
            get {
                return this.numeroPedimentoField;
            }
            set {
                this.numeroPedimentoField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteConceptoCuentaPredial {
        private string numeroField;

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public string Numero {
            get {
                return this.numeroField;
            }
            set {
                this.numeroField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteConceptoComplementoConcepto {
        private System.Xml.XmlElement[] anyField;

        /// <comentarios/>
        [XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteConceptoParte {
        private ComprobanteConceptoParteInformacionAduanera[] informacionAduaneraField;

        private string claveProdServField;

        private string noIdentificacionField;

        private decimal cantidadField;

        private string unidadField;

        private string descripcionField;

        private decimal valorUnitarioField;

        private bool valorUnitarioFieldSpecified;

        private decimal importeField;

        private bool importeFieldSpecified;

        /// <comentarios/>
        [XmlElementAttribute("InformacionAduanera")]
        public ComprobanteConceptoParteInformacionAduanera[] InformacionAduanera {
            get {
                return this.informacionAduaneraField;
            }
            set {
                this.informacionAduaneraField = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public string ClaveProdServ {
            get {
                return this.claveProdServField;
            }
            set {
                this.claveProdServField = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public string NoIdentificacion {
            get {
                return this.noIdentificacionField;
            }
            set {
                this.noIdentificacionField = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public decimal Cantidad {
            get {
                return this.cantidadField;
            }
            set {
                this.cantidadField = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public string Unidad {
            get {
                return this.unidadField;
            }
            set {
                this.unidadField = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public string Descripcion {
            get {
                return this.descripcionField;
            }
            set {
                this.descripcionField = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public decimal ValorUnitario {
            get {
                return this.valorUnitarioField;
            }
            set {
                this.valorUnitarioField = value;
            }
        }

        /// <comentarios/>
        [XmlIgnoreAttribute()]
        public bool ValorUnitarioSpecified {
            get {
                return this.valorUnitarioFieldSpecified;
            }
            set {
                this.valorUnitarioFieldSpecified = value;
            }
        }

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public decimal Importe {
            get {
                return this.importeField;
            }
            set {
                this.importeField = value;
            }
        }

        /// <comentarios/>
        [XmlIgnoreAttribute()]
        public bool ImporteSpecified {
            get {
                return this.importeFieldSpecified;
            }
            set {
                this.importeFieldSpecified = value;
            }
        }
    }

    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteConceptoParteInformacionAduanera {
        private string numeroPedimentoField;

        /// <comentarios/>
        [XmlAttributeAttribute()]
        public string NumeroPedimento {
            get {
                return this.numeroPedimentoField;
            }
            set {
                this.numeroPedimentoField = value;
            }
        }
    }
}