using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentIN2
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"IN2"; } }

        public string SegmentId { get { return @"IN2"; } }
        
        public string LongName { get { return @"Insurance additional info"; } }
        
        public string Description { get { return @"The IN2 segment contains additional insurance policy coverage and benefit information necessary for proper billing and reimbursement.  Fields used by this segment are defined by HCFA or other regulatory agencies."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_06",

                    };
            }
        }

        public HL7V23SegmentIN2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _insuredsEmployeeID;

public HL7V23Field InsuredsEmployeeID
{
    get
    {
        if (_insuredsEmployeeID != null)
        {
            return _insuredsEmployeeID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.1",
            Type = @"Field",
            Position = @"IN2.1",
            Name = @"Insured's Employee ID",
            Length = 59,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This fields contains the employee ID of the insured",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.1.1",
                            Type = @"Component",
                            Position = @"IN2.1.1",
                            Name = @"ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.1.2",
                            Type = @"Component",
                            Position = @"IN2.1.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type.  The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.1.3",
                            Type = @"Component",
                            Position = @"IN2.1.3",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.1.4",
                            Type = @"Component",
                            Position = @"IN2.1.4",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN2.1.4.1",
                            Type = @"SubComponent",
                            Position = @"IN2.1.4.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.1.4.2",
                            Type = @"SubComponent",
                            Position = @"IN2.1.4.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.1.4.3",
                            Type = @"SubComponent",
                            Position = @"IN2.1.4.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.1.5",
                            Type = @"Component",
                            Position = @"IN2.1.5",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.1.6",
                            Type = @"Component",
                            Position = @"IN2.1.6",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN2.1.6.1",
                            Type = @"SubComponent",
                            Position = @"IN2.1.6.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.1.6.2",
                            Type = @"SubComponent",
                            Position = @"IN2.1.6.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.1.6.3",
                            Type = @"SubComponent",
                            Position = @"IN2.1.6.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _insuredsEmployeeID = new HL7V23Field
        {
            field = message[@"IN2"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsEmployeeID.field.FieldRepetitions != null && _insuredsEmployeeID.field.FieldRepetitions.Count > 0)
        {
            _insuredsEmployeeID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuredsEmployeeID, fieldData);
        }

        return _insuredsEmployeeID;
    } 
}

internal HL7V23Field _insuredsSocialSecurityNumber;

public HL7V23Field InsuredsSocialSecurityNumber
{
    get
    {
        if (_insuredsSocialSecurityNumber != null)
        {
            return _insuredsSocialSecurityNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.2",
            Type = @"Field",
            Position = @"IN2.2",
            Name = @"Insured's Social Security Number",
            Length = 11,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This fields contains the social security number of the insured",
            Sample = @"",
            Fields = null
        }

        _insuredsSocialSecurityNumber = new HL7V23Field
        {
            field = message[@"IN2"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsSocialSecurityNumber.field.FieldRepetitions != null && _insuredsSocialSecurityNumber.field.FieldRepetitions.Count > 0)
        {
            _insuredsSocialSecurityNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuredsSocialSecurityNumber, fieldData);
        }

        return _insuredsSocialSecurityNumber;
    } 
}

internal HL7V23Field _insuredsEmployerName;

public HL7V23Field InsuredsEmployerName
{
    get
    {
        if (_insuredsEmployerName != null)
        {
            return _insuredsEmployerName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.3",
            Type = @"Field",
            Position = @"IN2.3",
            Name = @"Insured's Employer Name",
            Length = 130,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of insured’s employer or the person who purchased the insurance for the insured.  Multiple names for the same employer may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.  When the employer is an organization use IN2-70-insured employer organization name and ID.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.3.1",
                            Type = @"Component",
                            Position = @"IN2.3.1",
                            Name = @"ID Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Coded ID according to a user-defined table, defined by the 8th component.  If the first component is present, either the source table or the assigning authority must be valued",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3.2",
                            Type = @"Component",
                            Position = @"IN2.3.2",
                            Name = @"Family Name",
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
                            Id = @"IN2.3.3",
                            Type = @"Component",
                            Position = @"IN2.3.3",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3.4",
                            Type = @"Component",
                            Position = @"IN2.3.4",
                            Name = @"Middle Initial Or Name",
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
                            Id = @"IN2.3.5",
                            Type = @"Component",
                            Position = @"IN2.3.5",
                            Name = @"Suffix",
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
                            Id = @"IN2.3.6",
                            Type = @"Component",
                            Position = @"IN2.3.6",
                            Name = @"Prefix",
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
                            Id = @"IN2.3.7",
                            Type = @"Component",
                            Position = @"IN2.3.7",
                            Name = @"Degree",
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
                            Id = @"IN2.3.8",
                            Type = @"Component",
                            Position = @"IN2.3.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"Refer to user-defined table 0207 - CN ID source for suggested values.  Used to delineate the first component. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3.9",
                            Type = @"Component",
                            Position = @"IN2.3.9",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @" In this version an optional 9th component, the assigning authority (HD), has been added.  It is an HD data type (see Section 2.8.18, “HD - hierarchic designator”). ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN2.3.9.1",
                            Type = @"SubComponent",
                            Position = @"IN2.3.9.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3.9.2",
                            Type = @"SubComponent",
                            Position = @"IN2.3.9.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3.9.3",
                            Type = @"SubComponent",
                            Position = @"IN2.3.9.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3.10",
                            Type = @"Component",
                            Position = @"IN2.3.10",
                            Name = @"Name Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.48, “XPN - extended person name”). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3.11",
                            Type = @"Component",
                            Position = @"IN2.3.11",
                            Name = @"Identifier Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3.12",
                            Type = @"Component",
                            Position = @"IN2.3.12",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"Refer to HL7 table 0060 - Check digit scheme for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3.13",
                            Type = @"Component",
                            Position = @"IN2.3.13",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3.14",
                            Type = @"Component",
                            Position = @"IN2.3.14",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier:  as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN2.3.14.1",
                            Type = @"SubComponent",
                            Position = @"IN2.3.14.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3.14.2",
                            Type = @"SubComponent",
                            Position = @"IN2.3.14.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.3.14.3",
                            Type = @"SubComponent",
                            Position = @"IN2.3.14.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _insuredsEmployerName = new HL7V23Field
        {
            field = message[@"IN2"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsEmployerName.field.FieldRepetitions != null && _insuredsEmployerName.field.FieldRepetitions.Count > 0)
        {
            _insuredsEmployerName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuredsEmployerName, fieldData);
        }

        return _insuredsEmployerName;
    } 
}

internal HL7V23Field _employerInformationData;

public HL7V23Field EmployerInformationData
{
    get
    {
        if (_employerInformationData != null)
        {
            return _employerInformationData;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.4",
            Type = @"Field",
            Position = @"IN2.4",
            Name = @"Employer Information Data",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0139",
            TableName = @"Employer information data",
            Description = @"This field contains the required employer information data for UB82 form locator 71.  Refer to user-defined table 0139 - Employer information data for suggested values.",
            Sample = @"",
            Fields = null
        }

        _employerInformationData = new HL7V23Field
        {
            field = message[@"IN2"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_employerInformationData.field.FieldRepetitions != null && _employerInformationData.field.FieldRepetitions.Count > 0)
        {
            _employerInformationData.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_employerInformationData, fieldData);
        }

        return _employerInformationData;
    } 
}

internal HL7V23Field _mailClaimParty;

public HL7V23Field MailClaimParty
{
    get
    {
        if (_mailClaimParty != null)
        {
            return _mailClaimParty;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.5",
            Type = @"Field",
            Position = @"IN2.5",
            Name = @"Mail Claim Party",
            Length = 1,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0137",
            TableName = @"Mail claim party",
            Description = @"This field contains the party to which the claim should be mailed.  Refer to user-defined table 0137 - Mail claim party for suggested values.",
            Sample = @"",
            Fields = null
        }

        _mailClaimParty = new HL7V23Field
        {
            field = message[@"IN2"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_mailClaimParty.field.FieldRepetitions != null && _mailClaimParty.field.FieldRepetitions.Count > 0)
        {
            _mailClaimParty.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_mailClaimParty, fieldData);
        }

        return _mailClaimParty;
    } 
}

internal HL7V23Field _medicareHealthInsCardNumber;

public HL7V23Field MedicareHealthInsCardNumber
{
    get
    {
        if (_medicareHealthInsCardNumber != null)
        {
            return _medicareHealthInsCardNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.6",
            Type = @"Field",
            Position = @"IN2.6",
            Name = @"Medicare Health Ins Card Number",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the Medicare Health Insurance Number (HIN), defined by HCFA or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _medicareHealthInsCardNumber = new HL7V23Field
        {
            field = message[@"IN2"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_medicareHealthInsCardNumber.field.FieldRepetitions != null && _medicareHealthInsCardNumber.field.FieldRepetitions.Count > 0)
        {
            _medicareHealthInsCardNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_medicareHealthInsCardNumber, fieldData);
        }

        return _medicareHealthInsCardNumber;
    } 
}

internal HL7V23Field _medicaidCaseName;

public HL7V23Field MedicaidCaseName
{
    get
    {
        if (_medicaidCaseName != null)
        {
            return _medicaidCaseName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.7",
            Type = @"Field",
            Position = @"IN2.7",
            Name = @"Medicaid Case Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the Medicaid case name, defined by HCFA or other regulatory agencies. Multiple names for the same person may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.7.1",
                            Type = @"Component",
                            Position = @"IN2.7.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.7.2",
                            Type = @"Component",
                            Position = @"IN2.7.2",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.7.3",
                            Type = @"Component",
                            Position = @"IN2.7.3",
                            Name = @"Middle Initial Or Name",
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
                            Id = @"IN2.7.4",
                            Type = @"Component",
                            Position = @"IN2.7.4",
                            Name = @"Suffix",
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
                            Id = @"IN2.7.5",
                            Type = @"Component",
                            Position = @"IN2.7.5",
                            Name = @"Prefix",
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
                            Id = @"IN2.7.6",
                            Type = @"Component",
                            Position = @"IN2.7.6",
                            Name = @"Degree",
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
                            Id = @"IN2.7.7",
                            Type = @"Component",
                            Position = @"IN2.7.7",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.7.8",
                            Type = @"Component",
                            Position = @"IN2.7.8",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"In general this component provides an indication of the representation provided by the data item.  It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired.  This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _medicaidCaseName = new HL7V23Field
        {
            field = message[@"IN2"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_medicaidCaseName.field.FieldRepetitions != null && _medicaidCaseName.field.FieldRepetitions.Count > 0)
        {
            _medicaidCaseName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_medicaidCaseName, fieldData);
        }

        return _medicaidCaseName;
    } 
}

internal HL7V23Field _medicaidCaseNumber;

public HL7V23Field MedicaidCaseNumber
{
    get
    {
        if (_medicaidCaseNumber != null)
        {
            return _medicaidCaseNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.8",
            Type = @"Field",
            Position = @"IN2.8",
            Name = @"Medicaid Case Number",
            Length = 15,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the Medicaid case number, defined by HCFA or other regulatory agencies, which uniquely identifies a patient’s Medicaid policy.",
            Sample = @"",
            Fields = null
        }

        _medicaidCaseNumber = new HL7V23Field
        {
            field = message[@"IN2"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_medicaidCaseNumber.field.FieldRepetitions != null && _medicaidCaseNumber.field.FieldRepetitions.Count > 0)
        {
            _medicaidCaseNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_medicaidCaseNumber, fieldData);
        }

        return _medicaidCaseNumber;
    } 
}

internal HL7V23Field _champusSponsorName;

public HL7V23Field ChampusSponsorName
{
    get
    {
        if (_champusSponsorName != null)
        {
            return _champusSponsorName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.9",
            Type = @"Field",
            Position = @"IN2.9",
            Name = @"Champus Sponsor Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field is defined by HCFA or other regulatory agencies.  Multiple names for the same person may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.9.1",
                            Type = @"Component",
                            Position = @"IN2.9.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.9.2",
                            Type = @"Component",
                            Position = @"IN2.9.2",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.9.3",
                            Type = @"Component",
                            Position = @"IN2.9.3",
                            Name = @"Middle Initial Or Name",
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
                            Id = @"IN2.9.4",
                            Type = @"Component",
                            Position = @"IN2.9.4",
                            Name = @"Suffix",
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
                            Id = @"IN2.9.5",
                            Type = @"Component",
                            Position = @"IN2.9.5",
                            Name = @"Prefix",
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
                            Id = @"IN2.9.6",
                            Type = @"Component",
                            Position = @"IN2.9.6",
                            Name = @"Degree",
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
                            Id = @"IN2.9.7",
                            Type = @"Component",
                            Position = @"IN2.9.7",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.9.8",
                            Type = @"Component",
                            Position = @"IN2.9.8",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"In general this component provides an indication of the representation provided by the data item.  It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired.  This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _champusSponsorName = new HL7V23Field
        {
            field = message[@"IN2"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_champusSponsorName.field.FieldRepetitions != null && _champusSponsorName.field.FieldRepetitions.Count > 0)
        {
            _champusSponsorName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_champusSponsorName, fieldData);
        }

        return _champusSponsorName;
    } 
}

internal HL7V23Field _champusIDNumber;

public HL7V23Field ChampusIDNumber
{
    get
    {
        if (_champusIDNumber != null)
        {
            return _champusIDNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.10",
            Type = @"Field",
            Position = @"IN2.10",
            Name = @"Champus ID Number",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the Champus ID number, defined by HCFA or other regulatory agencies, which uniquely identifies a patient’s Champus policy",
            Sample = @"",
            Fields = null
        }

        _champusIDNumber = new HL7V23Field
        {
            field = message[@"IN2"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_champusIDNumber.field.FieldRepetitions != null && _champusIDNumber.field.FieldRepetitions.Count > 0)
        {
            _champusIDNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_champusIDNumber, fieldData);
        }

        return _champusIDNumber;
    } 
}

internal HL7V23Field _dependentofChampusRecipient;

public HL7V23Field DependentofChampusRecipient
{
    get
    {
        if (_dependentofChampusRecipient != null)
        {
            return _dependentofChampusRecipient;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.11",
            Type = @"Field",
            Position = @"IN2.11",
            Name = @"Dependent of Champus Recipient",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.11.1",
                            Type = @"Component",
                            Position = @"IN2.11.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.11.2",
                            Type = @"Component",
                            Position = @"IN2.11.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.11.3",
                            Type = @"Component",
                            Position = @"IN2.11.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.11.4",
                            Type = @"Component",
                            Position = @"IN2.11.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.11.5",
                            Type = @"Component",
                            Position = @"IN2.11.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.11.6",
                            Type = @"Component",
                            Position = @"IN2.11.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _dependentofChampusRecipient = new HL7V23Field
        {
            field = message[@"IN2"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dependentofChampusRecipient.field.FieldRepetitions != null && _dependentofChampusRecipient.field.FieldRepetitions.Count > 0)
        {
            _dependentofChampusRecipient.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_dependentofChampusRecipient, fieldData);
        }

        return _dependentofChampusRecipient;
    } 
}

internal HL7V23Field _champusOrganization;

public HL7V23Field ChampusOrganization
{
    get
    {
        if (_champusOrganization != null)
        {
            return _champusOrganization;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.12",
            Type = @"Field",
            Position = @"IN2.12",
            Name = @"Champus Organization",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _champusOrganization = new HL7V23Field
        {
            field = message[@"IN2"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_champusOrganization.field.FieldRepetitions != null && _champusOrganization.field.FieldRepetitions.Count > 0)
        {
            _champusOrganization.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_champusOrganization, fieldData);
        }

        return _champusOrganization;
    } 
}

internal HL7V23Field _champusStation;

public HL7V23Field ChampusStation
{
    get
    {
        if (_champusStation != null)
        {
            return _champusStation;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.13",
            Type = @"Field",
            Position = @"IN2.13",
            Name = @"Champus Station",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _champusStation = new HL7V23Field
        {
            field = message[@"IN2"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_champusStation.field.FieldRepetitions != null && _champusStation.field.FieldRepetitions.Count > 0)
        {
            _champusStation.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_champusStation, fieldData);
        }

        return _champusStation;
    } 
}

internal HL7V23Field _champusService;

public HL7V23Field ChampusService
{
    get
    {
        if (_champusService != null)
        {
            return _champusService;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.14",
            Type = @"Field",
            Position = @"IN2.14",
            Name = @"Champus Service",
            Length = 14,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0140",
            TableName = @"Champus Service",
            Description = @"This field is defined by HCFA or other regulatory agencies.  Refer to user-defined table 0140 - Champus service for suggested values.",
            Sample = @"",
            Fields = null
        }

        _champusService = new HL7V23Field
        {
            field = message[@"IN2"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_champusService.field.FieldRepetitions != null && _champusService.field.FieldRepetitions.Count > 0)
        {
            _champusService.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_champusService, fieldData);
        }

        return _champusService;
    } 
}

internal HL7V23Field _champusRankGrade;

public HL7V23Field ChampusRankGrade
{
    get
    {
        if (_champusRankGrade != null)
        {
            return _champusRankGrade;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.15",
            Type = @"Field",
            Position = @"IN2.15",
            Name = @"Champus Rank/Grade",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0141",
            TableName = @"Champus Rank/Grade",
            Description = @"This user-defined field identifies the Champus military rank/grade of the insured.  Refer to userdefined table 0141 - Champus rank/grade for suggested values.",
            Sample = @"",
            Fields = null
        }

        _champusRankGrade = new HL7V23Field
        {
            field = message[@"IN2"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_champusRankGrade.field.FieldRepetitions != null && _champusRankGrade.field.FieldRepetitions.Count > 0)
        {
            _champusRankGrade.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_champusRankGrade, fieldData);
        }

        return _champusRankGrade;
    } 
}

internal HL7V23Field _champusStatus;

public HL7V23Field ChampusStatus
{
    get
    {
        if (_champusStatus != null)
        {
            return _champusStatus;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.16",
            Type = @"Field",
            Position = @"IN2.16",
            Name = @"Champus Status",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0142",
            TableName = @"Champus Status",
            Description = @"This field is defined by HCFA or other regulatory agencies.  Refer to user-defined table 0142 - Champus status for suggested values.",
            Sample = @"",
            Fields = null
        }

        _champusStatus = new HL7V23Field
        {
            field = message[@"IN2"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_champusStatus.field.FieldRepetitions != null && _champusStatus.field.FieldRepetitions.Count > 0)
        {
            _champusStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_champusStatus, fieldData);
        }

        return _champusStatus;
    } 
}

internal HL7V23Field _champusRetireDate;

public HL7V23Field ChampusRetireDate
{
    get
    {
        if (_champusRetireDate != null)
        {
            return _champusRetireDate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.17",
            Type = @"Field",
            Position = @"IN2.17",
            Name = @"Champus Retire Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field is defined by HCFA or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _champusRetireDate = new HL7V23Field
        {
            field = message[@"IN2"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_champusRetireDate.field.FieldRepetitions != null && _champusRetireDate.field.FieldRepetitions.Count > 0)
        {
            _champusRetireDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_champusRetireDate, fieldData);
        }

        return _champusRetireDate;
    } 
}

internal HL7V23Field _champusNonAvailCertonFile;

public HL7V23Field ChampusNonAvailCertonFile
{
    get
    {
        if (_champusNonAvailCertonFile != null)
        {
            return _champusNonAvailCertonFile;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.18",
            Type = @"Field",
            Position = @"IN2.18",
            Name = @"Champus Non-Avail Cert on File",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"Refer to HL7 table 0136 - Yes/no indicator for valid values",
            Sample = @"",
            Fields = null
        }

        _champusNonAvailCertonFile = new HL7V23Field
        {
            field = message[@"IN2"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_champusNonAvailCertonFile.field.FieldRepetitions != null && _champusNonAvailCertonFile.field.FieldRepetitions.Count > 0)
        {
            _champusNonAvailCertonFile.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_champusNonAvailCertonFile, fieldData);
        }

        return _champusNonAvailCertonFile;
    } 
}

internal HL7V23Field _babyCoverage;

public HL7V23Field BabyCoverage
{
    get
    {
        if (_babyCoverage != null)
        {
            return _babyCoverage;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.19",
            Type = @"Field",
            Position = @"IN2.19",
            Name = @"Baby Coverage",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"Refer to HL7 table 0136 - Yes/no indicator for valid values",
            Sample = @"",
            Fields = null
        }

        _babyCoverage = new HL7V23Field
        {
            field = message[@"IN2"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_babyCoverage.field.FieldRepetitions != null && _babyCoverage.field.FieldRepetitions.Count > 0)
        {
            _babyCoverage.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_babyCoverage, fieldData);
        }

        return _babyCoverage;
    } 
}

internal HL7V23Field _combineBabyBill;

public HL7V23Field CombineBabyBill
{
    get
    {
        if (_combineBabyBill != null)
        {
            return _combineBabyBill;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.20",
            Type = @"Field",
            Position = @"IN2.20",
            Name = @"Combine Baby Bill",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"Refer to HL7 table 0136 - Yes/no indicator for valid values",
            Sample = @"",
            Fields = null
        }

        _combineBabyBill = new HL7V23Field
        {
            field = message[@"IN2"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_combineBabyBill.field.FieldRepetitions != null && _combineBabyBill.field.FieldRepetitions.Count > 0)
        {
            _combineBabyBill.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_combineBabyBill, fieldData);
        }

        return _combineBabyBill;
    } 
}

internal HL7V23Field _bloodDeductible;

public HL7V23Field BloodDeductible
{
    get
    {
        if (_bloodDeductible != null)
        {
            return _bloodDeductible;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.21",
            Type = @"Field",
            Position = @"IN2.21",
            Name = @"Blood Deductible",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Use this field instead of UB2-2-blood deductible, as the blood deductible can be associated with the specific insurance plan via this field",
            Sample = @"",
            Fields = null
        }

        _bloodDeductible = new HL7V23Field
        {
            field = message[@"IN2"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_bloodDeductible.field.FieldRepetitions != null && _bloodDeductible.field.FieldRepetitions.Count > 0)
        {
            _bloodDeductible.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_bloodDeductible, fieldData);
        }

        return _bloodDeductible;
    } 
}

internal HL7V23Field _specialCoverageApprovalName;

public HL7V23Field SpecialCoverageApprovalName
{
    get
    {
        if (_specialCoverageApprovalName != null)
        {
            return _specialCoverageApprovalName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.22",
            Type = @"Field",
            Position = @"IN2.22",
            Name = @"Special Coverage Approval Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the individual who approves any special coverage.  Multiple names for the same person may be sent in this field.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.22.1",
                            Type = @"Component",
                            Position = @"IN2.22.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.22.2",
                            Type = @"Component",
                            Position = @"IN2.22.2",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.22.3",
                            Type = @"Component",
                            Position = @"IN2.22.3",
                            Name = @"Middle Initial Or Name",
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
                            Id = @"IN2.22.4",
                            Type = @"Component",
                            Position = @"IN2.22.4",
                            Name = @"Suffix",
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
                            Id = @"IN2.22.5",
                            Type = @"Component",
                            Position = @"IN2.22.5",
                            Name = @"Prefix",
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
                            Id = @"IN2.22.6",
                            Type = @"Component",
                            Position = @"IN2.22.6",
                            Name = @"Degree",
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
                            Id = @"IN2.22.7",
                            Type = @"Component",
                            Position = @"IN2.22.7",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.22.8",
                            Type = @"Component",
                            Position = @"IN2.22.8",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"In general this component provides an indication of the representation provided by the data item.  It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired.  This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _specialCoverageApprovalName = new HL7V23Field
        {
            field = message[@"IN2"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specialCoverageApprovalName.field.FieldRepetitions != null && _specialCoverageApprovalName.field.FieldRepetitions.Count > 0)
        {
            _specialCoverageApprovalName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_specialCoverageApprovalName, fieldData);
        }

        return _specialCoverageApprovalName;
    } 
}

internal HL7V23Field _specialCoverageApprovalTitle;

public HL7V23Field SpecialCoverageApprovalTitle
{
    get
    {
        if (_specialCoverageApprovalTitle != null)
        {
            return _specialCoverageApprovalTitle;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.23",
            Type = @"Field",
            Position = @"IN2.23",
            Name = @"Special Coverage Approval Title",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the title of the person who approves special coverage",
            Sample = @"",
            Fields = null
        }

        _specialCoverageApprovalTitle = new HL7V23Field
        {
            field = message[@"IN2"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specialCoverageApprovalTitle.field.FieldRepetitions != null && _specialCoverageApprovalTitle.field.FieldRepetitions.Count > 0)
        {
            _specialCoverageApprovalTitle.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_specialCoverageApprovalTitle, fieldData);
        }

        return _specialCoverageApprovalTitle;
    } 
}

internal HL7V23Field _nonCoveredInsuranceCode;

public HL7V23Field NonCoveredInsuranceCode
{
    get
    {
        if (_nonCoveredInsuranceCode != null)
        {
            return _nonCoveredInsuranceCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.24",
            Type = @"Field",
            Position = @"IN2.24",
            Name = @"Non-Covered Insurance Code",
            Length = 8,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0143",
            TableName = @"Non-covered insurance code",
            Description = @"This field contains the code that describes why a service is not covered.  Refer to user-defined table 0143 - Non-covered insurance code for suggested values.",
            Sample = @"",
            Fields = null
        }

        _nonCoveredInsuranceCode = new HL7V23Field
        {
            field = message[@"IN2"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nonCoveredInsuranceCode.field.FieldRepetitions != null && _nonCoveredInsuranceCode.field.FieldRepetitions.Count > 0)
        {
            _nonCoveredInsuranceCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_nonCoveredInsuranceCode, fieldData);
        }

        return _nonCoveredInsuranceCode;
    } 
}

internal HL7V23Field _payorID;

public HL7V23Field PayorID
{
    get
    {
        if (_payorID != null)
        {
            return _payorID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.25",
            Type = @"Field",
            Position = @"IN2.25",
            Name = @"Payor ID",
            Length = 59,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field is required for NEIC processing, and it identifies the organization from which reimbursement is expected.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.25.1",
                            Type = @"Component",
                            Position = @"IN2.25.1",
                            Name = @"ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.25.2",
                            Type = @"Component",
                            Position = @"IN2.25.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type.  The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.25.3",
                            Type = @"Component",
                            Position = @"IN2.25.3",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.25.4",
                            Type = @"Component",
                            Position = @"IN2.25.4",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN2.25.4.1",
                            Type = @"SubComponent",
                            Position = @"IN2.25.4.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.25.4.2",
                            Type = @"SubComponent",
                            Position = @"IN2.25.4.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.25.4.3",
                            Type = @"SubComponent",
                            Position = @"IN2.25.4.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.25.5",
                            Type = @"Component",
                            Position = @"IN2.25.5",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.25.6",
                            Type = @"Component",
                            Position = @"IN2.25.6",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN2.25.6.1",
                            Type = @"SubComponent",
                            Position = @"IN2.25.6.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.25.6.2",
                            Type = @"SubComponent",
                            Position = @"IN2.25.6.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.25.6.3",
                            Type = @"SubComponent",
                            Position = @"IN2.25.6.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _payorID = new HL7V23Field
        {
            field = message[@"IN2"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_payorID.field.FieldRepetitions != null && _payorID.field.FieldRepetitions.Count > 0)
        {
            _payorID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_payorID, fieldData);
        }

        return _payorID;
    } 
}

internal HL7V23Field _payorSubscriberID;

public HL7V23Field PayorSubscriberID
{
    get
    {
        if (_payorSubscriberID != null)
        {
            return _payorSubscriberID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.26",
            Type = @"Field",
            Position = @"IN2.26",
            Name = @"Payor Subscriber ID",
            Length = 59,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field is required for NEIC processing, and it identifies the specific office within the insurance carrier that is designated as responsible for the claim.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.26.1",
                            Type = @"Component",
                            Position = @"IN2.26.1",
                            Name = @"ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.26.2",
                            Type = @"Component",
                            Position = @"IN2.26.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type.  The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.26.3",
                            Type = @"Component",
                            Position = @"IN2.26.3",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.26.4",
                            Type = @"Component",
                            Position = @"IN2.26.4",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN2.26.4.1",
                            Type = @"SubComponent",
                            Position = @"IN2.26.4.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.26.4.2",
                            Type = @"SubComponent",
                            Position = @"IN2.26.4.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.26.4.3",
                            Type = @"SubComponent",
                            Position = @"IN2.26.4.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.26.5",
                            Type = @"Component",
                            Position = @"IN2.26.5",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.26.6",
                            Type = @"Component",
                            Position = @"IN2.26.6",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN2.26.6.1",
                            Type = @"SubComponent",
                            Position = @"IN2.26.6.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.26.6.2",
                            Type = @"SubComponent",
                            Position = @"IN2.26.6.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.26.6.3",
                            Type = @"SubComponent",
                            Position = @"IN2.26.6.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _payorSubscriberID = new HL7V23Field
        {
            field = message[@"IN2"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_payorSubscriberID.field.FieldRepetitions != null && _payorSubscriberID.field.FieldRepetitions.Count > 0)
        {
            _payorSubscriberID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_payorSubscriberID, fieldData);
        }

        return _payorSubscriberID;
    } 
}

internal HL7V23Field _eligibilitySource;

public HL7V23Field EligibilitySource
{
    get
    {
        if (_eligibilitySource != null)
        {
            return _eligibilitySource;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.27",
            Type = @"Field",
            Position = @"IN2.27",
            Name = @"Eligibility Source",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0144",
            TableName = @"Eligibility source",
            Description = @"This field is required for NEIC processing, and it identifies the source of information about the insured’s eligibility for benefits.  Refer to user-defined table 0144 - Eligibility source for suggested values.",
            Sample = @"",
            Fields = null
        }

        _eligibilitySource = new HL7V23Field
        {
            field = message[@"IN2"][27],
            fieldData = fieldData
        };

        // check for repetitions
        if (_eligibilitySource.field.FieldRepetitions != null && _eligibilitySource.field.FieldRepetitions.Count > 0)
        {
            _eligibilitySource.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_eligibilitySource, fieldData);
        }

        return _eligibilitySource;
    } 
}

internal HL7V23Field _roomCoverageTypeAmount;

public HL7V23Field RoomCoverageTypeAmount
{
    get
    {
        if (_roomCoverageTypeAmount != null)
        {
            return _roomCoverageTypeAmount;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.28",
            Type = @"Field",
            Position = @"IN2.28",
            Name = @"Room Coverage Type/Amount",
            Length = 25,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_RMC",
            DataTypeName = @"Room Coverage",
            TableId = null,
            TableName = null,
            Description = @" Use this field instead of IN1-40-room rate-semi-private and IN1-41-room rate-private.  This field contains room type (e.g., private, semi-private), amount type (e.g., limit, percentage) and amount covered by the insurance.  Refer to user-defined tables 0145 - Room type and 0146 - Amount type for suggested values",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.28.1",
                            Type = @"Component",
                            Position = @"IN2.28.1",
                            Name = @"Room Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0145",
                            TableName = @"Room type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.28.2",
                            Type = @"Component",
                            Position = @"IN2.28.2",
                            Name = @"Amount Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0146",
                            TableName = @"Amount type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.28.3",
                            Type = @"Component",
                            Position = @"IN2.28.3",
                            Name = @"Coverage Amount",
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

        _roomCoverageTypeAmount = new HL7V23Field
        {
            field = message[@"IN2"][28],
            fieldData = fieldData
        };

        // check for repetitions
        if (_roomCoverageTypeAmount.field.FieldRepetitions != null && _roomCoverageTypeAmount.field.FieldRepetitions.Count > 0)
        {
            _roomCoverageTypeAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_roomCoverageTypeAmount, fieldData);
        }

        return _roomCoverageTypeAmount;
    } 
}

internal HL7V23Field _policyTypeAmount;

public HL7V23Field PolicyTypeAmount
{
    get
    {
        if (_policyTypeAmount != null)
        {
            return _policyTypeAmount;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.29",
            Type = @"Field",
            Position = @"IN2.29",
            Name = @"Policy Type/Amount",
            Length = 25,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_PTA",
            DataTypeName = @"Policy Type",
            TableId = null,
            TableName = null,
            Description = @"This field contains the policy type (e.g., ancillary, major medical) and amount (e.g., amount, percentage, limit) covered by the insurance.  Use this field instead of IN1-38-policy limit-amount.  Refer to user-defined tables 0147 - Policy type and 0193 - Amount class for suggested values",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.29.1",
                            Type = @"Component",
                            Position = @"IN2.29.1",
                            Name = @"Policy Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0147",
                            TableName = @"Policy type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.29.2",
                            Type = @"Component",
                            Position = @"IN2.29.2",
                            Name = @"Amount Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0193",
                            TableName = @"Amount class",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.29.3",
                            Type = @"Component",
                            Position = @"IN2.29.3",
                            Name = @"Amount",
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

        _policyTypeAmount = new HL7V23Field
        {
            field = message[@"IN2"][29],
            fieldData = fieldData
        };

        // check for repetitions
        if (_policyTypeAmount.field.FieldRepetitions != null && _policyTypeAmount.field.FieldRepetitions.Count > 0)
        {
            _policyTypeAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_policyTypeAmount, fieldData);
        }

        return _policyTypeAmount;
    } 
}

internal HL7V23Field _dailyDeductible;

public HL7V23Field DailyDeductible
{
    get
    {
        if (_dailyDeductible != null)
        {
            return _dailyDeductible;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.30",
            Type = @"Field",
            Position = @"IN2.30",
            Name = @"Daily Deductible",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_DDI",
            DataTypeName = @"Daily Deductible",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of days after which the daily deductible begins, the amount of the deductible, and the number of days to apply the deductible",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.30.1",
                            Type = @"Component",
                            Position = @"IN2.30.1",
                            Name = @"Delay Days",
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
                            Id = @"IN2.30.2",
                            Type = @"Component",
                            Position = @"IN2.30.2",
                            Name = @"Amount",
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
                            Id = @"IN2.30.3",
                            Type = @"Component",
                            Position = @"IN2.30.3",
                            Name = @"Number Of Days",
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

        _dailyDeductible = new HL7V23Field
        {
            field = message[@"IN2"][30],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dailyDeductible.field.FieldRepetitions != null && _dailyDeductible.field.FieldRepetitions.Count > 0)
        {
            _dailyDeductible.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_dailyDeductible, fieldData);
        }

        return _dailyDeductible;
    } 
}

internal HL7V23Field _livingDependency;

public HL7V23Field LivingDependency
{
    get
    {
        if (_livingDependency != null)
        {
            return _livingDependency;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.31",
            Type = @"Field",
            Position = @"IN2.31",
            Name = @"Living Dependency",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0223",
            TableName = @"Living dependency",
            Description = @"This field identifies the specific living conditions for the insured.  Refer to user-defined table 0223- Living dependency for suggested values",
            Sample = @"",
            Fields = null
        }

        _livingDependency = new HL7V23Field
        {
            field = message[@"IN2"][31],
            fieldData = fieldData
        };

        // check for repetitions
        if (_livingDependency.field.FieldRepetitions != null && _livingDependency.field.FieldRepetitions.Count > 0)
        {
            _livingDependency.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_livingDependency, fieldData);
        }

        return _livingDependency;
    } 
}

internal HL7V23Field _ambulatoryStatus;

public HL7V23Field AmbulatoryStatus
{
    get
    {
        if (_ambulatoryStatus != null)
        {
            return _ambulatoryStatus;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.32",
            Type = @"Field",
            Position = @"IN2.32",
            Name = @"Ambulatory Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0009",
            TableName = @"Ambulatory status",
            Description = @"This field identifies the insured’s state of mobility.  Refer to user-defined table 0009 - Ambulatory status for suggested values.",
            Sample = @"",
            Fields = null
        }

        _ambulatoryStatus = new HL7V23Field
        {
            field = message[@"IN2"][32],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ambulatoryStatus.field.FieldRepetitions != null && _ambulatoryStatus.field.FieldRepetitions.Count > 0)
        {
            _ambulatoryStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_ambulatoryStatus, fieldData);
        }

        return _ambulatoryStatus;
    } 
}

internal HL7V23Field _citizenship;

public HL7V23Field Citizenship
{
    get
    {
        if (_citizenship != null)
        {
            return _citizenship;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.33",
            Type = @"Field",
            Position = @"IN2.33",
            Name = @"Citizenship",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0171",
            TableName = @"Citizenship",
            Description = @"This field contains the code that identifies the insured’s citizenship.  HL7 recommends using ISO table 3166 as the suggested values in user-defined table 0171 - Citizenship.",
            Sample = @"",
            Fields = null
        }

        _citizenship = new HL7V23Field
        {
            field = message[@"IN2"][33],
            fieldData = fieldData
        };

        // check for repetitions
        if (_citizenship.field.FieldRepetitions != null && _citizenship.field.FieldRepetitions.Count > 0)
        {
            _citizenship.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_citizenship, fieldData);
        }

        return _citizenship;
    } 
}

internal HL7V23Field _primaryLanguage;

public HL7V23Field PrimaryLanguage
{
    get
    {
        if (_primaryLanguage != null)
        {
            return _primaryLanguage;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.34",
            Type = @"Field",
            Position = @"IN2.34",
            Name = @"Primary Language",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0296",
            TableName = @"Primary language",
            Description = @"This field identifies the insured’s primary speaking language.  HL7 recommends using ISO table 639 as the suggested values in user-defined table 0296 - Language.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.34.1",
                            Type = @"Component",
                            Position = @"IN2.34.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.34.2",
                            Type = @"Component",
                            Position = @"IN2.34.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.34.3",
                            Type = @"Component",
                            Position = @"IN2.34.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.34.4",
                            Type = @"Component",
                            Position = @"IN2.34.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.34.5",
                            Type = @"Component",
                            Position = @"IN2.34.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.34.6",
                            Type = @"Component",
                            Position = @"IN2.34.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _primaryLanguage = new HL7V23Field
        {
            field = message[@"IN2"][34],
            fieldData = fieldData
        };

        // check for repetitions
        if (_primaryLanguage.field.FieldRepetitions != null && _primaryLanguage.field.FieldRepetitions.Count > 0)
        {
            _primaryLanguage.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_primaryLanguage, fieldData);
        }

        return _primaryLanguage;
    } 
}

internal HL7V23Field _livingArrangement;

public HL7V23Field LivingArrangement
{
    get
    {
        if (_livingArrangement != null)
        {
            return _livingArrangement;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.35",
            Type = @"Field",
            Position = @"IN2.35",
            Name = @"Living Arrangement",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0220",
            TableName = @"Living arrangement",
            Description = @"This field indicates the situation in which the insured person lives at his primary residence.  Refer to user-defined table 0220 - Living arrangement for suggested values.",
            Sample = @"",
            Fields = null
        }

        _livingArrangement = new HL7V23Field
        {
            field = message[@"IN2"][35],
            fieldData = fieldData
        };

        // check for repetitions
        if (_livingArrangement.field.FieldRepetitions != null && _livingArrangement.field.FieldRepetitions.Count > 0)
        {
            _livingArrangement.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_livingArrangement, fieldData);
        }

        return _livingArrangement;
    } 
}

internal HL7V23Field _publicityIndicator;

public HL7V23Field PublicityIndicator
{
    get
    {
        if (_publicityIndicator != null)
        {
            return _publicityIndicator;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.36",
            Type = @"Field",
            Position = @"IN2.36",
            Name = @"Publicity Indicator",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0215",
            TableName = @"Publicity code",
            Description = @"This field contains a user-defined code indicating what level of publicity is allowed (e.g., No Publicity, Family Only) for the insured.  Refer to user-defined table 0215 - Publicity code for suggested values.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.36.1",
                            Type = @"Component",
                            Position = @"IN2.36.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.36.2",
                            Type = @"Component",
                            Position = @"IN2.36.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.36.3",
                            Type = @"Component",
                            Position = @"IN2.36.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.36.4",
                            Type = @"Component",
                            Position = @"IN2.36.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.36.5",
                            Type = @"Component",
                            Position = @"IN2.36.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.36.6",
                            Type = @"Component",
                            Position = @"IN2.36.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _publicityIndicator = new HL7V23Field
        {
            field = message[@"IN2"][36],
            fieldData = fieldData
        };

        // check for repetitions
        if (_publicityIndicator.field.FieldRepetitions != null && _publicityIndicator.field.FieldRepetitions.Count > 0)
        {
            _publicityIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_publicityIndicator, fieldData);
        }

        return _publicityIndicator;
    } 
}

internal HL7V23Field _protectionIndicator;

public HL7V23Field ProtectionIndicator
{
    get
    {
        if (_protectionIndicator != null)
        {
            return _protectionIndicator;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.37",
            Type = @"Field",
            Position = @"IN2.37",
            Name = @"Protection Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field identifies the insured’s protection, which determines whether or not access to information about this enrollee should be restricted from users who do not have adequate authority.  Refer to HL7 table 0136 - Yes/no indicator for valid values. 

Y restrict access
N do not restrict access",
            Sample = @"",
            Fields = null
        }

        _protectionIndicator = new HL7V23Field
        {
            field = message[@"IN2"][37],
            fieldData = fieldData
        };

        // check for repetitions
        if (_protectionIndicator.field.FieldRepetitions != null && _protectionIndicator.field.FieldRepetitions.Count > 0)
        {
            _protectionIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_protectionIndicator, fieldData);
        }

        return _protectionIndicator;
    } 
}

internal HL7V23Field _studentIndicator;

public HL7V23Field StudentIndicator
{
    get
    {
        if (_studentIndicator != null)
        {
            return _studentIndicator;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.38",
            Type = @"Field",
            Position = @"IN2.38",
            Name = @"Student Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0231",
            TableName = @"Student status",
            Description = @"This field identifies whether the insured is currently a student or not, and whether the patient is a full-time or a part-time student.  This field does not indicate the degree level (high school, college) of student, or his/her field of study (accounting, engineering, etc.).  Refer to user-defined table 0231 - Student status for suggested values.",
            Sample = @"",
            Fields = null
        }

        _studentIndicator = new HL7V23Field
        {
            field = message[@"IN2"][38],
            fieldData = fieldData
        };

        // check for repetitions
        if (_studentIndicator.field.FieldRepetitions != null && _studentIndicator.field.FieldRepetitions.Count > 0)
        {
            _studentIndicator.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_studentIndicator, fieldData);
        }

        return _studentIndicator;
    } 
}

internal HL7V23Field _religion;

public HL7V23Field Religion
{
    get
    {
        if (_religion != null)
        {
            return _religion;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.39",
            Type = @"Field",
            Position = @"IN2.39",
            Name = @"Religion",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0006",
            TableName = @"Religion",
            Description = @"This field indicates the type of religion practiced by the insured.  Refer to user-defined table 0006 - Religion for suggested values.",
            Sample = @"",
            Fields = null
        }

        _religion = new HL7V23Field
        {
            field = message[@"IN2"][39],
            fieldData = fieldData
        };

        // check for repetitions
        if (_religion.field.FieldRepetitions != null && _religion.field.FieldRepetitions.Count > 0)
        {
            _religion.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_religion, fieldData);
        }

        return _religion;
    } 
}

internal HL7V23Field _mothersMaidenName;

public HL7V23Field MothersMaidenName
{
    get
    {
        if (_mothersMaidenName != null)
        {
            return _mothersMaidenName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.40",
            Type = @"Field",
            Position = @"IN2.40",
            Name = @"Mother s Maiden Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the insured’s mother’s maiden name.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.40.1",
                            Type = @"Component",
                            Position = @"IN2.40.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.40.2",
                            Type = @"Component",
                            Position = @"IN2.40.2",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.40.3",
                            Type = @"Component",
                            Position = @"IN2.40.3",
                            Name = @"Middle Initial Or Name",
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
                            Id = @"IN2.40.4",
                            Type = @"Component",
                            Position = @"IN2.40.4",
                            Name = @"Suffix",
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
                            Id = @"IN2.40.5",
                            Type = @"Component",
                            Position = @"IN2.40.5",
                            Name = @"Prefix",
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
                            Id = @"IN2.40.6",
                            Type = @"Component",
                            Position = @"IN2.40.6",
                            Name = @"Degree",
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
                            Id = @"IN2.40.7",
                            Type = @"Component",
                            Position = @"IN2.40.7",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.40.8",
                            Type = @"Component",
                            Position = @"IN2.40.8",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"In general this component provides an indication of the representation provided by the data item.  It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired.  This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _mothersMaidenName = new HL7V23Field
        {
            field = message[@"IN2"][40],
            fieldData = fieldData
        };

        // check for repetitions
        if (_mothersMaidenName.field.FieldRepetitions != null && _mothersMaidenName.field.FieldRepetitions.Count > 0)
        {
            _mothersMaidenName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_mothersMaidenName, fieldData);
        }

        return _mothersMaidenName;
    } 
}

internal HL7V23Field _nationalityCode;

public HL7V23Field NationalityCode
{
    get
    {
        if (_nationalityCode != null)
        {
            return _nationalityCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.41",
            Type = @"Field",
            Position = @"IN2.41",
            Name = @"Nationality Code",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0212",
            TableName = @"Nationality",
            Description = @"This field contains a code that identifies the nation or national grouping to which the insured person belongs.  This information may be different from a person’s citizenship in countries in which multiple nationalities are recognized (for example, Spain: Basque, Catalan, etc.).  HL7 recommends using ISO table 3166 as he suggested values in user-defined table 0212 - Nationality.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.41.1",
                            Type = @"Component",
                            Position = @"IN2.41.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.41.2",
                            Type = @"Component",
                            Position = @"IN2.41.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.41.3",
                            Type = @"Component",
                            Position = @"IN2.41.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.41.4",
                            Type = @"Component",
                            Position = @"IN2.41.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.41.5",
                            Type = @"Component",
                            Position = @"IN2.41.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.41.6",
                            Type = @"Component",
                            Position = @"IN2.41.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _nationalityCode = new HL7V23Field
        {
            field = message[@"IN2"][41],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nationalityCode.field.FieldRepetitions != null && _nationalityCode.field.FieldRepetitions.Count > 0)
        {
            _nationalityCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_nationalityCode, fieldData);
        }

        return _nationalityCode;
    } 
}

internal HL7V23Field _ethnicGroup;

public HL7V23Field EthnicGroup
{
    get
    {
        if (_ethnicGroup != null)
        {
            return _ethnicGroup;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.42",
            Type = @"Field",
            Position = @"IN2.42",
            Name = @"Ethnic Group",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0189",
            TableName = @"Ethnic group",
            Description = @"This field indicates the insured’s ethnic group.  ERISA has a published list of ethnic classifications that may be used by local agreement at a site.  Refer to user-defined table 0189 - Ethnic group for suggested values.",
            Sample = @"",
            Fields = null
        }

        _ethnicGroup = new HL7V23Field
        {
            field = message[@"IN2"][42],
            fieldData = fieldData
        };

        // check for repetitions
        if (_ethnicGroup.field.FieldRepetitions != null && _ethnicGroup.field.FieldRepetitions.Count > 0)
        {
            _ethnicGroup.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_ethnicGroup, fieldData);
        }

        return _ethnicGroup;
    } 
}

internal HL7V23Field _maritalStatus;

public HL7V23Field MaritalStatus
{
    get
    {
        if (_maritalStatus != null)
        {
            return _maritalStatus;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.43",
            Type = @"Field",
            Position = @"IN2.43",
            Name = @"Marital Status",
            Length = 1,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0002",
            TableName = @"Marital status",
            Description = @"This field contains the insured’s marital status.  Refer to user-defined table 0002 - Marital status for suggested values.  Same values as those for PID-16-marital status.",
            Sample = @"",
            Fields = null
        }

        _maritalStatus = new HL7V23Field
        {
            field = message[@"IN2"][43],
            fieldData = fieldData
        };

        // check for repetitions
        if (_maritalStatus.field.FieldRepetitions != null && _maritalStatus.field.FieldRepetitions.Count > 0)
        {
            _maritalStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_maritalStatus, fieldData);
        }

        return _maritalStatus;
    } 
}

internal HL7V23Field _employmentStartDate;

public HL7V23Field EmploymentStartDate
{
    get
    {
        if (_employmentStartDate != null)
        {
            return _employmentStartDate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.44",
            Type = @"Field",
            Position = @"IN2.44",
            Name = @"Employment Start Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the date on which the insured’s employment with a particular employer began.",
            Sample = @"",
            Fields = null
        }

        _employmentStartDate = new HL7V23Field
        {
            field = message[@"IN2"][44],
            fieldData = fieldData
        };

        // check for repetitions
        if (_employmentStartDate.field.FieldRepetitions != null && _employmentStartDate.field.FieldRepetitions.Count > 0)
        {
            _employmentStartDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_employmentStartDate, fieldData);
        }

        return _employmentStartDate;
    } 
}

internal HL7V23Field _employmentStopDate;

public HL7V23Field EmploymentStopDate
{
    get
    {
        if (_employmentStopDate != null)
        {
            return _employmentStopDate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.45",
            Type = @"Field",
            Position = @"IN2.45",
            Name = @"Employment Stop Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"his field indicates the date on which the person’s employment with a particular employer ended.",
            Sample = @"",
            Fields = null
        }

        _employmentStopDate = new HL7V23Field
        {
            field = message[@"IN2"][45],
            fieldData = fieldData
        };

        // check for repetitions
        if (_employmentStopDate.field.FieldRepetitions != null && _employmentStopDate.field.FieldRepetitions.Count > 0)
        {
            _employmentStopDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_employmentStopDate, fieldData);
        }

        return _employmentStopDate;
    } 
}

