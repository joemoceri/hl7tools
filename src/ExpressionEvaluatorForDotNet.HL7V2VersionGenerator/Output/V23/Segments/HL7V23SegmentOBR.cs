using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentOBR
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"OBR"; } }

        public string SegmentId { get { return @"OBR"; } }
        
        public string LongName { get { return @"Observation request segment"; } }
        
        public string Description { get { return @"The Observation Request (OBR) segment is used to transmit information specific to an order for a diagnostic study or observation, physical exam, or assessment.  

The Observation Request segment defines the attributes of a particular request for diagnostic services (e.g., laboratory, EKG) or clinical observations (e.g., vital signs or physical exam).  When a placer requests a given set of observations, always include an order segment.  For lab tests, the information in the order segment usually applies to a single specimen.  However, there is not a one-to-one relationship between specimen and tests ordered.  Different test batteries will usually require their own order segments even when they can be performed on a single specimen.  In this case, the specimen information must be duplicated in each of the order segments that employ that specimen.  For other diagnostic studies, e.g., chest X-ray, a separate order segment will usually be generated for each diagnostic study"; } }
        
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

        public HL7V23SegmentOBR(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _setIDObservationRequest;

public HL7V23Field SetIDObservationRequest
{
    get
    {
        if (_setIDObservationRequest != null)
        {
            return _setIDObservationRequest;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.1",
            Type = @"Field",
            Position = @"OBR.1",
            Name = @"Set ID - Observation Request",
            Length = 4,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"For the first order transmitted, the sequence number shall be 1; for the second order, it shall be 2; and so on",
            Sample = @"",
            Fields = null
        }

        _setIDObservationRequest = new HL7V23Field
        {
            field = message[@"OBR"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDObservationRequest.field.FieldRepetitions != null && _setIDObservationRequest.field.FieldRepetitions.Count > 0)
        {
            _setIDObservationRequest.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_setIDObservationRequest, fieldData);
        }

        return _setIDObservationRequest;
    } 
}

internal HL7V23Field _placerOrderNumber;

public HL7V23Field PlacerOrderNumber
{
    get
    {
        if (_placerOrderNumber != null)
        {
            return _placerOrderNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.2",
            Type = @"Field",
            Position = @"OBR.2",
            Name = @"Placer Order Number",
            Length = 75,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field is identical to ORC-2-placer order number.

This  field is a special case of the Entity Identifier data type. The first component is a string that identifies an individual order (e.g., OBR).  A limit of fifteen (15) characters is suggested but not required.  It is assigned by the placer (ordering application).  It identifies an order uniquely among all orders from a particular ordering application.  The second through fourth components contain the application ID of the placing application in the same form as the HD data type (Section 2.8.18, “HD - Hierarchic designator”). The second component, namespace ID, is a user-defined coded value that will be uniquely associated with an application.  A limit of six (6) characters is suggested but not required. A given institution or group of intercommunicating institutions should establish a unique list of applications that may be potential placers and fillers and assign unique application IDs. The components are separated by component delimiters.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.2.1",
                            Type = @"Component",
                            Position = @"OBR.2.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4.  (See Section 2.8.18, “HD - hierarchic designator”.) ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.2.2",
                            Type = @"Component",
                            Position = @"OBR.2.2",
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
                            Id = @"OBR.2.3",
                            Type = @"Component",
                            Position = @"OBR.2.3",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.2.4",
                            Type = @"Component",
                            Position = @"OBR.2.4",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _placerOrderNumber = new HL7V23Field
        {
            field = message[@"OBR"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_placerOrderNumber.field.FieldRepetitions != null && _placerOrderNumber.field.FieldRepetitions.Count > 0)
        {
            _placerOrderNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_placerOrderNumber, fieldData);
        }

        return _placerOrderNumber;
    } 
}

internal HL7V23Field _fillerOrderNumber;

public HL7V23Field FillerOrderNumber
{
    get
    {
        if (_fillerOrderNumber != null)
        {
            return _fillerOrderNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.3",
            Type = @"Field",
            Position = @"OBR.3",
            Name = @"Filler Order Number",
            Length = 75,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This is a permanent identifier for an order and its associated observations.  It is a special case of the Entity Identifier data type.

The first component is a string that identifies an individual order segment (e.g., OBR).  It is assigned by the order filling (receiving) application.  It identifies an order uniquely among all orders from a particular filling application (e.g., clinical laboratory). A limit of fifteen (15) characters is suggested but not required. 

The second through fourth components contain the filler application ID, in the form of the HD data type (see Section 2.8.18, “HD - hierarchic designator”). The second component is a user-defined coded value  that uniquely defines the application from other applications on the network.  A limit of six (6) characters is suggested but not required.  The second component of the filler order number always identifies the actual filler of an order",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.3.1",
                            Type = @"Component",
                            Position = @"OBR.3.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4.  (See Section 2.8.18, “HD - hierarchic designator”.) ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.3.2",
                            Type = @"Component",
                            Position = @"OBR.3.2",
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
                            Id = @"OBR.3.3",
                            Type = @"Component",
                            Position = @"OBR.3.3",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.3.4",
                            Type = @"Component",
                            Position = @"OBR.3.4",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _fillerOrderNumber = new HL7V23Field
        {
            field = message[@"OBR"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fillerOrderNumber.field.FieldRepetitions != null && _fillerOrderNumber.field.FieldRepetitions.Count > 0)
        {
            _fillerOrderNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_fillerOrderNumber, fieldData);
        }

        return _fillerOrderNumber;
    } 
}

internal HL7V23Field _universalServiceIdentifier;

public HL7V23Field UniversalServiceIdentifier
{
    get
    {
        if (_universalServiceIdentifier != null)
        {
            return _universalServiceIdentifier;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.4",
            Type = @"Field",
            Position = @"OBR.4",
            Name = @"Universal Service Identifier",
            Length = 200,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the identifier code for the requested observation/test/battery.  This can be based on local and/or “universal” codes.  We recommend the “universal” procedure identifier.  The structure of this CE data type is described in the control section.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.4.1",
                            Type = @"Component",
                            Position = @"OBR.4.1",
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
                            Id = @"OBR.4.2",
                            Type = @"Component",
                            Position = @"OBR.4.2",
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
                            Id = @"OBR.4.3",
                            Type = @"Component",
                            Position = @"OBR.4.3",
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
                            Id = @"OBR.4.4",
                            Type = @"Component",
                            Position = @"OBR.4.4",
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
                            Id = @"OBR.4.5",
                            Type = @"Component",
                            Position = @"OBR.4.5",
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
                            Id = @"OBR.4.6",
                            Type = @"Component",
                            Position = @"OBR.4.6",
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

        _universalServiceIdentifier = new HL7V23Field
        {
            field = message[@"OBR"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_universalServiceIdentifier.field.FieldRepetitions != null && _universalServiceIdentifier.field.FieldRepetitions.Count > 0)
        {
            _universalServiceIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_universalServiceIdentifier, fieldData);
        }

        return _universalServiceIdentifier;
    } 
}

internal HL7V23Field _priority;

public HL7V23Field Priority
{
    get
    {
        if (_priority != null)
        {
            return _priority;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.5",
            Type = @"Field",
            Position = @"OBR.5",
            Name = @"Priority",
            Length = 2,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility only.  It is not used.  Previously priority (e.g., STAT, ASAP), but this information is carried as the sixth component of OBR-27quantity/timing",
            Sample = @"",
            Fields = null
        }

        _priority = new HL7V23Field
        {
            field = message[@"OBR"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_priority.field.FieldRepetitions != null && _priority.field.FieldRepetitions.Count > 0)
        {
            _priority.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_priority, fieldData);
        }

        return _priority;
    } 
}

internal HL7V23Field _requestedDateTime;

public HL7V23Field RequestedDateTime
{
    get
    {
        if (_requestedDateTime != null)
        {
            return _requestedDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.6",
            Type = @"Field",
            Position = @"OBR.6",
            Name = @"Requested Date/Time",
            Length = 26,
            Usage = @"B",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field has been retained for backward compatibility only.  It is not used.  Previously requested date/time.  This information is now carried in the fourth component of the OBR-27quantity/timing",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.6.1",
                            Type = @"Component",
                            Position = @"OBR.6.1",
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
                        }
        }

        _requestedDateTime = new HL7V23Field
        {
            field = message[@"OBR"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedDateTime.field.FieldRepetitions != null && _requestedDateTime.field.FieldRepetitions.Count > 0)
        {
            _requestedDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_requestedDateTime, fieldData);
        }

        return _requestedDateTime;
    } 
}

internal HL7V23Field _observationDateTime;

public HL7V23Field ObservationDateTime
{
    get
    {
        if (_observationDateTime != null)
        {
            return _observationDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.7",
            Type = @"Field",
            Position = @"OBR.7",
            Name = @"Observation Date/Time",
            Length = 26,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field is the clinically relevant date/time of the observation.  In the case of observations taken directly from a subject, it is the actual date and time the observation was obtained.  In the case of a specimen-associated study, this field shall represent the date and time the specimen was collected or obtained.  (This is a results-only field except when the placer or a third-party has already drawn the specimen.)  This field is conditionally required. When the OBR is transmitted as part of a report message, the field must be filled in.  If it is transmitted as part of a request and a sample has been sent along as part of the request, this field must be filled in because this specimen time is the physiologically relevant date/time of the observation",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.7.1",
                            Type = @"Component",
                            Position = @"OBR.7.1",
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
                        }
        }

        _observationDateTime = new HL7V23Field
        {
            field = message[@"OBR"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_observationDateTime.field.FieldRepetitions != null && _observationDateTime.field.FieldRepetitions.Count > 0)
        {
            _observationDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_observationDateTime, fieldData);
        }

        return _observationDateTime;
    } 
}

internal HL7V23Field _observationEndDateTime;

public HL7V23Field ObservationEndDateTime
{
    get
    {
        if (_observationEndDateTime != null)
        {
            return _observationEndDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.8",
            Type = @"Field",
            Position = @"OBR.8",
            Name = @"Observation End Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field is the end date and time of a study or timed specimen collection.  If an observation takes place over a substantial period of time, it will indicate when the observation period ended.  For observations made at a point in time, it will be null.  This is a results field except when the placer or a party other than the filler has already drawn the specimen",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.8.1",
                            Type = @"Component",
                            Position = @"OBR.8.1",
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
                        }
        }

        _observationEndDateTime = new HL7V23Field
        {
            field = message[@"OBR"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_observationEndDateTime.field.FieldRepetitions != null && _observationEndDateTime.field.FieldRepetitions.Count > 0)
        {
            _observationEndDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_observationEndDateTime, fieldData);
        }

        return _observationEndDateTime;
    } 
}

internal HL7V23Field _collectionVolume;

public HL7V23Field CollectionVolume
{
    get
    {
        if (_collectionVolume != null)
        {
            return _collectionVolume;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.9",
            Type = @"Field",
            Position = @"OBR.9",
            Name = @"Collection Volume",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = null,
            TableName = null,
            Description = @"For laboratory tests, the collection volume is the volume of a specimen.  The default unit is ML.  Specifically, units should be expressed in the ISO Standard unit abbreviations (ISO-2955,1977).  This is a results-only field except when the placer or a party has already drawn the specimen.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.9.1",
                            Type = @"Component",
                            Position = @"OBR.9.1",
                            Name = @"Quantity",
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
                            Id = @"OBR.9.2",
                            Type = @"Component",
                            Position = @"OBR.9.2",
                            Name = @"Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The units in which the quantity is expressed.  Field-by-field, default units may be defined within the specifications.  When the observation is measured in the default units, the units need not be transmitted.  If the measure is recorded in units different from the default, the measurement units must be transmitted as the second component.  If the units are ISO+ units, then units should be recorded as lowercase abbreviations as specified in Chapter 7.  If the units are ANSI or local, the units and the source table must be recorded as specified in Chapter 7.  But in these cases the component separator should be replaced by the subcomponent delimiter ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _collectionVolume = new HL7V23Field
        {
            field = message[@"OBR"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_collectionVolume.field.FieldRepetitions != null && _collectionVolume.field.FieldRepetitions.Count > 0)
        {
            _collectionVolume.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_collectionVolume, fieldData);
        }

        return _collectionVolume;
    } 
}

internal HL7V23Field _collectorIdentifier;

public HL7V23Field CollectorIdentifier
{
    get
    {
        if (_collectorIdentifier != null)
        {
            return _collectorIdentifier;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.10",
            Type = @"Field",
            Position = @"OBR.10",
            Name = @"Collector Identifier",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = null,
            TableName = null,
            Description = @"When a specimen is required for the study, this field will identify the person, department, or facility that collected the specimen.  Either name or ID code, or both, may be present.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.10.1",
                            Type = @"Component",
                            Position = @"OBR.10.1",
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
                            Id = @"OBR.10.2",
                            Type = @"Component",
                            Position = @"OBR.10.2",
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
                            Id = @"OBR.10.3",
                            Type = @"Component",
                            Position = @"OBR.10.3",
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
                            Id = @"OBR.10.4",
                            Type = @"Component",
                            Position = @"OBR.10.4",
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
                            Id = @"OBR.10.5",
                            Type = @"Component",
                            Position = @"OBR.10.5",
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
                            Id = @"OBR.10.6",
                            Type = @"Component",
                            Position = @"OBR.10.6",
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
                            Id = @"OBR.10.7",
                            Type = @"Component",
                            Position = @"OBR.10.7",
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
                            Id = @"OBR.10.8",
                            Type = @"Component",
                            Position = @"OBR.10.8",
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
                            Id = @"OBR.10.9",
                            Type = @"Component",
                            Position = @"OBR.10.9",
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
                            Id = @"OBR.10.9.1",
                            Type = @"SubComponent",
                            Position = @"OBR.10.9.1",
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
                            Id = @"OBR.10.9.2",
                            Type = @"SubComponent",
                            Position = @"OBR.10.9.2",
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
                            Id = @"OBR.10.9.3",
                            Type = @"SubComponent",
                            Position = @"OBR.10.9.3",
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
                            Id = @"OBR.10.10",
                            Type = @"Component",
                            Position = @"OBR.10.10",
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
                            Id = @"OBR.10.11",
                            Type = @"Component",
                            Position = @"OBR.10.11",
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
                            Id = @"OBR.10.12",
                            Type = @"Component",
                            Position = @"OBR.10.12",
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
                            Id = @"OBR.10.13",
                            Type = @"Component",
                            Position = @"OBR.10.13",
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
                            Id = @"OBR.10.14",
                            Type = @"Component",
                            Position = @"OBR.10.14",
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
                            Id = @"OBR.10.14.1",
                            Type = @"SubComponent",
                            Position = @"OBR.10.14.1",
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
                            Id = @"OBR.10.14.2",
                            Type = @"SubComponent",
                            Position = @"OBR.10.14.2",
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
                            Id = @"OBR.10.14.3",
                            Type = @"SubComponent",
                            Position = @"OBR.10.14.3",
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

        _collectorIdentifier = new HL7V23Field
        {
            field = message[@"OBR"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_collectorIdentifier.field.FieldRepetitions != null && _collectorIdentifier.field.FieldRepetitions.Count > 0)
        {
            _collectorIdentifier.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_collectorIdentifier, fieldData);
        }

        return _collectorIdentifier;
    } 
}

internal HL7V23Field _specimenActionCode;

public HL7V23Field SpecimenActionCode
{
    get
    {
        if (_specimenActionCode != null)
        {
            return _specimenActionCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.11",
            Type = @"Field",
            Position = @"OBR.11",
            Name = @"Specimen Action Code",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0065",
            TableName = @"Specimen action code",
            Description = @"This field is the action to be taken with respect to the specimens that accompany or precede this order.  The purpose of this field is to further qualify (when appropriate) the general action indicated by the order control code contained in the accompanying ORC segment.  For example, when a new order (ORC - “NW”) is sent to the lab, this field would be used to tell the lab whether or not to collect the specimen (“L” or “O”).",
            Sample = @"",
            Fields = null
        }

        _specimenActionCode = new HL7V23Field
        {
            field = message[@"OBR"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenActionCode.field.FieldRepetitions != null && _specimenActionCode.field.FieldRepetitions.Count > 0)
        {
            _specimenActionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_specimenActionCode, fieldData);
        }

        return _specimenActionCode;
    } 
}

internal HL7V23Field _dangerCode;

public HL7V23Field DangerCode
{
    get
    {
        if (_dangerCode != null)
        {
            return _dangerCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.12",
            Type = @"Field",
            Position = @"OBR.12",
            Name = @"Danger Code",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the code and/or text indicating any known or suspected patient or specimen hazards, e.g., patient with active tuberculosis or blood from a hepatitis patient.  Either code and/or text may be absent.  However, the code is always placed in the first component position and any free text in the second component.  Thus, free text without a code must be preceded by a component delimiter.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.12.1",
                            Type = @"Component",
                            Position = @"OBR.12.1",
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
                            Id = @"OBR.12.2",
                            Type = @"Component",
                            Position = @"OBR.12.2",
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
                            Id = @"OBR.12.3",
                            Type = @"Component",
                            Position = @"OBR.12.3",
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
                            Id = @"OBR.12.4",
                            Type = @"Component",
                            Position = @"OBR.12.4",
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
                            Id = @"OBR.12.5",
                            Type = @"Component",
                            Position = @"OBR.12.5",
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
                            Id = @"OBR.12.6",
                            Type = @"Component",
                            Position = @"OBR.12.6",
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

        _dangerCode = new HL7V23Field
        {
            field = message[@"OBR"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_dangerCode.field.FieldRepetitions != null && _dangerCode.field.FieldRepetitions.Count > 0)
        {
            _dangerCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_dangerCode, fieldData);
        }

        return _dangerCode;
    } 
}

internal HL7V23Field _relevantClinicalInformation;

public HL7V23Field RelevantClinicalInformation
{
    get
    {
        if (_relevantClinicalInformation != null)
        {
            return _relevantClinicalInformation;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.13",
            Type = @"Field",
            Position = @"OBR.13",
            Name = @"Relevant Clinical Information",
            Length = 300,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is the additional clinical information about the patient or specimen.  This field is used to report the suspected diagnosis and clinical findings on requests for interpreted diagnostic studies.  Examples include reporting the amount of inspired carbon dioxide for blood gasses, the point in the menstrual cycle for cervical pap tests, and other conditions that influence test interpretations.  For some orders this information may be sent on a more structured form as a series of OBX segments (see Chapter 7) that immediately follow the order segment.",
            Sample = @"",
            Fields = null
        }

        _relevantClinicalInformation = new HL7V23Field
        {
            field = message[@"OBR"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_relevantClinicalInformation.field.FieldRepetitions != null && _relevantClinicalInformation.field.FieldRepetitions.Count > 0)
        {
            _relevantClinicalInformation.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_relevantClinicalInformation, fieldData);
        }

        return _relevantClinicalInformation;
    } 
}

internal HL7V23Field _specimenReceivedDateTime;

public HL7V23Field SpecimenReceivedDateTime
{
    get
    {
        if (_specimenReceivedDateTime != null)
        {
            return _specimenReceivedDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.14",
            Type = @"Field",
            Position = @"OBR.14",
            Name = @"Specimen Received Date/Time",
            Length = 26,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"For observations requiring a specimen, the specimen received date/time is the actual login time at the diagnostic service.  This field must contain a value when the order is accompanied by a specimen, or when the observation required a specimen and the message is a report.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.14.1",
                            Type = @"Component",
                            Position = @"OBR.14.1",
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
                        }
        }

        _specimenReceivedDateTime = new HL7V23Field
        {
            field = message[@"OBR"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenReceivedDateTime.field.FieldRepetitions != null && _specimenReceivedDateTime.field.FieldRepetitions.Count > 0)
        {
            _specimenReceivedDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_specimenReceivedDateTime, fieldData);
        }

        return _specimenReceivedDateTime;
    } 
}

internal HL7V23Field _specimenSource;

public HL7V23Field SpecimenSource
{
    get
    {
        if (_specimenSource != null)
        {
            return _specimenSource;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.15",
            Type = @"Field",
            Position = @"OBR.15",
            Name = @"Specimen Source",
            Length = 300,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_SPS",
            DataTypeName = @"Specimen Source",
            TableId = null,
            TableName = null,
            Description = @"This field is the site where the specimen should be obtained or where the service should be performed.   

The first component contains the specimen source name or code (as a CE data type component).  (Even in the case of observations whose name implies the source, a source may be required, e.g., blood culture-heart blood.)  Refer to HL7 table 0070 - Source of specimen for valid entries. 

The second component should include free text additives to the specimen such as Heparin, EDTA, or Oxlate, when applicable.   

The third is a free text component describing the method of collection when that information is a part of the order.  When the method of collection is logically an observation result, it should be included as a result segment. 

The fourth component specifies the body site from which the specimen was obtained, and the fifth is the site modifier.  For example, the site could be anticubital foss, and the site modifier “right.”  The components of the CE fields become subcomponents.   Refer to HL7 table 0163 - Administrative site for valid entries

The fifth component indicates whether the specimen is frozen as part of the collection method.  Suggested values are F (Frozen); R (Refrigerated).  If the component is blank, the specimen is assumed to be at room temperature Table 0070 - Specimen source codes ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.15.1",
                            Type = @"Component",
                            Position = @"OBR.15.1",
                            Name = @"Specimen Source Name Or Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = @"0070",
                            TableName = @"Specimen source codes",
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.15.1.1",
                            Type = @"SubComponent",
                            Position = @"OBR.15.1.1",
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
                            Id = @"OBR.15.1.2",
                            Type = @"SubComponent",
                            Position = @"OBR.15.1.2",
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
                            Id = @"OBR.15.1.3",
                            Type = @"SubComponent",
                            Position = @"OBR.15.1.3",
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
                            Id = @"OBR.15.1.4",
                            Type = @"SubComponent",
                            Position = @"OBR.15.1.4",
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
                            Id = @"OBR.15.1.5",
                            Type = @"SubComponent",
                            Position = @"OBR.15.1.5",
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
                            Id = @"OBR.15.1.6",
                            Type = @"SubComponent",
                            Position = @"OBR.15.1.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.15.2",
                            Type = @"Component",
                            Position = @"OBR.15.2",
                            Name = @"Additives",
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
                            Id = @"OBR.15.3",
                            Type = @"Component",
                            Position = @"OBR.15.3",
                            Name = @"Freetext",
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
                            Id = @"OBR.15.4",
                            Type = @"Component",
                            Position = @"OBR.15.4",
                            Name = @"Body Site",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.15.4.1",
                            Type = @"SubComponent",
                            Position = @"OBR.15.4.1",
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
                            Id = @"OBR.15.4.2",
                            Type = @"SubComponent",
                            Position = @"OBR.15.4.2",
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
                            Id = @"OBR.15.4.3",
                            Type = @"SubComponent",
                            Position = @"OBR.15.4.3",
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
                            Id = @"OBR.15.4.4",
                            Type = @"SubComponent",
                            Position = @"OBR.15.4.4",
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
                            Id = @"OBR.15.4.5",
                            Type = @"SubComponent",
                            Position = @"OBR.15.4.5",
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
                            Id = @"OBR.15.4.6",
                            Type = @"SubComponent",
                            Position = @"OBR.15.4.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.15.5",
                            Type = @"Component",
                            Position = @"OBR.15.5",
                            Name = @"Site Modifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.15.5.1",
                            Type = @"SubComponent",
                            Position = @"OBR.15.5.1",
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
                            Id = @"OBR.15.5.2",
                            Type = @"SubComponent",
                            Position = @"OBR.15.5.2",
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
                            Id = @"OBR.15.5.3",
                            Type = @"SubComponent",
                            Position = @"OBR.15.5.3",
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
                            Id = @"OBR.15.5.4",
                            Type = @"SubComponent",
                            Position = @"OBR.15.5.4",
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
                            Id = @"OBR.15.5.5",
                            Type = @"SubComponent",
                            Position = @"OBR.15.5.5",
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
                            Id = @"OBR.15.5.6",
                            Type = @"SubComponent",
                            Position = @"OBR.15.5.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.15.6",
                            Type = @"Component",
                            Position = @"OBR.15.6",
                            Name = @"Collection Modifier Method Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.15.6.1",
                            Type = @"SubComponent",
                            Position = @"OBR.15.6.1",
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
                            Id = @"OBR.15.6.2",
                            Type = @"SubComponent",
                            Position = @"OBR.15.6.2",
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
                            Id = @"OBR.15.6.3",
                            Type = @"SubComponent",
                            Position = @"OBR.15.6.3",
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
                            Id = @"OBR.15.6.4",
                            Type = @"SubComponent",
                            Position = @"OBR.15.6.4",
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
                            Id = @"OBR.15.6.5",
                            Type = @"SubComponent",
                            Position = @"OBR.15.6.5",
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
                            Id = @"OBR.15.6.6",
                            Type = @"SubComponent",
                            Position = @"OBR.15.6.6",
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
                        },}
                        },
                        }
        }

        _specimenSource = new HL7V23Field
        {
            field = message[@"OBR"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specimenSource.field.FieldRepetitions != null && _specimenSource.field.FieldRepetitions.Count > 0)
        {
            _specimenSource.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_specimenSource, fieldData);
        }

        return _specimenSource;
    } 
}

internal HL7V23Field _orderingProvider;

public HL7V23Field OrderingProvider
{
    get
    {
        if (_orderingProvider != null)
        {
            return _orderingProvider;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.16",
            Type = @"Field",
            Position = @"OBR.16",
            Name = @"Ordering Provider",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the provider who ordered the test.  Either the ID code or the name, or both, may be present.  This is the same as ORC-12-ordering provider",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.16.1",
                            Type = @"Component",
                            Position = @"OBR.16.1",
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
                            Id = @"OBR.16.2",
                            Type = @"Component",
                            Position = @"OBR.16.2",
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
                            Id = @"OBR.16.3",
                            Type = @"Component",
                            Position = @"OBR.16.3",
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
                            Id = @"OBR.16.4",
                            Type = @"Component",
                            Position = @"OBR.16.4",
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
                            Id = @"OBR.16.5",
                            Type = @"Component",
                            Position = @"OBR.16.5",
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
                            Id = @"OBR.16.6",
                            Type = @"Component",
                            Position = @"OBR.16.6",
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
                            Id = @"OBR.16.7",
                            Type = @"Component",
                            Position = @"OBR.16.7",
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
                            Id = @"OBR.16.8",
                            Type = @"Component",
                            Position = @"OBR.16.8",
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
                            Id = @"OBR.16.9",
                            Type = @"Component",
                            Position = @"OBR.16.9",
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
                            Id = @"OBR.16.9.1",
                            Type = @"SubComponent",
                            Position = @"OBR.16.9.1",
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
                            Id = @"OBR.16.9.2",
                            Type = @"SubComponent",
                            Position = @"OBR.16.9.2",
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
                            Id = @"OBR.16.9.3",
                            Type = @"SubComponent",
                            Position = @"OBR.16.9.3",
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
                            Id = @"OBR.16.10",
                            Type = @"Component",
                            Position = @"OBR.16.10",
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
                            Id = @"OBR.16.11",
                            Type = @"Component",
                            Position = @"OBR.16.11",
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
                            Id = @"OBR.16.12",
                            Type = @"Component",
                            Position = @"OBR.16.12",
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
                            Id = @"OBR.16.13",
                            Type = @"Component",
                            Position = @"OBR.16.13",
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
                            Id = @"OBR.16.14",
                            Type = @"Component",
                            Position = @"OBR.16.14",
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
                            Id = @"OBR.16.14.1",
                            Type = @"SubComponent",
                            Position = @"OBR.16.14.1",
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
                            Id = @"OBR.16.14.2",
                            Type = @"SubComponent",
                            Position = @"OBR.16.14.2",
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
                            Id = @"OBR.16.14.3",
                            Type = @"SubComponent",
                            Position = @"OBR.16.14.3",
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

        _orderingProvider = new HL7V23Field
        {
            field = message[@"OBR"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_orderingProvider.field.FieldRepetitions != null && _orderingProvider.field.FieldRepetitions.Count > 0)
        {
            _orderingProvider.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_orderingProvider, fieldData);
        }

        return _orderingProvider;
    } 
}

internal HL7V23Field _orderCallbackPhoneNumber;

public HL7V23Field OrderCallbackPhoneNumber
{
    get
    {
        if (_orderCallbackPhoneNumber != null)
        {
            return _orderCallbackPhoneNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.17",
            Type = @"Field",
            Position = @"OBR.17",
            Name = @"Order Callback Phone Number",
            Length = 40,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"XTN",
            DataTypeName = @"Extended Telecommunication Number",
            TableId = null,
            TableName = null,
            Description = @"This field is the telephone number for reporting a status or a result using the standard format with extension and/or beeper number when applicable.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.17.1",
                            Type = @"Component",
                            Position = @"OBR.17.1",
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
                            Id = @"OBR.17.2",
                            Type = @"Component",
                            Position = @"OBR.17.2",
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
                            Id = @"OBR.17.3",
                            Type = @"Component",
                            Position = @"OBR.17.3",
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
                            Id = @"OBR.17.4",
                            Type = @"Component",
                            Position = @"OBR.17.4",
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
                            Id = @"OBR.17.5",
                            Type = @"Component",
                            Position = @"OBR.17.5",
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
                            Id = @"OBR.17.6",
                            Type = @"Component",
                            Position = @"OBR.17.6",
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
                            Id = @"OBR.17.7",
                            Type = @"Component",
                            Position = @"OBR.17.7",
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
                            Id = @"OBR.17.8",
                            Type = @"Component",
                            Position = @"OBR.17.8",
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
                            Id = @"OBR.17.9",
                            Type = @"Component",
                            Position = @"OBR.17.9",
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

        _orderCallbackPhoneNumber = new HL7V23Field
        {
            field = message[@"OBR"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_orderCallbackPhoneNumber.field.FieldRepetitions != null && _orderCallbackPhoneNumber.field.FieldRepetitions.Count > 0)
        {
            _orderCallbackPhoneNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_orderCallbackPhoneNumber, fieldData);
        }

        return _orderCallbackPhoneNumber;
    } 
}

internal HL7V23Field _placerField1;

public HL7V23Field PlacerField1
{
    get
    {
        if (_placerField1 != null)
        {
            return _placerField1;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.18",
            Type = @"Field",
            Position = @"OBR.18",
            Name = @"Placer Field 1",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is user field #1.  Text sent by the placer will be returned with the results.",
            Sample = @"",
            Fields = null
        }

        _placerField1 = new HL7V23Field
        {
            field = message[@"OBR"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_placerField1.field.FieldRepetitions != null && _placerField1.field.FieldRepetitions.Count > 0)
        {
            _placerField1.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_placerField1, fieldData);
        }

        return _placerField1;
    } 
}

internal HL7V23Field _placerField2;

public HL7V23Field PlacerField2
{
    get
    {
        if (_placerField2 != null)
        {
            return _placerField2;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.19",
            Type = @"Field",
            Position = @"OBR.19",
            Name = @"Placer Field 2",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is similar to placer field #1",
            Sample = @"",
            Fields = null
        }

        _placerField2 = new HL7V23Field
        {
            field = message[@"OBR"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_placerField2.field.FieldRepetitions != null && _placerField2.field.FieldRepetitions.Count > 0)
        {
            _placerField2.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_placerField2, fieldData);
        }

        return _placerField2;
    } 
}

internal HL7V23Field _fillerField1;

public HL7V23Field FillerField1
{
    get
    {
        if (_fillerField1 != null)
        {
            return _fillerField1;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.20",
            Type = @"Field",
            Position = @"OBR.20",
            Name = @"Filler Field 1",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is definable for any use by the filler (diagnostic service)",
            Sample = @"",
            Fields = null
        }

        _fillerField1 = new HL7V23Field
        {
            field = message[@"OBR"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fillerField1.field.FieldRepetitions != null && _fillerField1.field.FieldRepetitions.Count > 0)
        {
            _fillerField1.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_fillerField1, fieldData);
        }

        return _fillerField1;
    } 
}

internal HL7V23Field _fillerField2;

public HL7V23Field FillerField2
{
    get
    {
        if (_fillerField2 != null)
        {
            return _fillerField2;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.21",
            Type = @"Field",
            Position = @"OBR.21",
            Name = @"Filler Field 2",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is similar to filler field #1",
            Sample = @"",
            Fields = null
        }

        _fillerField2 = new HL7V23Field
        {
            field = message[@"OBR"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_fillerField2.field.FieldRepetitions != null && _fillerField2.field.FieldRepetitions.Count > 0)
        {
            _fillerField2.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_fillerField2, fieldData);
        }

        return _fillerField2;
    } 
}

internal HL7V23Field _resultsRptStatusChngDateTime;

public HL7V23Field ResultsRptStatusChngDateTime
{
    get
    {
        if (_resultsRptStatusChngDateTime != null)
        {
            return _resultsRptStatusChngDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.22",
            Type = @"Field",
            Position = @"OBR.22",
            Name = @"Results Rpt/Status Chng - Date/Time",
            Length = 26,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field specifies the date/time when the results were reported or status changed.  This field is used to indicate the date and time that the results are composed into a report and released, or that a status, as defined in ORC-5 order status, is entered or changed.  (This is a results field only.)  When other applications (such as office or clinical database applications) query the laboratory application for untransmitted results, the information in this field may be used to control processing on the communications link.  Usually, the ordering service would want only those results for which the reporting date/time is greater than the date/time the inquiring application last received results",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.22.1",
                            Type = @"Component",
                            Position = @"OBR.22.1",
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
                        }
        }

        _resultsRptStatusChngDateTime = new HL7V23Field
        {
            field = message[@"OBR"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_resultsRptStatusChngDateTime.field.FieldRepetitions != null && _resultsRptStatusChngDateTime.field.FieldRepetitions.Count > 0)
        {
            _resultsRptStatusChngDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_resultsRptStatusChngDateTime, fieldData);
        }

        return _resultsRptStatusChngDateTime;
    } 
}

internal HL7V23Field _chargeToPractice;

public HL7V23Field ChargeToPractice
{
    get
    {
        if (_chargeToPractice != null)
        {
            return _chargeToPractice;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.23",
            Type = @"Field",
            Position = @"OBR.23",
            Name = @"Charge To Practice",
            Length = 40,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_MOC",
            DataTypeName = @"Charge To Practise",
            TableId = null,
            TableName = null,
            Description = @"This field is the charge to the ordering entity for the studies performed when applicable. The first component is a dollar amount when known by the filler.  The second is a charge code when known by the filler (results only)",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.23.1",
                            Type = @"Component",
                            Position = @"OBR.23.1",
                            Name = @"Dollar Amount",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.23.1.1",
                            Type = @"SubComponent",
                            Position = @"OBR.23.1.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component is a quantity",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.23.1.2",
                            Type = @"SubComponent",
                            Position = @"OBR.23.1.2",
                            Name = @"Denomination",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed.  The values for the denomination component are those specified in ISO-4217.  If the denomination is not specified, MSH-17country code is used to determine the default. 

Example: 
|99.50^USD| 
where USD is the ISO 4217 code for the U.S. American dollar. ",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.23.2",
                            Type = @"Component",
                            Position = @"OBR.23.2",
                            Name = @"Charge Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.23.2.1",
                            Type = @"SubComponent",
                            Position = @"OBR.23.2.1",
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
                            Id = @"OBR.23.2.2",
                            Type = @"SubComponent",
                            Position = @"OBR.23.2.2",
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
                            Id = @"OBR.23.2.3",
                            Type = @"SubComponent",
                            Position = @"OBR.23.2.3",
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
                            Id = @"OBR.23.2.4",
                            Type = @"SubComponent",
                            Position = @"OBR.23.2.4",
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
                            Id = @"OBR.23.2.5",
                            Type = @"SubComponent",
                            Position = @"OBR.23.2.5",
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
                            Id = @"OBR.23.2.6",
                            Type = @"SubComponent",
                            Position = @"OBR.23.2.6",
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
                        },}
                        },
                        }
        }

        _chargeToPractice = new HL7V23Field
        {
            field = message[@"OBR"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_chargeToPractice.field.FieldRepetitions != null && _chargeToPractice.field.FieldRepetitions.Count > 0)
        {
            _chargeToPractice.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_chargeToPractice, fieldData);
        }

        return _chargeToPractice;
    } 
}

