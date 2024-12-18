//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from JavaParser.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="JavaParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface IJavaParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.compilationUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCompilationUnit([NotNull] JavaParser.CompilationUnitContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.packageDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPackageDeclaration([NotNull] JavaParser.PackageDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.importDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitImportDeclaration([NotNull] JavaParser.ImportDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.typeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeDeclaration([NotNull] JavaParser.TypeDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.modifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitModifier([NotNull] JavaParser.ModifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.classOrInterfaceModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassOrInterfaceModifier([NotNull] JavaParser.ClassOrInterfaceModifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.variableModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableModifier([NotNull] JavaParser.VariableModifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.classDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassDeclaration([NotNull] JavaParser.ClassDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.typeParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeParameters([NotNull] JavaParser.TypeParametersContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.typeParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeParameter([NotNull] JavaParser.TypeParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.typeBound"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeBound([NotNull] JavaParser.TypeBoundContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.enumDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumDeclaration([NotNull] JavaParser.EnumDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.enumConstants"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumConstants([NotNull] JavaParser.EnumConstantsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.enumConstant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumConstant([NotNull] JavaParser.EnumConstantContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.enumBodyDeclarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnumBodyDeclarations([NotNull] JavaParser.EnumBodyDeclarationsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.interfaceDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInterfaceDeclaration([NotNull] JavaParser.InterfaceDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.classBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassBody([NotNull] JavaParser.ClassBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.interfaceBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInterfaceBody([NotNull] JavaParser.InterfaceBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.classBodyDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassBodyDeclaration([NotNull] JavaParser.ClassBodyDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.memberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMemberDeclaration([NotNull] JavaParser.MemberDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.methodDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodDeclaration([NotNull] JavaParser.MethodDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.methodBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodBody([NotNull] JavaParser.MethodBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.typeTypeOrVoid"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeTypeOrVoid([NotNull] JavaParser.TypeTypeOrVoidContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.genericMethodDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGenericMethodDeclaration([NotNull] JavaParser.GenericMethodDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.genericConstructorDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGenericConstructorDeclaration([NotNull] JavaParser.GenericConstructorDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.constructorDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstructorDeclaration([NotNull] JavaParser.ConstructorDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.fieldDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFieldDeclaration([NotNull] JavaParser.FieldDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.interfaceBodyDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInterfaceBodyDeclaration([NotNull] JavaParser.InterfaceBodyDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.interfaceMemberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInterfaceMemberDeclaration([NotNull] JavaParser.InterfaceMemberDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.constDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstDeclaration([NotNull] JavaParser.ConstDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.constantDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstantDeclarator([NotNull] JavaParser.ConstantDeclaratorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.interfaceMethodDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInterfaceMethodDeclaration([NotNull] JavaParser.InterfaceMethodDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.interfaceMethodModifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInterfaceMethodModifier([NotNull] JavaParser.InterfaceMethodModifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.genericInterfaceMethodDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGenericInterfaceMethodDeclaration([NotNull] JavaParser.GenericInterfaceMethodDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.variableDeclarators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableDeclarators([NotNull] JavaParser.VariableDeclaratorsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.variableDeclarator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableDeclarator([NotNull] JavaParser.VariableDeclaratorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.variableDeclaratorId"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableDeclaratorId([NotNull] JavaParser.VariableDeclaratorIdContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.variableInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableInitializer([NotNull] JavaParser.VariableInitializerContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.arrayInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayInitializer([NotNull] JavaParser.ArrayInitializerContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.classOrInterfaceType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassOrInterfaceType([NotNull] JavaParser.ClassOrInterfaceTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.typeArgument"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeArgument([NotNull] JavaParser.TypeArgumentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.qualifiedNameList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQualifiedNameList([NotNull] JavaParser.QualifiedNameListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.formalParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFormalParameters([NotNull] JavaParser.FormalParametersContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.formalParameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFormalParameterList([NotNull] JavaParser.FormalParameterListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.formalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFormalParameter([NotNull] JavaParser.FormalParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.lastFormalParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLastFormalParameter([NotNull] JavaParser.LastFormalParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.qualifiedName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitQualifiedName([NotNull] JavaParser.QualifiedNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteral([NotNull] JavaParser.LiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.integerLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIntegerLiteral([NotNull] JavaParser.IntegerLiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.floatLiteral"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFloatLiteral([NotNull] JavaParser.FloatLiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.annotation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAnnotation([NotNull] JavaParser.AnnotationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.elementValuePairs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElementValuePairs([NotNull] JavaParser.ElementValuePairsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.elementValuePair"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElementValuePair([NotNull] JavaParser.ElementValuePairContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.elementValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElementValue([NotNull] JavaParser.ElementValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.elementValueArrayInitializer"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElementValueArrayInitializer([NotNull] JavaParser.ElementValueArrayInitializerContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.annotationTypeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAnnotationTypeDeclaration([NotNull] JavaParser.AnnotationTypeDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.annotationTypeBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAnnotationTypeBody([NotNull] JavaParser.AnnotationTypeBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.annotationTypeElementDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAnnotationTypeElementDeclaration([NotNull] JavaParser.AnnotationTypeElementDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.annotationTypeElementRest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAnnotationTypeElementRest([NotNull] JavaParser.AnnotationTypeElementRestContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.annotationMethodOrConstantRest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAnnotationMethodOrConstantRest([NotNull] JavaParser.AnnotationMethodOrConstantRestContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.annotationMethodRest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAnnotationMethodRest([NotNull] JavaParser.AnnotationMethodRestContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.annotationConstantRest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAnnotationConstantRest([NotNull] JavaParser.AnnotationConstantRestContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.defaultValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDefaultValue([NotNull] JavaParser.DefaultValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] JavaParser.BlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.blockStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlockStatement([NotNull] JavaParser.BlockStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.localVariableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLocalVariableDeclaration([NotNull] JavaParser.LocalVariableDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.localTypeDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLocalTypeDeclaration([NotNull] JavaParser.LocalTypeDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] JavaParser.StatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.catchClause"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCatchClause([NotNull] JavaParser.CatchClauseContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.catchType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCatchType([NotNull] JavaParser.CatchTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.finallyBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFinallyBlock([NotNull] JavaParser.FinallyBlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.resourceSpecification"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitResourceSpecification([NotNull] JavaParser.ResourceSpecificationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.resources"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitResources([NotNull] JavaParser.ResourcesContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.resource"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitResource([NotNull] JavaParser.ResourceContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.switchBlockStatementGroup"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSwitchBlockStatementGroup([NotNull] JavaParser.SwitchBlockStatementGroupContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.switchLabel"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSwitchLabel([NotNull] JavaParser.SwitchLabelContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.forControl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForControl([NotNull] JavaParser.ForControlContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.forInit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForInit([NotNull] JavaParser.ForInitContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.enhancedForControl"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitEnhancedForControl([NotNull] JavaParser.EnhancedForControlContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.parExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParExpression([NotNull] JavaParser.ParExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.expressionList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpressionList([NotNull] JavaParser.ExpressionListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.methodCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodCall([NotNull] JavaParser.MethodCallContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] JavaParser.ExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.lambdaExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLambdaExpression([NotNull] JavaParser.LambdaExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.lambdaParameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLambdaParameters([NotNull] JavaParser.LambdaParametersContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.lambdaBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLambdaBody([NotNull] JavaParser.LambdaBodyContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.primary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrimary([NotNull] JavaParser.PrimaryContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.classType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassType([NotNull] JavaParser.ClassTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.creator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCreator([NotNull] JavaParser.CreatorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.createdName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCreatedName([NotNull] JavaParser.CreatedNameContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.innerCreator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitInnerCreator([NotNull] JavaParser.InnerCreatorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.arrayCreatorRest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArrayCreatorRest([NotNull] JavaParser.ArrayCreatorRestContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.classCreatorRest"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassCreatorRest([NotNull] JavaParser.ClassCreatorRestContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.explicitGenericInvocation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExplicitGenericInvocation([NotNull] JavaParser.ExplicitGenericInvocationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.typeArgumentsOrDiamond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeArgumentsOrDiamond([NotNull] JavaParser.TypeArgumentsOrDiamondContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.nonWildcardTypeArgumentsOrDiamond"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNonWildcardTypeArgumentsOrDiamond([NotNull] JavaParser.NonWildcardTypeArgumentsOrDiamondContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.nonWildcardTypeArguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNonWildcardTypeArguments([NotNull] JavaParser.NonWildcardTypeArgumentsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.typeList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeList([NotNull] JavaParser.TypeListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.typeType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeType([NotNull] JavaParser.TypeTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.primitiveType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrimitiveType([NotNull] JavaParser.PrimitiveTypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.typeArguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTypeArguments([NotNull] JavaParser.TypeArgumentsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.superSuffix"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSuperSuffix([NotNull] JavaParser.SuperSuffixContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.explicitGenericInvocationSuffix"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExplicitGenericInvocationSuffix([NotNull] JavaParser.ExplicitGenericInvocationSuffixContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="JavaParser.arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArguments([NotNull] JavaParser.ArgumentsContext context);
}
