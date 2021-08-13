using System.Linq;
using System.Collections.Generic;

namespace ExpressionEvaluatorForDotNet
{
    public class HL7V251SegmentUB2
    {
        public HL7V2Message message { get; init; }

        public string Id { get { return @"UB2"; } }

        public string SegmentId { get { return @"UB2"; } }
        
        public string LongName { get { return @"UB92 Data"; } }
        
        public string Description { get { return @"The UB2 segment contains data necessary to complete UB92 bills specific to the United States; other realms may choose to implement using regional code sets. Only UB82 and UB92 fields that do not exist in other HL7 defined segments appear in this segment.  Just as with the UB82 billing, Patient Name and Date of Birth are required; they are included in the PID segment and therefore do not appear here. When the field locators are different on the UB92, as compared to the UB82, the element is listed with its new location in parentheses ( ). The UB codes listed as examples are not an exhaustive or current list; refer to a UB specification for additional information.

The Uniform Billing segments are specific to the US and may not be implemented in non-US systems."; } }
        
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

        public HL7V251SegmentUB2(HL7V2Message message)
        {
            this.message = message;
        }

        internal HL7V251Field _setIDUB2;

public HL7V251Field SetIDUB2
{
    get
    {
        if (_setIDUB2 != null)
        {
            return _setIDUB2;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB2.1",
            Type = @"Field",
            Position = @"UB2.1",
            Name = @"Set ID - UB2",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"SI",
            DataTypeName = @"Sequence ID",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number that identifies this transaction. For the first occurrence of the segment the sequence number shall be 1, for the second occurrence it shall be 2, etc.",
            Sample = @"",
            Fields = null
        }

        _setIDUB2 = new HL7V251Field
        {
            field = message[@"UB2"][1],
            fieldData = fieldData
        };

        // check for repetitions
        if (_setIDUB2.field.FieldRepetitions != null && _setIDUB2.field.FieldRepetitions.Count > 0)
        {
            _setIDUB2.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_setIDUB2, fieldData);
        }

        return _setIDUB2;
    } 
}

internal HL7V251Field _coInsuranceDays9;

public HL7V251Field CoInsuranceDays9
{
    get
    {
        if (_coInsuranceDays9 != null)
        {
            return _coInsuranceDays9;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB2.2",
            Type = @"Field",
            Position = @"UB2.2",
            Name = @"Co-Insurance Days (9)",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number of inpatient days exceeding defined benefit coverage. In the US, this corresponds to UB92 form locator 9. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _coInsuranceDays9 = new HL7V251Field
        {
            field = message[@"UB2"][2],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coInsuranceDays9.field.FieldRepetitions != null && _coInsuranceDays9.field.FieldRepetitions.Count > 0)
        {
            _coInsuranceDays9.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_coInsuranceDays9, fieldData);
        }

        return _coInsuranceDays9;
    } 
}

internal HL7V251Field _conditionCode2430;

public HL7V251Field ConditionCode2430
{
    get
    {
        if (_conditionCode2430 != null)
        {
            return _conditionCode2430;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB2.3",
            Type = @"Field",
            Position = @"UB2.3",
            Name = @"Condition Code (24-30)",
            Length = 2,
            Usage = @"O",
            Rpt = @"7",
            DataType = @"IS",
            DataTypeName = @"Coded value for user-defined tables",
            TableId = @"0043",
            TableName = @"Condition Code",
            Description = @"This field contains a code reporting conditions that may affect payer processing; for example, the condition is related to employment (Patient covered by insurance not reflected here, treatment of non-terminal condition for hospice patient). The code in this field can repeat up to seven times to correspond to UB92 form locators 24-30. Refer to User-defined Table 0043 - Condition Code for suggested values. Refer to a UB specification for additional information. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _conditionCode2430 = new HL7V251Field
        {
            field = message[@"UB2"][3],
            fieldData = fieldData
        };

        // check for repetitions
        if (_conditionCode2430.field.FieldRepetitions != null && _conditionCode2430.field.FieldRepetitions.Count > 0)
        {
            _conditionCode2430.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_conditionCode2430, fieldData);
        }

        return _conditionCode2430;
    } 
}

internal HL7V251Field _coveredDays7;

public HL7V251Field CoveredDays7
{
    get
    {
        if (_coveredDays7 != null)
        {
            return _coveredDays7;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB2.4",
            Type = @"Field",
            Position = @"UB2.4",
            Name = @"Covered Days (7)",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains UB92 field 7. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _coveredDays7 = new HL7V251Field
        {
            field = message[@"UB2"][4],
            fieldData = fieldData
        };

        // check for repetitions
        if (_coveredDays7.field.FieldRepetitions != null && _coveredDays7.field.FieldRepetitions.Count > 0)
        {
            _coveredDays7.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_coveredDays7, fieldData);
        }

        return _coveredDays7;
    } 
}

internal HL7V251Field _nonCoveredDays8;

public HL7V251Field NonCoveredDays8
{
    get
    {
        if (_nonCoveredDays8 != null)
        {
            return _nonCoveredDays8;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB2.5",
            Type = @"Field",
            Position = @"UB2.5",
            Name = @"Non-Covered Days (8)",
            Length = 4,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains UB92 field 8. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _nonCoveredDays8 = new HL7V251Field
        {
            field = message[@"UB2"][5],
            fieldData = fieldData
        };

        // check for repetitions
        if (_nonCoveredDays8.field.FieldRepetitions != null && _nonCoveredDays8.field.FieldRepetitions.Count > 0)
        {
            _nonCoveredDays8.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_nonCoveredDays8, fieldData);
        }

        return _nonCoveredDays8;
    } 
}

internal HL7V251Field _valueAmountandCode3941;

public HL7V251Field ValueAmountandCode3941
{
    get
    {
        if (_valueAmountandCode3941 != null)
        {
            return _valueAmountandCode3941;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB2.6",
            Type = @"Field",
            Position = @"UB2.6",
            Name = @"Value Amount and Code (39-41)",
            Length = 41,
            Usage = @"O",
            Rpt = @"12",
            DataType = @"UVC",
            DataTypeName = @"UB Value Code and Amount",
            TableId = null,
            TableName = null,
            Description = @"This field contains a monetary amount and an associated billing code. The pair in this field can repeat up to twelve times to represent/contain UB92 form locators 39a, 39b, 39c, 39d, 40a, 40b, 40c, 40d, 41a, 41b, 41c, and 41d. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"UB2.6.1",
                            Type = @"Component",
                            Position = @"UB2.6.1",
                            Name = @"Value Code",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded with No Exceptions",
                            TableId = @"0153",
                            TableName = @"Value code",
                            Description = @"Specifies the National Uniform Billing Committee (NUBC) code itself.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"UB2.6.1.1",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.6.1.2",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. Its data type is string (ST). This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.6.1.3",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.6.1.4",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to Identifier in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.6.1.5",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage notes in section introduction for further description.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.6.1.6",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 in section 2.17.5 for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.6.1.7",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.

Usage Note: If the coding system is any system other than an ""HL7 coding system,"" version ID must be valued with an actual version ID. If the coding system is ""HL7 coding system,"" version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.6.1.8",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component -6. It belongs conceptually to the group of Alternate components (see note 2.A.6.6) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.6.1.9",
                            Type = @"SubComponent",
                            Position = @"UB2.6.1.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.6.2",
                            Type = @"Component",
                            Position = @"UB2.6.2",
                            Name = @"Value Amount",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"MO",
                            DataTypeName = @"Money",
                            TableId = null,
                            TableName = null,
                            Description = @"Specifies the numeric amount when needed to pair with the value.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"UB2.6.2.1",
                            Type = @"SubComponent",
                            Position = @"UB2.6.2.1",
                            Name = @"Quantity",
                            Length = 16,
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
                            Id = @"UB2.6.2.2",
                            Type = @"SubComponent",
                            Position = @"UB2.6.2.2",
                            Name = @"Denomination",
                            Length = 3,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"ISO4217",
                            TableName = @"Currency Codes",
                            Description = @"The second component is the denomination in which the quantity is expressed. The values for the denomination component are those specified in ISO-4217. If the denomination is not specified, MSH-17-country code is used to determine the default.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        }
        }

        _valueAmountandCode3941 = new HL7V251Field
        {
            field = message[@"UB2"][6],
            fieldData = fieldData
        };

        // check for repetitions
        if (_valueAmountandCode3941.field.FieldRepetitions != null && _valueAmountandCode3941.field.FieldRepetitions.Count > 0)
        {
            _valueAmountandCode3941.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_valueAmountandCode3941, fieldData);
        }

        return _valueAmountandCode3941;
    } 
}

internal HL7V251Field _occurrenceCodeandDate3235;

public HL7V251Field OccurrenceCodeandDate3235
{
    get
    {
        if (_occurrenceCodeandDate3235 != null)
        {
            return _occurrenceCodeandDate3235;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB2.7",
            Type = @"Field",
            Position = @"UB2.7",
            Name = @"Occurrence Code and Date (32-35)",
            Length = 259,
            Usage = @"O",
            Rpt = @"8",
            DataType = @"OCD",
            DataTypeName = @"Occurrence Code and Date",
            TableId = null,
            TableName = null,
            Description = @"The set of values in this field can repeat up to eight times. UB92 fields 32a, 32b, 33a, 33b, 34a, 34b, 35a, and 35b. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"UB2.7.1",
                            Type = @"Component",
                            Position = @"UB2.7.1",
                            Name = @"Occurrence Code",
                            Length = 705,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded with No Exceptions",
                            TableId = @"0350",
                            TableName = @"Occurrence code",
                            Description = @"The NUBC code for the event or occurrence relating to a bill that may affect payer processing.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"UB2.7.1.1",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.7.1.2",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. Its data type is string (ST). This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.7.1.3",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.7.1.4",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to Identifier in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.7.1.5",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage notes in section introduction for further description.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.7.1.6",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 in section 2.17.5 for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.7.1.7",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.

Usage Note: If the coding system is any system other than an ""HL7 coding system,"" version ID must be valued with an actual version ID. If the coding system is ""HL7 coding system,"" version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.7.1.8",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component -6. It belongs conceptually to the group of Alternate components (see note 2.A.6.6) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.7.1.9",
                            Type = @"SubComponent",
                            Position = @"UB2.7.1.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.7.2",
                            Type = @"Component",
                            Position = @"UB2.7.2",
                            Name = @"Occurrence Date",
                            Length = 8,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"The date the event, relating to a bill that may affect payer processing, occurred.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _occurrenceCodeandDate3235 = new HL7V251Field
        {
            field = message[@"UB2"][7],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrenceCodeandDate3235.field.FieldRepetitions != null && _occurrenceCodeandDate3235.field.FieldRepetitions.Count > 0)
        {
            _occurrenceCodeandDate3235.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_occurrenceCodeandDate3235, fieldData);
        }

        return _occurrenceCodeandDate3235;
    } 
}

internal HL7V251Field _occurrenceSpanCodeDates36;

public HL7V251Field OccurrenceSpanCodeDates36
{
    get
    {
        if (_occurrenceSpanCodeDates36 != null)
        {
            return _occurrenceSpanCodeDates36;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB2.8",
            Type = @"Field",
            Position = @"UB2.8",
            Name = @"Occurrence Span Code/Dates (36)",
            Length = 268,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"OSP",
            DataTypeName = @"Occurrence Span Code and Date",
            TableId = null,
            TableName = null,
            Description = null,
            Sample = @"",
            Fields = new[]
                        {
                            new HL7V2FieldData
                        {
                            Id = @"UB2.8.1",
                            Type = @"Component",
                            Position = @"UB2.8.1",
                            Name = @"Occurrence Span Code",
                            Length = 705,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"CNE",
                            DataTypeName = @"Coded with No Exceptions",
                            TableId = @"0351",
                            TableName = @"Occurrence span",
                            Description = @"The date an event started that relates to the payment of a claim.",
                            Sample = @"",
                            FieldDatas = new []{new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.1",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.1",
                            Name = @"Identifier",
                            Length = 20,
                            Usage = @"R",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Sequence of characters (the code) that uniquely identifies the item being referenced by the CNE.2. Different coding schemes will have different elements here.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.2",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.2",
                            Name = @"Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the identifier, e.g., myocardial infarction or X-ray impression. Its data type is string (ST). This is the corresponding text assigned by the coding system to the identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.3",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.3",
                            Name = @"Name Of Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Each coding system is assigned a unique identifier. This component will serve to identify the coding scheme being used in the identifier component. The combination of the identifier and name of coding system components will be a unique code for a data item. Each system has a unique identifier.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.4",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.4",
                            Name = @"Alternate Identifier",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"Analogous to Identifier in component 1.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.5",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.5",
                            Name = @"Alternate Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The descriptive or textual name of the alternate identifier. Analogous to ""Text"" in component 2. See usage notes in section introduction for further description.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.6",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.6",
                            Name = @"Name Of Alternate Coding System",
                            Length = 20,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ID",
                            DataTypeName = @"Coded values for HL7 tables",
                            TableId = @"0396",
                            TableName = @"Coding system",
                            Description = @"Identifies the coding scheme being used in the alternate identifier component. Analogous to Name of Coding System in component 3. Refer to HL7 Table 0396 in section 2.17.5 for valid values.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.7",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.7",
                            Name = @"Coding System Version Id",
                            Length = 10,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component 3. It belongs conceptually to components 1-3 and appears here only for reasons of backward compatibility.

Usage Note: If the coding system is any system other than an ""HL7 coding system,"" version ID must be valued with an actual version ID. If the coding system is ""HL7 coding system,"" version ID may have an actual value or it may be absent. If version ID is absent, it will be interpreted to have the same value as the HL7 version number in the message header. Text description of code is optional but its use should be encouraged since it makes messages easier to review for accuracy, especially during interface testing and debugging. ",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.8",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.8",
                            Name = @"Alternate Coding System Version Id",
                            Length = 10,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"the version ID for the coding system identified by component -6. It belongs conceptually to the group of Alternate components (see note 2.A.6.6) and appears here only for reasons of backward compatibility.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.1.9",
                            Type = @"SubComponent",
                            Position = @"UB2.8.1.9",
                            Name = @"Original Text",
                            Length = 199,
                            Usage = @"O",
                            Rpt = @"1",
                            DataType = @"ST",
                            DataTypeName = @"String Data",
                            TableId = null,
                            TableName = null,
                            Description = @"The original text that was available to an automated process or a human before a specific code was assigned.",
                            Sample = @"",
                            FieldDatas = null
                        },}
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.2",
                            Type = @"Component",
                            Position = @"UB2.8.2",
                            Name = @"Occurrence Span Start Date",
                            Length = 8,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = @"The date an event ended that relates to the payment of a claim.",
                            Sample = @"",
                            FieldDatas = null
                        },
                        
                        new HL7V2FieldData
                        {
                            Id = @"UB2.8.3",
                            Type = @"Component",
                            Position = @"UB2.8.3",
                            Name = @"Occurrence Span Stop Date",
                            Length = 8,
                            Usage = @"C",
                            Rpt = @"1",
                            DataType = @"DT",
                            DataTypeName = @"Date",
                            TableId = null,
                            TableName = null,
                            Description = null,
                            Sample = @"",
                            FieldDatas = null
                        },
                        }
        }

        _occurrenceSpanCodeDates36 = new HL7V251Field
        {
            field = message[@"UB2"][8],
            fieldData = fieldData
        };

        // check for repetitions
        if (_occurrenceSpanCodeDates36.field.FieldRepetitions != null && _occurrenceSpanCodeDates36.field.FieldRepetitions.Count > 0)
        {
            _occurrenceSpanCodeDates36.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_occurrenceSpanCodeDates36, fieldData);
        }

