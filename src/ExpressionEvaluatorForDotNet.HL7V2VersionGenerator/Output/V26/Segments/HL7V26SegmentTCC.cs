using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V26SegmentTCC
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"TCC"; } }

        public string SegmentId { get { return @"TCC"; } }
        
        public string LongName { get { return @"Test Code Configuration"; } }
        
        public string Description { get { return @"The test (e.g., analyte) code configuration segment is the data necessary to maintain and transmit information concerning the test entity codes that are being used throughout the ""automated system."""; } }
        
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

        public HL7V26SegmentTCC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V26Field _universalServiceIdentifier;

public HL7V26Field UniversalServiceIdentifier
{
    get
    {
        if (_universalServiceIdentifier != null)
        {
            return _universalServiceIdentifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"TCC.1",
            Type = @"Field",
            Position = @"TCC.1",
            Name = @"Universal Service Identifier",
            Length = 705,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the test code that information is being transmitted about. The alternate elements represent the test code identifier that has been assigned by the manufacturer to this particular test code.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"TCC.1.1",
                            Type = @"Component",
                            Position = @"TCC.1.1",
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
                            Id = @"TCC.1.2",
                            Type = @"Component",
                            Position = @"TCC.1.2",
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
                            Id = @"TCC.1.3",
                            Type = @"Component",
                            Position = @"TCC.1.3",
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
                            Id = @"TCC.1.4",
                            Type = @"Component",
                            Position = @"TCC.1.4",
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
                            Id = @"TCC.1.5",
                            Type = @"Component",
                            Position = @"TCC.1.5",
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
                            Id = @"TCC.1.6",
                            Type = @"Component",
                            Position = @"TCC.1.6",
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
                            Id = @"TCC.1.7",
                            Type = @"Component",
                            Position = @"TCC.1.7",
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
                            Id = @"TCC.1.8",
                            Type = @"Component",
                            Position = @"TCC.1.8",
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
                            Id = @"TCC.1.9",
                            Type = @"Component",
                            Position = @"TCC.1.9",
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

        _universalServiceIdentifier = new HL7V26Field
        {
            field = message[@"TCC"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_universalServiceIdentifier.field.FieldRepetitions != null && _universalServiceIdentifier.field.FieldRepetitions.Count > 0)
        {
            _universalServiceIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_universalServiceIdentifier, fieldData);
        }

        return _universalServiceIdentifier;
    } 
}

internal HL7V26Field _equipmentTestApplicationIdentifier;

public HL7V26Field EquipmentTestApplicationIdentifier
{
    get
    {
        if (_equipmentTestApplicationIdentifier != null)
        {
            return _equipmentTestApplicationIdentifier;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"TCC.2",
            Type = @"Field",
            Position = @"TCC.2",
            Name = @"Equipment Test Application Identifier",
            Length = 427,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the test application code assigned by the manufacturer of the equipment or reagents and associated with performing of the particular test specified by the Universal Test Identifier.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"TCC.2.1",
                            Type = @"Component",
                            Position = @"TCC.2.1",
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
                            Id = @"TCC.2.2",
                            Type = @"Component",
                            Position = @"TCC.2.2",
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
                            Id = @"TCC.2.3",
                            Type = @"Component",
                            Position = @"TCC.2.3",
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
                            Id = @"TCC.2.4",
                            Type = @"Component",
                            Position = @"TCC.2.4",
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
                        },
                        }
        }

        _equipmentTestApplicationIdentifier = new HL7V26Field
        {
            field = message[@"TCC"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_equipmentTestApplicationIdentifier.field.FieldRepetitions != null && _equipmentTestApplicationIdentifier.field.FieldRepetitions.Count > 0)
        {
            _equipmentTestApplicationIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_equipmentTestApplicationIdentifier, fieldData);
        }

        return _equipmentTestApplicationIdentifier;
    } 
}

internal HL7V26Field _specimenSource;

