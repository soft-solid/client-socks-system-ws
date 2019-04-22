using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
