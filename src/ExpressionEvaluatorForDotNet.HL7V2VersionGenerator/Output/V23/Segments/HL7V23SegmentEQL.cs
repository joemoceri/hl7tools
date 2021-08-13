using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentEQL
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"EQL"; } }

        public string SegmentId { get { return @"EQL"; } }
        
        public string LongName { get { return @"Embedded Query Language"; } }
        
        public string Description { get { return @"The EQL segment is used to define queries using select statements based on the query language of choice (e.g., SQL).  Refer to the functional chapters for the lists of HL7-defined EQL select statements"; } }
        
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

        public HL7V23SegmentEQL(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _querytag;

public HL7V23Field Querytag
{
    get
    {
        if (_querytag != null)
        {
            return _querytag;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"EQL.1",
            Type = @"Field",
            Position = @"EQL.1",
            Name = @"Query tag",
            Length = 32,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field may be valued by the initiating system to identify the query, and may be used to match response messages to the originating query.  If it is valued, the responding system is required to echo it back as the first field in the query acknowledgment segment (QAK).  This field differs from MSA-2-message control ID  in that its value remains constant for each message (i.e., all continuation messages) associated with the query, whereas MSA-2-message control ID may vary with each continuation message, since it is associated with each individual message, not the query as a whole",
            Sample = @"",
            Fields = null
        }

        _querytag = new HL7V23Field
        {
            field = message[@"EQL"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_querytag.field.FieldRepetitions != null && _querytag.field.FieldRepetitions.Count > 0)
        {
            _querytag.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_querytag, fieldData);
        }

        return _querytag;
    } 
}

internal HL7V23Field _queryResponseFormatCode;

public HL7V23Field QueryResponseFormatCode
{
    get
    {
        if (_queryResponseFormatCode != null)
        {
            return _queryResponseFormatCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"EQL.2",
            Type = @"Field",
            Position = @"EQL.2",
            Name = @"Query/ Response Format Code",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0106",
            TableName = @"Query/response format code",
            Description = @"This field refers to HL7 table 0106 - Query/response format code for valid values",
            Sample = @"",
            Fields = null
        }

        _queryResponseFormatCode = new HL7V23Field
        {
            field = message[@"EQL"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_queryResponseFormatCode.field.FieldRepetitions != null && _queryResponseFormatCode.field.FieldRepetitions.Count > 0)
        {
            _queryResponseFormatCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_queryResponseFormatCode, fieldData);
        }

        return _queryResponseFormatCode;
    } 
}

internal HL7V23Field _eQLQueryName;

public HL7V23Field EQLQueryName
{
    get
    {
        if (_eQLQueryName != null)
        {
            return _eQLQueryName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"EQL.3",
            Type = @"Field",
            Position = @"EQL.3",
            Name = @"EQL Query Name",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the query.  Where the default HL7 coding system is used, these names are assigned by the function-specific chapters of this specification.  The values for this field are equivalent to those of  SPR-3-stored procedure name (see Section 2.24.20, “SPR - stored procedure request definition segment”). ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"EQL.3.1",
                            Type = @"Component",
                            Position = @"EQL.3.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQL.3.2",
                            Type = @"Component",
                            Position = @"EQL.3.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQL.3.3",
                            Type = @"Component",
                            Position = @"EQL.3.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQL.3.4",
                            Type = @"Component",
                            Position = @"EQL.3.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQL.3.5",
                            Type = @"Component",
                            Position = @"EQL.3.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"EQL.3.6",
                            Type = @"Component",
                            Position = @"EQL.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _eQLQueryName = new HL7V23Field
        {
            field = message[@"EQL"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eQLQueryName.field.FieldRepetitions != null && _eQLQueryName.field.FieldRepetitions.Count > 0)
        {
            _eQLQueryName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eQLQueryName, fieldData);
        }

        return _eQLQueryName;
    } 
}

internal HL7V23Field _eQLQueryStatement;

public HL7V23Field EQLQueryStatement
{
    get
    {
        if (_eQLQueryStatement != null)
        {
            return _eQLQueryStatement;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"EQL.4",
            Type = @"Field",
            Position = @"EQL.4",
            Name = @"EQL Query Statement",
            Length = 4096,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the EQL select statement that is the basis of the query. 

Fields are designated by the “@” symbol concatenated with the HL7 item number for the field.  If the field is divided into components, the designation may be suffixed with “.nn,” to identify a particular component (a suffix of “.3” indicates the third component of the field); otherwise, the whole field is assumed.  If the field is further divided into subcomponents, the designation is suffixed with “.nn.mm,” which identifies the component and subcomponent requested by relative position. 

Site-specific fields may be used, provided that they begin with the letter “Z.” Note that in this case sitedefined “z”-item numbers that do not conflict with HL7 items numbers must be negotiated as part of the site specification. 

Values for this field are defined in the function-specific chapters of this specification",
            Sample = @"",
            Fields = null
        }

        _eQLQueryStatement = new HL7V23Field
        {
            field = message[@"EQL"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eQLQueryStatement.field.FieldRepetitions != null && _eQLQueryStatement.field.FieldRepetitions.Count > 0)
        {
            _eQLQueryStatement.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eQLQueryStatement, fieldData);
        }

        return _eQLQueryStatement;
    } 
}
    }
}
