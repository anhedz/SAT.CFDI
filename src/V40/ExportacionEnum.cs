using System.ComponentModel;

namespace Jaeger.SAT.CFDI.V40 {
    public enum ExportacionEnum {
        [Description("01 - No aplica")]
        No_Aplica = 1,
        [Description("02 - Definitiva")]
        Definitiva = 2,
        [Description("03 - Temporal")]
        Temporal = 3
    }
}
