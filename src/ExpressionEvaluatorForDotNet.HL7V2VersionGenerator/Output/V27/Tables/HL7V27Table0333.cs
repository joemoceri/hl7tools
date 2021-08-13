using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V27Table0333
    {
        public string Id { get { return @"0333"; } }

        public string TableId { get { return @"0333"; } }

        public string TableType { get { return @"User"; } }

        public string Name { get { return @"Driver's License Issuing Authority"; } }

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
                return null;
            } 
        }
    }
}
