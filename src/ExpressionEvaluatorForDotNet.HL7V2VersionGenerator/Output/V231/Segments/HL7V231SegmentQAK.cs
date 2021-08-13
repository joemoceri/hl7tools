using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentQAK
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"QAK"; } }

        public string SegmentId { get { return @"QAK"; } }
        
        public string LongName { get { return @"Query Acknowledgement"; } }
        
        public string Description { get { return @"The QAK segment contains information sent with responses to a query. Although the QAK segment is required in the responses to the enhanced queries (see section 2.19), it may appear as an optional segment placed after the (optional) ERR segment in any query response (message) to any original mode query."; } }
        
        public string Sample { get { return @""; } }

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

        public HL7V231SegmentQAK(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field _queryTag;

public HL7V231Field QueryTag
{
    get
    {
        if (_queryTag != null)
        {
            return _queryTag;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"QAK.1",
            Type = @"Field",
            Position = @"QAK.1",
            Name = @"Query Tag",
            Length = 32,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field may be valued by the initiating system to identify the query, and may be used to match response messages to the originating query. If it is valued, the responding system is required to echo it back as the first field in the query acknowledgment segment (QAK). This field differs from MSA-2-message control ID in that its value remains constant for each message (i.e., all continuation messages) associated with the query, whereas MSA-2-message control ID may vary with each continuation message, since it is associated with each individual message, not the query as a whole. QAK-1-Query tag is not conditional on the presence of the QRD-1-Query ID field in the original mode queries: in the original mode queries QAK-1-Query tag is not used.",
            Sample = @"",
            Fields = null
        }

        _queryTag = new HL7V231Field
        {
            field = message[@"QAK"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_queryTag.field.FieldRepetitions != null && _queryTag.field.FieldRepetitions.Count > 0)
        {
            _queryTag.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_queryTag, fieldData);
        }

        return _queryTag;
    } 
}

internal HL7V231Field _queryResponseStatus;

public HL7V231Field QueryResponseStatus
{
    get
    {
        if (_queryResponseStatus != null)
        {
            return _queryResponseStatus;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"QAK.2",
            Type = @"Field",
            Position = @"QAK.2",
            Name = @"Query Response Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0208",
            TableName = @"Query response status",
            Description = @"This field allows the responding system to return a precise response status. It is especially useful in the case where no data is found that matches the query parameters, but where there is also no error. It is defined with HL7 table 0208 - Query response status.",
            Sample = @"",
            Fields = null
        }

        _queryResponseStatus = new HL7V231Field
        {
            field = message[@"QAK"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_queryResponseStatus.field.FieldRepetitions != null && _queryResponseStatus.field.FieldRepetitions.Count > 0)
        {
            _queryResponseStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_queryResponseStatus, fieldData);
        }

        return _queryResponseStatus;
    } 
}
    }
}
