using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0625
    {
        public string Id { get { return @"0625"; } }

        public string TableId { get { return @"0625"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Item Status Codes"; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_17",

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
                            Value = @"1",
                            Description = @"Active",
                            Comment = @"Item is available to be purchased or issued."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"Pending Inactive",
                            Comment = @"Item is not available to be purchased, but is available to be issued."
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3",
                            Description = @"Inactive",
                            Comment = @"Item is not available to be purchased or issued."
                        },
                        
                    };
            } 
        }
    }
}
