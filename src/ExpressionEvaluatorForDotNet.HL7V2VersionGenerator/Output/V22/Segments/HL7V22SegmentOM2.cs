using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V22SegmentOM2
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"OM2"; } }

        public string SegmentId { get { return @"OM2"; } }
        
        public string LongName { get { return @"Numeric Observation"; } }
        
        public string Description { get { return @"This segment contains attributes of observations with continuous values (including those with data types of numeric, date, or time stamp).  It can be applied to observation batteries of type A and C (see OM1-19nature of test/observation). "; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_07",

                    };
            }
        }

        public HL7V22SegmentOM2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V22Field _segmentTypeId;

public HL7V22Field SegmentTypeId
{
    get
    {
        if (_segmentTypeId != null)
        {
            return _segmentTypeId;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OM2.1",
            Type = @"Field",
            Position = @"OM2.1",
            Name = @"Segment Type Id",
            Length = 3,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"the string OM2 - identifies a record as a numeric observation segment",
            Sample = @"",
            Fields = null
        }

        _segmentTypeId = new HL7V22Field
        {
            field = message[@"OM2"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_segmentTypeId.field.FieldRepetitions != null && _segmentTypeId.field.FieldRepetitions.Count > 0)
        {
            _segmentTypeId.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_segmentTypeId, fieldData);
        }

        return _segmentTypeId;
    } 
}

internal HL7V22Field _sequenceNumberTestObservationMasterFile;

public HL7V22Field SequenceNumberTestObservationMasterFile
{
    get
    {
        if (_sequenceNumberTestObservationMasterFile != null)
        {
            return _sequenceNumberTestObservationMasterFile;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OM2.2",
            Type = @"Field",
            Position = @"OM2.2",
            Name = @"Sequence Number - Test/ Observation Master File",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"the same value as the sequence number of the associated OM1 segment",
            Sample = @"",
            Fields = null
        }

        _sequenceNumberTestObservationMasterFile = new HL7V22Field
        {
            field = message[@"OM2"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sequenceNumberTestObservationMasterFile.field.FieldRepetitions != null && _sequenceNumberTestObservationMasterFile.field.FieldRepetitions.Count > 0)
        {
            _sequenceNumberTestObservationMasterFile.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_sequenceNumberTestObservationMasterFile, fieldData);
        }

        return _sequenceNumberTestObservationMasterFile;
    } 
}

internal HL7V22Field _unitsOfMeasure;