internal HL7V23Field _diagnosticServiceSectionID;

public HL7V23Field DiagnosticServiceSectionID
{
    get
    {
        if (_diagnosticServiceSectionID != null)
        {
            return _diagnosticServiceSectionID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.24",
            Type = @"Field",
            Position = @"OBR.24",
            Name = @"Diagnostic Service Section ID",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0074",
            TableName = @"Diagnostic service section ID",
            Description = @"This field is the section of the diagnostic service where the observation was performed.  If the study was performed by an outside service, the identification of that service should be recorded here.  Refer to HL7 table 0074 - Diagnostic service section ID for valid entries",
            Sample = @"",
            Fields = null
        }

        _diagnosticServiceSectionID = new HL7V23Field
        {
            field = message[@"OBR"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_diagnosticServiceSectionID.field.FieldRepetitions != null && _diagnosticServiceSectionID.field.FieldRepetitions.Count > 0)
        {
            _diagnosticServiceSectionID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_diagnosticServiceSectionID, fieldData);
        }

        return _diagnosticServiceSectionID;
    } 
}

internal HL7V23Field _resultStatus;

public HL7V23Field ResultStatus
{
    get
    {
        if (_resultStatus != null)
        {
            return _resultStatus;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.25",
            Type = @"Field",
            Position = @"OBR.25",
            Name = @"Result Status",
            Length = 1,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0123",
            TableName = @"Result status",
            Description = @"his field is the status of results for this order.  This conditional field is required whenever the OBR is contained in a report message.  It is not required as part of an initial order. 

There are two methods of sending status information. If the status is that of the entire order, use ORC-15order effective date/time and ORC-5-order status.  If the status pertains to the order detail segment, use OBR-25-result status and OBR-22-results report/status change - date/time.  If both are present, the OBR values override the ORC values.  

This field would typically be used in a response to an order status query where the level of detail requested does not include the OBX segments.  When the individual status of each result is necessary, OBX-11observ result status may be used.  Refer to HL7 table 0123 - Result status for valid entries",
            Sample = @"",
            Fields = null
        }

        _resultStatus = new HL7V23Field
        {
            field = message[@"OBR"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_resultStatus.field.FieldRepetitions != null && _resultStatus.field.FieldRepetitions.Count > 0)
        {
            _resultStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_resultStatus, fieldData);
        }

        return _resultStatus;
    } 
}

