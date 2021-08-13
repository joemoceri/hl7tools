using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V271SegmentECD
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"ECD"; } }

        public string SegmentId { get { return @"ECD"; } }
        
        public string LongName { get { return @"Equipment Command"; } }
        
        public string Description { get { return @"The equipment command segment contains the information required to notify the receiving component what is to happen."; } }
        
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

        public HL7V271SegmentECD(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V271Field _referenceCommandNumber;

public HL7V271Field ReferenceCommandNumber
{
    get
    {
        if (_referenceCommandNumber != null)
        {
            return _referenceCommandNumber;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"ECD.1",
            Type = @"Field",
            Position = @"ECD.1",
            Name = @"Reference Command Number",
            Length = 0,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the unique identifier for this particular command that should be used by the various components for future referral to this command.  It is similar to the concept of MSH-10 Message Control ID, but at the equipment command/response level.  This number is generated by the originator of this command.",
            Sample = @"",
            Fields = null
        }

        _referenceCommandNumber = new HL7V271Field
        {
            field = message[@"ECD"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_referenceCommandNumber.field.FieldRepetitions != null && _referenceCommandNumber.field.FieldRepetitions.Count > 0)
        {
            _referenceCommandNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_referenceCommandNumber, fieldData);
        }

        return _referenceCommandNumber;
    } 
}

internal HL7V271Field _remoteControlCommand;

public HL7V271Field RemoteControlCommand
{
    get
    {
        if (_remoteControlCommand != null)
        {
            return _remoteControlCommand;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"ECD.2",
            Type = @"Field",
            Position = @"ECD.2",
            Name = @"Remote Control Command",
            Length = 0,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CWE",
            DataTypeName = @"Coded With Exceptions",
            TableId = @"0368",
            TableName = @"Remote Control Command",
            Description = @"This field identifies the command that the component is to initiate.  Refer to User-defined Table 0368 – Remote Control Command for valid values.  Refer to LECIS standard for details.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"ECD.2.1",
                            Type = @"Component",
                            Position = @"ECD.2.1",
                            Name = @"Identifier",
                            Length = 0,
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
                            Id = @"ECD.2.2",
                            Type = @"Component",
                            Position = @"ECD.2.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component contains the descriptive or textual name of the identifier, e.g., ""myocardial infarction"" or ""X-ray impression"".",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ECD.2.3",
                            Type = @"Component",
                            Position = @"ECD.2.3",
                            Name = @"Name Of Coding System",
                            Length = 12,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"The third component contains the code for the name of the coding system from which the value in CWE.1 is obtained. Each coding system is assigned a unique identifier. As of v2.7 this component is required when CWE.1 is populated and CWE.14 is not populated. Both CWE.3 and CWE.14 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the codingSystem as specified in CWE.3 and/or CWE.14, the ""Coding System"" component or the ""Coding System OID"" for the tuple.

Refer to HL7 Table 0396 – Coding System in Chapter 2C, section ""Coding System Table"" for valid values. 

Refer to section 2.A.8.3, ""Name of Coding System (ID)"" for a discussion of coding system conventions.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ECD.2.4",
                            Type = @"Component",
                            Position = @"ECD.2.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A sequence of characters that uniquely identifies an alternate code. Analogous to CWE.1- Identifier. 

Usage Notes: The Alternate Identifier is used to represent the local or user seen code as described. If present, it obeys the same rules of use and interpretation as described for component 1. If both are present, the identifiers in component 4 and component 1 should have exactly the same meaning, i.e., they should be exact synonyms.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ECD.2.5",
                            Type = @"Component",
                            Position = @"ECD.2.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text.  See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ECD.2.6",
                            Type = @"Component",
                            Position = @"ECD.2.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 12,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 - Name of Coding System. See usage note in section introduction.

As of v2.7 this component is required when CWE.4 is populated and CWE.17 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.6 and/or CWE.17, the ""Coding System"" component or the ""Coding System OID"", for the tuple.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ECD.2.7",
                            Type = @"Component",
                            Position = @"ECD.2.7",
                            Name = @"Coding System Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 1-3. If CWE.3 is populated with a value other than HL7nnnn or is of table type user-defined, version ID must be valued with an actual version ID.  If CWE.3 is populated with a value of HL7nnnn and nnnn is of table type HL7, version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ECD.2.8",
                            Type = @"Component",
                            Position = @"ECD.2.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 4-6. Analogous To CWE.7 - Coding System Version ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ECD.2.9",
                            Type = @"Component",
                            Position = @"ECD.2.9",
                            Name = @"Original Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The text as seen and/or selected by the user who entered the data. Original text can be used in a structured user interface to capture what the user saw as a representation of the code on the data input screen, or in a situation where the user dictates or directly enters text, it is the text entered or uttered by the user. In a situation where the code is assigned sometime after the text was entered, original text is the text or phrase used as the basis for assigning the code.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ECD.2.10",
                            Type = @"Component",
                            Position = @"ECD.2.10",
                            Name = @"Second Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"A sequence of characters that uniquely identifies a second alternate code. Analogous to CWE.1- Identifier. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ECD.2.11",
                            Type = @"Component",
                            Position = @"ECD.2.11",
                            Name = @"Second Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to CWE.2 - Text. See usage note in section introduction.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ECD.2.12",
                            Type = @"Component",
                            Position = @"ECD.2.12",
                            Name = @"Name Of Second Alternate Coding System",
                            Length = 12,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded Value For Hl7 Defined Tables",
                            TableId = @"0396",
                            TableName = @"Coding System",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to CWE.3 Name of Coding System. See usage note in section introduction.

As of v2.7 this component is required when CWE.10 is populated and CWE.20 is not populated. Both CWE.6 and CWE.17 may be populated. Receivers should not identify a code based on its position within the tuples (Identifier, Alternate Identifier, or Second Alternate Identifier) or position within a repeating field. Instead, the receiver should always examine the coding System as specified in CWE.12 and/or CWE.20, the ""Coding System"" component or the ""Coding System OID"", for the tuple.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ECD.2.13",
                            Type = @"Component",
                            Position = @"ECD.2.13",
                            Name = @"Second Alternate Coding System Version Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the coding system identified by components 10-12. Analogous to CWE.7 - Coding System Version ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ECD.2.14",
                            Type = @"Component",
                            Position = @"ECD.2.14",
                            Name = @"Coding System Oid",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.3. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. 

This component is required when CWE.1 is populated and CWE.3 is not populated. Both CWE.3 and CWE.14 may be populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ECD.2.15",
                            Type = @"Component",
                            Position = @"ECD.2.15",
                            Name = @"Value Set Oid",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.1 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. 

A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ECD.2.16",
                            Type = @"Component",
                            Position = @"ECD.2.16",
                            Name = @"Value Set Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the value set identified by CWE.15. The version is a date. The date is the date/time that the value set being used was published.

Value set version ID is required if CWE.15 is populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ECD.2.17",
                            Type = @"Component",
                            Position = @"ECD.2.17",
                            Name = @"Alternate Coding System Oid",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.6. Analogous to CWE.14 Coding System OID. 

The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. 

This component is required when CWE.4 is populated and CWE.6 is not populated. Both CWE.6 and CWE.17 may be populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ECD.2.18",
                            Type = @"Component",
                            Position = @"ECD.2.18",
                            Name = @"Alternate Value Set Oid",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.4 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. 

A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ECD.2.19",
                            Type = @"Component",
                            Position = @"ECD.2.19",
                            Name = @"Alternate Value Set Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the value set identified by CWE.18. The version is a date. The date is the date/time that the value set being used was published.

Value set version ID is required if CWE.18 is populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ECD.2.20",
                            Type = @"Component",
                            Position = @"ECD.2.20",
                            Name = @"Second Alternate Coding System Oid",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) for the coding system or value set named in CWE.12. Analogous to CWE.14 - Coding System OID. 

The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined code systems the OID registered in the HL7 OID registry SHALL be used. 

This component is required when CWE.10 is populated and CWE.12 is not populated. Both CWE.12 and CWE.20 may be populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ECD.2.21",
                            Type = @"Component",
                            Position = @"ECD.2.21",
                            Name = @"Second Alternate Value Set Oid",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This component contains the ISO Object Identifier (OID) to allow identification of the value set from which the value in CWE.10 is obtained. The value for this component is 2.16.840.1.113883.12.#### where  ""####"" is to be replaced by the HL7 table number in the case of an HL7 defined or user defined table. For externally defined value sets, the OID registered in the HL7 OID registry SHALL be used. 

A value set may or need not be present irrespective of other fields. Note that if a code is provided, the meaning of the code must come from the definition of the code in the code system. The meaning of the code SHALL NOT depend on the value set.  Applications SHALL NOT be required to interpret the code in light of the valueSet, and they SHALL NOT reject an instance because of the presence or absence of any or a particular value set/ value set version ID.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"ECD.2.22",
                            Type = @"Component",
                            Position = @"ECD.2.22",
                            Name = @"Second Alternate Value Set Version Id",
                            Length = 0,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DTM",
                            DataTypeName = @"Date/time",
                            TableId = null,
                            TableName = null,
                            Description = @"This component carries the version for the value set identified by CWE.21. The version is a date. The date is the date/time that the value set being used was published.

Value set version ID is required if CWE.21 is populated.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _remoteControlCommand = new HL7V271Field
        {
            field = message[@"ECD"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_remoteControlCommand.field.FieldRepetitions != null && _remoteControlCommand.field.FieldRepetitions.Count > 0)
        {
            _remoteControlCommand.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_remoteControlCommand, fieldData);
        }

        return _remoteControlCommand;
    } 
}

internal HL7V271Field _responseRequired;

public HL7V271Field ResponseRequired
{
    get
    {
        if (_responseRequired != null)
        {
            return _responseRequired;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"ECD.3",
            Type = @"Field",
            Position = @"ECD.3",
            Name = @"Response Required",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded Value For Hl7 Defined Tables",
            TableId = @"0136",
            TableName = @"Yes/no Indicator",
            Description = @"This field identifies the mode of synchronization that is to be used in relation to the execution of the command. ""Y"" (Yes) means that the response is required immediately after execution; ""N"" (No) response is not required at all. Refer to HL7 Table 0136 – Yes/no Indicator for valid values.",
            Sample = @"",
            Fields = null
        }

        _responseRequired = new HL7V271Field
        {
            field = message[@"ECD"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_responseRequired.field.FieldRepetitions != null && _responseRequired.field.FieldRepetitions.Count > 0)
        {
            _responseRequired.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_responseRequired, fieldData);
        }

        return _responseRequired;
    } 
}

internal HL7V271Field _requestedCompletionTime;

public HL7V271Field RequestedCompletionTime
{
    get
    {
        if (_requestedCompletionTime != null)
        {
            return _requestedCompletionTime;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"ECD.4",
            Type = @"Field",
            Position = @"ECD.4",
            Name = @"Requested Completion Time",
            Length = 0,
            Usage = @"W",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Attention: As of version 2.5 this fieldwas retained for backward compatibility only and withdrawn as of v2.7. The TQ data type was deprecated; see Chapter 2A, section 2.A.81. Instead use the ""Explicit time"" (TQ1-4) or ""Relative Time and Units"" (TQ1-5) fields of the TQ1 segment in a message using ECD segment. ",
            Sample = @"",
            Fields = null
        }

        _requestedCompletionTime = new HL7V271Field
        {
            field = message[@"ECD"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedCompletionTime.field.FieldRepetitions != null && _requestedCompletionTime.field.FieldRepetitions.Count > 0)
        {
            _requestedCompletionTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_requestedCompletionTime, fieldData);
        }

        return _requestedCompletionTime;
    } 
}

internal HL7V271Field _parameters;

public HL7V271Field Parameters
{
    get
    {
        if (_parameters != null)
        {
            return _parameters;
        }

        var fieldData = new HL7V271FieldData
        {
            Id = @"ECD.5",
            Type = @"Field",
            Position = @"ECD.5",
            Name = @"Parameters",
            Length = 0,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"TX",
            DataTypeName = @"Text Data",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the parameters of the command (if they are not included in a separate segment(s)). 

Note:  Elements of this segment (or other elements not defined here) may be required for certain vendor-specific equipment such as centrifuges, aliquoters, sorters, uncappers, recappers, automated storage units, etc.",
            Sample = @"",
            Fields = null
        }

        _parameters = new HL7V271Field
        {
            field = message[@"ECD"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_parameters.field.FieldRepetitions != null && _parameters.field.FieldRepetitions.Count > 0)
        {
            _parameters.fieldRepetitions = HL7V2FieldGenerator.GenerateV271FieldRepetitions(_parameters, fieldData);
        }

        return _parameters;
    } 
}
    }
}
