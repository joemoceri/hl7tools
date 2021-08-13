using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentSPR
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"SPR"; } }

        public string SegmentId { get { return @"SPR"; } }
        
        public string LongName { get { return @"Stored procedure request definition segment"; } }
        
        public string Description { get { return @"The SPR segment is used to issue queries using stored procedure calls. Refer to the functional chapters for the lists of HL7-defined stored procedure names, input parameters and output tables."; } }
        
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

        public HL7V231SegmentSPR(HL7V2Message message)
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
            Id = @"SPR.1",
            Type = @"Field",
            Position = @"SPR.1",
            Name = @"Query Tag",
            Length = 32,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field may be valued by the initiating system to identify the query, and may be used to match response messages to the originating query. If it is valued, the responding system is required to echo it back as the first field in the query acknowledgment segment (QAK). This field differs from MSA-2-message control ID in that its value remains constant for each message (i.e., all continuation messages) associated with the query, whereas MSA-2-message control ID may vary with each continuation message, since it is associated with each individual message, not the query as a whole.",
            Sample = @"",
            Fields = null
        }

        _queryTag = new HL7V231Field
        {
            field = message[@"SPR"][1],
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

internal HL7V231Field _queryResponseFormatCode;

public HL7V231Field QueryResponseFormatCode
{
    get
    {
        if (_queryResponseFormatCode != null)
        {
            return _queryResponseFormatCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"SPR.2",
            Type = @"Field",
            Position = @"SPR.2",
            Name = @"Query/ Response Format Code",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0106",
            TableName = @"Query/response format code",
            Description = @"This field refers to HL7 table 0106 - Query/response format code for valid values.",
            Sample = @"",
            Fields = null
        }

        _queryResponseFormatCode = new HL7V231Field
        {
            field = message[@"SPR"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_queryResponseFormatCode.field.FieldRepetitions != null && _queryResponseFormatCode.field.FieldRepetitions.Count > 0)
        {
            _queryResponseFormatCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_queryResponseFormatCode, fieldData);
        }

        return _queryResponseFormatCode;
    } 
}

internal HL7V231Field _storedProcedureName;

public HL7V231Field StoredProcedureName
{
    get
    {
        if (_storedProcedureName != null)
        {
            return _storedProcedureName;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"SPR.3",
            Type = @"Field",
            Position = @"SPR.3",
            Name = @"Stored Procedure Name",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the stored procedure that is to be executed. Values for this field are defined in the function-specific chapters of this specification; site-specific stored procedure names begin with the letter 'Z.'",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPR.3.1",
                            Type = @"Component",
                            Position = @"SPR.3.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPR.3.2",
                            Type = @"Component",
                            Position = @"SPR.3.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPR.3.3",
                            Type = @"Component",
                            Position = @"SPR.3.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPR.3.4",
                            Type = @"Component",
                            Position = @"SPR.3.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPR.3.5",
                            Type = @"Component",
                            Position = @"SPR.3.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPR.3.6",
                            Type = @"Component",
                            Position = @"SPR.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _storedProcedureName = new HL7V231Field
        {
            field = message[@"SPR"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_storedProcedureName.field.FieldRepetitions != null && _storedProcedureName.field.FieldRepetitions.Count > 0)
        {
            _storedProcedureName.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_storedProcedureName, fieldData);
        }

        return _storedProcedureName;
    } 
}

internal HL7V231Field _inputParameterList;

public HL7V231Field InputParameterList
{
    get
    {
        if (_inputParameterList != null)
        {
            return _inputParameterList;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"SPR.4",
            Type = @"Field",
            Position = @"SPR.4",
            Name = @"Input Parameter List",
            Length = 256,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"QIP",
            DataTypeName = @"Query Input Parameter List",
            TableId = null,
            TableName = null,
            Description = @"This field contains the list of parameter names and values to be passed to the stored procedure, in the form '<segment field name> ^ <value1& value2 & value3 ...>.' A single valued parameter contains only a single subcomponent in the second component: thus no subcomponent delimiters are needed (e.g., <segment field name> ^ <value>). A simple list of values (i.e., a one-dimensional array) may be passed instead of a single value by separating each value with the subcomponent delimiter: ' <segment field name> ^ <value1& value2 &...> .' Refer to Section 2.24.16.4, 'EQL query statement (ST) 00710 for segment field naming conventions.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPR.4.1",
                            Type = @"Component",
                            Position = @"SPR.4.1",
                            Name = @"Segment Field Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the segment field name.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPR.4.2",
                            Type = @"Component",
                            Position = @"SPR.4.2",
                            Name = @"Value1 & Value2 & Value3",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the field value or values in the form value1& value2 & value3",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _inputParameterList = new HL7V231Field
        {
            field = message[@"SPR"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_inputParameterList.field.FieldRepetitions != null && _inputParameterList.field.FieldRepetitions.Count > 0)
        {
            _inputParameterList.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_inputParameterList, fieldData);
        }

        return _inputParameterList;
    } 
}
    }
}
