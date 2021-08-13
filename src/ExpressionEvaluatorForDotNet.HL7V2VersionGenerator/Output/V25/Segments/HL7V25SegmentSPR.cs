using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentSPR
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"SPR"; } }

        public string SegmentId { get { return @"SPR"; } }
        
        public string LongName { get { return @"Stored Procedure Request Definition"; } }
        
        public string Description { get { return @"This segment is not carried forward to the recommended queries for v 2.4.

The SPR segment is used to issue queries using stored procedure calls.  Refer to the functional chapters for the lists of HL7-defined stored procedure names, input parameters and output tables."; } }
        
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

        public HL7V25SegmentSPR(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field _queryTag;

public HL7V25Field QueryTag
{
    get
    {
        if (_queryTag != null)
        {
            return _queryTag;
        }

        var fieldData = new HL7V25FieldData
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
            Description = @"This field may be valued by the initiating system to identify the query, and may be used to match response messages to the originating query.  If it is valued, the responding system is required to echo it back as the first field in the query acknowledgment segment (QAK).  This field differs from MSA-2-Message control ID in that its value remains constant for each message (i.e., all continuation messages) associated with the query, whereas MSA-2-Message control ID may vary with each continuation message, since it is associated with each individual message, not the query as a whole.",
            Sample = @"",
            Fields = null
        }

        _queryTag = new HL7V25Field
        {
            field = message[@"SPR"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_queryTag.field.FieldRepetitions != null && _queryTag.field.FieldRepetitions.Count > 0)
        {
            _queryTag.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_queryTag, fieldData);
        }

        return _queryTag;
    } 
}

internal HL7V25Field _queryResponseFormatCode;

public HL7V25Field QueryResponseFormatCode
{
    get
    {
        if (_queryResponseFormatCode != null)
        {
            return _queryResponseFormatCode;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPR.2",
            Type = @"Field",
            Position = @"SPR.2",
            Name = @"Query/Response Format Code",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0106",
            TableName = @"Query/response format code",
            Description = @"This field refers to HL7 Table 0106 - Query/response format code for valid values.",
            Sample = @"",
            Fields = null
        }

        _queryResponseFormatCode = new HL7V25Field
        {
            field = message[@"SPR"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_queryResponseFormatCode.field.FieldRepetitions != null && _queryResponseFormatCode.field.FieldRepetitions.Count > 0)
        {
            _queryResponseFormatCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_queryResponseFormatCode, fieldData);
        }

        return _queryResponseFormatCode;
    } 
}

internal HL7V25Field _storedProcedureName;

public HL7V25Field StoredProcedureName
{
    get
    {
        if (_storedProcedureName != null)
        {
            return _storedProcedureName;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPR.3",
            Type = @"Field",
            Position = @"SPR.3",
            Name = @"Stored Procedure Name",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the stored procedure that is to be executed.  Values for this field are defined in the function-specific chapters of this specification; site-specific stored procedure names begin with the letter “Z.” ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPR.3.1",
                            Type = @"Component",
                            Position = @"SPR.3.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPR.3.2",
                            Type = @"Component",
                            Position = @"SPR.3.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPR.3.3",
                            Type = @"Component",
                            Position = @"SPR.3.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPR.3.4",
                            Type = @"Component",
                            Position = @"SPR.3.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"An alternate sequence of characters (the code) that uniquely identifies the item being referenced. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPR.3.5",
                            Type = @"Component",
                            Position = @"SPR.3.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPR.3.6",
                            Type = @"Component",
                            Position = @"SPR.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _storedProcedureName = new HL7V25Field
        {
            field = message[@"SPR"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_storedProcedureName.field.FieldRepetitions != null && _storedProcedureName.field.FieldRepetitions.Count > 0)
        {
            _storedProcedureName.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_storedProcedureName, fieldData);
        }

        return _storedProcedureName;
    } 
}

internal HL7V25Field _inputParameterList;

public HL7V25Field InputParameterList
{
    get
    {
        if (_inputParameterList != null)
        {
            return _inputParameterList;
        }

        var fieldData = new HL7V25FieldData
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
            Description = @"This field contains the list of parameter names and values to be passed to the stored procedure, in the form “<segment field name> ^ <value1& value2 & value3 ...>.”  A single valued parameter contains only a single subcomponent in the second component: thus no subcomponent delimiters are needed (e.g., <segment field name> ^ <value>).  A simple list of values (i.e., a one-dimensional array) may be passed instead of a single value by separating each value with the subcomponent delimiter: “<segment field name> ^ <value1& value2 &...>.”",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPR.4.1",
                            Type = @"Component",
                            Position = @"SPR.4.1",
                            Name = @"Segment Field Name",
                            Length = 12,
                            Usage = @"R",
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
                            Name = @"Values",
                            Length = 199,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the field value or values in the form ""value1& value2 & value3""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _inputParameterList = new HL7V25Field
        {
            field = message[@"SPR"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_inputParameterList.field.FieldRepetitions != null && _inputParameterList.field.FieldRepetitions.Count > 0)
        {
            _inputParameterList.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_inputParameterList, fieldData);
        }

        return _inputParameterList;
    } 
}
    }
}
