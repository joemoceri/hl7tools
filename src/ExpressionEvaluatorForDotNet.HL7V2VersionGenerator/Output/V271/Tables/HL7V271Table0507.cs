using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271Table0507
    {
        public string Id { get { return @"0507"; } }

        public string TableId { get { return @"0507"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Observation Result Handling"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_02",

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
                            Description = @"Alert provider when abnormal",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"BCC",
                            Description = @"Blind Copy",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"CC",
                            Description = @"Copies Requested",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"F",
                            Description = @"Film-with-patient",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"N",
                            Description = @"Notify provider when ready",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
