using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V21Table0106
    {
        public string Id { get { return @"0106"; } }

        public string TableId { get { return @"0106"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"QUERY FORMAT CODE"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return null;
            } 
        }

        public IList<HL7V2TableEntry> Entries 
        { 
            get 
            { 
                return new[]
                    {
                        new HL7V2TableEntry
                        {
                            Value = @"R",
                            Description = @"Response in Record-oriented format",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
