using System.ComponentModel;

namespace Jaeger.SAT.CFDI.V40 {
    public enum PeriodicidadEnum {
        [Description("01 - Diario")]
        Diario = 1,
        [Description("02 - Semanal")]
        Semanal = 2,
        [Description("03 - Quincenal")]
        Quincenal = 3,
        [Description("04 - Mensual")]
        Mensual = 4,
        [Description("05 - Bimestral")]
        Bimestral = 5
    }
}