        return _occurrenceSpanCodeDates36;
    } 
}

internal HL7V251Field _uB92Locator2State;

public HL7V251Field UB92Locator2State
{
    get
    {
        if (_uB92Locator2State != null)
        {
            return _uB92Locator2State;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB2.9",
            Type = @"Field",
            Position = @"UB2.9",
            Name = @"UB92 Locator 2 (State)",
            Length = 29,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains an occurrence span code and an associated date. This field can repeat up to two times to represent/contain UB92 form locators 36a and 36b. This field is defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _uB92Locator2State = new HL7V251Field
        {
            field = message[@"UB2"][9],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator2State.field.FieldRepetitions != null && _uB92Locator2State.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator2State.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_uB92Locator2State, fieldData);
        }

        return _uB92Locator2State;
    } 
}

internal HL7V251Field _uB92Locator11State;

public HL7V251Field UB92Locator11State
{
    get
    {
        if (_uB92Locator11State != null)
        {
            return _uB92Locator11State;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB2.10",
            Type = @"Field",
            Position = @"UB2.10",
            Name = @"UB92 Locator 11 (State)",
            Length = 12,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"The value in this field may repeat up to two times.",
            Sample = @"",
            Fields = null
        }

        _uB92Locator11State = new HL7V251Field
        {
            field = message[@"UB2"][10],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator11State.field.FieldRepetitions != null && _uB92Locator11State.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator11State.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_uB92Locator11State, fieldData);
        }

        return _uB92Locator11State;
    } 
}

