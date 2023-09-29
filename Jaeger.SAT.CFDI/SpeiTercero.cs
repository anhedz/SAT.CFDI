/// <remarks/>
using System;
using System.IO;
using System.Xml.Serialization;

namespace Jaeger.SAT.CFDI {
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", IsNullable = false, ElementName = "SPEI_Tercero")]
    public partial class SpeiTercero {
        private SpeiTerceroBeneficiario beneficiarioField;

        private SpeiTerceroOrdenante ordenanteField;

        private System.DateTime fechaOperacionField;

        private System.DateTime horaField;

        private ushort claveSPEIField;

        private string selloField;

        private ulong numeroCertificadoField;

        private string cadenaCDAField;

        /// <remarks/>
        public SpeiTerceroBeneficiario Beneficiario {
            get {
                return this.beneficiarioField;
            }
            set {
                this.beneficiarioField = value;
            }
        }

        /// <remarks/>
        public SpeiTerceroOrdenante Ordenante {
            get {
                return this.ordenanteField;
            }
            set {
                this.ordenanteField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "date")]
        public System.DateTime FechaOperacion {
            get {
                return this.fechaOperacionField;
            }
            set {
                this.fechaOperacionField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "time")]
        public System.DateTime Hora {
            get {
                return this.horaField;
            }
            set {
                this.horaField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public ushort ClaveSPEI {
            get {
                return this.claveSPEIField;
            }
            set {
                this.claveSPEIField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string sello {
            get {
                return this.selloField;
            }
            set {
                this.selloField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public ulong numeroCertificado {
            get {
                return this.numeroCertificadoField;
            }
            set {
                this.numeroCertificadoField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string cadenaCDA {
            get {
                return this.cadenaCDAField;
            }
            set {
                this.cadenaCDAField = value;
            }
        }

        public static SpeiTercero LoadX(string input) {
            StreamReader oStreamReader = new StreamReader(input);
            try {
                return Services.XmlSerializerService.DeserializeObject<SpeiTercero>(oStreamReader.ReadToEnd());
            } catch (Exception) {
                return null;
            } finally {
                oStreamReader.Close();
            }
        }
    }
}

namespace Jaeger.SAT.CFDI {
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class SpeiTerceroBeneficiario {
        private string bancoReceptorField;

        private string nombreField;

        private byte tipoCuentaField;

        private string cuentaField;

        private string rFCField;

        private string conceptoField;

        private decimal iVAField;

        private byte montoPagoField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string BancoReceptor {
            get {
                return this.bancoReceptorField;
            }
            set {
                this.bancoReceptorField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte TipoCuenta {
            get {
                return this.tipoCuentaField;
            }
            set {
                this.tipoCuentaField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Cuenta {
            get {
                return this.cuentaField;
            }
            set {
                this.cuentaField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string RFC {
            get {
                return this.rFCField;
            }
            set {
                this.rFCField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Concepto {
            get {
                return this.conceptoField;
            }
            set {
                this.conceptoField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public decimal IVA {
            get {
                return this.iVAField;
            }
            set {
                this.iVAField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte MontoPago {
            get {
                return this.montoPagoField;
            }
            set {
                this.montoPagoField = value;
            }
        }
    }
}

namespace Jaeger.SAT.CFDI {
    /// <remarks/>
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class SpeiTerceroOrdenante {
        private string bancoEmisorField;

        private string nombreField;

        private byte tipoCuentaField;

        private string cuentaField;

        private string rFCField;

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string BancoEmisor {
            get {
                return this.bancoEmisorField;
            }
            set {
                this.bancoEmisorField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public byte TipoCuenta {
            get {
                return this.tipoCuentaField;
            }
            set {
                this.tipoCuentaField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Cuenta {
            get {
                return this.cuentaField;
            }
            set {
                this.cuentaField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string RFC {
            get {
                return this.rFCField;
            }
            set {
                this.rFCField = value;
            }
        }
    }
}