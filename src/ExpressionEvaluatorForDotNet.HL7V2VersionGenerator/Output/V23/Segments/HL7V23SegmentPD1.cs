using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentPD1
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PD1"; } }

        public string SegmentId { get { return @"PD1"; } }
        
        public string LongName { get { return @"Patient Demographic"; } }
        
        public string Description { get { return @"The patient additional demographic segment contains demographic information that is likely to change about the patient."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_03",

                    };
            }
        }

        public HL7V23SegmentPD1(HL7V2Message message)
        {
            this.message = message;
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
            Id = @"PD1.1",
            Type = @"Field",
            Position = @"PD1.1",
            Name = @"Living Dependency",
            Length = 2,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0223",
            TableName = @"Living dependency",
            Description = @"This field identifies specific living conditions (e.g., spouse dependent on patient, walk-up) that are relevant to an evaluation of the patient’s healthcare needs.  This information can be used for discharge planning.  Examples might include Spouse Dependent, Medical Supervision Required, Small Children Dependent.  This field repeats because, for example, “spouse dependent” and “medical supervision required” can apply at the same time.  Refer to user-defined table 0223 - Living dependency for suggested values",
            Sample = @"",
            Fields = null
        }

        _livingDependency = new HL7V23Field
        {
            field = message[@"PD1"][1],
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
            Id = @"PD1.2",
            Type = @"Field",
            Position = @"PD1.2",
            Name = @"Living Arrangement",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0220",
            TableName = @"Living arrangement",
            Description = @"This field identifies the situation in which the patient lives at his residential address.  Examples might include Alone, Family, Relatives, Institution, etc.  Refer to user-defined table 0220 - Patient living arrangement for suggested values",
            Sample = @"",
            Fields = null
        }

        _livingArrangement = new HL7V23Field
        {
            field = message[@"PD1"][2],
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

internal HL7V23Field _patientPrimaryFacility;

public HL7V23Field PatientPrimaryFacility
{
    get
    {
        if (_patientPrimaryFacility != null)
        {
            return _patientPrimaryFacility;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PD1.3",
            Type = @"Field",
            Position = @"PD1.3",
            Name = @"Patient Primary Facility",
            Length = 90,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XON",
            DataTypeName = @"Extended Composite Name And ID For Organizations",
            TableId = null,
            TableName = null,
            Description = @"This field contains the name and identifier that specifies the primary care facility selected by the patient at the time of enrollment in an HMO Insurance Plan.  Multiple facilities are allowed for the same facility.  The legal name of the facility must be sent in the first sequence.  If the legal name of the facility is not sent, then the repeat delimiter must be sent in the first sequence.  See Chapter 2 regarding suggested values for organization name type codes",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PD1.3.1",
                            Type = @"Component",
                            Position = @"PD1.3.1",
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
                            Id = @"PD1.3.2",
                            Type = @"Component",
                            Position = @"PD1.3.2",
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
                            Id = @"PD1.3.3",
                            Type = @"Component",
                            Position = @"PD1.3.3",
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
                            Id = @"PD1.3.4",
                            Type = @"Component",
                            Position = @"PD1.3.4",
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
                            Id = @"PD1.3.5",
                            Type = @"Component",
                            Position = @"PD1.3.5",
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
                            Id = @"PD1.3.6",
                            Type = @"Component",
                            Position = @"PD1.3.6",
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
                            Id = @"PD1.3.6.1",
                            Type = @"SubComponent",
                            Position = @"PD1.3.6.1",
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
                            Id = @"PD1.3.6.2",
                            Type = @"SubComponent",
                            Position = @"PD1.3.6.2",
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
                            Id = @"PD1.3.6.3",
                            Type = @"SubComponent",
                            Position = @"PD1.3.6.3",
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
                            Id = @"PD1.3.7",
                            Type = @"Component",
                            Position = @"PD1.3.7",
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
                            Id = @"PD1.3.8",
                            Type = @"Component",
                            Position = @"PD1.3.8",
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
                            Id = @"PD1.3.8.1",
                            Type = @"SubComponent",
                            Position = @"PD1.3.8.1",
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
                            Id = @"PD1.3.8.2",
                            Type = @"SubComponent",
                            Position = @"PD1.3.8.2",
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
                            Id = @"PD1.3.8.3",
                            Type = @"SubComponent",
                            Position = @"PD1.3.8.3",
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

        _patientPrimaryFacility = new HL7V23Field
        {
            field = message[@"PD1"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientPrimaryFacility.field.FieldRepetitions != null && _patientPrimaryFacility.field.FieldRepetitions.Count > 0)
        {
            _patientPrimaryFacility.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_patientPrimaryFacility, fieldData);
        }

        return _patientPrimaryFacility;
    } 
}

internal HL7V23Field _patientPrimaryCareProviderNameAndIDNo;

public HL7V23Field PatientPrimaryCareProviderNameAndIDNo
{
    get
    {
        if (_patientPrimaryCareProviderNameAndIDNo != null)
        {
            return _patientPrimaryCareProviderNameAndIDNo;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PD1.4",
            Type = @"Field",
            Position = @"PD1.4",
            Name = @"Patient Primary Care Provider Name & ID No.",
            Length = 90,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = null,
            TableName = null,
            Description = @" This field contains the provider name and ID of the managed care primary care provider.  This information is usually selected by the patient at the time of enrollment in the patient’s managed care insurance plan.  Multiple names are allowed for the same person.  The legal name must be sent in the first sequence.  If the legal name is not sent, then the repeat delimiter must be sent in the first sequence",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PD1.4.1",
                            Type = @"Component",
                            Position = @"PD1.4.1",
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
                            Id = @"PD1.4.2",
                            Type = @"Component",
                            Position = @"PD1.4.2",
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
                            Id = @"PD1.4.3",
                            Type = @"Component",
                            Position = @"PD1.4.3",
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
                            Id = @"PD1.4.4",
                            Type = @"Component",
                            Position = @"PD1.4.4",
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
                            Id = @"PD1.4.5",
                            Type = @"Component",
                            Position = @"PD1.4.5",
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
                            Id = @"PD1.4.6",
                            Type = @"Component",
                            Position = @"PD1.4.6",
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
                            Id = @"PD1.4.7",
                            Type = @"Component",
                            Position = @"PD1.4.7",
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
                            Id = @"PD1.4.8",
                            Type = @"Component",
                            Position = @"PD1.4.8",
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
                            Id = @"PD1.4.9",
                            Type = @"Component",
                            Position = @"PD1.4.9",
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
                            Id = @"PD1.4.9.1",
                            Type = @"SubComponent",
                            Position = @"PD1.4.9.1",
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
                            Id = @"PD1.4.9.2",
                            Type = @"SubComponent",
                            Position = @"PD1.4.9.2",
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
                            Id = @"PD1.4.9.3",
                            Type = @"SubComponent",
                            Position = @"PD1.4.9.3",
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
                            Id = @"PD1.4.10",
                            Type = @"Component",
                            Position = @"PD1.4.10",
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
                            Id = @"PD1.4.11",
                            Type = @"Component",
                            Position = @"PD1.4.11",
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
                            Id = @"PD1.4.12",
                            Type = @"Component",
                            Position = @"PD1.4.12",
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
                            Id = @"PD1.4.13",
                            Type = @"Component",
                            Position = @"PD1.4.13",
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
                            Id = @"PD1.4.14",
                            Type = @"Component",
                            Position = @"PD1.4.14",
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
                            Id = @"PD1.4.14.1",
                            Type = @"SubComponent",
                            Position = @"PD1.4.14.1",
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
                            Id = @"PD1.4.14.2",
                            Type = @"SubComponent",
                            Position = @"PD1.4.14.2",
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
                            Id = @"PD1.4.14.3",
                            Type = @"SubComponent",
                            Position = @"PD1.4.14.3",
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

        _patientPrimaryCareProviderNameAndIDNo = new HL7V23Field
        {
            field = message[@"PD1"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_patientPrimaryCareProviderNameAndIDNo.field.FieldRepetitions != null && _patientPrimaryCareProviderNameAndIDNo.field.FieldRepetitions.Count > 0)
        {
            _patientPrimaryCareProviderNameAndIDNo.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_patientPrimaryCareProviderNameAndIDNo, fieldData);
        }

        return _patientPrimaryCareProviderNameAndIDNo;
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
            Id = @"PD1.5",
            Type = @"Field",
            Position = @"PD1.5",
            Name = @"Student Indicator",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0231",
            TableName = @"Student status",
            Description = @"This field indicates if the patient is currently a student or not, and whether the patient is a fulltime or a part-time student.  This field does not indicate the student’s degree level (high school, college, elementary) or the student’s field of study (accounting, engineering, etc.).  Refer to user-defined table 0231 - Student status for suggested values",
            Sample = @"",
            Fields = null
        }

        _studentIndicator = new HL7V23Field
        {
            field = message[@"PD1"][5],
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

internal HL7V23Field _handicap;

public HL7V23Field Handicap
{
    get
    {
        if (_handicap != null)
        {
            return _handicap;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PD1.6",
            Type = @"Field",
            Position = @"PD1.6",
            Name = @"Handicap",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0295",
            TableName = @"Handicap",
            Description = @"This field indicates the nature of the patient’s permanent handicapped condition (e.g., deaf, blind).  A handicapped condition is defined as a physical or mental disability that is permanent.  Transient handicapped conditions should be sent in the ambulatory status.  Refer to user-defined table 0295 - Handicap for suggested values",
            Sample = @"",
            Fields = null
        }

        _handicap = new HL7V23Field
        {
            field = message[@"PD1"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_handicap.field.FieldRepetitions != null && _handicap.field.FieldRepetitions.Count > 0)
        {
            _handicap.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_handicap, fieldData);
        }

        return _handicap;
    } 
}

internal HL7V23Field _livingWill;

public HL7V23Field LivingWill
{
    get
    {
        if (_livingWill != null)
        {
            return _livingWill;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PD1.7",
            Type = @"Field",
            Position = @"PD1.7",
            Name = @"Living Will",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0315",
            TableName = @"Living will",
            Description = @"This field indicates whether or not the patient has a living will and, if so, whether a copy of the living will is on file at the facility.  If the patient does not have a living will, the value of this field indicates whether the patient was provided information on living wills.  Refer to user-defined table 0315 - Living will for suggested values",
            Sample = @"",
            Fields = null
        }

        _livingWill = new HL7V23Field
        {
            field = message[@"PD1"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_livingWill.field.FieldRepetitions != null && _livingWill.field.FieldRepetitions.Count > 0)
        {
            _livingWill.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_livingWill, fieldData);
        }

        return _livingWill;
    } 
}

internal HL7V23Field _organDonor;

public HL7V23Field OrganDonor
{
    get
    {
        if (_organDonor != null)
        {
            return _organDonor;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PD1.8",
            Type = @"Field",
            Position = @"PD1.8",
            Name = @"Organ Donor",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0316",
            TableName = @"Organ donor",
            Description = @"This field indicates whether the patient wants to donate his/her organs and whether his organ donor card is on file with the organization.  Refer to user-defined table 0316 - Organ donor for suggested values",
            Sample = @"",
            Fields = null
        }

        _organDonor = new HL7V23Field
        {
            field = message[@"PD1"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_organDonor.field.FieldRepetitions != null && _organDonor.field.FieldRepetitions.Count > 0)
        {
            _organDonor.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_organDonor, fieldData);
        }

        return _organDonor;
    } 
}

internal HL7V23Field _separateBill;

public HL7V23Field SeparateBill
{
    get
    {
        if (_separateBill != null)
        {
            return _separateBill;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PD1.9",
            Type = @"Field",
            Position = @"PD1.9",
            Name = @"Separate Bill",
            Length = 2,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field specifies that charges for this patient are to be billed separately from other patient bills with the same guarantor.  (This bill is now a patient bill rather than a guarantor bill.)  Refer to HL7 table 0136 - Yes/no indicator for valid values",
            Sample = @"",
            Fields = null
        }

        _separateBill = new HL7V23Field
        {
            field = message[@"PD1"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_separateBill.field.FieldRepetitions != null && _separateBill.field.FieldRepetitions.Count > 0)
        {
            _separateBill.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_separateBill, fieldData);
        }

        return _separateBill;
    } 
}

internal HL7V23Field _duplicatePatient;

public HL7V23Field DuplicatePatient
{
    get
    {
        if (_duplicatePatient != null)
        {
            return _duplicatePatient;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"PD1.10",
            Type = @"Field",
            Position = @"PD1.10",
            Name = @"Duplicate Patient",
            Length = 2,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CX",
            DataTypeName = @"Extended Composite ID With Check Digit",
            TableId = null,
            TableName = null,
            Description = @"This field indicates that a patient is the same as, or a duplicate of, another patient found on the sending system.  The intent is to be informational only and no action is required by the receiver.  Include the patient identifier if the sender knows an identifier for the patient",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PD1.10.1",
                            Type = @"Component",
                            Position = @"PD1.10.1",
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
                            Id = @"PD1.10.2",
                            Type = @"Component",
                            Position = @"PD1.10.2",
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
                            Id = @"PD1.10.3",
                            Type = @"Component",
                            Position = @"PD1.10.3",
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
                            Id = @"PD1.10.4",
                            Type = @"Component",
                            Position = @"PD1.10.4",
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
                            Id = @"PD1.10.4.1",
                            Type = @"SubComponent",
                            Position = @"PD1.10.4.1",
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
                            Id = @"PD1.10.4.2",
                            Type = @"SubComponent",
                            Position = @"PD1.10.4.2",
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
                            Id = @"PD1.10.4.3",
                            Type = @"SubComponent",
                            Position = @"PD1.10.4.3",
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
                            Id = @"PD1.10.5",
                            Type = @"Component",
                            Position = @"PD1.10.5",
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
                            Id = @"PD1.10.6",
                            Type = @"Component",
                            Position = @"PD1.10.6",
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
                            Id = @"PD1.10.6.1",
                            Type = @"SubComponent",
                            Position = @"PD1.10.6.1",
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
                            Id = @"PD1.10.6.2",
                            Type = @"SubComponent",
                            Position = @"PD1.10.6.2",
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
                            Id = @"PD1.10.6.3",
                            Type = @"SubComponent",
                            Position = @"PD1.10.6.3",
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

        _duplicatePatient = new HL7V23Field
        {
            field = message[@"PD1"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_duplicatePatient.field.FieldRepetitions != null && _duplicatePatient.field.FieldRepetitions.Count > 0)
        {
            _duplicatePatient.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_duplicatePatient, fieldData);
        }

        return _duplicatePatient;
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
            Id = @"PD1.11",
            Type = @"Field",
            Position = @"PD1.11",
            Name = @"Publicity Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = @"0215",
            TableName = @"Publicity code",
            Description = @"This field contains a user-defined code indicating what level of publicity is allowed (e.g., No Publicity, Family Only) for the patient.  This code is conveyed at the patient level rather than the visit level.  It is up to the application to decide processing rules for patient vs. visit-level data.  Refer to user-defined table 0215 - Publicity code for suggested values.  Refer to PV2-21-visit publicity code for visit level code",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PD1.11.1",
                            Type = @"Component",
                            Position = @"PD1.11.1",
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
                            Id = @"PD1.11.2",
                            Type = @"Component",
                            Position = @"PD1.11.2",
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
                            Id = @"PD1.11.3",
                            Type = @"Component",
                            Position = @"PD1.11.3",
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
                            Id = @"PD1.11.4",
                            Type = @"Component",
                            Position = @"PD1.11.4",
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
                            Id = @"PD1.11.5",
                            Type = @"Component",
                            Position = @"PD1.11.5",
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
                            Id = @"PD1.11.6",
                            Type = @"Component",
                            Position = @"PD1.11.6",
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
            field = message[@"PD1"][11],
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
            Id = @"PD1.12",
            Type = @"Field",
            Position = @"PD1.12",
            Name = @"Protection Indicator",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field identifies the person’s protection that determines, in turn, whether access to information about this person should be kept from users who do not have adequate authority for the patient.  This indicator is conveyed at the patient level rather that the visit level. It is up to the application to decide processing rules for patient vs. visit level data.  Refer to Chapter 2, HL7 table 0136 - Yes/no indicator for valid values.  Refer to PV2-22-visit protection indicator for visit level code",
            Sample = @"",
            Fields = null
        }

        _protectionIndicator = new HL7V23Field
        {
            field = message[@"PD1"][12],
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
    }
}
