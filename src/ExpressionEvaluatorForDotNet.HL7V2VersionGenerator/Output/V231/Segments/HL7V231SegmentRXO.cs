using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V231SegmentRXO
    {
        public readonly HL7V2Message message;

        public string Id { get { return @"RXO"; } }

        public string SegmentId { get { return @"RXO"; } }
        
        public string LongName { get { return @"Pharmacy/treatment order segment"; } }
        
        public string Description { get { return @"This is the 'master' pharmacy/treatment order segment. It contains order data not specific to components or additives. Unlike the OBR, it does not contain status fields or other data that are results-only."; } }
        
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

        public IList<HL7V2FieldData> Fields 
        { 
            get 
            {
                return new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"RXO.1",
                            Type = @"Field",
                            Position = @"RXO.1",
                            Name = @"Requested Give Code",
                            Length = 100,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the medical substance or product ordered to be given to the patient; it is equivalent to OBR-4-universal service ID in function. The request-to-dispense fields, which define the type and amount of what is to be issued to the patient (see RXO-10 requested dispense code , RXO-11-requested dispense amount, and RXO-12-requested dispense units ), do not necessarily correlate with the instructions of what amount is to be 'given' or administered with each dose, and may or may not be specified with the order. For example, the 'give' part of the order may convey the field-representation of give 15 mg of Librium every 6 hours, while the request to dispense part of the order may convey issue 30 tablets of 10 mg generic equivalent for this outpatient prescription . When the give code does not include the dosage form, use RXO-5-requested dosage form.",
                            Sample = @"",
                            FieldDatas = new []{
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
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
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
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
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.1.4",
                            Type = @"Component",
                            Position = @"RXO.1.4",
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
                            Description = null,
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
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.2",
                            Type = @"Field",
                            Position = @"RXO.2",
                            Name = @"Requested Give Amount - Minimum",
                            Length = 20,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the ordered amount. In a variable dose order, this is the minimum ordered amount. In a nonvarying dose order, this is the exact amount of the order.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            Description = @"In a variable dose order, this is the maximum ordered amount. In a nonvarying dose order, this field is not used.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.4",
                            Type = @"Field",
                            Position = @"RXO.4",
                            Name = @"Requested Give Units",
                            Length = 60,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field indicates the units for the give amount.",
                            Sample = @"",
                            FieldDatas = new []{
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
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
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
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
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.4.4",
                            Type = @"Component",
                            Position = @"RXO.4.4",
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
                            Description = null,
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
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
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
                            Description = @"This field indicates the manner in which the medication is aggregated for dispensing, e.g., tablets, capsules, suppositories. In some cases, this information is implied by the dispense/give code in RXO-1-requested give code or RXO-10-requested dispense code. Use when both RXO-1-requested give code and RXO-10-requested dispense code do not specify the drug/treatment form.",
                            Sample = @"",
                            FieldDatas = new []{
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
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
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
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
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.5.4",
                            Type = @"Component",
                            Position = @"RXO.5.4",
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
                            Description = null,
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
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.6",
                            Type = @"Field",
                            Position = @"RXO.6",
                            Name = @"Provider s Pharmacy/Treatment Instructions",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the ordering provider's instructions to the pharmacy or the non-pharmacy treatment provider (e.g., respiratory therapy). If coded, a user-defined table must be used. If transmitted as a free text field, place a null in the first component and the text in the second, e.g., |^this is a free text treatment instruction|.",
                            Sample = @"",
                            FieldDatas = new []{
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
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
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
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
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.6.4",
                            Type = @"Component",
                            Position = @"RXO.6.4",
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
                            Description = null,
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
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.7",
                            Type = @"Field",
                            Position = @"RXO.7",
                            Name = @"Provider s Administration Instructions",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the ordering provider's instructions to the patient or to the provider administering the drug or treatment. If coded, a user-defined table must be used. If transmitted as free text, place a null in the first component and the text in the second, e.g., |^this is a free text administration instruction|.",
                            Sample = @"",
                            FieldDatas = new []{
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
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
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
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
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.7.4",
                            Type = @"Component",
                            Position = @"RXO.7.4",
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
                            Description = null,
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
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8",
                            Type = @"Field",
                            Position = @"RXO.8",
                            Name = @"Deliver-to Location",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"LA1",
                            DataTypeName = @"Location With Address Information (variant 1)",
                            TableId = null,
                            TableName = null,
                            Description = @"The first components, modeled after the PL data type, contain the inpatient or outpatient location to which the pharmacy provider or treatment supplier is to deliver the drug or treatment device (if applicable). The default (null) value is the current census location for the patient. This component has the same form as PV1-3-assigned patient location. The last component can be used to specify an address. This could be used to fill mail orders to a patient or provider, or to account for home health care.",
                            Sample = @"",
                            FieldDatas = new []{
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
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.4.1",
                            Type = @"SubComponent",
                            Position = @"RXO.8.4.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.4.2",
                            Type = @"SubComponent",
                            Position = @"RXO.8.4.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.8.4.3",
                            Type = @"SubComponent",
                            Position = @"RXO.8.4.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
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
                            FieldDatas = new []{
                        new HL7V2FieldData
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
                            Description = @"The street or mailing address of a person or institution. When referencing an institution, this first component is used to specify the institution name. When used in connection with a person, this component specifies the first line of the address.",
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
                            Description = @"Second line of address. In general, it qualifies address. Examples: Suite 555 or Fourth Floor. When referencing an institution, this component specifies the street address.",
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
                            Description = @"State or province should be represented by the official postal service codes for that country.",
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
                            Description = @"Zip or postal codes should be represented by the official codes for that country. In the US, the zip code takes the form 99999[-9999], while the Canadian postal code takes the form A9A-9A9.",
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
                            Description = @"Defines the country of the address. ISO 3166 provides a list of country codes that may be used.[2] This ISO table has three separate forms of the country code: HL7 specifies that the 3-character (alphabetic) form be used for the country code.",
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
                            Description = @"Type is optional and defined by HL7 table 0190 - Address type .",
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
                            Description = @"Other geographic designation includes county, bioregion, SMSA, etc.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        }
                        },
                        
                        new HL7V2FieldData
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
                            Description = @"Following are the values:",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            Description = @"This field indicates what is to be/was dispensed; it is equivalent to OBR-4-universal service ID in function. It may be present in the order or not, depending on the application. If not present, and values are given for RXO-11-requested dispense amount and RXO-12-requested dispense units , the RXO-1-requested give code is assumed. If the requested dispense code does not include the dosage form, use RXO-5-requested dosage form .",
                            Sample = @"",
                            FieldDatas = new []{
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
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
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
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
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.10.4",
                            Type = @"Component",
                            Position = @"RXO.10.4",
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
                            Description = null,
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
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
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
                            Description = @"This field specifies the amount to be dispensed.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            Description = @"This field identifies the units for the dispense amount. This must be in simple units that reflect the actual quantity of the substance to be dispensed. It does not include compound units.",
                            Sample = @"",
                            FieldDatas = new []{
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
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
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
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
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.12.4",
                            Type = @"Component",
                            Position = @"RXO.12.4",
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
                            Description = null,
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
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.13",
                            Type = @"Field",
                            Position = @"RXO.13",
                            Name = @"Number Of Refills",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"NM",
                            DataTypeName = @"Numeric",
                            TableId = null,
                            TableName = null,
                            Description = @"This field defines the number of times the requested dispense amount can be given to the patient, subject to local regulation. Refers to outpatient only.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.14",
                            Type = @"Field",
                            Position = @"RXO.14",
                            Name = @"Ordering Provider s DEA Number",
                            Length = 60,
                            Usage = @"C",
                            Rpt = @"*",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number And Name For Persons",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the provider's controlled substance number, if required by site. It is defined as conditional because it is required when the substance being requested is a controlled substance (e.g., a narcotic).",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"RXO.14.1",
                            Type = @"Component",
                            Position = @"RXO.14.1",
                            Name = @"Id Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This string refers to the coded ID according to a user-defined table, defined by the 9th component. If the first component is present, either the source table or the assigning authority must be valued.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.14.2",
                            Type = @"Component",
                            Position = @"RXO.14.2",
                            Name = @"Family Name & Last Name Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family + Last Name Prefix",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"RXO.14.2.1",
                            Type = @"SubComponent",
                            Position = @"RXO.14.2.1",
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
                            Id = @"RXO.14.2.2",
                            Type = @"SubComponent",
                            Position = @"RXO.14.2.2",
                            Name = @"Last Name Prefix",
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
                            Description = @"Used to specify a name suffix (e.g., Jr. or III).",
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
                            Description = @"Used to specify a name prefix (e.g., Dr.).",
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
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree",
                            Description = @"Used to specify an educational degree (e.g., MD). Refer to user-defined table 0360 Degree for suggested values.",
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
                            Description = @"User-defined table 0297 - CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.",
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
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. It is a HD data type. Assigning authorities are unique across a given HL7 implementation. User-defined table 0363 Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"RXO.14.9.1",
                            Type = @"SubComponent",
                            Position = @"RXO.14.9.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.14.9.2",
                            Type = @"SubComponent",
                            Position = @"RXO.14.9.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.14.9.3",
                            Type = @"SubComponent",
                            Position = @"RXO.14.9.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.14.10",
                            Type = @"Component",
                            Position = @"RXO.14.10",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.51, XPN - extended person name).",
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
                            Description = @"The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
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
                            Description = @"Refer to HL7 table 0061 - Check digit scheme for valid values.",
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
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the <assigning authority> component. Refer to user-defined table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.14.14",
                            Type = @"Component",
                            Position = @"RXO.14.14",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"RXO.14.14.1",
                            Type = @"SubComponent",
                            Position = @"RXO.14.14.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.14.14.2",
                            Type = @"SubComponent",
                            Position = @"RXO.14.14.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.14.14.3",
                            Type = @"SubComponent",
                            Position = @"RXO.14.14.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.14.15",
                            Type = @"Component",
                            Position = @"RXO.14.15",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.15",
                            Type = @"Field",
                            Position = @"RXO.15",
                            Name = @"Pharmacist/Treatment Supplier s Verifier ID",
                            Length = 60,
                            Usage = @"C",
                            Rpt = @"*",
                            DataType = @"XCN",
                            DataTypeName = @"Extended Composite ID Number And Name For Persons",
                            TableId = null,
                            TableName = null,
                            Description = @"This field is the provider ID of the pharmacist/treatment substance supplier verifier. Use if required by the pharmacy or treatment application or site on orders (or some subgroup of orders), in addition to ORC-11-verified by.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"RXO.15.1",
                            Type = @"Component",
                            Position = @"RXO.15.1",
                            Name = @"Id Number",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"This string refers to the coded ID according to a user-defined table, defined by the 9th component. If the first component is present, either the source table or the assigning authority must be valued.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.15.2",
                            Type = @"Component",
                            Position = @"RXO.15.2",
                            Name = @"Family Name & Last Name Prefix",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"FN",
                            DataTypeName = @"Family + Last Name Prefix",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"RXO.15.2.1",
                            Type = @"SubComponent",
                            Position = @"RXO.15.2.1",
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
                            Id = @"RXO.15.2.2",
                            Type = @"SubComponent",
                            Position = @"RXO.15.2.2",
                            Name = @"Last Name Prefix",
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
                            Description = @"Used to specify a name suffix (e.g., Jr. or III).",
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
                            Description = @"Used to specify a name prefix (e.g., Dr.).",
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
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0360",
                            TableName = @"Degree",
                            Description = @"Used to specify an educational degree (e.g., MD). Refer to user-defined table 0360 Degree for suggested values.",
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
                            Description = @"User-defined table 0297 - CN ID source is used as the HL7 identifier for the user-defined table of values for this component. Used to delineate the first component.",
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
                            Description = @"The assigning authority is a unique identifier of the system (or organization or agency or department) that creates the data. It is a HD data type. Assigning authorities are unique across a given HL7 implementation. User-defined table 0363 Assigning authority is used as the HL7 identifier for the user-defined table of values for the first sub-component of the HD component, <namespace ID>.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"RXO.15.9.1",
                            Type = @"SubComponent",
                            Position = @"RXO.15.9.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.15.9.2",
                            Type = @"SubComponent",
                            Position = @"RXO.15.9.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.15.9.3",
                            Type = @"SubComponent",
                            Position = @"RXO.15.9.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.15.10",
                            Type = @"Component",
                            Position = @"RXO.15.10",
                            Name = @"Name Type Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0200",
                            TableName = @"Name type",
                            Description = @"A code that represents the type of name. Refer to HL7 table 0200 - Name type for valid values (see Section 2.8.51, XPN - extended person name).",
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
                            Description = @"The check digit in this data type is not an add-on produced by the message processor. It is the check digit that is part of the identifying number used in the sending application. If the sending application does not include a self-generated check digit in the identifying number, this component should be valued null.",
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
                            Description = @"Refer to HL7 table 0061 - Check digit scheme for valid values.",
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
                            Description = @"A code corresponding to the type of identifier. In some cases, this code may be used as a qualifier to the <assigning authority> component. Refer to user-defined table 0203 - Identifier type for suggested values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.15.14",
                            Type = @"Component",
                            Position = @"RXO.15.14",
                            Name = @"Assigning Facility",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"HD",
                            DataTypeName = @"Hierarchic Designator",
                            TableId = null,
                            TableName = null,
                            Description = @"The place or location identifier where the identifier was first assigned to the person. This component is not an inherent part of the identifier but rather part of the history of the identifier: as part of this data type, its existence is a convenience for certain intercommunicating systems.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"RXO.15.14.1",
                            Type = @"SubComponent",
                            Position = @"RXO.15.14.1",
                            Name = @"Namespace Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"IS",
                            DataTypeName = @"Coded value for user-defined tables",
                            TableId = @"0300",
                            TableName = @"Namespace ID",
                            Description = @"User-defined table 0300 - Namespace ID is used as the HL7 identifier for the user-defined table of values for this component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.15.14.2",
                            Type = @"SubComponent",
                            Position = @"RXO.15.14.2",
                            Name = @"Universal Id",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The HDs second component, <universal ID (UID), is a string formatted according to the scheme defined by the third component, <universal ID type> (UID type). The UID is intended to be unique over time within the UID type. It is rigorously defined. Each UID must belong to one of the specifically enumerated schemes for constructing UIDs (defined by the UID type). The UID (second component) must follow the syntactic rules of the particular universal identifier scheme (defined by the third component). Note that these syntactic rules are not defined within HL7 but are defined by the rules of the particular universal identifier scheme (defined by the third component).",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.15.14.3",
                            Type = @"SubComponent",
                            Position = @"RXO.15.14.3",
                            Name = @"Universal Id Type",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0301",
                            TableName = @"Universal ID type",
                            Description = @"The third component governs the interpretation of the second component of the HD. If the third component is a known UID refer to HL7 table 0301 - Universal ID type for valid values, then the second component is a universal ID of that type.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.15.15",
                            Type = @"Component",
                            Position = @"RXO.15.15",
                            Name = @"Name Representation Code",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"4000",
                            TableName = @"Name/address representation",
                            Description = @"Different <name/address types> and representations of the same <name/address> should be described by repeating of this field, with different values of the <name/address type> and/or <name/address representation> component.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
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
                            Description = @"This field uses HL7 table 0136 - Yes/no indicator . The values have the following meaning for this field:",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            Description = @"This field identifies the time unit to use to calculate the rate at which the pharmaceutical is to be administered.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            Description = @"Use this field when RXO-1-requested give code does not specify the strength. This is the numeric part of the strength, used in combination with RXO-19-requested give strength units.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            Description = @"Use when both RXO-1-requested give code and RXO-10-requested dispense code do not specify the strength. This is the unit of the strength, used in combination with RXO-18-requested give strength .",
                            Sample = @"",
                            FieldDatas = new []{
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
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
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
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
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.19.4",
                            Type = @"Component",
                            Position = @"RXO.19.4",
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
                            Description = null,
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
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.20",
                            Type = @"Field",
                            Position = @"RXO.20",
                            Name = @"Indication",
                            Length = 200,
                            Usage = @"O",
                            Rpt = @"*",
                            DataType = @"CE",
                            DataTypeName = @"Coded Element",
                            TableId = null,
                            TableName = null,
                            Description = @"This field identifies the condition or problem for which the drug/treatment was prescribed. May repeat if multiple indications are relevant.",
                            Sample = @"",
                            FieldDatas = new []{
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
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
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
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
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.20.4",
                            Type = @"Component",
                            Position = @"RXO.20.4",
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
                            Description = null,
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
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
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
                            Description = @"This field contains the rate at which to administer treatment.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
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
                            Description = @"This field contains the units in which RXO-21-requested give rate amount is denominated.",
                            Sample = @"",
                            FieldDatas = new []{
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
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the <text>. Different coding schemes will have different elements here.",
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
                            Description = @"Name or description of the item in question. E.g., myocardial infarction or X-ray impression. Its data type is string (ST).",
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
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier. ASTM E1238-94, Diagnostic, procedure, observation, drug ID, and health outcomes coding systems are identified in the tables in Section 7.1.4, Coding schemes. Others may be added as needed. When an HL7 table is used for a CE data type, the name of coding system component is defined as HL7nnnn where nnnn is the HL7 table number.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.22.4",
                            Type = @"Component",
                            Position = @"RXO.22.4",
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
                            Description = null,
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
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"RXO.23",
                            Type = @"Field",
                            Position = @"RXO.23",
                            Name = @"Total Daily Dose",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"CQ",
                            DataTypeName = @"Composite Quantity With Units",
                            TableId = null,
                            TableName = null,
                            Description = @"This field contains the total daily dose for this particular pharmaceutical as expressed in terms of actual dispense units.",
                            Sample = @"",
                            FieldDatas = new []{
                        new HL7V2FieldData
                        {
                            Id = @"RXO.23.1",
                            Type = @"Component",
                            Position = @"RXO.23.1",
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
                            Id = @"RXO.23.2",
                            Type = @"Component",
                            Position = @"RXO.23.2",
                            Name = @"Units",
                            Length = 0,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The units in which the quantity is expressed. Field-by-field, default units may be defined within the specifications. When the observation is measured in the default units, the units need not be transmitted. If the measure is recorded in units different from the default, the measurement units must be transmitted as the second component. If the units are ISO+ units, then units should be recorded as lowercase abbreviations as specified in Chapter 7. If the units are ANSI or local, the units and the source table must be recorded as specified in Chapter 7. But in these cases the component separator should be replaced by the subcomponent delimiter",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
                        },
                        };
            }
        }

        public HL7V231SegmentRXO(HL7V2Message message)
        {
            this.message = message;
        }

        
internal HL7V231Field requestedGiveCode;

public HL7V231Field RequestedGiveCode
{
    get
    {
        if (requestedGiveCode != null)
        {
            return requestedGiveCode;
        }

        requestedGiveCode = new HL7V231Field
        {
            field = message[@"RXO"][1],
            Id = @"RXO.1",
            Type = @"Field",
            Position = @"RXO.1",
            Name = @"Requested Give Code",
            Length = 100,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the medical substance or product ordered to be given to the patient; it is equivalent to OBR-4-universal service ID in function. The request-to-dispense fields, which define the type and amount of what is to be issued to the patient (see RXO-10 requested dispense code , RXO-11-requested dispense amount, and RXO-12-requested dispense units ), do not necessarily correlate with the instructions of what amount is to be 'given' or administered with each dose, and may or may not be specified with the order. For example, the 'give' part of the order may convey the field-representation of give 15 mg of Librium every 6 hours, while the request to dispense part of the order may convey issue 30 tablets of 10 mg generic equivalent for this outpatient prescription . When the give code does not include the dosage form, use RXO-5-requested dosage form.",
            Sample = @"",
        };

        // check for repetitions
        if (requestedGiveCode.field.FieldRepetitions != null && requestedGiveCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requestedGiveCode.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < requestedGiveCode.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = requestedGiveCode.field.FieldRepetitions[i],
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
                    for (var j = 0; j < requestedGiveCode.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = requestedGiveCode.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < requestedGiveCode.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = requestedGiveCode.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            requestedGiveCode.fieldRepetitions = fieldRepetitions;
        }

        return requestedGiveCode;
    } 
}

internal HL7V231Field requestedGiveAmountMinimum;

public HL7V231Field RequestedGiveAmountMinimum
{
    get
    {
        if (requestedGiveAmountMinimum != null)
        {
            return requestedGiveAmountMinimum;
        }

        requestedGiveAmountMinimum = new HL7V231Field
        {
            field = message[@"RXO"][2],
            Id = @"RXO.2",
            Type = @"Field",
            Position = @"RXO.2",
            Name = @"Requested Give Amount - Minimum",
            Length = 20,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field is the ordered amount. In a variable dose order, this is the minimum ordered amount. In a nonvarying dose order, this is the exact amount of the order.",
            Sample = @"",
        };

        // check for repetitions
        if (requestedGiveAmountMinimum.field.FieldRepetitions != null && requestedGiveAmountMinimum.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requestedGiveAmountMinimum.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < requestedGiveAmountMinimum.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = requestedGiveAmountMinimum.field.FieldRepetitions[i],
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
                    for (var j = 0; j < requestedGiveAmountMinimum.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = requestedGiveAmountMinimum.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < requestedGiveAmountMinimum.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = requestedGiveAmountMinimum.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            requestedGiveAmountMinimum.fieldRepetitions = fieldRepetitions;
        }

        return requestedGiveAmountMinimum;
    } 
}

internal HL7V231Field requestedGiveAmountMaximum;

public HL7V231Field RequestedGiveAmountMaximum
{
    get
    {
        if (requestedGiveAmountMaximum != null)
        {
            return requestedGiveAmountMaximum;
        }

        requestedGiveAmountMaximum = new HL7V231Field
        {
            field = message[@"RXO"][3],
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
            Description = @"In a variable dose order, this is the maximum ordered amount. In a nonvarying dose order, this field is not used.",
            Sample = @"",
        };

        // check for repetitions
        if (requestedGiveAmountMaximum.field.FieldRepetitions != null && requestedGiveAmountMaximum.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requestedGiveAmountMaximum.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < requestedGiveAmountMaximum.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = requestedGiveAmountMaximum.field.FieldRepetitions[i],
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
                    for (var j = 0; j < requestedGiveAmountMaximum.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = requestedGiveAmountMaximum.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < requestedGiveAmountMaximum.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = requestedGiveAmountMaximum.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            requestedGiveAmountMaximum.fieldRepetitions = fieldRepetitions;
        }

        return requestedGiveAmountMaximum;
    } 
}

internal HL7V231Field requestedGiveUnits;

public HL7V231Field RequestedGiveUnits
{
    get
    {
        if (requestedGiveUnits != null)
        {
            return requestedGiveUnits;
        }

        requestedGiveUnits = new HL7V231Field
        {
            field = message[@"RXO"][4],
            Id = @"RXO.4",
            Type = @"Field",
            Position = @"RXO.4",
            Name = @"Requested Give Units",
            Length = 60,
            Usage = @"C",
            Rpt = @"1",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field indicates the units for the give amount.",
            Sample = @"",
        };

        // check for repetitions
        if (requestedGiveUnits.field.FieldRepetitions != null && requestedGiveUnits.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requestedGiveUnits.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < requestedGiveUnits.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = requestedGiveUnits.field.FieldRepetitions[i],
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
                    for (var j = 0; j < requestedGiveUnits.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = requestedGiveUnits.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < requestedGiveUnits.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = requestedGiveUnits.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            requestedGiveUnits.fieldRepetitions = fieldRepetitions;
        }

        return requestedGiveUnits;
    } 
}

internal HL7V231Field requestedDosageForm;

public HL7V231Field RequestedDosageForm
{
    get
    {
        if (requestedDosageForm != null)
        {
            return requestedDosageForm;
        }

        requestedDosageForm = new HL7V231Field
        {
            field = message[@"RXO"][5],
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
            Description = @"This field indicates the manner in which the medication is aggregated for dispensing, e.g., tablets, capsules, suppositories. In some cases, this information is implied by the dispense/give code in RXO-1-requested give code or RXO-10-requested dispense code. Use when both RXO-1-requested give code and RXO-10-requested dispense code do not specify the drug/treatment form.",
            Sample = @"",
        };

        // check for repetitions
        if (requestedDosageForm.field.FieldRepetitions != null && requestedDosageForm.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requestedDosageForm.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < requestedDosageForm.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = requestedDosageForm.field.FieldRepetitions[i],
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
                    for (var j = 0; j < requestedDosageForm.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = requestedDosageForm.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < requestedDosageForm.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = requestedDosageForm.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            requestedDosageForm.fieldRepetitions = fieldRepetitions;
        }

        return requestedDosageForm;
    } 
}

internal HL7V231Field providersPharmacyTreatmentInstructions;

public HL7V231Field ProvidersPharmacyTreatmentInstructions
{
    get
    {
        if (providersPharmacyTreatmentInstructions != null)
        {
            return providersPharmacyTreatmentInstructions;
        }

        providersPharmacyTreatmentInstructions = new HL7V231Field
        {
            field = message[@"RXO"][6],
            Id = @"RXO.6",
            Type = @"Field",
            Position = @"RXO.6",
            Name = @"Provider s Pharmacy/Treatment Instructions",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the ordering provider's instructions to the pharmacy or the non-pharmacy treatment provider (e.g., respiratory therapy). If coded, a user-defined table must be used. If transmitted as a free text field, place a null in the first component and the text in the second, e.g., |^this is a free text treatment instruction|.",
            Sample = @"",
        };

        // check for repetitions
        if (providersPharmacyTreatmentInstructions.field.FieldRepetitions != null && providersPharmacyTreatmentInstructions.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(providersPharmacyTreatmentInstructions.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < providersPharmacyTreatmentInstructions.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = providersPharmacyTreatmentInstructions.field.FieldRepetitions[i],
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
                    for (var j = 0; j < providersPharmacyTreatmentInstructions.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = providersPharmacyTreatmentInstructions.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < providersPharmacyTreatmentInstructions.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = providersPharmacyTreatmentInstructions.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            providersPharmacyTreatmentInstructions.fieldRepetitions = fieldRepetitions;
        }

        return providersPharmacyTreatmentInstructions;
    } 
}

internal HL7V231Field providersAdministrationInstructions;

public HL7V231Field ProvidersAdministrationInstructions
{
    get
    {
        if (providersAdministrationInstructions != null)
        {
            return providersAdministrationInstructions;
        }

        providersAdministrationInstructions = new HL7V231Field
        {
            field = message[@"RXO"][7],
            Id = @"RXO.7",
            Type = @"Field",
            Position = @"RXO.7",
            Name = @"Provider s Administration Instructions",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the ordering provider's instructions to the patient or to the provider administering the drug or treatment. If coded, a user-defined table must be used. If transmitted as free text, place a null in the first component and the text in the second, e.g., |^this is a free text administration instruction|.",
            Sample = @"",
        };

        // check for repetitions
        if (providersAdministrationInstructions.field.FieldRepetitions != null && providersAdministrationInstructions.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(providersAdministrationInstructions.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < providersAdministrationInstructions.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = providersAdministrationInstructions.field.FieldRepetitions[i],
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
                    for (var j = 0; j < providersAdministrationInstructions.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = providersAdministrationInstructions.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < providersAdministrationInstructions.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = providersAdministrationInstructions.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            providersAdministrationInstructions.fieldRepetitions = fieldRepetitions;
        }

        return providersAdministrationInstructions;
    } 
}

internal HL7V231Field delivertoLocation;

public HL7V231Field DelivertoLocation
{
    get
    {
        if (delivertoLocation != null)
        {
            return delivertoLocation;
        }

        delivertoLocation = new HL7V231Field
        {
            field = message[@"RXO"][8],
            Id = @"RXO.8",
            Type = @"Field",
            Position = @"RXO.8",
            Name = @"Deliver-to Location",
            Length = 200,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"LA1",
            DataTypeName = @"Location With Address Information (variant 1)",
            TableId = null,
            TableName = null,
            Description = @"The first components, modeled after the PL data type, contain the inpatient or outpatient location to which the pharmacy provider or treatment supplier is to deliver the drug or treatment device (if applicable). The default (null) value is the current census location for the patient. This component has the same form as PV1-3-assigned patient location. The last component can be used to specify an address. This could be used to fill mail orders to a patient or provider, or to account for home health care.",
            Sample = @"",
        };

        // check for repetitions
        if (delivertoLocation.field.FieldRepetitions != null && delivertoLocation.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(delivertoLocation.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < delivertoLocation.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = delivertoLocation.field.FieldRepetitions[i],
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
                    for (var j = 0; j < delivertoLocation.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = delivertoLocation.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < delivertoLocation.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = delivertoLocation.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            delivertoLocation.fieldRepetitions = fieldRepetitions;
        }

        return delivertoLocation;
    } 
}

internal HL7V231Field allowSubstitutions;

public HL7V231Field AllowSubstitutions
{
    get
    {
        if (allowSubstitutions != null)
        {
            return allowSubstitutions;
        }

        allowSubstitutions = new HL7V231Field
        {
            field = message[@"RXO"][9],
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
            Description = @"Following are the values:",
            Sample = @"",
        };

        // check for repetitions
        if (allowSubstitutions.field.FieldRepetitions != null && allowSubstitutions.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(allowSubstitutions.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < allowSubstitutions.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = allowSubstitutions.field.FieldRepetitions[i],
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
                    for (var j = 0; j < allowSubstitutions.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = allowSubstitutions.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < allowSubstitutions.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = allowSubstitutions.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            allowSubstitutions.fieldRepetitions = fieldRepetitions;
        }

        return allowSubstitutions;
    } 
}

internal HL7V231Field requestedDispenseCode;

public HL7V231Field RequestedDispenseCode
{
    get
    {
        if (requestedDispenseCode != null)
        {
            return requestedDispenseCode;
        }

        requestedDispenseCode = new HL7V231Field
        {
            field = message[@"RXO"][10],
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
            Description = @"This field indicates what is to be/was dispensed; it is equivalent to OBR-4-universal service ID in function. It may be present in the order or not, depending on the application. If not present, and values are given for RXO-11-requested dispense amount and RXO-12-requested dispense units , the RXO-1-requested give code is assumed. If the requested dispense code does not include the dosage form, use RXO-5-requested dosage form .",
            Sample = @"",
        };

        // check for repetitions
        if (requestedDispenseCode.field.FieldRepetitions != null && requestedDispenseCode.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requestedDispenseCode.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < requestedDispenseCode.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = requestedDispenseCode.field.FieldRepetitions[i],
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
                    for (var j = 0; j < requestedDispenseCode.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = requestedDispenseCode.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < requestedDispenseCode.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = requestedDispenseCode.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            requestedDispenseCode.fieldRepetitions = fieldRepetitions;
        }

        return requestedDispenseCode;
    } 
}

internal HL7V231Field requestedDispenseAmount;

public HL7V231Field RequestedDispenseAmount
{
    get
    {
        if (requestedDispenseAmount != null)
        {
            return requestedDispenseAmount;
        }

        requestedDispenseAmount = new HL7V231Field
        {
            field = message[@"RXO"][11],
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
            Description = @"This field specifies the amount to be dispensed.",
            Sample = @"",
        };

        // check for repetitions
        if (requestedDispenseAmount.field.FieldRepetitions != null && requestedDispenseAmount.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requestedDispenseAmount.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < requestedDispenseAmount.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = requestedDispenseAmount.field.FieldRepetitions[i],
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
                    for (var j = 0; j < requestedDispenseAmount.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = requestedDispenseAmount.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < requestedDispenseAmount.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = requestedDispenseAmount.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            requestedDispenseAmount.fieldRepetitions = fieldRepetitions;
        }

        return requestedDispenseAmount;
    } 
}

internal HL7V231Field requestedDispenseUnits;

public HL7V231Field RequestedDispenseUnits
{
    get
    {
        if (requestedDispenseUnits != null)
        {
            return requestedDispenseUnits;
        }

        requestedDispenseUnits = new HL7V231Field
        {
            field = message[@"RXO"][12],
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
            Description = @"This field identifies the units for the dispense amount. This must be in simple units that reflect the actual quantity of the substance to be dispensed. It does not include compound units.",
            Sample = @"",
        };

        // check for repetitions
        if (requestedDispenseUnits.field.FieldRepetitions != null && requestedDispenseUnits.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requestedDispenseUnits.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < requestedDispenseUnits.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = requestedDispenseUnits.field.FieldRepetitions[i],
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
                    for (var j = 0; j < requestedDispenseUnits.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = requestedDispenseUnits.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < requestedDispenseUnits.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = requestedDispenseUnits.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            requestedDispenseUnits.fieldRepetitions = fieldRepetitions;
        }

        return requestedDispenseUnits;
    } 
}

internal HL7V231Field numberOfRefills;

public HL7V231Field NumberOfRefills
{
    get
    {
        if (numberOfRefills != null)
        {
            return numberOfRefills;
        }

        numberOfRefills = new HL7V231Field
        {
            field = message[@"RXO"][13],
            Id = @"RXO.13",
            Type = @"Field",
            Position = @"RXO.13",
            Name = @"Number Of Refills",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field defines the number of times the requested dispense amount can be given to the patient, subject to local regulation. Refers to outpatient only.",
            Sample = @"",
        };

        // check for repetitions
        if (numberOfRefills.field.FieldRepetitions != null && numberOfRefills.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(numberOfRefills.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < numberOfRefills.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = numberOfRefills.field.FieldRepetitions[i],
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
                    for (var j = 0; j < numberOfRefills.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = numberOfRefills.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < numberOfRefills.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = numberOfRefills.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            numberOfRefills.fieldRepetitions = fieldRepetitions;
        }

        return numberOfRefills;
    } 
}

internal HL7V231Field orderingProvidersDEANumber;

public HL7V231Field OrderingProvidersDEANumber
{
    get
    {
        if (orderingProvidersDEANumber != null)
        {
            return orderingProvidersDEANumber;
        }

        orderingProvidersDEANumber = new HL7V231Field
        {
            field = message[@"RXO"][14],
            Id = @"RXO.14",
            Type = @"Field",
            Position = @"RXO.14",
            Name = @"Ordering Provider s DEA Number",
            Length = 60,
            Usage = @"C",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name For Persons",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the provider's controlled substance number, if required by site. It is defined as conditional because it is required when the substance being requested is a controlled substance (e.g., a narcotic).",
            Sample = @"",
        };

        // check for repetitions
        if (orderingProvidersDEANumber.field.FieldRepetitions != null && orderingProvidersDEANumber.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(orderingProvidersDEANumber.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < orderingProvidersDEANumber.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = orderingProvidersDEANumber.field.FieldRepetitions[i],
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
                    for (var j = 0; j < orderingProvidersDEANumber.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = orderingProvidersDEANumber.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < orderingProvidersDEANumber.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = orderingProvidersDEANumber.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            orderingProvidersDEANumber.fieldRepetitions = fieldRepetitions;
        }

        return orderingProvidersDEANumber;
    } 
}

internal HL7V231Field pharmacistTreatmentSuppliersVerifierID;

public HL7V231Field PharmacistTreatmentSuppliersVerifierID
{
    get
    {
        if (pharmacistTreatmentSuppliersVerifierID != null)
        {
            return pharmacistTreatmentSuppliersVerifierID;
        }

        pharmacistTreatmentSuppliersVerifierID = new HL7V231Field
        {
            field = message[@"RXO"][15],
            Id = @"RXO.15",
            Type = @"Field",
            Position = @"RXO.15",
            Name = @"Pharmacist/Treatment Supplier s Verifier ID",
            Length = 60,
            Usage = @"C",
            Rpt = @"*",
            DataType = @"XCN",
            DataTypeName = @"Extended Composite ID Number And Name For Persons",
            TableId = null,
            TableName = null,
            Description = @"This field is the provider ID of the pharmacist/treatment substance supplier verifier. Use if required by the pharmacy or treatment application or site on orders (or some subgroup of orders), in addition to ORC-11-verified by.",
            Sample = @"",
        };

        // check for repetitions
        if (pharmacistTreatmentSuppliersVerifierID.field.FieldRepetitions != null && pharmacistTreatmentSuppliersVerifierID.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(pharmacistTreatmentSuppliersVerifierID.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < pharmacistTreatmentSuppliersVerifierID.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = pharmacistTreatmentSuppliersVerifierID.field.FieldRepetitions[i],
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
                    for (var j = 0; j < pharmacistTreatmentSuppliersVerifierID.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = pharmacistTreatmentSuppliersVerifierID.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < pharmacistTreatmentSuppliersVerifierID.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = pharmacistTreatmentSuppliersVerifierID.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            pharmacistTreatmentSuppliersVerifierID.fieldRepetitions = fieldRepetitions;
        }

        return pharmacistTreatmentSuppliersVerifierID;
    } 
}

internal HL7V231Field needsHumanReview;

public HL7V231Field NeedsHumanReview
{
    get
    {
        if (needsHumanReview != null)
        {
            return needsHumanReview;
        }

        needsHumanReview = new HL7V231Field
        {
            field = message[@"RXO"][16],
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
            Description = @"This field uses HL7 table 0136 - Yes/no indicator . The values have the following meaning for this field:",
            Sample = @"",
        };

        // check for repetitions
        if (needsHumanReview.field.FieldRepetitions != null && needsHumanReview.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(needsHumanReview.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < needsHumanReview.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = needsHumanReview.field.FieldRepetitions[i],
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
                    for (var j = 0; j < needsHumanReview.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = needsHumanReview.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < needsHumanReview.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = needsHumanReview.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            needsHumanReview.fieldRepetitions = fieldRepetitions;
        }

        return needsHumanReview;
    } 
}

internal HL7V231Field requestedGivePer;

public HL7V231Field RequestedGivePer
{
    get
    {
        if (requestedGivePer != null)
        {
            return requestedGivePer;
        }

        requestedGivePer = new HL7V231Field
        {
            field = message[@"RXO"][17],
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
            Description = @"This field identifies the time unit to use to calculate the rate at which the pharmaceutical is to be administered.",
            Sample = @"",
        };

        // check for repetitions
        if (requestedGivePer.field.FieldRepetitions != null && requestedGivePer.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requestedGivePer.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < requestedGivePer.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = requestedGivePer.field.FieldRepetitions[i],
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
                    for (var j = 0; j < requestedGivePer.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = requestedGivePer.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < requestedGivePer.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = requestedGivePer.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            requestedGivePer.fieldRepetitions = fieldRepetitions;
        }

        return requestedGivePer;
    } 
}

internal HL7V231Field requestedGiveStrength;

public HL7V231Field RequestedGiveStrength
{
    get
    {
        if (requestedGiveStrength != null)
        {
            return requestedGiveStrength;
        }

        requestedGiveStrength = new HL7V231Field
        {
            field = message[@"RXO"][18],
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
            Description = @"Use this field when RXO-1-requested give code does not specify the strength. This is the numeric part of the strength, used in combination with RXO-19-requested give strength units.",
            Sample = @"",
        };

        // check for repetitions
        if (requestedGiveStrength.field.FieldRepetitions != null && requestedGiveStrength.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requestedGiveStrength.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < requestedGiveStrength.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = requestedGiveStrength.field.FieldRepetitions[i],
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
                    for (var j = 0; j < requestedGiveStrength.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = requestedGiveStrength.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < requestedGiveStrength.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = requestedGiveStrength.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            requestedGiveStrength.fieldRepetitions = fieldRepetitions;
        }

        return requestedGiveStrength;
    } 
}

internal HL7V231Field requestedGiveStrengthUnits;

public HL7V231Field RequestedGiveStrengthUnits
{
    get
    {
        if (requestedGiveStrengthUnits != null)
        {
            return requestedGiveStrengthUnits;
        }

        requestedGiveStrengthUnits = new HL7V231Field
        {
            field = message[@"RXO"][19],
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
            Description = @"Use when both RXO-1-requested give code and RXO-10-requested dispense code do not specify the strength. This is the unit of the strength, used in combination with RXO-18-requested give strength .",
            Sample = @"",
        };

        // check for repetitions
        if (requestedGiveStrengthUnits.field.FieldRepetitions != null && requestedGiveStrengthUnits.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requestedGiveStrengthUnits.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < requestedGiveStrengthUnits.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = requestedGiveStrengthUnits.field.FieldRepetitions[i],
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
                    for (var j = 0; j < requestedGiveStrengthUnits.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = requestedGiveStrengthUnits.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < requestedGiveStrengthUnits.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = requestedGiveStrengthUnits.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            requestedGiveStrengthUnits.fieldRepetitions = fieldRepetitions;
        }

        return requestedGiveStrengthUnits;
    } 
}

internal HL7V231Field indication;

public HL7V231Field Indication
{
    get
    {
        if (indication != null)
        {
            return indication;
        }

        indication = new HL7V231Field
        {
            field = message[@"RXO"][20],
            Id = @"RXO.20",
            Type = @"Field",
            Position = @"RXO.20",
            Name = @"Indication",
            Length = 200,
            Usage = @"O",
            Rpt = @"*",
            DataType = @"CE",
            DataTypeName = @"Coded Element",
            TableId = null,
            TableName = null,
            Description = @"This field identifies the condition or problem for which the drug/treatment was prescribed. May repeat if multiple indications are relevant.",
            Sample = @"",
        };

        // check for repetitions
        if (indication.field.FieldRepetitions != null && indication.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(indication.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < indication.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = indication.field.FieldRepetitions[i],
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
                    for (var j = 0; j < indication.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = indication.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < indication.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = indication.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            indication.fieldRepetitions = fieldRepetitions;
        }

        return indication;
    } 
}

internal HL7V231Field requestedGiveRateAmount;

public HL7V231Field RequestedGiveRateAmount
{
    get
    {
        if (requestedGiveRateAmount != null)
        {
            return requestedGiveRateAmount;
        }

        requestedGiveRateAmount = new HL7V231Field
        {
            field = message[@"RXO"][21],
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
            Description = @"This field contains the rate at which to administer treatment.",
            Sample = @"",
        };

        // check for repetitions
        if (requestedGiveRateAmount.field.FieldRepetitions != null && requestedGiveRateAmount.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requestedGiveRateAmount.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < requestedGiveRateAmount.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = requestedGiveRateAmount.field.FieldRepetitions[i],
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
                    for (var j = 0; j < requestedGiveRateAmount.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = requestedGiveRateAmount.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < requestedGiveRateAmount.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = requestedGiveRateAmount.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            requestedGiveRateAmount.fieldRepetitions = fieldRepetitions;
        }

        return requestedGiveRateAmount;
    } 
}

internal HL7V231Field requestedGiveRateUnits;

public HL7V231Field RequestedGiveRateUnits
{
    get
    {
        if (requestedGiveRateUnits != null)
        {
            return requestedGiveRateUnits;
        }

        requestedGiveRateUnits = new HL7V231Field
        {
            field = message[@"RXO"][22],
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
            Description = @"This field contains the units in which RXO-21-requested give rate amount is denominated.",
            Sample = @"",
        };

        // check for repetitions
        if (requestedGiveRateUnits.field.FieldRepetitions != null && requestedGiveRateUnits.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(requestedGiveRateUnits.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < requestedGiveRateUnits.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = requestedGiveRateUnits.field.FieldRepetitions[i],
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
                    for (var j = 0; j < requestedGiveRateUnits.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = requestedGiveRateUnits.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < requestedGiveRateUnits.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = requestedGiveRateUnits.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            requestedGiveRateUnits.fieldRepetitions = fieldRepetitions;
        }

        return requestedGiveRateUnits;
    } 
}

internal HL7V231Field totalDailyDose;

public HL7V231Field TotalDailyDose
{
    get
    {
        if (totalDailyDose != null)
        {
            return totalDailyDose;
        }

        totalDailyDose = new HL7V231Field
        {
            field = message[@"RXO"][23],
            Id = @"RXO.23",
            Type = @"Field",
            Position = @"RXO.23",
            Name = @"Total Daily Dose",
            Length = 10,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"CQ",
            DataTypeName = @"Composite Quantity With Units",
            TableId = null,
            TableName = null,
            Description = @"This field contains the total daily dose for this particular pharmaceutical as expressed in terms of actual dispense units.",
            Sample = @"",
        };

        // check for repetitions
        if (totalDailyDose.field.FieldRepetitions != null && totalDailyDose.field.FieldRepetitions.Count > 0)
        {
            // get this fields data
            var fieldData = Fields.First(fd => fd.Id.Equals(totalDailyDose.Id));
            var fieldRepetitions = new List<HL7V231FieldRepetition>();

            for (var i = 0; i < totalDailyDose.field.FieldRepetitions.Count; i++)
            {
                var fieldRepetition = new HL7V231FieldRepetition
                {
                    fieldRepetition = totalDailyDose.field.FieldRepetitions[i],
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
                    for (var j = 0; j < totalDailyDose.field.Components(i + 1).Count; j++)
                    {
                        var componentFieldData = fieldData.FieldDatas[j];
                        var component = new HL7V231Component
                        {
                            component = totalDailyDose.field.FieldRepetitions[i].Components[j],
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

                            for (var k = 0; k < totalDailyDose.field.Components(i + 1)[j].SubComponents.Count; k++)
                            {
                                var subComponentFieldData = componentFieldData.FieldDatas[k];
                                var subComponent = new HL7V231SubComponent
                                {
                                    subComponent = totalDailyDose.field.FieldRepetitions[i].Components[j].SubComponents[k],
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
                     
            totalDailyDose.fieldRepetitions = fieldRepetitions;
        }

        return totalDailyDose;
    } 
}

    }
}