internal HL7V23Field _jobTitle;

public HL7V23Field JobTitle
{
    get
    {
        if (_jobTitle != null)
        {
            return _jobTitle;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.46",
            Type = @"Field",
            Position = @"IN2.46",
            Name = @"Job Title",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains a descriptive name for the insured’s occupation (for example, Sr. Systems Analyst, Sr. Accountant). ",
            Sample = @"",
            Fields = null
        }

        _jobTitle = new HL7V23Field
        {
            field = message[@"IN2"][46],
            fieldData = fieldData
        };

        // check for repetitions
        if (_jobTitle.field.FieldRepetitions != null && _jobTitle.field.FieldRepetitions.Count > 0)
        {
            _jobTitle.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_jobTitle, fieldData);
        }

        return _jobTitle;
    } 
}

internal HL7V23Field _jobCodeClass;

public HL7V23Field JobCodeClass
{
    get
    {
        if (_jobCodeClass != null)
        {
            return _jobCodeClass;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.47",
            Type = @"Field",
            Position = @"IN2.47",
            Name = @"Job Code/Class",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"JCC",
            DataTypeName = @"Job Code Class",
            TableId = null,
            TableName = null,
            Description = @"This field indicates a code that identifies the insured’s job code ( for example, programmer, analyst, doctor, etc.).  Refer to user-defined tables 0327 - Job code and 0328 - Job class for suggested values. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.47.1",
                            Type = @"Component",
                            Position = @"IN2.47.1",
                            Name = @"Job Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0327",
                            TableName = @"Job code",
                            Description = @"This component contains the person’s  job code.  Refer to user-defined table 0327 - job code",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.47.2",
                            Type = @"Component",
                            Position = @"IN2.47.2",
                            Name = @"Job Class",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0328",
                            TableName = @"Employee classification",
                            Description = @"This component contains the person’s employee classification.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _jobCodeClass = new HL7V23Field
        {
            field = message[@"IN2"][47],
            fieldData = fieldData
        };

        // check for repetitions
        if (_jobCodeClass.field.FieldRepetitions != null && _jobCodeClass.field.FieldRepetitions.Count > 0)
        {
            _jobCodeClass.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_jobCodeClass, fieldData);
        }

        return _jobCodeClass;
    } 
}

