﻿using Adamant.Exploratory.Compiler.Syntax;
using Adamant.Exploratory.Compiler.Syntax.Modifiers;

namespace Adamant.Exploratory.Compiler.Symbols
{
	public abstract class EntitySymbol : DeclarationSymbol
	{
		protected EntitySymbol(PackageSyntax containingPackage, Accessibility declaredAccessibility, string name)
			: base(containingPackage, declaredAccessibility, name)
		{
		}
	}
}
