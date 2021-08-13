using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V25SegmentSPM
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"SPM"; } }

        public string SegmentId { get { return @"SPM"; } }
        
        public string LongName { get { return @"Specimen"; } }
        
        public string Description { get { return @"The intent of this segment is to describe the characteristics of a specimen. It differs from the intent of the OBR in that the OBR addresses order-specific information. It differs from the SAC segment in that the SAC addresses specimen container attributes. An advantage afforded by a separate specimen segment is that it generalizes the multiple relationships among order(s), results, specimen(s) and specimen container(s)."; } }
        
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

        public HL7V25SegmentSPM(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V25Field _setIDSPM;

public HL7V25Field SetIDSPM
{
    get
    {
        if (_setIDSPM != null)
        {
            return _setIDSPM;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.1",
            Type = @"Field",
            Position = @"SPM.1",
            Name = @"Set ID - SPM",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the sequence number. This field is used to identify SPM segment instances in message structures where the SPM segment repeats.",
            Sample = @"",
            Fields = null
        }

        _setIDSPM = new HL7V25Field
        {
            field = message[@"SPM"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDSPM.field.FieldRepetitions != null && _setIDSPM.field.FieldRepetitions.Count > 0)
        {
            _setIDSPM.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_setIDSPM, fieldData);
        }

        return _setIDSPM;
    } 
}

internal HL7V25Field _specimenID;

public HL7V25Field SpecimenID
{
    get
    {
        if (_specimenID != null)
        {
            return _specimenID;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.2",
            Type = @"Field",
            Position = @"SPM.2",
            Name = @"Specimen ID",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EIP",
            DataTypeName = @"Entity Identifier Pair",
            TableId = null,
            TableName = null,
            Description = @"This field contains a unique identifier for the specimen as referenced by the Placer application, the Filler application, or both.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.2.1",
                            Type = @"Component",
                            Position = @"SPM.2.1",
                            Name = @"Placer Assigned Identifier",
                            Length = 427,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies an identifier assigned to an entity by the placer system.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.2.1.1",
                            Type = @"SubComponent",
                            Position = @"SPM.2.1.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.2.1.2",
                            Type = @"SubComponent",
                            Position = @"SPM.2.1.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.2.1.3",
                            Type = @"SubComponent",
                            Position = @"SPM.2.1.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"SPM.2.1.4",
                            Type = @"SubComponent",
                            Position = @"SPM.2.1.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.2.2",
                            Type = @"Component",
                            Position = @"SPM.2.2",
                            Name = @"Filler Assigned Identifier",
                            Length = 427,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies an identifier assigned to an entity by the filler system.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.2.2.1",
                            Type = @"SubComponent",
                            Position = @"SPM.2.2.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.2.2.2",
                            Type = @"SubComponent",
                            Position = @"SPM.2.2.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.2.2.3",
                            Type = @"SubComponent",
                            Position = @"SPM.2.2.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"SPM.2.2.4",
                            Type = @"SubComponent",
                            Position = @"SPM.2.2.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _specimenID = new HL7V25Field
        {
            field = message[@"SPM"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenID.field.FieldRepetitions != null && _specimenID.field.FieldRepetitions.Count > 0)
        {
            _specimenID.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenID, fieldData);
        }

        return _specimenID;
    } 
}

internal HL7V25Field _specimenParentIDs;

public HL7V25Field SpecimenParentIDs
{
    get
    {
        if (_specimenParentIDs != null)
        {
            return _specimenParentIDs;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.3",
            Type = @"Field",
            Position = @"SPM.3",
            Name = @"Specimen Parent IDs",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"EIP",
            DataTypeName = @"Entity Identifier Pair",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identifiers for the specimen or specimens that contributed to the specimen that is described by the segment instance.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.3.1",
                            Type = @"Component",
                            Position = @"SPM.3.1",
                            Name = @"Placer Assigned Identifier",
                            Length = 427,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies an identifier assigned to an entity by the placer system.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.3.1.1",
                            Type = @"SubComponent",
                            Position = @"SPM.3.1.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.3.1.2",
                            Type = @"SubComponent",
                            Position = @"SPM.3.1.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.3.1.3",
                            Type = @"SubComponent",
                            Position = @"SPM.3.1.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"SPM.3.1.4",
                            Type = @"SubComponent",
                            Position = @"SPM.3.1.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.3.2",
                            Type = @"Component",
                            Position = @"SPM.3.2",
                            Name = @"Filler Assigned Identifier",
                            Length = 427,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies an identifier assigned to an entity by the filler system.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.3.2.1",
                            Type = @"SubComponent",
                            Position = @"SPM.3.2.1",
                            Name = @"Entity Identifier",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. See Section 2.A.33, ""HD - hierarchic designator"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.3.2.2",
                            Type = @"SubComponent",
                            Position = @"SPM.3.2.2",
                            Name = @"Namespace Id",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0363",
                            TableName = @"Assigning authority",
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. Refer to User-defined Table 0363 - Assigning authority for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.3.2.3",
                            Type = @"SubComponent",
                            Position = @"SPM.3.2.3",
                            Name = @"Universal Id",
                            Length = 199,
                            Usage = @"C",
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
                            Id = @"SPM.3.2.4",
                            Type = @"SubComponent",
                            Position = @"SPM.3.2.4",
                            Name = @"Universal Id Type",
                            Length = 6,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _specimenParentIDs = new HL7V25Field
        {
            field = message[@"SPM"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenParentIDs.field.FieldRepetitions != null && _specimenParentIDs.field.FieldRepetitions.Count > 0)
        {
            _specimenParentIDs.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenParentIDs, fieldData);
        }

        return _specimenParentIDs;
    } 
}

internal HL7V25Field _specimenType;

public HL7V25Field SpecimenType
{
    get
    {
        if (_specimenType != null)
        {
            return _specimenType;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.4",
            Type = @"Field",
            Position = @"SPM.4",
            Name = @"Specimen Type",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0487",
            TableName = @"Specimen Type",
            Description = @"This field describes the precise nature of the entity that will be the source material for the observation.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.4.1",
                            Type = @"Component",
                            Position = @"SPM.4.1",
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
                            Id = @"SPM.4.2",
                            Type = @"Component",
                            Position = @"SPM.4.2",
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
                            Id = @"SPM.4.3",
                            Type = @"Component",
                            Position = @"SPM.4.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.4.4",
                            Type = @"Component",
                            Position = @"SPM.4.4",
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
                            Id = @"SPM.4.5",
                            Type = @"Component",
                            Position = @"SPM.4.5",
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
                            Id = @"SPM.4.6",
                            Type = @"Component",
                            Position = @"SPM.4.6",
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
                            Id = @"SPM.4.7",
                            Type = @"Component",
                            Position = @"SPM.4.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.4.8",
                            Type = @"Component",
                            Position = @"SPM.4.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.4.9",
                            Type = @"Component",
                            Position = @"SPM.4.9",
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

        _specimenType = new HL7V25Field
        {
            field = message[@"SPM"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenType.field.FieldRepetitions != null && _specimenType.field.FieldRepetitions.Count > 0)
        {
            _specimenType.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenType, fieldData);
        }

        return _specimenType;
    } 
}

internal HL7V25Field _specimenTypeModifier;

public HL7V25Field SpecimenTypeModifier
{
    get
    {
        if (_specimenTypeModifier != null)
        {
            return _specimenTypeModifier;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.5",
            Type = @"Field",
            Position = @"SPM.5",
            Name = @"Specimen Type Modifier",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0541",
            TableName = @"Specimen Type Modifier",
            Description = @"This field contains modifying or qualifying description(s) about the specimen type",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.5.1",
                            Type = @"Component",
                            Position = @"SPM.5.1",
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
                            Id = @"SPM.5.2",
                            Type = @"Component",
                            Position = @"SPM.5.2",
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
                            Id = @"SPM.5.3",
                            Type = @"Component",
                            Position = @"SPM.5.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.5.4",
                            Type = @"Component",
                            Position = @"SPM.5.4",
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
                            Id = @"SPM.5.5",
                            Type = @"Component",
                            Position = @"SPM.5.5",
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
                            Id = @"SPM.5.6",
                            Type = @"Component",
                            Position = @"SPM.5.6",
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
                            Id = @"SPM.5.7",
                            Type = @"Component",
                            Position = @"SPM.5.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.5.8",
                            Type = @"Component",
                            Position = @"SPM.5.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.5.9",
                            Type = @"Component",
                            Position = @"SPM.5.9",
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

        _specimenTypeModifier = new HL7V25Field
        {
            field = message[@"SPM"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenTypeModifier.field.FieldRepetitions != null && _specimenTypeModifier.field.FieldRepetitions.Count > 0)
        {
            _specimenTypeModifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenTypeModifier, fieldData);
        }

        return _specimenTypeModifier;
    } 
}

internal HL7V25Field _specimenAdditives;

public HL7V25Field SpecimenAdditives
{
    get
    {
        if (_specimenAdditives != null)
        {
            return _specimenAdditives;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.6",
            Type = @"Field",
            Position = @"SPM.6",
            Name = @"Specimen Additives",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0371",
            TableName = @"Additive/Preservative",
            Description = @"This field identifies any additives introduced to the specimen before or at the time of collection. These additives may be introduced in order to preserve, maintain or enhance the particular nature or component of the specimen. Refer to HL7 Table 0371 - Additive for valid values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.6.1",
                            Type = @"Component",
                            Position = @"SPM.6.1",
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
                            Id = @"SPM.6.2",
                            Type = @"Component",
                            Position = @"SPM.6.2",
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
                            Id = @"SPM.6.3",
                            Type = @"Component",
                            Position = @"SPM.6.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.6.4",
                            Type = @"Component",
                            Position = @"SPM.6.4",
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
                            Id = @"SPM.6.5",
                            Type = @"Component",
                            Position = @"SPM.6.5",
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
                            Id = @"SPM.6.6",
                            Type = @"Component",
                            Position = @"SPM.6.6",
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
                            Id = @"SPM.6.7",
                            Type = @"Component",
                            Position = @"SPM.6.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.6.8",
                            Type = @"Component",
                            Position = @"SPM.6.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.6.9",
                            Type = @"Component",
                            Position = @"SPM.6.9",
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

        _specimenAdditives = new HL7V25Field
        {
            field = message[@"SPM"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenAdditives.field.FieldRepetitions != null && _specimenAdditives.field.FieldRepetitions.Count > 0)
        {
            _specimenAdditives.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenAdditives, fieldData);
        }

        return _specimenAdditives;
    } 
}

internal HL7V25Field _specimenCollectionMethod;

public HL7V25Field SpecimenCollectionMethod
{
    get
    {
        if (_specimenCollectionMethod != null)
        {
            return _specimenCollectionMethod;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.7",
            Type = @"Field",
            Position = @"SPM.7",
            Name = @"Specimen Collection Method",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0488",
            TableName = @"Specimen Collection Method",
            Description = @"Describes the procedure or process by which the specimen was collected.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.7.1",
                            Type = @"Component",
                            Position = @"SPM.7.1",
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
                            Id = @"SPM.7.2",
                            Type = @"Component",
                            Position = @"SPM.7.2",
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
                            Id = @"SPM.7.3",
                            Type = @"Component",
                            Position = @"SPM.7.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.7.4",
                            Type = @"Component",
                            Position = @"SPM.7.4",
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
                            Id = @"SPM.7.5",
                            Type = @"Component",
                            Position = @"SPM.7.5",
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
                            Id = @"SPM.7.6",
                            Type = @"Component",
                            Position = @"SPM.7.6",
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
                            Id = @"SPM.7.7",
                            Type = @"Component",
                            Position = @"SPM.7.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.7.8",
                            Type = @"Component",
                            Position = @"SPM.7.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.7.9",
                            Type = @"Component",
                            Position = @"SPM.7.9",
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

        _specimenCollectionMethod = new HL7V25Field
        {
            field = message[@"SPM"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenCollectionMethod.field.FieldRepetitions != null && _specimenCollectionMethod.field.FieldRepetitions.Count > 0)
        {
            _specimenCollectionMethod.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenCollectionMethod, fieldData);
        }

        return _specimenCollectionMethod;
    } 
}

internal HL7V25Field _specimenSourceSite;

public HL7V25Field SpecimenSourceSite
{
    get
    {
        if (_specimenSourceSite != null)
        {
            return _specimenSourceSite;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.8",
            Type = @"Field",
            Position = @"SPM.8",
            Name = @"Specimen Source Site",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"specifies the source from which the specimen was obtained. For example, in the case where a liver biopsy is obtained via a percutaneous needle, the source would be liver.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.8.1",
                            Type = @"Component",
                            Position = @"SPM.8.1",
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
                            Id = @"SPM.8.2",
                            Type = @"Component",
                            Position = @"SPM.8.2",
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
                            Id = @"SPM.8.3",
                            Type = @"Component",
                            Position = @"SPM.8.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.8.4",
                            Type = @"Component",
                            Position = @"SPM.8.4",
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
                            Id = @"SPM.8.5",
                            Type = @"Component",
                            Position = @"SPM.8.5",
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
                            Id = @"SPM.8.6",
                            Type = @"Component",
                            Position = @"SPM.8.6",
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
                            Id = @"SPM.8.7",
                            Type = @"Component",
                            Position = @"SPM.8.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.8.8",
                            Type = @"Component",
                            Position = @"SPM.8.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.8.9",
                            Type = @"Component",
                            Position = @"SPM.8.9",
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

        _specimenSourceSite = new HL7V25Field
        {
            field = message[@"SPM"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenSourceSite.field.FieldRepetitions != null && _specimenSourceSite.field.FieldRepetitions.Count > 0)
        {
            _specimenSourceSite.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenSourceSite, fieldData);
        }

        return _specimenSourceSite;
    } 
}

internal HL7V25Field _specimenSourceSiteModifier;

public HL7V25Field SpecimenSourceSiteModifier
{
    get
    {
        if (_specimenSourceSiteModifier != null)
        {
            return _specimenSourceSiteModifier;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.9",
            Type = @"Field",
            Position = @"SPM.9",
            Name = @"Specimen Source Site Modifier",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0542",
            TableName = @"Specimen Source Type Modifier",
            Description = @"This field contains modifying or qualifying description(s) about the specimen source site",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.9.1",
                            Type = @"Component",
                            Position = @"SPM.9.1",
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
                            Id = @"SPM.9.2",
                            Type = @"Component",
                            Position = @"SPM.9.2",
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
                            Id = @"SPM.9.3",
                            Type = @"Component",
                            Position = @"SPM.9.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.9.4",
                            Type = @"Component",
                            Position = @"SPM.9.4",
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
                            Id = @"SPM.9.5",
                            Type = @"Component",
                            Position = @"SPM.9.5",
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
                            Id = @"SPM.9.6",
                            Type = @"Component",
                            Position = @"SPM.9.6",
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
                            Id = @"SPM.9.7",
                            Type = @"Component",
                            Position = @"SPM.9.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.9.8",
                            Type = @"Component",
                            Position = @"SPM.9.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.9.9",
                            Type = @"Component",
                            Position = @"SPM.9.9",
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

        _specimenSourceSiteModifier = new HL7V25Field
        {
            field = message[@"SPM"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenSourceSiteModifier.field.FieldRepetitions != null && _specimenSourceSiteModifier.field.FieldRepetitions.Count > 0)
        {
            _specimenSourceSiteModifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenSourceSiteModifier, fieldData);
        }

        return _specimenSourceSiteModifier;
    } 
}

internal HL7V25Field _specimenCollectionSite;

public HL7V25Field SpecimenCollectionSite
{
    get
    {
        if (_specimenCollectionSite != null)
        {
            return _specimenCollectionSite;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.10",
            Type = @"Field",
            Position = @"SPM.10",
            Name = @"Specimen Collection Site",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0543",
            TableName = @"Specimen Collection Site",
            Description = @"This field differs from SPM-8-Specimen Source Site in those cases where the source site must be approached via a particular site (e.g., anatomic location). For example, in the case where a liver biopsy is obtained via a percutaneous needle, the collection site would be the point of entry of the needle. For venous blood collected from the left radial vein, the collection site could be antecubital fossa.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.10.1",
                            Type = @"Component",
                            Position = @"SPM.10.1",
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
                            Id = @"SPM.10.2",
                            Type = @"Component",
                            Position = @"SPM.10.2",
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
                            Id = @"SPM.10.3",
                            Type = @"Component",
                            Position = @"SPM.10.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.10.4",
                            Type = @"Component",
                            Position = @"SPM.10.4",
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
                            Id = @"SPM.10.5",
                            Type = @"Component",
                            Position = @"SPM.10.5",
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
                            Id = @"SPM.10.6",
                            Type = @"Component",
                            Position = @"SPM.10.6",
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
                            Id = @"SPM.10.7",
                            Type = @"Component",
                            Position = @"SPM.10.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.10.8",
                            Type = @"Component",
                            Position = @"SPM.10.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.10.9",
                            Type = @"Component",
                            Position = @"SPM.10.9",
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

        _specimenCollectionSite = new HL7V25Field
        {
            field = message[@"SPM"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenCollectionSite.field.FieldRepetitions != null && _specimenCollectionSite.field.FieldRepetitions.Count > 0)
        {
            _specimenCollectionSite.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenCollectionSite, fieldData);
        }

        return _specimenCollectionSite;
    } 
}

internal HL7V25Field _specimenRole;

public HL7V25Field SpecimenRole
{
    get
    {
        if (_specimenRole != null)
        {
            return _specimenRole;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.11",
            Type = @"Field",
            Position = @"SPM.11",
            Name = @"Specimen Role",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0369",
            TableName = @"Specimen Role",
            Description = @"This field indicates the role of the sample. Refer to User-defined Table 0369 – Specimen role for suggested values. Each of these values is normally identifiable by the systems and its components and can influence processing and data management related to the specimen.  ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.11.1",
                            Type = @"Component",
                            Position = @"SPM.11.1",
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
                            Id = @"SPM.11.2",
                            Type = @"Component",
                            Position = @"SPM.11.2",
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
                            Id = @"SPM.11.3",
                            Type = @"Component",
                            Position = @"SPM.11.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.11.4",
                            Type = @"Component",
                            Position = @"SPM.11.4",
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
                            Id = @"SPM.11.5",
                            Type = @"Component",
                            Position = @"SPM.11.5",
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
                            Id = @"SPM.11.6",
                            Type = @"Component",
                            Position = @"SPM.11.6",
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
                            Id = @"SPM.11.7",
                            Type = @"Component",
                            Position = @"SPM.11.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.11.8",
                            Type = @"Component",
                            Position = @"SPM.11.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.11.9",
                            Type = @"Component",
                            Position = @"SPM.11.9",
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

        _specimenRole = new HL7V25Field
        {
            field = message[@"SPM"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenRole.field.FieldRepetitions != null && _specimenRole.field.FieldRepetitions.Count > 0)
        {
            _specimenRole.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenRole, fieldData);
        }

        return _specimenRole;
    } 
}

internal HL7V25Field _specimenCollectionAmount;

public HL7V25Field SpecimenCollectionAmount
{
    get
    {
        if (_specimenCollectionAmount != null)
        {
            return _specimenCollectionAmount;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.12",
            Type = @"Field",
            Position = @"SPM.12",
            Name = @"Specimen Collection Amount",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the volume or mass of the collected specimen. For laboratory tests, the collection volume is the volume of a specimen. Specifically, units should be expressed in the ISO Standard unit abbreviations (ISO-2955, 1977). This is a results-only field except when the placer or a party has already drawn the specimen.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.12.1",
                            Type = @"Component",
                            Position = @"SPM.12.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric quantity or amount of an entity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.12.2",
                            Type = @"Component",
                            Position = @"SPM.12.2",
                            Name = @"Units",
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the quantity is measured in the default units, the units need not be transmitted. If the quantity is recorded in units different from the default, the units must be transmitted.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.12.2.1",
                            Type = @"SubComponent",
                            Position = @"SPM.12.2.1",
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
                            Id = @"SPM.12.2.2",
                            Type = @"SubComponent",
                            Position = @"SPM.12.2.2",
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
                            Id = @"SPM.12.2.3",
                            Type = @"SubComponent",
                            Position = @"SPM.12.2.3",
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
                            Id = @"SPM.12.2.4",
                            Type = @"SubComponent",
                            Position = @"SPM.12.2.4",
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
                            Id = @"SPM.12.2.5",
                            Type = @"SubComponent",
                            Position = @"SPM.12.2.5",
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
                            Id = @"SPM.12.2.6",
                            Type = @"SubComponent",
                            Position = @"SPM.12.2.6",
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
                        },}
                        },
                        }
        }

        _specimenCollectionAmount = new HL7V25Field
        {
            field = message[@"SPM"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenCollectionAmount.field.FieldRepetitions != null && _specimenCollectionAmount.field.FieldRepetitions.Count > 0)
        {
            _specimenCollectionAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenCollectionAmount, fieldData);
        }

        return _specimenCollectionAmount;
    } 
}

internal HL7V25Field _groupedSpecimenCount;

public HL7V25Field GroupedSpecimenCount
{
    get
    {
        if (_groupedSpecimenCount != null)
        {
            return _groupedSpecimenCount;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.13",
            Type = @"Field",
            Position = @"SPM.13",
            Name = @"Grouped Specimen Count",
            Length = 6,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field refers to the number of individual specimens of a particular type represented by this instance of a specimen. The use of this field is restricted to specimens upon which all specimen related attributes are identical. This field would only be valued if the specimen role attribute has the value G.",
            Sample = @"",
            Fields = null
        }

        _groupedSpecimenCount = new HL7V25Field
        {
            field = message[@"SPM"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_groupedSpecimenCount.field.FieldRepetitions != null && _groupedSpecimenCount.field.FieldRepetitions.Count > 0)
        {
            _groupedSpecimenCount.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_groupedSpecimenCount, fieldData);
        }

        return _groupedSpecimenCount;
    } 
}

internal HL7V25Field _specimenDescription;

public HL7V25Field SpecimenDescription
{
    get
    {
        if (_specimenDescription != null)
        {
            return _specimenDescription;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.14",
            Type = @"Field",
            Position = @"SPM.14",
            Name = @"Specimen Description",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This is a text field that allows additional information specifically about the specimen to be sent in the message",
            Sample = @"",
            Fields = null
        }

        _specimenDescription = new HL7V25Field
        {
            field = message[@"SPM"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenDescription.field.FieldRepetitions != null && _specimenDescription.field.FieldRepetitions.Count > 0)
        {
            _specimenDescription.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenDescription, fieldData);
        }

        return _specimenDescription;
    } 
}

internal HL7V25Field _specimenHandlingCode;

public HL7V25Field SpecimenHandlingCode
{
    get
    {
        if (_specimenHandlingCode != null)
        {
            return _specimenHandlingCode;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.15",
            Type = @"Field",
            Position = @"SPM.15",
            Name = @"Specimen Handling Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0376",
            TableName = @"Special Handling Code",
            Description = @"This describes how the specimen and/or container need to be handled from the time of collection through the initiation of testing. As this field is not required, no assumptions can be made as to meaning when this field is not populated.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.15.1",
                            Type = @"Component",
                            Position = @"SPM.15.1",
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
                            Id = @"SPM.15.2",
                            Type = @"Component",
                            Position = @"SPM.15.2",
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
                            Id = @"SPM.15.3",
                            Type = @"Component",
                            Position = @"SPM.15.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.15.4",
                            Type = @"Component",
                            Position = @"SPM.15.4",
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
                            Id = @"SPM.15.5",
                            Type = @"Component",
                            Position = @"SPM.15.5",
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
                            Id = @"SPM.15.6",
                            Type = @"Component",
                            Position = @"SPM.15.6",
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
                            Id = @"SPM.15.7",
                            Type = @"Component",
                            Position = @"SPM.15.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.15.8",
                            Type = @"Component",
                            Position = @"SPM.15.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.15.9",
                            Type = @"Component",
                            Position = @"SPM.15.9",
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

        _specimenHandlingCode = new HL7V25Field
        {
            field = message[@"SPM"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenHandlingCode.field.FieldRepetitions != null && _specimenHandlingCode.field.FieldRepetitions.Count > 0)
        {
            _specimenHandlingCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenHandlingCode, fieldData);
        }

        return _specimenHandlingCode;
    } 
}

internal HL7V25Field _specimenRiskCode;

public HL7V25Field SpecimenRiskCode
{
    get
    {
        if (_specimenRiskCode != null)
        {
            return _specimenRiskCode;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.16",
            Type = @"Field",
            Position = @"SPM.16",
            Name = @"Specimen Risk Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0489",
            TableName = @"Risk Codes",
            Description = @"This field contains any known or suspected specimen hazards, e.g., exceptionally infectious agent or blood from a hepatitis patient. Either code and/or text may be absent. However, the code is always placed in the first component position and any free text in the second component. Thus, a component delimiter must precede free text without a code. Refer to User-defined Table 0489 - Risk Codes for suggested entries",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.16.1",
                            Type = @"Component",
                            Position = @"SPM.16.1",
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
                            Id = @"SPM.16.2",
                            Type = @"Component",
                            Position = @"SPM.16.2",
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
                            Id = @"SPM.16.3",
                            Type = @"Component",
                            Position = @"SPM.16.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.16.4",
                            Type = @"Component",
                            Position = @"SPM.16.4",
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
                            Id = @"SPM.16.5",
                            Type = @"Component",
                            Position = @"SPM.16.5",
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
                            Id = @"SPM.16.6",
                            Type = @"Component",
                            Position = @"SPM.16.6",
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
                            Id = @"SPM.16.7",
                            Type = @"Component",
                            Position = @"SPM.16.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.16.8",
                            Type = @"Component",
                            Position = @"SPM.16.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.16.9",
                            Type = @"Component",
                            Position = @"SPM.16.9",
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

        _specimenRiskCode = new HL7V25Field
        {
            field = message[@"SPM"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenRiskCode.field.FieldRepetitions != null && _specimenRiskCode.field.FieldRepetitions.Count > 0)
        {
            _specimenRiskCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenRiskCode, fieldData);
        }

        return _specimenRiskCode;
    } 
}

internal HL7V25Field _specimenCollectionDateTime;

public HL7V25Field SpecimenCollectionDateTime
{
    get
    {
        if (_specimenCollectionDateTime != null)
        {
            return _specimenCollectionDateTime;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.17",
            Type = @"Field",
            Position = @"SPM.17",
            Name = @"Specimen Collection Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DR",
            DataTypeName = @"Date/Time Range",
            TableId = null,
            TableName = null,
            Description = @"The date and time when the specimen was acquired from the source. The use of the Date Range data type allows for description of specimens collected over a period of time, for example, 24-hour urine collection. For specimens collected at a point in time, only the first component (start date/time) will be populated.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.17.1",
                            Type = @"Component",
                            Position = @"SPM.17.1",
                            Name = @"Range Start Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component contains the earliest date/time (time stamp) in the specified range.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.17.1.1",
                            Type = @"SubComponent",
                            Position = @"SPM.17.1.1",
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
                            Id = @"SPM.17.1.2",
                            Type = @"SubComponent",
                            Position = @"SPM.17.1.2",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.17.2",
                            Type = @"Component",
                            Position = @"SPM.17.2",
                            Name = @"Range End Date/Time",
                            Length = 26,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the latest date/time in the specified range. Note that the TS (time stamp) data type allows the specification of precision.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.17.2.1",
                            Type = @"SubComponent",
                            Position = @"SPM.17.2.1",
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
                            Id = @"SPM.17.2.2",
                            Type = @"SubComponent",
                            Position = @"SPM.17.2.2",
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
                        },}
                        },
                        }
        }

        _specimenCollectionDateTime = new HL7V25Field
        {
            field = message[@"SPM"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenCollectionDateTime.field.FieldRepetitions != null && _specimenCollectionDateTime.field.FieldRepetitions.Count > 0)
        {
            _specimenCollectionDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenCollectionDateTime, fieldData);
        }

        return _specimenCollectionDateTime;
    } 
}

internal HL7V25Field _specimenReceivedDateTime;

public HL7V25Field SpecimenReceivedDateTime
{
    get
    {
        if (_specimenReceivedDateTime != null)
        {
            return _specimenReceivedDateTime;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.18",
            Type = @"Field",
            Position = @"SPM.18",
            Name = @"Specimen Received Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"The specimen received date/time is the time that the specimen is received at the diagnostic service. The actual time that is recorded is based on how specimen receipt is managed and may correspond to the time the sample is logged in. This is fundamentally different from SPM-xx Specimen Collection date/time.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.18.1",
                            Type = @"Component",
                            Position = @"SPM.18.1",
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
                            Id = @"SPM.18.2",
                            Type = @"Component",
                            Position = @"SPM.18.2",
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

        _specimenReceivedDateTime = new HL7V25Field
        {
            field = message[@"SPM"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenReceivedDateTime.field.FieldRepetitions != null && _specimenReceivedDateTime.field.FieldRepetitions.Count > 0)
        {
            _specimenReceivedDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenReceivedDateTime, fieldData);
        }

        return _specimenReceivedDateTime;
    } 
}

internal HL7V25Field _specimenExpirationDateTime;

public HL7V25Field SpecimenExpirationDateTime
{
    get
    {
        if (_specimenExpirationDateTime != null)
        {
            return _specimenExpirationDateTime;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.19",
            Type = @"Field",
            Position = @"SPM.19",
            Name = @"Specimen Expiration Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field is the date and time the specimen can no longer be used for the purpose implied by the order. For example, in the Blood Banking environment the specimen can no longer be used for pre-transfusion compatibility testing. The specimen segment will include an SPM-21-Specimen Reject Reason of 'EX' indicating 'Expired' for message instances created after this date and time.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.19.1",
                            Type = @"Component",
                            Position = @"SPM.19.1",
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
                            Id = @"SPM.19.2",
                            Type = @"Component",
                            Position = @"SPM.19.2",
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

        _specimenExpirationDateTime = new HL7V25Field
        {
            field = message[@"SPM"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenExpirationDateTime.field.FieldRepetitions != null && _specimenExpirationDateTime.field.FieldRepetitions.Count > 0)
        {
            _specimenExpirationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenExpirationDateTime, fieldData);
        }

        return _specimenExpirationDateTime;
    } 
}

internal HL7V25Field _specimenAvailability;

public HL7V25Field SpecimenAvailability
{
    get
    {
        if (_specimenAvailability != null)
        {
            return _specimenAvailability;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.20",
            Type = @"Field",
            Position = @"SPM.20",
            Name = @"Specimen Availability",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This describes whether the specimen, as it exists, is currently available to use in an analysis. Refer to HL7 Table 0136 Yes/No Indicator for valid values",
            Sample = @"",
            Fields = null
        }

        _specimenAvailability = new HL7V25Field
        {
            field = message[@"SPM"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenAvailability.field.FieldRepetitions != null && _specimenAvailability.field.FieldRepetitions.Count > 0)
        {
            _specimenAvailability.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenAvailability, fieldData);
        }

        return _specimenAvailability;
    } 
}

internal HL7V25Field _specimenRejectReason;

public HL7V25Field SpecimenRejectReason
{
    get
    {
        if (_specimenRejectReason != null)
        {
            return _specimenRejectReason;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.21",
            Type = @"Field",
            Position = @"SPM.21",
            Name = @"Specimen Reject Reason",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0490",
            TableName = @"Specimen Reject Reason",
            Description = @"This describes one or more reasons the specimen is rejected for the specified observation/result/analysis. Refer to HL7 Table 0490 - Specimen Reject Reason for valid values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.21.1",
                            Type = @"Component",
                            Position = @"SPM.21.1",
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
                            Id = @"SPM.21.2",
                            Type = @"Component",
                            Position = @"SPM.21.2",
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
                            Id = @"SPM.21.3",
                            Type = @"Component",
                            Position = @"SPM.21.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.21.4",
                            Type = @"Component",
                            Position = @"SPM.21.4",
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
                            Id = @"SPM.21.5",
                            Type = @"Component",
                            Position = @"SPM.21.5",
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
                            Id = @"SPM.21.6",
                            Type = @"Component",
                            Position = @"SPM.21.6",
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
                            Id = @"SPM.21.7",
                            Type = @"Component",
                            Position = @"SPM.21.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.21.8",
                            Type = @"Component",
                            Position = @"SPM.21.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.21.9",
                            Type = @"Component",
                            Position = @"SPM.21.9",
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

        _specimenRejectReason = new HL7V25Field
        {
            field = message[@"SPM"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenRejectReason.field.FieldRepetitions != null && _specimenRejectReason.field.FieldRepetitions.Count > 0)
        {
            _specimenRejectReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenRejectReason, fieldData);
        }

        return _specimenRejectReason;
    } 
}

internal HL7V25Field _specimenQuality;

public HL7V25Field SpecimenQuality
{
    get
    {
        if (_specimenQuality != null)
        {
            return _specimenQuality;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.22",
            Type = @"Field",
            Position = @"SPM.22",
            Name = @"Specimen Quality",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0491",
            TableName = @"Specimen Quality",
            Description = @"The degree or grade of excellence of the specimen at receipt. The filler populates this attribute. Refer to User-defined Table 0491 - Specimen Quality for suggested entries.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.22.1",
                            Type = @"Component",
                            Position = @"SPM.22.1",
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
                            Id = @"SPM.22.2",
                            Type = @"Component",
                            Position = @"SPM.22.2",
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
                            Id = @"SPM.22.3",
                            Type = @"Component",
                            Position = @"SPM.22.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.22.4",
                            Type = @"Component",
                            Position = @"SPM.22.4",
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
                            Id = @"SPM.22.5",
                            Type = @"Component",
                            Position = @"SPM.22.5",
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
                            Id = @"SPM.22.6",
                            Type = @"Component",
                            Position = @"SPM.22.6",
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
                            Id = @"SPM.22.7",
                            Type = @"Component",
                            Position = @"SPM.22.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.22.8",
                            Type = @"Component",
                            Position = @"SPM.22.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.22.9",
                            Type = @"Component",
                            Position = @"SPM.22.9",
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

        _specimenQuality = new HL7V25Field
        {
            field = message[@"SPM"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenQuality.field.FieldRepetitions != null && _specimenQuality.field.FieldRepetitions.Count > 0)
        {
            _specimenQuality.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenQuality, fieldData);
        }

        return _specimenQuality;
    } 
}

internal HL7V25Field _specimenAppropriateness;

public HL7V25Field SpecimenAppropriateness
{
    get
    {
        if (_specimenAppropriateness != null)
        {
            return _specimenAppropriateness;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.23",
            Type = @"Field",
            Position = @"SPM.23",
            Name = @"Specimen Appropriateness",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0492",
            TableName = @"Specimen Appropriateness",
            Description = @"The suitability of the specimen for the particular planned use as determined by the filler. Refer to User-defined Table 0492 - Specimen Appropriateness for suggested entries.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.23.1",
                            Type = @"Component",
                            Position = @"SPM.23.1",
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
                            Id = @"SPM.23.2",
                            Type = @"Component",
                            Position = @"SPM.23.2",
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
                            Id = @"SPM.23.3",
                            Type = @"Component",
                            Position = @"SPM.23.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.23.4",
                            Type = @"Component",
                            Position = @"SPM.23.4",
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
                            Id = @"SPM.23.5",
                            Type = @"Component",
                            Position = @"SPM.23.5",
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
                            Id = @"SPM.23.6",
                            Type = @"Component",
                            Position = @"SPM.23.6",
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
                            Id = @"SPM.23.7",
                            Type = @"Component",
                            Position = @"SPM.23.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.23.8",
                            Type = @"Component",
                            Position = @"SPM.23.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.23.9",
                            Type = @"Component",
                            Position = @"SPM.23.9",
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

        _specimenAppropriateness = new HL7V25Field
        {
            field = message[@"SPM"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenAppropriateness.field.FieldRepetitions != null && _specimenAppropriateness.field.FieldRepetitions.Count > 0)
        {
            _specimenAppropriateness.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenAppropriateness, fieldData);
        }

        return _specimenAppropriateness;
    } 
}

internal HL7V25Field _specimenCondition;

public HL7V25Field SpecimenCondition
{
    get
    {
        if (_specimenCondition != null)
        {
            return _specimenCondition;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.24",
            Type = @"Field",
            Position = @"SPM.24",
            Name = @"Specimen Condition",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0493",
            TableName = @"Specimen Condition",
            Description = @"A mode or state of being that describes the nature of the specimen. Refer to User-defined Table 0493 - Specimen Condition for suggested entries.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.24.1",
                            Type = @"Component",
                            Position = @"SPM.24.1",
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
                            Id = @"SPM.24.2",
                            Type = @"Component",
                            Position = @"SPM.24.2",
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
                            Id = @"SPM.24.3",
                            Type = @"Component",
                            Position = @"SPM.24.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.24.4",
                            Type = @"Component",
                            Position = @"SPM.24.4",
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
                            Id = @"SPM.24.5",
                            Type = @"Component",
                            Position = @"SPM.24.5",
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
                            Id = @"SPM.24.6",
                            Type = @"Component",
                            Position = @"SPM.24.6",
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
                            Id = @"SPM.24.7",
                            Type = @"Component",
                            Position = @"SPM.24.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.24.8",
                            Type = @"Component",
                            Position = @"SPM.24.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.24.9",
                            Type = @"Component",
                            Position = @"SPM.24.9",
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

        _specimenCondition = new HL7V25Field
        {
            field = message[@"SPM"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenCondition.field.FieldRepetitions != null && _specimenCondition.field.FieldRepetitions.Count > 0)
        {
            _specimenCondition.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenCondition, fieldData);
        }

        return _specimenCondition;
    } 
}

internal HL7V25Field _specimenCurrentQuantity;

public HL7V25Field SpecimenCurrentQuantity
{
    get
    {
        if (_specimenCurrentQuantity != null)
        {
            return _specimenCurrentQuantity;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.25",
            Type = @"Field",
            Position = @"SPM.25",
            Name = @"Specimen Current Quantity",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity with Units",
            TableId = null,
            TableName = null,
            Description = @"This attributes contains the amount of specimen that currently exists or is available for use in further testing.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.25.1",
                            Type = @"Component",
                            Position = @"SPM.25.1",
                            Name = @"Quantity",
                            Length = 16,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This component specifies the numeric quantity or amount of an entity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.25.2",
                            Type = @"Component",
                            Position = @"SPM.25.2",
                            Name = @"Units",
                            Length = 483,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This component species the units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the quantity is measured in the default units, the units need not be transmitted. If the quantity is recorded in units different from the default, the units must be transmitted.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"SPM.25.2.1",
                            Type = @"SubComponent",
                            Position = @"SPM.25.2.1",
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
                            Id = @"SPM.25.2.2",
                            Type = @"SubComponent",
                            Position = @"SPM.25.2.2",
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
                            Id = @"SPM.25.2.3",
                            Type = @"SubComponent",
                            Position = @"SPM.25.2.3",
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
                            Id = @"SPM.25.2.4",
                            Type = @"SubComponent",
                            Position = @"SPM.25.2.4",
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
                            Id = @"SPM.25.2.5",
                            Type = @"SubComponent",
                            Position = @"SPM.25.2.5",
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
                            Id = @"SPM.25.2.6",
                            Type = @"SubComponent",
                            Position = @"SPM.25.2.6",
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
                        },}
                        },
                        }
        }

        _specimenCurrentQuantity = new HL7V25Field
        {
            field = message[@"SPM"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenCurrentQuantity.field.FieldRepetitions != null && _specimenCurrentQuantity.field.FieldRepetitions.Count > 0)
        {
            _specimenCurrentQuantity.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenCurrentQuantity, fieldData);
        }

        return _specimenCurrentQuantity;
    } 
}

internal HL7V25Field _numberofSpecimenContainers;

public HL7V25Field NumberofSpecimenContainers
{
    get
    {
        if (_numberofSpecimenContainers != null)
        {
            return _numberofSpecimenContainers;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.26",
            Type = @"Field",
            Position = @"SPM.26",
            Name = @"Number of Specimen Containers",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the number of containers for a given sample. For sample receipt verification purposes; may be different from the total number of samples that accompany the order.",
            Sample = @"",
            Fields = null
        }

        _numberofSpecimenContainers = new HL7V25Field
        {
            field = message[@"SPM"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_numberofSpecimenContainers.field.FieldRepetitions != null && _numberofSpecimenContainers.field.FieldRepetitions.Count > 0)
        {
            _numberofSpecimenContainers.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_numberofSpecimenContainers, fieldData);
        }

        return _numberofSpecimenContainers;
    } 
}

internal HL7V25Field _containerType;

public HL7V25Field ContainerType
{
    get
    {
        if (_containerType != null)
        {
            return _containerType;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.27",
            Type = @"Field",
            Position = @"SPM.27",
            Name = @"Container Type",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"The container in or on which a specimen is transported",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.27.1",
                            Type = @"Component",
                            Position = @"SPM.27.1",
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
                            Id = @"SPM.27.2",
                            Type = @"Component",
                            Position = @"SPM.27.2",
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
                            Id = @"SPM.27.3",
                            Type = @"Component",
                            Position = @"SPM.27.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.27.4",
                            Type = @"Component",
                            Position = @"SPM.27.4",
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
                            Id = @"SPM.27.5",
                            Type = @"Component",
                            Position = @"SPM.27.5",
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
                            Id = @"SPM.27.6",
                            Type = @"Component",
                            Position = @"SPM.27.6",
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
                            Id = @"SPM.27.7",
                            Type = @"Component",
                            Position = @"SPM.27.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.27.8",
                            Type = @"Component",
                            Position = @"SPM.27.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.27.9",
                            Type = @"Component",
                            Position = @"SPM.27.9",
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

        _containerType = new HL7V25Field
        {
            field = message[@"SPM"][27],
            fieldData = fieldData
        };

        // check for repetitions
        if (_containerType.field.FieldRepetitions != null && _containerType.field.FieldRepetitions.Count > 0)
        {
            _containerType.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_containerType, fieldData);
        }

        return _containerType;
    } 
}

internal HL7V25Field _containerCondition;

public HL7V25Field ContainerCondition
{
    get
    {
        if (_containerCondition != null)
        {
            return _containerCondition;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.28",
            Type = @"Field",
            Position = @"SPM.28",
            Name = @"Container Condition",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0544",
            TableName = @"Container Condition",
            Description = @"In chain of custody cases where specimens are moved from lab to lab, the status of the container that the specimen is shipped in must be recorded at each receipt. If the container is compromised in any way (seal broken, container cracked or leaking, etc) then this needs to be recorded for legal reasons.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.28.1",
                            Type = @"Component",
                            Position = @"SPM.28.1",
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
                            Id = @"SPM.28.2",
                            Type = @"Component",
                            Position = @"SPM.28.2",
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
                            Id = @"SPM.28.3",
                            Type = @"Component",
                            Position = @"SPM.28.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.28.4",
                            Type = @"Component",
                            Position = @"SPM.28.4",
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
                            Id = @"SPM.28.5",
                            Type = @"Component",
                            Position = @"SPM.28.5",
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
                            Id = @"SPM.28.6",
                            Type = @"Component",
                            Position = @"SPM.28.6",
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
                            Id = @"SPM.28.7",
                            Type = @"Component",
                            Position = @"SPM.28.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.28.8",
                            Type = @"Component",
                            Position = @"SPM.28.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.28.9",
                            Type = @"Component",
                            Position = @"SPM.28.9",
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

        _containerCondition = new HL7V25Field
        {
            field = message[@"SPM"][28],
            fieldData = fieldData
        };

        // check for repetitions
        if (_containerCondition.field.FieldRepetitions != null && _containerCondition.field.FieldRepetitions.Count > 0)
        {
            _containerCondition.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_containerCondition, fieldData);
        }

        return _containerCondition;
    } 
}

internal HL7V25Field _specimenChildRole;

public HL7V25Field SpecimenChildRole
{
    get
    {
        if (_specimenChildRole != null)
        {
            return _specimenChildRole;
        }

        var fieldData = new HL7V25FieldData
        {
            Id = @"SPM.29",
            Type = @"Field",
            Position = @"SPM.29",
            Name = @"Specimen Child Role",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0494",
            TableName = @"Specimen Child Role",
            Description = @"For child specimens, this field identifies the relationship between this specimen and the parent specimen. If this field is populated, then SPM-3-Specimen Parent ID must be populated. This field differs from SPM-15-Specimen Role in that this field refers to the role of this specimen relative to a parent role rather than the role of this specimen to the ordered service.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"SPM.29.1",
                            Type = @"Component",
                            Position = @"SPM.29.1",
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
                            Id = @"SPM.29.2",
                            Type = @"Component",
                            Position = @"SPM.29.2",
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
                            Id = @"SPM.29.3",
                            Type = @"Component",
                            Position = @"SPM.29.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the identifier component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.29.4",
                            Type = @"Component",
                            Position = @"SPM.29.4",
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
                            Id = @"SPM.29.5",
                            Type = @"Component",
                            Position = @"SPM.29.5",
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
                            Id = @"SPM.29.6",
                            Type = @"Component",
                            Position = @"SPM.29.6",
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
                            Id = @"SPM.29.7",
                            Type = @"Component",
                            Position = @"SPM.29.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 1-3. It belongs conceptually to the group of component 1-3 and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.29.8",
                            Type = @"Component",
                            Position = @"SPM.29.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is the version ID for the coding system identified by components 4-6. It belongs conceptually to the group of alternate components (See usage note in section introduction) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"SPM.29.9",
                            Type = @"Component",
                            Position = @"SPM.29.9",
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

        _specimenChildRole = new HL7V25Field
        {
            field = message[@"SPM"][29],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenChildRole.field.FieldRepetitions != null && _specimenChildRole.field.FieldRepetitions.Count > 0)
        {
            _specimenChildRole.fieldRepetitions = HL7V2FieldGenerator.GenerateV25FieldRepetitions(_specimenChildRole, fieldData);
        }

        return _specimenChildRole;
    } 
}
    }
}
