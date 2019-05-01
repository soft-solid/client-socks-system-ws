using System;
using System.Linq.Expressions;

namespace TestTypeApp.Tools.ExtensionMethods
{
    static class GetNameExtentions
    {
        public static string GetPropertyName<T, TValue>(this T @object, Expression<Func<T, TValue>> propFunc)
        {
            return ((MemberExpression)propFunc.Body).Member.Name;
        }
    }
}