internal HL7V23Field _parentResult;

public HL7V23Field ParentResult
{
    get
    {
        if (_parentResult != null)
        {
            return _parentResult;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.26",
            Type = @"Field",
            Position = @"OBR.26",
            Name = @"Parent Result",
            Length = 400,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_PRL",
            DataTypeName = @"Parent Result Link",
            TableId = null,
            TableName = null,
            Description = @"This field is defined to make it available for other types of linkages (e.g., toxicology).  This important information, together with the information in OBR-29-parent number, uniquely identifies the parent result’s OBX segment related to this order.  The value of this OBX segment in the parent result is the organism or chemical species about which this battery reports.  For example, if the current battery is an antimicrobial susceptibility, the parent results identified OBX contains a result which identifies the organism on which the susceptibility was run.  This indirect linkage is preferred because the name of the organism in the parent result may undergo several preliminary values prior to finalization.

The third component may be used to record the name of the microorganism identified by the parent result directly.  The organism in this case should be identified exactly as it is in the parent culture. 

We emphasize that this field does not take the entire result field from the parent.  It is meant only for the text name of the organism or chemical subspecies identified.  This field is included only to provide a method for linking back to the parent result for those systems that could not generate unambiguous Observation IDs and sub-IDs. 

This field is present only when the parent result is identified by OBR-29-parent number and the parent spawns child orders for each of many results.  (See Chapter 7 for more details about this linkage.) 

A second mode of conveying this information is to use a standard observation result segment (OBX).  If more than one organism is present, OBX-4-subID is used to distinguish them.  In this case, the first OBX with subID N will contain a value identifying the Nth microorganism, and each additional OBX with subID N will contain susceptibility values for a given antimicrobial test on this organism",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.26.1",
                            Type = @"Component",
                            Position = @"OBR.26.1",
                            Name = @"OBX-3 Observation Identifier Of Parent Result",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.26.1.1",
                            Type = @"SubComponent",
                            Position = @"OBR.26.1.1",
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
                            Id = @"OBR.26.1.2",
                            Type = @"SubComponent",
                            Position = @"OBR.26.1.2",
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
                            Id = @"OBR.26.1.3",
                            Type = @"SubComponent",
                            Position = @"OBR.26.1.3",
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
                            Id = @"OBR.26.1.4",
                            Type = @"SubComponent",
                            Position = @"OBR.26.1.4",
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
                            Id = @"OBR.26.1.5",
                            Type = @"SubComponent",
                            Position = @"OBR.26.1.5",
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
                            Id = @"OBR.26.1.6",
                            Type = @"SubComponent",
                            Position = @"OBR.26.1.6",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.26.2",
                            Type = @"Component",
                            Position = @"OBR.26.2",
                            Name = @"OBX-4 Sub-ID Of Parent Result",
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
                            Id = @"OBR.26.3",
                            Type = @"Component",
                            Position = @"OBR.26.3",
                            Name = @"Part Of OBX-5 Observation Result From Parent",
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

        _parentResult = new HL7V23Field
        {
            field = message[@"OBR"][26],
            fieldData = fieldData
        };

        // check for repetitions
        if (_parentResult.field.FieldRepetitions != null && _parentResult.field.FieldRepetitions.Count > 0)
        {
            _parentResult.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_parentResult, fieldData);
        }

        return _parentResult;
    } 
}

