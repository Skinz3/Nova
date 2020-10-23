//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from NovaParser.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="NovaParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface INovaParserListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>primaryExpr</c>
	/// labeled alternative in <see cref="NovaParser.primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryExpr([NotNull] NovaParser.PrimaryExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>primaryExpr</c>
	/// labeled alternative in <see cref="NovaParser.primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryExpr([NotNull] NovaParser.PrimaryExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>primarylit</c>
	/// labeled alternative in <see cref="NovaParser.primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimarylit([NotNull] NovaParser.PrimarylitContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>primarylit</c>
	/// labeled alternative in <see cref="NovaParser.primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimarylit([NotNull] NovaParser.PrimarylitContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>litIdent</c>
	/// labeled alternative in <see cref="NovaParser.primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLitIdent([NotNull] NovaParser.LitIdentContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>litIdent</c>
	/// labeled alternative in <see cref="NovaParser.primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLitIdent([NotNull] NovaParser.LitIdentContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="NovaParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterString([NotNull] NovaParser.StringContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="NovaParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitString([NotNull] NovaParser.StringContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>bool</c>
	/// labeled alternative in <see cref="NovaParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBool([NotNull] NovaParser.BoolContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>bool</c>
	/// labeled alternative in <see cref="NovaParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBool([NotNull] NovaParser.BoolContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>null</c>
	/// labeled alternative in <see cref="NovaParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNull([NotNull] NovaParser.NullContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>null</c>
	/// labeled alternative in <see cref="NovaParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNull([NotNull] NovaParser.NullContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>char</c>
	/// labeled alternative in <see cref="NovaParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChar([NotNull] NovaParser.CharContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>char</c>
	/// labeled alternative in <see cref="NovaParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChar([NotNull] NovaParser.CharContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>float</c>
	/// labeled alternative in <see cref="NovaParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFloat([NotNull] NovaParser.FloatContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>float</c>
	/// labeled alternative in <see cref="NovaParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFloat([NotNull] NovaParser.FloatContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="NovaParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInt([NotNull] NovaParser.IntContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="NovaParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInt([NotNull] NovaParser.IntContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ntvCall</c>
	/// labeled alternative in <see cref="NovaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNtvCall([NotNull] NovaParser.NtvCallContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ntvCall</c>
	/// labeled alternative in <see cref="NovaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNtvCall([NotNull] NovaParser.NtvCallContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>primaryValue</c>
	/// labeled alternative in <see cref="NovaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryValue([NotNull] NovaParser.PrimaryValueContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>primaryValue</c>
	/// labeled alternative in <see cref="NovaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryValue([NotNull] NovaParser.PrimaryValueContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>unaryExpr</c>
	/// labeled alternative in <see cref="NovaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryExpr([NotNull] NovaParser.UnaryExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>unaryExpr</c>
	/// labeled alternative in <see cref="NovaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryExpr([NotNull] NovaParser.UnaryExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>ctorCall</c>
	/// labeled alternative in <see cref="NovaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCtorCall([NotNull] NovaParser.CtorCallContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>ctorCall</c>
	/// labeled alternative in <see cref="NovaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCtorCall([NotNull] NovaParser.CtorCallContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>metCall</c>
	/// labeled alternative in <see cref="NovaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMetCall([NotNull] NovaParser.MetCallContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>metCall</c>
	/// labeled alternative in <see cref="NovaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMetCall([NotNull] NovaParser.MetCallContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>binaryExpr</c>
	/// labeled alternative in <see cref="NovaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBinaryExpr([NotNull] NovaParser.BinaryExprContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>binaryExpr</c>
	/// labeled alternative in <see cref="NovaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBinaryExpr([NotNull] NovaParser.BinaryExprContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>fieldAccessor</c>
	/// labeled alternative in <see cref="NovaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldAccessor([NotNull] NovaParser.FieldAccessorContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>fieldAccessor</c>
	/// labeled alternative in <see cref="NovaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldAccessor([NotNull] NovaParser.FieldAccessorContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>methodAccessor</c>
	/// labeled alternative in <see cref="NovaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodAccessor([NotNull] NovaParser.MethodAccessorContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>methodAccessor</c>
	/// labeled alternative in <see cref="NovaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodAccessor([NotNull] NovaParser.MethodAccessorContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompilationUnit([NotNull] NovaParser.CompilationUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompilationUnit([NotNull] NovaParser.CompilationUnitContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.importDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImportDeclaration([NotNull] NovaParser.ImportDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.importDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImportDeclaration([NotNull] NovaParser.ImportDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.fileName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFileName([NotNull] NovaParser.FileNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.fileName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFileName([NotNull] NovaParser.FileNameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.typeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeDeclaration([NotNull] NovaParser.TypeDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.typeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeDeclaration([NotNull] NovaParser.TypeDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.primitiveDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimitiveDeclaration([NotNull] NovaParser.PrimitiveDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.primitiveDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimitiveDeclaration([NotNull] NovaParser.PrimitiveDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.classDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassDeclaration([NotNull] NovaParser.ClassDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.classDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassDeclaration([NotNull] NovaParser.ClassDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.structDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStructDeclaration([NotNull] NovaParser.StructDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.structDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStructDeclaration([NotNull] NovaParser.StructDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.classBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassBody([NotNull] NovaParser.ClassBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.classBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassBody([NotNull] NovaParser.ClassBodyContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.memberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMemberDeclaration([NotNull] NovaParser.MemberDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.memberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMemberDeclaration([NotNull] NovaParser.MemberDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.modifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterModifier([NotNull] NovaParser.ModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.modifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitModifier([NotNull] NovaParser.ModifierContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.classModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassModifier([NotNull] NovaParser.ClassModifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.classModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassModifier([NotNull] NovaParser.ClassModifierContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.fieldDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldDeclaration([NotNull] NovaParser.FieldDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.fieldDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldDeclaration([NotNull] NovaParser.FieldDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.variableDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableDeclarator([NotNull] NovaParser.VariableDeclaratorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.variableDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableDeclarator([NotNull] NovaParser.VariableDeclaratorContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.variableInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableInitializer([NotNull] NovaParser.VariableInitializerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.variableInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableInitializer([NotNull] NovaParser.VariableInitializerContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.variableDeclaratorId"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableDeclaratorId([NotNull] NovaParser.VariableDeclaratorIdContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.variableDeclaratorId"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableDeclaratorId([NotNull] NovaParser.VariableDeclaratorIdContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.typeType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeType([NotNull] NovaParser.TypeTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.typeType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeType([NotNull] NovaParser.TypeTypeContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.primitiveTypeOrUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimitiveTypeOrUnit([NotNull] NovaParser.PrimitiveTypeOrUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.primitiveTypeOrUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimitiveTypeOrUnit([NotNull] NovaParser.PrimitiveTypeOrUnitContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.primitiveType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimitiveType([NotNull] NovaParser.PrimitiveTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.primitiveType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimitiveType([NotNull] NovaParser.PrimitiveTypeContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] NovaParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] NovaParser.ExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.methodDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodDeclaration([NotNull] NovaParser.MethodDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.methodDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodDeclaration([NotNull] NovaParser.MethodDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.typeTypeOrUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeTypeOrUnit([NotNull] NovaParser.TypeTypeOrUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.typeTypeOrUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeTypeOrUnit([NotNull] NovaParser.TypeTypeOrUnitContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.formalParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFormalParameters([NotNull] NovaParser.FormalParametersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.formalParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFormalParameters([NotNull] NovaParser.FormalParametersContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.formalParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFormalParameterList([NotNull] NovaParser.FormalParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.formalParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFormalParameterList([NotNull] NovaParser.FormalParameterListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.formalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFormalParameter([NotNull] NovaParser.FormalParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.formalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFormalParameter([NotNull] NovaParser.FormalParameterContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.lastFormalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLastFormalParameter([NotNull] NovaParser.LastFormalParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.lastFormalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLastFormalParameter([NotNull] NovaParser.LastFormalParameterContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.constructorDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructorDeclaration([NotNull] NovaParser.ConstructorDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.constructorDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructorDeclaration([NotNull] NovaParser.ConstructorDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.methodBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodBody([NotNull] NovaParser.MethodBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.methodBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodBody([NotNull] NovaParser.MethodBodyContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] NovaParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] NovaParser.BlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.localVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLocalVariableDeclaration([NotNull] NovaParser.LocalVariableDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.localVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLocalVariableDeclaration([NotNull] NovaParser.LocalVariableDeclarationContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] NovaParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] NovaParser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileStatement([NotNull] NovaParser.WhileStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileStatement([NotNull] NovaParser.WhileStatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturnStatement([NotNull] NovaParser.ReturnStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturnStatement([NotNull] NovaParser.ReturnStatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.assignationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignationStatement([NotNull] NovaParser.AssignationStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.assignationStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignationStatement([NotNull] NovaParser.AssignationStatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.statementExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementExpression([NotNull] NovaParser.StatementExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.statementExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementExpression([NotNull] NovaParser.StatementExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfStatement([NotNull] NovaParser.IfStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfStatement([NotNull] NovaParser.IfStatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForStatement([NotNull] NovaParser.ForStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForStatement([NotNull] NovaParser.ForStatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.parExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParExpression([NotNull] NovaParser.ParExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.parExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParExpression([NotNull] NovaParser.ParExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.forControl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForControl([NotNull] NovaParser.ForControlContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.forControl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForControl([NotNull] NovaParser.ForControlContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.expressionList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionList([NotNull] NovaParser.ExpressionListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.expressionList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionList([NotNull] NovaParser.ExpressionListContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimary([NotNull] NovaParser.PrimaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimary([NotNull] NovaParser.PrimaryContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.primaryIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryIdentifier([NotNull] NovaParser.PrimaryIdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.primaryIdentifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryIdentifier([NotNull] NovaParser.PrimaryIdentifierContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteral([NotNull] NovaParser.LiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteral([NotNull] NovaParser.LiteralContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.integerLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntegerLiteral([NotNull] NovaParser.IntegerLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.integerLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntegerLiteral([NotNull] NovaParser.IntegerLiteralContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.floatLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFloatLiteral([NotNull] NovaParser.FloatLiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.floatLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFloatLiteral([NotNull] NovaParser.FloatLiteralContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.methodCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodCall([NotNull] NovaParser.MethodCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.methodCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodCall([NotNull] NovaParser.MethodCallContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.constructorCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstructorCall([NotNull] NovaParser.ConstructorCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.constructorCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstructorCall([NotNull] NovaParser.ConstructorCallContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.nativeCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNativeCall([NotNull] NovaParser.NativeCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.nativeCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNativeCall([NotNull] NovaParser.NativeCallContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.creator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreator([NotNull] NovaParser.CreatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.creator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreator([NotNull] NovaParser.CreatorContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.createdName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCreatedName([NotNull] NovaParser.CreatedNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.createdName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCreatedName([NotNull] NovaParser.CreatedNameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.classCreatorRest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterClassCreatorRest([NotNull] NovaParser.ClassCreatorRestContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.classCreatorRest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitClassCreatorRest([NotNull] NovaParser.ClassCreatorRestContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="NovaParser.arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArguments([NotNull] NovaParser.ArgumentsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="NovaParser.arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArguments([NotNull] NovaParser.ArgumentsContext context);
}
