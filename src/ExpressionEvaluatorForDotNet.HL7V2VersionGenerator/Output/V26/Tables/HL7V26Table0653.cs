using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26Table0653
    {
        public string Id { get { return @"0653"; } }

        public string TableId { get { return @"0653"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Date Format"; } }

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
                            Description = @"mm/dd/yy",
                            Comment = @"USA standard"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"2",
                            Description = @"yy.mm.dd",
                            Comment = @"ANSI standard"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"3",
                            Description = @"dd/mm/yy",
                            Comment = @"Britain/France standard"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"4",
                            Description = @"dd.mm.yy",
                            Comment = @"Germany standard"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"5",
                            Description = @"yy/mm/dd",
                            Comment = @"Japan standard"
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"6",
                            Description = @"Yymmdd",
                            Comment = @"ISO standard"
                        },
                        
                    };
            } 
        }
    }
}
