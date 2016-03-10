﻿using System.Collections.Generic;
using System.Linq;
using Adamant.Exploratory.Compiler.Syntax;
using Adamant.Exploratory.Compiler.Syntax.Expressions;
using Adamant.Exploratory.Compiler.Syntax.ValueTypes;

namespace Adamant.Exploratory.Compiler.Antlr.Builders
{
	public class ExpressionBuilder : Builder<Expression>
	{
		private readonly IBuildContext build;

		public ExpressionBuilder(IBuildContext build)
		{
			this.build = build;
		}

		public override Expression VisitMemberExpression(AdamantParser.MemberExpressionContext context)
		{
			var expression = context.expression().Accept(this);
			var member = Identifier(context.identifier());
			return new MemberExpression(expression, member);
		}

		public override Expression VisitCallExpression(AdamantParser.CallExpressionContext context)
		{
			var expression = context.expression().Accept(this);
			var arguments = context.argumentList()._expressions.Select(exp => exp.Accept(this));
			return new CallExpression(expression, arguments);
		}

		public override Expression VisitEqualityExpression(AdamantParser.EqualityExpressionContext context)
		{
			var lhs = context.lhs.Accept(this);
			var rhs = context.rhs.Accept(this);
			return new BinaryOperatorExpression(lhs, rhs);
		}

		public override Expression VisitIfExpression(AdamantParser.IfExpressionContext context)
		{
			var condition = context.condition.Accept(this);
			var then = context.then.Accept(this);
			var @else = context.@else.Accept(this);
			return new IfExpression(condition, then, @else);
		}

		public override Expression VisitVariableExpression(AdamantParser.VariableExpressionContext context)
		{
			var name = Identifier(context.identifier());
			return new VariableExpression(new IdentifierName(name));
		}

		public override Expression VisitNewExpression(AdamantParser.NewExpressionContext context)
		{
			var type = context.name().Accept(build.Name);
			var arguments = context.argumentList()._expressions.Select(exp => exp.Accept(this));
			return new NewExpression(type, arguments);
		}

		public override Expression VisitNewObjectExpression(AdamantParser.NewObjectExpressionContext context)
		{
			var baseTypes = context.baseTypes();
			var baseClass = baseTypes?.baseType?.Accept(build.ValueType);
			var interfaces = baseTypes?._interfaces.Select(i => i.Accept(build.ValueType)).ToList() ?? new List<ValueType>();
			var arguments = context.argumentList()._expressions.Select(exp => exp.Accept(this));
			var members = context.member().Select(m => m.Accept(build.Member));
			return new NewObjectExpression(baseClass, interfaces, arguments, members);
		}

		public override Expression VisitBooleanLiteralExpression(AdamantParser.BooleanLiteralExpressionContext context)
		{
			return new LiteralExpression();
		}

		public override Expression VisitIntLiteralExpression(AdamantParser.IntLiteralExpressionContext context)
		{
			return new LiteralExpression();
		}

		public override Expression VisitStringLiteralExpression(AdamantParser.StringLiteralExpressionContext context)
		{
			return new LiteralExpression();
		}

		public override Expression VisitAssignmentExpression(AdamantParser.AssignmentExpressionContext context)
		{
			var lvalue = context.lvalue.Accept(this);
			var rvalue = context.rvalue.Accept(this);
			return new AssignmentExpression(lvalue, rvalue);
		}

		public override Expression VisitSelfExpression(AdamantParser.SelfExpressionContext context)
		{
			return new SelfExpression();
		}
	}
}
