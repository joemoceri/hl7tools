using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25Table0083
    {
        public string Id { get { return @"0083"; } }

        public string TableId { get { return @"0083"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Outlier Type"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

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
                            Value = @"C",
                            Description = @"Outlier cost",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"D",
                            Description = @"Outlier days",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
