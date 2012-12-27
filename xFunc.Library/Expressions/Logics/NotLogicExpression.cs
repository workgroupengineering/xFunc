﻿using System;

namespace xFunc.Library.Expressions.Logics
{

    public class NotLogicExpression : UnaryLogicExpression
    {

        public NotLogicExpression()
            : base(null)
        {

        }

        public NotLogicExpression(ILogicExpression firstMathExpression)
            : base(firstMathExpression)
        {

        }

        public override string ToString()
        {
            return ToString("!");
        }

        public override bool Calculate(LogicParameterCollection parameters)
        {
            return !firstMathExpression.Calculate(parameters);
        }

    }

}
