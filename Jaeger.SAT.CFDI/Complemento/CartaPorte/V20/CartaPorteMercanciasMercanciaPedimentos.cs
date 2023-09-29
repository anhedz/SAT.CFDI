namespace Jaeger.SAT.CFDI.Complemento.CartaPorte.V20 {
    /// <summary>
    /// Nodo condicional para registrar la información del(los) número(s) de pedimento(s) de importación que se encuentra(n) asociado(s) al traslado de los bienes y/o mercancías de procedencia extranjera para acreditar 
    /// la legal estancia o tenencia durante su traslado en territorio nacional.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sat.gob.mx/CartaPorte20")]
    public partial class CartaPorteMercanciasMercanciaPedimentos {

        private string pedimentoField;

        /// <summary>
        /// Atributo requerido para expresar el número de pedimento de importación que se encuentra asociado con el traslado de los bienes y/o mercancías de procedencia extranjera para acreditar la legal estancia y 
        /// tenencia durante su traslado en territorio nacional, el cual se  expresa  en  el siguiente  formato:  últimos  2  dígitos  del  año  de  validación seguidos  por  dos  espacios,  2  dígitos  de  la  
        /// aduana  de despacho seguidos por dos espacios, 4 dígitos del número de  la  patente  seguidos  por  dos  espacios,  1  dígito  que corresponde al último dígito del año en curso, salvo que se trate de un 
        /// pedimento consolidado iniciado en el año inmediato anterior o del pedimento original de una rectificación, seguido de 6 dígitos de la numeración progresiva por aduana.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Pedimento {
            get {
                return this.pedimentoField;
            }
            set {
                this.pedimentoField = value;
            }
        }
    }
}