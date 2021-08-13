using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentMFE
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"MFE"; } }

        public string SegmentId { get { return @"MFE"; } }
        
        public string LongName { get { return @"Master File Entry"; } }
        
        public string Description { get { return @"The Technical Steward for the MFE segment is CQ."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",

                    };
            }
        }

        public HL7V251SegmentMFE(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field _recordLevelEventCode;

public HL7V251Field RecordLevelEventCode
{
    get
    {
        if (_recordLevelEventCode != null)
        {
            return _recordLevelEventCode;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"MFE.1",
            Type = @"Field",
            Position = @"MFE.1",
            Name = @"Record-Level Event Code",
            Length = 3,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0180",
            TableName = @"Record-level event code",
            Description = @"This field defines the record-level event for the master file record identified by the MFI segment and the primary key field in this segment. Refer to HL7 table 0180 - Record level event code for valid values.

Note:  If the MFI-3 - File-level event code is ""REP"" (replace file), then each MFE segment must have an MFE-1 - Record-level event code of ""MAD"" (add record to master file). ",
            Sample = @"",
            Fields = null
        }

        _recordLevelEventCode = new HL7V251Field
        {
            field = message[@"MFE"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_recordLevelEventCode.field.FieldRepetitions != null && _recordLevelEventCode.field.FieldRepetitions.Count > 0)
        {
            _recordLevelEventCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_recordLevelEventCode, fieldData);
        }

        return _recordLevelEventCode;
    } 
}

internal HL7V251Field _mFNControlID;

public HL7V251Field MFNControlID
{
    get
    {
        if (_mFNControlID != null)
        {
            return _mFNControlID;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"MFE.2",
            Type = @"Field",
            Position = @"MFE.2",
            Name = @"MFN Control ID",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"A number or other identifier that uniquely identifies this change to this record from the point of view of the originating system. When returned to the originating system via the MFA segment, this field allows the target system to precisely identify which change to this record is being acknowledged. It is only required if the MFI response level code requires responses at the record level (any value other than NE).

Note:  Note that this segment does not contain a Set ID field. The MFE-2 - MFN Control ID implements a more general concept than the Set ID. It takes the place of the SET ID in the MFE segment. ",
            Sample = @"",
            Fields = null
        }

        _mFNControlID = new HL7V251Field
        {
            field = message[@"MFE"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_mFNControlID.field.FieldRepetitions != null && _mFNControlID.field.FieldRepetitions.Count > 0)
        {
            _mFNControlID.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_mFNControlID, fieldData);
        }

        return _mFNControlID;
    } 
}

internal HL7V251Field _effectiveDateTime;

public HL7V251Field EffectiveDateTime
{
    get
    {
        if (_effectiveDateTime != null)
        {
            return _effectiveDateTime;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"MFE.3",
            Type = @"Field",
            Position = @"MFE.3",
            Name = @"Effective Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"An optional effective date/time can be included for the record-level action specified. It is the date/time the originating system expects that the event is to have been completed on the receiving system. If this field is not present, the effective date/time should default to the current date/time (when the message is received).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"MFE.3.1",
                            Type = @"Component",
                            Position = @"MFE.3.1",
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
                            Id = @"MFE.3.2",
                            Type = @"Component",
                            Position = @"MFE.3.2",
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

        _effectiveDateTime = new HL7V251Field
        {
            field = message[@"MFE"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_effectiveDateTime.field.FieldRepetitions != null && _effectiveDateTime.field.FieldRepetitions.Count > 0)
        {
            _effectiveDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_effectiveDateTime, fieldData);
        }

        return _effectiveDateTime;
    } 
}

internal HL7V251Field _primaryKeyValueMFE;

public HL7V251Field PrimaryKeyValueMFE
{
    get
    {
        if (_primaryKeyValueMFE != null)
        {
            return _primaryKeyValueMFE;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"MFE.4",
            Type = @"Field",
            Position = @"MFE.4",
            Name = @"Primary Key Value - MFE",
            Length = 200,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"VARIES",
            DataTypeName = @"Variable Datatype",
            TableId = null,
            TableName = null,
            Description = @"This field uniquely identifies the record of the master file (identified in the MFI segment) to be changed (as defined by the record-level event code). The data type of field is defined by the value of MFE-5 - Value Type, and may take on the format of any of the HL7 data types defined in HL7 table 0355 - Primary Key Value Type . The PL data type is used only on Location master transactions.

The following exception to the use of the CE data type is deprecated in v 2.3.1, and left only to satisfy backwards compatibility.  When the CE data type is used, the first component of this CE data field carries an optional subcomponent, the application ID, that uniquely identifies the application responsible for creating the primary key value.  The application ID subcomponent can be used to guarantee uniqueness of the primary key across multiple applications.  ",
            Sample = @"",
            Fields = null
        }

        _primaryKeyValueMFE = new HL7V251Field
        {
            field = message[@"MFE"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_primaryKeyValueMFE.field.FieldRepetitions != null && _primaryKeyValueMFE.field.FieldRepetitions.Count > 0)
        {
            _primaryKeyValueMFE.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_primaryKeyValueMFE, fieldData);
        }

        return _primaryKeyValueMFE;
    } 
}

internal HL7V251Field _primaryKeyValueType;

public HL7V251Field PrimaryKeyValueType
{
    get
    {
        if (_primaryKeyValueType != null)
        {
            return _primaryKeyValueType;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"MFE.5",
            Type = @"Field",
            Position = @"MFE.5",
            Name = @"Primary Key Value Type",
            Length = 3,
            Usage = @"R",
            Rpt = @"*",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0355",
            TableName = @"Primary key value type",
            Description = @"This field contains the HL7 data type of MFE-4 - Primary Key Value - MFE. The valid values for the data type of a primary key are listed in HL7 table 0355 - Primary key value type .",
            Sample = @"",
            Fields = null
        }

        _primaryKeyValueType = new HL7V251Field
        {
            field = message[@"MFE"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_primaryKeyValueType.field.FieldRepetitions != null && _primaryKeyValueType.field.FieldRepetitions.Count > 0)
        {
            _primaryKeyValueType.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_primaryKeyValueType, fieldData);
        }

        return _primaryKeyValueType;
    } 
}
    }
}
