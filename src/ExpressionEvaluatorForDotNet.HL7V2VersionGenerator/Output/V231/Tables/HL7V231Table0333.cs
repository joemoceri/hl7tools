using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231Table0333
    {
        public string Id { get { return @"0333"; } }

        public string TableId { get { return @"0333"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Network change type"; } }

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
                            Value = @"M",
                            Description = @"Migrates to different CPU",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SD",
                            Description = @"Shut down",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"SU",
                            Description = @"Start up",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
