using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentRMI
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RMI"; } }

        public string SegmentId { get { return @"RMI"; } }
        
        public string LongName { get { return @"Risk Management Incident"; } }
        
        public string Description { get { return @"The RMI segment is used to report an occurrence of an incident event pertaining or attaching to a patient encounter."; } }
        
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

        public HL7V251SegmentRMI(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field _riskManagementIncidentCode;

public HL7V251Field RiskManagementIncidentCode
{
    get
    {
        if (_riskManagementIncidentCode != null)
        {
            return _riskManagementIncidentCode;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"RMI.1",
            Type = @"Field",
            Position = @"RMI.1",
            Name = @"Risk Management Incident Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0427",
            TableName = @"Risk Management Incident Code",
            Description = @"A code depicting the incident that occurred during a patients stay. Refer to User-defined Table 0427 - Risk Management Incident Code for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RMI.1.1",
                            Type = @"Component",
                            Position = @"RMI.1.1",
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
                            Id = @"RMI.1.2",
                            Type = @"Component",
                            Position = @"RMI.1.2",
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
                            Id = @"RMI.1.3",
                            Type = @"Component",
                            Position = @"RMI.1.3",
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
                            Id = @"RMI.1.4",
                            Type = @"Component",
                            Position = @"RMI.1.4",
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
                            Id = @"RMI.1.5",
                            Type = @"Component",
                            Position = @"RMI.1.5",
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
                            Id = @"RMI.1.6",
                            Type = @"Component",
                            Position = @"RMI.1.6",
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

        _riskManagementIncidentCode = new HL7V251Field
        {
            field = message[@"RMI"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_riskManagementIncidentCode.field.FieldRepetitions != null && _riskManagementIncidentCode.field.FieldRepetitions.Count > 0)
        {
            _riskManagementIncidentCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_riskManagementIncidentCode, fieldData);
        }

        return _riskManagementIncidentCode;
    } 
}

internal HL7V251Field _dateTimeIncident;

public HL7V251Field DateTimeIncident
{
    get
    {
        if (_dateTimeIncident != null)
        {
            return _dateTimeIncident;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"RMI.2",
            Type = @"Field",
            Position = @"RMI.2",
            Name = @"Date/Time Incident",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date and time the Risk Management Incident identified in RMI-1 - Risk Management Incident Code occurred.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RMI.2.1",
                            Type = @"Component",
                            Position = @"RMI.2.1",
                            Name = @"Time",
                            Length = 24,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/Time",
                            TableId = null,
                            TableName = null,
                            Description = @"The point in time.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RMI.2.2",
                            Type = @"Component",
                            Position = @"RMI.2.2",
                            Name = @"Degree Of Precision",
                            Length = 1,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0529",
                            TableName = @"Precision",
                            Description = @"Retained only for purposes of backward compatibility as of v 2.3. Refer to component 1 for current method of designating degree of precision. 

Indicates the degree of precision of the time stamp (Y = year, L = month, D = day, H = hour, M = minute, S = second). Refer to HL7 Table 0529 - Precision for valid value.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _dateTimeIncident = new HL7V251Field
        {
            field = message[@"RMI"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dateTimeIncident.field.FieldRepetitions != null && _dateTimeIncident.field.FieldRepetitions.Count > 0)
        {
            _dateTimeIncident.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_dateTimeIncident, fieldData);
        }

        return _dateTimeIncident;
    } 
}

internal HL7V251Field _incidentTypeCode;

public HL7V251Field IncidentTypeCode
{
    get
    {
        if (_incidentTypeCode != null)
        {
            return _incidentTypeCode;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"RMI.3",
            Type = @"Field",
            Position = @"RMI.3",
            Name = @"Incident Type Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0428",
            TableName = @"Incident Type Code",
            Description = @"A code depicting a classification of the incident type. Refer to User-defined Table 0428 - Incident Type Code for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RMI.3.1",
                            Type = @"Component",
                            Position = @"RMI.3.1",
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
                            Id = @"RMI.3.2",
                            Type = @"Component",
                            Position = @"RMI.3.2",
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
                            Id = @"RMI.3.3",
                            Type = @"Component",
                            Position = @"RMI.3.3",
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
                            Id = @"RMI.3.4",
                            Type = @"Component",
                            Position = @"RMI.3.4",
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
                            Id = @"RMI.3.5",
                            Type = @"Component",
                            Position = @"RMI.3.5",
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
                            Id = @"RMI.3.6",
                            Type = @"Component",
                            Position = @"RMI.3.6",
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

        _incidentTypeCode = new HL7V251Field
        {
            field = message[@"RMI"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_incidentTypeCode.field.FieldRepetitions != null && _incidentTypeCode.field.FieldRepetitions.Count > 0)
        {
            _incidentTypeCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_incidentTypeCode, fieldData);
        }

        return _incidentTypeCode;
    } 
}
    }
}
