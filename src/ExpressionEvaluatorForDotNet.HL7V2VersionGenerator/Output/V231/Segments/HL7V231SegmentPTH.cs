using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentPTH
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"PTH"; } }

        public string SegmentId { get { return @"PTH"; } }
        
        public string LongName { get { return @"Pathway"; } }
        
        public string Description { get { return @"The pathway segment contains the data necessary to add, update, correct, and delete from the record pathways that are utilized to address an individual's health care."; } }
        
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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"PTH.1",
                            Type = @"Field",
                            Position = @"PTH.1",
                            Name = @"Action Code",
                            Length = 2,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0287",
                            TableName = @"Problem/goal action code",
                            Description = @"This field reveals the intent of the message. Refer to HL7 table 0287 - Problem/goal action code for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTH.2",
                            Type = @"Field",
                            Position = @"PTH.2",
                            Name = @"Pathway ID",
                            Length = 80,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the pathway master data identifier associated with the referenced problem or goal. Examples; open heart pathway, new diabetic, total hip replace.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"PTH.2.1",
                            Type = @"Component",
                            Position = @"PTH.2.1",
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
                            Id = @"PTH.2.2",
                            Type = @"Component",
                            Position = @"PTH.2.2",
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
                            Id = @"PTH.2.3",
                            Type = @"Component",
                            Position = @"PTH.2.3",
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
                            Id = @"PTH.2.4",
                            Type = @"Component",
                            Position = @"PTH.2.4",
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
                            Id = @"PTH.2.5",
                            Type = @"Component",
                            Position = @"PTH.2.5",
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
                            Id = @"PTH.2.6",
                            Type = @"Component",
                            Position = @"PTH.2.6",
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
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTH.3",
                            Type = @"Field",
                            Position = @"PTH.3",
                            Name = @"Pathway Instance ID",
                            Length = 60,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"EI",
                            DataTypeName = @"Entity Identifier",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains a value generated by the originating application that represents an associated order placer group number, or other unique identifier assigned to the grouping of pathway directives.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"PTH.3.1",
                            Type = @"Component",
                            Position = @"PTH.3.1",
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
                            Id = @"PTH.3.2",
                            Type = @"Component",
                            Position = @"PTH.3.2",
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
                            Id = @"PTH.3.3",
                            Type = @"Component",
                            Position = @"PTH.3.3",
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
                            Id = @"PTH.3.4",
                            Type = @"Component",
                            Position = @"PTH.3.4",
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
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTH.4",
                            Type = @"Field",
                            Position = @"PTH.4",
                            Name = @"Pathway Established Date/Time",
                            Length = 26,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the identification of the event time for the current pathway record.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"PTH.4.1",
                            Type = @"Component",
                            Position = @"PTH.4.1",
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
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTH.5",
                            Type = @"Field",
                            Position = @"PTH.5",
                            Name = @"Pathway Life Cycle Status",
                            Length = 80,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains an application-specific set of state identifiers (e.g., Active, Suspended, Complete, Canceled, Delayed, Scheduled).",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"PTH.5.1",
                            Type = @"Component",
                            Position = @"PTH.5.1",
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
                            Id = @"PTH.5.2",
                            Type = @"Component",
                            Position = @"PTH.5.2",
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
                            Id = @"PTH.5.3",
                            Type = @"Component",
                            Position = @"PTH.5.3",
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
                            Id = @"PTH.5.4",
                            Type = @"Component",
                            Position = @"PTH.5.4",
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
                            Id = @"PTH.5.5",
                            Type = @"Component",
                            Position = @"PTH.5.5",
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
                            Id = @"PTH.5.6",
                            Type = @"Component",
                            Position = @"PTH.5.6",
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
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"PTH.6",
                            Type = @"Field",
                            Position = @"PTH.6",
                            Name = @"Change Pathway Life Cycle Status Date/Time",
                            Length = 26,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"TS",
                            DataTypeName = @"Time Stamp",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the date/time when pathway has been modified or deactivated. (Marked as conditional - must be filled in if trigger event is update or terminate pathway)",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"PTH.6.1",
                            Type = @"Component",
                            Position = @"PTH.6.1",
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
                        },
                        };
            }
        }

        public HL7V231SegmentPTH(HL7V2Message message)
        {
            this.message = message;
        }

        
internal HL7V231Field actionCode;

