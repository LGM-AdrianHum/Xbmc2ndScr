﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.18033
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;
namespace TestVLC
{
}

namespace TestVLC
{
}

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]

[System.Diagnostics.DebuggerStepThroughAttribute()]

[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class vlm {
    
    private vlmBroadcast[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("broadcast", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public vlmBroadcast[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]

[System.Diagnostics.DebuggerStepThroughAttribute()]

[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class vlmBroadcast {
    
    private string outputField;
    
    private string[] optionsField;
    
    private vlmBroadcastInputs[] inputsField;
    
    private vlmBroadcastInstancesInstance[] instancesField;
    
    private string nameField;
    
    private string enabledField;
    
    private string loopField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string output {
        get {
            return this.outputField;
        }
        set {
            this.outputField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArray("options",Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItem("option",Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string[] options {
        get {
            return this.optionsField;
        }
        set {
            this.optionsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("inputs", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public vlmBroadcastInputs[] inputs {
        get {
            return this.inputsField;
        }
        set {
            this.inputsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("instance", typeof(vlmBroadcastInstancesInstance), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
    public vlmBroadcastInstancesInstance[] instances {
        get {
            return this.instancesField;
        }
        set {
            this.instancesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string enabled {
        get {
            return this.enabledField;
        }
        set {
            this.enabledField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string loop {
        get {
            return this.loopField;
        }
        set {
            this.loopField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]

[System.Diagnostics.DebuggerStepThroughAttribute()]

[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class vlmBroadcastInputs {
    
    private string inputField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string input {
        get {
            return this.inputField;
        }
        set {
            this.inputField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]

[System.Diagnostics.DebuggerStepThroughAttribute()]

[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class vlmBroadcastInstancesInstance {
    
    private string nameField;
    
    private string stateField;
    
    private string positionField;
    
    private string timeField;
    
    private string lengthField;
    
    private string rateField;
    
    private string titleField;
    
    private string chapterField;
    
    private string canseekField;
    
    private string playlistindexField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string state {
        get {
            return this.stateField;
        }
        set {
            this.stateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string position {
        get {
            return this.positionField;
        }
        set {
            this.positionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string time {
        get {
            return this.timeField;
        }
        set {
            this.timeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string length {
        get {
            return this.lengthField;
        }
        set {
            this.lengthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string rate {
        get {
            return this.rateField;
        }
        set {
            this.rateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string title {
        get {
            return this.titleField;
        }
        set {
            this.titleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string chapter {
        get {
            return this.chapterField;
        }
        set {
            this.chapterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("can-seek")]
    public string canseek {
        get {
            return this.canseekField;
        }
        set {
            this.canseekField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string playlistindex {
        get {
            return this.playlistindexField;
        }
        set {
            this.playlistindexField = value;
        }
    }
}
