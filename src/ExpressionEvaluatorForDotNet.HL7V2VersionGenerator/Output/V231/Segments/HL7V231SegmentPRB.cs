using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentPRB
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"PRB"; } }

        public string SegmentId { get { return @"PRB"; } }
        
        public string LongName { get { return @"Problem Detail"; } }
        
        public string Description { get { return @"The problem detail segment contains the data necessary to add, update, correct, and delete the problems of a given individual."; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_12",

                    };
            }
        }

        public HL7V231SegmentPRB(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V231Field _actionCode;

public HL7V231Field ActionCode
{
    get
    {
        if (_actionCode != null)
        {
            return _actionCode;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.1",
            Type = @"Field",
            Position = @"PRB.1",
            Name = @"Action Code",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0287",
            TableName = @"Problem/goal action code",
            Description = @"This field contains the intent of the message. Refer to HL7 table 0287 - Problem/goal action code for valid values.",
            Sample = @"",
            Fields = null
        }

        _actionCode = new HL7V231Field
        {
            field = message[@"PRB"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_actionCode.field.FieldRepetitions != null && _actionCode.field.FieldRepetitions.Count > 0)
        {
            _actionCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_actionCode, fieldData);
        }

        return _actionCode;
    } 
}

internal HL7V231Field _actionDateTime;

public HL7V231Field ActionDateTime
{
    get
    {
        if (_actionDateTime != null)
        {
            return _actionDateTime;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.2",
            Type = @"Field",
            Position = @"PRB.2",
            Name = @"Action Date/Time",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the operation represented by the action code was performed.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.2.1",
                            Type = @"Component",
                            Position = @"PRB.2.1",
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

        _actionDateTime = new HL7V231Field
        {
            field = message[@"PRB"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_actionDateTime.field.FieldRepetitions != null && _actionDateTime.field.FieldRepetitions.Count > 0)
        {
            _actionDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_actionDateTime, fieldData);
        }

        return _actionDateTime;
    } 
}

internal HL7V231Field _problemID;

public HL7V231Field ProblemID
{
    get
    {
        if (_problemID != null)
        {
            return _problemID;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.3",
            Type = @"Field",
            Position = @"PRB.3",
            Name = @"Problem ID",
            Length = 80,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the problem. This is the identifier from an institution's master list of problems.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.3.1",
                            Type = @"Component",
                            Position = @"PRB.3.1",
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
                            Id = @"PRB.3.2",
                            Type = @"Component",
                            Position = @"PRB.3.2",
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
                            Id = @"PRB.3.3",
                            Type = @"Component",
                            Position = @"PRB.3.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.3.4",
                            Type = @"Component",
                            Position = @"PRB.3.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.3.5",
                            Type = @"Component",
                            Position = @"PRB.3.5",
                            Name = @"Alternate Text",
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
                            Id = @"PRB.3.6",
                            Type = @"Component",
                            Position = @"PRB.3.6",
                            Name = @"Name Of Alternate Coding System",
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

        _problemID = new HL7V231Field
        {
            field = message[@"PRB"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemID.field.FieldRepetitions != null && _problemID.field.FieldRepetitions.Count > 0)
        {
            _problemID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_problemID, fieldData);
        }

        return _problemID;
    } 
}

internal HL7V231Field _problemInstanceID;

public HL7V231Field ProblemInstanceID
{
    get
    {
        if (_problemInstanceID != null)
        {
            return _problemInstanceID;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.4",
            Type = @"Field",
            Position = @"PRB.4",
            Name = @"Problem Instance ID",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identifier assigned by an initiating system to an instance of a problem.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.4.1",
                            Type = @"Component",
                            Position = @"PRB.4.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. (See Section 2.8.20, HD - hierarchic designator.)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.4.2",
                            Type = @"Component",
                            Position = @"PRB.4.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"See Section 2.8.20.1, Namespace ID (IS) for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.4.3",
                            Type = @"Component",
                            Position = @"PRB.4.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"See Section 2.8.20.2, Universal ID (ST) for definition..",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.4.4",
                            Type = @"Component",
                            Position = @"PRB.4.4",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values. See Section 2.8.20.2 Universal ID (ST), for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _problemInstanceID = new HL7V231Field
        {
            field = message[@"PRB"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemInstanceID.field.FieldRepetitions != null && _problemInstanceID.field.FieldRepetitions.Count > 0)
        {
            _problemInstanceID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_problemInstanceID, fieldData);
        }

        return _problemInstanceID;
    } 
}

internal HL7V231Field _episodeofCareID;

public HL7V231Field EpisodeofCareID
{
    get
    {
        if (_episodeofCareID != null)
        {
            return _episodeofCareID;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.5",
            Type = @"Field",
            Position = @"PRB.5",
            Name = @"Episode of Care ID",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field uniquely identifies the episode of care to which this problem applies. (See note under 'Ongoing issues.')",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.5.1",
                            Type = @"Component",
                            Position = @"PRB.5.1",
                            Name = @"Entity Identifier",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The first component, <entity identifier>, is usually defined to be unique within the series of identifiers created by the <assigning authority>, defined by a hierarchic designator, represented by components 2 through 4. (See Section 2.8.20, HD - hierarchic designator.)",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.5.2",
                            Type = @"Component",
                            Position = @"PRB.5.2",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"See Section 2.8.20.1, Namespace ID (IS) for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.5.3",
                            Type = @"Component",
                            Position = @"PRB.5.3",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"See Section 2.8.20.2, Universal ID (ST) for definition..",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.5.4",
                            Type = @"Component",
                            Position = @"PRB.5.4",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"Refer to HL7 table 0301 - Universal ID type for valid values. See Section 2.8.20.2 Universal ID (ST), for definition.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _episodeofCareID = new HL7V231Field
        {
            field = message[@"PRB"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_episodeofCareID.field.FieldRepetitions != null && _episodeofCareID.field.FieldRepetitions.Count > 0)
        {
            _episodeofCareID.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_episodeofCareID, fieldData);
        }

        return _episodeofCareID;
    } 
}

internal HL7V231Field _problemListPriority;

public HL7V231Field ProblemListPriority
{
    get
    {
        if (_problemListPriority != null)
        {
            return _problemListPriority;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.6",
            Type = @"Field",
            Position = @"PRB.6",
            Name = @"Problem List Priority",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field prioritizes this problem on a list that is maintained for the individual.",
            Sample = @"",
            Fields = null
        }

        _problemListPriority = new HL7V231Field
        {
            field = message[@"PRB"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemListPriority.field.FieldRepetitions != null && _problemListPriority.field.FieldRepetitions.Count > 0)
        {
            _problemListPriority.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_problemListPriority, fieldData);
        }

        return _problemListPriority;
    } 
}

internal HL7V231Field _problemEstablishedDateTime;

public HL7V231Field ProblemEstablishedDateTime
{
    get
    {
        if (_problemEstablishedDateTime != null)
        {
            return _problemEstablishedDateTime;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.7",
            Type = @"Field",
            Position = @"PRB.7",
            Name = @"Problem Established Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time when the corresponding problem was initially identified by the caregiver.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.7.1",
                            Type = @"Component",
                            Position = @"PRB.7.1",
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

        _problemEstablishedDateTime = new HL7V231Field
        {
            field = message[@"PRB"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemEstablishedDateTime.field.FieldRepetitions != null && _problemEstablishedDateTime.field.FieldRepetitions.Count > 0)
        {
            _problemEstablishedDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_problemEstablishedDateTime, fieldData);
        }

        return _problemEstablishedDateTime;
    } 
}

internal HL7V231Field _anticipatedProblemResolutionDateTime;

public HL7V231Field AnticipatedProblemResolutionDateTime
{
    get
    {
        if (_anticipatedProblemResolutionDateTime != null)
        {
            return _anticipatedProblemResolutionDateTime;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.8",
            Type = @"Field",
            Position = @"PRB.8",
            Name = @"Anticipated Problem Resolution Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the estimated date/time for resolving the stated problem.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.8.1",
                            Type = @"Component",
                            Position = @"PRB.8.1",
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

        _anticipatedProblemResolutionDateTime = new HL7V231Field
        {
            field = message[@"PRB"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_anticipatedProblemResolutionDateTime.field.FieldRepetitions != null && _anticipatedProblemResolutionDateTime.field.FieldRepetitions.Count > 0)
        {
            _anticipatedProblemResolutionDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_anticipatedProblemResolutionDateTime, fieldData);
        }

        return _anticipatedProblemResolutionDateTime;
    } 
}

internal HL7V231Field _actualProblemResolutionDateTime;

public HL7V231Field ActualProblemResolutionDateTime
{
    get
    {
        if (_actualProblemResolutionDateTime != null)
        {
            return _actualProblemResolutionDateTime;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.9",
            Type = @"Field",
            Position = @"PRB.9",
            Name = @"Actual Problem Resolution Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time that the problem was actually resolved.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.9.1",
                            Type = @"Component",
                            Position = @"PRB.9.1",
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

        _actualProblemResolutionDateTime = new HL7V231Field
        {
            field = message[@"PRB"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_actualProblemResolutionDateTime.field.FieldRepetitions != null && _actualProblemResolutionDateTime.field.FieldRepetitions.Count > 0)
        {
            _actualProblemResolutionDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_actualProblemResolutionDateTime, fieldData);
        }

        return _actualProblemResolutionDateTime;
    } 
}

internal HL7V231Field _problemClassification;

public HL7V231Field ProblemClassification
{
    get
    {
        if (_problemClassification != null)
        {
            return _problemClassification;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.10",
            Type = @"Field",
            Position = @"PRB.10",
            Name = @"Problem Classification",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the kind of problem. This field can be used to categorize problems so that they may be managed and viewed independently within different applications (e.g., admission, final, post-operative, pre-operative, outpatient, discharge, etc.).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.10.1",
                            Type = @"Component",
                            Position = @"PRB.10.1",
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
                            Id = @"PRB.10.2",
                            Type = @"Component",
                            Position = @"PRB.10.2",
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
                            Id = @"PRB.10.3",
                            Type = @"Component",
                            Position = @"PRB.10.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.10.4",
                            Type = @"Component",
                            Position = @"PRB.10.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.10.5",
                            Type = @"Component",
                            Position = @"PRB.10.5",
                            Name = @"Alternate Text",
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
                            Id = @"PRB.10.6",
                            Type = @"Component",
                            Position = @"PRB.10.6",
                            Name = @"Name Of Alternate Coding System",
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

        _problemClassification = new HL7V231Field
        {
            field = message[@"PRB"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemClassification.field.FieldRepetitions != null && _problemClassification.field.FieldRepetitions.Count > 0)
        {
            _problemClassification.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_problemClassification, fieldData);
        }

        return _problemClassification;
    } 
}

internal HL7V231Field _problemManagementDiscipline;

public HL7V231Field ProblemManagementDiscipline
{
    get
    {
        if (_problemManagementDiscipline != null)
        {
            return _problemManagementDiscipline;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.11",
            Type = @"Field",
            Position = @"PRB.11",
            Name = @"Problem Management Discipline",
            Length = 80,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the category of caregiver with responsibility for managing this specific problem (e.g., care team, nursing, medicine, respiratory therapy, occupational therapy, dietary etc.). This is a repeating field to allow identification of all disciplines who may have the responsibility for this problem.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.11.1",
                            Type = @"Component",
                            Position = @"PRB.11.1",
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
                            Id = @"PRB.11.2",
                            Type = @"Component",
                            Position = @"PRB.11.2",
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
                            Id = @"PRB.11.3",
                            Type = @"Component",
                            Position = @"PRB.11.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.11.4",
                            Type = @"Component",
                            Position = @"PRB.11.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.11.5",
                            Type = @"Component",
                            Position = @"PRB.11.5",
                            Name = @"Alternate Text",
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
                            Id = @"PRB.11.6",
                            Type = @"Component",
                            Position = @"PRB.11.6",
                            Name = @"Name Of Alternate Coding System",
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

        _problemManagementDiscipline = new HL7V231Field
        {
            field = message[@"PRB"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemManagementDiscipline.field.FieldRepetitions != null && _problemManagementDiscipline.field.FieldRepetitions.Count > 0)
        {
            _problemManagementDiscipline.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_problemManagementDiscipline, fieldData);
        }

        return _problemManagementDiscipline;
    } 
}

internal HL7V231Field _problemPersistence;

public HL7V231Field ProblemPersistence
{
    get
    {
        if (_problemPersistence != null)
        {
            return _problemPersistence;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.12",
            Type = @"Field",
            Position = @"PRB.12",
            Name = @"Problem Persistence",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the perseverance of a problem (e.g., acute, chronic, etc.).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.12.1",
                            Type = @"Component",
                            Position = @"PRB.12.1",
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
                            Id = @"PRB.12.2",
                            Type = @"Component",
                            Position = @"PRB.12.2",
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
                            Id = @"PRB.12.3",
                            Type = @"Component",
                            Position = @"PRB.12.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.12.4",
                            Type = @"Component",
                            Position = @"PRB.12.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.12.5",
                            Type = @"Component",
                            Position = @"PRB.12.5",
                            Name = @"Alternate Text",
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
                            Id = @"PRB.12.6",
                            Type = @"Component",
                            Position = @"PRB.12.6",
                            Name = @"Name Of Alternate Coding System",
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

        _problemPersistence = new HL7V231Field
        {
            field = message[@"PRB"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemPersistence.field.FieldRepetitions != null && _problemPersistence.field.FieldRepetitions.Count > 0)
        {
            _problemPersistence.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_problemPersistence, fieldData);
        }

        return _problemPersistence;
    } 
}

internal HL7V231Field _problemConfirmationStatus;

public HL7V231Field ProblemConfirmationStatus
{
    get
    {
        if (_problemConfirmationStatus != null)
        {
            return _problemConfirmationStatus;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.13",
            Type = @"Field",
            Position = @"PRB.13",
            Name = @"Problem Confirmation Status",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the verification status of a problem (e.g., confirmed, differential, provisional, rule-out, etc.).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.13.1",
                            Type = @"Component",
                            Position = @"PRB.13.1",
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
                            Id = @"PRB.13.2",
                            Type = @"Component",
                            Position = @"PRB.13.2",
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
                            Id = @"PRB.13.3",
                            Type = @"Component",
                            Position = @"PRB.13.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.13.4",
                            Type = @"Component",
                            Position = @"PRB.13.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.13.5",
                            Type = @"Component",
                            Position = @"PRB.13.5",
                            Name = @"Alternate Text",
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
                            Id = @"PRB.13.6",
                            Type = @"Component",
                            Position = @"PRB.13.6",
                            Name = @"Name Of Alternate Coding System",
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

        _problemConfirmationStatus = new HL7V231Field
        {
            field = message[@"PRB"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemConfirmationStatus.field.FieldRepetitions != null && _problemConfirmationStatus.field.FieldRepetitions.Count > 0)
        {
            _problemConfirmationStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_problemConfirmationStatus, fieldData);
        }

        return _problemConfirmationStatus;
    } 
}

internal HL7V231Field _problemLifeCycleStatus;

public HL7V231Field ProblemLifeCycleStatus
{
    get
    {
        if (_problemLifeCycleStatus != null)
        {
            return _problemLifeCycleStatus;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.14",
            Type = @"Field",
            Position = @"PRB.14",
            Name = @"Problem Life Cycle Status",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the current status of the problem at this particular date/time (e.g., active, active-improving, active-stable, active-worsening, inactive, resolved, etc.).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.14.1",
                            Type = @"Component",
                            Position = @"PRB.14.1",
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
                            Id = @"PRB.14.2",
                            Type = @"Component",
                            Position = @"PRB.14.2",
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
                            Id = @"PRB.14.3",
                            Type = @"Component",
                            Position = @"PRB.14.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.14.4",
                            Type = @"Component",
                            Position = @"PRB.14.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.14.5",
                            Type = @"Component",
                            Position = @"PRB.14.5",
                            Name = @"Alternate Text",
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
                            Id = @"PRB.14.6",
                            Type = @"Component",
                            Position = @"PRB.14.6",
                            Name = @"Name Of Alternate Coding System",
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

        _problemLifeCycleStatus = new HL7V231Field
        {
            field = message[@"PRB"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemLifeCycleStatus.field.FieldRepetitions != null && _problemLifeCycleStatus.field.FieldRepetitions.Count > 0)
        {
            _problemLifeCycleStatus.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_problemLifeCycleStatus, fieldData);
        }

        return _problemLifeCycleStatus;
    } 
}

internal HL7V231Field _problemLifeCycleStatusDateTime;

public HL7V231Field ProblemLifeCycleStatusDateTime
{
    get
    {
        if (_problemLifeCycleStatusDateTime != null)
        {
            return _problemLifeCycleStatusDateTime;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.15",
            Type = @"Field",
            Position = @"PRB.15",
            Name = @"Problem Life Cycle Status Date/Time",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the effective date/time of the current problem life cycle status.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.15.1",
                            Type = @"Component",
                            Position = @"PRB.15.1",
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

        _problemLifeCycleStatusDateTime = new HL7V231Field
        {
            field = message[@"PRB"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemLifeCycleStatusDateTime.field.FieldRepetitions != null && _problemLifeCycleStatusDateTime.field.FieldRepetitions.Count > 0)
        {
            _problemLifeCycleStatusDateTime.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_problemLifeCycleStatusDateTime, fieldData);
        }

        return _problemLifeCycleStatusDateTime;
    } 
}

internal HL7V231Field _problemDateofOnset;

public HL7V231Field ProblemDateofOnset
{
    get
    {
        if (_problemDateofOnset != null)
        {
            return _problemDateofOnset;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.16",
            Type = @"Field",
            Position = @"PRB.16",
            Name = @"Problem Date of Onset",
            Length = 26,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time when the problem began.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.16.1",
                            Type = @"Component",
                            Position = @"PRB.16.1",
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

        _problemDateofOnset = new HL7V231Field
        {
            field = message[@"PRB"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemDateofOnset.field.FieldRepetitions != null && _problemDateofOnset.field.FieldRepetitions.Count > 0)
        {
            _problemDateofOnset.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_problemDateofOnset, fieldData);
        }

        return _problemDateofOnset;
    } 
}

internal HL7V231Field _problemOnsetText;

public HL7V231Field ProblemOnsetText
{
    get
    {
        if (_problemOnsetText != null)
        {
            return _problemOnsetText;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.17",
            Type = @"Field",
            Position = @"PRB.17",
            Name = @"Problem Onset Text",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field allows for a textual representation of the time when the problem began.",
            Sample = @"",
            Fields = null
        }

        _problemOnsetText = new HL7V231Field
        {
            field = message[@"PRB"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemOnsetText.field.FieldRepetitions != null && _problemOnsetText.field.FieldRepetitions.Count > 0)
        {
            _problemOnsetText.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_problemOnsetText, fieldData);
        }

        return _problemOnsetText;
    } 
}

internal HL7V231Field _problemRanking;

public HL7V231Field ProblemRanking
{
    get
    {
        if (_problemRanking != null)
        {
            return _problemRanking;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.18",
            Type = @"Field",
            Position = @"PRB.18",
            Name = @"Problem Ranking",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains a user-defined prioritization of a problem (e.g., numeric ranking, or the use of words such as 'primary,' 'secondary,' etc.).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.18.1",
                            Type = @"Component",
                            Position = @"PRB.18.1",
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
                            Id = @"PRB.18.2",
                            Type = @"Component",
                            Position = @"PRB.18.2",
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
                            Id = @"PRB.18.3",
                            Type = @"Component",
                            Position = @"PRB.18.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.18.4",
                            Type = @"Component",
                            Position = @"PRB.18.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.18.5",
                            Type = @"Component",
                            Position = @"PRB.18.5",
                            Name = @"Alternate Text",
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
                            Id = @"PRB.18.6",
                            Type = @"Component",
                            Position = @"PRB.18.6",
                            Name = @"Name Of Alternate Coding System",
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

        _problemRanking = new HL7V231Field
        {
            field = message[@"PRB"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemRanking.field.FieldRepetitions != null && _problemRanking.field.FieldRepetitions.Count > 0)
        {
            _problemRanking.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_problemRanking, fieldData);
        }

        return _problemRanking;
    } 
}

internal HL7V231Field _certaintyofProblem;

public HL7V231Field CertaintyofProblem
{
    get
    {
        if (_certaintyofProblem != null)
        {
            return _certaintyofProblem;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.19",
            Type = @"Field",
            Position = @"PRB.19",
            Name = @"Certainty of Problem",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains a qualitative representation of the certainty of a problem (e.g., HI - high, LO - low, ME - medium, etc.).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.19.1",
                            Type = @"Component",
                            Position = @"PRB.19.1",
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
                            Id = @"PRB.19.2",
                            Type = @"Component",
                            Position = @"PRB.19.2",
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
                            Id = @"PRB.19.3",
                            Type = @"Component",
                            Position = @"PRB.19.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.19.4",
                            Type = @"Component",
                            Position = @"PRB.19.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.19.5",
                            Type = @"Component",
                            Position = @"PRB.19.5",
                            Name = @"Alternate Text",
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
                            Id = @"PRB.19.6",
                            Type = @"Component",
                            Position = @"PRB.19.6",
                            Name = @"Name Of Alternate Coding System",
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

        _certaintyofProblem = new HL7V231Field
        {
            field = message[@"PRB"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_certaintyofProblem.field.FieldRepetitions != null && _certaintyofProblem.field.FieldRepetitions.Count > 0)
        {
            _certaintyofProblem.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_certaintyofProblem, fieldData);
        }

        return _certaintyofProblem;
    } 
}

internal HL7V231Field _probabilityofProblem;

public HL7V231Field ProbabilityofProblem
{
    get
    {
        if (_probabilityofProblem != null)
        {
            return _probabilityofProblem;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.20",
            Type = @"Field",
            Position = @"PRB.20",
            Name = @"Probability of Problem",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains a quantitative or numeric representation of the certainty that the problem exists for this patient. This field has a valid range of 0 to 1. For example, a healthcare provider may be 75% (.75) sure that the problem has been correctly identified.",
            Sample = @"",
            Fields = null
        }

        _probabilityofProblem = new HL7V231Field
        {
            field = message[@"PRB"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_probabilityofProblem.field.FieldRepetitions != null && _probabilityofProblem.field.FieldRepetitions.Count > 0)
        {
            _probabilityofProblem.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_probabilityofProblem, fieldData);
        }

        return _probabilityofProblem;
    } 
}

internal HL7V231Field _individualAwarenessofProblem;

public HL7V231Field IndividualAwarenessofProblem
{
    get
    {
        if (_individualAwarenessofProblem != null)
        {
            return _individualAwarenessofProblem;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.21",
            Type = @"Field",
            Position = @"PRB.21",
            Name = @"Individual Awareness of Problem",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the individual's comprehension of the problem (e.g., full, marginal, partial, etc.).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.21.1",
                            Type = @"Component",
                            Position = @"PRB.21.1",
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
                            Id = @"PRB.21.2",
                            Type = @"Component",
                            Position = @"PRB.21.2",
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
                            Id = @"PRB.21.3",
                            Type = @"Component",
                            Position = @"PRB.21.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.21.4",
                            Type = @"Component",
                            Position = @"PRB.21.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.21.5",
                            Type = @"Component",
                            Position = @"PRB.21.5",
                            Name = @"Alternate Text",
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
                            Id = @"PRB.21.6",
                            Type = @"Component",
                            Position = @"PRB.21.6",
                            Name = @"Name Of Alternate Coding System",
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

        _individualAwarenessofProblem = new HL7V231Field
        {
            field = message[@"PRB"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_individualAwarenessofProblem.field.FieldRepetitions != null && _individualAwarenessofProblem.field.FieldRepetitions.Count > 0)
        {
            _individualAwarenessofProblem.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_individualAwarenessofProblem, fieldData);
        }

        return _individualAwarenessofProblem;
    } 
}

internal HL7V231Field _problemPrognosis;

public HL7V231Field ProblemPrognosis
{
    get
    {
        if (_problemPrognosis != null)
        {
            return _problemPrognosis;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.22",
            Type = @"Field",
            Position = @"PRB.22",
            Name = @"Problem Prognosis",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the prognosis for the individual's problem (e.g., good, poor, etc.).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.22.1",
                            Type = @"Component",
                            Position = @"PRB.22.1",
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
                            Id = @"PRB.22.2",
                            Type = @"Component",
                            Position = @"PRB.22.2",
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
                            Id = @"PRB.22.3",
                            Type = @"Component",
                            Position = @"PRB.22.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.22.4",
                            Type = @"Component",
                            Position = @"PRB.22.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.22.5",
                            Type = @"Component",
                            Position = @"PRB.22.5",
                            Name = @"Alternate Text",
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
                            Id = @"PRB.22.6",
                            Type = @"Component",
                            Position = @"PRB.22.6",
                            Name = @"Name Of Alternate Coding System",
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

        _problemPrognosis = new HL7V231Field
        {
            field = message[@"PRB"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_problemPrognosis.field.FieldRepetitions != null && _problemPrognosis.field.FieldRepetitions.Count > 0)
        {
            _problemPrognosis.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_problemPrognosis, fieldData);
        }

        return _problemPrognosis;
    } 
}

internal HL7V231Field _individualAwarenessofPrognosis;

public HL7V231Field IndividualAwarenessofPrognosis
{
    get
    {
        if (_individualAwarenessofPrognosis != null)
        {
            return _individualAwarenessofPrognosis;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.23",
            Type = @"Field",
            Position = @"PRB.23",
            Name = @"Individual Awareness of Prognosis",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the individual's comprehension of the prognosis for the problem (e.g., full, marginal, partial, etc.).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.23.1",
                            Type = @"Component",
                            Position = @"PRB.23.1",
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
                            Id = @"PRB.23.2",
                            Type = @"Component",
                            Position = @"PRB.23.2",
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
                            Id = @"PRB.23.3",
                            Type = @"Component",
                            Position = @"PRB.23.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.23.4",
                            Type = @"Component",
                            Position = @"PRB.23.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.23.5",
                            Type = @"Component",
                            Position = @"PRB.23.5",
                            Name = @"Alternate Text",
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
                            Id = @"PRB.23.6",
                            Type = @"Component",
                            Position = @"PRB.23.6",
                            Name = @"Name Of Alternate Coding System",
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

        _individualAwarenessofPrognosis = new HL7V231Field
        {
            field = message[@"PRB"][23],
            fieldData = fieldData
        };

        // check for repetitions
        if (_individualAwarenessofPrognosis.field.FieldRepetitions != null && _individualAwarenessofPrognosis.field.FieldRepetitions.Count > 0)
        {
            _individualAwarenessofPrognosis.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_individualAwarenessofPrognosis, fieldData);
        }

        return _individualAwarenessofPrognosis;
    } 
}

internal HL7V231Field _familySignificantOtherAwarenessofProblemPrognosis;

public HL7V231Field FamilySignificantOtherAwarenessofProblemPrognosis
{
    get
    {
        if (_familySignificantOtherAwarenessofProblemPrognosis != null)
        {
            return _familySignificantOtherAwarenessofProblemPrognosis;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.24",
            Type = @"Field",
            Position = @"PRB.24",
            Name = @"Family/Significant Other Awareness of Problem/Prognosis",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the individual's family or significant other's comprehension of the actual problem/prognosis.",
            Sample = @"",
            Fields = null
        }

        _familySignificantOtherAwarenessofProblemPrognosis = new HL7V231Field
        {
            field = message[@"PRB"][24],
            fieldData = fieldData
        };

        // check for repetitions
        if (_familySignificantOtherAwarenessofProblemPrognosis.field.FieldRepetitions != null && _familySignificantOtherAwarenessofProblemPrognosis.field.FieldRepetitions.Count > 0)
        {
            _familySignificantOtherAwarenessofProblemPrognosis.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_familySignificantOtherAwarenessofProblemPrognosis, fieldData);
        }

        return _familySignificantOtherAwarenessofProblemPrognosis;
    } 
}

internal HL7V231Field _securitySensitivity;

public HL7V231Field SecuritySensitivity
{
    get
    {
        if (_securitySensitivity != null)
        {
            return _securitySensitivity;
        }

        var fieldData = new HL7V231FieldData
        {
            Id = @"PRB.25",
            Type = @"Field",
            Position = @"PRB.25",
            Name = @"Security/Sensitivity",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains information about the level of security and/or sensitivity surrounding the problem (e.g., highly sensitive, not sensitive, sensitive, etc.).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PRB.25.1",
                            Type = @"Component",
                            Position = @"PRB.25.1",
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
                            Id = @"PRB.25.2",
                            Type = @"Component",
                            Position = @"PRB.25.2",
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
                            Id = @"PRB.25.3",
                            Type = @"Component",
                            Position = @"PRB.25.3",
                            Name = @"Name Of Coding System",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.25.4",
                            Type = @"Component",
                            Position = @"PRB.25.4",
                            Name = @"Alternate Components",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"These three components are defined analogously to the above for the alternate or local coding system. If the Alternate Text component is absent, and the Alternate Identifier is present, the Alternate Text will be taken to be the same as the Text component. If the Alternate Coding System component is absent, it will be taken to mean the locally-defined system.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PRB.25.5",
                            Type = @"Component",
                            Position = @"PRB.25.5",
                            Name = @"Alternate Text",
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
                            Id = @"PRB.25.6",
                            Type = @"Component",
                            Position = @"PRB.25.6",
                            Name = @"Name Of Alternate Coding System",
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

        _securitySensitivity = new HL7V231Field
        {
            field = message[@"PRB"][25],
            fieldData = fieldData
        };

        // check for repetitions
        if (_securitySensitivity.field.FieldRepetitions != null && _securitySensitivity.field.FieldRepetitions.Count > 0)
        {
            _securitySensitivity.fieldRepetitions = HL7V2FieldGenerator.GenerateV231FieldRepetitions(_securitySensitivity, fieldData);
        }

        return _securitySensitivity;
    } 
}
    }
}