internal HL7V23Field _jobStatus;

public HL7V23Field JobStatus
{
    get
    {
        if (_jobStatus != null)
        {
            return _jobStatus;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.48",
            Type = @"Field",
            Position = @"IN2.48",
            Name = @"Job Status",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0311",
            TableName = @"Job status",
            Description = @"This field indicates a code that identifies the insured’s current job status (for example, part- time/workers comp, full-time/leave of absence, full-time/suspended,   etc.).  Refer to user-defined table 0311 - Job status for suggested values.",
            Sample = @"",
            Fields = null
        }

        _jobStatus = new HL7V23Field
        {
            field = message[@"IN2"][48],
            fieldData = fieldData
        };

        // check for repetitions
        if (_jobStatus.field.FieldRepetitions != null && _jobStatus.field.FieldRepetitions.Count > 0)
        {
            _jobStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_jobStatus, fieldData);
        }

        return _jobStatus;
    } 
}

internal HL7V23Field _employerContactPersonName;

public HL7V23Field EmployerContactPersonName
{
    get
    {
        if (_employerContactPersonName != null)
        {
            return _employerContactPersonName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.49",
            Type = @"Field",
            Position = @"IN2.49",
            Name = @"Employer Contact Person Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the contact person that should be contacted at the insured’s place of employment.  (Joe Smith is the insured.  He works at GTE.  Contact Sue Jones at GTE regarding Joe Smith’s policy).  Multiple names for the same person may be sent in this sequence.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.49.1",
                            Type = @"Component",
                            Position = @"IN2.49.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.49.2",
                            Type = @"Component",
                            Position = @"IN2.49.2",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.49.3",
                            Type = @"Component",
                            Position = @"IN2.49.3",
                            Name = @"Middle Initial Or Name",
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
                            Id = @"IN2.49.4",
                            Type = @"Component",
                            Position = @"IN2.49.4",
                            Name = @"Suffix",
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
                            Id = @"IN2.49.5",
                            Type = @"Component",
                            Position = @"IN2.49.5",
                            Name = @"Prefix",
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
                            Id = @"IN2.49.6",
                            Type = @"Component",
                            Position = @"IN2.49.6",
                            Name = @"Degree",
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
                            Id = @"IN2.49.7",
                            Type = @"Component",
                            Position = @"IN2.49.7",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.49.8",
                            Type = @"Component",
                            Position = @"IN2.49.8",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"In general this component provides an indication of the representation provided by the data item.  It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired.  This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _employerContactPersonName = new HL7V23Field
        {
            field = message[@"IN2"][49],
            fieldData = fieldData
        };

        // check for repetitions
        if (_employerContactPersonName.field.FieldRepetitions != null && _employerContactPersonName.field.FieldRepetitions.Count > 0)
        {
            _employerContactPersonName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_employerContactPersonName, fieldData);
        }

        return _employerContactPersonName;
    } 
}