internal HL7V23Field _quantityTiming;

public HL7V23Field QuantityTiming
{
    get
    {
        if (_quantityTiming != null)
        {
            return _quantityTiming;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.27",
            Type = @"Field",
            Position = @"OBR.27",
            Name = @"Quantity/Timing",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"TQ",
            DataTypeName = @"Timing Quantity",
            TableId = null,
            TableName = null,
            Description = @"This field contains information about how many services to perform at one service time and how often the service times are repeated, and to fix duration of the request.  See Section 4.4, “QUANTITY/TIMING (TQ) DEFINITION.”",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.27.1",
                            Type = @"Component",
                            Position = @"OBR.27.1",
                            Name = @"Quantity",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity With Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the quantity of the service that should be provided at each service interval.  For example., if two blood cultures are to be obtained every 4 hours, the quantity would be 2.  If three units of blood are to be typed and cross-matched, the quantity would be 3.  The default value is 1.  When units are required, they can be added, specified by a subcomponent delimiter. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.27.1.1",
                            Type = @"SubComponent",
                            Position = @"OBR.27.1.1",
                            Name = @"Quantity",
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
                            Id = @"OBR.27.1.2",
                            Type = @"SubComponent",
                            Position = @"OBR.27.1.2",
                            Name = @"Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The units in which the quantity is expressed.  Field-by-field, default units may be defined within the specifications.  When the observation is measured in the default units, the units need not be transmitted.  If the measure is recorded in units different from the default, the measurement units must be transmitted as the second component.  If the units are ISO+ units, then units should be recorded as lowercase abbreviations as specified in Chapter 7.  If the units are ANSI or local, the units and the source table must be recorded as specified in Chapter 7.  But in these cases the component separator should be replaced by the subcomponent delimiter ",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.27.2",
                            Type = @"Component",
                            Position = @"OBR.27.2",
                            Name = @"Interval",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"RI",
                            DataTypeName = @"Repeat Interval",
                            TableId = null,
                            TableName = null,
                            Description = @"This field determines the interval between repeated services.

The default is one time only, the first subcomponent is the repeat pattern, and the second subcomponent is the explicit time at which pattern is to be executed",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.27.2.1",
                            Type = @"SubComponent",
                            Position = @"OBR.27.2.1",
                            Name = @"Repeat Pattern",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0335",
                            TableName = @"Repeat pattern",
                            Description = @"The first component is defined by user-defined table 0335 - Repeat pattern. See Section  4.4.2.1 “Repeat pattern,”  for further details",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.27.2.2",
                            Type = @"SubComponent",
                            Position = @"OBR.27.2.2",
                            Name = @"Explicit Time Interval",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The second component explicitly lists the actual times referenced by the code in the first subcomponent, in the following format: HHMM,HHMM,HHMM,.…  This second subcomponent will be used to clarify the first subcomponent in cases where the actual administration times vary within an institution. See Section 4.4.2.2, “Explicit time interval subcomponent,” for further details.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.27.3",
                            Type = @"Component",
                            Position = @"OBR.27.3",
                            Name = @"Duration",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates how long the service should continue after it is started.  The default is INDEF (do indefinitely)

S<integer> = <integer> seconds 
M<integer> = <integer> minutes 
H<integer> = <integer> hours 
D<integer> = <integer> days 
W<integer> = <integer> weeks 
L<integer> = <integer> months 
X<integer> = <integer> times at interval specified in the order.  A request for 2 blood cultures Q2H X3 would imply obtaining 2 blood cultures 3 different times at 2-hour intervals for a total of 6 blood cultures. 
T<integer> = at the interval and amount stated until a total of <integer> “DOSAGE” is accumulated.  Units would be assumed to be the same as in the QUANTITY field. INDEF = do indefinitely - also the default ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.27.4",
                            Type = @"Component",
                            Position = @"OBR.27.4",
                            Name = @"Start Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field may be specified by the orderer, in which case it indicates the earliest date/time at which the services should be started.  In many cases, however, the start date/time will be implied or will be defined by other fields in the order record (e.g., urgency - STAT).  In such a case, this field will be empty.  

The filling service will often record a value in this field after receipt of the order, however, and compute an end time on the basis of the start date/time for the filling service’s internal use. ",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.27.4.1",
                            Type = @"SubComponent",
                            Position = @"OBR.27.4.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.27.5",
                            Type = @"Component",
                            Position = @"OBR.27.5",
                            Name = @"End Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"When filled in by the requester of the service, this field should be the latest date/time that the service should be performed.  If it has not been performed by the specified time, it should not be performed at all.  The requester may not always fill in this value, yet the filling service may fill it in on the basis of the instruction it receives and the actual start time.  

Regardless of the value of the end date/time, the service should be stopped at the earliest of the date/times specified by either the duration or the end date/time.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.27.5.1",
                            Type = @"SubComponent",
                            Position = @"OBR.27.5.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.27.6",
                            Type = @"Component",
                            Position = @"OBR.27.6",
                            Name = @"Priority",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field describes the urgency of the request.  The following values are suggested (the default for Priority is R):

S = Stat With highest priority 
A = ASAP Fill after S orders 
R = Routine Default 
P = Preop  
C = Callback  
T = Timing critical A request implying that it is critical to come as close as possible to the requested time, e.g., for a trough antimicrobial level. 
PRN = As needed

If using the value “T” (timing critical), the degree of criticality can be specified thus:
 
Format: 
TS<integer> = timing critical within <integer> seconds 
TM<integer> = timing critical within <integer> minutes 
TH<integer> = timing critical within <integer> hours 
TD<integer> = timing critical within <integer> days 
TW<integer> = timing critical within <integer> weeks 
TL<integer> = timing critical within <integer> months 

For the sequential orders specification, these values specify the time criticality with which the predecessor order must be followed by the given order. 
The priority component may repeat; separate repeating values with the repeat delimiter separated by a space",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.27.7",
                            Type = @"Component",
                            Position = @"OBR.27.7",
                            Name = @"Condition",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This is a free text field that describes the conditions under which the drug is to be given.  For example, PRN pain, or to keep blood pressure below 110.  The presence of text in this field should be taken to mean that human review is needed to determine the how and/or when this drug should be given",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.27.8",
                            Type = @"Component",
                            Position = @"OBR.27.8",
                            Name = @"Text",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TX",
                            DataTypeName = @"Text Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is a full text version of the instruction (optional)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.27.9",
                            Type = @"Component",
                            Position = @"OBR.27.9",
                            Name = @"Conjunction",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This non-null component indicates that a second timing specification is to follow using the repeat delimiter.  This field can take three values:  

S =  Synchronous  
Do the next specification after this one (unless otherwise constrained by the following components: ORC4^4-start date/time and ORC-4^5-end date/time).  
An “S” specification implies that the second timing sequence follows the first, e.g., when an order is written to measure blood pressure Q15 minutes for the 1st hour, then every 2 hours for the next day.  

A =  Asynchronous  
Do the next specification in parallel with this one (unless otherwise constrained by the following components: ORC-4^4-start date/time and ORC-4^5-end date/time).  The conjunction of “A” specifies two parallel instructions, as are sometimes used in medication, e.g., prednisone given at 1 tab on Monday, Wednesday, Friday, and at 1/2 tab on Tuesday, Thursday, Saturday, Sunday.  

C =  This is an actuation time 
It will be followed by a completion time for the service.  This code allows one to distinguish between the time and priority at which a service should be actuated (e.g., blood should be drawn) and the time and priority at which a service should be completed (e.g., results should be reported)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.27.10",
                            Type = @"Component",
                            Position = @"OBR.27.10",
                            Name = @"Order Sequencing",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CM_OSD",
                            DataTypeName = @"Order Sequence",
                            TableId = null,
                            TableName = null,
                            Description = @"There are many situations, such as the creation of an order for a group of intravenous (IV) solutions, where the sequence of the individual intravenous solutions (each a service in itself) needs to be specified, e.g., hyperalimentation with multi-vitamins in every third bottle. 

There are other situations where part of the order’s instructions contains a results condition of some type, such as “PRN pain.”  There is currently a free text “condition” component of ORC-4-quantity/timing which allows any condition to be specified.  However, to support a fully encoded version of order sequencing, or results condition, we have defined in the following paragraphs a 10th component of ORC-4-quantity/timing.  

The sequencing conditions supported by this 10th component are based on the completion of a  predecessor service",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.27.10.1",
                            Type = @"SubComponent",
                            Position = @"OBR.27.10.1",
                            Name = @"Sequence/results Flag",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"OSD1",
                            TableName = @"Sequence condition",
                            Description = @"S for sequence conditions; C for cyclical; R is reserved for possible future use. The C will be used for indicating a repeating cycle of orders; for example, individual intravenous solutions used in a cyclical sequence (a.k.a. “Alternating IVs”).  This value would be compatible with linking separate orders or with having all cyclical order components in a single order.  Likewise, the value would be compatible with either Parent-Child messages or a single order message to communicate the orders’ sequencin",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.27.10.2",
                            Type = @"SubComponent",
                            Position = @"OBR.27.10.2",
                            Name = @"Placer Order Number Entity Identifier",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the first two components of the placer order number: entity identifier (ST) and namespace ID (IS) (respectively).  Uses two subcomponents since the placer order number is an EI data type.  We have not defined subsubcomponents in HL",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.27.10.3",
                            Type = @"SubComponent",
                            Position = @"OBR.27.10.3",
                            Name = @"Placer Order Number Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the first two components of the placer order number: entity identifier (ST) and namespace ID (IS) (respectively).  Uses two subcomponents since the placer order number is an EI data type.  We have not defined subsubcomponents in HL",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.27.10.4",
                            Type = @"SubComponent",
                            Position = @"OBR.27.10.4",
                            Name = @"Filler Order Number Entity Identifier",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the first two components of the filler order number: entity identifier (ST) and namespace ID (IS) (respectively).  Uses two subcomponents since the filler order number is an EI data type.  We have not defined subsubcomponents in HL7.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.27.10.5",
                            Type = @"SubComponent",
                            Position = @"OBR.27.10.5",
                            Name = @"Filler Order Number Namespace ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the first two components of the filler order number: entity identifier (ST) and namespace ID (IS) (respectively).  Uses two subcomponents since the filler order number is an EI data type.  We have not defined subsubcomponents in HL7.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.27.10.6",
                            Type = @"SubComponent",
                            Position = @"OBR.27.10.6",
                            Name = @"Sequence Condition Value",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The acceptable condition values have the form commonly used in project planning methodologies: <one of “SS”, “EE”, “SE”, or “ES”> +/- <time> 

The first letter stands for start (S) or end (E) of predecessor order, where the predecessor is defined by the placer or filler order number in subcomponents 1,2 or subcomponents 3,4. 

The second letter stands for the start (S) or end (E) of the successor order, where the successor order is the order containing this quantity/timing specification. 

The time specifies the interval between the predecessor and successor starts or ends (see following examples). Where <time> is defined as:  

 - S<integer> do for <integer> seconds  
 - M<integer> do for <integer> minutes  
 - H<integer> do for <integer> hours  
 - D<integer> do for <integer> days  
 - W<integer> do for <integer> weeks  
 - L<integer> do for <integer> months",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.27.10.7",
                            Type = @"SubComponent",
                            Position = @"OBR.27.10.7",
                            Name = @"Maximum Number Of Repeats",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"The maximum number of repeats to be used only on cyclic groups.  The total number of repeats is constrained by the end date/time of the last repeat or the end date/time of the parent, whichever is first.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.27.10.8",
                            Type = @"SubComponent",
                            Position = @"OBR.27.10.8",
                            Name = @"Placer Order Number Universal ID",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the last two components of the placer order number: universal ID (ST) and universal ID type (ID) (respectively).  Uses two subcomponents since the placer order number is an EI data type.  We have not defined subsubcomponents in HL7.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.27.10.9",
                            Type = @"SubComponent",
                            Position = @"OBR.27.10.9",
                            Name = @"Placer Order Number Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the last two components of the placer order number: universal ID (ST) and universal ID type (ID) (respectively).  Uses two subcomponents since the placer order number is an EI data type.  We have not defined subsubcomponents in HL7.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.27.10.10",
                            Type = @"SubComponent",
                            Position = @"OBR.27.10.10",
                            Name = @"Filler Order Number Universal ID",
                            Length = 0,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the last two components of the filler order number: universal ID (ST) and universal ID type (ID) (respectively).  Uses two subcomponents since the filler order number is an EI data type.  We have not defined subsubcomponents in HL7",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.27.10.11",
                            Type = @"SubComponent",
                            Position = @"OBR.27.10.11",
                            Name = @"Filler Order Number Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = null,
                            TableName = null,
                            Description = @"Contains the last two components of the filler order number: universal ID (ST) and universal ID type (ID) (respectively).  Uses two subcomponents since the filler order number is an EI data type.  We have not defined subsubcomponents in HL7",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _quantityTiming = new HL7V23Field
        {
            field = message[@"OBR"][27],
            fieldData = fieldData
        };

        // check for repetitions
        if (_quantityTiming.field.FieldRepetitions != null && _quantityTiming.field.FieldRepetitions.Count > 0)
        {
            _quantityTiming.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_quantityTiming, fieldData);
        }

        return _quantityTiming;
    } 
}

