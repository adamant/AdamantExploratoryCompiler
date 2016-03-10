﻿using System.Collections.Generic;

namespace Adamant.Exploratory.Compiler.Core.Diagnostics
{
	public class DiagnosticsBuilder
	{
		private List<Diagnostic> diagnostics = new List<Diagnostic>();

		public DiagnosticsBuilder()
		{
		}

		public DiagnosticsBuilder(IEnumerable<Diagnostic> diagnostics)
		{
			this.diagnostics.AddRange(diagnostics);
		}

		public void Add(IEnumerable<Diagnostic> diagnostics)
		{
			this.diagnostics.AddRange(diagnostics);
		}

		public IReadOnlyList<Diagnostic> Complete()
		{
			var result = diagnostics;
			diagnostics = null;
			result.Sort();
			return result;
		}
	}
}
