using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentERQ
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ERQ"; } }

        public string SegmentId { get { return @"ERQ"; } }
        
        public string LongName { get { return @"Event Replay Query"; } }
        
        public string Description { get { return @"The ERQ segment is used to issue queries where the desired response is formatted as an event replay response message.  This enables the querying application to request detailed event data from an application that supports this feature, such that it may no longer be necessary for it to capture and store all event information at the time of the original trigger event."; } }
        
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

        public HL7V24SegmentERQ(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field _queryTag;

public HL7V24Field QueryTag
{
    get
    {
        if (_queryTag != null)
        {
            return _queryTag;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"ERQ.1",
            Type = @"Field",
            Position = @"ERQ.1",
            Name = @"Query Tag",
            Length = 32,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field may be valued by the initiating system to identify the query, and may be used to match response messages to the originating query.  If it is valued, the responding system is required to echo it back as the first field in the query acknowledgment segment (QAK).  This field differs from MSA2-Message control ID in that its value remains constant for each message (i.e., all continuation messages) associated with the query, whereas MSA-2-Message control ID may vary with each continuation message, since it is associated with each individual message, not the query as a whole.",
            Sample = @"",
            Fields = null
        }

        _queryTag = new HL7V24Field
        {
            field = message[@"ERQ"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_queryTag.field.FieldRepetitions != null && _queryTag.field.FieldRepetitions.Count > 0)
        {
            _queryTag.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_queryTag, fieldData);
        }

        return _queryTag;
    } 
}

internal HL7V24Field _eventIdentifier;

public HL7V24Field EventIdentifier
{
    get
    {
        if (_eventIdentifier != null)
        {
            return _eventIdentifier;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"ERQ.2",
            Type = @"Field",
            Position = @"ERQ.2",
            Name = @"Event Identifier",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the HL7 event identifier corresponding to the original trigger event.  Its contents dictate the format of the response message.  Hence, a value of “A04” in this field indicates a request for the data associated with the “register a patient” trigger event.  The ERP response message returns the contents of the “register a patient” message defined in Chapter 3.  If more than one match is found, the ERP returns repeating groups of the segments defined by the “A04” message",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ERQ.2.1",
                            Type = @"Component",
                            Position = @"ERQ.2.1",
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
                            Id = @"ERQ.2.2",
                            Type = @"Component",
                            Position = @"ERQ.2.2",
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
                            Id = @"ERQ.2.3",
                            Type = @"Component",
                            Position = @"ERQ.2.3",
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
                            Id = @"ERQ.2.4",
                            Type = @"Component",
                            Position = @"ERQ.2.4",
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
                            Id = @"ERQ.2.5",
                            Type = @"Component",
                            Position = @"ERQ.2.5",
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
                            Id = @"ERQ.2.6",
                            Type = @"Component",
                            Position = @"ERQ.2.6",
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

        _eventIdentifier = new HL7V24Field
        {
            field = message[@"ERQ"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eventIdentifier.field.FieldRepetitions != null && _eventIdentifier.field.FieldRepetitions.Count > 0)
        {
            _eventIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_eventIdentifier, fieldData);
        }

        return _eventIdentifier;
    } 
}

internal HL7V24Field _inputParameterList;

public HL7V24Field InputParameterList
{
    get
    {
        if (_inputParameterList != null)
        {
            return _inputParameterList;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"ERQ.3",
            Type = @"Field",
            Position = @"ERQ.3",
            Name = @"Input Parameter List",
            Length = 256,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"QIP",
            DataTypeName = @"Query Input Parameter List",
            TableId = null,
            TableName = null,
            Description = @" This field contains the list of parameter names and values to be passed to the responding system, in the form “<segment field name> ^ <value1 & value2 & value3 ...>.”  A single valued parameter contains only a single subcomponent in the second component: thus no subcomponent delimiters are needed (e.g., <segment field name> ^ <value>).  A simple list of values (i.e., a onedimensional array) may be passed instead of a single value by separating each value with the subcomponent delimiter: “<segment field name> ^ <value1&value2 &...>.”",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ERQ.3.1",
                            Type = @"Component",
                            Position = @"ERQ.3.1",
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
                            Id = @"ERQ.3.2",
                            Type = @"Component",
                            Position = @"ERQ.3.2",
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

        _inputParameterList = new HL7V24Field
        {
            field = message[@"ERQ"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_inputParameterList.field.FieldRepetitions != null && _inputParameterList.field.FieldRepetitions.Count > 0)
        {
            _inputParameterList.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_inputParameterList, fieldData);
        }

        return _inputParameterList;
    } 
}
    }
}