internal HL7V23Field _resultCopiesTo;

public HL7V23Field ResultCopiesTo
{
    get
    {
        if (_resultCopiesTo != null)
        {
            return _resultCopiesTo;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.28",
            Type = @"Field",
            Position = @"OBR.28",
            Name = @"Result Copies To",
            Length = 150,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the people who are to receive copies of the results.  By local convention, either the ID number or the name may be absent",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.28.1",
                            Type = @"Component",
                            Position = @"OBR.28.1",
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
                            Id = @"OBR.28.2",
                            Type = @"Component",
                            Position = @"OBR.28.2",
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
                            Id = @"OBR.28.3",
                            Type = @"Component",
                            Position = @"OBR.28.3",
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
                            Id = @"OBR.28.4",
                            Type = @"Component",
                            Position = @"OBR.28.4",
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
                            Id = @"OBR.28.5",
                            Type = @"Component",
                            Position = @"OBR.28.5",
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
                            Id = @"OBR.28.6",
                            Type = @"Component",
                            Position = @"OBR.28.6",
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
                            Id = @"OBR.28.7",
                            Type = @"Component",
                            Position = @"OBR.28.7",
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
                            Id = @"OBR.28.8",
                            Type = @"Component",
                            Position = @"OBR.28.8",
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
                            Id = @"OBR.28.9",
                            Type = @"Component",
                            Position = @"OBR.28.9",
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
                            Id = @"OBR.28.9.1",
                            Type = @"SubComponent",
                            Position = @"OBR.28.9.1",
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
                            Id = @"OBR.28.9.2",
                            Type = @"SubComponent",
                            Position = @"OBR.28.9.2",
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
                            Id = @"OBR.28.9.3",
                            Type = @"SubComponent",
                            Position = @"OBR.28.9.3",
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
                            Id = @"OBR.28.10",
                            Type = @"Component",
                            Position = @"OBR.28.10",
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
                            Id = @"OBR.28.11",
                            Type = @"Component",
                            Position = @"OBR.28.11",
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
                            Id = @"OBR.28.12",
                            Type = @"Component",
                            Position = @"OBR.28.12",
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
                            Id = @"OBR.28.13",
                            Type = @"Component",
                            Position = @"OBR.28.13",
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
                            Id = @"OBR.28.14",
                            Type = @"Component",
                            Position = @"OBR.28.14",
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
                            Id = @"OBR.28.14.1",
                            Type = @"SubComponent",
                            Position = @"OBR.28.14.1",
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
                            Id = @"OBR.28.14.2",
                            Type = @"SubComponent",
                            Position = @"OBR.28.14.2",
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
                            Id = @"OBR.28.14.3",
                            Type = @"SubComponent",
                            Position = @"OBR.28.14.3",
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

        _resultCopiesTo = new HL7V23Field
        {
            field = message[@"OBR"][28],
            fieldData = fieldData
        };

        // check for repetitions
        if (_resultCopiesTo.field.FieldRepetitions != null && _resultCopiesTo.field.FieldRepetitions.Count > 0)
        {
            _resultCopiesTo.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_resultCopiesTo, fieldData);
        }

        return _resultCopiesTo;
    } 
}

