using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentIPC
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"IPC"; } }

        public string SegmentId { get { return @"IPC"; } }
        
        public string LongName { get { return @"Imaging Procedure Control Segment"; } }
        
        public string Description { get { return @"The IPC segment contains information about tasks that need to be performed in order to fulfill the request for imaging service. The information includes location, type and instance identification of equipment (acquisition modality) and stages (procedure steps)."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_04",

                    };
            }
        }

        public HL7V251SegmentIPC(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field _accessionIdentifier;

public HL7V251Field AccessionIdentifier
{
    get
    {
        if (_accessionIdentifier != null)
        {
            return _accessionIdentifier;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IPC.1",
            Type = @"Field",
            Position = @"IPC.1",
            Name = @"Accession Identifier",
            Length = 80,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"A workflow-management IDIS generated number that identifies the Filler Order for an Imaging Service (Imaging Service Request). This identifier corresponds one-to-one to the Order Filler number but is used in internal tracking of the work by the IDIS and in communication between IDIS within the department. It also has specific requirements to assure its compatibility with DICOM. It is a case of the Entity Identifier data type. Its first component is a string that identifies the Imaging Service Request. A limit of sixteen (16) characters is required to allow compatibility with DICOM. See DICOM Standard Part 3 for further details on DICOM Attribute (0008,0050) that conveys information identical to the component one of this field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IPC.1.1",
                            Type = @"Component",
                            Position = @"IPC.1.1",
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
                            Id = @"IPC.1.2",
                            Type = @"Component",
                            Position = @"IPC.1.2",
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
                            Id = @"IPC.1.3",
                            Type = @"Component",
                            Position = @"IPC.1.3",
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
                            Id = @"IPC.1.4",
                            Type = @"Component",
                            Position = @"IPC.1.4",
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

        _accessionIdentifier = new HL7V251Field
        {
            field = message[@"IPC"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_accessionIdentifier.field.FieldRepetitions != null && _accessionIdentifier.field.FieldRepetitions.Count > 0)
        {
            _accessionIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_accessionIdentifier, fieldData);
        }

        return _accessionIdentifier;
    } 
}

internal HL7V251Field _requestedProcedureID;

public HL7V251Field RequestedProcedureID
{
    get
    {
        if (_requestedProcedureID != null)
        {
            return _requestedProcedureID;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IPC.2",
            Type = @"Field",
            Position = @"IPC.2",
            Name = @"Requested Procedure ID",
            Length = 22,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field is the identifier of the Requested Procedure that the workflow management IDIS selected to perform as a part of the order for the imaging service. It is a case of the Entity Identifier data type. The first component of this field is a string that identifies the Requested Procedure. A limit of sixteen (16) characters is required to allow compatibility with DICOM. This string must uniquely identify the Requested Procedure within the scope of the order (as specified by accession number). This uniqueness must persist over time. See DICOM Standard Part 3 for further details on DICOM Attribute (0040,0001) that conveys information identical to the component one of this field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IPC.2.1",
                            Type = @"Component",
                            Position = @"IPC.2.1",
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
                            Id = @"IPC.2.2",
                            Type = @"Component",
                            Position = @"IPC.2.2",
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
                            Id = @"IPC.2.3",
                            Type = @"Component",
                            Position = @"IPC.2.3",
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
                            Id = @"IPC.2.4",
                            Type = @"Component",
                            Position = @"IPC.2.4",
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

        _requestedProcedureID = new HL7V251Field
        {
            field = message[@"IPC"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedProcedureID.field.FieldRepetitions != null && _requestedProcedureID.field.FieldRepetitions.Count > 0)
        {
            _requestedProcedureID.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_requestedProcedureID, fieldData);
        }

        return _requestedProcedureID;
    } 
}

internal HL7V251Field _studyInstanceUID;

public HL7V251Field StudyInstanceUID
{
    get
    {
        if (_studyInstanceUID != null)
        {
            return _studyInstanceUID;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IPC.3",
            Type = @"Field",
            Position = @"IPC.3",
            Name = @"Study Instance UID",
            Length = 70,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"Globally unique identifier assigned by the workflow management IDIS to the Imaging Study under which all images and other DICOM objects produced in the course of the Requested Procedure shall be collected. It is a case of the Entity Identifier data type (Section 2.A.28). Its first component is a string that identifies the Study. A limit of sixty-four (64) characters is required to allow compatibility with DICOM. See DICOM Standard Part 3 for further details on DICOM Attribute (0020,000D) that conveys information identical to component one of this field. The second through fourth components contain the ID of the workflow management IDIS, in the form of the HD data type. The second component is a user-defined coded value that uniquely defines the application from other applications on the network. A limit of five (5) characters is suggested but not required. The second component of the Study Instance UID always identifies the actual filler of an order.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IPC.3.1",
                            Type = @"Component",
                            Position = @"IPC.3.1",
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
                            Id = @"IPC.3.2",
                            Type = @"Component",
                            Position = @"IPC.3.2",
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
                            Id = @"IPC.3.3",
                            Type = @"Component",
                            Position = @"IPC.3.3",
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
                            Id = @"IPC.3.4",
                            Type = @"Component",
                            Position = @"IPC.3.4",
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

        _studyInstanceUID = new HL7V251Field
        {
            field = message[@"IPC"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_studyInstanceUID.field.FieldRepetitions != null && _studyInstanceUID.field.FieldRepetitions.Count > 0)
        {
            _studyInstanceUID.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_studyInstanceUID, fieldData);
        }

        return _studyInstanceUID;
    } 
}

internal HL7V251Field _scheduledProcedureStepID;

public HL7V251Field ScheduledProcedureStepID
{
    get
    {
        if (_scheduledProcedureStepID != null)
        {
            return _scheduledProcedureStepID;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IPC.4",
            Type = @"Field",
            Position = @"IPC.4",
            Name = @"Scheduled Procedure Step ID",
            Length = 22,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field is the identifier of a particular Procedure Step (sub-procedure) of the Requested Procedure that the workflow management IDIS selected to perform as a part of the order for imaging service. It is a case of the Entity Identifier data type. Its first component is a string that identifies the Procedure Step. A limit of sixteen (16) characters is required to allow compatibility with DICOM. This string must uniquely identify the Procedure Step within the scope of the Requested Procedure. This uniqueness must persist over time. See DICOM Standard Part 3 for further details on DICOM Attribute (0040,0009) that conveys information identical to the component one of this field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IPC.4.1",
                            Type = @"Component",
                            Position = @"IPC.4.1",
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
                            Id = @"IPC.4.2",
                            Type = @"Component",
                            Position = @"IPC.4.2",
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
                            Id = @"IPC.4.3",
                            Type = @"Component",
                            Position = @"IPC.4.3",
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
                            Id = @"IPC.4.4",
                            Type = @"Component",
                            Position = @"IPC.4.4",
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

        _scheduledProcedureStepID = new HL7V251Field
        {
            field = message[@"IPC"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_scheduledProcedureStepID.field.FieldRepetitions != null && _scheduledProcedureStepID.field.FieldRepetitions.Count > 0)
        {
            _scheduledProcedureStepID.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_scheduledProcedureStepID, fieldData);
        }

        return _scheduledProcedureStepID;
    } 
}

internal HL7V251Field _modality;

public HL7V251Field Modality
{
    get
    {
        if (_modality != null)
        {
            return _modality;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IPC.5",
            Type = @"Field",
            Position = @"IPC.5",
            Name = @"Modality",
            Length = 16,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"The type of equipment requested to acquire data during performance of a Procedure Step. The acquired data will be used to create the images for the Imaging Study corresponding to the Requested Procedure.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IPC.5.1",
                            Type = @"Component",
                            Position = @"IPC.5.1",
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
                            Id = @"IPC.5.2",
                            Type = @"Component",
                            Position = @"IPC.5.2",
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
                            Id = @"IPC.5.3",
                            Type = @"Component",
                            Position = @"IPC.5.3",
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
                            Id = @"IPC.5.4",
                            Type = @"Component",
                            Position = @"IPC.5.4",
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
                            Id = @"IPC.5.5",
                            Type = @"Component",
                            Position = @"IPC.5.5",
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
                            Id = @"IPC.5.6",
                            Type = @"Component",
                            Position = @"IPC.5.6",
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
                        },
                        }
        }

        _modality = new HL7V251Field
        {
            field = message[@"IPC"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_modality.field.FieldRepetitions != null && _modality.field.FieldRepetitions.Count > 0)
        {
            _modality.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_modality, fieldData);
        }

        return _modality;
    } 
}

internal HL7V251Field _protocolCode;

public HL7V251Field ProtocolCode
{
    get
    {
        if (_protocolCode != null)
        {
            return _protocolCode;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IPC.6",
            Type = @"Field",
            Position = @"IPC.6",
            Name = @"Protocol Code",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"One or more coded entries identifying the protocol according to which the Scheduled Procedure Step shall be performed. Protocol Code(s) may identify particular equipment settings as well as operator's manipulations.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IPC.6.1",
                            Type = @"Component",
                            Position = @"IPC.6.1",
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
                            Id = @"IPC.6.2",
                            Type = @"Component",
                            Position = @"IPC.6.2",
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
                            Id = @"IPC.6.3",
                            Type = @"Component",
                            Position = @"IPC.6.3",
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
                            Id = @"IPC.6.4",
                            Type = @"Component",
                            Position = @"IPC.6.4",
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
                            Id = @"IPC.6.5",
                            Type = @"Component",
                            Position = @"IPC.6.5",
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
                            Id = @"IPC.6.6",
                            Type = @"Component",
                            Position = @"IPC.6.6",
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
                        },
                        }
        }

        _protocolCode = new HL7V251Field
        {
            field = message[@"IPC"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_protocolCode.field.FieldRepetitions != null && _protocolCode.field.FieldRepetitions.Count > 0)
        {
            _protocolCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_protocolCode, fieldData);
        }

        return _protocolCode;
    } 
}

internal HL7V251Field _scheduledStationName;

public HL7V251Field ScheduledStationName
{
    get
    {
        if (_scheduledStationName != null)
        {
            return _scheduledStationName;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IPC.7",
            Type = @"Field",
            Position = @"IPC.7",
            Name = @"Scheduled Station Name",
            Length = 22,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the instance of the modality resource being requested for the performance of a particular Scheduled Procedure Step. It is a case of the Entity Identifier data type. The first component of this field is a string that identifies the particular piece of equipment. A limit of sixteen (16) characters is required to allow compatibility with DICOM. See DICOM Standard Part 3 for further details on DICOM Attribute (0040,0010) that conveys information identical to the component one of this field.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IPC.7.1",
                            Type = @"Component",
                            Position = @"IPC.7.1",
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
                            Id = @"IPC.7.2",
                            Type = @"Component",
                            Position = @"IPC.7.2",
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
                            Id = @"IPC.7.3",
                            Type = @"Component",
                            Position = @"IPC.7.3",
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
                            Id = @"IPC.7.4",
                            Type = @"Component",
                            Position = @"IPC.7.4",
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

        _scheduledStationName = new HL7V251Field
        {
            field = message[@"IPC"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_scheduledStationName.field.FieldRepetitions != null && _scheduledStationName.field.FieldRepetitions.Count > 0)
        {
            _scheduledStationName.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_scheduledStationName, fieldData);
        }

        return _scheduledStationName;
    } 
}

internal HL7V251Field _scheduledProcedureStepLocation;

public HL7V251Field ScheduledProcedureStepLocation
{
    get
    {
        if (_scheduledProcedureStepLocation != null)
        {
            return _scheduledProcedureStepLocation;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IPC.8",
            Type = @"Field",
            Position = @"IPC.8",
            Name = @"Scheduled Procedure Step Location",
            Length = 250,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field specifies a locally defined physical location of the modality resource being requested for performance of particular Scheduled Procedure Step. Although location is usually defined geographically (such as identification of a campus, building, floor, etc.) it may be used for identification of a pool of equipment (resources) formed by any other means. Values for the field shall be drawn from a locally defined coding scheme.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"IPC.8.1",
                            Type = @"Component",
                            Position = @"IPC.8.1",
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
                            Id = @"IPC.8.2",
                            Type = @"Component",
                            Position = @"IPC.8.2",
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
                            Id = @"IPC.8.3",
                            Type = @"Component",
                            Position = @"IPC.8.3",
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
                            Id = @"IPC.8.4",
                            Type = @"Component",
                            Position = @"IPC.8.4",
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
                            Id = @"IPC.8.5",
                            Type = @"Component",
                            Position = @"IPC.8.5",
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
                            Id = @"IPC.8.6",
                            Type = @"Component",
                            Position = @"IPC.8.6",
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
                        },
                        }
        }

        _scheduledProcedureStepLocation = new HL7V251Field
        {
            field = message[@"IPC"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_scheduledProcedureStepLocation.field.FieldRepetitions != null && _scheduledProcedureStepLocation.field.FieldRepetitions.Count > 0)
        {
            _scheduledProcedureStepLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_scheduledProcedureStepLocation, fieldData);
        }

        return _scheduledProcedureStepLocation;
    } 
}

internal HL7V251Field _scheduledAETitle;

public HL7V251Field ScheduledAETitle
{
    get
    {
        if (_scheduledAETitle != null)
        {
            return _scheduledAETitle;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"IPC.9",
            Type = @"Field",
            Position = @"IPC.9",
            Name = @"Scheduled AE Title",
            Length = 16,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the Application Entity Title of the modality resource being requested for performance of a particular Scheduled Procedure Step. Application Entity Title is the identifier that identifies an instance of DICOM-compatible equipment for the purpose of addressing during communication. See DICOM Standard, Part 3 for further details on the DICOM Attribute (0040,0001) that conveys equivalent information. A limit of sixteen (16) characters is required to allow compatibility with DICOM.",
            Sample = @"",
            Fields = null
        }

        _scheduledAETitle = new HL7V251Field
        {
            field = message[@"IPC"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_scheduledAETitle.field.FieldRepetitions != null && _scheduledAETitle.field.FieldRepetitions.Count > 0)
        {
            _scheduledAETitle.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_scheduledAETitle, fieldData);
        }

        return _scheduledAETitle;
    } 
}
    }
}
