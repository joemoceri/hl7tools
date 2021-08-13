using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271FieldRepetition
    {
        public HL7V2FieldRepetition fieldRepetition { get; init; }

        public IList<HL7V271Component> components { get; internal set; }

        public HL7V271FieldData fieldData { get; init; }

        public string Value { get { return fieldRepetition?.Value; } }
    }
}
