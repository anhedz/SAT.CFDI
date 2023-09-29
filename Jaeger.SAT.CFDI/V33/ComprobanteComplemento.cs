using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using Jaeger.SAT.CFDI.Complemento.TimbreFiscal.V11;
using Jaeger.SAT.CFDI.Complemento.Pagos.V10;
using Jaeger.SAT.CFDI.Complemento.LeyendasFiscales.V10;
using Jaeger.SAT.CFDI.Complemento.ValesDeDespensa.V10;
using Jaeger.SAT.CFDI.Complemento.ImpuestosLocales.V10;
using Jaeger.SAT.CFDI.Complemento.Aerolineas.V10;

namespace Jaeger.SAT.CFDI.V33 {
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/3")]
    public partial class ComprobanteComplemento {
        //private System.Xml.XmlElement[] anyField;
        private List<XmlElement> anyField;

        /// <comentarios/>
        [XmlAnyElementAttribute()]
        public List<XmlElement> Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }

        [XmlIgnore]
        public TimbreFiscalDigital TimbreFiscalDigital {
            get {
                TimbreFiscalDigital timbreFiscalDigital;
                List<XmlElement>.Enumerator enumerator = this.anyField.GetEnumerator();
                try {
                    while (enumerator.MoveNext()) {
                        XmlElement current = enumerator.Current;
                        string name = current.Name;
                        if (name == null || current.Name != "tfd:TimbreFiscalDigital") {
                            continue;
                        }
                        timbreFiscalDigital = TimbreFiscalDigital.Deserialize(current.OuterXml);
                        return timbreFiscalDigital;
                    }
                    return null;
                } catch (Exception) {
                    timbreFiscalDigital = null;
                } finally {
                    ((IDisposable)enumerator).Dispose();
                }
                return timbreFiscalDigital;
            }
            set {
                XmlDocument objXml = new XmlDocument();
                objXml.LoadXml(value.Serialize());
                if (this.anyField == null) {
                    this.anyField = new List<XmlElement>();
                }
                this.anyField.Add(objXml.DocumentElement);
            }
        }

        [XmlIgnore]
        public Jaeger.SAT.CFDI.Complemento.Nomina.V12.Nomina Nomina12 {
            get {
                Jaeger.SAT.CFDI.Complemento.Nomina.V12.Nomina nomina12;
                List<XmlElement>.Enumerator enumerator = this.anyField.GetEnumerator();
                try {
                    while (enumerator.MoveNext()) {
                        XmlElement current = enumerator.Current;
                        string name = current.Name;
                        if (name == null || name != "nomina12:Nomina") {
                            continue;
                        }
                        nomina12 = Jaeger.SAT.CFDI.Complemento.Nomina.V12.Nomina.Deserialize(current.OuterXml);
                        return nomina12;
                    }
                    return null;
                } catch (Exception) {
                    nomina12 = null;
                } finally {
                    ((IDisposable)(object)enumerator).Dispose();
                }
                return nomina12;
            }
            set {
                XmlDocument objXml = new XmlDocument();
                objXml.LoadXml(value.Serialize());
                if (this.anyField == null) {
                    this.anyField = new List<XmlElement>();
                }
                this.anyField.Add(objXml.DocumentElement);
            }
        }

        [XmlIgnore]
        public Pagos Pagos {
            get {
                Pagos pagos10;
                List<XmlElement>.Enumerator enumerator = this.anyField.GetEnumerator();
                try {
                    while (enumerator.MoveNext()) {
                        XmlElement current = enumerator.Current;
                        string name = current.Name;
                        if (name == null || name != "pago10:Pagos") {
                            continue;
                        }
                        pagos10 = Pagos.Deserialize(current.OuterXml);
                        return pagos10;
                    }
                    return null;
                } catch (Exception) {
                    pagos10 = null;
                } finally {
                    ((IDisposable)(object)enumerator).Dispose();
                }
                return pagos10;
            }
            set {
                XmlDocument objXml = new XmlDocument();
                objXml.LoadXml(value.Serialize());
                if (this.anyField == null) {
                    this.anyField = new List<XmlElement>();
                }
                this.anyField.Add(objXml.DocumentElement);
            }
        }

        [XmlIgnore]
        public LeyendasFiscales LeyendasFiscales {
            get {
                LeyendasFiscales leyendasFiscales;
                leyendasFiscales = Services.XmlSerializerService.XmlDeserializarStringXml<LeyendasFiscales>(this.Buscar("leyendasFisc:LeyendasFiscales"));
                return leyendasFiscales;
            }
        }

        [XmlIgnore]
        public ValesDeDespensa ValesDeDespensa {
            get {
                ValesDeDespensa valesDeDespensa;
                valesDeDespensa = Services.XmlSerializerService.XmlDeserializarStringXml<ValesDeDespensa>(this.Buscar("valesdedespensa:ValesDeDespensa"));
                return valesDeDespensa;
            }
        }

        [XmlIgnore]
        public ImpuestosLocales ImpuestosLocales {
            get {
                ImpuestosLocales impuestosLocales;
                impuestosLocales = Services.XmlSerializerService.XmlDeserializarStringXml<ImpuestosLocales>(this.Buscar("implocal:ImpuestosLocales"));
                return impuestosLocales;
            }
        }

        [XmlIgnore]
        public Aerolineas Aerolineas {
            get {
                Aerolineas aerolineas;
                aerolineas = Services.XmlSerializerService.XmlDeserializarStringXml<Aerolineas>(this.Buscar("aerolineas:Aerolineas"));
                return aerolineas;
            }
        }

        [XmlIgnore]
        public Complemento.EstadoCuentaCombustible.V12.EstadoDeCuentaCombustible ECC12 {
            get {
                Complemento.EstadoCuentaCombustible.V12.EstadoDeCuentaCombustible cc;
                cc = Services.XmlSerializerService.XmlDeserializarStringXml<Complemento.EstadoCuentaCombustible.V12.EstadoDeCuentaCombustible>(Buscar(""));
                return cc;
            }
        }

        [XmlIgnore]
        public Complemento.CartaPorte.V10.CartaPorte CartaPorte {
            get {
                return Services.XmlSerializerService.XmlDeserializarStringXml<Complemento.CartaPorte.V10.CartaPorte>(Buscar("cartaporte20:CartaPorte"));
            }
        }

        private string Buscar(string nombre) {
            List<XmlElement>.Enumerator enumerator = this.anyField.GetEnumerator();
            try {
                while (enumerator.MoveNext()) {
                    XmlElement current = enumerator.Current;
                    string name = current.Name;
                    if (name == null || name != nombre) {
                        continue;
                    }
                    return current.OuterXml;
                }
                return string.Empty;
            } catch (Exception) {
                return string.Empty;
            } finally {
                ((IDisposable)(object)enumerator).Dispose();
            }
        }
    }
}