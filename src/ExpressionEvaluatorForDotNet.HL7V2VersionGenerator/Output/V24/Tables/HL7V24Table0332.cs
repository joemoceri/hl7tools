using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0332
    {
        public string Id { get { return @"0332"; } }

        public string TableId { get { return @"0332"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"Source type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_14",

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
                            Value = @"A",
                            Description = @"Accept",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"I",
                            Description = @"Initiate",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
