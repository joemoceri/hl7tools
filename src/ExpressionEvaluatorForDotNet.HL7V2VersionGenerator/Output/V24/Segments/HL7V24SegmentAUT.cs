using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V24SegmentAUT
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"AUT"; } }

        public string SegmentId { get { return @"AUT"; } }
        
        public string LongName { get { return @"Authorization Information"; } }
        
        public string Description { get { return @"This segment represents an authorization or a pre-authorization for a referred procedure or requested service by the payor covering the patients health care."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_11",

                    };
            }
        }

        public HL7V24SegmentAUT(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V24Field _authorizingPayorPlanID;

public HL7V24Field AuthorizingPayorPlanID
{
    get
    {
        if (_authorizingPayorPlanID != null)
        {
            return _authorizingPayorPlanID;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"AUT.1",
            Type = @"Field",
            Position = @"AUT.1",
            Name = @"Authorizing Payor, Plan ID",
            Length = 250,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0072",
            TableName = @"Insurance plan ID",
            Description = @"This field contains the ID of the coverage plan authorizing treatment. Values should be entries in a locally-defined table of plan codes. User defined Table 0072- Insurance plan ID is used as the HL7 identifier for the user-defined table of values for this field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"AUT.1.1",
                            Type = @"Component",
                            Position = @"AUT.1.1",
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
                            Id = @"AUT.1.2",
                            Type = @"Component",
                            Position = @"AUT.1.2",
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
                            Id = @"AUT.1.3",
                            Type = @"Component",
                            Position = @"AUT.1.3",
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
                            Id = @"AUT.1.4",
                            Type = @"Component",
                            Position = @"AUT.1.4",
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
                            Id = @"AUT.1.5",
                            Type = @"Component",
                            Position = @"AUT.1.5",
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
                            Id = @"AUT.1.6",
                            Type = @"Component",
                            Position = @"AUT.1.6",
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

        _authorizingPayorPlanID = new HL7V24Field
        {
            field = message[@"AUT"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_authorizingPayorPlanID.field.FieldRepetitions != null && _authorizingPayorPlanID.field.FieldRepetitions.Count > 0)
        {
            _authorizingPayorPlanID.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_authorizingPayorPlanID, fieldData);
        }

        return _authorizingPayorPlanID;
    } 
}

internal HL7V24Field _authorizingPayorCompanyID;

public HL7V24Field AuthorizingPayorCompanyID
{
    get
    {
        if (_authorizingPayorCompanyID != null)
        {
            return _authorizingPayorCompanyID;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"AUT.2",
            Type = @"Field",
            Position = @"AUT.2",
            Name = @"Authorizing Payor, Company ID",
            Length = 250,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0285",
            TableName = @"Insurance company ID codes",
            Description = @"This field contains the ID of the insurance company or other entity that administers the authorizing coverage plan. Values may be entries in a locally-defined table of payor codes . User-defined Table 0285 - Insurance company ID codes is used as the HL7 identifier for the user-defined table of values for this field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"AUT.2.1",
                            Type = @"Component",
                            Position = @"AUT.2.1",
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
                            Id = @"AUT.2.2",
                            Type = @"Component",
                            Position = @"AUT.2.2",
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
                            Id = @"AUT.2.3",
                            Type = @"Component",
                            Position = @"AUT.2.3",
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
                            Id = @"AUT.2.4",
                            Type = @"Component",
                            Position = @"AUT.2.4",
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
                            Id = @"AUT.2.5",
                            Type = @"Component",
                            Position = @"AUT.2.5",
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
                            Id = @"AUT.2.6",
                            Type = @"Component",
                            Position = @"AUT.2.6",
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

        _authorizingPayorCompanyID = new HL7V24Field
        {
            field = message[@"AUT"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_authorizingPayorCompanyID.field.FieldRepetitions != null && _authorizingPayorCompanyID.field.FieldRepetitions.Count > 0)
        {
            _authorizingPayorCompanyID.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_authorizingPayorCompanyID, fieldData);
        }

        return _authorizingPayorCompanyID;
    } 
}

internal HL7V24Field _authorizingPayorCompanyName;

public HL7V24Field AuthorizingPayorCompanyName
{
    get
    {
        if (_authorizingPayorCompanyName != null)
        {
            return _authorizingPayorCompanyName;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"AUT.3",
            Type = @"Field",
            Position = @"AUT.3",
            Name = @"Authorizing Payor, Company Name",
            Length = 45,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name of the insurance company or other entity that administers the authorizing coverage plan.",
            Sample = @"",
            Fields = null
        }

        _authorizingPayorCompanyName = new HL7V24Field
        {
            field = message[@"AUT"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_authorizingPayorCompanyName.field.FieldRepetitions != null && _authorizingPayorCompanyName.field.FieldRepetitions.Count > 0)
        {
            _authorizingPayorCompanyName.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_authorizingPayorCompanyName, fieldData);
        }

        return _authorizingPayorCompanyName;
    } 
}

internal HL7V24Field _authorizationEffectiveDate;

public HL7V24Field AuthorizationEffectiveDate
{
    get
    {
        if (_authorizationEffectiveDate != null)
        {
            return _authorizationEffectiveDate;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"AUT.4",
            Type = @"Field",
            Position = @"AUT.4",
            Name = @"Authorization Effective Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the effective date of the authorization.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"AUT.4.1",
                            Type = @"Component",
                            Position = @"AUT.4.1",
                            Name = @"Time Of An Event",
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
                            Id = @"AUT.4.2",
                            Type = @"Component",
                            Position = @"AUT.4.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _authorizationEffectiveDate = new HL7V24Field
        {
            field = message[@"AUT"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_authorizationEffectiveDate.field.FieldRepetitions != null && _authorizationEffectiveDate.field.FieldRepetitions.Count > 0)
        {
            _authorizationEffectiveDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_authorizationEffectiveDate, fieldData);
        }

        return _authorizationEffectiveDate;
    } 
}

internal HL7V24Field _authorizationExpirationDate;

public HL7V24Field AuthorizationExpirationDate
{
    get
    {
        if (_authorizationExpirationDate != null)
        {
            return _authorizationExpirationDate;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"AUT.5",
            Type = @"Field",
            Position = @"AUT.5",
            Name = @"Authorization Expiration Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the expiration date after which the authorization to treat will no longer be in effect from the perspective of the coverage plan.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"AUT.5.1",
                            Type = @"Component",
                            Position = @"AUT.5.1",
                            Name = @"Time Of An Event",
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
                            Id = @"AUT.5.2",
                            Type = @"Component",
                            Position = @"AUT.5.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _authorizationExpirationDate = new HL7V24Field
        {
            field = message[@"AUT"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_authorizationExpirationDate.field.FieldRepetitions != null && _authorizationExpirationDate.field.FieldRepetitions.Count > 0)
        {
            _authorizationExpirationDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_authorizationExpirationDate, fieldData);
        }

        return _authorizationExpirationDate;
    } 
}

internal HL7V24Field _authorizationIdentifier;

public HL7V24Field AuthorizationIdentifier
{
    get
    {
        if (_authorizationIdentifier != null)
        {
            return _authorizationIdentifier;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"AUT.6",
            Type = @"Field",
            Position = @"AUT.6",
            Name = @"Authorization Identifier",
            Length = 30,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains the coverage applications permanent identifier assigned to track the authorization and all related billing documents. This field is conditionally required. It is not required when authorization information is being requested. However, it is required when this segment is contained in a message which is responding to a request and contains the authorization information. This is a composite field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"AUT.6.1",
                            Type = @"Component",
                            Position = @"AUT.6.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. (See Section 2.9.21, HD - hierarchic designator.)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.6.2",
                            Type = @"Component",
                            Position = @"AUT.6.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined Table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.6.3",
                            Type = @"Component",
                            Position = @"AUT.6.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"<universal ID> (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component).  Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.6.4",
                            Type = @"Component",
                            Position = @"AUT.6.4",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"This component governs the interpretation of the second component of the HD.  If the third component is a known UID refer to HL7 Table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _authorizationIdentifier = new HL7V24Field
        {
            field = message[@"AUT"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_authorizationIdentifier.field.FieldRepetitions != null && _authorizationIdentifier.field.FieldRepetitions.Count > 0)
        {
            _authorizationIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_authorizationIdentifier, fieldData);
        }

        return _authorizationIdentifier;
    } 
}

internal HL7V24Field _reimbursementLimit;

public HL7V24Field ReimbursementLimit
{
    get
    {
        if (_reimbursementLimit != null)
        {
            return _reimbursementLimit;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"AUT.7",
            Type = @"Field",
            Position = @"AUT.7",
            Name = @"Reimbursement Limit",
            Length = 25,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CP",
            DataTypeName = @"Composite Price",
            TableId = null,
            TableName = null,
            Description = @"This field contains the dollar limit for reimbursement specified by the coverage plan for the authorized treatment.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"AUT.7.1",
                            Type = @"Component",
                            Position = @"AUT.7.1",
                            Name = @"Price",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"The only required component; usually containing a decimal point. Note that each component of the MO data type (Section 2.9.26, MO - money) is a subcomponent here.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"AUT.7.1.1",
                            Type = @"SubComponent",
                            Position = @"AUT.7.1.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.7.1.2",
                            Type = @"SubComponent",
                            Position = @"AUT.7.1.2",
                            Name = @"Denomination",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, MSH-17-country code is used to determine the default. 

Example:
|99.50^USD|

where USD is the ISO 4217 code for the U.S. American dollar.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.7.2",
                            Type = @"Component",
                            Position = @"AUT.7.2",
                            Name = @"Price Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0205",
                            TableName = @"Price type",
                            Description = @"A coded value, data type ID. Refer to HL7 Table 0205 - Price type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.7.3",
                            Type = @"Component",
                            Position = @"AUT.7.3",
                            Name = @"From Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"Each is a NM data type; together they specify the range. The range can be defined as either time or quantity. For example, the range can indicate that the first 10 minutes of the procedure has one price. Another repetition of the data type can use the range to specify that the following 10 to 60 minutes of the procedure is charged at another price per; a final repetition can specify that the final 60 to N minutes of the procedure at a third price.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.7.4",
                            Type = @"Component",
                            Position = @"AUT.7.4",
                            Name = @"To Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"See <from value> above.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.7.5",
                            Type = @"Component",
                            Position = @"AUT.7.5",
                            Name = @"Range Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"A coded value, data type CE, defined by the standard table of units for either time or quantity  (see for example, the tables in Section 7.1.4, “Coding schemes”).  This describes the units associated with the range, e.g., seconds, minutes, hours, days, quantity (i.e., count); it is required if <from value> and  <to value> are present.

Subcomponents of range units: <identifier (ST)> & <text (ST)> & <name of coding system (IS)> & <alternate identifier (ST)> & <alternate text (ST)> & <name of alternate coding system (IS)>",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"AUT.7.5.1",
                            Type = @"SubComponent",
                            Position = @"AUT.7.5.1",
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
                            Id = @"AUT.7.5.2",
                            Type = @"SubComponent",
                            Position = @"AUT.7.5.2",
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
                            Id = @"AUT.7.5.3",
                            Type = @"SubComponent",
                            Position = @"AUT.7.5.3",
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
                            Id = @"AUT.7.5.4",
                            Type = @"SubComponent",
                            Position = @"AUT.7.5.4",
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
                            Id = @"AUT.7.5.5",
                            Type = @"SubComponent",
                            Position = @"AUT.7.5.5",
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
                            Id = @"AUT.7.5.6",
                            Type = @"SubComponent",
                            Position = @"AUT.7.5.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"AUT.7.6",
                            Type = @"Component",
                            Position = @"AUT.7.6",
                            Name = @"Range Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0298",
                            TableName = @"CP range type",
                            Description = @"Refers to HL7 Table 0298 - CP range type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _reimbursementLimit = new HL7V24Field
        {
            field = message[@"AUT"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_reimbursementLimit.field.FieldRepetitions != null && _reimbursementLimit.field.FieldRepetitions.Count > 0)
        {
            _reimbursementLimit.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_reimbursementLimit, fieldData);
        }

        return _reimbursementLimit;
    } 
}

internal HL7V24Field _requestedNumberofTreatments;

public HL7V24Field RequestedNumberofTreatments
{
    get
    {
        if (_requestedNumberofTreatments != null)
        {
            return _requestedNumberofTreatments;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"AUT.8",
            Type = @"Field",
            Position = @"AUT.8",
            Name = @"Requested Number of Treatments",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the requested number of times that the treatment may be administered to the patient without obtaining additional authorization.",
            Sample = @"",
            Fields = null
        }

        _requestedNumberofTreatments = new HL7V24Field
        {
            field = message[@"AUT"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedNumberofTreatments.field.FieldRepetitions != null && _requestedNumberofTreatments.field.FieldRepetitions.Count > 0)
        {
            _requestedNumberofTreatments.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_requestedNumberofTreatments, fieldData);
        }

        return _requestedNumberofTreatments;
    } 
}

internal HL7V24Field _authorizedNumberofTreatments;

public HL7V24Field AuthorizedNumberofTreatments
{
    get
    {
        if (_authorizedNumberofTreatments != null)
        {
            return _authorizedNumberofTreatments;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"AUT.9",
            Type = @"Field",
            Position = @"AUT.9",
            Name = @"Authorized Number of Treatments",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of times that the authorized treatment may be administered to the patient without obtaining additional authorization.",
            Sample = @"",
            Fields = null
        }

        _authorizedNumberofTreatments = new HL7V24Field
        {
            field = message[@"AUT"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_authorizedNumberofTreatments.field.FieldRepetitions != null && _authorizedNumberofTreatments.field.FieldRepetitions.Count > 0)
        {
            _authorizedNumberofTreatments.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_authorizedNumberofTreatments, fieldData);
        }

        return _authorizedNumberofTreatments;
    } 
}

internal HL7V24Field _processDate;

public HL7V24Field ProcessDate
{
    get
    {
        if (_processDate != null)
        {
            return _processDate;
        }

        var fieldData = new HL7V24FieldData
        {
            Id = @"AUT.10",
            Type = @"Field",
            Position = @"AUT.10",
            Name = @"Process Date",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date that the authorization originated with the authorizing party.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"AUT.10.1",
                            Type = @"Component",
                            Position = @"AUT.10.1",
                            Name = @"Time Of An Event",
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
                            Id = @"AUT.10.2",
                            Type = @"Component",
                            Position = @"AUT.10.2",
                            Name = @"Degree of precision",
                            Length = 0,
                            Usage = @"B",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Degree of precision",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _processDate = new HL7V24Field
        {
            field = message[@"AUT"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_processDate.field.FieldRepetitions != null && _processDate.field.FieldRepetitions.Count > 0)
        {
            _processDate.fieldRepetitions = HL7V2FieldGenerator.GenerateV24FieldRepetitions(_processDate, fieldData);
        }

        return _processDate;
    } 
}
    }
}
