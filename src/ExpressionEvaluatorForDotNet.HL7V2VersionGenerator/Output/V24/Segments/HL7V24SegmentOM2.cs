using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentOM2
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"OM2"; } }

        public string SegmentId { get { return @"OM2"; } }
        
        public string LongName { get { return @"Numeric Observation"; } }
        
        public string Description { get { return @"This segment contains the attributes of observations with continuous values (including those with data types of numeric, date, or time stamp).  It can be applied to observation batteries of type A and C (see OM1-18 - Nature of service/test/observation).

The Technical Steward for the OM2 segment is ORDERS."; } }
        
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

        public HL7V24SegmentOM2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field _sequenceNumberTestObservationMasterFile;

public HL7V24Field SequenceNumberTestObservationMasterFile
{
    get
    {
        if (_sequenceNumberTestObservationMasterFile != null)
        {
            return _sequenceNumberTestObservationMasterFile;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"OM2.1",
            Type = @"Field",
            Position = @"OM2.1",
            Name = @"Sequence Number - Test/ Observation Master File",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the same value as the sequence number of the associated OM1 segment.",
            Sample = @"",
            Fields = null
        }

        _sequenceNumberTestObservationMasterFile = new HL7V24Field
        {
            field = message[@"OM2"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sequenceNumberTestObservationMasterFile.field.FieldRepetitions != null && _sequenceNumberTestObservationMasterFile.field.FieldRepetitions.Count > 0)
        {
            _sequenceNumberTestObservationMasterFile.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_sequenceNumberTestObservationMasterFile, fieldData);
        }

        return _sequenceNumberTestObservationMasterFile;
    } 
}

internal HL7V24Field _unitsofMeasure;

public HL7V24Field UnitsofMeasure
{
    get
    {
        if (_unitsofMeasure != null)
        {
            return _unitsofMeasure;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"OM2.2",
            Type = @"Field",
            Position = @"OM2.2",
            Name = @"Units of Measure",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the single tests/observations (those with a nature code of A or C, as described in OM1-18 - Nature of service/test/observation ) that have numeric values. This field contains their customary units of measure.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM2.2.1",
                            Type = @"Component",
                            Position = @"OM2.2.1",
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
                            Id = @"OM2.2.2",
                            Type = @"Component",
                            Position = @"OM2.2.2",
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
                            Id = @"OM2.2.3",
                            Type = @"Component",
                            Position = @"OM2.2.3",
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
                            Id = @"OM2.2.4",
                            Type = @"Component",
                            Position = @"OM2.2.4",
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
                            Id = @"OM2.2.5",
                            Type = @"Component",
                            Position = @"OM2.2.5",
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
                            Id = @"OM2.2.6",
                            Type = @"Component",
                            Position = @"OM2.2.6",
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

        _unitsofMeasure = new HL7V24Field
        {
            field = message[@"OM2"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_unitsofMeasure.field.FieldRepetitions != null && _unitsofMeasure.field.FieldRepetitions.Count > 0)
        {
            _unitsofMeasure.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_unitsofMeasure, fieldData);
        }

        return _unitsofMeasure;
    } 
}

internal HL7V24Field _rangeofDecimalPrecision;

public HL7V24Field RangeofDecimalPrecision
{
    get
    {
        if (_rangeofDecimalPrecision != null)
        {
            return _rangeofDecimalPrecision;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"OM2.3",
            Type = @"Field",
            Position = @"OM2.3",
            Name = @"Range of Decimal Precision",
            Length = 10,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the numerically valued single observations (code A or C as described in OM1-18 - Nature of service/test/observation ), specifies the total length in characters of the field needed to display the observation, and the number of digits displayed to the right of the decimal point. This is coded as a single number in the format <length>.<decimal-digits>. For example, a value of 6.2 implies 6 characters total (including the sign and decimal point) with 2 digits after the decimal point. For integer values, the period and <decimal-digits> portion may be omitted (that is, 5.0 and 5 are equivalent). More than one such mask may be transmitted (separated by repeat delimiters) when it is necessary to define multiple display formats that are possible.",
            Sample = @"",
            Fields = null
        }

        _rangeofDecimalPrecision = new HL7V24Field
        {
            field = message[@"OM2"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rangeofDecimalPrecision.field.FieldRepetitions != null && _rangeofDecimalPrecision.field.FieldRepetitions.Count > 0)
        {
            _rangeofDecimalPrecision.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_rangeofDecimalPrecision, fieldData);
        }

        return _rangeofDecimalPrecision;
    } 
}

internal HL7V24Field _correspondingSIUnitsofMeasure;

public HL7V24Field CorrespondingSIUnitsofMeasure
{
    get
    {
        if (_correspondingSIUnitsofMeasure != null)
        {
            return _correspondingSIUnitsofMeasure;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"OM2.4",
            Type = @"Field",
            Position = @"OM2.4",
            Name = @"Corresponding SI Units of Measure",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the single tests/observations - the corresponding SI units of measure in the format, when these differ from the customary units of measure given in the previous field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM2.4.1",
                            Type = @"Component",
                            Position = @"OM2.4.1",
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
                            Id = @"OM2.4.2",
                            Type = @"Component",
                            Position = @"OM2.4.2",
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
                            Id = @"OM2.4.3",
                            Type = @"Component",
                            Position = @"OM2.4.3",
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
                            Id = @"OM2.4.4",
                            Type = @"Component",
                            Position = @"OM2.4.4",
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
                            Id = @"OM2.4.5",
                            Type = @"Component",
                            Position = @"OM2.4.5",
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
                            Id = @"OM2.4.6",
                            Type = @"Component",
                            Position = @"OM2.4.6",
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

        _correspondingSIUnitsofMeasure = new HL7V24Field
        {
            field = message[@"OM2"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_correspondingSIUnitsofMeasure.field.FieldRepetitions != null && _correspondingSIUnitsofMeasure.field.FieldRepetitions.Count > 0)
        {
            _correspondingSIUnitsofMeasure.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_correspondingSIUnitsofMeasure, fieldData);
        }

        return _correspondingSIUnitsofMeasure;
    } 
}

internal HL7V24Field _sIConversionFactor;

public HL7V24Field SIConversionFactor
{
    get
    {
        if (_sIConversionFactor != null)
        {
            return _sIConversionFactor;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"OM2.5",
            Type = @"Field",
            Position = @"OM2.5",
            Name = @"SI Conversion Factor",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the continuous, numerically valued tests/observations, with a nature code of A or C (see OM1-18 - Nature of service/test/observation). This is a factor for converting the customary units to SI units.",
            Sample = @"",
            Fields = null
        }

        _sIConversionFactor = new HL7V24Field
        {
            field = message[@"OM2"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sIConversionFactor.field.FieldRepetitions != null && _sIConversionFactor.field.FieldRepetitions.Count > 0)
        {
            _sIConversionFactor.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_sIConversionFactor, fieldData);
        }

        return _sIConversionFactor;
    } 
}

internal HL7V24Field _reference;

public HL7V24Field Reference
{
    get
    {
        if (_reference != null)
        {
            return _reference;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"OM2.6",
            Type = @"Field",
            Position = @"OM2.6",
            Name = @"Reference",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"RFR",
            DataTypeName = @"Reference Range",
            TableId = null,
            TableName = null,
            Description = @"This field contains the reference (normal) ranges for ""numeric"" observations/tests with a nature code of A or C (see OM1-18 - Nature of service/test/observation ). It can identify different reference (normal) ranges for different categories of patients according to age, sex, race, and other conditions.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM2.6.1",
                            Type = @"Component",
                            Position = @"OM2.6.1",
                            Name = @"Numeric Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Wertebereich",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.6.1.1",
                            Type = @"SubComponent",
                            Position = @"OM2.6.1.1",
                            Name = @"Low Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.6.1.2",
                            Type = @"SubComponent",
                            Position = @"OM2.6.1.2",
                            Name = @"High Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.6.2",
                            Type = @"Component",
                            Position = @"OM2.6.2",
                            Name = @"Administrative Sex",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0007",
                            TableName = @"Admission type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.6.3",
                            Type = @"Component",
                            Position = @"OM2.6.3",
                            Name = @"Age Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Wertebereich",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.6.3.1",
                            Type = @"SubComponent",
                            Position = @"OM2.6.3.1",
                            Name = @"Low Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.6.3.2",
                            Type = @"SubComponent",
                            Position = @"OM2.6.3.2",
                            Name = @"High Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.6.4",
                            Type = @"Component",
                            Position = @"OM2.6.4",
                            Name = @"Gestational Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Wertebereich",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.6.4.1",
                            Type = @"SubComponent",
                            Position = @"OM2.6.4.1",
                            Name = @"Low Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.6.4.2",
                            Type = @"SubComponent",
                            Position = @"OM2.6.4.2",
                            Name = @"High Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.6.5",
                            Type = @"Component",
                            Position = @"OM2.6.5",
                            Name = @"Species",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.6.6",
                            Type = @"Component",
                            Position = @"OM2.6.6",
                            Name = @"Race/subspecies",
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
                            Id = @"OM2.6.7",
                            Type = @"Component",
                            Position = @"OM2.6.7",
                            Name = @"Conditions",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _reference = new HL7V24Field
        {
            field = message[@"OM2"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_reference.field.FieldRepetitions != null && _reference.field.FieldRepetitions.Count > 0)
        {
            _reference.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_reference, fieldData);
        }

        return _reference;
    } 
}

internal HL7V24Field _criticalRangeforOrdinalandContinuousObservations;

public HL7V24Field CriticalRangeforOrdinalandContinuousObservations
{
    get
    {
        if (_criticalRangeforOrdinalandContinuousObservations != null)
        {
            return _criticalRangeforOrdinalandContinuousObservations;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"OM2.7",
            Type = @"Field",
            Position = @"OM2.7",
            Name = @"Critical Range for Ordinal and Continuous Observations",
            Length = 205,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NR",
            DataTypeName = @"Wertebereich",
            TableId = null,
            TableName = null,
            Description = @"This field applies only to single tests/observations (i.e., a nature code of A or C, as described in OM1-18 - Nature of service/test/observation ) with numeric results. When a critical range is defined for such observations, it should be recorded here in the same format as the normal range (see OM2-6 - Reference (normal) range - ordinal and continuous observations ).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM2.7.1",
                            Type = @"Component",
                            Position = @"OM2.7.1",
                            Name = @"Low Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.7.2",
                            Type = @"Component",
                            Position = @"OM2.7.2",
                            Name = @"High Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _criticalRangeforOrdinalandContinuousObservations = new HL7V24Field
        {
            field = message[@"OM2"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_criticalRangeforOrdinalandContinuousObservations.field.FieldRepetitions != null && _criticalRangeforOrdinalandContinuousObservations.field.FieldRepetitions.Count > 0)
        {
            _criticalRangeforOrdinalandContinuousObservations.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_criticalRangeforOrdinalandContinuousObservations, fieldData);
        }

        return _criticalRangeforOrdinalandContinuousObservations;
    } 
}

internal HL7V24Field _absoluteRangeforOrdinalandContinuousObservations;

public HL7V24Field AbsoluteRangeforOrdinalandContinuousObservations
{
    get
    {
        if (_absoluteRangeforOrdinalandContinuousObservations != null)
        {
            return _absoluteRangeforOrdinalandContinuousObservations;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"OM2.8",
            Type = @"Field",
            Position = @"OM2.8",
            Name = @"Absolute Range for Ordinal and Continuous Observations",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"RFR",
            DataTypeName = @"Reference Range",
            TableId = null,
            TableName = null,
            Description = @"This field applies only to single tests/observations with a nature code of A or C (see OM1-18 - Nature of service/test/observation ). It defines the range of possible results. Results outside this range are not possible. The field should be recorded in the same format as the normal and critical ranges.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM2.8.1",
                            Type = @"Component",
                            Position = @"OM2.8.1",
                            Name = @"Numeric Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Wertebereich",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.8.1.1",
                            Type = @"SubComponent",
                            Position = @"OM2.8.1.1",
                            Name = @"Low Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.8.1.2",
                            Type = @"SubComponent",
                            Position = @"OM2.8.1.2",
                            Name = @"High Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.8.2",
                            Type = @"Component",
                            Position = @"OM2.8.2",
                            Name = @"Administrative Sex",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0007",
                            TableName = @"Admission type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.8.3",
                            Type = @"Component",
                            Position = @"OM2.8.3",
                            Name = @"Age Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Wertebereich",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.8.3.1",
                            Type = @"SubComponent",
                            Position = @"OM2.8.3.1",
                            Name = @"Low Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.8.3.2",
                            Type = @"SubComponent",
                            Position = @"OM2.8.3.2",
                            Name = @"High Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.8.4",
                            Type = @"Component",
                            Position = @"OM2.8.4",
                            Name = @"Gestational Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Wertebereich",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.8.4.1",
                            Type = @"SubComponent",
                            Position = @"OM2.8.4.1",
                            Name = @"Low Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.8.4.2",
                            Type = @"SubComponent",
                            Position = @"OM2.8.4.2",
                            Name = @"High Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.8.5",
                            Type = @"Component",
                            Position = @"OM2.8.5",
                            Name = @"Species",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.8.6",
                            Type = @"Component",
                            Position = @"OM2.8.6",
                            Name = @"Race/subspecies",
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
                            Id = @"OM2.8.7",
                            Type = @"Component",
                            Position = @"OM2.8.7",
                            Name = @"Conditions",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _absoluteRangeforOrdinalandContinuousObservations = new HL7V24Field
        {
            field = message[@"OM2"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_absoluteRangeforOrdinalandContinuousObservations.field.FieldRepetitions != null && _absoluteRangeforOrdinalandContinuousObservations.field.FieldRepetitions.Count > 0)
        {
            _absoluteRangeforOrdinalandContinuousObservations.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_absoluteRangeforOrdinalandContinuousObservations, fieldData);
        }

        return _absoluteRangeforOrdinalandContinuousObservations;
    } 
}

internal HL7V24Field _deltaCheckCriteria;

public HL7V24Field DeltaCheckCriteria
{
    get
    {
        if (_deltaCheckCriteria != null)
        {
            return _deltaCheckCriteria;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"OM2.9",
            Type = @"Field",
            Position = @"OM2.9",
            Name = @"Delta Check Criteria",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"DLT",
            DataTypeName = @"Delta Check",
            TableId = null,
            TableName = null,
            Description = @"This field applies to numeric tests/observations with a nature code of A or C (see OM1-18 - Nature of service/test/observation ). The field describes the information that controls delta check warnings and includes four components.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM2.9.1",
                            Type = @"Component",
                            Position = @"OM2.9.1",
                            Name = @"Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NR",
                            DataTypeName = @"Wertebereich",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.9.1.1",
                            Type = @"SubComponent",
                            Position = @"OM2.9.1.1",
                            Name = @"Low Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.9.1.2",
                            Type = @"SubComponent",
                            Position = @"OM2.9.1.2",
                            Name = @"High Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.9.2",
                            Type = @"Component",
                            Position = @"OM2.9.2",
                            Name = @"Numeric Threshold",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.9.3",
                            Type = @"Component",
                            Position = @"OM2.9.3",
                            Name = @"Change Computation",
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
                            Id = @"OM2.9.4",
                            Type = @"Component",
                            Position = @"OM2.9.4",
                            Name = @"Length Of Time-days",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _deltaCheckCriteria = new HL7V24Field
        {
            field = message[@"OM2"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_deltaCheckCriteria.field.FieldRepetitions != null && _deltaCheckCriteria.field.FieldRepetitions.Count > 0)
        {
            _deltaCheckCriteria.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_deltaCheckCriteria, fieldData);
        }

        return _deltaCheckCriteria;
    } 
}

internal HL7V24Field _minimumMeaningfulIncrements;

public HL7V24Field MinimumMeaningfulIncrements
{
    get
    {
        if (_minimumMeaningfulIncrements != null)
        {
            return _minimumMeaningfulIncrements;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"OM2.10",
            Type = @"Field",
            Position = @"OM2.10",
            Name = @"Minimum Meaningful Increments",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the numerically valued single observations (a nature code of A or C, as described in OM1-18 - Nature of service/test/observation ) and specifies the smallest meaningful difference between reported values (the effective resolution of the measuring instrument or technique for continuous data, or the smallest discrete interval that can occur for discrete data).",
            Sample = @"",
            Fields = null
        }

        _minimumMeaningfulIncrements = new HL7V24Field
        {
            field = message[@"OM2"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_minimumMeaningfulIncrements.field.FieldRepetitions != null && _minimumMeaningfulIncrements.field.FieldRepetitions.Count > 0)
        {
            _minimumMeaningfulIncrements.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_minimumMeaningfulIncrements, fieldData);
        }

        return _minimumMeaningfulIncrements;
    } 
}
    }
}