internal HL7V251Field _uB92Locator31National;

public HL7V251Field UB92Locator31National
{
    get
    {
        if (_uB92Locator31National != null)
        {
            return _uB92Locator31National;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB2.11",
            Type = @"Field",
            Position = @"UB2.11",
            Name = @"UB92 Locator 31 (National)",
            Length = 5,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Defined by CMS or other regulatory agencies.",
            Sample = @"",
            Fields = null
        }

        _uB92Locator31National = new HL7V251Field
        {
            field = message[@"UB2"][11],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator31National.field.FieldRepetitions != null && _uB92Locator31National.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator31National.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_uB92Locator31National, fieldData);
        }

        return _uB92Locator31National;
    } 
}

internal HL7V251Field _documentControlNumber;

public HL7V251Field DocumentControlNumber
{
    get
    {
        if (_documentControlNumber != null)
        {
            return _documentControlNumber;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB2.12",
            Type = @"Field",
            Position = @"UB2.12",
            Name = @"Document Control Number",
            Length = 23,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field contains the number assigned by payor that is used for rebilling/adjustment purposes. It may repeat up to three times. Refer UB92 field 37",
            Sample = @"",
            Fields = null
        }

        _documentControlNumber = new HL7V251Field
        {
            field = message[@"UB2"][12],
            fieldData = fieldData
        };

        // check for repetitions
        if (_documentControlNumber.field.FieldRepetitions != null && _documentControlNumber.field.FieldRepetitions.Count > 0)
        {
            _documentControlNumber.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_documentControlNumber, fieldData);
        }

        return _documentControlNumber;
    } 
}