internal HL7V23Field _parentNumber;

public HL7V23Field ParentNumber
{
    get
    {
        if (_parentNumber != null)
        {
            return _parentNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.29",
            Type = @"Field",
            Position = @"OBR.29",
            Name = @"Parent Number",
            Length = 150,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_EIP",
            DataTypeName = @"Parent Order",
            TableId = null,
            TableName = null,
            Description = @"This field is identical to ORC-8-parent.  This field relates a child to its parent when a parent-child relationship exists.  For example, observations that are spawned by previous observations, e.g., antimicrobial susceptibilities spawned by blood cultures, need to record the parent (blood culture) filler order number here.  The parent-child mechanism is described under the order control field notes (see Section 4.3.1.1.1, “Table notes for order control codes of ORC”).  It is required when the order is a child.   

Parent is a two-component field. The components of the placer order number and the filler order number are transmitted in subcomponents of the two components of this field",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.29.1",
                            Type = @"Component",
                            Position = @"OBR.29.1",
                            Name = @"Parent s Placer Order Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.29.1.1",
                            Type = @"SubComponent",
                            Position = @"OBR.29.1.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4.  (See Section 2.8.18, “HD - hierarchic designator”.) ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.29.1.2",
                            Type = @"SubComponent",
                            Position = @"OBR.29.1.2",
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
                            Id = @"OBR.29.1.3",
                            Type = @"SubComponent",
                            Position = @"OBR.29.1.3",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.29.1.4",
                            Type = @"SubComponent",
                            Position = @"OBR.29.1.4",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.29.2",
                            Type = @"Component",
                            Position = @"OBR.29.2",
                            Name = @"Parent s Filler Order Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.29.2.1",
                            Type = @"SubComponent",
                            Position = @"OBR.29.2.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, entity identifier, is usually defined to be unique within the series of identifiers created by the assigning authority, defined by a hierarchic designator, represented by components 2 through 4.  (See Section 2.8.18, “HD - hierarchic designator”.) ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.29.2.2",
                            Type = @"SubComponent",
                            Position = @"OBR.29.2.2",
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
                            Id = @"OBR.29.2.3",
                            Type = @"SubComponent",
                            Position = @"OBR.29.2.3",
                            Name = @"Universal ID",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HD’s second component, universal ID (UID), is a string formatted according to the scheme defined by the third component, universal ID type (UID type).  The UID is intended to be unique over time within the UID type.  It is rigorously defined.  Each UID must belong to one of the specifically enumerated schemes for constructing UID’s (defined by the UID type).  The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.29.2.4",
                            Type = @"SubComponent",
                            Position = @"OBR.29.2.4",
                            Name = @"Universal ID Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _parentNumber = new HL7V23Field
        {
            field = message[@"OBR"][29],
            fieldData = fieldData
        };

        // check for repetitions
        if (_parentNumber.field.FieldRepetitions != null && _parentNumber.field.FieldRepetitions.Count > 0)
        {
            _parentNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_parentNumber, fieldData);
        }

        return _parentNumber;
    } 
}

internal HL7V23Field _transportationMode;

public HL7V23Field TransportationMode
{
    get
    {
        if (_transportationMode != null)
        {
            return _transportationMode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.30",
            Type = @"Field",
            Position = @"OBR.30",
            Name = @"Transportation Mode",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0124",
            TableName = @"Transportation mode",
            Description = @"This field identifies how (or whether) to transport a patient, when applicable.  Refer to HL7 table 0124 - Transportation mode for valid codes",
            Sample = @"",
            Fields = null
        }

        _transportationMode = new HL7V23Field
        {
            field = message[@"OBR"][30],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transportationMode.field.FieldRepetitions != null && _transportationMode.field.FieldRepetitions.Count > 0)
        {
            _transportationMode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_transportationMode, fieldData);
        }

        return _transportationMode;
    } 
}

internal HL7V23Field _reasonForStudy;

public HL7V23Field ReasonForStudy
{
    get
    {
        if (_reasonForStudy != null)
        {
            return _reasonForStudy;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.31",
            Type = @"Field",
            Position = @"OBR.31",
            Name = @"Reason For Study",
            Length = 300,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the code or text using the conventions for coded fields given in the Control/Query Chapter (Chapter 2).  This is required for some studies to obtain proper reimbursement",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.31.1",
                            Type = @"Component",
                            Position = @"OBR.31.1",
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
                            Id = @"OBR.31.2",
                            Type = @"Component",
                            Position = @"OBR.31.2",
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
                            Id = @"OBR.31.3",
                            Type = @"Component",
                            Position = @"OBR.31.3",
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
                            Id = @"OBR.31.4",
                            Type = @"Component",
                            Position = @"OBR.31.4",
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
                            Id = @"OBR.31.5",
                            Type = @"Component",
                            Position = @"OBR.31.5",
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
                            Id = @"OBR.31.6",
                            Type = @"Component",
                            Position = @"OBR.31.6",
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

        _reasonForStudy = new HL7V23Field
        {
            field = message[@"OBR"][31],
            fieldData = fieldData
        };

        // check for repetitions
        if (_reasonForStudy.field.FieldRepetitions != null && _reasonForStudy.field.FieldRepetitions.Count > 0)
        {
            _reasonForStudy.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_reasonForStudy, fieldData);
        }

        return _reasonForStudy;
    } 
}

internal HL7V23Field _principalResultInterpreter;

public HL7V23Field PrincipalResultInterpreter
{
    get
    {
        if (_principalResultInterpreter != null)
        {
            return _principalResultInterpreter;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.32",
            Type = @"Field",
            Position = @"OBR.32",
            Name = @"Principal Result Interpreter",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CM_NDL",
            DataTypeName = @"Observing Practitioner",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the physician or other clinician who interpreted the observation and is responsible for the report content",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.32.1",
                            Type = @"Component",
                            Position = @"OBR.32.1",
                            Name = @"OP Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN",
                            DataTypeName = @"Composite ID Number And Name",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.32.1.1",
                            Type = @"SubComponent",
                            Position = @"OBR.32.1.1",
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
                            Id = @"OBR.32.1.2",
                            Type = @"SubComponent",
                            Position = @"OBR.32.1.2",
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
                            Id = @"OBR.32.1.3",
                            Type = @"SubComponent",
                            Position = @"OBR.32.1.3",
                            Name = @"Given Name",
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
                            Id = @"OBR.32.1.4",
                            Type = @"SubComponent",
                            Position = @"OBR.32.1.4",
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
                            Id = @"OBR.32.1.5",
                            Type = @"SubComponent",
                            Position = @"OBR.32.1.5",
                            Name = @"Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name suffix (e.g., Jr. or III). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.32.1.6",
                            Type = @"SubComponent",
                            Position = @"OBR.32.1.6",
                            Name = @"Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name prefix (e.g., Dr.). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.32.1.7",
                            Type = @"SubComponent",
                            Position = @"OBR.32.1.7",
                            Name = @"Degree",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify an educational degree (e.g., MD). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.32.1.8",
                            Type = @"SubComponent",
                            Position = @"OBR.32.1.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"Refer to user-defined table 0297 - CN ID source  for suggested values.  Used to delineate the first component",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.32.1.9",
                            Type = @"SubComponent",
                            Position = @"OBR.32.1.9",
                            Name = @"Assigning Authority",
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
                            Id = @"OBR.32.2",
                            Type = @"Component",
                            Position = @"OBR.32.2",
                            Name = @"Start Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.32.2.1",
                            Type = @"SubComponent",
                            Position = @"OBR.32.2.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.32.3",
                            Type = @"Component",
                            Position = @"OBR.32.3",
                            Name = @"End Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.32.3.1",
                            Type = @"SubComponent",
                            Position = @"OBR.32.3.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.32.4",
                            Type = @"Component",
                            Position = @"OBR.32.4",
                            Name = @"Point Of Care",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0302",
                            TableName = @"Point of care",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.32.5",
                            Type = @"Component",
                            Position = @"OBR.32.5",
                            Name = @"Room",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0303",
                            TableName = @"Room",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.32.6",
                            Type = @"Component",
                            Position = @"OBR.32.6",
                            Name = @"Bed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0304",
                            TableName = @"Bed",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.32.7",
                            Type = @"Component",
                            Position = @"OBR.32.7",
                            Name = @"Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.32.7.1",
                            Type = @"SubComponent",
                            Position = @"OBR.32.7.1",
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
                            Id = @"OBR.32.7.2",
                            Type = @"SubComponent",
                            Position = @"OBR.32.7.2",
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
                            Id = @"OBR.32.7.3",
                            Type = @"SubComponent",
                            Position = @"OBR.32.7.3",
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
                            Id = @"OBR.32.8",
                            Type = @"Component",
                            Position = @"OBR.32.8",
                            Name = @"Location Status",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0306",
                            TableName = @"Location status",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.32.9",
                            Type = @"Component",
                            Position = @"OBR.32.9",
                            Name = @"Person Location Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0305",
                            TableName = @"Person location type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.32.10",
                            Type = @"Component",
                            Position = @"OBR.32.10",
                            Name = @"Building",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0307",
                            TableName = @"Building",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.32.11",
                            Type = @"Component",
                            Position = @"OBR.32.11",
                            Name = @"Floor",
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

        _principalResultInterpreter = new HL7V23Field
        {
            field = message[@"OBR"][32],
            fieldData = fieldData
        };

        // check for repetitions
        if (_principalResultInterpreter.field.FieldRepetitions != null && _principalResultInterpreter.field.FieldRepetitions.Count > 0)
        {
            _principalResultInterpreter.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_principalResultInterpreter, fieldData);
        }

        return _principalResultInterpreter;
    } 
}

internal HL7V23Field _assistantResultInterpreter;

