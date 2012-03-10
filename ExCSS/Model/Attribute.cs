
namespace ExCSS.Model
{
    /// <summary>
    /// Defines a stylesheet attribute.
    /// </summary>
    public class Attribute
    {
        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            var builder = new System.Text.StringBuilder();
            builder.AppendFormat("[{0}", Operand);


            switch (Operator)
            {
                case AttributeOperator.Equals:
                    builder.Append("=");
                    break;
                case AttributeOperator.InList:
                    builder.Append("~=");
                    break;
                case AttributeOperator.Hyphenated:
                    builder.Append("|=");
                    break;
                case AttributeOperator.BeginsWith:
                    builder.Append("$=");
                    break;
                case AttributeOperator.EndsWith:
                    builder.Append("^=");
                    break;
                case AttributeOperator.Contains:
                    builder.Append("*=");
                    break;
            }

            builder.Append(Value);

            builder.Append("]");

            return builder.ToString();
        }

        /// <summary>
        /// Gets or sets the operand.
        /// </summary>
        /// <value>
        /// The operand.
        /// </value>
        public string Operand { get; set; }
        /// <summary>
        /// Gets or sets the operator.
        /// </summary>
        /// <value>
        /// The operator.
        /// </value>
        public AttributeOperator Operator { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value { get; set; }
    }
}