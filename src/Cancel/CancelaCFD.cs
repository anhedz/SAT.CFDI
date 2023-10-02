using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Jaeger.SAT.CFDI.Cancel {
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("xsd", "4.0.30319.33440")]
	[Serializable]
	[XmlRoot(Namespace="http://cancelacfd.sat.gob.mx", IsNullable=false)]
	[XmlType(AnonymousType=true, Namespace="http://cancelacfd.sat.gob.mx")]
	public class CancelaCFD
	{
        private Cancel.Cancelacion cancelacionField;

		/// <comentarios />
        public Cancel.Cancelacion Cancelacion
        {
			get
			{
				return this.cancelacionField;
			}
			set
			{
				this.cancelacionField = value;
			}
		}

		[DebuggerNonUserCode]
		public CancelaCFD()
		{
		}
	}
}