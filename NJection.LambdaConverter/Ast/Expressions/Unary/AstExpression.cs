﻿using NJection.LambdaConverter.Visitors;
using NRefactory = ICSharpCode.NRefactory.CSharp;

namespace NJection.LambdaConverter.Expressions
{
    public abstract partial class AstExpression
    {
        public static Unary Unary(NRefactory.UnaryOperatorExpression unaryOperatorExpression, IScope scope, INRefcatoryExpressionVisitor visitor) {
            return new Unary(unaryOperatorExpression, scope, visitor);
        }
    }
}