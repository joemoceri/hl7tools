using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentNDS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"NDS"; } }

        public string SegmentId { get { return @"NDS"; } }
        
        public string LongName { get { return @"Notification Detail"; } }
        
        public string Description { get { return @"The equipment notification detail segment is the data necessary to maintain an adequate audit trail as well as notifications of events, (e.g., alarms that have occurred on a particular piece of equipment."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_13",

                    };
            }
        }

        public HL7V26SegmentNDS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _notificationReferenceNumber;

public HL7V26Field NotificationReferenceNumber
{
    get
    {
        if (_notificationReferenceNumber != null)
        {
            return _notificationReferenceNumber;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"NDS.1",
            Type = @"Field",
            Position = @"NDS.1",
            Name = @"Notification Reference Number",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains a unique sequential reference number that may be used by various components to refer to this transaction. This number is generated by the originator of this notification.",
            Sample = @"",
            Fields = null
        }

        _notificationReferenceNumber = new HL7V26Field
        {
            field = message[@"NDS"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_notificationReferenceNumber.field.FieldRepetitions != null && _notificationReferenceNumber.field.FieldRepetitions.Count > 0)
        {
            _notificationReferenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_notificationReferenceNumber, fieldData);
        }

        return _notificationReferenceNumber;
    } 
}

internal HL7V26Field _notificationDateTime;

public HL7V26Field NotificationDateTime
{
    get
    {
        if (_notificationDateTime != null)
        {
            return _notificationDateTime;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"NDS.2",
            Type = @"Field",
            Position = @"NDS.2",
            Name = @"Notification Date/Time",
            Length = 24,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field is the date/time of the notifications.",
            Sample = @"",
            Fields = null
        }

        _notificationDateTime = new HL7V26Field
        {
            field = message[@"NDS"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_notificationDateTime.field.FieldRepetitions != null && _notificationDateTime.field.FieldRepetitions.Count > 0)
        {
            _notificationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_notificationDateTime, fieldData);
        }

        return _notificationDateTime;
    } 
}

internal HL7V26Field _notificationAlertSeverity;

public HL7V26Field NotificationAlertSeverity
{
    get
    {
        if (_notificationAlertSeverity != null)
        {
            return _notificationAlertSeverity;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"NDS.3",
            Type = @"Field",
            Position = @"NDS.3",
            Name = @"Notification Alert Severity",
            Length = 705,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0367",
            TableName = @"Alert level",
            Description = @"The severity of the specific notification. Refer to HL7 Table 0367 - Alert level for valid entries.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NDS.3.1",
                            Type = @"Component",
                            Position = @"NDS.3.1",
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
                            Id = @"NDS.3.2",
                            Type = @"Component",
                            Position = @"NDS.3.2",
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
                            Id = @"NDS.3.3",
                            Type = @"Component",
                            Position = @"NDS.3.3",
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
                            Id = @"NDS.3.4",
                            Type = @"Component",
                            Position = @"NDS.3.4",
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
                            Id = @"NDS.3.5",
                            Type = @"Component",
                            Position = @"NDS.3.5",
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
                            Id = @"NDS.3.6",
                            Type = @"Component",
                            Position = @"NDS.3.6",
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
                            Id = @"NDS.3.7",
                            Type = @"Component",
                            Position = @"NDS.3.7",
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
                            Id = @"NDS.3.8",
                            Type = @"Component",
                            Position = @"NDS.3.8",
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
                            Id = @"NDS.3.9",
                            Type = @"Component",
                            Position = @"NDS.3.9",
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

        _notificationAlertSeverity = new HL7V26Field
        {
            field = message[@"NDS"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_notificationAlertSeverity.field.FieldRepetitions != null && _notificationAlertSeverity.field.FieldRepetitions.Count > 0)
        {
            _notificationAlertSeverity.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_notificationAlertSeverity, fieldData);
        }

        return _notificationAlertSeverity;
    } 
}

internal HL7V26Field _notificationCode;

public HL7V26Field NotificationCode
{
    get
    {
        if (_notificationCode != null)
        {
            return _notificationCode;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"NDS.4",
            Type = @"Field",
            Position = @"NDS.4",
            Name = @"Notification Code",
            Length = 705,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field contains information about the type of notification being sent. These are manufacturer and equipment specific error or status codes, e.g., AQN0123 - aliquoting error - clot detected.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"NDS.4.1",
                            Type = @"Component",
                            Position = @"NDS.4.1",
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
                            Id = @"NDS.4.2",
                            Type = @"Component",
                            Position = @"NDS.4.2",
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
                            Id = @"NDS.4.3",
                            Type = @"Component",
                            Position = @"NDS.4.3",
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
                            Id = @"NDS.4.4",
                            Type = @"Component",
                            Position = @"NDS.4.4",
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
                            Id = @"NDS.4.5",
                            Type = @"Component",
                            Position = @"NDS.4.5",
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
                            Id = @"NDS.4.6",
                            Type = @"Component",
                            Position = @"NDS.4.6",
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
                            Id = @"NDS.4.7",
                            Type = @"Component",
                            Position = @"NDS.4.7",
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
                            Id = @"NDS.4.8",
                            Type = @"Component",
                            Position = @"NDS.4.8",
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
                            Id = @"NDS.4.9",
                            Type = @"Component",
                            Position = @"NDS.4.9",
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

        _notificationCode = new HL7V26Field
        {
            field = message[@"NDS"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_notificationCode.field.FieldRepetitions != null && _notificationCode.field.FieldRepetitions.Count > 0)
        {
            _notificationCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_notificationCode, fieldData);
        }

        return _notificationCode;
    } 
}
    }
}
