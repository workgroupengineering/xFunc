﻿using System;
using xFunc.Maths;
using xFunc.Maths.Expressions;
using xFunc.Presenters;

namespace xFunc.ViewModels
{

    public class MathWorkspaceItemViewModel
    {

        private int index;
        private MathWorkspaceItem item;

        public MathWorkspaceItemViewModel(int index, MathWorkspaceItem item)
        {
            this.index = index;
            this.item = item;
        }

        public int Index
        {
            get
            {
                return index;
            }
        }

        public MathWorkspaceItem Item
        {
            get
            {
                return item;
            }
        }

        public string StringExpression
        {
            get
            {
                return item.StringExpression;
            }
        }

        public IMathExpression Expression
        {
            get
            {
                return item.Expression;
            }
        }

        public string Answer
        {
            get
            {
                return item.Answer;
            }
        }

    }

}