public HL7V26Field SpecimenSource
{
    get
    {
        if (_specimenSource != null)
        {
            return _specimenSource;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"TCC.3",
            Type = @"Field",
            Position = @"TCC.3",
            Name = @"Specimen Source",
            Length = 300,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"SPS",
            DataTypeName = @"Specimen Source",
            TableId = null,
            TableName = null,
            Description = @"This field is the site where the specimen should be obtained or where the service should be performed.

As of version 2.5 this field is deprecated and retained for backward compatibility only. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"TCC.3.1",
                            Type = @"Component",
                            Position = @"TCC.3.1",
                            Name = @"Specimen Source Name Or Code",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"contains the specimen source name or code (as a CWE data type component). (Even in the case of observations whose name implies the source, a source may be required, e.g., blood culture-heart blood.)",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TCC.3.1.1",
                            Type = @"SubComponent",
                            Position = @"TCC.3.1.1",
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
                            Id = @"TCC.3.1.2",
                            Type = @"SubComponent",
                            Position = @"TCC.3.1.2",
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
                            Id = @"TCC.3.1.3",
                            Type = @"SubComponent",
                            Position = @"TCC.3.1.3",
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
                            Id = @"TCC.3.1.4",
                            Type = @"SubComponent",
                            Position = @"TCC.3.1.4",
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
                            Id = @"TCC.3.1.5",
                            Type = @"SubComponent",
                            Position = @"TCC.3.1.5",
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
                            Id = @"TCC.3.1.6",
                            Type = @"SubComponent",
                            Position = @"TCC.3.1.6",
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
                            Id = @"TCC.3.1.7",
                            Type = @"SubComponent",
                            Position = @"TCC.3.1.7",
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
                            Id = @"TCC.3.1.8",
                            Type = @"SubComponent",
                            Position = @"TCC.3.1.8",
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
                            Id = @"TCC.3.1.9",
                            Type = @"SubComponent",
                            Position = @"TCC.3.1.9",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCC.3.2",
                            Type = @"Component",
                            Position = @"TCC.3.2",
                            Name = @"Additives",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0371",
                            TableName = @"Additive/Preservative",
                            Description = @"identifies an additive introduced to the specimen before or at the time of collection. Refer to HL7 Table0371 - Additive in chapter 7 for valid values. The tables values are taken from NCCLS AUTO4. The value set can be extended with user specific values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TCC.3.2.1",
                            Type = @"SubComponent",
                            Position = @"TCC.3.2.1",
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
                            Id = @"TCC.3.2.2",
                            Type = @"SubComponent",
                            Position = @"TCC.3.2.2",
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
                            Id = @"TCC.3.2.3",
                            Type = @"SubComponent",
                            Position = @"TCC.3.2.3",
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
                            Id = @"TCC.3.2.4",
                            Type = @"SubComponent",
                            Position = @"TCC.3.2.4",
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
                            Id = @"TCC.3.2.5",
                            Type = @"SubComponent",
                            Position = @"TCC.3.2.5",
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
                            Id = @"TCC.3.2.6",
                            Type = @"SubComponent",
                            Position = @"TCC.3.2.6",
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
                            Id = @"TCC.3.2.7",
                            Type = @"SubComponent",
                            Position = @"TCC.3.2.7",
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
                            Id = @"TCC.3.2.8",
                            Type = @"SubComponent",
                            Position = @"TCC.3.2.8",
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
                            Id = @"TCC.3.2.9",
                            Type = @"SubComponent",
                            Position = @"TCC.3.2.9",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCC.3.3",
                            Type = @"Component",
                            Position = @"TCC.3.3",
                            Name = @"Specimen Collection Method",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"describes the method of collection when that information is a part of the order. When the method of collection is logically an observation result, it should be included as a result segment (i.e., OBX segment).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCC.3.4",
                            Type = @"Component",
                            Position = @"TCC.3.4",
                            Name = @"Body Site",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0163",
                            TableName = @"Body site",
                            Description = @"This component specifies the body site from which the specimen was obtained. A nationally recognized coding system is to be used for this field. Valid coding sources for this field include:",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TCC.3.4.1",
                            Type = @"SubComponent",
                            Position = @"TCC.3.4.1",
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
                            Id = @"TCC.3.4.2",
                            Type = @"SubComponent",
                            Position = @"TCC.3.4.2",
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
                            Id = @"TCC.3.4.3",
                            Type = @"SubComponent",
                            Position = @"TCC.3.4.3",
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
                            Id = @"TCC.3.4.4",
                            Type = @"SubComponent",
                            Position = @"TCC.3.4.4",
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
                            Id = @"TCC.3.4.5",
                            Type = @"SubComponent",
                            Position = @"TCC.3.4.5",
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
                            Id = @"TCC.3.4.6",
                            Type = @"SubComponent",
                            Position = @"TCC.3.4.6",
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
                            Id = @"TCC.3.4.7",
                            Type = @"SubComponent",
                            Position = @"TCC.3.4.7",
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
                            Id = @"TCC.3.4.8",
                            Type = @"SubComponent",
                            Position = @"TCC.3.4.8",
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
                            Id = @"TCC.3.4.9",
                            Type = @"SubComponent",
                            Position = @"TCC.3.4.9",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCC.3.5",
                            Type = @"Component",
                            Position = @"TCC.3.5",
                            Name = @"Site Modifier",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0495",
                            TableName = @"Body Site Modifier",
                            Description = @"modifies body site. For example, the site could be antecubital fossa, and the site modifier right. Refer to HL7 Table 0495 - Body Site Modifier for allowed values.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TCC.3.5.1",
                            Type = @"SubComponent",
                            Position = @"TCC.3.5.1",
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
                            Id = @"TCC.3.5.2",
                            Type = @"SubComponent",
                            Position = @"TCC.3.5.2",
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
                            Id = @"TCC.3.5.3",
                            Type = @"SubComponent",
                            Position = @"TCC.3.5.3",
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
                            Id = @"TCC.3.5.4",
                            Type = @"SubComponent",
                            Position = @"TCC.3.5.4",
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
                            Id = @"TCC.3.5.5",
                            Type = @"SubComponent",
                            Position = @"TCC.3.5.5",
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
                            Id = @"TCC.3.5.6",
                            Type = @"SubComponent",
                            Position = @"TCC.3.5.6",
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
                            Id = @"TCC.3.5.7",
                            Type = @"SubComponent",
                            Position = @"TCC.3.5.7",
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
                            Id = @"TCC.3.5.8",
                            Type = @"SubComponent",
                            Position = @"TCC.3.5.8",
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
                            Id = @"TCC.3.5.9",
                            Type = @"SubComponent",
                            Position = @"TCC.3.5.9",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCC.3.6",
                            Type = @"Component",
                            Position = @"TCC.3.6",
                            Name = @"Collection Method Modifier Code",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = null,
                            TableName = null,
                            Description = @"Indicates whether the specimen is frozen as part of the collection method. Suggested values are F (Frozen); R (Refrigerated). If the component is blank, the specimen is assumed to be at room temperature.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TCC.3.6.1",
                            Type = @"SubComponent",
                            Position = @"TCC.3.6.1",
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
                            Id = @"TCC.3.6.2",
                            Type = @"SubComponent",
                            Position = @"TCC.3.6.2",
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
                            Id = @"TCC.3.6.3",
                            Type = @"SubComponent",
                            Position = @"TCC.3.6.3",
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
                            Id = @"TCC.3.6.4",
                            Type = @"SubComponent",
                            Position = @"TCC.3.6.4",
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
                            Id = @"TCC.3.6.5",
                            Type = @"SubComponent",
                            Position = @"TCC.3.6.5",
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
                            Id = @"TCC.3.6.6",
                            Type = @"SubComponent",
                            Position = @"TCC.3.6.6",
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
                            Id = @"TCC.3.6.7",
                            Type = @"SubComponent",
                            Position = @"TCC.3.6.7",
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
                            Id = @"TCC.3.6.8",
                            Type = @"SubComponent",
                            Position = @"TCC.3.6.8",
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
                            Id = @"TCC.3.6.9",
                            Type = @"SubComponent",
                            Position = @"TCC.3.6.9",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCC.3.7",
                            Type = @"Component",
                            Position = @"TCC.3.7",
                            Name = @"Specimen Role",
                            Length = 705,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CWE",
                            DataTypeName = @"Coded with Exceptions",
                            TableId = @"0369",
                            TableName = @"Specimen Role",
                            Description = @"indicates the role of the sample. Refer to User-defined Table 0369 - Specimen role for suggested values. Each of these values is normally identifiable by the systems and its components and can influence processing and data management related to the specimen.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"TCC.3.7.1",
                            Type = @"SubComponent",
                            Position = @"TCC.3.7.1",
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
                            Id = @"TCC.3.7.2",
                            Type = @"SubComponent",
                            Position = @"TCC.3.7.2",
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
                            Id = @"TCC.3.7.3",
                            Type = @"SubComponent",
                            Position = @"TCC.3.7.3",
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
                            Id = @"TCC.3.7.4",
                            Type = @"SubComponent",
                            Position = @"TCC.3.7.4",
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
                            Id = @"TCC.3.7.5",
                            Type = @"SubComponent",
                            Position = @"TCC.3.7.5",
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
                            Id = @"TCC.3.7.6",
                            Type = @"SubComponent",
                            Position = @"TCC.3.7.6",
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
                            Id = @"TCC.3.7.7",
                            Type = @"SubComponent",
                            Position = @"TCC.3.7.7",
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
                            Id = @"TCC.3.7.8",
                            Type = @"SubComponent",
                            Position = @"TCC.3.7.8",
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
                            Id = @"TCC.3.7.9",
                            Type = @"SubComponent",
                            Position = @"TCC.3.7.9",
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
                        },}
                        },
                        }
        }

        _specimenSource = new HL7V26Field
        {
            field = message[@"TCC"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenSource.field.FieldRepetitions != null && _specimenSource.field.FieldRepetitions.Count > 0)
        {
            _specimenSource.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_specimenSource, fieldData);
        }

        return _specimenSource;
    } 
}