internal HL7V251Field _uB92Locator49National;

public HL7V251Field UB92Locator49National
{
    get
    {
        if (_uB92Locator49National != null)
        {
            return _uB92Locator49National;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB2.13",
            Type = @"Field",
            Position = @"UB2.13",
            Name = @"UB92 Locator 49 (National)",
            Length = 4,
            Usage = @"O",
            Rpt = @"23",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field is defined by CMS or other regulatory agencies. This field may repeat up to twenty-three times.",
            Sample = @"",
            Fields = null
        }

        _uB92Locator49National = new HL7V251Field
        {
            field = message[@"UB2"][13],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator49National.field.FieldRepetitions != null && _uB92Locator49National.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator49National.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_uB92Locator49National, fieldData);
        }

        return _uB92Locator49National;
    } 
}

internal HL7V251Field _uB92Locator56State;

public HL7V251Field UB92Locator56State
{
    get
    {
        if (_uB92Locator56State != null)
        {
            return _uB92Locator56State;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB2.14",
            Type = @"Field",
            Position = @"UB2.14",
            Name = @"UB92 Locator 56 (State)",
            Length = 14,
            Usage = @"O",
            Rpt = @"5",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field may repeat up to five times.",
            Sample = @"",
            Fields = null
        }

        _uB92Locator56State = new HL7V251Field
        {
            field = message[@"UB2"][14],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator56State.field.FieldRepetitions != null && _uB92Locator56State.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator56State.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_uB92Locator56State, fieldData);
        }

        return _uB92Locator56State;
    } 
}