internal HL7V23Field _employerContactPersonPhoneNumber;

public HL7V23Field EmployerContactPersonPhoneNumber
{
    get
    {
        if (_employerContactPersonPhoneNumber != null)
        {
            return _employerContactPersonPhoneNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.50",
            Type = @"Field",
            Position = @"IN2.50",
            Name = @"Employer Contact Person Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the telephone number for Sue Jones who is the contact person at GTE (Joe Smith’s place of employment).  Joe Smith is the insured.  Multiple phone numbers for the same contact person may be sent in this sequence, not multiple contacts.  The primary telephone number is assumed to be in the first repetition.  When no primary telephone number is sent, a repeat delimiter must be present for the first repetition. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.50.1",
                            Type = @"Component",
                            Position = @"IN2.50.1",
                            Name = @"Telephone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"Defined as the TN data type ( see Section 2.8.40, “TN - telephone number”), except that the length of the country access code has been increased to three",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.50.2",
                            Type = @"Component",
                            Position = @"IN2.50.2",
                            Name = @"Telecommunication Use Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunicationuse code",
                            Description = @"A code that represents a specific use of a telecommunication number.  Refer to HL7 table 0201 - Telecommunication use code for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.50.3",
                            Type = @"Component",
                            Position = @"IN2.50.3",
                            Name = @"Telecommunication Equipment Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunicationequipment type",
                            Description = @"A code that represents the type of telecommunication equipment.  Refer to HL7 table 0202 - Telecommunication equipment type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.50.4",
                            Type = @"Component",
                            Position = @"IN2.50.4",
                            Name = @"Email Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Note: Components five through nine reiterate the basic function of the first component in a delimited form that allows the expression of both local and international telephone numbers.  In Version 2.3, the recommended form for the telephone number is to use the delimited form rather than the unstructured form supported by the first component (which is left in for backward compatibility only). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.50.5",
                            Type = @"Component",
                            Position = @"IN2.50.5",
                            Name = @"Country Code",
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
                            Id = @"IN2.50.6",
                            Type = @"Component",
                            Position = @"IN2.50.6",
                            Name = @"Area/city Code",
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
                            Id = @"IN2.50.7",
                            Type = @"Component",
                            Position = @"IN2.50.7",
                            Name = @"Phone Number",
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
                            Id = @"IN2.50.8",
                            Type = @"Component",
                            Position = @"IN2.50.8",
                            Name = @"Extension",
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
                            Id = @"IN2.50.9",
                            Type = @"Component",
                            Position = @"IN2.50.9",
                            Name = @"Any Text",
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

        _employerContactPersonPhoneNumber = new HL7V23Field
        {
            field = message[@"IN2"][50],
            fieldData = fieldData
        };

        // check for repetitions
        if (_employerContactPersonPhoneNumber.field.FieldRepetitions != null && _employerContactPersonPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            _employerContactPersonPhoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_employerContactPersonPhoneNumber, fieldData);
        }

        return _employerContactPersonPhoneNumber;
    } 
}

