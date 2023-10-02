using System;
using System.IO;

namespace Jaeger.SAT.CFDI.Helper {
    public static class LogErrorService {
        public static string FileName;

        /// <summary>
        /// Constructor
        /// </summary>
        static LogErrorService() {
            LogErrorService.FileName = "C:\\Jaeger\\Jaeger.Log\\jaeger_sat_cfdi.log";
        }

        static public bool LogDelete() {
            try {
                File.Delete(LogErrorService.FileName);
                return true;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static void LogWrite(string mensaje) {
            try {
                if (!File.Exists(LogErrorService.FileName)) {
                    File.Create(LogErrorService.FileName).Close();
                }
                var streamWriter = File.AppendText(LogErrorService.FileName);
                object[] type = new object[] { mensaje, "|", DateTime.Now.ToString("s") };
                streamWriter.WriteLine(string.Concat(type));
                streamWriter.Close();
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public static void LogWrite(this Exception exception, string mensaje) {
            try {
                if (!File.Exists(LogErrorService.FileName)) {
                    File.Create(LogErrorService.FileName).Close();
                }
                var streamWriter = File.AppendText(LogErrorService.FileName);
                object[] type = new object[] { mensaje, "|", DateTime.Now.ToString("s") };
                streamWriter.WriteLine(string.Concat(type));
                streamWriter.WriteLine(exception.StackTrace);
                streamWriter.Close();
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
