﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlorTest.Model;

// 
// Этот исходный код был создан с помощью xsd, версия=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=true)]
public partial class Value {
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string ValueField {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class ListType {
    
    private string ValueField;
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ListTypeValue {
        get {
            return this.ValueField;
        }
        set {
            this.ValueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class LastDayUpdated {
    
    private Value[] ValueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("VALUE", IsNullable=true)]
    public Value[] VALUE {
        get {
            return this.ValueField;
        }
        set {
            this.ValueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class ConsolidatedList {
    
    private Individuals[] IndividualsField;
    
    private Entities[] EntitiesField;
    
    private string dateGeneratedField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("INDIVIDUAL", typeof(Individuals), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public Individuals[] Individuals {
        get {
            return this.IndividualsField;
        }
        set {
            this.IndividualsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ENTITY", typeof(Entities), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public Entities[] Entities {
        get {
            return this.EntitiesField;
        }
        set {
            this.EntitiesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DateGenerated {
        get {
            return this.dateGeneratedField;
        }
        set {
            this.dateGeneratedField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class Individuals {
    
    private string DataIdField;
    
    private string VersionNumField;
    
    private string FirstNameField;
    
    private string SecondNameField;
    
    private string tHIRD_NAMEField;
    
    private string fOURTH_NAMEField;
    
    private string uN_LIST_TYPEField;
    
    private string rEFERENCE_NUMBERField;
    
    private string lISTED_ONField;
    
    private string gENDERField;
    
    private string nAME_ORIGINAL_SCRIPTField;
    
    private string cOMMENTS1Field;
    
    private string sORT_KEYField;
    
    private string sORT_KEY_LAST_MODField;
    
    private Value[] tITLEField;
    
    private Value[] dESIGNATIONField;
    
    private Value[] nATIONALITYField;
    
    private ListType[] lIST_TYPEField;
    
    private Value[] lAST_DAY_UPDATEDField;
    
    private CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ALIAS[] iNDIVIDUAL_ALIASField;
    
    private CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ADDRESS[] iNDIVIDUAL_ADDRESSField;
    
    private CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DATE_OF_BIRTH[] iNDIVIDUAL_DATE_OF_BIRTHField;
    
    private CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_PLACE_OF_BIRTH[] iNDIVIDUAL_PLACE_OF_BIRTHField;
    
    private CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DOCUMENT[] iNDIVIDUAL_DOCUMENTField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DATAID {
        get {
            return this.DataIdField;
        }
        set {
            this.DataIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string VERSIONNUM {
        get {
            return this.VersionNumField;
        }
        set {
            this.VersionNumField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FIRST_NAME {
        get {
            return this.FirstNameField;
        }
        set {
            this.FirstNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string SECOND_NAME {
        get {
            return this.SecondNameField;
        }
        set {
            this.SecondNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string THIRD_NAME {
        get {
            return this.tHIRD_NAMEField;
        }
        set {
            this.tHIRD_NAMEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FOURTH_NAME {
        get {
            return this.fOURTH_NAMEField;
        }
        set {
            this.fOURTH_NAMEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string UN_LIST_TYPE {
        get {
            return this.uN_LIST_TYPEField;
        }
        set {
            this.uN_LIST_TYPEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string REFERENCE_NUMBER {
        get {
            return this.rEFERENCE_NUMBERField;
        }
        set {
            this.rEFERENCE_NUMBERField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string LISTED_ON {
        get {
            return this.lISTED_ONField;
        }
        set {
            this.lISTED_ONField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string GENDER {
        get {
            return this.gENDERField;
        }
        set {
            this.gENDERField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NAME_ORIGINAL_SCRIPT {
        get {
            return this.nAME_ORIGINAL_SCRIPTField;
        }
        set {
            this.nAME_ORIGINAL_SCRIPTField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string COMMENTS1 {
        get {
            return this.cOMMENTS1Field;
        }
        set {
            this.cOMMENTS1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string SORT_KEY {
        get {
            return this.sORT_KEYField;
        }
        set {
            this.sORT_KEYField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string SORT_KEY_LAST_MOD {
        get {
            return this.sORT_KEY_LAST_MODField;
        }
        set {
            this.sORT_KEY_LAST_MODField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("VALUE", typeof(Value))]
    public Value[] TITLE {
        get {
            return this.tITLEField;
        }
        set {
            this.tITLEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("VALUE", typeof(Value))]
    public Value[] DESIGNATION {
        get {
            return this.dESIGNATIONField;
        }
        set {
            this.dESIGNATIONField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("VALUE", typeof(Value))]
    public Value[] NATIONALITY {
        get {
            return this.nATIONALITYField;
        }
        set {
            this.nATIONALITYField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("LIST_TYPE")]
    public ListType[] LIST_TYPE {
        get {
            return this.lIST_TYPEField;
        }
        set {
            this.lIST_TYPEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("VALUE", typeof(Value))]
    public Value[] LAST_DAY_UPDATED {
        get {
            return this.lAST_DAY_UPDATEDField;
        }
        set {
            this.lAST_DAY_UPDATEDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("INDIVIDUAL_ALIAS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ALIAS[] INDIVIDUAL_ALIAS {
        get {
            return this.iNDIVIDUAL_ALIASField;
        }
        set {
            this.iNDIVIDUAL_ALIASField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("INDIVIDUAL_ADDRESS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ADDRESS[] INDIVIDUAL_ADDRESS {
        get {
            return this.iNDIVIDUAL_ADDRESSField;
        }
        set {
            this.iNDIVIDUAL_ADDRESSField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("INDIVIDUAL_DATE_OF_BIRTH", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DATE_OF_BIRTH[] INDIVIDUAL_DATE_OF_BIRTH {
        get {
            return this.iNDIVIDUAL_DATE_OF_BIRTHField;
        }
        set {
            this.iNDIVIDUAL_DATE_OF_BIRTHField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("INDIVIDUAL_PLACE_OF_BIRTH", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_PLACE_OF_BIRTH[] INDIVIDUAL_PLACE_OF_BIRTH {
        get {
            return this.iNDIVIDUAL_PLACE_OF_BIRTHField;
        }
        set {
            this.iNDIVIDUAL_PLACE_OF_BIRTHField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("INDIVIDUAL_DOCUMENT", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DOCUMENT[] INDIVIDUAL_DOCUMENT {
        get {
            return this.iNDIVIDUAL_DOCUMENTField;
        }
        set {
            this.iNDIVIDUAL_DOCUMENTField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ALIAS {
    
    private string qUALITYField;
    
    private string aLIAS_NAMEField;
    
    private string cITY_OF_BIRTHField;
    
    private string cOUNTRY_OF_BIRTHField;
    
    private string nOTEField;
    
    private string dATE_OF_BIRTHField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string QUALITY {
        get {
            return this.qUALITYField;
        }
        set {
            this.qUALITYField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ALIAS_NAME {
        get {
            return this.aLIAS_NAMEField;
        }
        set {
            this.aLIAS_NAMEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CITY_OF_BIRTH {
        get {
            return this.cITY_OF_BIRTHField;
        }
        set {
            this.cITY_OF_BIRTHField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string COUNTRY_OF_BIRTH {
        get {
            return this.cOUNTRY_OF_BIRTHField;
        }
        set {
            this.cOUNTRY_OF_BIRTHField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NOTE {
        get {
            return this.nOTEField;
        }
        set {
            this.nOTEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DATE_OF_BIRTH {
        get {
            return this.dATE_OF_BIRTHField;
        }
        set {
            this.dATE_OF_BIRTHField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_ADDRESS {
    
    private string nOTEField;
    
    private string sTREETField;
    
    private string sTATE_PROVINCEField;
    
    private string cITYField;
    
    private string cOUNTRYField;
    
    private string zIP_CODEField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NOTE {
        get {
            return this.nOTEField;
        }
        set {
            this.nOTEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string STREET {
        get {
            return this.sTREETField;
        }
        set {
            this.sTREETField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string STATE_PROVINCE {
        get {
            return this.sTATE_PROVINCEField;
        }
        set {
            this.sTATE_PROVINCEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CITY {
        get {
            return this.cITYField;
        }
        set {
            this.cITYField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string COUNTRY {
        get {
            return this.cOUNTRYField;
        }
        set {
            this.cOUNTRYField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ZIP_CODE {
        get {
            return this.zIP_CODEField;
        }
        set {
            this.zIP_CODEField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DATE_OF_BIRTH {
    
    private string tYPE_OF_DATEField;
    
    private string dATEField;
    
    private string fROM_YEARField;
    
    private string tO_YEARField;
    
    private string nOTEField;
    
    private string yEARField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TYPE_OF_DATE {
        get {
            return this.tYPE_OF_DATEField;
        }
        set {
            this.tYPE_OF_DATEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DATE {
        get {
            return this.dATEField;
        }
        set {
            this.dATEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FROM_YEAR {
        get {
            return this.fROM_YEARField;
        }
        set {
            this.fROM_YEARField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TO_YEAR {
        get {
            return this.tO_YEARField;
        }
        set {
            this.tO_YEARField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NOTE {
        get {
            return this.nOTEField;
        }
        set {
            this.nOTEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string YEAR {
        get {
            return this.yEARField;
        }
        set {
            this.yEARField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_PLACE_OF_BIRTH {
    
    private string sTREETField;
    
    private string cITYField;
    
    private string sTATE_PROVINCEField;
    
    private string nOTEField;
    
    private string cOUNTRYField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string STREET {
        get {
            return this.sTREETField;
        }
        set {
            this.sTREETField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CITY {
        get {
            return this.cITYField;
        }
        set {
            this.cITYField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string STATE_PROVINCE {
        get {
            return this.sTATE_PROVINCEField;
        }
        set {
            this.sTATE_PROVINCEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NOTE {
        get {
            return this.nOTEField;
        }
        set {
            this.nOTEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string COUNTRY {
        get {
            return this.cOUNTRYField;
        }
        set {
            this.cOUNTRYField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class CONSOLIDATED_LISTINDIVIDUALSINDIVIDUALINDIVIDUAL_DOCUMENT {
    
    private string tYPE_OF_DOCUMENTField;
    
    private string tYPE_OF_DOCUMENT2Field;
    
    private string nOTEField;
    
    private string nUMBERField;
    
    private string iSSUING_COUNTRYField;
    
    private string dATE_OF_ISSUEField;
    
    private string cITY_OF_ISSUEField;
    
    private string cOUNTRY_OF_ISSUEField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TYPE_OF_DOCUMENT {
        get {
            return this.tYPE_OF_DOCUMENTField;
        }
        set {
            this.tYPE_OF_DOCUMENTField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TYPE_OF_DOCUMENT2 {
        get {
            return this.tYPE_OF_DOCUMENT2Field;
        }
        set {
            this.tYPE_OF_DOCUMENT2Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NOTE {
        get {
            return this.nOTEField;
        }
        set {
            this.nOTEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NUMBER {
        get {
            return this.nUMBERField;
        }
        set {
            this.nUMBERField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ISSUING_COUNTRY {
        get {
            return this.iSSUING_COUNTRYField;
        }
        set {
            this.iSSUING_COUNTRYField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DATE_OF_ISSUE {
        get {
            return this.dATE_OF_ISSUEField;
        }
        set {
            this.dATE_OF_ISSUEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CITY_OF_ISSUE {
        get {
            return this.cITY_OF_ISSUEField;
        }
        set {
            this.cITY_OF_ISSUEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string COUNTRY_OF_ISSUE {
        get {
            return this.cOUNTRY_OF_ISSUEField;
        }
        set {
            this.cOUNTRY_OF_ISSUEField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class Entities {
    
    private string dATAIDField;
    
    private string vERSIONNUMField;
    
    private string fIRST_NAMEField;
    
    private string uN_LIST_TYPEField;
    
    private string rEFERENCE_NUMBERField;
    
    private string lISTED_ONField;
    
    private string nAME_ORIGINAL_SCRIPTField;
    
    private string cOMMENTS1Field;
    
    private string sORT_KEYField;
    
    private string sORT_KEY_LAST_MODField;
    
    private ListType[] lIST_TYPEField;
    
    private Value[][] lAST_DAY_UPDATEDField;
    
    private CONSOLIDATED_LISTENTITIESENTITYENTITY_ALIAS[] eNTITY_ALIASField;
    
    private CONSOLIDATED_LISTENTITIESENTITYENTITY_ADDRESS[] eNTITY_ADDRESSField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DATAID {
        get {
            return this.dATAIDField;
        }
        set {
            this.dATAIDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string VERSIONNUM {
        get {
            return this.vERSIONNUMField;
        }
        set {
            this.vERSIONNUMField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FIRST_NAME {
        get {
            return this.fIRST_NAMEField;
        }
        set {
            this.fIRST_NAMEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string UN_LIST_TYPE {
        get {
            return this.uN_LIST_TYPEField;
        }
        set {
            this.uN_LIST_TYPEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string REFERENCE_NUMBER {
        get {
            return this.rEFERENCE_NUMBERField;
        }
        set {
            this.rEFERENCE_NUMBERField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string LISTED_ON {
        get {
            return this.lISTED_ONField;
        }
        set {
            this.lISTED_ONField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NAME_ORIGINAL_SCRIPT {
        get {
            return this.nAME_ORIGINAL_SCRIPTField;
        }
        set {
            this.nAME_ORIGINAL_SCRIPTField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string COMMENTS1 {
        get {
            return this.cOMMENTS1Field;
        }
        set {
            this.cOMMENTS1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string SORT_KEY {
        get {
            return this.sORT_KEYField;
        }
        set {
            this.sORT_KEYField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string SORT_KEY_LAST_MOD {
        get {
            return this.sORT_KEY_LAST_MODField;
        }
        set {
            this.sORT_KEY_LAST_MODField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("LIST_TYPE")]
    public ListType[] LIST_TYPE {
        get {
            return this.lIST_TYPEField;
        }
        set {
            this.lIST_TYPEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("VALUE", typeof(Value))]
    public Value[][] LAST_DAY_UPDATED {
        get {
            return this.lAST_DAY_UPDATEDField;
        }
        set {
            this.lAST_DAY_UPDATEDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ENTITY_ALIAS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public CONSOLIDATED_LISTENTITIESENTITYENTITY_ALIAS[] ENTITY_ALIAS {
        get {
            return this.eNTITY_ALIASField;
        }
        set {
            this.eNTITY_ALIASField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ENTITY_ADDRESS", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public CONSOLIDATED_LISTENTITIESENTITYENTITY_ADDRESS[] ENTITY_ADDRESS {
        get {
            return this.eNTITY_ADDRESSField;
        }
        set {
            this.eNTITY_ADDRESSField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class CONSOLIDATED_LISTENTITIESENTITYENTITY_ALIAS {
    
    private string qUALITYField;
    
    private string aLIAS_NAMEField;
    
    private string nOTEField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string QUALITY {
        get {
            return this.qUALITYField;
        }
        set {
            this.qUALITYField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ALIAS_NAME {
        get {
            return this.aLIAS_NAMEField;
        }
        set {
            this.aLIAS_NAMEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NOTE {
        get {
            return this.nOTEField;
        }
        set {
            this.nOTEField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class CONSOLIDATED_LISTENTITIESENTITYENTITY_ADDRESS {
    
    private string sTREETField;
    
    private string cITYField;
    
    private string sTATE_PROVINCEField;
    
    private string zIP_CODEField;
    
    private string cOUNTRYField;
    
    private string nOTEField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string STREET {
        get {
            return this.sTREETField;
        }
        set {
            this.sTREETField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CITY {
        get {
            return this.cITYField;
        }
        set {
            this.cITYField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string STATE_PROVINCE {
        get {
            return this.sTATE_PROVINCEField;
        }
        set {
            this.sTATE_PROVINCEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ZIP_CODE {
        get {
            return this.zIP_CODEField;
        }
        set {
            this.zIP_CODEField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string COUNTRY {
        get {
            return this.cOUNTRYField;
        }
        set {
            this.cOUNTRYField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NOTE {
        get {
            return this.nOTEField;
        }
        set {
            this.nOTEField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class NewDataSet {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CONSOLIDATED_LIST", typeof(ConsolidatedList))]
    [System.Xml.Serialization.XmlElementAttribute("LAST_DAY_UPDATED", typeof(Value[]))]
    [System.Xml.Serialization.XmlElementAttribute("LIST_TYPE", typeof(ListType))]
    [System.Xml.Serialization.XmlElementAttribute("VALUE", typeof(Value), IsNullable=true)]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}