internal HL7V251Field _uB92Locator57National;

public HL7V251Field UB92Locator57National
{
    get
    {
        if (_uB92Locator57National != null)
        {
            return _uB92Locator57National;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB2.15",
            Type = @"Field",
            Position = @"UB2.15",
            Name = @"UB92 Locator 57 (National)",
            Length = 27,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"Defined by UB-92 CMS specification.",
            Sample = @"",
            Fields = null
        }

        _uB92Locator57National = new HL7V251Field
        {
            field = message[@"UB2"][15],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator57National.field.FieldRepetitions != null && _uB92Locator57National.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator57National.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_uB92Locator57National, fieldData);
        }

        return _uB92Locator57National;
    } 
}

internal HL7V251Field _uB92Locator78State;

public HL7V251Field UB92Locator78State
{
    get
    {
        if (_uB92Locator78State != null)
        {
            return _uB92Locator78State;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB2.16",
            Type = @"Field",
            Position = @"UB2.16",
            Name = @"UB92 Locator 78 (State)",
            Length = 2,
            Usage = @"O",
            Rpt = @"2",
            DataType = @"ST",
            DataTypeName = @"String Data",
            TableId = null,
            TableName = null,
            Description = @"This field may repeat up to two times.",
            Sample = @"",
            Fields = null
        }

        _uB92Locator78State = new HL7V251Field
        {
            field = message[@"UB2"][16],
            fieldData = fieldData
        };

        // check for repetitions
        if (_uB92Locator78State.field.FieldRepetitions != null && _uB92Locator78State.field.FieldRepetitions.Count > 0)
        {
            _uB92Locator78State.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_uB92Locator78State, fieldData);
        }

        return _uB92Locator78State;
    } 
}

internal HL7V251Field _specialVisitCount;

public HL7V251Field SpecialVisitCount
{
    get
    {
        if (_specialVisitCount != null)
        {
            return _specialVisitCount;
        }

        var fieldData = new HL7V251FieldData
        {
            Id = @"UB2.17",
            Type = @"Field",
            Position = @"UB2.17",
            Name = @"Special Visit Count",
            Length = 3,
            Usage = @"O",
            Rpt = @"1",
            DataType = @"NM",
            DataTypeName = @"Numeric",
            TableId = null,
            TableName = null,
            Description = @"This field contains the total number of special therapy visits.",
            Sample = @"",
            Fields = null
        }

        _specialVisitCount = new HL7V251Field
        {
            field = message[@"UB2"][17],
            fieldData = fieldData
        };

        // check for repetitions
        if (_specialVisitCount.field.FieldRepetitions != null && _specialVisitCount.field.FieldRepetitions.Count > 0)
        {
            _specialVisitCount.fieldRepetitions = HL7V2FieldGenerator.GenerateV251FieldRepetitions(_specialVisitCount, fieldData);
        }

        return _specialVisitCount;
    } 
}
    }
}