internal HL7V23Field _employerContactReason;

public HL7V23Field EmployerContactReason
{
    get
    {
        if (_employerContactReason != null)
        {
            return _employerContactReason;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.51",
            Type = @"Field",
            Position = @"IN2.51",
            Name = @"Employer Contact Reason",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0222",
            TableName = @"Contact reason",
            Description = @"This field contains the reason(s) that Sue Jones should be contacted on behalf of Joe Smith, a GTE employer.  Refer to user-defined table 0222 - Contact reason for suggested values.",
            Sample = @"",
            Fields = null
        }

        _employerContactReason = new HL7V23Field
        {
            field = message[@"IN2"][51],
            fieldData = fieldData
        };

        // check for repetitions
        if (_employerContactReason.field.FieldRepetitions != null && _employerContactReason.field.FieldRepetitions.Count > 0)
        {
            _employerContactReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_employerContactReason, fieldData);
        }

        return _employerContactReason;
    } 
}

internal HL7V23Field _insuredsContactPersonName;

public HL7V23Field InsuredsContactPersonName
{
    get
    {
        if (_insuredsContactPersonName != null)
        {
            return _insuredsContactPersonName;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.52",
            Type = @"Field",
            Position = @"IN2.52",
            Name = @"Insured's Contact Person Name",
            Length = 48,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XPN",
            DataTypeName = @"Extended Person Name",
            TableId = null,
            TableName = null,
            Description = @"This field contains the contact person for the insured",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.52.1",
                            Type = @"Component",
                            Position = @"IN2.52.1",
                            Name = @"Family Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"LastName",
                            TableName = @"LastName",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.52.2",
                            Type = @"Component",
                            Position = @"IN2.52.2",
                            Name = @"Given Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = @"FirstName",
                            TableName = @"First Name",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.52.3",
                            Type = @"Component",
                            Position = @"IN2.52.3",
                            Name = @"Middle Initial Or Name",
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
                            Id = @"IN2.52.4",
                            Type = @"Component",
                            Position = @"IN2.52.4",
                            Name = @"Suffix",
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
                            Id = @"IN2.52.5",
                            Type = @"Component",
                            Position = @"IN2.52.5",
                            Name = @"Prefix",
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
                            Id = @"IN2.52.6",
                            Type = @"Component",
                            Position = @"IN2.52.6",
                            Name = @"Degree",
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
                            Id = @"IN2.52.7",
                            Type = @"Component",
                            Position = @"IN2.52.7",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name.  Refer to HL7 table 0200 - Name type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.52.8",
                            Type = @"Component",
                            Position = @"IN2.52.8",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"In general this component provides an indication of the representation provided by the data item.  It does not necessarily specify the character sets used. Thus, even though the representation might provide an indication of what to expect, the sender is still free to encode the contents using whatever character set is desired.  This component provides only hints for the receiver, so it can make choices regarding what it has been sent and what it is capable of displaying",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _insuredsContactPersonName = new HL7V23Field
        {
            field = message[@"IN2"][52],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsContactPersonName.field.FieldRepetitions != null && _insuredsContactPersonName.field.FieldRepetitions.Count > 0)
        {
            _insuredsContactPersonName.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuredsContactPersonName, fieldData);
        }

        return _insuredsContactPersonName;
    } 
}