public HL7V23Field AssistantResultInterpreter
{
    get
    {
        if (_assistantResultInterpreter != null)
        {
            return _assistantResultInterpreter;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.33",
            Type = @"Field",
            Position = @"OBR.33",
            Name = @"Assistant Result Interpreter",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_NDL",
            DataTypeName = @"Observing Practitioner",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the clinical observer who assisted with the interpretation of this study",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.33.1",
                            Type = @"Component",
                            Position = @"OBR.33.1",
                            Name = @"OP Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN",
                            DataTypeName = @"Composite ID Number And Name",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.33.1.1",
                            Type = @"SubComponent",
                            Position = @"OBR.33.1.1",
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
                            Id = @"OBR.33.1.2",
                            Type = @"SubComponent",
                            Position = @"OBR.33.1.2",
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
                            Id = @"OBR.33.1.3",
                            Type = @"SubComponent",
                            Position = @"OBR.33.1.3",
                            Name = @"Given Name",
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
                            Id = @"OBR.33.1.4",
                            Type = @"SubComponent",
                            Position = @"OBR.33.1.4",
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
                            Id = @"OBR.33.1.5",
                            Type = @"SubComponent",
                            Position = @"OBR.33.1.5",
                            Name = @"Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name suffix (e.g., Jr. or III). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.33.1.6",
                            Type = @"SubComponent",
                            Position = @"OBR.33.1.6",
                            Name = @"Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name prefix (e.g., Dr.). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.33.1.7",
                            Type = @"SubComponent",
                            Position = @"OBR.33.1.7",
                            Name = @"Degree",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify an educational degree (e.g., MD). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.33.1.8",
                            Type = @"SubComponent",
                            Position = @"OBR.33.1.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"Refer to user-defined table 0297 - CN ID source  for suggested values.  Used to delineate the first component",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.33.1.9",
                            Type = @"SubComponent",
                            Position = @"OBR.33.1.9",
                            Name = @"Assigning Authority",
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
                            Id = @"OBR.33.2",
                            Type = @"Component",
                            Position = @"OBR.33.2",
                            Name = @"Start Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.33.2.1",
                            Type = @"SubComponent",
                            Position = @"OBR.33.2.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.33.3",
                            Type = @"Component",
                            Position = @"OBR.33.3",
                            Name = @"End Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.33.3.1",
                            Type = @"SubComponent",
                            Position = @"OBR.33.3.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.33.4",
                            Type = @"Component",
                            Position = @"OBR.33.4",
                            Name = @"Point Of Care",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0302",
                            TableName = @"Point of care",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.33.5",
                            Type = @"Component",
                            Position = @"OBR.33.5",
                            Name = @"Room",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0303",
                            TableName = @"Room",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.33.6",
                            Type = @"Component",
                            Position = @"OBR.33.6",
                            Name = @"Bed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0304",
                            TableName = @"Bed",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.33.7",
                            Type = @"Component",
                            Position = @"OBR.33.7",
                            Name = @"Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.33.7.1",
                            Type = @"SubComponent",
                            Position = @"OBR.33.7.1",
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
                            Id = @"OBR.33.7.2",
                            Type = @"SubComponent",
                            Position = @"OBR.33.7.2",
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
                            Id = @"OBR.33.7.3",
                            Type = @"SubComponent",
                            Position = @"OBR.33.7.3",
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
                            Id = @"OBR.33.8",
                            Type = @"Component",
                            Position = @"OBR.33.8",
                            Name = @"Location Status",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0306",
                            TableName = @"Location status",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.33.9",
                            Type = @"Component",
                            Position = @"OBR.33.9",
                            Name = @"Person Location Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0305",
                            TableName = @"Person location type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.33.10",
                            Type = @"Component",
                            Position = @"OBR.33.10",
                            Name = @"Building",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0307",
                            TableName = @"Building",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.33.11",
                            Type = @"Component",
                            Position = @"OBR.33.11",
                            Name = @"Floor",
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

        _assistantResultInterpreter = new HL7V23Field
        {
            field = message[@"OBR"][33],
            fieldData = fieldData
        };

        // check for repetitions
        if (_assistantResultInterpreter.field.FieldRepetitions != null && _assistantResultInterpreter.field.FieldRepetitions.Count > 0)
        {
            _assistantResultInterpreter.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_assistantResultInterpreter, fieldData);
        }

        return _assistantResultInterpreter;
    } 
}

internal HL7V23Field _technician;

public HL7V23Field Technician
{
    get
    {
        if (_technician != null)
        {
            return _technician;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.34",
            Type = @"Field",
            Position = @"OBR.34",
            Name = @"Technician",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_NDL",
            DataTypeName = @"Observing Practitioner",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the performing technician",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.34.1",
                            Type = @"Component",
                            Position = @"OBR.34.1",
                            Name = @"OP Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN",
                            DataTypeName = @"Composite ID Number And Name",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.34.1.1",
                            Type = @"SubComponent",
                            Position = @"OBR.34.1.1",
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
                            Id = @"OBR.34.1.2",
                            Type = @"SubComponent",
                            Position = @"OBR.34.1.2",
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
                            Id = @"OBR.34.1.3",
                            Type = @"SubComponent",
                            Position = @"OBR.34.1.3",
                            Name = @"Given Name",
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
                            Id = @"OBR.34.1.4",
                            Type = @"SubComponent",
                            Position = @"OBR.34.1.4",
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
                            Id = @"OBR.34.1.5",
                            Type = @"SubComponent",
                            Position = @"OBR.34.1.5",
                            Name = @"Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name suffix (e.g., Jr. or III). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.34.1.6",
                            Type = @"SubComponent",
                            Position = @"OBR.34.1.6",
                            Name = @"Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name prefix (e.g., Dr.). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.34.1.7",
                            Type = @"SubComponent",
                            Position = @"OBR.34.1.7",
                            Name = @"Degree",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify an educational degree (e.g., MD). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.34.1.8",
                            Type = @"SubComponent",
                            Position = @"OBR.34.1.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"Refer to user-defined table 0297 - CN ID source  for suggested values.  Used to delineate the first component",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.34.1.9",
                            Type = @"SubComponent",
                            Position = @"OBR.34.1.9",
                            Name = @"Assigning Authority",
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
                            Id = @"OBR.34.2",
                            Type = @"Component",
                            Position = @"OBR.34.2",
                            Name = @"Start Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.34.2.1",
                            Type = @"SubComponent",
                            Position = @"OBR.34.2.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.34.3",
                            Type = @"Component",
                            Position = @"OBR.34.3",
                            Name = @"End Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.34.3.1",
                            Type = @"SubComponent",
                            Position = @"OBR.34.3.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.34.4",
                            Type = @"Component",
                            Position = @"OBR.34.4",
                            Name = @"Point Of Care",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0302",
                            TableName = @"Point of care",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.34.5",
                            Type = @"Component",
                            Position = @"OBR.34.5",
                            Name = @"Room",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0303",
                            TableName = @"Room",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.34.6",
                            Type = @"Component",
                            Position = @"OBR.34.6",
                            Name = @"Bed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0304",
                            TableName = @"Bed",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.34.7",
                            Type = @"Component",
                            Position = @"OBR.34.7",
                            Name = @"Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.34.7.1",
                            Type = @"SubComponent",
                            Position = @"OBR.34.7.1",
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
                            Id = @"OBR.34.7.2",
                            Type = @"SubComponent",
                            Position = @"OBR.34.7.2",
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
                            Id = @"OBR.34.7.3",
                            Type = @"SubComponent",
                            Position = @"OBR.34.7.3",
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
                            Id = @"OBR.34.8",
                            Type = @"Component",
                            Position = @"OBR.34.8",
                            Name = @"Location Status",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0306",
                            TableName = @"Location status",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.34.9",
                            Type = @"Component",
                            Position = @"OBR.34.9",
                            Name = @"Person Location Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0305",
                            TableName = @"Person location type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.34.10",
                            Type = @"Component",
                            Position = @"OBR.34.10",
                            Name = @"Building",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0307",
                            TableName = @"Building",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.34.11",
                            Type = @"Component",
                            Position = @"OBR.34.11",
                            Name = @"Floor",
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

        _technician = new HL7V23Field
        {
            field = message[@"OBR"][34],
            fieldData = fieldData
        };

        // check for repetitions
        if (_technician.field.FieldRepetitions != null && _technician.field.FieldRepetitions.Count > 0)
        {
            _technician.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_technician, fieldData);
        }

        return _technician;
    } 
}

internal HL7V23Field _transcriptionist;

public HL7V23Field Transcriptionist
{
    get
    {
        if (_transcriptionist != null)
        {
            return _transcriptionist;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.35",
            Type = @"Field",
            Position = @"OBR.35",
            Name = @"Transcriptionist",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CM_NDL",
            DataTypeName = @"Observing Practitioner",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the report transcriber",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.35.1",
                            Type = @"Component",
                            Position = @"OBR.35.1",
                            Name = @"OP Name",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CN",
                            DataTypeName = @"Composite ID Number And Name",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.35.1.1",
                            Type = @"SubComponent",
                            Position = @"OBR.35.1.1",
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
                            Id = @"OBR.35.1.2",
                            Type = @"SubComponent",
                            Position = @"OBR.35.1.2",
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
                            Id = @"OBR.35.1.3",
                            Type = @"SubComponent",
                            Position = @"OBR.35.1.3",
                            Name = @"Given Name",
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
                            Id = @"OBR.35.1.4",
                            Type = @"SubComponent",
                            Position = @"OBR.35.1.4",
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
                            Id = @"OBR.35.1.5",
                            Type = @"SubComponent",
                            Position = @"OBR.35.1.5",
                            Name = @"Suffix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name suffix (e.g., Jr. or III). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.35.1.6",
                            Type = @"SubComponent",
                            Position = @"OBR.35.1.6",
                            Name = @"Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify a name prefix (e.g., Dr.). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.35.1.7",
                            Type = @"SubComponent",
                            Position = @"OBR.35.1.7",
                            Name = @"Degree",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Used to specify an educational degree (e.g., MD). ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.35.1.8",
                            Type = @"SubComponent",
                            Position = @"OBR.35.1.8",
                            Name = @"Source Table",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0297",
                            TableName = @"CN ID source",
                            Description = @"Refer to user-defined table 0297 - CN ID source  for suggested values.  Used to delineate the first component",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.35.1.9",
                            Type = @"SubComponent",
                            Position = @"OBR.35.1.9",
                            Name = @"Assigning Authority",
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
                            Id = @"OBR.35.2",
                            Type = @"Component",
                            Position = @"OBR.35.2",
                            Name = @"Start Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.35.2.1",
                            Type = @"SubComponent",
                            Position = @"OBR.35.2.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.35.3",
                            Type = @"Component",
                            Position = @"OBR.35.3",
                            Name = @"End Date/time",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.35.3.1",
                            Type = @"SubComponent",
                            Position = @"OBR.35.3.1",
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
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.35.4",
                            Type = @"Component",
                            Position = @"OBR.35.4",
                            Name = @"Point Of Care",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0302",
                            TableName = @"Point of care",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.35.5",
                            Type = @"Component",
                            Position = @"OBR.35.5",
                            Name = @"Room",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0303",
                            TableName = @"Room",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.35.6",
                            Type = @"Component",
                            Position = @"OBR.35.6",
                            Name = @"Bed",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0304",
                            TableName = @"Bed",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.35.7",
                            Type = @"Component",
                            Position = @"OBR.35.7",
                            Name = @"Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"OBR.35.7.1",
                            Type = @"SubComponent",
                            Position = @"OBR.35.7.1",
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
                            Id = @"OBR.35.7.2",
                            Type = @"SubComponent",
                            Position = @"OBR.35.7.2",
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
                            Id = @"OBR.35.7.3",
                            Type = @"SubComponent",
                            Position = @"OBR.35.7.3",
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
                            Id = @"OBR.35.8",
                            Type = @"Component",
                            Position = @"OBR.35.8",
                            Name = @"Location Status",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0306",
                            TableName = @"Location status",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.35.9",
                            Type = @"Component",
                            Position = @"OBR.35.9",
                            Name = @"Person Location Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0305",
                            TableName = @"Person location type",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.35.10",
                            Type = @"Component",
                            Position = @"OBR.35.10",
                            Name = @"Building",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0307",
                            TableName = @"Building",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"OBR.35.11",
                            Type = @"Component",
                            Position = @"OBR.35.11",
                            Name = @"Floor",
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

        _transcriptionist = new HL7V23Field
        {
            field = message[@"OBR"][35],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transcriptionist.field.FieldRepetitions != null && _transcriptionist.field.FieldRepetitions.Count > 0)
        {
            _transcriptionist.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_transcriptionist, fieldData);
        }

        return _transcriptionist;
    } 
}

