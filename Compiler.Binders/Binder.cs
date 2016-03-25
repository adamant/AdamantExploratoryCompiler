﻿using System.Collections.Generic;
using Adamant.Exploratory.Common;
using Adamant.Exploratory.Compiler.Binders.LookupResults;
using Adamant.Exploratory.Compiler.Binders.SymbolReferences;
using Adamant.Exploratory.Compiler.Syntax;
using Adamant.Exploratory.Compiler.Syntax.ValueTypes;

namespace Adamant.Exploratory.Compiler.Binders
{
	/// <summary>
	/// A binder associates code references with their associated symbols
	/// </summary>
	public abstract class Binder
	{
		protected readonly Binder ContainingScope;

		protected Binder(Binder containingScope)
		{
			ContainingScope = containingScope;
		}

		public abstract IEnumerable<SymbolReference> GetMembers(string name);

		public LookupResult Lookup(NameSyntax name, Package fromPackage)
		{
			return name.Match().Returning<LookupResult>()
				.With<QualifiedNameSyntax>(qualifiedName =>
				{
					var context = Lookup(qualifiedName.Left, fromPackage);
					return context.Lookup(qualifiedName.Right, fromPackage);
				})
				.With<IdentifierNameSyntax>(i => Lookup(i, fromPackage))
				.Exhaustive();
		}

		protected abstract LookupResult Lookup(IdentifierNameSyntax identifierName, Package fromPackage);

		public virtual LookupResult LookupInGlobalNamespace(NameSyntax name, Package fromPackage)
		{
			return ContainingScope.LookupInGlobalNamespace(name, fromPackage);
		}
	}
}