internal HL7V23Field _insuredsContactPersonTelephoneNumber;

public HL7V23Field InsuredsContactPersonTelephoneNumber
{
    get
    {
        if (_insuredsContactPersonTelephoneNumber != null)
        {
            return _insuredsContactPersonTelephoneNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.53",
            Type = @"Field",
            Position = @"IN2.53",
            Name = @"Insured s Contact Person Telephone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the telephone number for the contact person for the insured.  Multiple names for the same person may be sent in this contact, not multiple contacts.  The legal name is assumed to be in the first repetition.  When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.53.1",
                            Type = @"Component",
                            Position = @"IN2.53.1",
                            Name = @"Telephone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"Defined as the TN data type ( see Section 2.8.40, “TN - telephone number”), except that the length of the country access code has been increased to three",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.53.2",
                            Type = @"Component",
                            Position = @"IN2.53.2",
                            Name = @"Telecommunication Use Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunicationuse code",
                            Description = @"A code that represents a specific use of a telecommunication number.  Refer to HL7 table 0201 - Telecommunication use code for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.53.3",
                            Type = @"Component",
                            Position = @"IN2.53.3",
                            Name = @"Telecommunication Equipment Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunicationequipment type",
                            Description = @"A code that represents the type of telecommunication equipment.  Refer to HL7 table 0202 - Telecommunication equipment type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.53.4",
                            Type = @"Component",
                            Position = @"IN2.53.4",
                            Name = @"Email Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Note: Components five through nine reiterate the basic function of the first component in a delimited form that allows the expression of both local and international telephone numbers.  In Version 2.3, the recommended form for the telephone number is to use the delimited form rather than the unstructured form supported by the first component (which is left in for backward compatibility only). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.53.5",
                            Type = @"Component",
                            Position = @"IN2.53.5",
                            Name = @"Country Code",
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
                            Id = @"IN2.53.6",
                            Type = @"Component",
                            Position = @"IN2.53.6",
                            Name = @"Area/city Code",
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
                            Id = @"IN2.53.7",
                            Type = @"Component",
                            Position = @"IN2.53.7",
                            Name = @"Phone Number",
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
                            Id = @"IN2.53.8",
                            Type = @"Component",
                            Position = @"IN2.53.8",
                            Name = @"Extension",
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
                            Id = @"IN2.53.9",
                            Type = @"Component",
                            Position = @"IN2.53.9",
                            Name = @"Any Text",
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

        _insuredsContactPersonTelephoneNumber = new HL7V23Field
        {
            field = message[@"IN2"][53],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsContactPersonTelephoneNumber.field.FieldRepetitions != null && _insuredsContactPersonTelephoneNumber.field.FieldRepetitions.Count > 0)
        {
            _insuredsContactPersonTelephoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuredsContactPersonTelephoneNumber, fieldData);
        }

        return _insuredsContactPersonTelephoneNumber;
    } 
}

internal HL7V23Field _insuredsContactPersonReason;

public HL7V23Field InsuredsContactPersonReason
{
    get
    {
        if (_insuredsContactPersonReason != null)
        {
            return _insuredsContactPersonReason;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.54",
            Type = @"Field",
            Position = @"IN2.54",
            Name = @"Insured s Contact Person Reason",
            Length = 2,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0222",
            TableName = @"Contact reason",
            Description = @"This field contains the reason(s) the person should be contacted regarding the insured.  Refer to user-defined table - 0222 - Contact reason for suggested values",
            Sample = @"",
            Fields = null
        }

        _insuredsContactPersonReason = new HL7V23Field
        {
            field = message[@"IN2"][54],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsContactPersonReason.field.FieldRepetitions != null && _insuredsContactPersonReason.field.FieldRepetitions.Count > 0)
        {
            _insuredsContactPersonReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuredsContactPersonReason, fieldData);
        }

        return _insuredsContactPersonReason;
    } 
}

internal HL7V23Field _relationshipToThePatientStartDate;

public HL7V23Field RelationshipToThePatientStartDate
{
    get
    {
        if (_relationshipToThePatientStartDate != null)
        {
            return _relationshipToThePatientStartDate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.55",
            Type = @"Field",
            Position = @"IN2.55",
            Name = @"Relationship To The Patient Start Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the date on which the insured’s patient relationship (defined in IN1-17insured’s relationship to patient) became effective (began). ",
            Sample = @"",
            Fields = null
        }

        _relationshipToThePatientStartDate = new HL7V23Field
        {
            field = message[@"IN2"][55],
            fieldData = fieldData
        };

        // check for repetitions
        if (_relationshipToThePatientStartDate.field.FieldRepetitions != null && _relationshipToThePatientStartDate.field.FieldRepetitions.Count > 0)
        {
            _relationshipToThePatientStartDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_relationshipToThePatientStartDate, fieldData);
        }

        return _relationshipToThePatientStartDate;
    } 
}

internal HL7V23Field _relationshipToThePatientStopDate;

public HL7V23Field RelationshipToThePatientStopDate
{
    get
    {
        if (_relationshipToThePatientStopDate != null)
        {
            return _relationshipToThePatientStopDate;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.56",
            Type = @"Field",
            Position = @"IN2.56",
            Name = @"Relationship To The Patient Stop Date",
            Length = 8,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"DT",
            DataTypeName = @"Date",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the date after which the relationship (defined in IN1-17-insured’s relationship to patient) is no longer effective",
            Sample = @"",
            Fields = null
        }

        _relationshipToThePatientStopDate = new HL7V23Field
        {
            field = message[@"IN2"][56],
            fieldData = fieldData
        };

        // check for repetitions
        if (_relationshipToThePatientStopDate.field.FieldRepetitions != null && _relationshipToThePatientStopDate.field.FieldRepetitions.Count > 0)
        {
            _relationshipToThePatientStopDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_relationshipToThePatientStopDate, fieldData);
        }

        return _relationshipToThePatientStopDate;
    } 
}

internal HL7V23Field _insuranceCompanyContactReason;

public HL7V23Field InsuranceCompanyContactReason
{
    get
    {
        if (_insuranceCompanyContactReason != null)
        {
            return _insuranceCompanyContactReason;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.57",
            Type = @"Field",
            Position = @"IN2.57",
            Name = @"Insurance Company Contact Reason",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0232",
            TableName = @"Insurance company contact reason",
            Description = @"This field contains a user-defined code that specifies how the contact should be used.  Refer to user-defined table 0232 - Insurance company contact reason for suggested values.",
            Sample = @"",
            Fields = null
        }

        _insuranceCompanyContactReason = new HL7V23Field
        {
            field = message[@"IN2"][57],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuranceCompanyContactReason.field.FieldRepetitions != null && _insuranceCompanyContactReason.field.FieldRepetitions.Count > 0)
        {
            _insuranceCompanyContactReason.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuranceCompanyContactReason, fieldData);
        }

        return _insuranceCompanyContactReason;
    } 
}

internal HL7V23Field _insuranceCompanyContactPhoneNumber;

public HL7V23Field InsuranceCompanyContactPhoneNumber
{
    get
    {
        if (_insuranceCompanyContactPhoneNumber != null)
        {
            return _insuranceCompanyContactPhoneNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.58",
            Type = @"Field",
            Position = @"IN2.58",
            Name = @"Insurance Company Contact Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field contains the telephone number of the person who should be contacted at the insurance company for questions regarding an insurance policy/claim, etc.  Multiple phone numbers for the insurance company may be sent in this sequence.  The primary telephone number is assumed to be in the first repetition.  When the primary telephone number is not sent, a repeat delimiter must be sent first for the first repetition.  ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.58.1",
                            Type = @"Component",
                            Position = @"IN2.58.1",
                            Name = @"Telephone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"Defined as the TN data type ( see Section 2.8.40, “TN - telephone number”), except that the length of the country access code has been increased to three",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.58.2",
                            Type = @"Component",
                            Position = @"IN2.58.2",
                            Name = @"Telecommunication Use Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunicationuse code",
                            Description = @"A code that represents a specific use of a telecommunication number.  Refer to HL7 table 0201 - Telecommunication use code for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.58.3",
                            Type = @"Component",
                            Position = @"IN2.58.3",
                            Name = @"Telecommunication Equipment Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunicationequipment type",
                            Description = @"A code that represents the type of telecommunication equipment.  Refer to HL7 table 0202 - Telecommunication equipment type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.58.4",
                            Type = @"Component",
                            Position = @"IN2.58.4",
                            Name = @"Email Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Note: Components five through nine reiterate the basic function of the first component in a delimited form that allows the expression of both local and international telephone numbers.  In Version 2.3, the recommended form for the telephone number is to use the delimited form rather than the unstructured form supported by the first component (which is left in for backward compatibility only). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.58.5",
                            Type = @"Component",
                            Position = @"IN2.58.5",
                            Name = @"Country Code",
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
                            Id = @"IN2.58.6",
                            Type = @"Component",
                            Position = @"IN2.58.6",
                            Name = @"Area/city Code",
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
                            Id = @"IN2.58.7",
                            Type = @"Component",
                            Position = @"IN2.58.7",
                            Name = @"Phone Number",
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
                            Id = @"IN2.58.8",
                            Type = @"Component",
                            Position = @"IN2.58.8",
                            Name = @"Extension",
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
                            Id = @"IN2.58.9",
                            Type = @"Component",
                            Position = @"IN2.58.9",
                            Name = @"Any Text",
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

        _insuranceCompanyContactPhoneNumber = new HL7V23Field
        {
            field = message[@"IN2"][58],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuranceCompanyContactPhoneNumber.field.FieldRepetitions != null && _insuranceCompanyContactPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            _insuranceCompanyContactPhoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuranceCompanyContactPhoneNumber, fieldData);
        }

        return _insuranceCompanyContactPhoneNumber;
    } 
}

internal HL7V23Field _policyScope;

