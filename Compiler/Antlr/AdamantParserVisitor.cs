//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from AdamantParser.g4 by ANTLR 4.5.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace Adamant.Exploratory.Compiler.Antlr {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="AdamantParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.1")]
[System.CLSCompliant(false)]
public interface IAdamantParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompilationUnit([NotNull] AdamantParser.CompilationUnitContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.usingStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUsingStatement([NotNull] AdamantParser.UsingStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifier([NotNull] AdamantParser.IdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.namespaceName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNamespaceName([NotNull] AdamantParser.NamespaceNameContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NamespaceDeclaration</c>
	/// labeled alternative in <see cref="AdamantParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNamespaceDeclaration([NotNull] AdamantParser.NamespaceDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ClassDeclaration</c>
	/// labeled alternative in <see cref="AdamantParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassDeclaration([NotNull] AdamantParser.ClassDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>VariableDeclaration</c>
	/// labeled alternative in <see cref="AdamantParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableDeclaration([NotNull] AdamantParser.VariableDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FunctionDeclaration</c>
	/// labeled alternative in <see cref="AdamantParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionDeclaration([NotNull] AdamantParser.FunctionDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.attribute"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAttribute([NotNull] AdamantParser.AttributeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.baseTypes"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBaseTypes([NotNull] AdamantParser.BaseTypesContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.modifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModifier([NotNull] AdamantParser.ModifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.typeParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeParameterList([NotNull] AdamantParser.TypeParameterListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.typeParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeParameter([NotNull] AdamantParser.TypeParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeName([NotNull] AdamantParser.TypeNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.typeArguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeArguments([NotNull] AdamantParser.TypeArgumentsContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MutableType</c>
	/// labeled alternative in <see cref="AdamantParser.ownershipType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMutableType([NotNull] AdamantParser.MutableTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>OwnedType</c>
	/// labeled alternative in <see cref="AdamantParser.ownershipType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOwnedType([NotNull] AdamantParser.OwnedTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ImmutableType</c>
	/// labeled alternative in <see cref="AdamantParser.ownershipType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitImmutableType([NotNull] AdamantParser.ImmutableTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ArrayType</c>
	/// labeled alternative in <see cref="AdamantParser.plainType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayType([NotNull] AdamantParser.ArrayTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ArraySliceType</c>
	/// labeled alternative in <see cref="AdamantParser.plainType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArraySliceType([NotNull] AdamantParser.ArraySliceTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>StringType</c>
	/// labeled alternative in <see cref="AdamantParser.plainType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStringType([NotNull] AdamantParser.StringTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NamedType</c>
	/// labeled alternative in <see cref="AdamantParser.plainType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNamedType([NotNull] AdamantParser.NamedTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>PrimitiveNumericType</c>
	/// labeled alternative in <see cref="AdamantParser.plainType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrimitiveNumericType([NotNull] AdamantParser.PrimitiveNumericTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FunctionType</c>
	/// labeled alternative in <see cref="AdamantParser.plainType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionType([NotNull] AdamantParser.FunctionTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MaybeType</c>
	/// labeled alternative in <see cref="AdamantParser.plainType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMaybeType([NotNull] AdamantParser.MaybeTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>PointerType</c>
	/// labeled alternative in <see cref="AdamantParser.plainType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPointerType([NotNull] AdamantParser.PointerTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.funcTypeParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncTypeParameterList([NotNull] AdamantParser.FuncTypeParameterListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.funcTypeParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncTypeParameter([NotNull] AdamantParser.FuncTypeParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.constExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstExpression([NotNull] AdamantParser.ConstExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.typeParameterConstraintClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeParameterConstraintClause([NotNull] AdamantParser.TypeParameterConstraintClauseContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ConstructorConstraint</c>
	/// labeled alternative in <see cref="AdamantParser.typeParameterConstraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstructorConstraint([NotNull] AdamantParser.ConstructorConstraintContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>TypeConstraint</c>
	/// labeled alternative in <see cref="AdamantParser.typeParameterConstraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeConstraint([NotNull] AdamantParser.TypeConstraintContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>TypeListParameterConstraint</c>
	/// labeled alternative in <see cref="AdamantParser.typeParameterConstraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeListParameterConstraint([NotNull] AdamantParser.TypeListParameterConstraintContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Constructor</c>
	/// labeled alternative in <see cref="AdamantParser.member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstructor([NotNull] AdamantParser.ConstructorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Destructor</c>
	/// labeled alternative in <see cref="AdamantParser.member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDestructor([NotNull] AdamantParser.DestructorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ConversionMethod</c>
	/// labeled alternative in <see cref="AdamantParser.member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConversionMethod([NotNull] AdamantParser.ConversionMethodContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Field</c>
	/// labeled alternative in <see cref="AdamantParser.member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitField([NotNull] AdamantParser.FieldContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Property</c>
	/// labeled alternative in <see cref="AdamantParser.member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProperty([NotNull] AdamantParser.PropertyContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Method</c>
	/// labeled alternative in <see cref="AdamantParser.member"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethod([NotNull] AdamantParser.MethodContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameterList([NotNull] AdamantParser.ParameterListContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>namedParameter</c>
	/// labeled alternative in <see cref="AdamantParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNamedParameter([NotNull] AdamantParser.NamedParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>selfParameter</c>
	/// labeled alternative in <see cref="AdamantParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelfParameter([NotNull] AdamantParser.SelfParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.parameterModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameterModifier([NotNull] AdamantParser.ParameterModifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.constructorInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstructorInitializer([NotNull] AdamantParser.ConstructorInitializerContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.argumentList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArgumentList([NotNull] AdamantParser.ArgumentListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.methodBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodBody([NotNull] AdamantParser.MethodBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.overloadableOperator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOverloadableOperator([NotNull] AdamantParser.OverloadableOperatorContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>VariableDeclarationStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableDeclarationStatement([NotNull] AdamantParser.VariableDeclarationStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>UnsafeBlockStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnsafeBlockStatement([NotNull] AdamantParser.UnsafeBlockStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BlockStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockStatement([NotNull] AdamantParser.BlockStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>EmptyStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEmptyStatement([NotNull] AdamantParser.EmptyStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ExpressionStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpressionStatement([NotNull] AdamantParser.ExpressionStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ReturnStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturnStatement([NotNull] AdamantParser.ReturnStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ThrowStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitThrowStatement([NotNull] AdamantParser.ThrowStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IfStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStatement([NotNull] AdamantParser.IfStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ForStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForStatement([NotNull] AdamantParser.ForStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ForeachStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForeachStatement([NotNull] AdamantParser.ForeachStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>DeleteStatement</c>
	/// labeled alternative in <see cref="AdamantParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDeleteStatement([NotNull] AdamantParser.DeleteStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="AdamantParser.localVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLocalVariableDeclaration([NotNull] AdamantParser.LocalVariableDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NullCheckExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNullCheckExpression([NotNull] AdamantParser.NullCheckExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>StringLiteralExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStringLiteralExpression([NotNull] AdamantParser.StringLiteralExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>XorExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitXorExpression([NotNull] AdamantParser.XorExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>UnaryExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnaryExpression([NotNull] AdamantParser.UnaryExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>OrExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOrExpression([NotNull] AdamantParser.OrExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IntLiteralExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIntLiteralExpression([NotNull] AdamantParser.IntLiteralExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NewObjectExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNewObjectExpression([NotNull] AdamantParser.NewObjectExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AndExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAndExpression([NotNull] AdamantParser.AndExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AssignmentExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignmentExpression([NotNull] AdamantParser.AssignmentExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>SelfExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSelfExpression([NotNull] AdamantParser.SelfExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>BooleanLiteralExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBooleanLiteralExpression([NotNull] AdamantParser.BooleanLiteralExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>EqualityExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEqualityExpression([NotNull] AdamantParser.EqualityExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MultiplicativeExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplicativeExpression([NotNull] AdamantParser.MultiplicativeExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>CallExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCallExpression([NotNull] AdamantParser.CallExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NullLiteralExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNullLiteralExpression([NotNull] AdamantParser.NullLiteralExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>AdditiveExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAdditiveExpression([NotNull] AdamantParser.AdditiveExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>IfExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfExpression([NotNull] AdamantParser.IfExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>PointerMemberExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPointerMemberExpression([NotNull] AdamantParser.PointerMemberExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>NewExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNewExpression([NotNull] AdamantParser.NewExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>UninitializedExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUninitializedExpression([NotNull] AdamantParser.UninitializedExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>VariableExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableExpression([NotNull] AdamantParser.VariableExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ShiftExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitShiftExpression([NotNull] AdamantParser.ShiftExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>MemberExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMemberExpression([NotNull] AdamantParser.MemberExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ComparativeExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComparativeExpression([NotNull] AdamantParser.ComparativeExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>CoalesceExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCoalesceExpression([NotNull] AdamantParser.CoalesceExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ArrayAccessExpression</c>
	/// labeled alternative in <see cref="AdamantParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayAccessExpression([NotNull] AdamantParser.ArrayAccessExpressionContext context);
}
} // namespace Adamant.Exploratory.Compiler.Antlr
