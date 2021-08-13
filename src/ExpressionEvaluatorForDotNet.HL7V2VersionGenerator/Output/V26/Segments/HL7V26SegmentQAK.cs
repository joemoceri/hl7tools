using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentQAK
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"QAK"; } }

        public string SegmentId { get { return @"QAK"; } }
        
        public string LongName { get { return @"Query Acknowledgment"; } }
        
        public string Description { get { return @"The QAK segment contains information sent with responses to a query. Although the QAK segment is required in the responses to the enhanced queries (see section Error! Reference source not found. , ""Error! Reference source not found.""), it may appear as an optional segment placed after the (optional) ERR segment in any query response (message) to any original mode query."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_05",

                    };
            }
        }

        public HL7V26SegmentQAK(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _queryTag;

public HL7V26Field QueryTag
{
    get
    {
        if (_queryTag != null)
        {
            return _queryTag;
        }

        var fieldData = new HL7V26FieldData
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
            Description = @"This field may be valued by the initiating system to identify the query, and may be used to match response messages to the originating query. If it is valued, the responding system is required to echo it back as the first field in the query acknowledgment segment (QAK). This field differs from MSA-2-message control ID in that its value remains constant for each message (i.e., all continuation messages) associated with the query, whereas MSA-2-Message control ID may vary with each continuation message, since it is associated with each individual message, not the query as a whole. QAK-1-Query tag is not conditional on the presence of the QRD-1-Query ID field in the original mode queries; in the original mode queries QAK-1-Query tag is not used.",
            Sample = @"",
            Fields = null
        }

        _queryTag = new HL7V26Field
        {
            field = message[@"QAK"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_queryTag.field.FieldRepetitions != null && _queryTag.field.FieldRepetitions.Count > 0)
        {
            _queryTag.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_queryTag, fieldData);
        }

        return _queryTag;
    } 
}

internal HL7V26Field _queryResponseStatus;

public HL7V26Field QueryResponseStatus
{
    get
    {
        if (_queryResponseStatus != null)
        {
            return _queryResponseStatus;
        }

        var fieldData = new HL7V26FieldData
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
            TableName = @"Query Response Status",
            Description = @"This field allows the responding system to return a precise response status. It is especially useful in the case where no data is found that matches the query parameters, but where there is also no error. It is defined with HL7 Table 0208 - Query Response Status .",
            Sample = @"",
            Fields = null
        }

        _queryResponseStatus = new HL7V26Field
        {
            field = message[@"QAK"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_queryResponseStatus.field.FieldRepetitions != null && _queryResponseStatus.field.FieldRepetitions.Count > 0)
        {
            _queryResponseStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_queryResponseStatus, fieldData);
        }

        return _queryResponseStatus;
    } 
}

internal HL7V26Field _messageQueryName;

public HL7V26Field MessageQueryName
{
    get
    {
        if (_messageQueryName != null)
        {
            return _messageQueryName;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"QAK.3",
            Type = @"Field",
            Position = @"QAK.3",
            Name = @"Message Query Name",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0471",
            TableName = @"Query name",
            Description = @"This field contains the name of the query. These names are assigned by the function-specific chapters of this specification. Site-specific event replay query names begin with the letter ""Z."" Refer to User defined table 0471 - Query name for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"QAK.3.1",
                            Type = @"Component",
                            Position = @"QAK.3.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CWE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QAK.3.2",
                            Type = @"Component",
                            Position = @"QAK.3.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QAK.3.3",
                            Type = @"Component",
                            Position = @"QAK.3.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QAK.3.4",
                            Type = @"Component",
                            Position = @"QAK.3.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. Analogous to ""Identifier"" in component 1. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QAK.3.5",
                            Type = @"Component",
                            Position = @"QAK.3.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QAK.3.6",
                            Type = @"Component",
                            Position = @"QAK.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System above. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QAK.3.7",
                            Type = @"Component",
                            Position = @"QAK.3.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID. If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QAK.3.8",
                            Type = @"Component",
                            Position = @"QAK.3.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"QAK.3.9",
                            Type = @"Component",
                            Position = @"QAK.3.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _messageQueryName = new HL7V26Field
        {
            field = message[@"QAK"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messageQueryName.field.FieldRepetitions != null && _messageQueryName.field.FieldRepetitions.Count > 0)
        {
            _messageQueryName.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_messageQueryName, fieldData);
        }

        return _messageQueryName;
    } 
}

internal HL7V26Field _hitCount;

public HL7V26Field HitCount
{
    get
    {
        if (_hitCount != null)
        {
            return _hitCount;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"QAK.4",
            Type = @"Field",
            Position = @"QAK.4",
            Name = @"Hit Count",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field, when used, contains the total number of records found by the Server that matched the query. For tabular responses, this is the number of rows found. For other response types, the Query Profile defines the meaning of a ""hit.""",
            Sample = @"",
            Fields = null
        }

        _hitCount = new HL7V26Field
        {
            field = message[@"QAK"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_hitCount.field.FieldRepetitions != null && _hitCount.field.FieldRepetitions.Count > 0)
        {
            _hitCount.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_hitCount, fieldData);
        }

        return _hitCount;
    } 
}

internal HL7V26Field _thispayload;

public HL7V26Field Thispayload
{
    get
    {
        if (_thispayload != null)
        {
            return _thispayload;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"QAK.5",
            Type = @"Field",
            Position = @"QAK.5",
            Name = @"This payload",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field, when used, contains the total number of matching records that the Server sent in the current response. Where the continuation protocol is used to transmit the response in partial installments, this number will differ from the value sent in QAK-4-Hit count total.",
            Sample = @"",
            Fields = null
        }

        _thispayload = new HL7V26Field
        {
            field = message[@"QAK"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_thispayload.field.FieldRepetitions != null && _thispayload.field.FieldRepetitions.Count > 0)
        {
            _thispayload.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_thispayload, fieldData);
        }

        return _thispayload;
    } 
}

internal HL7V26Field _hitsremaining;

public HL7V26Field Hitsremaining
{
    get
    {
        if (_hitsremaining != null)
        {
            return _hitsremaining;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"QAK.6",
            Type = @"Field",
            Position = @"QAK.6",
            Name = @"Hits remaining",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field, when used, contains the number of matching records found by the Server that have yet to be sent. It is only meaningful when the Server uses the continuation protocol to transmit partial responses.",
            Sample = @"",
            Fields = null
        }

        _hitsremaining = new HL7V26Field
        {
            field = message[@"QAK"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_hitsremaining.field.FieldRepetitions != null && _hitsremaining.field.FieldRepetitions.Count > 0)
        {
            _hitsremaining.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_hitsremaining, fieldData);
        }

        return _hitsremaining;
    } 
}
    }
}
