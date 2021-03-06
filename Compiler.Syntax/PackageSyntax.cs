﻿using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using Adamant.Exploratory.Common;
using Adamant.Exploratory.Compiler.Core.Diagnostics;

namespace Adamant.Exploratory.Compiler.Syntax
{
	/// <summary>
	/// A package is what a forge project produces.  The difference is that a project contains
	/// information about different configurations and targets as well as the build pipeline. A
	/// package is for a specific configuration, target etc.
	/// </summary>
	public class PackageSyntax : SyntaxNode
	{
		public readonly string Name;
		public readonly bool IsApp;
		public readonly IReadOnlyList<CompilationUnitSyntax> CompilationUnits;
		public readonly IReadOnlyList<PackageReferenceSyntax> Dependencies;
		public readonly IReadOnlyList<Diagnostic> Diagnostics;
		// TODO Language version

		public PackageSyntax(string name, bool isApp, IEnumerable<PackageReferenceSyntax> dependencies)
			: this(name, isApp, new List<CompilationUnitSyntax>(), dependencies.ToList())
		{
		}

		private PackageSyntax(string name, bool isApp, IReadOnlyList<CompilationUnitSyntax> compilationUnits, IReadOnlyList<PackageReferenceSyntax> dependencies)
		{
			Requires.NotNullOrEmpty(name, nameof(name));
			Requires.That(dependencies.Select(d => d.AliasName).Distinct().Count() == dependencies.Count, nameof(dependencies), "Dependency names/alias must be unique");

			Name = name;
			CompilationUnits = compilationUnits;
			Dependencies = dependencies;
			IsApp = isApp;
			var diagnostics = new DiagnosticsBuilder();
			foreach(var compilationUnit in CompilationUnits)
				diagnostics.Add(compilationUnit.Diagnostics);

			Diagnostics = diagnostics.Complete();
		}

		[Pure]
		public PackageSyntax With(IEnumerable<CompilationUnitSyntax> compilationUnits)
		{
			return new PackageSyntax(Name, IsApp, compilationUnits.ToList(), Dependencies);
		}
	}
}
