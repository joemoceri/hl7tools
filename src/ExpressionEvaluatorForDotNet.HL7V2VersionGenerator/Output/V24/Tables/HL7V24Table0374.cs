using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24Table0374
    {
        public string Id { get { return @"0374"; } }

        public string TableId { get { return @"0374"; } }

        public string TableType { get { return @"HL7"; } }

        public string Name { get { return @"System induced contaminants"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",

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
                            Value = @"CNTM",
                            Description = @"Present, type of contamination unspecified",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
