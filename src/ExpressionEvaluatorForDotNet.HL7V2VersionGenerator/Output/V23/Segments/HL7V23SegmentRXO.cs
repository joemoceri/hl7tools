using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V23SegmentRXO
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"RXO"; } }

        public string SegmentId { get { return @"RXO"; } }
        
        public string LongName { get { return @"Pharmacy prescription order segment"; } }
        
        public string Description { get { return @"This is the “master” pharmacy/treatment order segment.  It contains order data not specific to components or additives.  Unlike the OBR, it does not contain status fields or other data that are results-only.

It can be used for any type of pharmacy order, including inpatient (unit dose and compound unit dose), outpatient, IVs, and hyperalimentation IVs (nutritional IVs), as well as other nonpharmacy treatments, e.g., respiratory therapy, oxygen, and metabolites.  

In addition to the pharmaceutical information, this segment contains additional data such as provider and text comments. 

A quantity/timing field is not needed in the RXO segment.  The ORC segment contains the requested ORC7-quantity/timing of the original order which does not change as the order is encoded, dispensed, or administered. "; } }
        
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

        public HL7V23SegmentRXO(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V23Field _requestedGiveCode;

public HL7V23Field RequestedGiveCode
{
    get
    {
        if (_requestedGiveCode != null)
        {
            return _requestedGiveCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RXO.1",
            Type = @"Field",
            Position = @"RXO.1",
            Name = @"Requested Give Code",
            Length = 100,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the medical substance or product ordered to be given to the patient; it is equivalent to OBR-4-universal service ID code in function.  The request-to-dispense fields, which define the type and amount of what is to be issued to the patient (see RXO-10 requested dispense code, RXO-11requested dispense amount, and RXO-12-requested dispense units), do not necessarily correlate with the instructions of what amount is to be “given” or administered with each dose, and may or may not be specified with the order.  For example, the “give” part of the order may convey the field-representation of give 15 mg of Librium every 6 hours, while the request to dispense part of the order may convey issue 30 tablets of 10 mg generic equivalent for this outpatient prescription.  When the give code does not include the dosage form, use RXO-5-requested dosage form",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.1.1",
                            Type = @"Component",
                            Position = @"RXO.1.1",
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
                            Id = @"RXO.1.2",
                            Type = @"Component",
                            Position = @"RXO.1.2",
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
                            Id = @"RXO.1.3",
                            Type = @"Component",
                            Position = @"RXO.1.3",
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
                            Id = @"RXO.1.4",
                            Type = @"Component",
                            Position = @"RXO.1.4",
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
                            Id = @"RXO.1.5",
                            Type = @"Component",
                            Position = @"RXO.1.5",
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
                            Id = @"RXO.1.6",
                            Type = @"Component",
                            Position = @"RXO.1.6",
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

        _requestedGiveCode = new HL7V23Field
        {
            field = message[@"RXO"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedGiveCode.field.FieldRepetitions != null && _requestedGiveCode.field.FieldRepetitions.Count > 0)
        {
            _requestedGiveCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_requestedGiveCode, fieldData);
        }

        return _requestedGiveCode;
    } 
}

internal HL7V23Field _requestedGiveAmountMinimum;

public HL7V23Field RequestedGiveAmountMinimum
{
    get
    {
        if (_requestedGiveAmountMinimum != null)
        {
            return _requestedGiveAmountMinimum;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RXO.2",
            Type = @"Field",
            Position = @"RXO.2",
            Name = @"Requested Give Amount - Minimum",
            Length = 20,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the ordered amount.  In a variable dose order, this is the minimum ordered amount.  In a nonvarying dose order, this is the exact amount of the order",
            Sample = @"",
            Fields = null
        }

        _requestedGiveAmountMinimum = new HL7V23Field
        {
            field = message[@"RXO"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedGiveAmountMinimum.field.FieldRepetitions != null && _requestedGiveAmountMinimum.field.FieldRepetitions.Count > 0)
        {
            _requestedGiveAmountMinimum.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_requestedGiveAmountMinimum, fieldData);
        }

        return _requestedGiveAmountMinimum;
    } 
}

internal HL7V23Field _requestedGiveAmountMaximum;

public HL7V23Field RequestedGiveAmountMaximum
{
    get
    {
        if (_requestedGiveAmountMaximum != null)
        {
            return _requestedGiveAmountMaximum;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RXO.3",
            Type = @"Field",
            Position = @"RXO.3",
            Name = @"Requested Give Amount - Maximum",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"In a variable dose order, this is the maximum ordered amount.  In a nonvarying dose order, this field is not used",
            Sample = @"",
            Fields = null
        }

        _requestedGiveAmountMaximum = new HL7V23Field
        {
            field = message[@"RXO"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedGiveAmountMaximum.field.FieldRepetitions != null && _requestedGiveAmountMaximum.field.FieldRepetitions.Count > 0)
        {
            _requestedGiveAmountMaximum.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_requestedGiveAmountMaximum, fieldData);
        }

        return _requestedGiveAmountMaximum;
    } 
}

internal HL7V23Field _requestedGiveUnits;

public HL7V23Field RequestedGiveUnits
{
    get
    {
        if (_requestedGiveUnits != null)
        {
            return _requestedGiveUnits;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RXO.4",
            Type = @"Field",
            Position = @"RXO.4",
            Name = @"Requested Give Units",
            Length = 60,
            Usage = @"R",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the units for the give amount",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.4.1",
                            Type = @"Component",
                            Position = @"RXO.4.1",
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
                            Id = @"RXO.4.2",
                            Type = @"Component",
                            Position = @"RXO.4.2",
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
                            Id = @"RXO.4.3",
                            Type = @"Component",
                            Position = @"RXO.4.3",
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
                            Id = @"RXO.4.4",
                            Type = @"Component",
                            Position = @"RXO.4.4",
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
                            Id = @"RXO.4.5",
                            Type = @"Component",
                            Position = @"RXO.4.5",
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
                            Id = @"RXO.4.6",
                            Type = @"Component",
                            Position = @"RXO.4.6",
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

        _requestedGiveUnits = new HL7V23Field
        {
            field = message[@"RXO"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedGiveUnits.field.FieldRepetitions != null && _requestedGiveUnits.field.FieldRepetitions.Count > 0)
        {
            _requestedGiveUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_requestedGiveUnits, fieldData);
        }

        return _requestedGiveUnits;
    } 
}

internal HL7V23Field _requestedDosageForm;

public HL7V23Field RequestedDosageForm
{
    get
    {
        if (_requestedDosageForm != null)
        {
            return _requestedDosageForm;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RXO.5",
            Type = @"Field",
            Position = @"RXO.5",
            Name = @"Requested Dosage Form",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the manner in which the medication is aggregated for dispensing, e.g., tablets, capsules, suppositories.  In some cases, this information is implied by the dispense/give code in RXO-1-requested give code or RXO-10-requested dispense code.  Use when both RXO-1-requested give code and RXO-10-requested dispense code do not specify the drug/treatment form",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.5.1",
                            Type = @"Component",
                            Position = @"RXO.5.1",
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
                            Id = @"RXO.5.2",
                            Type = @"Component",
                            Position = @"RXO.5.2",
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
                            Id = @"RXO.5.3",
                            Type = @"Component",
                            Position = @"RXO.5.3",
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
                            Id = @"RXO.5.4",
                            Type = @"Component",
                            Position = @"RXO.5.4",
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
                            Id = @"RXO.5.5",
                            Type = @"Component",
                            Position = @"RXO.5.5",
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
                            Id = @"RXO.5.6",
                            Type = @"Component",
                            Position = @"RXO.5.6",
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

        _requestedDosageForm = new HL7V23Field
        {
            field = message[@"RXO"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedDosageForm.field.FieldRepetitions != null && _requestedDosageForm.field.FieldRepetitions.Count > 0)
        {
            _requestedDosageForm.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_requestedDosageForm, fieldData);
        }

        return _requestedDosageForm;
    } 
}

internal HL7V23Field _providersPharmacyInstructions;

public HL7V23Field ProvidersPharmacyInstructions
{
    get
    {
        if (_providersPharmacyInstructions != null)
        {
            return _providersPharmacyInstructions;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RXO.6",
            Type = @"Field",
            Position = @"RXO.6",
            Name = @"Provider's Pharmacy Instructions",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the ordering provider’s instructions to the pharmacy or the non-pharmacy treatment provider (e.g., respiratory therapy).  If coded, a user-defined table must be used.  If transmitted as a free text field, place a null in the first component and the text in the second, e.g., |^this is a free text treatment instruction",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.6.1",
                            Type = @"Component",
                            Position = @"RXO.6.1",
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
                            Id = @"RXO.6.2",
                            Type = @"Component",
                            Position = @"RXO.6.2",
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
                            Id = @"RXO.6.3",
                            Type = @"Component",
                            Position = @"RXO.6.3",
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
                            Id = @"RXO.6.4",
                            Type = @"Component",
                            Position = @"RXO.6.4",
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
                            Id = @"RXO.6.5",
                            Type = @"Component",
                            Position = @"RXO.6.5",
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
                            Id = @"RXO.6.6",
                            Type = @"Component",
                            Position = @"RXO.6.6",
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

        _providersPharmacyInstructions = new HL7V23Field
        {
            field = message[@"RXO"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_providersPharmacyInstructions.field.FieldRepetitions != null && _providersPharmacyInstructions.field.FieldRepetitions.Count > 0)
        {
            _providersPharmacyInstructions.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_providersPharmacyInstructions, fieldData);
        }

        return _providersPharmacyInstructions;
    } 
}

internal HL7V23Field _providersAdministrationInstructions;

public HL7V23Field ProvidersAdministrationInstructions
{
    get
    {
        if (_providersAdministrationInstructions != null)
        {
            return _providersAdministrationInstructions;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RXO.7",
            Type = @"Field",
            Position = @"RXO.7",
            Name = @"Provider's Administration Instructions",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the ordering provider’s instructions to the patient or to the provider administering the drug or treatment.  If coded, a user-defined table must be used. If transmitted as free text, place a null in the first component and the text in the second, e.g., |^this is a free text administration instruction",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.7.1",
                            Type = @"Component",
                            Position = @"RXO.7.1",
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
                            Id = @"RXO.7.2",
                            Type = @"Component",
                            Position = @"RXO.7.2",
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
                            Id = @"RXO.7.3",
                            Type = @"Component",
                            Position = @"RXO.7.3",
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
                            Id = @"RXO.7.4",
                            Type = @"Component",
                            Position = @"RXO.7.4",
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
                            Id = @"RXO.7.5",
                            Type = @"Component",
                            Position = @"RXO.7.5",
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
                            Id = @"RXO.7.6",
                            Type = @"Component",
                            Position = @"RXO.7.6",
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

        _providersAdministrationInstructions = new HL7V23Field
        {
            field = message[@"RXO"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_providersAdministrationInstructions.field.FieldRepetitions != null && _providersAdministrationInstructions.field.FieldRepetitions.Count > 0)
        {
            _providersAdministrationInstructions.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_providersAdministrationInstructions, fieldData);
        }

        return _providersAdministrationInstructions;
    } 
}

internal HL7V23Field _deliverToLocation;

public HL7V23Field DeliverToLocation
{
    get
    {
        if (_deliverToLocation != null)
        {
            return _deliverToLocation;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RXO.8",
            Type = @"Field",
            Position = @"RXO.8",
            Name = @"Deliver To Location",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"LA1",
            DataTypeName = @"Location With Address Information (variant 1)",
            TableId = null,
            TableName = null,
            Description = @"The first components, modeled after the  PL data type, contain the inpatient or outpatient location to which the pharmacy provider or treatment supplier is to deliver the drug or treatment device (if applicable).  The default (null) value is the current census location for the patient. This component has the same form as PV1-3-assigned patient location.  The last component can be used to specify an address.  This could be used to fill mail orders to a patient or provider, or to account for home health care",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.8.1",
                            Type = @"Component",
                            Position = @"RXO.8.1",
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
                            Id = @"RXO.8.2",
                            Type = @"Component",
                            Position = @"RXO.8.2",
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
                            Id = @"RXO.8.3",
                            Type = @"Component",
                            Position = @"RXO.8.3",
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
                            Id = @"RXO.8.4",
                            Type = @"Component",
                            Position = @"RXO.8.4",
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
                            Id = @"RXO.8.4.1",
                            Type = @"SubComponent",
                            Position = @"RXO.8.4.1",
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
                            Id = @"RXO.8.4.2",
                            Type = @"SubComponent",
                            Position = @"RXO.8.4.2",
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
                            Id = @"RXO.8.4.3",
                            Type = @"SubComponent",
                            Position = @"RXO.8.4.3",
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
                            Id = @"RXO.8.5",
                            Type = @"Component",
                            Position = @"RXO.8.5",
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
                            Id = @"RXO.8.6",
                            Type = @"Component",
                            Position = @"RXO.8.6",
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
                            Id = @"RXO.8.7",
                            Type = @"Component",
                            Position = @"RXO.8.7",
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
                            Id = @"RXO.8.8",
                            Type = @"Component",
                            Position = @"RXO.8.8",
                            Name = @"Floor",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0308",
                            TableName = @"Floor",
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.9",
                            Type = @"Component",
                            Position = @"RXO.8.9",
                            Name = @"Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"AD",
                            DataTypeName = @"Address",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"RXO.8.9.1",
                            Type = @"SubComponent",
                            Position = @"RXO.8.9.1",
                            Name = @"Street Address",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Street address ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.9.2",
                            Type = @"SubComponent",
                            Position = @"RXO.8.9.2",
                            Name = @"Other Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Second line of address. In general, it qualifies address.  Examples:  Suite 555 or Fourth Floor",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.9.3",
                            Type = @"SubComponent",
                            Position = @"RXO.8.9.3",
                            Name = @"City",
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
                            Id = @"RXO.8.9.4",
                            Type = @"SubComponent",
                            Position = @"RXO.8.9.4",
                            Name = @"State Or Province",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"State or province should be represented by the official postal service codes for that country",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.9.5",
                            Type = @"SubComponent",
                            Position = @"RXO.8.9.5",
                            Name = @"Zip Or Postal Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Zip or postal codes should be represented by the official codes for that country.  In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A-9A9",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.9.6",
                            Type = @"SubComponent",
                            Position = @"RXO.8.9.6",
                            Name = @"Country",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO3166",
                            TableName = @"Country Codes",
                            Description = @"Defines  the country of the address.   ISO 3166 provides a list of country codes that may be used",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.9.7",
                            Type = @"SubComponent",
                            Position = @"RXO.8.9.7",
                            Name = @"Address Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0190",
                            TableName = @"Address type",
                            Description = @"Type is optional and defined by HL7 table 0190 - Address type",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.9.8",
                            Type = @"SubComponent",
                            Position = @"RXO.8.9.8",
                            Name = @"Other Geographic Designation",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Other geographic designation includes county, bioregion, SMSA, etc",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _deliverToLocation = new HL7V23Field
        {
            field = message[@"RXO"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_deliverToLocation.field.FieldRepetitions != null && _deliverToLocation.field.FieldRepetitions.Count > 0)
        {
            _deliverToLocation.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_deliverToLocation, fieldData);
        }

        return _deliverToLocation;
    } 
}

internal HL7V23Field _allowSubstitutions;

public HL7V23Field AllowSubstitutions
{
    get
    {
        if (_allowSubstitutions != null)
        {
            return _allowSubstitutions;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RXO.9",
            Type = @"Field",
            Position = @"RXO.9",
            Name = @"Allow Substitutions",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0161",
            TableName = @"Allow substitution",
            Description = null,
            Sample = @"",
            Fields = null
        }

        _allowSubstitutions = new HL7V23Field
        {
            field = message[@"RXO"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_allowSubstitutions.field.FieldRepetitions != null && _allowSubstitutions.field.FieldRepetitions.Count > 0)
        {
            _allowSubstitutions.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_allowSubstitutions, fieldData);
        }

        return _allowSubstitutions;
    } 
}

internal HL7V23Field _requestedDispenseCode;

public HL7V23Field RequestedDispenseCode
{
    get
    {
        if (_requestedDispenseCode != null)
        {
            return _requestedDispenseCode;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RXO.10",
            Type = @"Field",
            Position = @"RXO.10",
            Name = @"Requested Dispense Code",
            Length = 100,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field indicates what is to be/was dispensed; it is equivalent to OBR-4-universal service ID in function.  It may be present in the order or not, depending on the application.  If not present, and values are given for RXO-11-requested dispense amount and RXO-12-requested dispense units, the RXO-1requested give code is assumed.  If the requested dispense code does not include the dosage form, use RXO-5-requested dosage form",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.10.1",
                            Type = @"Component",
                            Position = @"RXO.10.1",
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
                            Id = @"RXO.10.2",
                            Type = @"Component",
                            Position = @"RXO.10.2",
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
                            Id = @"RXO.10.3",
                            Type = @"Component",
                            Position = @"RXO.10.3",
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
                            Id = @"RXO.10.4",
                            Type = @"Component",
                            Position = @"RXO.10.4",
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
                            Id = @"RXO.10.5",
                            Type = @"Component",
                            Position = @"RXO.10.5",
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
                            Id = @"RXO.10.6",
                            Type = @"Component",
                            Position = @"RXO.10.6",
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

        _requestedDispenseCode = new HL7V23Field
        {
            field = message[@"RXO"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedDispenseCode.field.FieldRepetitions != null && _requestedDispenseCode.field.FieldRepetitions.Count > 0)
        {
            _requestedDispenseCode.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_requestedDispenseCode, fieldData);
        }

        return _requestedDispenseCode;
    } 
}

internal HL7V23Field _requestedDispenseAmount;

public HL7V23Field RequestedDispenseAmount
{
    get
    {
        if (_requestedDispenseAmount != null)
        {
            return _requestedDispenseAmount;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RXO.11",
            Type = @"Field",
            Position = @"RXO.11",
            Name = @"Requested Dispense Amount",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the amount to be dispensed",
            Sample = @"",
            Fields = null
        }

        _requestedDispenseAmount = new HL7V23Field
        {
            field = message[@"RXO"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedDispenseAmount.field.FieldRepetitions != null && _requestedDispenseAmount.field.FieldRepetitions.Count > 0)
        {
            _requestedDispenseAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_requestedDispenseAmount, fieldData);
        }

        return _requestedDispenseAmount;
    } 
}

internal HL7V23Field _requestedDispenseUnits;

public HL7V23Field RequestedDispenseUnits
{
    get
    {
        if (_requestedDispenseUnits != null)
        {
            return _requestedDispenseUnits;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RXO.12",
            Type = @"Field",
            Position = @"RXO.12",
            Name = @"Requested Dispense Units",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the units for the dispense amount.  This must be in simple units that reflect the actual quantity of the substance to be dispensed.  It does not include compound units",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.12.1",
                            Type = @"Component",
                            Position = @"RXO.12.1",
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
                            Id = @"RXO.12.2",
                            Type = @"Component",
                            Position = @"RXO.12.2",
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
                            Id = @"RXO.12.3",
                            Type = @"Component",
                            Position = @"RXO.12.3",
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
                            Id = @"RXO.12.4",
                            Type = @"Component",
                            Position = @"RXO.12.4",
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
                            Id = @"RXO.12.5",
                            Type = @"Component",
                            Position = @"RXO.12.5",
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
                            Id = @"RXO.12.6",
                            Type = @"Component",
                            Position = @"RXO.12.6",
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

        _requestedDispenseUnits = new HL7V23Field
        {
            field = message[@"RXO"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedDispenseUnits.field.FieldRepetitions != null && _requestedDispenseUnits.field.FieldRepetitions.Count > 0)
        {
            _requestedDispenseUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_requestedDispenseUnits, fieldData);
        }

        return _requestedDispenseUnits;
    } 
}

internal HL7V23Field _numberofRefills;

public HL7V23Field NumberofRefills
{
    get
    {
        if (_numberofRefills != null)
        {
            return _numberofRefills;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RXO.13",
            Type = @"Field",
            Position = @"RXO.13",
            Name = @"Number of Refills",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"his field defines the number of times the requested dispense amount can be given to the patient, subject to local regulation.  Refers to outpatient only",
            Sample = @"",
            Fields = null
        }

        _numberofRefills = new HL7V23Field
        {
            field = message[@"RXO"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_numberofRefills.field.FieldRepetitions != null && _numberofRefills.field.FieldRepetitions.Count > 0)
        {
            _numberofRefills.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_numberofRefills, fieldData);
        }

        return _numberofRefills;
    } 
}

internal HL7V23Field _orderingProvidersDEANumber;

public HL7V23Field OrderingProvidersDEANumber
{
    get
    {
        if (_orderingProvidersDEANumber != null)
        {
            return _orderingProvidersDEANumber;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RXO.14",
            Type = @"Field",
            Position = @"RXO.14",
            Name = @"Ordering Provider's DEA Number",
            Length = 60,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the providers controlled substance number, if required by site.  It is defined as conditional because it is required when the substance being requested is a controlled substance (e.g., a narcotic).",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.14.1",
                            Type = @"Component",
                            Position = @"RXO.14.1",
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
                            Id = @"RXO.14.2",
                            Type = @"Component",
                            Position = @"RXO.14.2",
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
                            Id = @"RXO.14.3",
                            Type = @"Component",
                            Position = @"RXO.14.3",
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
                            Id = @"RXO.14.4",
                            Type = @"Component",
                            Position = @"RXO.14.4",
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
                            Id = @"RXO.14.5",
                            Type = @"Component",
                            Position = @"RXO.14.5",
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
                            Id = @"RXO.14.6",
                            Type = @"Component",
                            Position = @"RXO.14.6",
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
                            Id = @"RXO.14.7",
                            Type = @"Component",
                            Position = @"RXO.14.7",
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
                            Id = @"RXO.14.8",
                            Type = @"Component",
                            Position = @"RXO.14.8",
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
                            Id = @"RXO.14.9",
                            Type = @"Component",
                            Position = @"RXO.14.9",
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
                            Id = @"RXO.14.9.1",
                            Type = @"SubComponent",
                            Position = @"RXO.14.9.1",
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
                            Id = @"RXO.14.9.2",
                            Type = @"SubComponent",
                            Position = @"RXO.14.9.2",
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
                            Id = @"RXO.14.9.3",
                            Type = @"SubComponent",
                            Position = @"RXO.14.9.3",
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
                            Id = @"RXO.14.10",
                            Type = @"Component",
                            Position = @"RXO.14.10",
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
                            Id = @"RXO.14.11",
                            Type = @"Component",
                            Position = @"RXO.14.11",
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
                            Id = @"RXO.14.12",
                            Type = @"Component",
                            Position = @"RXO.14.12",
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
                            Id = @"RXO.14.13",
                            Type = @"Component",
                            Position = @"RXO.14.13",
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
                            Id = @"RXO.14.14",
                            Type = @"Component",
                            Position = @"RXO.14.14",
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
                            Id = @"RXO.14.14.1",
                            Type = @"SubComponent",
                            Position = @"RXO.14.14.1",
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
                            Id = @"RXO.14.14.2",
                            Type = @"SubComponent",
                            Position = @"RXO.14.14.2",
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
                            Id = @"RXO.14.14.3",
                            Type = @"SubComponent",
                            Position = @"RXO.14.14.3",
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

        _orderingProvidersDEANumber = new HL7V23Field
        {
            field = message[@"RXO"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_orderingProvidersDEANumber.field.FieldRepetitions != null && _orderingProvidersDEANumber.field.FieldRepetitions.Count > 0)
        {
            _orderingProvidersDEANumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_orderingProvidersDEANumber, fieldData);
        }

        return _orderingProvidersDEANumber;
    } 
}

internal HL7V23Field _pharmacistTreatmentSuppliersVerifierID;

public HL7V23Field PharmacistTreatmentSuppliersVerifierID
{
    get
    {
        if (_pharmacistTreatmentSuppliersVerifierID != null)
        {
            return _pharmacistTreatmentSuppliersVerifierID;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RXO.15",
            Type = @"Field",
            Position = @"RXO.15",
            Name = @"Pharmacist/Treatment Supplier's Verifier ID",
            Length = 60,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name",
            TableId = null,
            TableName = null,
            Description = @"This field is the provider ID of the pharmacist/treatment substance supplier verifier.  Use if required by the pharmacy or treatment application or site on orders (or some subgroup of orders), in addition to ORC-11-verified by",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.15.1",
                            Type = @"Component",
                            Position = @"RXO.15.1",
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
                            Id = @"RXO.15.2",
                            Type = @"Component",
                            Position = @"RXO.15.2",
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
                            Id = @"RXO.15.3",
                            Type = @"Component",
                            Position = @"RXO.15.3",
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
                            Id = @"RXO.15.4",
                            Type = @"Component",
                            Position = @"RXO.15.4",
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
                            Id = @"RXO.15.5",
                            Type = @"Component",
                            Position = @"RXO.15.5",
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
                            Id = @"RXO.15.6",
                            Type = @"Component",
                            Position = @"RXO.15.6",
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
                            Id = @"RXO.15.7",
                            Type = @"Component",
                            Position = @"RXO.15.7",
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
                            Id = @"RXO.15.8",
                            Type = @"Component",
                            Position = @"RXO.15.8",
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
                            Id = @"RXO.15.9",
                            Type = @"Component",
                            Position = @"RXO.15.9",
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
                            Id = @"RXO.15.9.1",
                            Type = @"SubComponent",
                            Position = @"RXO.15.9.1",
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
                            Id = @"RXO.15.9.2",
                            Type = @"SubComponent",
                            Position = @"RXO.15.9.2",
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
                            Id = @"RXO.15.9.3",
                            Type = @"SubComponent",
                            Position = @"RXO.15.9.3",
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
                            Id = @"RXO.15.10",
                            Type = @"Component",
                            Position = @"RXO.15.10",
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
                            Id = @"RXO.15.11",
                            Type = @"Component",
                            Position = @"RXO.15.11",
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
                            Id = @"RXO.15.12",
                            Type = @"Component",
                            Position = @"RXO.15.12",
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
                            Id = @"RXO.15.13",
                            Type = @"Component",
                            Position = @"RXO.15.13",
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
                            Id = @"RXO.15.14",
                            Type = @"Component",
                            Position = @"RXO.15.14",
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
                            Id = @"RXO.15.14.1",
                            Type = @"SubComponent",
                            Position = @"RXO.15.14.1",
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
                            Id = @"RXO.15.14.2",
                            Type = @"SubComponent",
                            Position = @"RXO.15.14.2",
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
                            Id = @"RXO.15.14.3",
                            Type = @"SubComponent",
                            Position = @"RXO.15.14.3",
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

        _pharmacistTreatmentSuppliersVerifierID = new HL7V23Field
        {
            field = message[@"RXO"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_pharmacistTreatmentSuppliersVerifierID.field.FieldRepetitions != null && _pharmacistTreatmentSuppliersVerifierID.field.FieldRepetitions.Count > 0)
        {
            _pharmacistTreatmentSuppliersVerifierID.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_pharmacistTreatmentSuppliersVerifierID, fieldData);
        }

        return _pharmacistTreatmentSuppliersVerifierID;
    } 
}

internal HL7V23Field _needsHumanReview;

public HL7V23Field NeedsHumanReview
{
    get
    {
        if (_needsHumanReview != null)
        {
            return _needsHumanReview;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RXO.16",
            Type = @"Field",
            Position = @"RXO.16",
            Name = @"Needs Human Review",
            Length = 1,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ID",
            DataTypeName = @"Coded values for HL7 tables",
            TableId = @"0136",
            TableName = @"Yes/no indicator",
            Description = @"This field uses HL7 table 0136 - Yes/no indicator. ",
            Sample = @"",
            Fields = null
        }

        _needsHumanReview = new HL7V23Field
        {
            field = message[@"RXO"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_needsHumanReview.field.FieldRepetitions != null && _needsHumanReview.field.FieldRepetitions.Count > 0)
        {
            _needsHumanReview.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_needsHumanReview, fieldData);
        }

        return _needsHumanReview;
    } 
}

internal HL7V23Field _requestedGivePer;

public HL7V23Field RequestedGivePer
{
    get
    {
        if (_requestedGivePer != null)
        {
            return _requestedGivePer;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RXO.17",
            Type = @"Field",
            Position = @"RXO.17",
            Name = @"Requested Give Per",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the time unit to use to calculate the rate at which the pharmaceutical is to be administered",
            Sample = @"",
            Fields = null
        }

        _requestedGivePer = new HL7V23Field
        {
            field = message[@"RXO"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedGivePer.field.FieldRepetitions != null && _requestedGivePer.field.FieldRepetitions.Count > 0)
        {
            _requestedGivePer.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_requestedGivePer, fieldData);
        }

        return _requestedGivePer;
    } 
}

internal HL7V23Field _requestedGiveStrength;

public HL7V23Field RequestedGiveStrength
{
    get
    {
        if (_requestedGiveStrength != null)
        {
            return _requestedGiveStrength;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RXO.18",
            Type = @"Field",
            Position = @"RXO.18",
            Name = @"Requested Give Strength",
            Length = 20,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"Use this field when RXO-1-requested give code does not specify the strength.  This is the numeric part of the strength, used in combination with Requested Strength Unit",
            Sample = @"",
            Fields = null
        }

        _requestedGiveStrength = new HL7V23Field
        {
            field = message[@"RXO"][18],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedGiveStrength.field.FieldRepetitions != null && _requestedGiveStrength.field.FieldRepetitions.Count > 0)
        {
            _requestedGiveStrength.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_requestedGiveStrength, fieldData);
        }

        return _requestedGiveStrength;
    } 
}

internal HL7V23Field _requestedGiveStrengthUnits;

public HL7V23Field RequestedGiveStrengthUnits
{
    get
    {
        if (_requestedGiveStrengthUnits != null)
        {
            return _requestedGiveStrengthUnits;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RXO.19",
            Type = @"Field",
            Position = @"RXO.19",
            Name = @"Requested Give Strength Units",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"Use when both RXO-1-requested give code and RXO-10-requested dispense code do not specify the strength.  This is the unit of the strength, used in combination with RXO-18-requested strength",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.19.1",
                            Type = @"Component",
                            Position = @"RXO.19.1",
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
                            Id = @"RXO.19.2",
                            Type = @"Component",
                            Position = @"RXO.19.2",
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
                            Id = @"RXO.19.3",
                            Type = @"Component",
                            Position = @"RXO.19.3",
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
                            Id = @"RXO.19.4",
                            Type = @"Component",
                            Position = @"RXO.19.4",
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
                            Id = @"RXO.19.5",
                            Type = @"Component",
                            Position = @"RXO.19.5",
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
                            Id = @"RXO.19.6",
                            Type = @"Component",
                            Position = @"RXO.19.6",
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

        _requestedGiveStrengthUnits = new HL7V23Field
        {
            field = message[@"RXO"][19],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedGiveStrengthUnits.field.FieldRepetitions != null && _requestedGiveStrengthUnits.field.FieldRepetitions.Count > 0)
        {
            _requestedGiveStrengthUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_requestedGiveStrengthUnits, fieldData);
        }

        return _requestedGiveStrengthUnits;
    } 
}

internal HL7V23Field _indication;

public HL7V23Field Indication
{
    get
    {
        if (_indication != null)
        {
            return _indication;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RXO.20",
            Type = @"Field",
            Position = @"RXO.20",
            Name = @"Indication",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the condition or problem for which the drug/treatment was prescribed. May repeat if multiple indications are relevant",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.20.1",
                            Type = @"Component",
                            Position = @"RXO.20.1",
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
                            Id = @"RXO.20.2",
                            Type = @"Component",
                            Position = @"RXO.20.2",
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
                            Id = @"RXO.20.3",
                            Type = @"Component",
                            Position = @"RXO.20.3",
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
                            Id = @"RXO.20.4",
                            Type = @"Component",
                            Position = @"RXO.20.4",
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
                            Id = @"RXO.20.5",
                            Type = @"Component",
                            Position = @"RXO.20.5",
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
                            Id = @"RXO.20.6",
                            Type = @"Component",
                            Position = @"RXO.20.6",
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

        _indication = new HL7V23Field
        {
            field = message[@"RXO"][20],
            fieldData = fieldData
        };

        // check for repetitions
        if (_indication.field.FieldRepetitions != null && _indication.field.FieldRepetitions.Count > 0)
        {
            _indication.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_indication, fieldData);
        }

        return _indication;
    } 
}

internal HL7V23Field _requestedGiveRateAmount;

public HL7V23Field RequestedGiveRateAmount
{
    get
    {
        if (_requestedGiveRateAmount != null)
        {
            return _requestedGiveRateAmount;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RXO.21",
            Type = @"Field",
            Position = @"RXO.21",
            Name = @"Requested Give Rate Amount",
            Length = 6,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the rate at which to administer treatment",
            Sample = @"",
            Fields = null
        }

        _requestedGiveRateAmount = new HL7V23Field
        {
            field = message[@"RXO"][21],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedGiveRateAmount.field.FieldRepetitions != null && _requestedGiveRateAmount.field.FieldRepetitions.Count > 0)
        {
            _requestedGiveRateAmount.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_requestedGiveRateAmount, fieldData);
        }

        return _requestedGiveRateAmount;
    } 
}

internal HL7V23Field _requestedGiveRateUnits;

public HL7V23Field RequestedGiveRateUnits
{
    get
    {
        if (_requestedGiveRateUnits != null)
        {
            return _requestedGiveRateUnits;
        }

        var fieldData = new HL7V23FieldData
        {
            Id = @"RXO.22",
            Type = @"Field",
            Position = @"RXO.22",
            Name = @"Requested Give Rate Units",
            Length = 60,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field contains the units in which RXO-21-requested give rate amount is denominated",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.22.1",
                            Type = @"Component",
                            Position = @"RXO.22.1",
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
                            Id = @"RXO.22.2",
                            Type = @"Component",
                            Position = @"RXO.22.2",
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
                            Id = @"RXO.22.3",
                            Type = @"Component",
                            Position = @"RXO.22.3",
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
                            Id = @"RXO.22.4",
                            Type = @"Component",
                            Position = @"RXO.22.4",
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
                            Id = @"RXO.22.5",
                            Type = @"Component",
                            Position = @"RXO.22.5",
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
                            Id = @"RXO.22.6",
                            Type = @"Component",
                            Position = @"RXO.22.6",
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

        _requestedGiveRateUnits = new HL7V23Field
        {
            field = message[@"RXO"][22],
            fieldData = fieldData
        };

        // check for repetitions
        if (_requestedGiveRateUnits.field.FieldRepetitions != null && _requestedGiveRateUnits.field.FieldRepetitions.Count > 0)
        {
            _requestedGiveRateUnits.fieldRepetitions = HL7V2FieldGenerator.GenerateV23FieldRepetitions(_requestedGiveRateUnits, fieldData);
        }

        return _requestedGiveRateUnits;
    } 
}
    }
}
