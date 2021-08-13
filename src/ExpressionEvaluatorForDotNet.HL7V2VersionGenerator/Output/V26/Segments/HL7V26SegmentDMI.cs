using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentDMI
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"DMI"; } }

        public string SegmentId { get { return @"DMI"; } }
        
        public string LongName { get { return @"DRG Master File Information"; } }
        
        public string Description { get { return @"The Technical Steward for the DMI segment is Financial Management.

The DMI segment contains the DRG related basic information, for example, relative weight, etc.  The DMI segment is used to send the fixed information assigned to a specific DRG."; } }
        
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

        public HL7V26SegmentDMI(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _diagnosticRelatedGroup;

public HL7V26Field DiagnosticRelatedGroup
{
    get
    {
        if (_diagnosticRelatedGroup != null)
        {
            return _diagnosticRelatedGroup;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DMI.1",
            Type = @"Field",
            Position = @"DMI.1",
            Name = @"Diagnostic Related Group",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = @"0055",
            TableName = @"Diagnosis Related Group",
            Description = @"This field contains the DRG for the transaction. Interim DRG's could be determined for an encounter. Refer to Externally-defined Table 0055 - Diagnosis Related Group in Chapter 6 for suggested values.

As of v2.6, the known applicable external coding systems include those in Z001 - Diagnostic Related Group Coding Systems. If the code set you are using is in this table, then you must use that designation.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DMI.1.1",
                            Type = @"Component",
                            Position = @"DMI.1.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.1.2",
                            Type = @"Component",
                            Position = @"DMI.1.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.1.3",
                            Type = @"Component",
                            Position = @"DMI.1.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained.Refer to HL7 Table 0396 - Coding System s in section 2.16.4, ""Coding System Table"" for valid values. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.1.4",
                            Type = @"Component",
                            Position = @"DMI.1.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to “Identifier” in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.1.5",
                            Type = @"Component",
                            Position = @"DMI.1.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.1.6",
                            Type = @"Component",
                            Position = @"DMI.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 - Coding Systems in section 2.16.4, ""Coding System Table"" for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.1.7",
                            Type = @"Component",
                            Position = @"DMI.1.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.1.8",
                            Type = @"Component",
                            Position = @"DMI.1.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 6. It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.1.9",
                            Type = @"Component",
                            Position = @"DMI.1.9",
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

        _diagnosticRelatedGroup = new HL7V26Field
        {
            field = message[@"DMI"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosticRelatedGroup.field.FieldRepetitions != null && _diagnosticRelatedGroup.field.FieldRepetitions.Count > 0)
        {
            _diagnosticRelatedGroup.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_diagnosticRelatedGroup, fieldData);
        }

        return _diagnosticRelatedGroup;
    } 
}

internal HL7V26Field _majorDiagnosticCategory;

public HL7V26Field MajorDiagnosticCategory
{
    get
    {
        if (_majorDiagnosticCategory != null)
        {
            return _majorDiagnosticCategory;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DMI.2",
            Type = @"Field",
            Position = @"DMI.2",
            Name = @"Major Diagnostic Category",
            Length = 1,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CNE",
            DataTypeName = @"Coded with No Exceptions",
            TableId = @"0118",
            TableName = @"Major Diagnostic Category",
            Description = @"This field indicates the determined Major Diagnostic Category (MDC) value. Refer to Externally-defined Table 0118 - Major Diagnostic Category for suggested values.

As of v2.6, the known applicable external coding systems include those in Z002 - Major Diagnostic Category Coding Systems. If the code set you are using is in this table, then you must use that designation.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DMI.2.1",
                            Type = @"Component",
                            Position = @"DMI.2.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.2.2",
                            Type = @"Component",
                            Position = @"DMI.2.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.2.3",
                            Type = @"Component",
                            Position = @"DMI.2.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CNE.1 is obtained.Refer to HL7 Table 0396 - Coding System s in section 2.16.4, ""Coding System Table"" for valid values. Each coding system is assigned a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.2.4",
                            Type = @"Component",
                            Position = @"DMI.2.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to “Identifier” in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.2.5",
                            Type = @"Component",
                            Position = @"DMI.2.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.2.6",
                            Type = @"Component",
                            Position = @"DMI.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 - Coding Systems in section 2.16.4, ""Coding System Table"" for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.2.7",
                            Type = @"Component",
                            Position = @"DMI.2.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.2.8",
                            Type = @"Component",
                            Position = @"DMI.2.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 6. It belongs conceptually to the group of Alternate components (see note 2.A.1) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.2.9",
                            Type = @"Component",
                            Position = @"DMI.2.9",
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

        _majorDiagnosticCategory = new HL7V26Field
        {
            field = message[@"DMI"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_majorDiagnosticCategory.field.FieldRepetitions != null && _majorDiagnosticCategory.field.FieldRepetitions.Count > 0)
        {
            _majorDiagnosticCategory.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_majorDiagnosticCategory, fieldData);
        }

        return _majorDiagnosticCategory;
    } 
}

internal HL7V26Field _lowerandUpperTrimPoints;

public HL7V26Field LowerandUpperTrimPoints
{
    get
    {
        if (_lowerandUpperTrimPoints != null)
        {
            return _lowerandUpperTrimPoints;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DMI.3",
            Type = @"Field",
            Position = @"DMI.3",
            Name = @"Lower and Upper Trim Points",
            Length = 7,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"NR",
            DataTypeName = @"Numeric Range",
            TableId = null,
            TableName = null,
            Description = @"This field contains the lower and upper trim points as calculated for this DRG..",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"DMI.3.1",
                            Type = @"Component",
                            Position = @"DMI.3.1",
                            Name = @"Low Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the lower limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"DMI.3.2",
                            Type = @"Component",
                            Position = @"DMI.3.2",
                            Name = @"High Value",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The number specifying the high limit or boundary of the range.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _lowerandUpperTrimPoints = new HL7V26Field
        {
            field = message[@"DMI"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_lowerandUpperTrimPoints.field.FieldRepetitions != null && _lowerandUpperTrimPoints.field.FieldRepetitions.Count > 0)
        {
            _lowerandUpperTrimPoints.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_lowerandUpperTrimPoints, fieldData);
        }

        return _lowerandUpperTrimPoints;
    } 
}

internal HL7V26Field _averageLengthofStay;

public HL7V26Field AverageLengthofStay
{
    get
    {
        if (_averageLengthofStay != null)
        {
            return _averageLengthofStay;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DMI.4",
            Type = @"Field",
            Position = @"DMI.4",
            Name = @"Average Length of Stay",
            Length = 5,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the average length of stay in days, calculated as the geometric mean value, allocated to the determined DRG.",
            Sample = @"",
            Fields = null
        }

        _averageLengthofStay = new HL7V26Field
        {
            field = message[@"DMI"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_averageLengthofStay.field.FieldRepetitions != null && _averageLengthofStay.field.FieldRepetitions.Count > 0)
        {
            _averageLengthofStay.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_averageLengthofStay, fieldData);
        }

        return _averageLengthofStay;
    } 
}

internal HL7V26Field _relativeWeight;

public HL7V26Field RelativeWeight
{
    get
    {
        if (_relativeWeight != null)
        {
            return _relativeWeight;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"DMI.5",
            Type = @"Field",
            Position = @"DMI.5",
            Name = @"Relative Weight",
            Length = 7,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"Each DRG has its own relative weight (cost weight) which is calculated (defined) by official institutions. This value is the basis for calculating other values, e.g., the effective weight.",
            Sample = @"",
            Fields = null
        }

        _relativeWeight = new HL7V26Field
        {
            field = message[@"DMI"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_relativeWeight.field.FieldRepetitions != null && _relativeWeight.field.FieldRepetitions.Count > 0)
        {
            _relativeWeight.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_relativeWeight, fieldData);
        }

        return _relativeWeight;
    } 
}
    }
}
