using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0542
    {
        public string Id { get { return @"0542"; } }

        public string TableId { get { return @"0542"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Specimen Source Type Modifier"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

                    };
            } 
        }

        public IList<HL7V2TableEntry> Entries 
        { 
            get 
            { 
                return null;
            } 
        }
    }
}
