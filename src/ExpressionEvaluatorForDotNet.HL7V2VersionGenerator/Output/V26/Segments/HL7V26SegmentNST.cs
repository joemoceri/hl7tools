using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentNST
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"NST"; } }

        public string SegmentId { get { return @"NST"; } }
        
        public string LongName { get { return @"Application control level statistics"; } }
        
        public string Description { get { return @"The NST segment allows application control-level statistical information to be passed between the various systems on the network. Some fields in this segment refer to portions of lower level protocols; they contain information that can be used by application management applications monitoring the state of various network links."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_14",

                    };
            }
        }

        public HL7V26SegmentNST(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _statisticsAvailable;

public HL7V26Field StatisticsAvailable
{
    get
    {
        if (_statisticsAvailable != null)
        {
            return _statisticsAvailable;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"NST.1",
            Type = @"Field",
            Position = @"NST.1",
            Name = @"Statistics Available",
            Length = 1,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates the availability of statistics. Refer to HL7 table 0136 - Yes/no indicator for valid values.

N - the responding application does not keep any statistics.  If the value ""N"" is specified, the response message is used to signify to the initiating application that the communication link between the initiating application and the responding application is operational (and fields 2 15 are empty in the response message).

Y - the responding application does keep statistics, fields 4 and 5 are required (and the response message contains one or more non null fields in the range 2 3, 6 15). ",
            Sample = @"",
            Fields = null
        }

        _statisticsAvailable = new HL7V26Field
        {
            field = message[@"NST"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_statisticsAvailable.field.FieldRepetitions != null && _statisticsAvailable.field.FieldRepetitions.Count > 0)
        {
            _statisticsAvailable.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_statisticsAvailable, fieldData);
        }

        return _statisticsAvailable;
    } 
}

internal HL7V26Field _sourceIdentifier;

public HL7V26Field SourceIdentifier
{
    get
    {
        if (_sourceIdentifier != null)
        {
            return _sourceIdentifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"NST.2",
            Type = @"Field",
            Position = @"NST.2",
            Name = @"Source Identifier",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field identifies a particular lower level link (e.g., a port number).",
            Sample = @"",
            Fields = null
        }

        _sourceIdentifier = new HL7V26Field
        {
            field = message[@"NST"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sourceIdentifier.field.FieldRepetitions != null && _sourceIdentifier.field.FieldRepetitions.Count > 0)
        {
            _sourceIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_sourceIdentifier, fieldData);
        }

        return _sourceIdentifier;
    } 
}

internal HL7V26Field _sourceType;

public HL7V26Field SourceType
{
    get
    {
        if (_sourceType != null)
        {
            return _sourceType;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"NST.3",
            Type = @"Field",
            Position = @"NST.3",
            Name = @"Source Type",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0332",
            TableName = @"Source type",
            Description = @"This field identifies (in certain systems) whether a lower level source identifier is an initiate or accept type. Refer to HL7 Table 0332 - Source type for valid values.",
            Sample = @"",
            Fields = null
        }

        _sourceType = new HL7V26Field
        {
            field = message[@"NST"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sourceType.field.FieldRepetitions != null && _sourceType.field.FieldRepetitions.Count > 0)
        {
            _sourceType.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_sourceType, fieldData);
        }

        return _sourceType;
    } 
}

internal HL7V26Field _statisticsStart;

public HL7V26Field StatisticsStart
{
    get
    {
        if (_statisticsStart != null)
        {
            return _statisticsStart;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"NST.4",
            Type = @"Field",
            Position = @"NST.4",
            Name = @"Statistics Start",
            Length = 24,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time stamp of the start of the collection of the statistics reported in fields 6-15 of this segment. It is strongly recommended that this value include seconds.",
            Sample = @"",
            Fields = null
        }

        _statisticsStart = new HL7V26Field
        {
            field = message[@"NST"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_statisticsStart.field.FieldRepetitions != null && _statisticsStart.field.FieldRepetitions.Count > 0)
        {
            _statisticsStart.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_statisticsStart, fieldData);
        }

        return _statisticsStart;
    } 
}

internal HL7V26Field _statisticsEnd;

public HL7V26Field StatisticsEnd
{
    get
    {
        if (_statisticsEnd != null)
        {
            return _statisticsEnd;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"NST.5",
            Type = @"Field",
            Position = @"NST.5",
            Name = @"Statistics End",
            Length = 24,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"DTM",
            DataTypeName = @"Date/Time",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time stamp of the end of the statistics collection period reported in fields 6-15 of this segment. It is strongly recommended that this value include seconds.",
            Sample = @"",
            Fields = null
        }

        _statisticsEnd = new HL7V26Field
        {
            field = message[@"NST"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_statisticsEnd.field.FieldRepetitions != null && _statisticsEnd.field.FieldRepetitions.Count > 0)
        {
            _statisticsEnd.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_statisticsEnd, fieldData);
        }

        return _statisticsEnd;
    } 
}

internal HL7V26Field _receiveCharacterCount;

public HL7V26Field ReceiveCharacterCount
{
    get
    {
        if (_receiveCharacterCount != null)
        {
            return _receiveCharacterCount;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"NST.6",
            Type = @"Field",
            Position = @"NST.6",
            Name = @"Receive Character Count",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of characters received.",
            Sample = @"",
            Fields = null
        }

        _receiveCharacterCount = new HL7V26Field
        {
            field = message[@"NST"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_receiveCharacterCount.field.FieldRepetitions != null && _receiveCharacterCount.field.FieldRepetitions.Count > 0)
        {
            _receiveCharacterCount.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_receiveCharacterCount, fieldData);
        }

        return _receiveCharacterCount;
    } 
}

internal HL7V26Field _sendCharacterCount;

public HL7V26Field SendCharacterCount
{
    get
    {
        if (_sendCharacterCount != null)
        {
            return _sendCharacterCount;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"NST.7",
            Type = @"Field",
            Position = @"NST.7",
            Name = @"Send Character Count",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of characters sent.",
            Sample = @"",
            Fields = null
        }

        _sendCharacterCount = new HL7V26Field
        {
            field = message[@"NST"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sendCharacterCount.field.FieldRepetitions != null && _sendCharacterCount.field.FieldRepetitions.Count > 0)
        {
            _sendCharacterCount.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_sendCharacterCount, fieldData);
        }

        return _sendCharacterCount;
    } 
}

internal HL7V26Field _messagesReceived;

public HL7V26Field MessagesReceived
{
    get
    {
        if (_messagesReceived != null)
        {
            return _messagesReceived;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"NST.8",
            Type = @"Field",
            Position = @"NST.8",
            Name = @"Messages Received",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of messages received.",
            Sample = @"",
            Fields = null
        }

        _messagesReceived = new HL7V26Field
        {
            field = message[@"NST"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messagesReceived.field.FieldRepetitions != null && _messagesReceived.field.FieldRepetitions.Count > 0)
        {
            _messagesReceived.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_messagesReceived, fieldData);
        }

        return _messagesReceived;
    } 
}

internal HL7V26Field _messagesSent;

public HL7V26Field MessagesSent
{
    get
    {
        if (_messagesSent != null)
        {
            return _messagesSent;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"NST.9",
            Type = @"Field",
            Position = @"NST.9",
            Name = @"Messages Sent",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of messages sent.",
            Sample = @"",
            Fields = null
        }

        _messagesSent = new HL7V26Field
        {
            field = message[@"NST"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_messagesSent.field.FieldRepetitions != null && _messagesSent.field.FieldRepetitions.Count > 0)
        {
            _messagesSent.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_messagesSent, fieldData);
        }

        return _messagesSent;
    } 
}

internal HL7V26Field _checksumErrorsReceived;

public HL7V26Field ChecksumErrorsReceived
{
    get
    {
        if (_checksumErrorsReceived != null)
        {
            return _checksumErrorsReceived;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"NST.10",
            Type = @"Field",
            Position = @"NST.10",
            Name = @"Checksum Errors Received",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of messages received with checksum errors.",
            Sample = @"",
            Fields = null
        }

        _checksumErrorsReceived = new HL7V26Field
        {
            field = message[@"NST"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_checksumErrorsReceived.field.FieldRepetitions != null && _checksumErrorsReceived.field.FieldRepetitions.Count > 0)
        {
            _checksumErrorsReceived.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_checksumErrorsReceived, fieldData);
        }

        return _checksumErrorsReceived;
    } 
}

internal HL7V26Field _lengthErrorsReceived;

public HL7V26Field LengthErrorsReceived
{
    get
    {
        if (_lengthErrorsReceived != null)
        {
            return _lengthErrorsReceived;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"NST.11",
            Type = @"Field",
            Position = @"NST.11",
            Name = @"Length Errors Received",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of messages received with length errors.",
            Sample = @"",
            Fields = null
        }

        _lengthErrorsReceived = new HL7V26Field
        {
            field = message[@"NST"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_lengthErrorsReceived.field.FieldRepetitions != null && _lengthErrorsReceived.field.FieldRepetitions.Count > 0)
        {
            _lengthErrorsReceived.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_lengthErrorsReceived, fieldData);
        }

        return _lengthErrorsReceived;
    } 
}

internal HL7V26Field _otherErrorsReceived;

public HL7V26Field OtherErrorsReceived
{
    get
    {
        if (_otherErrorsReceived != null)
        {
            return _otherErrorsReceived;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"NST.12",
            Type = @"Field",
            Position = @"NST.12",
            Name = @"Other Errors Received",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of ""other"" invalid messages received (excluding length and checksum errors).",
            Sample = @"",
            Fields = null
        }

        _otherErrorsReceived = new HL7V26Field
        {
            field = message[@"NST"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_otherErrorsReceived.field.FieldRepetitions != null && _otherErrorsReceived.field.FieldRepetitions.Count > 0)
        {
            _otherErrorsReceived.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_otherErrorsReceived, fieldData);
        }

        return _otherErrorsReceived;
    } 
}

internal HL7V26Field _connectTimeouts;

public HL7V26Field ConnectTimeouts
{
    get
    {
        if (_connectTimeouts != null)
        {
            return _connectTimeouts;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"NST.13",
            Type = @"Field",
            Position = @"NST.13",
            Name = @"Connect Timeouts",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of connect timeout errors.",
            Sample = @"",
            Fields = null
        }

        _connectTimeouts = new HL7V26Field
        {
            field = message[@"NST"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_connectTimeouts.field.FieldRepetitions != null && _connectTimeouts.field.FieldRepetitions.Count > 0)
        {
            _connectTimeouts.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_connectTimeouts, fieldData);
        }

        return _connectTimeouts;
    } 
}

internal HL7V26Field _receiveTimeouts;

public HL7V26Field ReceiveTimeouts
{
    get
    {
        if (_receiveTimeouts != null)
        {
            return _receiveTimeouts;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"NST.14",
            Type = @"Field",
            Position = @"NST.14",
            Name = @"Receive Timeouts",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of timeouts while waiting for a response to an initiated message.",
            Sample = @"",
            Fields = null
        }

        _receiveTimeouts = new HL7V26Field
        {
            field = message[@"NST"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_receiveTimeouts.field.FieldRepetitions != null && _receiveTimeouts.field.FieldRepetitions.Count > 0)
        {
            _receiveTimeouts.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_receiveTimeouts, fieldData);
        }

        return _receiveTimeouts;
    } 
}

internal HL7V26Field _applicationcontrollevelErrors;

public HL7V26Field ApplicationcontrollevelErrors
{
    get
    {
        if (_applicationcontrollevelErrors != null)
        {
            return _applicationcontrollevelErrors;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"NST.15",
            Type = @"Field",
            Position = @"NST.15",
            Name = @"Application control-level Errors",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of application control-level errors in response to an initiated message.",
            Sample = @"",
            Fields = null
        }

        _applicationcontrollevelErrors = new HL7V26Field
        {
            field = message[@"NST"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_applicationcontrollevelErrors.field.FieldRepetitions != null && _applicationcontrollevelErrors.field.FieldRepetitions.Count > 0)
        {
            _applicationcontrollevelErrors.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_applicationcontrollevelErrors, fieldData);
        }

        return _applicationcontrollevelErrors;
    } 
}
    }
}
