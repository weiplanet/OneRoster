namespace Questar.OneRoster.Test
{
    using System;
    using System.Collections.ObjectModel;
    using System.Linq.Expressions;
    using System.Reflection;

    public class ExpressionComparer
    {
        private ScopedDictionary<ParameterExpression, ParameterExpression> _parameterScope;
        private readonly Func<object, object, bool> _fnCompare;

        protected ExpressionComparer(
            ScopedDictionary<ParameterExpression, ParameterExpression> parameterScope,
            Func<object, object, bool> fnCompare)
        {
            _parameterScope = parameterScope;
            _fnCompare = fnCompare;
        }

        protected Func<object, object, bool> FnCompare => _fnCompare;

        public static bool AreEqual(Expression a, Expression b)
            => AreEqual(null, a, b);

        public static bool AreEqual(Expression a, Expression b, Func<object, object, bool> fnCompare)
            => AreEqual(null, a, b, fnCompare);

        public static bool AreEqual(
            ScopedDictionary<ParameterExpression, ParameterExpression> parameterScope,
            Expression a,
            Expression b)
            => new ExpressionComparer(parameterScope, null).Compare(a, b);

        public static bool AreEqual(
            ScopedDictionary<ParameterExpression, ParameterExpression> parameterScope,
            Expression a,
            Expression b,
            Func<object, object, bool> fnCompare)
            => new ExpressionComparer(parameterScope, fnCompare).Compare(a, b);

        protected virtual bool Compare(Expression a, Expression b)
        {
            if (a == b) return true;
            if (a == null || b == null) return false;
            if (a.NodeType != b.NodeType) return false;
            if (a.Type != b.Type) return false;
            switch (a.NodeType)
            {
                case ExpressionType.Negate:
                case ExpressionType.NegateChecked:
                case ExpressionType.Not:
                case ExpressionType.Convert:
                case ExpressionType.ConvertChecked:
                case ExpressionType.ArrayLength:
                case ExpressionType.Quote:
                case ExpressionType.TypeAs:
                case ExpressionType.UnaryPlus:
                    return CompareUnary((UnaryExpression)a, (UnaryExpression)b);
                case ExpressionType.Add:
                case ExpressionType.AddChecked:
                case ExpressionType.Subtract:
                case ExpressionType.SubtractChecked:
                case ExpressionType.Multiply:
                case ExpressionType.MultiplyChecked:
                case ExpressionType.Divide:
                case ExpressionType.Modulo:
                case ExpressionType.And:
                case ExpressionType.AndAlso:
                case ExpressionType.Or:
                case ExpressionType.OrElse:
                case ExpressionType.LessThan:
                case ExpressionType.LessThanOrEqual:
                case ExpressionType.GreaterThan:
                case ExpressionType.GreaterThanOrEqual:
                case ExpressionType.Equal:
                case ExpressionType.NotEqual:
                case ExpressionType.Coalesce:
                case ExpressionType.ArrayIndex:
                case ExpressionType.RightShift:
                case ExpressionType.LeftShift:
                case ExpressionType.ExclusiveOr:
                case ExpressionType.Power:
                    return CompareBinary((BinaryExpression)a, (BinaryExpression)b);
                case ExpressionType.TypeIs:
                    return CompareTypeIs((TypeBinaryExpression)a, (TypeBinaryExpression)b);
                case ExpressionType.Conditional:
                    return CompareConditional((ConditionalExpression)a, (ConditionalExpression)b);
                case ExpressionType.Constant:
                    return CompareConstant((ConstantExpression)a, (ConstantExpression)b);
                case ExpressionType.Parameter:
                    return CompareParameter((ParameterExpression)a, (ParameterExpression)b);
                case ExpressionType.MemberAccess:
                    return CompareMemberAccess((MemberExpression)a, (MemberExpression)b);
                case ExpressionType.Call:
                    return CompareMethodCall((MethodCallExpression)a, (MethodCallExpression)b);
                case ExpressionType.Lambda:
                    return CompareLambda((LambdaExpression)a, (LambdaExpression)b);
                case ExpressionType.New:
                    return CompareNew((NewExpression)a, (NewExpression)b);
                case ExpressionType.NewArrayInit:
                case ExpressionType.NewArrayBounds:
                    return CompareNewArray((NewArrayExpression)a, (NewArrayExpression)b);
                case ExpressionType.Invoke:
                    return CompareInvocation((InvocationExpression)a, (InvocationExpression)b);
                case ExpressionType.MemberInit:
                    return CompareMemberInit((MemberInitExpression)a, (MemberInitExpression)b);
                case ExpressionType.ListInit:
                    return CompareListInit((ListInitExpression)a, (ListInitExpression)b);
                case ExpressionType.AddAssign:
                case ExpressionType.AddAssignChecked:
                case ExpressionType.AndAssign:
                case ExpressionType.Assign:
                case ExpressionType.Block:
                case ExpressionType.DebugInfo:
                case ExpressionType.Decrement:
                case ExpressionType.Default:
                case ExpressionType.DivideAssign:
                case ExpressionType.Dynamic:
                case ExpressionType.ExclusiveOrAssign:
                case ExpressionType.Extension:
                case ExpressionType.Goto:
                case ExpressionType.Increment:
                case ExpressionType.Index:
                case ExpressionType.IsFalse:
                case ExpressionType.IsTrue:
                case ExpressionType.Label:
                case ExpressionType.LeftShiftAssign:
                case ExpressionType.Loop:
                case ExpressionType.ModuloAssign:
                case ExpressionType.MultiplyAssign:
                case ExpressionType.MultiplyAssignChecked:
                case ExpressionType.OnesComplement:
                case ExpressionType.OrAssign:
                case ExpressionType.PostDecrementAssign:
                case ExpressionType.PostIncrementAssign:
                case ExpressionType.PowerAssign:
                case ExpressionType.PreDecrementAssign:
                case ExpressionType.PreIncrementAssign:
                case ExpressionType.RightShiftAssign:
                case ExpressionType.RuntimeVariables:
                case ExpressionType.SubtractAssign:
                case ExpressionType.SubtractAssignChecked:
                case ExpressionType.Switch:
                case ExpressionType.Throw:
                case ExpressionType.Try:
                case ExpressionType.TypeEqual:
                case ExpressionType.Unbox:
                default:
                    throw new UnhandledExpressionTypeException(a.NodeType);
            }
        }

        protected virtual bool CompareUnary(UnaryExpression a, UnaryExpression b)
            => a.NodeType == b.NodeType
            && a.Method == b.Method
            && a.IsLifted == b.IsLifted
            && a.IsLiftedToNull == b.IsLiftedToNull
            && Compare(a.Operand, b.Operand);

        protected virtual bool CompareBinary(BinaryExpression a, BinaryExpression b)
            => a.NodeType == b.NodeType
            && a.Method == b.Method
            && a.IsLifted == b.IsLifted
            && a.IsLiftedToNull == b.IsLiftedToNull
            && Compare(a.Left, b.Left)
            && Compare(a.Right, b.Right);

        protected virtual bool CompareTypeIs(TypeBinaryExpression a, TypeBinaryExpression b)
            => a.TypeOperand == b.TypeOperand
            && Compare(a.Expression, b.Expression);

        protected virtual bool CompareConditional(ConditionalExpression a, ConditionalExpression b)
            => Compare(a.Test, b.Test)
            && Compare(a.IfTrue, b.IfTrue)
            && Compare(a.IfFalse, b.IfFalse);

        protected virtual bool CompareConstant(ConstantExpression a, ConstantExpression b)
            => _fnCompare?.Invoke(a.Value, b.Value) ?? Equals(a.Value, b.Value);

        protected virtual bool CompareParameter(ParameterExpression a, ParameterExpression b)
        {
            if (_parameterScope == null) return a == b;
            if (_parameterScope.TryGetValue(a, out var mapped)) return mapped == b;
            return a == b;
        }

        protected virtual bool CompareMemberAccess(MemberExpression a, MemberExpression b)
            => a.Member == b.Member
            && Compare(a.Expression, b.Expression);

        protected virtual bool CompareMethodCall(MethodCallExpression a, MethodCallExpression b)
            => a.Method == b.Method
            && Compare(a.Object, b.Object)
            && CompareExpressionList(a.Arguments, b.Arguments);

        protected virtual bool CompareLambda(LambdaExpression a, LambdaExpression b)
        {
            var n = a.Parameters.Count;
            if (b.Parameters.Count != n) return false;
            for (var i = 0; i < n; i++)
            {
                if (a.Parameters[i].Type != b.Parameters[i].Type) return false;
            }
            var save = _parameterScope;
            _parameterScope = new ScopedDictionary<ParameterExpression, ParameterExpression>(_parameterScope);
            try
            {
                for (var i = 0; i < n; i++)
                {
                    _parameterScope.Add(a.Parameters[i], b.Parameters[i]);
                }
                return Compare(a.Body, b.Body);
            }
            finally
            {
                _parameterScope = save;
            }
        }

        protected virtual bool CompareNew(NewExpression a, NewExpression b)
            => a.Constructor == b.Constructor
            && CompareExpressionList(a.Arguments, b.Arguments)
            && CompareMemberList(a.Members, b.Members);

        protected virtual bool CompareExpressionList(ReadOnlyCollection<Expression> a, ReadOnlyCollection<Expression> b)
        {
            if (a == b) return true;
            if (a == null || b == null) return false;
            if (a.Count != b.Count) return false;
            for (int i = 0, n = a.Count; i < n; i++)
            {
                if (!Compare(a[i], b[i])) return false;
            }
            return true;
        }

        protected virtual bool CompareMemberList(ReadOnlyCollection<MemberInfo> a, ReadOnlyCollection<MemberInfo> b)
        {
            if (a == b) return true;
            if (a == null || b == null) return false;
            if (a.Count != b.Count) return false;
            for (int i = 0, n = a.Count; i < n; i++)
            {
                if (a[i] != b[i]) return false;
            }
            return true;
        }

        protected virtual bool CompareNewArray(NewArrayExpression a, NewArrayExpression b)
            => CompareExpressionList(a.Expressions, b.Expressions);

        protected virtual bool CompareInvocation(InvocationExpression a, InvocationExpression b)
            => Compare(a.Expression, b.Expression)
            && CompareExpressionList(a.Arguments, b.Arguments);

        protected virtual bool CompareMemberInit(MemberInitExpression a, MemberInitExpression b)
            => Compare(a.NewExpression, b.NewExpression)
            && CompareBindingList(a.Bindings, b.Bindings);

        protected virtual bool CompareBindingList(ReadOnlyCollection<MemberBinding> a, ReadOnlyCollection<MemberBinding> b)
        {
            if (a == b) return true;
            if (a == null || b == null) return false;
            if (a.Count != b.Count) return false;
            for (int i = 0, n = a.Count; i < n; i++)
            {
                if (!CompareBinding(a[i], b[i])) return false;
            }
            return true;
        }

        protected virtual bool CompareBinding(MemberBinding a, MemberBinding b)
        {
            if (a == b) return true;
            if (a == null || b == null) return false;
            if (a.BindingType != b.BindingType) return false;
            if (a.Member != b.Member) return false;
            switch (a.BindingType)
            {
                case MemberBindingType.Assignment:
                    return CompareMemberAssignment((MemberAssignment)a, (MemberAssignment)b);
                case MemberBindingType.ListBinding:
                    return CompareMemberListBinding((MemberListBinding)a, (MemberListBinding)b);
                case MemberBindingType.MemberBinding:
                    return CompareMemberMemberBinding((MemberMemberBinding)a, (MemberMemberBinding)b);
                default:
                    throw new Exception(string.Format("Unhandled binding type: '{0}'", a.BindingType));
            }
        }

        protected virtual bool CompareMemberAssignment(MemberAssignment a, MemberAssignment b)
            => a.Member == b.Member
            && Compare(a.Expression, b.Expression);

        protected virtual bool CompareMemberListBinding(MemberListBinding a, MemberListBinding b)
            => a.Member == b.Member
            && CompareElementInitList(a.Initializers, b.Initializers);

        protected virtual bool CompareMemberMemberBinding(MemberMemberBinding a, MemberMemberBinding b)
            => a.Member == b.Member
            && CompareBindingList(a.Bindings, b.Bindings);

        protected virtual bool CompareListInit(ListInitExpression a, ListInitExpression b)
            => Compare(a.NewExpression, b.NewExpression)
            && CompareElementInitList(a.Initializers, b.Initializers);

        protected virtual bool CompareElementInitList(ReadOnlyCollection<ElementInit> a, ReadOnlyCollection<ElementInit> b)
        {
            if (a == b) return true;
            if (a == null || b == null) return false;
            if (a.Count != b.Count) return false;
            for (int i = 0, n = a.Count; i < n; i++)
            {
                if (!CompareElementInit(a[i], b[i])) return false;
            }
            return true;
        }

        protected virtual bool CompareElementInit(ElementInit a, ElementInit b)
            => a.AddMethod == b.AddMethod
            && CompareExpressionList(a.Arguments, b.Arguments);
    }
}
