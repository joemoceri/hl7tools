using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentOBX
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"OBX"; } }

        public string SegmentId { get { return @"OBX"; } }
        
        public string LongName { get { return @"Observation/result segment"; } }
        
        public string Description { get { return @"The OBX segment is used to transmit a single observation or observation fragment. It represents the smallest indivisible unit of a report. Its structure is summarized in Figure 7-5."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",
"CH_09",

                    };
            }
        }

        public HL7V231SegmentOBX(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field _setIDOBX;

public HL7V231Field SetIDOBX
{
    get
    {
        if (_setIDOBX != null)
        {
            return _setIDOBX;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OBX.1",
            Type = @"Field",
            Position = @"OBX.1",
            Name = @"Set ID - OBX",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the sequence number. For compatibility with ASTM.",
            Sample = @"",
            Fields = null
        }

        _setIDOBX = new HL7V231Field
        {
            field = message[@"OBX"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDOBX.field.FieldRepetitions != null && _setIDOBX.field.FieldRepetitions.Count > 0)
        {
            _setIDOBX.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_setIDOBX, fieldData);
        }

        return _setIDOBX;
    } 
}

internal HL7V231Field _valueType;

public HL7V231Field ValueType
{
    get
    {
        if (_valueType != null)
        {
            return _valueType;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OBX.2",
            Type = @"Field",
            Position = @"OBX.2",
            Name = @"Value Type",
            Length = 3,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0125",
            TableName = @"Value type",
            Description = @"This field contains the format of the observation value in OBX. It must be valued if OBX-11-Observ result status is not valued with an X'. If the value is CE then the result must be a coded entry. When the value type is TX or FT then the results are bulk text. The valid values for the value type of an observation are listed in HL7 table 0125 - Value type .",
            Sample = @"",
            Fields = null
        }

        _valueType = new HL7V231Field
        {
            field = message[@"OBX"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_valueType.field.FieldRepetitions != null && _valueType.field.FieldRepetitions.Count > 0)
        {
            _valueType.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_valueType, fieldData);
        }

        return _valueType;
    } 
}

internal HL7V231Field _observationIdentifier;

public HL7V231Field ObservationIdentifier
{
    get
    {
        if (_observationIdentifier != null)
        {
            return _observationIdentifier;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OBX.3",
            Type = @"Field",
            Position = @"OBX.3",
            Name = @"Observation Identifier",
            Length = 80,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains a unique identifier for the observation. The format is that of the Coded Element (CE). Example: 93000.3^P-R interval^A34.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBX.3.1",
                            Type = @"Component",
                            Position = @"OBX.3.1",
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
                            Id = @"OBX.3.2",
                            Type = @"Component",
                            Position = @"OBX.3.2",
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
                            Id = @"OBX.3.3",
                            Type = @"Component",
                            Position = @"OBX.3.3",
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
                            Id = @"OBX.3.4",
                            Type = @"Component",
                            Position = @"OBX.3.4",
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
                            Id = @"OBX.3.5",
                            Type = @"Component",
                            Position = @"OBX.3.5",
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
                            Id = @"OBX.3.6",
                            Type = @"Component",
                            Position = @"OBX.3.6",
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

        _observationIdentifier = new HL7V231Field
        {
            field = message[@"OBX"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_observationIdentifier.field.FieldRepetitions != null && _observationIdentifier.field.FieldRepetitions.Count > 0)
        {
            _observationIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_observationIdentifier, fieldData);
        }

        return _observationIdentifier;
    } 
}

internal HL7V231Field _observationSubID;

public HL7V231Field ObservationSubID
{
    get
    {
        if (_observationSubID != null)
        {
            return _observationSubID;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OBX.4",
            Type = @"Field",
            Position = @"OBX.4",
            Name = @"Observation Sub-ID",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is used to distinguish between multiple OBX segments with the same observation ID organized under one OBR. For example, a chest X-ray report might include three separate diagnostic impressions. The standard requires three OBX segments, one for each impression. By putting a 1 in the Sub-ID of the first of these OBX segments, 2 in the second, and 3 in the third, we can uniquely identify each OBX segment for editing or replacement.",
            Sample = @"",
            Fields = null
        }

        _observationSubID = new HL7V231Field
        {
            field = message[@"OBX"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_observationSubID.field.FieldRepetitions != null && _observationSubID.field.FieldRepetitions.Count > 0)
        {
            _observationSubID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_observationSubID, fieldData);
        }

        return _observationSubID;
    } 
}

internal HL7V231Field _observationValue;

public HL7V231Field ObservationValue
{
    get
    {
        if (_observationValue != null)
        {
            return _observationValue;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OBX.5",
            Type = @"Field",
            Position = @"OBX.5",
            Name = @"Observation Value",
            Length = 65536,
            Usage = @"C",
            Rpt = @"*",
            DataType = @"VARIES",
            DataTypeName = @"Variable Datatype",
            TableId = null,
            TableName = null,
            Description = @"This field contains the value observed by the observation producer. OBX-2-value type contains the data type for this field according to which observation value is formatted. It is not a required field because some systems will report only the normalcy/abnormalcy (OBX-8), especially in product experience reporting.",
            Sample = @"",
            Fields = null
        }

        _observationValue = new HL7V231Field
        {
            field = message[@"OBX"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_observationValue.field.FieldRepetitions != null && _observationValue.field.FieldRepetitions.Count > 0)
        {
            _observationValue.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_observationValue, fieldData);
        }

        return _observationValue;
    } 
}

internal HL7V231Field _units;

public HL7V231Field Units
{
    get
    {
        if (_units != null)
        {
            return _units;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OBX.6",
            Type = @"Field",
            Position = @"OBX.6",
            Name = @"Units",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the units that have a data type of CE. The default coding system for the units codes consists of the ISO+ abbreviation for a single case unit (ISO 2955-83) plus extensions, that do not collide with ISO abbreviations (see introductory section to this chapter). We designate this coding system as ISO+. Both the ISO unit's abbreviations and the extensions are defined in Section 7.3.2.6.2, 'ISO and ANSI customary units abbreviations,' and listed in Figure 7-13. The ISO+ abbreviations are the codes for the default coding system. Consequently, when ISO+ units are being used, only ISO+ abbreviations need be sent, and the contents of the units field will be backward compatible to HL7 Version. 2.1.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBX.6.1",
                            Type = @"Component",
                            Position = @"OBX.6.1",
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
                            Id = @"OBX.6.2",
                            Type = @"Component",
                            Position = @"OBX.6.2",
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
                            Id = @"OBX.6.3",
                            Type = @"Component",
                            Position = @"OBX.6.3",
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
                            Id = @"OBX.6.4",
                            Type = @"Component",
                            Position = @"OBX.6.4",
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
                            Id = @"OBX.6.5",
                            Type = @"Component",
                            Position = @"OBX.6.5",
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
                            Id = @"OBX.6.6",
                            Type = @"Component",
                            Position = @"OBX.6.6",
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

        _units = new HL7V231Field
        {
            field = message[@"OBX"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_units.field.FieldRepetitions != null && _units.field.FieldRepetitions.Count > 0)
        {
            _units.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_units, fieldData);
        }

        return _units;
    } 
}

internal HL7V231Field _referencesRange;

public HL7V231Field ReferencesRange
{
    get
    {
        if (_referencesRange != null)
        {
            return _referencesRange;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OBX.7",
            Type = @"Field",
            Position = @"OBX.7",
            Name = @"References Range",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"When the observation quantifies the amount of a toxic substance, then the upper limit of the range identifies the toxic limit. If the observation quantifies a drug, the lower limits identify the lower therapeutic bounds and the upper limits represent the upper therapeutic bounds above which toxic side effects are common.",
            Sample = @"",
            Fields = null
        }

        _referencesRange = new HL7V231Field
        {
            field = message[@"OBX"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_referencesRange.field.FieldRepetitions != null && _referencesRange.field.FieldRepetitions.Count > 0)
        {
            _referencesRange.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_referencesRange, fieldData);
        }

        return _referencesRange;
    } 
}

internal HL7V231Field _abnormalFlags;

public HL7V231Field AbnormalFlags
{
    get
    {
        if (_abnormalFlags != null)
        {
            return _abnormalFlags;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OBX.8",
            Type = @"Field",
            Position = @"OBX.8",
            Name = @"Abnormal Flags",
            Length = 5,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0078",
            TableName = @"Abnormal flags",
            Description = @"This field contains a table lookup indicating the normalcy status of the result. We strongly recommend sending this value when applicable. If the observation is an antimicrobial susceptibility, the interpretation codes are: S=susceptible; R=resistant; I=intermediate; MS=moderately susceptible; VS=very susceptible. (See ASTM 1238 - review for more details). Refer to HL7table 0078 - Abnormal flags for valid entries.",
            Sample = @"",
            Fields = null
        }

        _abnormalFlags = new HL7V231Field
        {
            field = message[@"OBX"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_abnormalFlags.field.FieldRepetitions != null && _abnormalFlags.field.FieldRepetitions.Count > 0)
        {
            _abnormalFlags.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_abnormalFlags, fieldData);
        }

        return _abnormalFlags;
    } 
}

internal HL7V231Field _probability;

public HL7V231Field Probability
{
    get
    {
        if (_probability != null)
        {
            return _probability;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OBX.9",
            Type = @"Field",
            Position = @"OBX.9",
            Name = @"Probability",
            Length = 5,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the probability of a result being true for results with categorical values. It mainly applies to discrete coded results. It is a decimal number represented as an ASCII string that must be between 0 and 1, inclusive.",
            Sample = @"",
            Fields = null
        }

        _probability = new HL7V231Field
        {
            field = message[@"OBX"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_probability.field.FieldRepetitions != null && _probability.field.FieldRepetitions.Count > 0)
        {
            _probability.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_probability, fieldData);
        }

        return _probability;
    } 
}

internal HL7V231Field _natureofAbnormalTest;

public HL7V231Field NatureofAbnormalTest
{
    get
    {
        if (_natureofAbnormalTest != null)
        {
            return _natureofAbnormalTest;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OBX.10",
            Type = @"Field",
            Position = @"OBX.10",
            Name = @"Nature of Abnormal Test",
            Length = 2,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0080",
            TableName = @"Nature of abnormal testing",
            Description = @"This field contains the nature of the abnormal test. Refer to HL7 table 0080 - Nature of abnormal testing for valid values. As many of the codes as apply may be included, separated by repeat delimiters. For example, normal values based on age, sex, and race would be codes as A~S~R.",
            Sample = @"",
            Fields = null
        }

        _natureofAbnormalTest = new HL7V231Field
        {
            field = message[@"OBX"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_natureofAbnormalTest.field.FieldRepetitions != null && _natureofAbnormalTest.field.FieldRepetitions.Count > 0)
        {
            _natureofAbnormalTest.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_natureofAbnormalTest, fieldData);
        }

        return _natureofAbnormalTest;
    } 
}

internal HL7V231Field _observationResultStatus;

public HL7V231Field ObservationResultStatus
{
    get
    {
        if (_observationResultStatus != null)
        {
            return _observationResultStatus;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OBX.11",
            Type = @"Field",
            Position = @"OBX.11",
            Name = @"Observation Result Status",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0085",
            TableName = @"Observation result status codes interpretation",
            Description = @"This field contains the observation result status. Refer to HL7 table 0085 - Observation result status codes interpretation for valid values. This field reflects the current completion status of the results for one Observation Identifier.",
            Sample = @"",
            Fields = null
        }

        _observationResultStatus = new HL7V231Field
        {
            field = message[@"OBX"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_observationResultStatus.field.FieldRepetitions != null && _observationResultStatus.field.FieldRepetitions.Count > 0)
        {
            _observationResultStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_observationResultStatus, fieldData);
        }

        return _observationResultStatus;
    } 
}

internal HL7V231Field _dateLastObsNormalValues;

public HL7V231Field DateLastObsNormalValues
{
    get
    {
        if (_dateLastObsNormalValues != null)
        {
            return _dateLastObsNormalValues;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OBX.12",
            Type = @"Field",
            Position = @"OBX.12",
            Name = @"Date Last Obs Normal Values",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the changes in the observation methods that would make values obtained from the old method not comparable with those obtained from the new method.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBX.12.1",
                            Type = @"Component",
                            Position = @"OBX.12.1",
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

        _dateLastObsNormalValues = new HL7V231Field
        {
            field = message[@"OBX"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateLastObsNormalValues.field.FieldRepetitions != null && _dateLastObsNormalValues.field.FieldRepetitions.Count > 0)
        {
            _dateLastObsNormalValues.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_dateLastObsNormalValues, fieldData);
        }

        return _dateLastObsNormalValues;
    } 
}

internal HL7V231Field _userDefinedAccessChecks;

public HL7V231Field UserDefinedAccessChecks
{
    get
    {
        if (_userDefinedAccessChecks != null)
        {
            return _userDefinedAccessChecks;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OBX.13",
            Type = @"Field",
            Position = @"OBX.13",
            Name = @"User Defined Access Checks",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field permits the producer to record results-dependent codes for classifying the observation at the receiving system. This field should be needed only rarely, because most classifications are fixed attributes of the observation ID and can be defined in the associated observation master file (see description in Chapter 8).",
            Sample = @"",
            Fields = null
        }

        _userDefinedAccessChecks = new HL7V231Field
        {
            field = message[@"OBX"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_userDefinedAccessChecks.field.FieldRepetitions != null && _userDefinedAccessChecks.field.FieldRepetitions.Count > 0)
        {
            _userDefinedAccessChecks.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_userDefinedAccessChecks, fieldData);
        }

        return _userDefinedAccessChecks;
    } 
}

internal HL7V231Field _dateTimeoftheObservation;

public HL7V231Field DateTimeoftheObservation
{
    get
    {
        if (_dateTimeoftheObservation != null)
        {
            return _dateTimeoftheObservation;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OBX.14",
            Type = @"Field",
            Position = @"OBX.14",
            Name = @"Date/Time of the Observation",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field is required in two circumstances. The first is when the observations reported beneath one report header (OBR) have different dates. This could occur in the case of queries, timed test sequences, or clearance studies where one measurement within a battery may have a different time than another measurement.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBX.14.1",
                            Type = @"Component",
                            Position = @"OBX.14.1",
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

        _dateTimeoftheObservation = new HL7V231Field
        {
            field = message[@"OBX"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateTimeoftheObservation.field.FieldRepetitions != null && _dateTimeoftheObservation.field.FieldRepetitions.Count > 0)
        {
            _dateTimeoftheObservation.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_dateTimeoftheObservation, fieldData);
        }

        return _dateTimeoftheObservation;
    } 
}

internal HL7V231Field _producersID;

public HL7V231Field ProducersID
{
    get
    {
        if (_producersID != null)
        {
            return _producersID;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OBX.15",
            Type = @"Field",
            Position = @"OBX.15",
            Name = @"Producer's ID",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains a unique identifier of the responsible producing service. It should be reported explicitly when the test results are produced at outside laboratories, for example. When this field is null, the receiving system assumes that the observations were produced by the sending organization. This information supports CLIA regulations in the US. The code for producer ID is recorded as a CE data type. In the US, the Medicare number of the producing service is suggested as the identifier.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBX.15.1",
                            Type = @"Component",
                            Position = @"OBX.15.1",
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
                            Id = @"OBX.15.2",
                            Type = @"Component",
                            Position = @"OBX.15.2",
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
                            Id = @"OBX.15.3",
                            Type = @"Component",
                            Position = @"OBX.15.3",
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
                            Id = @"OBX.15.4",
                            Type = @"Component",
                            Position = @"OBX.15.4",
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
                            Id = @"OBX.15.5",
                            Type = @"Component",
                            Position = @"OBX.15.5",
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
                            Id = @"OBX.15.6",
                            Type = @"Component",
                            Position = @"OBX.15.6",
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

        _producersID = new HL7V231Field
        {
            field = message[@"OBX"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_producersID.field.FieldRepetitions != null && _producersID.field.FieldRepetitions.Count > 0)
        {
            _producersID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_producersID, fieldData);
        }

        return _producersID;
    } 
}

internal HL7V231Field _responsibleObserver;

public HL7V231Field ResponsibleObserver
{
    get
    {
        if (_responsibleObserver != null)
        {
            return _responsibleObserver;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OBX.16",
            Type = @"Field",
            Position = @"OBX.16",
            Name = @"Responsible Observer",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name For Persons",
            TableId = null,
            TableName = null,
            Description = @"When required, this field contains the identifier of the individual directly responsible for the observation (i.e., the person who either performed or verified it). In a nursing service, the observer is usually the professional who performed the observation (e.g., took the blood pressure). In a laboratory, the observer is the technician who performed or verified the analysis. The code for the observer is recorded as a CE data type. If the code is sent as a local code, it should be unique and unambiguous when combined with OBX-15-producer ID.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBX.16.1",
                            Type = @"Component",
                            Position = @"OBX.16.1",
                            Name = @"Id Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This string refers to the coded ID according to a user-defined table, defined by the 9th component. If the first component is present, either the source table or the assigning authority must be valued.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.2",
                            Type = @"Component",
                            Position = @"OBX.16.2",
                            Name = @"Family Name & Last Name Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family + Last Name Prefix",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBX.16.2.1",
                            Type = @"SubComponent",
                            Position = @"OBX.16.2.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.2.2",
                            Type = @"SubComponent",
                            Position = @"OBX.16.2.2",
                            Name = @"Last Name Prefix",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.3",
                            Type = @"Component",
                            Position = @"OBX.16.3",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.4",
                            Type = @"Component",
                            Position = @"OBX.16.4",
                            Name = @"Middle Initial Or Name",
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
                            Id = @"OBX.16.5",
                            Type = @"Component",
                            Position = @"OBX.16.5",
                            Name = @"Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name suffix (e.g., Jr. or III).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.6",
                            Type = @"Component",
                            Position = @"OBX.16.6",
                            Name = @"Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name prefix (e.g., Dr.).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.7",
                            Type = @"Component",
                            Position = @"OBX.16.7",
                            Name = @"Degree",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree",
                            Description = @"Used to specify an educational degree (e.g., MD). Refer to user-defined table 0360 Degree for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.8",
                            Type = @"Component",
                            Position = @"OBX.16.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"User-defined table 0297 - CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.9",
                            Type = @"Component",
                            Position = @"OBX.16.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. It is a HD data type. Assigning authorities are unique across a given HL7 implementation. User-defined table 0363 Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBX.16.9.1",
                            Type = @"SubComponent",
                            Position = @"OBX.16.9.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.9.2",
                            Type = @"SubComponent",
                            Position = @"OBX.16.9.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.9.3",
                            Type = @"SubComponent",
                            Position = @"OBX.16.9.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.10",
                            Type = @"Component",
                            Position = @"OBX.16.10",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.51, XPN - extended person name).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.11",
                            Type = @"Component",
                            Position = @"OBX.16.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.12",
                            Type = @"Component",
                            Position = @"OBX.16.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0061 - Check digit scheme for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.13",
                            Type = @"Component",
                            Position = @"OBX.16.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the <assigning authority> component. Refer to user-defined table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.14",
                            Type = @"Component",
                            Position = @"OBX.16.14",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBX.16.14.1",
                            Type = @"SubComponent",
                            Position = @"OBX.16.14.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.14.2",
                            Type = @"SubComponent",
                            Position = @"OBX.16.14.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.14.3",
                            Type = @"SubComponent",
                            Position = @"OBX.16.14.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBX.16.15",
                            Type = @"Component",
                            Position = @"OBX.16.15",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _responsibleObserver = new HL7V231Field
        {
            field = message[@"OBX"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_responsibleObserver.field.FieldRepetitions != null && _responsibleObserver.field.FieldRepetitions.Count > 0)
        {
            _responsibleObserver.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_responsibleObserver, fieldData);
        }

        return _responsibleObserver;
    } 
}

internal HL7V231Field _observationMethod;

public HL7V231Field ObservationMethod
{
    get
    {
        if (_observationMethod != null)
        {
            return _observationMethod;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"OBX.17",
            Type = @"Field",
            Position = @"OBX.17",
            Name = @"Observation Method",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBX.17.1",
                            Type = @"Component",
                            Position = @"OBX.17.1",
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
                            Id = @"OBX.17.2",
                            Type = @"Component",
                            Position = @"OBX.17.2",
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
                            Id = @"OBX.17.3",
                            Type = @"Component",
                            Position = @"OBX.17.3",
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
                            Id = @"OBX.17.4",
                            Type = @"Component",
                            Position = @"OBX.17.4",
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
                            Id = @"OBX.17.5",
                            Type = @"Component",
                            Position = @"OBX.17.5",
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
                            Id = @"OBX.17.6",
                            Type = @"Component",
                            Position = @"OBX.17.6",
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

        _observationMethod = new HL7V231Field
        {
            field = message[@"OBX"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_observationMethod.field.FieldRepetitions != null && _observationMethod.field.FieldRepetitions.Count > 0)
        {
            _observationMethod.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_observationMethod, fieldData);
        }

        return _observationMethod;
    } 
}
    }
}