public HL7V22Field UnitsOfMeasure
{
    get
    {
        if (_unitsOfMeasure != null)
        {
            return _unitsOfMeasure;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OM2.3",
            Type = @"Field",
            Position = @"OM2.3",
            Name = @"Units Of Measure",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"for single tests/observations (those with a nature code of A or C, as described in OM1-19-nature of test/observation) that have numeric values, this field contains their customary units of measure",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM2.3.1",
                            Type = @"Component",
                            Position = @"OM2.3.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.3.2",
                            Type = @"Component",
                            Position = @"OM2.3.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.3.3",
                            Type = @"Component",
                            Position = @"OM2.3.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.3.4",
                            Type = @"Component",
                            Position = @"OM2.3.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.3.5",
                            Type = @"Component",
                            Position = @"OM2.3.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.3.6",
                            Type = @"Component",
                            Position = @"OM2.3.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _unitsOfMeasure = new HL7V22Field
        {
            field = message[@"OM2"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_unitsOfMeasure.field.FieldRepetitions != null && _unitsOfMeasure.field.FieldRepetitions.Count > 0)
        {
            _unitsOfMeasure.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_unitsOfMeasure, fieldData);
        }

        return _unitsOfMeasure;
    } 
}

internal HL7V22Field _rangeOfDecimalPrecision;

public HL7V22Field RangeOfDecimalPrecision
{
    get
    {
        if (_rangeOfDecimalPrecision != null)
        {
            return _rangeOfDecimalPrecision;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OM2.4",
            Type = @"Field",
            Position = @"OM2.4",
            Name = @"Range Of Decimal Precision",
            Length = 10,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"used for numerically valued single observations (code A or C as described in OM1;15), specifies the total length in characters of the field needed to display the observation, and the number of digits displayed to the right of the decimal point.  This is coded as a single number in the format <length>.<decimaldigits>.  For example, a value of 6.2 implies 6 characters total (including the sign and decimal point) with 2 digits after the decimal point.  For integer values, the period and <decimal-digits> portion may be omitted (that is, 5.0 and 5 are equivalent).  More than one such mask may be transmitted (separated by repeat delimiters) when it is necessary to define multiple display formats that are possible",
            Sample = @"",
            Fields = null
        }

        _rangeOfDecimalPrecision = new HL7V22Field
        {
            field = message[@"OM2"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rangeOfDecimalPrecision.field.FieldRepetitions != null && _rangeOfDecimalPrecision.field.FieldRepetitions.Count > 0)
        {
            _rangeOfDecimalPrecision.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_rangeOfDecimalPrecision, fieldData);
        }

        return _rangeOfDecimalPrecision;
    } 
}

internal HL7V22Field _correspondingSiUnitsOfMeasure;

public HL7V22Field CorrespondingSiUnitsOfMeasure
{
    get
    {
        if (_correspondingSiUnitsOfMeasure != null)
        {
            return _correspondingSiUnitsOfMeasure;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OM2.5",
            Type = @"Field",
            Position = @"OM2.5",
            Name = @"Corresponding Si Units Of Measure",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"for single tests/observations - the corresponding SI units of measure in the format, when these differ from the customary units of measure given in the previous field",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM2.5.1",
                            Type = @"Component",
                            Position = @"OM2.5.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.5.2",
                            Type = @"Component",
                            Position = @"OM2.5.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or x-ray impression.  Its data type is string (ST).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.5.3",
                            Type = @"Component",
                            Position = @"OM2.5.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system will be assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item.  For backward compatibility, if this component is absent, it will be taken to mean the CPT-4 with ASTM extensions, i.e., AS4.  Other coding systems that might appear here are ICD-9, ICD-10, SNOMED, etc.  Each system will be given a unique identifying string.  The current ASTM 1238-88  diagnostic/procedure/observation/drug ID/health outcomes coding systems are identified in the tables below.  Others may be added as needed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.5.4",
                            Type = @"Component",
                            Position = @"OM2.5.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.5.5",
                            Type = @"Component",
                            Position = @"OM2.5.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.5.6",
                            Type = @"Component",
                            Position = @"OM2.5.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _correspondingSiUnitsOfMeasure = new HL7V22Field
        {
            field = message[@"OM2"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_correspondingSiUnitsOfMeasure.field.FieldRepetitions != null && _correspondingSiUnitsOfMeasure.field.FieldRepetitions.Count > 0)
        {
            _correspondingSiUnitsOfMeasure.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_correspondingSiUnitsOfMeasure, fieldData);
        }

        return _correspondingSiUnitsOfMeasure;
    } 
}

internal HL7V22Field _siConversionFactor;

public HL7V22Field SiConversionFactor
{
    get
    {
        if (_siConversionFactor != null)
        {
            return _siConversionFactor;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OM2.6",
            Type = @"Field",
            Position = @"OM2.6",
            Name = @"Si Conversion Factor",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"for continuous, numerically valued tests/observations, with a nature code of A or C (see OM1-19-nature of test/observation).  This is a factor for converting the customary units to SI units",
            Sample = @"",
            Fields = null
        }

        _siConversionFactor = new HL7V22Field
        {
            field = message[@"OM2"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_siConversionFactor.field.FieldRepetitions != null && _siConversionFactor.field.FieldRepetitions.Count > 0)
        {
            _siConversionFactor.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_siConversionFactor, fieldData);
        }

        return _siConversionFactor;
    } 
}

internal HL7V22Field _referencenormalRangeOrdinalAndContinuousObservations;

public HL7V22Field ReferencenormalRangeOrdinalAndContinuousObservations
{
    get
    {
        if (_referencenormalRangeOrdinalAndContinuousObservations != null)
        {
            return _referencenormalRangeOrdinalAndContinuousObservations;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OM2.7",
            Type = @"Field",
            Position = @"OM2.7",
            Name = @"Reference (normal) Range - Ordinal & Continuous Observations",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_RFR",
            DataTypeName = @"Reference Range",
            TableId = null,
            TableName = null,
            Description = @"provides reference (normal) ranges for ""numeric"" observations/tests with a nature code of A or C (see OM1-19-nature of test/observation). It can identify different reference (normal) ranges for different categories of patients according to age, sex, race, and other conditions",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM2.7.1",
                            Type = @"Component",
                            Position = @"OM2.7.1",
                            Name = @"Reference Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_RANGE",
                            DataTypeName = @"Range Of Values",
                            TableId = null,
                            TableName = null,
                            Description = @"The format of this component is <low value & high value>, where the range is taken to be inclusive (i.e., the range includes the end points).  In this specification, the units are assumed to be identical to the reporting units given in OM2-3-units of measure). ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.7.1.1",
                            Type = @"SubComponent",
                            Position = @"OM2.7.1.1",
                            Name = @"Low Value",
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
                            Id = @"OM2.7.1.2",
                            Type = @"SubComponent",
                            Position = @"OM2.7.1.2",
                            Name = @"High Value",
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
                            Id = @"OM2.7.2",
                            Type = @"Component",
                            Position = @"OM2.7.2",
                            Name = @"Sex",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"The sex of the patient",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.7.3",
                            Type = @"Component",
                            Position = @"OM2.7.3",
                            Name = @"Age Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_RANGE",
                            DataTypeName = @"Range Of Values",
                            TableId = null,
                            TableName = null,
                            Description = @"The age range (in years or fractions thereof) is specified as two values separated by a subcomponent delimiter (i.e., <low value & high value>) in order to allow a simple and consistent machine interpretation of this component.  Ages of less than one year should be specified as a fraction (e.g., 1 month = 0.0830, 1 week = 0.01920, 1 day = 0.0027300).  However, for most purposes involving infants, the gestational age (measured in weeks) is preferred.  The lower end of the range is not indicated; the upper end is, assuring that series of ranges do not overlap",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.7.3.1",
                            Type = @"SubComponent",
                            Position = @"OM2.7.3.1",
                            Name = @"Low Value",
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
                            Id = @"OM2.7.3.2",
                            Type = @"SubComponent",
                            Position = @"OM2.7.3.2",
                            Name = @"High Value",
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
                            Id = @"OM2.7.4",
                            Type = @"Component",
                            Position = @"OM2.7.4",
                            Name = @"Gestational Age Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_RANGE",
                            DataTypeName = @"Range Of Values",
                            TableId = null,
                            TableName = null,
                            Description = @"The gestational age is relevant only when the reference range is influenced by the stage of pregnancy.  A range of values separated by a component delimiter is required, i.e., <low value & high value>.  The gestational age is measured in weeks from conception.  For example, <1&10> implies that the normals apply to gestational ages from 1 week to 4 weeks inclusive (1&4).  The lower end of the range is not included; the upper end is, assuring  that series of age ranges do not overlap",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.7.4.1",
                            Type = @"SubComponent",
                            Position = @"OM2.7.4.1",
                            Name = @"Low Value",
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
                            Id = @"OM2.7.4.2",
                            Type = @"SubComponent",
                            Position = @"OM2.7.4.2",
                            Name = @"High Value",
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
                            Id = @"OM2.7.5",
                            Type = @"Component",
                            Position = @"OM2.7.5",
                            Name = @"Species",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is assumed to be human unless otherwise stated.  The species should be represented as text (e.g., rabbit, mouse, rat",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.7.6",
                            Type = @"Component",
                            Position = @"OM2.7.6",
                            Name = @"Race / Subspecies",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value",
                            TableId = null,
                            TableName = null,
                            Description = @"In the case of humans (the default), the race is specified when race influences the reference range.  When normal ranges for animals are being described, this component can be used to describe subspecies or special breeds of animals",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.7.7",
                            Type = @"Component",
                            Position = @"OM2.7.7",
                            Name = @"Text Condition",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The condition is simply free text.  This component allows for definition of normal ranges based on any arbitrary condition, e.g., phase of menstrual cycle or dose of a particular drug.  It is provided as a way to communicate the normal ranges for special conditions.  It does not allow automatic checking of these text conditions",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _referencenormalRangeOrdinalAndContinuousObservations = new HL7V22Field
        {
            field = message[@"OM2"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_referencenormalRangeOrdinalAndContinuousObservations.field.FieldRepetitions != null && _referencenormalRangeOrdinalAndContinuousObservations.field.FieldRepetitions.Count > 0)
        {
            _referencenormalRangeOrdinalAndContinuousObservations.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_referencenormalRangeOrdinalAndContinuousObservations, fieldData);
        }

        return _referencenormalRangeOrdinalAndContinuousObservations;
    } 
}

internal HL7V22Field _criticalRangeForOrdinalAndContinuousObservations;

public HL7V22Field CriticalRangeForOrdinalAndContinuousObservations
{
    get
    {
        if (_criticalRangeForOrdinalAndContinuousObservations != null)
        {
            return _criticalRangeForOrdinalAndContinuousObservations;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OM2.8",
            Type = @"Field",
            Position = @"OM2.8",
            Name = @"Critical Range For Ordinal And Continuous Observations",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_RANGE",
            DataTypeName = @"Range Of Values",
            TableId = null,
            TableName = null,
            Description = @"applies only to single tests/observations (i.e., a nature code of A or C, as described in OM1-19-nature of test/observations) with numeric results.  When a critical range is defined for such observations, it should be recorded here in the same format as the normal range (see OM2-7-reference (normal) range-ordinal and continuous obs). ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM2.8.1",
                            Type = @"Component",
                            Position = @"OM2.8.1",
                            Name = @"Low Value",
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
                            Id = @"OM2.8.2",
                            Type = @"Component",
                            Position = @"OM2.8.2",
                            Name = @"High Value",
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

        _criticalRangeForOrdinalAndContinuousObservations = new HL7V22Field
        {
            field = message[@"OM2"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_criticalRangeForOrdinalAndContinuousObservations.field.FieldRepetitions != null && _criticalRangeForOrdinalAndContinuousObservations.field.FieldRepetitions.Count > 0)
        {
            _criticalRangeForOrdinalAndContinuousObservations.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_criticalRangeForOrdinalAndContinuousObservations, fieldData);
        }

        return _criticalRangeForOrdinalAndContinuousObservations;
    } 
}

internal HL7V22Field _absoluteRangeForOrdinalAndContinuousObservations;

public HL7V22Field AbsoluteRangeForOrdinalAndContinuousObservations
{
    get
    {
        if (_absoluteRangeForOrdinalAndContinuousObservations != null)
        {
            return _absoluteRangeForOrdinalAndContinuousObservations;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OM2.9",
            Type = @"Field",
            Position = @"OM2.9",
            Name = @"Absolute Range For Ordinal And Continuous Observations",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_ABS_RANGE",
            DataTypeName = @"Absolute Range",
            TableId = null,
            TableName = null,
            Description = @"pplies only to single tests/observations with a nature code of A or C (see OM1-19-nature of test/observation).  It defines the range of possible results.  Results outside this range are not possible.  The field should be recorded in the same format as the normal and critical ranges",
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
                            DataType = @"CM_RANGE",
                            DataTypeName = @"Range Of Values",
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
                            Id = @"OM2.9.1.2",
                            Type = @"SubComponent",
                            Position = @"OM2.9.1.2",
                            Name = @"High Value",
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
                            Id = @"OM2.9.2",
                            Type = @"Component",
                            Position = @"OM2.9.2",
                            Name = @"Numeric Change",
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
                            Name = @"Percent Per Change",
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
                            Id = @"OM2.9.4",
                            Type = @"Component",
                            Position = @"OM2.9.4",
                            Name = @"Days",
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

        _absoluteRangeForOrdinalAndContinuousObservations = new HL7V22Field
        {
            field = message[@"OM2"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_absoluteRangeForOrdinalAndContinuousObservations.field.FieldRepetitions != null && _absoluteRangeForOrdinalAndContinuousObservations.field.FieldRepetitions.Count > 0)
        {
            _absoluteRangeForOrdinalAndContinuousObservations.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_absoluteRangeForOrdinalAndContinuousObservations, fieldData);
        }

        return _absoluteRangeForOrdinalAndContinuousObservations;
    } 
}

internal HL7V22Field _deltaCheckCriteria;

public HL7V22Field DeltaCheckCriteria
{
    get
    {
        if (_deltaCheckCriteria != null)
        {
            return _deltaCheckCriteria;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OM2.10",
            Type = @"Field",
            Position = @"OM2.10",
            Name = @"Delta Check Criteria",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_DLT",
            DataTypeName = @"Delta Check",
            TableId = null,
            TableName = null,
            Description = @"applies to numeric tests/observations with a nature code of A or C (see OM1-19-nature of test/observation).  The field describes the information that controls delta check warnings and includes four components. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM2.10.1",
                            Type = @"Component",
                            Position = @"OM2.10.1",
                            Name = @"Range",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_RANGE",
                            DataTypeName = @"Range Of Values",
                            TableId = null,
                            TableName = null,
                            Description = @"The range to which the following applies: <low & high>",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OM2.10.1.1",
                            Type = @"SubComponent",
                            Position = @"OM2.10.1.1",
                            Name = @"Low Value",
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
                            Id = @"OM2.10.1.2",
                            Type = @"SubComponent",
                            Position = @"OM2.10.1.2",
                            Name = @"High Value",
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
                            Id = @"OM2.10.2",
                            Type = @"Component",
                            Position = @"OM2.10.2",
                            Name = @"Numeric Threshold",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The numeric threshold of the change that is detected, e.g., 10 ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.10.3",
                            Type = @"Component",
                            Position = @"OM2.10.3",
                            Name = @"Change",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Whether the change is computed as a percent change or an absolute change.  This component can have two possible values: 
 
- % Indicates a percent change
- a Absolute change ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OM2.10.4",
                            Type = @"Component",
                            Position = @"OM2.10.4",
                            Name = @"Length Of Time-days",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The length of time that the service retains a value for computing delta checks.  This is recorded in number of days.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _deltaCheckCriteria = new HL7V22Field
        {
            field = message[@"OM2"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_deltaCheckCriteria.field.FieldRepetitions != null && _deltaCheckCriteria.field.FieldRepetitions.Count > 0)
        {
            _deltaCheckCriteria.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_deltaCheckCriteria, fieldData);
        }

        return _deltaCheckCriteria;
    } 
}

internal HL7V22Field _minimumMeaningfulIncrements;

public HL7V22Field MinimumMeaningfulIncrements
{
    get
    {
        if (_minimumMeaningfulIncrements != null)
        {
            return _minimumMeaningfulIncrements;
        }

        var fieldData = new HL7V22FieldData
        {
            Id = @"OM2.11",
            Type = @"Field",
            Position = @"OM2.11",
            Name = @"Minimum Meaningful Increments",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"used for numerically valued single observations (a nature code of A or C, as described in OM1-19nature of test/observation) and specifies the smallest meaningful difference between reported values (the effective resolution of the measuring instrument or technique for continuous data, or the smallest discrete interval that can occur for discrete data).",
            Sample = @"",
            Fields = null
        }

        _minimumMeaningfulIncrements = new HL7V22Field
        {
            field = message[@"OM2"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_minimumMeaningfulIncrements.field.FieldRepetitions != null && _minimumMeaningfulIncrements.field.FieldRepetitions.Count > 0)
        {
            _minimumMeaningfulIncrements.fieldRepetitions = HL7V2FieldGenerator.GenerateV22FieldRepetitions(_minimumMeaningfulIncrements, fieldData);
        }

        return _minimumMeaningfulIncrements;
    } 
}
    }
}