public HL7V23Field PolicyScope
{
    get
    {
        if (_policyScope != null)
        {
            return _policyScope;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.59",
            Type = @"Field",
            Position = @"IN2.59",
            Name = @"Policy Scope",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0312",
            TableName = @"Policy scope",
            Description = @"This field contains a user-defined code designating the extent of the coverage for a participating member (e.g., “single,” “family,” etc.  Refer to user-defined table 0312 - Policy scope for suggested values.",
            Sample = @"",
            Fields = null
        }

        _policyScope = new HL7V23Field
        {
            field = message[@"IN2"][59],
            fieldData = fieldData
        };

        // check for repetitions
        if (_policyScope.field.FieldRepetitions != null && _policyScope.field.FieldRepetitions.Count > 0)
        {
            _policyScope.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_policyScope, fieldData);
        }

        return _policyScope;
    } 
}

internal HL7V23Field _policySource;

public HL7V23Field PolicySource
{
    get
    {
        if (_policySource != null)
        {
            return _policySource;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.60",
            Type = @"Field",
            Position = @"IN2.60",
            Name = @"Policy Source",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0313",
            TableName = @"Policy source",
            Description = @"This user-defined field identifies how the policy information got established.  Refer to userdefined table 0313 - Policy source for suggested values.",
            Sample = @"",
            Fields = null
        }

        _policySource = new HL7V23Field
        {
            field = message[@"IN2"][60],
            fieldData = fieldData
        };

        // check for repetitions
        if (_policySource.field.FieldRepetitions != null && _policySource.field.FieldRepetitions.Count > 0)
        {
            _policySource.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_policySource, fieldData);
        }

        return _policySource;
    } 
}

internal HL7V23Field _patientMemberNumber;

public HL7V23Field PatientMemberNumber
{
    get
    {
        if (_patientMemberNumber != null)
        {
            return _patientMemberNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.61",
            Type = @"Field",
            Position = @"IN2.61",
            Name = @"Patient Member Number",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field contains an identifying number assigned by the payor for each individual covered by the insurance policy issued to the insured.  For example, each individual family member may have a different member number from the insurance policy number issued to the head of household.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.61.1",
                            Type = @"Component",
                            Position = @"IN2.61.1",
                            Name = @"ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.61.2",
                            Type = @"Component",
                            Position = @"IN2.61.2",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Defined as in the CK data type (see Section 2.8.5, “CK - composite ID with check digit”) except that an ST data type is allowed instead of an NM data type.  The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.61.3",
                            Type = @"Component",
                            Position = @"IN2.61.3",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.61.4",
                            Type = @"Component",
                            Position = @"IN2.61.4",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN2.61.4.1",
                            Type = @"SubComponent",
                            Position = @"IN2.61.4.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.61.4.2",
                            Type = @"SubComponent",
                            Position = @"IN2.61.4.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.61.4.3",
                            Type = @"SubComponent",
                            Position = @"IN2.61.4.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.61.5",
                            Type = @"Component",
                            Position = @"IN2.61.5",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.61.6",
                            Type = @"Component",
                            Position = @"IN2.61.6",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the patient.  This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN2.61.6.1",
                            Type = @"SubComponent",
                            Position = @"IN2.61.6.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.61.6.2",
                            Type = @"SubComponent",
                            Position = @"IN2.61.6.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.61.6.3",
                            Type = @"SubComponent",
                            Position = @"IN2.61.6.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _patientMemberNumber = new HL7V23Field
        {
            field = message[@"IN2"][61],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientMemberNumber.field.FieldRepetitions != null && _patientMemberNumber.field.FieldRepetitions.Count > 0)
        {
            _patientMemberNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_patientMemberNumber, fieldData);
        }

        return _patientMemberNumber;
    } 
}

internal HL7V23Field _guarantorsRelationshipToInsured;

public HL7V23Field GuarantorsRelationshipToInsured
{
    get
    {
        if (_guarantorsRelationshipToInsured != null)
        {
            return _guarantorsRelationshipToInsured;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.62",
            Type = @"Field",
            Position = @"IN2.62",
            Name = @"Guarantor's Relationship To Insured",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0063",
            TableName = @"Relationship",
            Description = @"This field specifies the relationship of the guarantor to the insurance subscriber.  Refer to userdefined table 0063-Relationship for suggested values",
            Sample = @"",
            Fields = null
        }

        _guarantorsRelationshipToInsured = new HL7V23Field
        {
            field = message[@"IN2"][62],
            fieldData = fieldData
        };

        // check for repetitions
        if (_guarantorsRelationshipToInsured.field.FieldRepetitions != null && _guarantorsRelationshipToInsured.field.FieldRepetitions.Count > 0)
        {
            _guarantorsRelationshipToInsured.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_guarantorsRelationshipToInsured, fieldData);
        }

        return _guarantorsRelationshipToInsured;
    } 
}

internal HL7V23Field _insuredsTelephoneNumberHome;

public HL7V23Field InsuredsTelephoneNumberHome
{
    get
    {
        if (_insuredsTelephoneNumberHome != null)
        {
            return _insuredsTelephoneNumberHome;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.63",
            Type = @"Field",
            Position = @"IN2.63",
            Name = @"Insured's Telephone Number - Home",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"The value of this field represents the insured’s telephone number.  Multiple phone numbers may be sent in this sequence.  The primary telephone number is assumed to be in the first repetition (PRN - Primary, PH - Telephone).  When the primary telephone number is not sent, a repeat delimiter must be sent first for the first repetition. ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.63.1",
                            Type = @"Component",
                            Position = @"IN2.63.1",
                            Name = @"Telephone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"Defined as the TN data type ( see Section 2.8.40, “TN - telephone number”), except that the length of the country access code has been increased to three",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.63.2",
                            Type = @"Component",
                            Position = @"IN2.63.2",
                            Name = @"Telecommunication Use Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunicationuse code",
                            Description = @"A code that represents a specific use of a telecommunication number.  Refer to HL7 table 0201 - Telecommunication use code for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.63.3",
                            Type = @"Component",
                            Position = @"IN2.63.3",
                            Name = @"Telecommunication Equipment Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunicationequipment type",
                            Description = @"A code that represents the type of telecommunication equipment.  Refer to HL7 table 0202 - Telecommunication equipment type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.63.4",
                            Type = @"Component",
                            Position = @"IN2.63.4",
                            Name = @"Email Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Note: Components five through nine reiterate the basic function of the first component in a delimited form that allows the expression of both local and international telephone numbers.  In Version 2.3, the recommended form for the telephone number is to use the delimited form rather than the unstructured form supported by the first component (which is left in for backward compatibility only). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.63.5",
                            Type = @"Component",
                            Position = @"IN2.63.5",
                            Name = @"Country Code",
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
                            Id = @"IN2.63.6",
                            Type = @"Component",
                            Position = @"IN2.63.6",
                            Name = @"Area/city Code",
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
                            Id = @"IN2.63.7",
                            Type = @"Component",
                            Position = @"IN2.63.7",
                            Name = @"Phone Number",
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
                            Id = @"IN2.63.8",
                            Type = @"Component",
                            Position = @"IN2.63.8",
                            Name = @"Extension",
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
                            Id = @"IN2.63.9",
                            Type = @"Component",
                            Position = @"IN2.63.9",
                            Name = @"Any Text",
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

        _insuredsTelephoneNumberHome = new HL7V23Field
        {
            field = message[@"IN2"][63],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsTelephoneNumberHome.field.FieldRepetitions != null && _insuredsTelephoneNumberHome.field.FieldRepetitions.Count > 0)
        {
            _insuredsTelephoneNumberHome.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuredsTelephoneNumberHome, fieldData);
        }

        return _insuredsTelephoneNumberHome;
    } 
}

internal HL7V23Field _insuredsEmployerTelephoneNumber;

public HL7V23Field InsuredsEmployerTelephoneNumber
{
    get
    {
        if (_insuredsEmployerTelephoneNumber != null)
        {
            return _insuredsEmployerTelephoneNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.64",
            Type = @"Field",
            Position = @"IN2.64",
            Name = @"Insured's Employer Telephone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"The value of this field represents the insured’s employer’s telephone number.  Multiple phone numbers may be sent in this sequence.  The primary telephone number is assumed to be in the first repetition.  When the primary telephone number is not sent, a repeat delimiter must be sent first for the first repetition",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.64.1",
                            Type = @"Component",
                            Position = @"IN2.64.1",
                            Name = @"Telephone Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TN",
                            DataTypeName = @"Telephone Number",
                            TableId = @"PhoneNumber",
                            TableName = @"Phone Number",
                            Description = @"Defined as the TN data type ( see Section 2.8.40, “TN - telephone number”), except that the length of the country access code has been increased to three",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.64.2",
                            Type = @"Component",
                            Position = @"IN2.64.2",
                            Name = @"Telecommunication Use Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0201",
                            TableName = @"Telecommunicationuse code",
                            Description = @"A code that represents a specific use of a telecommunication number.  Refer to HL7 table 0201 - Telecommunication use code for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.64.3",
                            Type = @"Component",
                            Position = @"IN2.64.3",
                            Name = @"Telecommunication Equipment Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0202",
                            TableName = @"Telecommunicationequipment type",
                            Description = @"A code that represents the type of telecommunication equipment.  Refer to HL7 table 0202 - Telecommunication equipment type for valid values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.64.4",
                            Type = @"Component",
                            Position = @"IN2.64.4",
                            Name = @"Email Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Note: Components five through nine reiterate the basic function of the first component in a delimited form that allows the expression of both local and international telephone numbers.  In Version 2.3, the recommended form for the telephone number is to use the delimited form rather than the unstructured form supported by the first component (which is left in for backward compatibility only). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.64.5",
                            Type = @"Component",
                            Position = @"IN2.64.5",
                            Name = @"Country Code",
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
                            Id = @"IN2.64.6",
                            Type = @"Component",
                            Position = @"IN2.64.6",
                            Name = @"Area/city Code",
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
                            Id = @"IN2.64.7",
                            Type = @"Component",
                            Position = @"IN2.64.7",
                            Name = @"Phone Number",
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
                            Id = @"IN2.64.8",
                            Type = @"Component",
                            Position = @"IN2.64.8",
                            Name = @"Extension",
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
                            Id = @"IN2.64.9",
                            Type = @"Component",
                            Position = @"IN2.64.9",
                            Name = @"Any Text",
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

        _insuredsEmployerTelephoneNumber = new HL7V23Field
        {
            field = message[@"IN2"][64],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredsEmployerTelephoneNumber.field.FieldRepetitions != null && _insuredsEmployerTelephoneNumber.field.FieldRepetitions.Count > 0)
        {
            _insuredsEmployerTelephoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuredsEmployerTelephoneNumber, fieldData);
        }

        return _insuredsEmployerTelephoneNumber;
    } 
}

internal HL7V23Field _militaryHandicappedProgram;

public HL7V23Field MilitaryHandicappedProgram
{
    get
    {
        if (_militaryHandicappedProgram != null)
        {
            return _militaryHandicappedProgram;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.65",
            Type = @"Field",
            Position = @"IN2.65",
            Name = @"Military Handicapped Program",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the Champus program for the handicapped in which the patient is enrolled",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.65.1",
                            Type = @"Component",
                            Position = @"IN2.65.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.65.2",
                            Type = @"Component",
                            Position = @"IN2.65.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.65.3",
                            Type = @"Component",
                            Position = @"IN2.65.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.65.4",
                            Type = @"Component",
                            Position = @"IN2.65.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.65.5",
                            Type = @"Component",
                            Position = @"IN2.65.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.65.6",
                            Type = @"Component",
                            Position = @"IN2.65.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _militaryHandicappedProgram = new HL7V23Field
        {
            field = message[@"IN2"][65],
            fieldData = fieldData
        };

        // check for repetitions
        if (_militaryHandicappedProgram.field.FieldRepetitions != null && _militaryHandicappedProgram.field.FieldRepetitions.Count > 0)
        {
            _militaryHandicappedProgram.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_militaryHandicappedProgram, fieldData);
        }

        return _militaryHandicappedProgram;
    } 
}

