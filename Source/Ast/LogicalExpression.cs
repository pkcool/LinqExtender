﻿
namespace LinqExtender.Ast
{
    public class LogicalExpression : Expression
    {
        private LogicalOperator @operator;
        private bool isChild;
        private Expression left;
        private Expression right;

        public LogicalExpression(LogicalOperator @operator)
        {
            this.@operator = @operator;
        }

        /// <summary>
        /// Gets the left expression.
        /// </summary>
        public Expression Left
        {
            get
            {
                return left;
            }
            internal set
            {
                left = value;
            }
        }

        /// <summary>
        /// Gets the right exprssison.
        /// </summary>
        public Expression Right
        {
            get
            {
                return right;
            }
            internal set
            {
                right = value;
            }
        }

        /// <summary>
        /// Gets value that indicates that the current is a child expression.
        /// </summary>
        public bool IsChild
        {
            get
            {
                return isChild;
            }
            internal set
            {
                isChild = value;
            }
        }

        /// <summary>
        /// Gets the operator joining the left and right expression.
        /// </summary>
        public LogicalOperator Operator
        {
            get
            {
                return @operator;
            }
        }

        public override CodeType CodeType
        {
            get { return CodeType.LogicalExpression; }
        }
    }
}