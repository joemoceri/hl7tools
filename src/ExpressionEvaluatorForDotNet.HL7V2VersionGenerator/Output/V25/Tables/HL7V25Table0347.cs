using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0347
    {
        public string Id { get { return @"0347"; } }

        public string TableId { get { return @"0347"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"State/province"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_15",

                    };
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
                            Value = @"AB",
                            Description = @"Alberta  (US and Canada)",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"MI",
                            Description = @"Michigan  (US)",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
