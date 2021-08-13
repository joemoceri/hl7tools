using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentCNS
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"CNS"; } }

        public string SegmentId { get { return @"CNS"; } }
        
        public string LongName { get { return @"Clear Notification"; } }
        
        public string Description { get { return @"The clear equipment notification segment contains the data necessary to allow the receiving equipment to clear any associated notifications."; } }
        
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

        public HL7V24SegmentCNS(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field _startingNotificationReferenceNumber;

public HL7V24Field StartingNotificationReferenceNumber
{
    get
    {
        if (_startingNotificationReferenceNumber != null)
        {
            return _startingNotificationReferenceNumber;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"CNS.1",
            Type = @"Field",
            Position = @"CNS.1",
            Name = @"Starting Notification Reference Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the starting notification reference number that is to be cleared",
            Sample = @"",
            Fields = null
        }

        _startingNotificationReferenceNumber = new HL7V24Field
        {
            field = message[@"CNS"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_startingNotificationReferenceNumber.field.FieldRepetitions != null && _startingNotificationReferenceNumber.field.FieldRepetitions.Count > 0)
        {
            _startingNotificationReferenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_startingNotificationReferenceNumber, fieldData);
        }

        return _startingNotificationReferenceNumber;
    } 
}

internal HL7V24Field _endingNotificationReferenceNumber;

public HL7V24Field EndingNotificationReferenceNumber
{
    get
    {
        if (_endingNotificationReferenceNumber != null)
        {
            return _endingNotificationReferenceNumber;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"CNS.2",
            Type = @"Field",
            Position = @"CNS.2",
            Name = @"Ending Notification Reference Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the ending notification reference number that is to be cleared.  If empty, then only notification with Starting Notification Reference Number will be cleared",
            Sample = @"",
            Fields = null
        }

        _endingNotificationReferenceNumber = new HL7V24Field
        {
            field = message[@"CNS"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_endingNotificationReferenceNumber.field.FieldRepetitions != null && _endingNotificationReferenceNumber.field.FieldRepetitions.Count > 0)
        {
            _endingNotificationReferenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_endingNotificationReferenceNumber, fieldData);
        }

        return _endingNotificationReferenceNumber;
    } 
}

internal HL7V24Field _startingNotificationDateTime;

public HL7V24Field StartingNotificationDateTime
{
    get
    {
        if (_startingNotificationDateTime != null)
        {
            return _startingNotificationDateTime;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"CNS.3",
            Type = @"Field",
            Position = @"CNS.3",
            Name = @"Starting Notification Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field is the starting date/time of the notifications to be cleared.  If this field is empty but Ending Notification Date/Time is filled, then all notifications before Ending Notification Date/Time will be cleared",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CNS.3.1",
                            Type = @"Component",
                            Position = @"CNS.3.1",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.3.2",
                            Type = @"Component",
                            Position = @"CNS.3.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _startingNotificationDateTime = new HL7V24Field
        {
            field = message[@"CNS"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_startingNotificationDateTime.field.FieldRepetitions != null && _startingNotificationDateTime.field.FieldRepetitions.Count > 0)
        {
            _startingNotificationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_startingNotificationDateTime, fieldData);
        }

        return _startingNotificationDateTime;
    } 
}

internal HL7V24Field _endingNotificationDateTime;

public HL7V24Field EndingNotificationDateTime
{
    get
    {
        if (_endingNotificationDateTime != null)
        {
            return _endingNotificationDateTime;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"CNS.4",
            Type = @"Field",
            Position = @"CNS.4",
            Name = @"Ending Notification Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field is the ending date/time of the notifications to be cleared.  If this field is empty but Starting Notification Date/Time is filled, then all notifications after Starting Notification Date/Time will be cleared",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CNS.4.1",
                            Type = @"Component",
                            Position = @"CNS.4.1",
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
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.4.2",
                            Type = @"Component",
                            Position = @"CNS.4.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _endingNotificationDateTime = new HL7V24Field
        {
            field = message[@"CNS"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_endingNotificationDateTime.field.FieldRepetitions != null && _endingNotificationDateTime.field.FieldRepetitions.Count > 0)
        {
            _endingNotificationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_endingNotificationDateTime, fieldData);
        }

        return _endingNotificationDateTime;
    } 
}

internal HL7V24Field _startingNotificationCode;

public HL7V24Field StartingNotificationCode
{
    get
    {
        if (_startingNotificationCode != null)
        {
            return _startingNotificationCode;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"CNS.5",
            Type = @"Field",
            Position = @"CNS.5",
            Name = @"Starting Notification Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the starting notification code that is to be cleared (see 13.4.7.4 NDS-4 Notification code (CE) 01401).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CNS.5.1",
                            Type = @"Component",
                            Position = @"CNS.5.1",
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
                            Id = @"CNS.5.2",
                            Type = @"Component",
                            Position = @"CNS.5.2",
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
                            Id = @"CNS.5.3",
                            Type = @"Component",
                            Position = @"CNS.5.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.5.4",
                            Type = @"Component",
                            Position = @"CNS.5.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.5.5",
                            Type = @"Component",
                            Position = @"CNS.5.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.5.6",
                            Type = @"Component",
                            Position = @"CNS.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _startingNotificationCode = new HL7V24Field
        {
            field = message[@"CNS"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_startingNotificationCode.field.FieldRepetitions != null && _startingNotificationCode.field.FieldRepetitions.Count > 0)
        {
            _startingNotificationCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_startingNotificationCode, fieldData);
        }

        return _startingNotificationCode;
    } 
}

internal HL7V24Field _endingNotificationCode;

public HL7V24Field EndingNotificationCode
{
    get
    {
        if (_endingNotificationCode != null)
        {
            return _endingNotificationCode;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"CNS.6",
            Type = @"Field",
            Position = @"CNS.6",
            Name = @"Ending Notification Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the ending notification code that is to be cleared (see 13.4.7.4 NDS-4 Notification code (CE) 01401).  If empty, then only notification with Starting Notification Code will be cleared",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"CNS.6.1",
                            Type = @"Component",
                            Position = @"CNS.6.1",
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
                            Id = @"CNS.6.2",
                            Type = @"Component",
                            Position = @"CNS.6.2",
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
                            Id = @"CNS.6.3",
                            Type = @"Component",
                            Position = @"CNS.6.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.6.4",
                            Type = @"Component",
                            Position = @"CNS.6.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.6.5",
                            Type = @"Component",
                            Position = @"CNS.6.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"CNS.6.6",
                            Type = @"Component",
                            Position = @"CNS.6.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the alternate text component is absent, and the alternate identifier is present, the alternate text will be taken to be the same as the text component.  If the alternate coding system component is absent, it will be taken to mean the locally-defined system.

Refer to User-defined table 0396 Coding Systems for valid values. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _endingNotificationCode = new HL7V24Field
        {
            field = message[@"CNS"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_endingNotificationCode.field.FieldRepetitions != null && _endingNotificationCode.field.FieldRepetitions.Count > 0)
        {
            _endingNotificationCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_endingNotificationCode, fieldData);
        }

        return _endingNotificationCode;
    } 
}
    }
}
