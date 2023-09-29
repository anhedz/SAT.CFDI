using System.IO;
using System.Reflection;

namespace Jaeger.SAT.CFDI.Services {
    public static class FileResourceService {
        public static string GetResources(string strResources, string strFolder = "Jaeger.SAT.CFDI.Resources", string startDirectory = "") {
            string strDirectory = Path.Combine("C:\\", strFolder);
            if (!(startDirectory == "")) {
                strDirectory = startDirectory;
            }

            if (!Directory.Exists(strDirectory)) {
                Directory.CreateDirectory(strDirectory);
            }

            using (Stream oStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(string.Concat("Jaeger.", strResources))) {
                FileStream oFileStream = new FileStream(Path.Combine(strDirectory, strResources), FileMode.Create, FileAccess.Write);
                oStream.CopyTo(oFileStream);
                oFileStream.Close();
            }
            return strDirectory;
        }

        public static string GetResources(string strResources) {
            string result = string.Empty;
            using (Stream oStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(string.Concat("Jaeger.", strResources))) {
                result = new StreamReader(oStream).ReadToEnd();
            }
            return result;
        }
    }
}