internal HL7V26Field _autoDilutionFactorDefault;

public HL7V26Field AutoDilutionFactorDefault
{
    get
    {
        if (_autoDilutionFactorDefault != null)
        {
            return _autoDilutionFactorDefault;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"TCC.4",
            Type = @"Field",
            Position = @"TCC.4",
            Name = @"Auto-Dilution Factor Default",
            Length = 36,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SN",
            DataTypeName = @"Structured Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the value that is to be used as the default factor for automatically diluting a specimen by an instrument for this particular test code. (See examples in definition of 13.4.3.29, "" SAC-29 Dilution Factor(SN) 01356"" in, ""Specimen Container Detail Segment."")",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"TCC.4.1",
                            Type = @"Component",
                            Position = @"TCC.4.1",
                            Name = @"Comparator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as greater than, less than, greater than or equal, less than or equal, equal, and not equal, respectively (= "">"" or ""<"" or "">="" or ""<="" or ""="" or ""<>""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCC.4.2",
                            Type = @"Component",
                            Position = @"TCC.4.2",
                            Name = @"Num1",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCC.4.3",
                            Type = @"Component",
                            Position = @"TCC.4.3",
                            Name = @"Separator/Suffix",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"""-"" or ""+"" or ""/"" or ""."" or "":""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCC.4.4",
                            Type = @"Component",
                            Position = @"TCC.4.4",
                            Name = @"Num2",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number or null depending on the measurement.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _autoDilutionFactorDefault = new HL7V26Field
        {
            field = message[@"TCC"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_autoDilutionFactorDefault.field.FieldRepetitions != null && _autoDilutionFactorDefault.field.FieldRepetitions.Count > 0)
        {
            _autoDilutionFactorDefault.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_autoDilutionFactorDefault, fieldData);
        }

        return _autoDilutionFactorDefault;
    } 
}

internal HL7V26Field _rerunDilutionFactorDefault;

public HL7V26Field RerunDilutionFactorDefault
{
    get
    {
        if (_rerunDilutionFactorDefault != null)
        {
            return _rerunDilutionFactorDefault;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"TCC.5",
            Type = @"Field",
            Position = @"TCC.5",
            Name = @"Rerun Dilution Factor Default",
            Length = 36,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SN",
            DataTypeName = @"Structured Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the value that is to be used as the default factor for automatically diluting a specimen in case of rerun for this particular test code.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"TCC.5.1",
                            Type = @"Component",
                            Position = @"TCC.5.1",
                            Name = @"Comparator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as greater than, less than, greater than or equal, less than or equal, equal, and not equal, respectively (= "">"" or ""<"" or "">="" or ""<="" or ""="" or ""<>""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCC.5.2",
                            Type = @"Component",
                            Position = @"TCC.5.2",
                            Name = @"Num1",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCC.5.3",
                            Type = @"Component",
                            Position = @"TCC.5.3",
                            Name = @"Separator/Suffix",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"""-"" or ""+"" or ""/"" or ""."" or "":""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCC.5.4",
                            Type = @"Component",
                            Position = @"TCC.5.4",
                            Name = @"Num2",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number or null depending on the measurement.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _rerunDilutionFactorDefault = new HL7V26Field
        {
            field = message[@"TCC"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_rerunDilutionFactorDefault.field.FieldRepetitions != null && _rerunDilutionFactorDefault.field.FieldRepetitions.Count > 0)
        {
            _rerunDilutionFactorDefault.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_rerunDilutionFactorDefault, fieldData);
        }

        return _rerunDilutionFactorDefault;
    } 
}

internal HL7V26Field _preDilutionFactorDefault;

public HL7V26Field PreDilutionFactorDefault
{
    get
    {
        if (_preDilutionFactorDefault != null)
        {
            return _preDilutionFactorDefault;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"TCC.6",
            Type = @"Field",
            Position = @"TCC.6",
            Name = @"Pre-Dilution Factor Default",
            Length = 36,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SN",
            DataTypeName = @"Structured Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the value that is to be used as the default factor for a specimen that is delivered to the laboratory automation system as pre-diluted for this particular test code.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"TCC.6.1",
                            Type = @"Component",
                            Position = @"TCC.6.1",
                            Name = @"Comparator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as greater than, less than, greater than or equal, less than or equal, equal, and not equal, respectively (= "">"" or ""<"" or "">="" or ""<="" or ""="" or ""<>""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCC.6.2",
                            Type = @"Component",
                            Position = @"TCC.6.2",
                            Name = @"Num1",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCC.6.3",
                            Type = @"Component",
                            Position = @"TCC.6.3",
                            Name = @"Separator/Suffix",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"""-"" or ""+"" or ""/"" or ""."" or "":""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCC.6.4",
                            Type = @"Component",
                            Position = @"TCC.6.4",
                            Name = @"Num2",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number or null depending on the measurement.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _preDilutionFactorDefault = new HL7V26Field
        {
            field = message[@"TCC"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_preDilutionFactorDefault.field.FieldRepetitions != null && _preDilutionFactorDefault.field.FieldRepetitions.Count > 0)
        {
            _preDilutionFactorDefault.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_preDilutionFactorDefault, fieldData);
        }

        return _preDilutionFactorDefault;
    } 
}

internal HL7V26Field _endogenousContentofPreDilutionDiluent;

public HL7V26Field EndogenousContentofPreDilutionDiluent
{
    get
    {
        if (_endogenousContentofPreDilutionDiluent != null)
        {
            return _endogenousContentofPreDilutionDiluent;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"TCC.7",
            Type = @"Field",
            Position = @"TCC.7",
            Name = @"Endogenous Content of Pre-Dilution Diluent",
            Length = 36,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SN",
            DataTypeName = @"Structured Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field represents a baseline value for the measured test that is inherently contained in the diluent. In the calculation of the actual result for the measured test, this baseline value is normally considered.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"TCC.7.1",
                            Type = @"Component",
                            Position = @"TCC.7.1",
                            Name = @"Comparator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as greater than, less than, greater than or equal, less than or equal, equal, and not equal, respectively (= "">"" or ""<"" or "">="" or ""<="" or ""="" or ""<>""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCC.7.2",
                            Type = @"Component",
                            Position = @"TCC.7.2",
                            Name = @"Num1",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCC.7.3",
                            Type = @"Component",
                            Position = @"TCC.7.3",
                            Name = @"Separator/Suffix",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"""-"" or ""+"" or ""/"" or ""."" or "":""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCC.7.4",
                            Type = @"Component",
                            Position = @"TCC.7.4",
                            Name = @"Num2",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number or null depending on the measurement.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _endogenousContentofPreDilutionDiluent = new HL7V26Field
        {
            field = message[@"TCC"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_endogenousContentofPreDilutionDiluent.field.FieldRepetitions != null && _endogenousContentofPreDilutionDiluent.field.FieldRepetitions.Count > 0)
        {
            _endogenousContentofPreDilutionDiluent.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_endogenousContentofPreDilutionDiluent, fieldData);
        }

        return _endogenousContentofPreDilutionDiluent;
    } 
}

internal HL7V26Field _inventoryLimitsWarningLevel;

public HL7V26Field InventoryLimitsWarningLevel
{
    get
    {
        if (_inventoryLimitsWarningLevel != null)
        {
            return _inventoryLimitsWarningLevel;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"TCC.8",
            Type = @"Field",
            Position = @"TCC.8",
            Name = @"Inventory Limits Warning Level",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the value that is to be used as the threshold for initiating inventory warning-level messages.",
            Sample = @"",
            Fields = null
        }

        _inventoryLimitsWarningLevel = new HL7V26Field
        {
            field = message[@"TCC"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_inventoryLimitsWarningLevel.field.FieldRepetitions != null && _inventoryLimitsWarningLevel.field.FieldRepetitions.Count > 0)
        {
            _inventoryLimitsWarningLevel.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_inventoryLimitsWarningLevel, fieldData);
        }

        return _inventoryLimitsWarningLevel;
    } 
}

internal HL7V26Field _automaticRerunAllowed;

public HL7V26Field AutomaticRerunAllowed
{
    get
    {
        if (_automaticRerunAllowed != null)
        {
            return _automaticRerunAllowed;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"TCC.9",
            Type = @"Field",
            Position = @"TCC.9",
            Name = @"Automatic Rerun Allowed",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field identifies whether or not automatic reruns are to be initiated on specimens for this particular test code. Refer to HL7 Table 0136 -Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _automaticRerunAllowed = new HL7V26Field
        {
            field = message[@"TCC"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_automaticRerunAllowed.field.FieldRepetitions != null && _automaticRerunAllowed.field.FieldRepetitions.Count > 0)
        {
            _automaticRerunAllowed.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_automaticRerunAllowed, fieldData);
        }

        return _automaticRerunAllowed;
    } 
}

internal HL7V26Field _automaticRepeatAllowed;

public HL7V26Field AutomaticRepeatAllowed
{
    get
    {
        if (_automaticRepeatAllowed != null)
        {
            return _automaticRepeatAllowed;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"TCC.10",
            Type = @"Field",
            Position = @"TCC.10",
            Name = @"Automatic Repeat Allowed",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field identifies whether or not automatic repeat testing is to be initiated on specimens for this particular test code. Refer to HL7 Table 0136 -Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _automaticRepeatAllowed = new HL7V26Field
        {
            field = message[@"TCC"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_automaticRepeatAllowed.field.FieldRepetitions != null && _automaticRepeatAllowed.field.FieldRepetitions.Count > 0)
        {
            _automaticRepeatAllowed.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_automaticRepeatAllowed, fieldData);
        }

        return _automaticRepeatAllowed;
    } 
}

internal HL7V26Field _automaticReflexAllowed;

public HL7V26Field AutomaticReflexAllowed
{
    get
    {
        if (_automaticReflexAllowed != null)
        {
            return _automaticReflexAllowed;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"TCC.11",
            Type = @"Field",
            Position = @"TCC.11",
            Name = @"Automatic Reflex Allowed",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field identifies whether or not automatic or manual reflex testing is to be initiated on specimens for this particular test code. Refer to HL7 Table 0136 -Yes/no indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _automaticReflexAllowed = new HL7V26Field
        {
            field = message[@"TCC"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_automaticReflexAllowed.field.FieldRepetitions != null && _automaticReflexAllowed.field.FieldRepetitions.Count > 0)
        {
            _automaticReflexAllowed.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_automaticReflexAllowed, fieldData);
        }

        return _automaticReflexAllowed;
    } 
}

internal HL7V26Field _equipmentDynamicRange;

public HL7V26Field EquipmentDynamicRange
{
    get
    {
        if (_equipmentDynamicRange != null)
        {
            return _equipmentDynamicRange;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"TCC.12",
            Type = @"Field",
            Position = @"TCC.12",
            Name = @"Equipment Dynamic Range",
            Length = 36,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SN",
            DataTypeName = @"Structured Numeric",
            TableId = null,
            TableName = null,
            Description = @"This is the range over which the equipment can produce results.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"TCC.12.1",
                            Type = @"Component",
                            Position = @"TCC.12.1",
                            Name = @"Comparator",
                            Length = 2,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as greater than, less than, greater than or equal, less than or equal, equal, and not equal, respectively (= "">"" or ""<"" or "">="" or ""<="" or ""="" or ""<>""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCC.12.2",
                            Type = @"Component",
                            Position = @"TCC.12.2",
                            Name = @"Num1",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCC.12.3",
                            Type = @"Component",
                            Position = @"TCC.12.3",
                            Name = @"Separator/Suffix",
                            Length = 1,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"""-"" or ""+"" or ""/"" or ""."" or "":""",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"TCC.12.4",
                            Type = @"Component",
                            Position = @"TCC.12.4",
                            Name = @"Num2",
                            Length = 15,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"A number or null depending on the measurement.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _equipmentDynamicRange = new HL7V26Field
        {
            field = message[@"TCC"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_equipmentDynamicRange.field.FieldRepetitions != null && _equipmentDynamicRange.field.FieldRepetitions.Count > 0)
        {
            _equipmentDynamicRange.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_equipmentDynamicRange, fieldData);
        }

        return _equipmentDynamicRange;
    } 
}

internal HL7V26Field _units;

public HL7V26Field Units
{
    get
    {
        if (_units != null)
        {
            return _units;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"TCC.13",
            Type = @"Field",
            Position = @"TCC.13",
            Name = @"Units",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = null,
            TableName = null,
            Description = @"This field is the units that have a data type of CWE. The default coding system for the units codes consists of the ISO+ abbreviation for a single case unit (ISO 2955-83) plus extensions, that do not collide with ISO abbreviations (see Chapter 7, section 7.4.2.6). We designate this coding system as ISO+. Both the ISO unit's abbreviations and the extensions are defined in Chapter 7, section 7.4.2.6.2 and listed in Figure 7-9. The ISO+ abbreviations are the codes for the default coding system. Consequently, when ISO+ units are being used, only ISO+ abbreviations need be sent, and the contents of the units field will be backward compatible to HL7 Version 2.1. For more information on this field see reference Chapter 7, section 7.4.2.6.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"TCC.13.1",
                            Type = @"Component",
                            Position = @"TCC.13.1",
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
                            Id = @"TCC.13.2",
                            Type = @"Component",
                            Position = @"TCC.13.2",
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
                            Id = @"TCC.13.3",
                            Type = @"Component",
                            Position = @"TCC.13.3",
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
                            Id = @"TCC.13.4",
                            Type = @"Component",
                            Position = @"TCC.13.4",
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
                            Id = @"TCC.13.5",
                            Type = @"Component",
                            Position = @"TCC.13.5",
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
                            Id = @"TCC.13.6",
                            Type = @"Component",
                            Position = @"TCC.13.6",
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
                            Id = @"TCC.13.7",
                            Type = @"Component",
                            Position = @"TCC.13.7",
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
                            Id = @"TCC.13.8",
                            Type = @"Component",
                            Position = @"TCC.13.8",
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
                            Id = @"TCC.13.9",
                            Type = @"Component",
                            Position = @"TCC.13.9",
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

        _units = new HL7V26Field
        {
            field = message[@"TCC"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_units.field.FieldRepetitions != null && _units.field.FieldRepetitions.Count > 0)
        {
            _units.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_units, fieldData);
        }

        return _units;
    } 
}

internal HL7V26Field _processingType;

public HL7V26Field ProcessingType
{
    get
    {
        if (_processingType != null)
        {
            return _processingType;
        }

        var fieldData = new HL7V26FieldData
        {
            Id = @"TCC.14",
            Type = @"Field",
            Position = @"TCC.14",
            Name = @"Processing Type",
            Length = 705,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded with Exceptions",
            TableId = @"0388",
            TableName = @"Processing type",
            Description = @"This field identifies the processing type that applies to this test code. If this attribute is omitted, then regular production is the default. Refer to HL7 Table 0388 - Processing type for valid values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"TCC.14.1",
                            Type = @"Component",
                            Position = @"TCC.14.1",
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
                            Id = @"TCC.14.2",
                            Type = @"Component",
                            Position = @"TCC.14.2",
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
                            Id = @"TCC.14.3",
                            Type = @"Component",
                            Position = @"TCC.14.3",
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
                            Id = @"TCC.14.4",
                            Type = @"Component",
                            Position = @"TCC.14.4",
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
                            Id = @"TCC.14.5",
                            Type = @"Component",
                            Position = @"TCC.14.5",
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
                            Id = @"TCC.14.6",
                            Type = @"Component",
                            Position = @"TCC.14.6",
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
                            Id = @"TCC.14.7",
                            Type = @"Component",
                            Position = @"TCC.14.7",
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
                            Id = @"TCC.14.8",
                            Type = @"Component",
                            Position = @"TCC.14.8",
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
                            Id = @"TCC.14.9",
                            Type = @"Component",
                            Position = @"TCC.14.9",
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

        _processingType = new HL7V26Field
        {
            field = message[@"TCC"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_processingType.field.FieldRepetitions != null && _processingType.field.FieldRepetitions.Count > 0)
        {
            _processingType.fieldRepetitions = HL7V2FieldGenerator.GenerateV26FieldRepetitions(_processingType, fieldData);
        }

        return _processingType;
    } 
}
    }
}
