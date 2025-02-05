﻿using backend_api.Core.Exceptions;
using System;
using System.Linq.Expressions;
using System.Reflection;


namespace backend_api.Core.Utils;

public static class ExpressionUtil<TDomain>
{
    public static object GetPropertyValue<TField>(Expression<Func<TDomain, TField>> expression, TDomain data)
    {
        if (data == null)
            throw new NullInputEntityException<TDomain>();

        var prop = GetPropertyInfo(expression);
        var value = prop.GetValue(data);
        return value;
    }

    public static void SetPropertyValue<TField>(Expression<Func<TDomain, TField>> expression, TDomain data,
        object value)
    {
        if (data == null)
            throw new NullInputEntityException<TDomain>();

        var prop = GetPropertyInfo(expression);
        prop.SetValue(data, value);
    }

    public static PropertyInfo GetPropertyInfo<TField>(Expression<Func<TDomain, TField>> expression)
    {
        var expr = (MemberExpression)expression.Body;
        return (PropertyInfo)expr.Member;
    }
}