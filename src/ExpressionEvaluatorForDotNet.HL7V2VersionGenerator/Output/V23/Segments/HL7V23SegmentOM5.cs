using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentOM5
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"OM5"; } }

        public string SegmentId { get { return @"OM5"; } }
        
        public string LongName { get { return @"Observation batteries"; } }
        
        public string Description { get { return @"This segment contains the information about batteries and supersets (a nature code of F, P or S, as described in OM1-18-nature of test/observation). "; } }
        
        public string Sample { get { return @""; } }

        public IList<string> Chapters 
        { 
            get 
            {
                return new[]
                    {
                        "CH_08",

                    };
            }
        }

        public HL7V23SegmentOM5(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _sequenceNumber;

public HL7V23Field SequenceNumber
{
    get
    {
        if (_sequenceNumber != null)
        {
            return _sequenceNumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OM5.1",
            Type = @"Field",
            Position = @"OM5.1",
            Name = @"Sequence Number",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the same value as the sequence number of the associated OM1 segment",
            Sample = @"",
            Fields = null
        }

        _sequenceNumber = new HL7V23Field
        {
            field = message[@"OM5"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_sequenceNumber.field.FieldRepetitions != null && _sequenceNumber.field.FieldRepetitions.Count > 0)
        {
            _sequenceNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_sequenceNumber, fieldData);
        }

        return _sequenceNumber;
    } 
}

internal HL7V23Field _testObservationsIncludedwanOrderedTestBattery;

public HL7V23Field TestObservationsIncludedwanOrderedTestBattery
{
    get
    {
        if (_testObservationsIncludedwanOrderedTestBattery != null)
        {
            return _testObservationsIncludedwanOrderedTestBattery;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OM5.2",
            Type = @"Field",
            Position = @"OM5.2",
            Name = @"Test/Observations Included w/an Ordered Test Battery",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the codes and names of all tests/observations included within a single battery (nature code P, as described in OM1-18-nature of test/observation), a single functional procedure (nature code F), or a given superset (nature code S).  When a segment includes a list of component elements, the sending system should be sure that the segments defining all of the components are sent before the segment that references them.  An entry in this list can itself be a battery. 
The individual test/observation IDs should be recorded as type CE, i.e., in the standard format for coded observation identifiers.  Multiple observations should be separated by repeat delimiters

If the definition segment defined serum electrolytes, this field might look like the following: 
84132^potassium^AS4~ 
84295^sodium^AS4~ 
82435^chloride^AS4~ 
82374^HCO3^^AS4~ 

For S (superset) parameters, this field contains the batteries that are included within the “super” battery. For example, ROUTINES might be defined as:
402^Electrolytes~352^Urinalysis~432^CBC~520^SMA12 ",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"OM5.2.1",
                            Type = @"Component",
                            Position = @"OM5.2.1",
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
                            Id = @"OM5.2.2",
                            Type = @"Component",
                            Position = @"OM5.2.2",
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
                            Id = @"OM5.2.3",
                            Type = @"Component",
                            Position = @"OM5.2.3",
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
                            Id = @"OM5.2.4",
                            Type = @"Component",
                            Position = @"OM5.2.4",
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
                            Id = @"OM5.2.5",
                            Type = @"Component",
                            Position = @"OM5.2.5",
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
                            Id = @"OM5.2.6",
                            Type = @"Component",
                            Position = @"OM5.2.6",
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

        _testObservationsIncludedwanOrderedTestBattery = new HL7V23Field
        {
            field = message[@"OM5"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_testObservationsIncludedwanOrderedTestBattery.field.FieldRepetitions != null && _testObservationsIncludedwanOrderedTestBattery.field.FieldRepetitions.Count > 0)
        {
            _testObservationsIncludedwanOrderedTestBattery.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_testObservationsIncludedwanOrderedTestBattery, fieldData);
        }

        return _testObservationsIncludedwanOrderedTestBattery;
    } 
}

internal HL7V23Field _observationIDSuffixes;

public HL7V23Field ObservationIDSuffixes
{
    get
    {
        if (_observationIDSuffixes != null)
        {
            return _observationIDSuffixes;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"OM5.3",
            Type = @"Field",
            Position = @"OM5.3",
            Name = @"Observation ID Suffixes",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the tests or procedures that produce a type which uses observation ID suffixes following the test/observation ID code.  This field lists the possible options.  The applicable threecharacter mnemonics given in ASTM Table 20 (or others appropriate to the application) are listed, separated by repeat delimiters.  For example, a chest X-ray may use the suffixes IMP, REC, DEV, or others. Each of the expected suffixes should be listed here",
            Sample = @"",
            Fields = null
        }

        _observationIDSuffixes = new HL7V23Field
        {
            field = message[@"OM5"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_observationIDSuffixes.field.FieldRepetitions != null && _observationIDSuffixes.field.FieldRepetitions.Count > 0)
        {
            _observationIDSuffixes.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_observationIDSuffixes, fieldData);
        }

        return _observationIDSuffixes;
    } 
}
    }
}