internal HL7V23Field _scheduledDateTime;

public HL7V23Field ScheduledDateTime
{
    get
    {
        if (_scheduledDateTime != null)
        {
            return _scheduledDateTime;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.36",
            Type = @"Field",
            Position = @"OBR.36",
            Name = @"Scheduled Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field is the date/time the filler scheduled an observation, when applicable (e.g., action code in OBR-11-specimen action code  = “S”).  This is a result of a request to schedule a particular test and provides a way to inform the placer of the date/time a study is scheduled (result only).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.36.1",
                            Type = @"Component",
                            Position = @"OBR.36.1",
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
                        }
        }

        _scheduledDateTime = new HL7V23Field
        {
            field = message[@"OBR"][36],
            fieldData = fieldData
        };

        // check for repetitions
        if (_scheduledDateTime.field.FieldRepetitions != null && _scheduledDateTime.field.FieldRepetitions.Count > 0)
        {
            _scheduledDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_scheduledDateTime, fieldData);
        }

        return _scheduledDateTime;
    } 
}

internal HL7V23Field _numberOfSampleContainers;

public HL7V23Field NumberOfSampleContainers
{
    get
    {
        if (_numberOfSampleContainers != null)
        {
            return _numberOfSampleContainers;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.37",
            Type = @"Field",
            Position = @"OBR.37",
            Name = @"Number Of Sample Containers",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the number of containers for a given sample.  For sample receipt verification purposes; may be different from the total number of samples which accompany the order.",
            Sample = @"",
            Fields = null
        }

        _numberOfSampleContainers = new HL7V23Field
        {
            field = message[@"OBR"][37],
            fieldData = fieldData
        };

        // check for repetitions
        if (_numberOfSampleContainers.field.FieldRepetitions != null && _numberOfSampleContainers.field.FieldRepetitions.Count > 0)
        {
            _numberOfSampleContainers.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_numberOfSampleContainers, fieldData);
        }

        return _numberOfSampleContainers;
    } 
}

internal HL7V23Field _transportLogisticsOfCollectedSample;

public HL7V23Field TransportLogisticsOfCollectedSample
{
    get
    {
        if (_transportLogisticsOfCollectedSample != null)
        {
            return _transportLogisticsOfCollectedSample;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.38",
            Type = @"Field",
            Position = @"OBR.38",
            Name = @"Transport Logistics Of Collected Sample",
            Length = 60,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the means by which a sample reaches the diagnostic service provider.  This information is to aid the lab in scheduling or interpretation of results.  Possible answers: routine transport van, public postal service, etc.  If coded, requires a user-defined table.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.38.1",
                            Type = @"Component",
                            Position = @"OBR.38.1",
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
                            Id = @"OBR.38.2",
                            Type = @"Component",
                            Position = @"OBR.38.2",
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
                            Id = @"OBR.38.3",
                            Type = @"Component",
                            Position = @"OBR.38.3",
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
                            Id = @"OBR.38.4",
                            Type = @"Component",
                            Position = @"OBR.38.4",
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
                            Id = @"OBR.38.5",
                            Type = @"Component",
                            Position = @"OBR.38.5",
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
                            Id = @"OBR.38.6",
                            Type = @"Component",
                            Position = @"OBR.38.6",
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

        _transportLogisticsOfCollectedSample = new HL7V23Field
        {
            field = message[@"OBR"][38],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transportLogisticsOfCollectedSample.field.FieldRepetitions != null && _transportLogisticsOfCollectedSample.field.FieldRepetitions.Count > 0)
        {
            _transportLogisticsOfCollectedSample.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_transportLogisticsOfCollectedSample, fieldData);
        }

        return _transportLogisticsOfCollectedSample;
    } 
}

internal HL7V23Field _collectorsComment;

public HL7V23Field CollectorsComment
{
    get
    {
        if (_collectorsComment != null)
        {
            return _collectorsComment;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.39",
            Type = @"Field",
            Position = @"OBR.39",
            Name = @"Collector s Comment",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is for reporting additional comments related to the sample. If coded, requires a userdefined table.  If only free text is reported, it is placed in the second component with a null in the first component, e.g., ^difficult clotting after venipuncture and echymosis.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.39.1",
                            Type = @"Component",
                            Position = @"OBR.39.1",
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
                            Id = @"OBR.39.2",
                            Type = @"Component",
                            Position = @"OBR.39.2",
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
                            Id = @"OBR.39.3",
                            Type = @"Component",
                            Position = @"OBR.39.3",
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
                            Id = @"OBR.39.4",
                            Type = @"Component",
                            Position = @"OBR.39.4",
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
                            Id = @"OBR.39.5",
                            Type = @"Component",
                            Position = @"OBR.39.5",
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
                            Id = @"OBR.39.6",
                            Type = @"Component",
                            Position = @"OBR.39.6",
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

        _collectorsComment = new HL7V23Field
        {
            field = message[@"OBR"][39],
            fieldData = fieldData
        };

        // check for repetitions
        if (_collectorsComment.field.FieldRepetitions != null && _collectorsComment.field.FieldRepetitions.Count > 0)
        {
            _collectorsComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_collectorsComment, fieldData);
        }

        return _collectorsComment;
    } 
}

internal HL7V23Field _transportArrangementResponsibility;

public HL7V23Field TransportArrangementResponsibility
{
    get
    {
        if (_transportArrangementResponsibility != null)
        {
            return _transportArrangementResponsibility;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.40",
            Type = @"Field",
            Position = @"OBR.40",
            Name = @"Transport Arrangement Responsibility",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is an indicator of who is responsible for arranging transport to the planned diagnostic service.  Examples: Requester, Provider, Patient.  If coded, requires a user-defined table.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.40.1",
                            Type = @"Component",
                            Position = @"OBR.40.1",
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
                            Id = @"OBR.40.2",
                            Type = @"Component",
                            Position = @"OBR.40.2",
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
                            Id = @"OBR.40.3",
                            Type = @"Component",
                            Position = @"OBR.40.3",
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
                            Id = @"OBR.40.4",
                            Type = @"Component",
                            Position = @"OBR.40.4",
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
                            Id = @"OBR.40.5",
                            Type = @"Component",
                            Position = @"OBR.40.5",
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
                            Id = @"OBR.40.6",
                            Type = @"Component",
                            Position = @"OBR.40.6",
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

        _transportArrangementResponsibility = new HL7V23Field
        {
            field = message[@"OBR"][40],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transportArrangementResponsibility.field.FieldRepetitions != null && _transportArrangementResponsibility.field.FieldRepetitions.Count > 0)
        {
            _transportArrangementResponsibility.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_transportArrangementResponsibility, fieldData);
        }

        return _transportArrangementResponsibility;
    } 
}

internal HL7V23Field _transportArranged;

public HL7V23Field TransportArranged
{
    get
    {
        if (_transportArranged != null)
        {
            return _transportArranged;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.41",
            Type = @"Field",
            Position = @"OBR.41",
            Name = @"Transport Arranged",
            Length = 30,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0224",
            TableName = @"Transport arranged",
            Description = @"This field is an indicator of whether transport arrangements are known to have been made.  Refer to HL7 table 0224 - Transport arranged for valid codes.",
            Sample = @"",
            Fields = null
        }

        _transportArranged = new HL7V23Field
        {
            field = message[@"OBR"][41],
            fieldData = fieldData
        };

        // check for repetitions
        if (_transportArranged.field.FieldRepetitions != null && _transportArranged.field.FieldRepetitions.Count > 0)
        {
            _transportArranged.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_transportArranged, fieldData);
        }

        return _transportArranged;
    } 
}

internal HL7V23Field _escortRequired;

public HL7V23Field EscortRequired
{
    get
    {
        if (_escortRequired != null)
        {
            return _escortRequired;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.42",
            Type = @"Field",
            Position = @"OBR.42",
            Name = @"Escort Required",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0225",
            TableName = @"Escort required",
            Description = @"This field is an indicator that the patient needs to be escorted to the diagnostic service department.  Note: The nature of the escort requirements should be stated in OBR-43 planned patient transport comment.  See HL7 table 0225 - Escort required for valid values.",
            Sample = @"",
            Fields = null
        }

        _escortRequired = new HL7V23Field
        {
            field = message[@"OBR"][42],
            fieldData = fieldData
        };

        // check for repetitions
        if (_escortRequired.field.FieldRepetitions != null && _escortRequired.field.FieldRepetitions.Count > 0)
        {
            _escortRequired.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_escortRequired, fieldData);
        }

        return _escortRequired;
    } 
}

internal HL7V23Field _plannedPatientTransportComment;

public HL7V23Field PlannedPatientTransportComment
{
    get
    {
        if (_plannedPatientTransportComment != null)
        {
            return _plannedPatientTransportComment;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OBR.43",
            Type = @"Field",
            Position = @"OBR.43",
            Name = @"Planned Patient Transport Comment",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field is the code or free text comments on special requirements for the transport of the patient to the diagnostic service department.  If coded, requires a user-defined table.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OBR.43.1",
                            Type = @"Component",
                            Position = @"OBR.43.1",
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
                            Id = @"OBR.43.2",
                            Type = @"Component",
                            Position = @"OBR.43.2",
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
                            Id = @"OBR.43.3",
                            Type = @"Component",
                            Position = @"OBR.43.3",
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
                            Id = @"OBR.43.4",
                            Type = @"Component",
                            Position = @"OBR.43.4",
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
                            Id = @"OBR.43.5",
                            Type = @"Component",
                            Position = @"OBR.43.5",
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
                            Id = @"OBR.43.6",
                            Type = @"Component",
                            Position = @"OBR.43.6",
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

        _plannedPatientTransportComment = new HL7V23Field
        {
            field = message[@"OBR"][43],
            fieldData = fieldData
        };

        // check for repetitions
        if (_plannedPatientTransportComment.field.FieldRepetitions != null && _plannedPatientTransportComment.field.FieldRepetitions.Count > 0)
        {
            _plannedPatientTransportComment.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_plannedPatientTransportComment, fieldData);
        }

        return _plannedPatientTransportComment;
    } 
}
    }
}