internal HL7V23Field _suspendFlag;

public HL7V23Field SuspendFlag
{
    get
    {
        if (_suspendFlag != null)
        {
            return _suspendFlag;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.66",
            Type = @"Field",
            Position = @"IN2.66",
            Name = @"Suspend Flag",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates whether charges should be suspended for a patient.  Refer to HL7 table 0136 - Yes/no indicator for valid values. 

Y charges should be suspended 
N charges should NOT be suspended ",
            Sample = @"",
            Fields = null
        }

        _suspendFlag = new HL7V23Field
        {
            field = message[@"IN2"][66],
            fieldData = fieldData
        };

        // check for repetitions
        if (_suspendFlag.field.FieldRepetitions != null && _suspendFlag.field.FieldRepetitions.Count > 0)
        {
            _suspendFlag.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_suspendFlag, fieldData);
        }

        return _suspendFlag;
    } 
}

internal HL7V23Field _copayLimitFlag;

public HL7V23Field CopayLimitFlag
{
    get
    {
        if (_copayLimitFlag != null)
        {
            return _copayLimitFlag;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.67",
            Type = @"Field",
            Position = @"IN2.67",
            Name = @"Co-pay Limit Flag",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates if the patient has reached the co-pay limit so that no more co-pay charges should be calculated for the patient.  Refer to HL7 table 0136 - Yes/no indicator for valid values. 

Y the patient is at or exceeds the co-pay limit 
N the patient is under the co-pay limit ",
            Sample = @"",
            Fields = null
        }

        _copayLimitFlag = new HL7V23Field
        {
            field = message[@"IN2"][67],
            fieldData = fieldData
        };

        // check for repetitions
        if (_copayLimitFlag.field.FieldRepetitions != null && _copayLimitFlag.field.FieldRepetitions.Count > 0)
        {
            _copayLimitFlag.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_copayLimitFlag, fieldData);
        }

        return _copayLimitFlag;
    } 
}

internal HL7V23Field _stoplossLimitFlag;

public HL7V23Field StoplossLimitFlag
{
    get
    {
        if (_stoplossLimitFlag != null)
        {
            return _stoplossLimitFlag;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.68",
            Type = @"Field",
            Position = @"IN2.68",
            Name = @"Stoploss Limit Flag",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field indicates if the patient has reached the stoploss limit established in the Contract Master.  Refer to HL7 table 0136 - Yes/no indicator for valid values

Y the patient has reached the stoploss limit 
N the patient has not reached the stoploss limi",
            Sample = @"",
            Fields = null
        }

        _stoplossLimitFlag = new HL7V23Field
        {
            field = message[@"IN2"][68],
            fieldData = fieldData
        };

        // check for repetitions
        if (_stoplossLimitFlag.field.FieldRepetitions != null && _stoplossLimitFlag.field.FieldRepetitions.Count > 0)
        {
            _stoplossLimitFlag.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_stoplossLimitFlag, fieldData);
        }

        return _stoplossLimitFlag;
    } 
}

internal HL7V23Field _insuredOrganizationNameAndID;

public HL7V23Field InsuredOrganizationNameAndID
{
    get
    {
        if (_insuredOrganizationNameAndID != null)
        {
            return _insuredOrganizationNameAndID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.69",
            Type = @"Field",
            Position = @"IN2.69",
            Name = @"Insured Organization Name And ID",
            Length = 130,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And ID For Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the name of the insured if the insured/subscriber is an organization.  Multiple names for the insured may be sent in this sequence, not multiple insured people.  The legal name is assumed to be in the first repetition. When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.69.1",
                            Type = @"Component",
                            Position = @"IN2.69.1",
                            Name = @"Organization Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The name of the specified organization",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.69.2",
                            Type = @"Component",
                            Position = @"IN2.69.2",
                            Name = @"Organization Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name.  Refer to user-defined table 0204 - Organizational name type for suggested values. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.69.3",
                            Type = @"Component",
                            Position = @"IN2.69.3",
                            Name = @"ID Number",
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
                            Id = @"IN2.69.4",
                            Type = @"Component",
                            Position = @"IN2.69.4",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.69.5",
                            Type = @"Component",
                            Position = @"IN2.69.5",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.69.6",
                            Type = @"Component",
                            Position = @"IN2.69.6",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN2.69.6.1",
                            Type = @"SubComponent",
                            Position = @"IN2.69.6.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.69.6.2",
                            Type = @"SubComponent",
                            Position = @"IN2.69.6.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.69.6.3",
                            Type = @"SubComponent",
                            Position = @"IN2.69.6.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.69.7",
                            Type = @"Component",
                            Position = @"IN2.69.7",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.69.8",
                            Type = @"Component",
                            Position = @"IN2.69.8",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning facility is a unique identifier of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN2.69.8.1",
                            Type = @"SubComponent",
                            Position = @"IN2.69.8.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.69.8.2",
                            Type = @"SubComponent",
                            Position = @"IN2.69.8.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.69.8.3",
                            Type = @"SubComponent",
                            Position = @"IN2.69.8.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _insuredOrganizationNameAndID = new HL7V23Field
        {
            field = message[@"IN2"][69],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredOrganizationNameAndID.field.FieldRepetitions != null && _insuredOrganizationNameAndID.field.FieldRepetitions.Count > 0)
        {
            _insuredOrganizationNameAndID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuredOrganizationNameAndID, fieldData);
        }

        return _insuredOrganizationNameAndID;
    } 
}

internal HL7V23Field _insuredEmployerOrganizationNameAndID;

public HL7V23Field InsuredEmployerOrganizationNameAndID
{
    get
    {
        if (_insuredEmployerOrganizationNameAndID != null)
        {
            return _insuredEmployerOrganizationNameAndID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.70",
            Type = @"Field",
            Position = @"IN2.70",
            Name = @"Insured Employer Organization Name And ID",
            Length = 130,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And ID For Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the name of the insured’s employer, or the organization that purchased the insurance for the insured, if the employer is an organization.  Multiple names and identifiers for the same organization may be sent in this field, not multiple organizations.  The legal name is assumed to be in the first repetition. When the legal name is not sent, a repeat delimiter must be sent first for the first repetition.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.70.1",
                            Type = @"Component",
                            Position = @"IN2.70.1",
                            Name = @"Organization Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The name of the specified organization",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.70.2",
                            Type = @"Component",
                            Position = @"IN2.70.2",
                            Name = @"Organization Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0204",
                            TableName = @"Organizational name type",
                            Description = @"A code that represents the type of name i.e., legal name, display name.  Refer to user-defined table 0204 - Organizational name type for suggested values. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.70.3",
                            Type = @"Component",
                            Position = @"IN2.70.3",
                            Name = @"ID Number",
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
                            Id = @"IN2.70.4",
                            Type = @"Component",
                            Position = @"IN2.70.4",
                            Name = @"Check Digit",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The check digit in this data type is not an add-on produced by the message processor.  It is the check digit that is part of the identifying number used in the sending application.  If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.70.5",
                            Type = @"Component",
                            Position = @"IN2.70.5",
                            Name = @"Code Identifying The Check Digit Scheme Employed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0061",
                            TableName = @"Check digit scheme",
                            Description = @"The check digit scheme codes are defined in HL7 table 0061 - Check digit scheme",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.70.6",
                            Type = @"Component",
                            Position = @"IN2.70.6",
                            Name = @"Assigning Authority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning authority is a unique name of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN2.70.6.1",
                            Type = @"SubComponent",
                            Position = @"IN2.70.6.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.70.6.2",
                            Type = @"SubComponent",
                            Position = @"IN2.70.6.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.70.6.3",
                            Type = @"SubComponent",
                            Position = @"IN2.70.6.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.70.7",
                            Type = @"Component",
                            Position = @"IN2.70.7",
                            Name = @"Identifier Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0203",
                            TableName = @"Identifier type",
                            Description = @"A code corresponding to the type of identifier.  In some cases, this code may be used as a qualifier to the “Assigning authority” component.  Refer to user-defined table 0203 - Identifier type for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.70.8",
                            Type = @"Component",
                            Position = @"IN2.70.8",
                            Name = @"Assigning Facility ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The assigning facility is a unique identifier of the system that creates the data.  It is an HD data type.  It is equivalent to the application ID of the placer or filler order number (see Chapter 4).  Assigning authorities are unique across a given HL7 implementation",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"IN2.70.8.1",
                            Type = @"SubComponent",
                            Position = @"IN2.70.8.1",
                            Name = @"Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"Refer to user-defined table 0300 - Namespace ID for suggested values",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.70.8.2",
                            Type = @"SubComponent",
                            Position = @"IN2.70.8.2",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, Universal ID (UID), is a string formatted according to the scheme defined by the third component, Universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong  to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.70.8.3",
                            Type = @"SubComponent",
                            Position = @"IN2.70.8.3",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _insuredEmployerOrganizationNameAndID = new HL7V23Field
        {
            field = message[@"IN2"][70],
            fieldData = fieldData
        };

        // check for repetitions
        if (_insuredEmployerOrganizationNameAndID.field.FieldRepetitions != null && _insuredEmployerOrganizationNameAndID.field.FieldRepetitions.Count > 0)
        {
            _insuredEmployerOrganizationNameAndID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_insuredEmployerOrganizationNameAndID, fieldData);
        }

        return _insuredEmployerOrganizationNameAndID;
    } 
}

internal HL7V23Field _race;

public HL7V23Field Race
{
    get
    {
        if (_race != null)
        {
            return _race;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.71",
            Type = @"Field",
            Position = @"IN2.71",
            Name = @"Race",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0005",
            TableName = @"Race",
            Description = @"RISA has a published list of ethnic classifications that may be used by local agreement at a site.  Refer to user-defined table 0005 - Race for suggested values.",
            Sample = @"",
            Fields = null
        }

        _race = new HL7V23Field
        {
            field = message[@"IN2"][71],
            fieldData = fieldData
        };

        // check for repetitions
        if (_race.field.FieldRepetitions != null && _race.field.FieldRepetitions.Count > 0)
        {
            _race.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_race, fieldData);
        }

        return _race;
    } 
}

internal HL7V23Field _patientRelationshiptoInsured;

public HL7V23Field PatientRelationshiptoInsured
{
    get
    {
        if (_patientRelationshiptoInsured != null)
        {
            return _patientRelationshiptoInsured;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"IN2.72",
            Type = @"Field",
            Position = @"IN2.72",
            Name = @"Patient Relationship to Insured",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the relationship of the patient to the insured, as defined by HCFA or other regulatory agencies.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IN2.72.1",
                            Type = @"Component",
                            Position = @"IN2.72.1",
                            Name = @"Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>.  Different coding schemes will have different elements here",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.72.2",
                            Type = @"Component",
                            Position = @"IN2.72.2",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Name or description of the item in question.  E.g., myocardial infarction or X-ray impression.  Its data type is string (ST). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.72.3",
                            Type = @"Component",
                            Position = @"IN2.72.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier.  This component will serve to identify the coding scheme being used in the identifier component.  The combination of the identifier and name of coding system components will be a unique code for a data item  Each system has a unique identifier. ASTM E123894, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, “Coding schemes.”  Others may be added as needed.  When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.72.4",
                            Type = @"Component",
                            Position = @"IN2.72.4",
                            Name = @"Alternate Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.72.5",
                            Type = @"Component",
                            Position = @"IN2.72.5",
                            Name = @"Alternate Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"IN2.72.6",
                            Type = @"Component",
                            Position = @"IN2.72.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system.  If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component.  If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _patientRelationshiptoInsured = new HL7V23Field
        {
            field = message[@"IN2"][72],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientRelationshiptoInsured.field.FieldRepetitions != null && _patientRelationshiptoInsured.field.FieldRepetitions.Count > 0)
        {
            _patientRelationshiptoInsured.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_patientRelationshiptoInsured, fieldData);
        }

        return _patientRelationshiptoInsured;
    } 
}
    }
}
