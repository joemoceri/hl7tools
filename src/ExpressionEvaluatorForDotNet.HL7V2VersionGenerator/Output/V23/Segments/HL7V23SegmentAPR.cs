using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentAPR
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"APR"; } }

        public string SegmentId { get { return @"APR"; } }
        
        public string LongName { get { return @"Appointment Preferences"; } }
        
        public string Description { get { return @"The APR segment contains parameters and preference specifications used for requesting appointments in the SRM message.  It allows placer applications to provide coded parameters and preference indicators to the filler application, to help determine when a requested appointment should be scheduled.  An APR segment can be provided in conjunction with either the ARQ segment or any of the service and resource segments (AIG, AIS, AIP, and AIL).  If an APR segment appears in conjunction with an ARQ segment, its parameters and preference indicators pertain to the schedule request as a whole.  If the APR segment appears with any of the service and resource segments, then its parameters and preferences apply only to the immediately preceding service or resource"; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_10",

                    };
            }
        }

        public HL7V23SegmentAPR(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _timeSelectionCriteria;

public HL7V23Field TimeSelectionCriteria
{
    get
    {
        if (_timeSelectionCriteria != null)
        {
            return _timeSelectionCriteria;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"APR.1",
            Type = @"Field",
            Position = @"APR.1",
            Name = @"Time Selection Criteria",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"SCV",
            DataTypeName = @"Scheduling Class Value Pair",
            TableId = @"0294",
            TableName = @"Time selection criteria parameter class codes",
            Description = @"This field is used to communicate parameters and preferences to the filler application regarding the selection of an appropriate time slot for an appointment.  The first component of this field is a code identifying the parameter or preference being passed to the filler application.  The second component is the actual data value for that parameter. 

For example, if a filler application allows preference parameters to be passed to specify a preferred start time, a preferred end time, and preferred days of the week for the appointment, it may define the following parameter class codes and valid data sets",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"APR.1.1",
                            Type = @"Component",
                            Position = @"APR.1.1",
                            Name = @"Parameter Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component of this field is a code identifying the parameter or preference being passed to the filler application",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.1.2",
                            Type = @"Component",
                            Position = @"APR.1.2",
                            Name = @"Parameter Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component is the actual data value for that parameter.

For example, if a filler application allows preference parameters to be passed to specify a preferred start time, a preferred end time, and preferred days of the week for the appointment, it may define the following parameter class codes and valid data sets",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _timeSelectionCriteria = new HL7V23Field
        {
            field = message[@"APR"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_timeSelectionCriteria.field.FieldRepetitions != null && _timeSelectionCriteria.field.FieldRepetitions.Count > 0)
        {
            _timeSelectionCriteria.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_timeSelectionCriteria, fieldData);
        }

        return _timeSelectionCriteria;
    } 
}

internal HL7V23Field _resourceSelectionCriteria;

public HL7V23Field ResourceSelectionCriteria
{
    get
    {
        if (_resourceSelectionCriteria != null)
        {
            return _resourceSelectionCriteria;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"APR.2",
            Type = @"Field",
            Position = @"APR.2",
            Name = @"Resource Selection Criteria",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"SCV",
            DataTypeName = @"Scheduling Class Value Pair",
            TableId = null,
            TableName = null,
            Description = @"This field is used to communicate parameters and preferences to the filler application regarding the selection of an appropriate resource for an appointment.  The first component of this field is a code identifying the parameter or preference being passed to the filler application.  The second component is the actual data value for that parameter. 

Refer to Section 10.5.8.1, “Time selection criteria  (SVC)   00908,” for an example illustrating how this mechanism works within an interface. 

The valid set of preferences should be determined by the placer and filler applications during implementation of the interface.  Refer to user-defined table 0294 - Time selection criteria parameter class codes for suggested examples. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"APR.2.1",
                            Type = @"Component",
                            Position = @"APR.2.1",
                            Name = @"Parameter Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component of this field is a code identifying the parameter or preference being passed to the filler application",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.2.2",
                            Type = @"Component",
                            Position = @"APR.2.2",
                            Name = @"Parameter Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component is the actual data value for that parameter.

For example, if a filler application allows preference parameters to be passed to specify a preferred start time, a preferred end time, and preferred days of the week for the appointment, it may define the following parameter class codes and valid data sets",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _resourceSelectionCriteria = new HL7V23Field
        {
            field = message[@"APR"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_resourceSelectionCriteria.field.FieldRepetitions != null && _resourceSelectionCriteria.field.FieldRepetitions.Count > 0)
        {
            _resourceSelectionCriteria.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_resourceSelectionCriteria, fieldData);
        }

        return _resourceSelectionCriteria;
    } 
}

internal HL7V23Field _locationSelectionCriteria;

public HL7V23Field LocationSelectionCriteria
{
    get
    {
        if (_locationSelectionCriteria != null)
        {
            return _locationSelectionCriteria;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"APR.3",
            Type = @"Field",
            Position = @"APR.3",
            Name = @"Location Selection Criteria",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"SCV",
            DataTypeName = @"Scheduling Class Value Pair",
            TableId = null,
            TableName = null,
            Description = @"This field is used to communicate parameters and preferences to the filler application regarding the selection of an appropriate location for the appointment.  The first component of this field is a code identifying the parameter or preference being passed to the filler application.  The second component is the actual data value for that parameter. 

Refer to Section 10.5.8.1, “Time selection criteria  (SVC)   00908,” for an example of how this mechanism works within an interface. 

The valid set of preferences should be determined by the placer and filler applications during implementation of the interface.  Refer to user-defined table 0294 - Time selection criteria parameter class codes for suggested examples.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"APR.3.1",
                            Type = @"Component",
                            Position = @"APR.3.1",
                            Name = @"Parameter Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component of this field is a code identifying the parameter or preference being passed to the filler application",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.3.2",
                            Type = @"Component",
                            Position = @"APR.3.2",
                            Name = @"Parameter Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component is the actual data value for that parameter.

For example, if a filler application allows preference parameters to be passed to specify a preferred start time, a preferred end time, and preferred days of the week for the appointment, it may define the following parameter class codes and valid data sets",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _locationSelectionCriteria = new HL7V23Field
        {
            field = message[@"APR"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_locationSelectionCriteria.field.FieldRepetitions != null && _locationSelectionCriteria.field.FieldRepetitions.Count > 0)
        {
            _locationSelectionCriteria.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_locationSelectionCriteria, fieldData);
        }

        return _locationSelectionCriteria;
    } 
}

internal HL7V23Field _slotSpacingCriteria;

public HL7V23Field SlotSpacingCriteria
{
    get
    {
        if (_slotSpacingCriteria != null)
        {
            return _slotSpacingCriteria;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"APR.4",
            Type = @"Field",
            Position = @"APR.4",
            Name = @"Slot Spacing Criteria",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is used in queries returning lists of possible appointment slots, or other lists of slots.  If the filler application allows it, the querying application may indicate the spacing of the slots returned to the querying application, in relation to the requested start date/time in the ARQ segment.  The value in this field should be a positive integer, representing the number of minutes between slot starting times that is returned in the query. ",
            Sample = @"",
            Fields = null
        }

        _slotSpacingCriteria = new HL7V23Field
        {
            field = message[@"APR"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_slotSpacingCriteria.field.FieldRepetitions != null && _slotSpacingCriteria.field.FieldRepetitions.Count > 0)
        {
            _slotSpacingCriteria.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_slotSpacingCriteria, fieldData);
        }

        return _slotSpacingCriteria;
    } 
}

internal HL7V23Field _fillerOverrideCriteria;

public HL7V23Field FillerOverrideCriteria
{
    get
    {
        if (_fillerOverrideCriteria != null)
        {
            return _fillerOverrideCriteria;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"APR.5",
            Type = @"Field",
            Position = @"APR.5",
            Name = @"Filler Override Criteria",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"SCV",
            DataTypeName = @"Scheduling Class Value Pair",
            TableId = null,
            TableName = null,
            Description = @"This field is used to communicate override parameters to the filler application.  These override parameters allow placer applications to override specific features of filler applications such as conflict checking.  It is assumed that the placer and filler applications will pass enough information to determine whether the requestor is allowed to override such features.  This chapter does not provide any security or permission information.   

The first component of this field is a code identifying the parameter being passed to the filler application.  The second component is the actual data value for that parameter. 
Refer to Section 10.5.8.1, “Time selection criteria  (SVC)   00908,” for an example illustrating how this mechanism works within an interface. 

The valid set of parameters should be determined by the placer and filler applications during implementation of the interface",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"APR.5.1",
                            Type = @"Component",
                            Position = @"APR.5.1",
                            Name = @"Parameter Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component of this field is a code identifying the parameter or preference being passed to the filler application",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"APR.5.2",
                            Type = @"Component",
                            Position = @"APR.5.2",
                            Name = @"Parameter Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component is the actual data value for that parameter.

For example, if a filler application allows preference parameters to be passed to specify a preferred start time, a preferred end time, and preferred days of the week for the appointment, it may define the following parameter class codes and valid data sets",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _fillerOverrideCriteria = new HL7V23Field
        {
            field = message[@"APR"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fillerOverrideCriteria.field.FieldRepetitions != null && _fillerOverrideCriteria.field.FieldRepetitions.Count > 0)
        {
            _fillerOverrideCriteria.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_fillerOverrideCriteria, fieldData);
        }

        return _fillerOverrideCriteria;
    } 
}
    }
}
