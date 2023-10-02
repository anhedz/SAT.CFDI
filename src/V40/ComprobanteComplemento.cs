using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using Jaeger.SAT.CFDI.Complemento.TimbreFiscal.V11;
using Jaeger.SAT.CFDI.Complemento.Aerolineas.V10;
using Jaeger.SAT.CFDI.Complemento.ImpuestosLocales.V10;
using Jaeger.SAT.CFDI.Complemento.LeyendasFiscales.V10;
using Jaeger.SAT.CFDI.Complemento.ValesDeDespensa.V10;
using Jaeger.SAT.CFDI.Complemento.Pagos.V20;

namespace Jaeger.SAT.CFDI.V40 {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/cfd/4")]
    public partial class ComprobanteComplemento {

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
        public Pagos Pagos {
            get {
                Pagos pagos10;
                List<XmlElement>.Enumerator enumerator = this.anyField.GetEnumerator();
                try {
                    while (enumerator.MoveNext()) {
                        XmlElement current = enumerator.Current;
                        string name = current.Name;
                        if (name == null || name != "pago20:Pagos") {
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
        public Complemento.CartaPorte.V20.CartaPorte CartaPorte {
            get {
                Complemento.CartaPorte.V20.CartaPorte pagos10;
                List<XmlElement>.Enumerator enumerator = this.anyField.GetEnumerator();
                try {
                    while (enumerator.MoveNext()) {
                        XmlElement current = enumerator.Current;
                        string name = current.Name;
                        if (name == null || name != "cartaporte20:CartaPorte") {
                            continue;
                        }
                        pagos10 = Complemento.CartaPorte.V20.CartaPorte.Deserialize(current.OuterXml);
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
        public Complemento.Nomina.V12.Nomina Nomina {
            get {
                return Services.XmlSerializerService.XmlDeserializarStringXml<Complemento.Nomina.V12.Nomina>(this.Buscar("nominas12:Nomina"));
            }
            set {
                var xml = new XmlDocument();
                xml.LoadXml(value.Serialize());
                if (this.anyField == null) {
                    this.anyField = new List<XmlElement>();
                }
                this.anyField.Add(xml.DocumentElement);
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
