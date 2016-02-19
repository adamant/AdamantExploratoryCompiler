﻿namespace Adamant.Exploratory.Compiler.Ast.Statements
{
	public class ReturnStatement : Statement
	{
		public readonly Expression Expression;

		public ReturnStatement(Expression expression)
		{
			Expression = expression;
		}
	}
}
