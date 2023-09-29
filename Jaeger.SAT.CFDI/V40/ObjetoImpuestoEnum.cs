using System.ComponentModel;
namespace Jaeger.SAT.CFDI.V40 {
    public enum ObjetoImpuestoEnum {
        [Description("01 - No objeto de impuesto.")]
        No_objeto_de_impuesto = 1,
        [Description("02 - Sí objeto de impuesto.")]
        Si_objeto_de_impuesto = 2,
        [Description("03 - Sí objeto del impuesto y no obligado al desglose.")]
        Si_objeto_de_impuesto_y = 3
    }
}
