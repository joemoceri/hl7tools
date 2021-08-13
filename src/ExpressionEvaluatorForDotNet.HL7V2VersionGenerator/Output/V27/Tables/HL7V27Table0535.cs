using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0535
    {
        public string Id { get { return @"0535"; } }

        public string TableId { get { return @"0535"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Signature Code"; } }

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
                            Description = @"Signed CMS-1500 claim form on file, e.g., authorization for release of any medical or other information necessary to process this claim and assignment of benefits.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"M",
                            Description = @"Signed authorization for assignment of benefits on file.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"P",
                            Description = @"Signature generated by provider because the patient was not physically present for services.",
                            Comment = null
                        },
                        new HL7V2TableEntry
                        {
                            Value = @"S",
                            Description = @"Signed authorization for release of any medical or other information necessary to process this claim on file.",
                            Comment = null
                        },
                        
                    };
            } 
        }
    }
}