public HL7V231Field ActionCode
{
    get
    {
        if (actionCode != null)
        {
            return actionCode;
        }

        actionCode = new HL7V231Field
        {
            field = message[@"PTH"][1],
            Id = @"PTH.1",
            Type = @"Field",
            Position = @"PTH.1",
            Name = @"Action Code",
            Length = 2,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0287",
            TableName = @"Problem/goal action code",
            Description = @"This field reveals the intent of the message. Refer to HL7 table 0287 - Problem/goal action code for valid values.",
            Sample = @"",
        };

        // check for repetitions
        if (actionCode.field.FieldRepetitions != null && actionCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(actionCode.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < actionCode.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = actionCode.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < actionCode.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = actionCode.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < actionCode.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = actionCode.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            actionCode.fieldRepetitions = fieldRepetitions;
        }

        return actionCode;
    } 
}

internal HL7V231Field pathwayID;

public HL7V231Field PathwayID
{
    get
    {
        if (pathwayID != null)
        {
            return pathwayID;
        }

        pathwayID = new HL7V231Field
        {
            field = message[@"PTH"][2],
            Id = @"PTH.2",
            Type = @"Field",
            Position = @"PTH.2",
            Name = @"Pathway ID",
            Length = 80,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the pathway master data identifier associated with the referenced problem or goal. Examples; open heart pathway, new diabetic, total hip replace.",
            Sample = @"",
        };

        // check for repetitions
        if (pathwayID.field.FieldRepetitions != null && pathwayID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(pathwayID.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < pathwayID.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = pathwayID.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < pathwayID.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = pathwayID.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < pathwayID.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = pathwayID.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            pathwayID.fieldRepetitions = fieldRepetitions;
        }

        return pathwayID;
    } 
}

internal HL7V231Field pathwayInstanceID;

public HL7V231Field PathwayInstanceID
{
    get
    {
        if (pathwayInstanceID != null)
        {
            return pathwayInstanceID;
        }

        pathwayInstanceID = new HL7V231Field
        {
            field = message[@"PTH"][3],
            Id = @"PTH.3",
            Type = @"Field",
            Position = @"PTH.3",
            Name = @"Pathway Instance ID",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"EI",
            DataTypeName = @"Entity Identifier",
            TableId = null,
            TableName = null,
            Description = @"This field contains a value generated by the originating application that represents an associated order placer group number, or other unique identifier assigned to the grouping of pathway directives.",
            Sample = @"",
        };

        // check for repetitions
        if (pathwayInstanceID.field.FieldRepetitions != null && pathwayInstanceID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(pathwayInstanceID.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < pathwayInstanceID.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = pathwayInstanceID.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < pathwayInstanceID.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = pathwayInstanceID.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < pathwayInstanceID.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = pathwayInstanceID.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            pathwayInstanceID.fieldRepetitions = fieldRepetitions;
        }

        return pathwayInstanceID;
    } 
}

internal HL7V231Field pathwayEstablishedDateTime;

public HL7V231Field PathwayEstablishedDateTime
{
    get
    {
        if (pathwayEstablishedDateTime != null)
        {
            return pathwayEstablishedDateTime;
        }

        pathwayEstablishedDateTime = new HL7V231Field
        {
            field = message[@"PTH"][4],
            Id = @"PTH.4",
            Type = @"Field",
            Position = @"PTH.4",
            Name = @"Pathway Established Date/Time",
            Length = 26,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the identification of the event time for the current pathway record.",
            Sample = @"",
        };

        // check for repetitions
        if (pathwayEstablishedDateTime.field.FieldRepetitions != null && pathwayEstablishedDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(pathwayEstablishedDateTime.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < pathwayEstablishedDateTime.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = pathwayEstablishedDateTime.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < pathwayEstablishedDateTime.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = pathwayEstablishedDateTime.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < pathwayEstablishedDateTime.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = pathwayEstablishedDateTime.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            pathwayEstablishedDateTime.fieldRepetitions = fieldRepetitions;
        }

        return pathwayEstablishedDateTime;
    } 
}

internal HL7V231Field pathwayLifeCycleStatus;

public HL7V231Field PathwayLifeCycleStatus
{
    get
    {
        if (pathwayLifeCycleStatus != null)
        {
            return pathwayLifeCycleStatus;
        }

        pathwayLifeCycleStatus = new HL7V231Field
        {
            field = message[@"PTH"][5],
            Id = @"PTH.5",
            Type = @"Field",
            Position = @"PTH.5",
            Name = @"Pathway Life Cycle Status",
            Length = 80,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains an application-specific set of state identifiers (e.g., Active, Suspended, Complete, Canceled, Delayed, Scheduled).",
            Sample = @"",
        };

        // check for repetitions
        if (pathwayLifeCycleStatus.field.FieldRepetitions != null && pathwayLifeCycleStatus.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(pathwayLifeCycleStatus.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < pathwayLifeCycleStatus.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = pathwayLifeCycleStatus.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < pathwayLifeCycleStatus.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = pathwayLifeCycleStatus.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < pathwayLifeCycleStatus.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = pathwayLifeCycleStatus.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            pathwayLifeCycleStatus.fieldRepetitions = fieldRepetitions;
        }

        return pathwayLifeCycleStatus;
    } 
}

internal HL7V231Field changePathwayLifeCycleStatusDateTime;

public HL7V231Field ChangePathwayLifeCycleStatusDateTime
{
    get
    {
        if (changePathwayLifeCycleStatusDateTime != null)
        {
            return changePathwayLifeCycleStatusDateTime;
        }

        changePathwayLifeCycleStatusDateTime = new HL7V231Field
        {
            field = message[@"PTH"][6],
            Id = @"PTH.6",
            Type = @"Field",
            Position = @"PTH.6",
            Name = @"Change Pathway Life Cycle Status Date/Time",
            Length = 26,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"TS",
            DataTypeName = @"Time Stamp",
            TableId = null,
            TableName = null,
            Description = @"This field contains the date/time when pathway has been modified or deactivated. (Marked as conditional - must be filled in if trigger event is update or terminate pathway)",
            Sample = @"",
        };

        // check for repetitions
        if (changePathwayLifeCycleStatusDateTime.field.FieldRepetitions != null && changePathwayLifeCycleStatusDateTime.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(changePathwayLifeCycleStatusDateTime.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < changePathwayLifeCycleStatusDateTime.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = changePathwayLifeCycleStatusDateTime.field.FieldRepetitions[i],
                    Id = fieldData.Id,
                    Type = fieldData.Type,
                    Position = fieldData.Position,
                    Name = fieldData.Name,
                    Length = fieldData.Length,
                    Usage = fieldData.Usage,
                    Rpt = fieldData.Rpt,
                    DataType = fieldData.DataType,
                    DataTypeName = fieldData.DataTypeName,
                    TableId = fieldData.TableId,
                    TableName = fieldData.TableName,
                    Description = fieldData.Description,
                    Sample = fieldData.Sample
                };

                // check for components if the definition specifies it does
                if (fieldData.FieldDatas != null && fieldData.FieldDatas.Count > 0)
                {
                    var components = new List<HL7V231Component>();

                    // there should be components per repetition
                    for (var j = 0; j < changePathwayLifeCycleStatusDateTime.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = changePathwayLifeCycleStatusDateTime.field.FieldRepetitions[i].Components[j],
                            Id = componentFieldData.Id,
                            Type = componentFieldData.Type,
                            Position = componentFieldData.Position,
                            Name = componentFieldData.Name,
                            Length = componentFieldData.Length,
                            Usage = componentFieldData.Usage,
                            Rpt = componentFieldData.Rpt,
                            DataType = componentFieldData.DataType,
                            DataTypeName = componentFieldData.DataTypeName,
                            TableId = componentFieldData.TableId,
                            TableName = componentFieldData.TableName,
                            Description = componentFieldData.Description,
                            Sample = componentFieldData.Sample
                        };

                        // check for sub components
                        if (componentFieldData.FieldDatas != null && componentFieldData.FieldDatas.Count > 0)
                        {
                            var subComponents = new List<HL7V231SubComponent>();

                            for (var k = 0; k < changePathwayLifeCycleStatusDateTime.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = changePathwayLifeCycleStatusDateTime.field.FieldRepetitions[i].Components[j].SubComponents[k],
                                    Id = subComponentFieldData.Id,
                                    Type = subComponentFieldData.Type,
                                    Position = subComponentFieldData.Position,
                                    Name = subComponentFieldData.Name,
                                    Length = subComponentFieldData.Length,
                                    Usage = subComponentFieldData.Usage,
                                    Rpt = subComponentFieldData.Rpt,
                                    DataType = subComponentFieldData.DataType,
                                    DataTypeName = subComponentFieldData.DataTypeName,
                                    TableId = subComponentFieldData.TableId,
                                    TableName = subComponentFieldData.TableName,
                                    Description = subComponentFieldData.Description,
                                    Sample = subComponentFieldData.Sample
                                };

                                subComponents.Add(subComponent);
                            }

                            component.subComponents = subComponents;
                        }

                        components.Add(component);
                    }

                    fieldRepetition.components = components;
                }

                fieldRepetitions.Add(fieldRepetition);
            }
                     
            changePathwayLifeCycleStatusDateTime.fieldRepetitions = fieldRepetitions;
        }

        return changePathwayLifeCycleStatusDateTime;
    } 
}

    }
}
