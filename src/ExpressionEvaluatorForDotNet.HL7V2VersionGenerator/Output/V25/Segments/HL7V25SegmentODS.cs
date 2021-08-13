using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentODS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ODS"; } }

        public string SegmentId { get { return @"ODS"; } }
        
        public string LongName { get { return @"Dietary Orders, Supplements, and Preferences"; } }
        
        public string Description { get { return @"The ORC sequence items of interest to ODS are ORC-1-order control, ORC-2-placer order number, ORC-3-filler order number, ORC-7-quantity/timing, ORC-9-date/time of transaction, ORC-10-entered by, and ORC-11-verified by. For ORC-1-order control, the values may be New (NW), Cancel (CA), Discontinue Order Request (DC), Change (XO), Hold Order Request (HD), and Release Previous Hold (RL). The HD and RL codes could stop service for a specified length of time. ORC-7-quantity/timing should be used to specify whether an order is continuous or for one service period only. It is also useful for supplements which are part of a diet but only delivered, say, every day at night."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

                    };
            }
        }

        public HL7V25SegmentODS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field _type;

public HL7V25Field Type
{
    get
    {
        if (_type != null)
        {
            return _type;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"ODS.1",
            Type = @"Field",
            Position = @"ODS.1",
            Name = @"Type",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0159",
            TableName = @"Diet Code Specification Type",
            Description = @"This field specifies type of diet. Refer To HL7 Table 0159 - Diet Code Specification Type for valid entries.",
            Sample = @"",
            Fields = null
        }

        _type = new HL7V25Field
        {
            field = message[@"ODS"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_type.field.FieldRepetitions != null && _type.field.FieldRepetitions.Count > 0)
        {
            _type.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_type, fieldData);
        }

        return _type;
    } 
}

internal HL7V25Field _servicePeriod;

public HL7V25Field ServicePeriod
{
    get
    {
        if (_servicePeriod != null)
        {
            return _servicePeriod;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"ODS.2",
            Type = @"Field",
            Position = @"ODS.2",
            Name = @"Service Period",
            Length = 250,
            Usage = @"O",
            Rpt = @"10",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"When blank, the modifier applies to all service periods. Diet orders, for example, typically apply to all service periods. This field usually specifies supplements. This field allows you to designate a modification for one or more of the service periods during a day by combining service specifications as needed. The service periods will be local CEs, normally numbers. Suggested are:",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ODS.2.1",
                            Type = @"Component",
                            Position = @"ODS.2.1",
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
                            Id = @"ODS.2.2",
                            Type = @"Component",
                            Position = @"ODS.2.2",
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
                            Id = @"ODS.2.3",
                            Type = @"Component",
                            Position = @"ODS.2.3",
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
                            Id = @"ODS.2.4",
                            Type = @"Component",
                            Position = @"ODS.2.4",
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
                            Id = @"ODS.2.5",
                            Type = @"Component",
                            Position = @"ODS.2.5",
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
                            Id = @"ODS.2.6",
                            Type = @"Component",
                            Position = @"ODS.2.6",
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

        _servicePeriod = new HL7V25Field
        {
            field = message[@"ODS"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_servicePeriod.field.FieldRepetitions != null && _servicePeriod.field.FieldRepetitions.Count > 0)
        {
            _servicePeriod.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_servicePeriod, fieldData);
        }

        return _servicePeriod;
    } 
}

internal HL7V25Field _dietSupplementorPreferenceCode;

public HL7V25Field DietSupplementorPreferenceCode
{
    get
    {
        if (_dietSupplementorPreferenceCode != null)
        {
            return _dietSupplementorPreferenceCode;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"ODS.3",
            Type = @"Field",
            Position = @"ODS.3",
            Name = @"Diet, Supplement, or Preference Code",
            Length = 250,
            Usage = @"R",
            Rpt = @"20",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the identifier of the ordered item for a patient; it is equivalent to OBR-4-universal service ID in function. Since ODS is a repeating segment, multiple entities get multiple segments. Example:",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ODS.3.1",
                            Type = @"Component",
                            Position = @"ODS.3.1",
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
                            Id = @"ODS.3.2",
                            Type = @"Component",
                            Position = @"ODS.3.2",
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
                            Id = @"ODS.3.3",
                            Type = @"Component",
                            Position = @"ODS.3.3",
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
                            Id = @"ODS.3.4",
                            Type = @"Component",
                            Position = @"ODS.3.4",
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
                            Id = @"ODS.3.5",
                            Type = @"Component",
                            Position = @"ODS.3.5",
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
                            Id = @"ODS.3.6",
                            Type = @"Component",
                            Position = @"ODS.3.6",
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

        _dietSupplementorPreferenceCode = new HL7V25Field
        {
            field = message[@"ODS"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dietSupplementorPreferenceCode.field.FieldRepetitions != null && _dietSupplementorPreferenceCode.field.FieldRepetitions.Count > 0)
        {
            _dietSupplementorPreferenceCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_dietSupplementorPreferenceCode, fieldData);
        }

        return _dietSupplementorPreferenceCode;
    } 
}

internal HL7V25Field _textInstruction;

public HL7V25Field TextInstruction
{
    get
    {
        if (_textInstruction != null)
        {
            return _textInstruction;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"ODS.4",
            Type = @"Field",
            Position = @"ODS.4",
            Name = @"Text Instruction",
            Length = 80,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field defines the specific instructions for dietary. These instructions may address specific patient needs, such as isolation. This field provides the ordering provider's dietary instructions as free text. It can represent the full dietary instruction or indicate supplemental information.",
            Sample = @"",
            Fields = null
        }

        _textInstruction = new HL7V25Field
        {
            field = message[@"ODS"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_textInstruction.field.FieldRepetitions != null && _textInstruction.field.FieldRepetitions.Count > 0)
        {
            _textInstruction.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_textInstruction, fieldData);
        }

        return _textInstruction;
    } 
}
    }
}
