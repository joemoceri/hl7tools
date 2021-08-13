using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentACC
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ACC"; } }

        public string SegmentId { get { return @"ACC"; } }
        
        public string LongName { get { return @"Accident segment"; } }
        
        public string Description { get { return @"The ACC segment contains patient information relative to an accident in which the patient has been involved."; } }
        
        public string Sample { get { return @""; } }

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

        public HL7V231SegmentACC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field _accidentDateTime;

public HL7V231Field AccidentDateTime
{
    get
    {
        if (_accidentDateTime != null)
        {
            return _accidentDateTime;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ACC.1",
            Type = @"Field",
            Position = @"ACC.1",
            Name = @"Accident Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time of the accident.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ACC.1.1",
                            Type = @"Component",
                            Position = @"ACC.1.1",
                            Name = @"Time Of An Event",
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

        _accidentDateTime = new HL7V231Field
        {
            field = message[@"ACC"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_accidentDateTime.field.FieldRepetitions != null && _accidentDateTime.field.FieldRepetitions.Count > 0)
        {
            _accidentDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_accidentDateTime, fieldData);
        }

        return _accidentDateTime;
    } 
}

internal HL7V231Field _accidentCode;

public HL7V231Field AccidentCode
{
    get
    {
        if (_accidentCode != null)
        {
            return _accidentCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ACC.2",
            Type = @"Field",
            Position = @"ACC.2",
            Name = @"Accident Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0050",
            TableName = @"Accident code",
            Description = @"This field contains the type of accident. User-defined table 0050 - Accident code is used as the HL7 identifier for the user-defined table of values for this field. ICD accident codes are recommended.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ACC.2.1",
                            Type = @"Component",
                            Position = @"ACC.2.1",
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
                            Id = @"ACC.2.2",
                            Type = @"Component",
                            Position = @"ACC.2.2",
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
                            Id = @"ACC.2.3",
                            Type = @"Component",
                            Position = @"ACC.2.3",
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
                            Id = @"ACC.2.4",
                            Type = @"Component",
                            Position = @"ACC.2.4",
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
                            Id = @"ACC.2.5",
                            Type = @"Component",
                            Position = @"ACC.2.5",
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
                            Id = @"ACC.2.6",
                            Type = @"Component",
                            Position = @"ACC.2.6",
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

        _accidentCode = new HL7V231Field
        {
            field = message[@"ACC"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_accidentCode.field.FieldRepetitions != null && _accidentCode.field.FieldRepetitions.Count > 0)
        {
            _accidentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_accidentCode, fieldData);
        }

        return _accidentCode;
    } 
}

internal HL7V231Field _accidentLocation;

public HL7V231Field AccidentLocation
{
    get
    {
        if (_accidentLocation != null)
        {
            return _accidentLocation;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ACC.3",
            Type = @"Field",
            Position = @"ACC.3",
            Name = @"Accident Location",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the location of the accident.",
            Sample = @"",
            Fields = null
        }

        _accidentLocation = new HL7V231Field
        {
            field = message[@"ACC"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_accidentLocation.field.FieldRepetitions != null && _accidentLocation.field.FieldRepetitions.Count > 0)
        {
            _accidentLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_accidentLocation, fieldData);
        }

        return _accidentLocation;
    } 
}

internal HL7V231Field _autoAccidentState;

public HL7V231Field AutoAccidentState
{
    get
    {
        if (_autoAccidentState != null)
        {
            return _autoAccidentState;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ACC.4",
            Type = @"Field",
            Position = @"ACC.4",
            Name = @"Auto Accident State",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0347",
            TableName = @"Auto accident state",
            Description = @"This field specifies the state in which the auto accident occurred. (HCFA 1500 requirement.) Refer to user-defined table 0347 - Auto accident state for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ACC.4.1",
                            Type = @"Component",
                            Position = @"ACC.4.1",
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
                            Id = @"ACC.4.2",
                            Type = @"Component",
                            Position = @"ACC.4.2",
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
                            Id = @"ACC.4.3",
                            Type = @"Component",
                            Position = @"ACC.4.3",
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
                            Id = @"ACC.4.4",
                            Type = @"Component",
                            Position = @"ACC.4.4",
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
                            Id = @"ACC.4.5",
                            Type = @"Component",
                            Position = @"ACC.4.5",
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
                            Id = @"ACC.4.6",
                            Type = @"Component",
                            Position = @"ACC.4.6",
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

        _autoAccidentState = new HL7V231Field
        {
            field = message[@"ACC"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_autoAccidentState.field.FieldRepetitions != null && _autoAccidentState.field.FieldRepetitions.Count > 0)
        {
            _autoAccidentState.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_autoAccidentState, fieldData);
        }

        return _autoAccidentState;
    } 
}

internal HL7V231Field _accidentJobRelatedIndicator;

public HL7V231Field AccidentJobRelatedIndicator
{
    get
    {
        if (_accidentJobRelatedIndicator != null)
        {
            return _accidentJobRelatedIndicator;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ACC.5",
            Type = @"Field",
            Position = @"ACC.5",
            Name = @"Accident Job Related Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates if the accident was related to a job. Refer to HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _accidentJobRelatedIndicator = new HL7V231Field
        {
            field = message[@"ACC"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_accidentJobRelatedIndicator.field.FieldRepetitions != null && _accidentJobRelatedIndicator.field.FieldRepetitions.Count > 0)
        {
            _accidentJobRelatedIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_accidentJobRelatedIndicator, fieldData);
        }

        return _accidentJobRelatedIndicator;
    } 
}

internal HL7V231Field _accidentDeathIndicator;

public HL7V231Field AccidentDeathIndicator
{
    get
    {
        if (_accidentDeathIndicator != null)
        {
            return _accidentDeathIndicator;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"ACC.6",
            Type = @"Field",
            Position = @"ACC.6",
            Name = @"Accident Death Indicator",
            Length = 12,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether or not a patient has died as a result of an accident. Refer to HL7 table 0136 - Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _accidentDeathIndicator = new HL7V231Field
        {
            field = message[@"ACC"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_accidentDeathIndicator.field.FieldRepetitions != null && _accidentDeathIndicator.field.FieldRepetitions.Count > 0)
        {
            _accidentDeathIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_accidentDeathIndicator, fieldData);
        }

        return _accidentDeathIndicator;
    } 
}
    }
}
