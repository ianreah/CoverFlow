﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
//[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class lfm
{

    private lfmTopalbums[] topalbumsField;

    private string statusField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("topalbums", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public lfmTopalbums[] topalbums
    {
        get
        {
            return this.topalbumsField;
        }
        set
        {
            this.topalbumsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
//[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class lfmTopalbums
{

    private lfmTopalbumsAlbum[] albumField;

    private string userField;

    private string typeField;

    private string pageField;

    private string perPageField;

    private string totalPagesField;

    private string totalField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("album", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public lfmTopalbumsAlbum[] album
    {
        get
        {
            return this.albumField;
        }
        set
        {
            this.albumField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string user
    {
        get
        {
            return this.userField;
        }
        set
        {
            this.userField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string page
    {
        get
        {
            return this.pageField;
        }
        set
        {
            this.pageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string perPage
    {
        get
        {
            return this.perPageField;
        }
        set
        {
            this.perPageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string totalPages
    {
        get
        {
            return this.totalPagesField;
        }
        set
        {
            this.totalPagesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string total
    {
        get
        {
            return this.totalField;
        }
        set
        {
            this.totalField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
//[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class lfmTopalbumsAlbum
{

    private string nameField;

    private string playcountField;

    private string mbidField;

    private string urlField;

    private lfmTopalbumsAlbumArtist[] artistField;

    private lfmTopalbumsAlbumImage[] imageField;

    private string rankField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string playcount
    {
        get
        {
            return this.playcountField;
        }
        set
        {
            this.playcountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string mbid
    {
        get
        {
            return this.mbidField;
        }
        set
        {
            this.mbidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("artist", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public lfmTopalbumsAlbumArtist[] artist
    {
        get
        {
            return this.artistField;
        }
        set
        {
            this.artistField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("image", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
    public lfmTopalbumsAlbumImage[] image
    {
        get
        {
            return this.imageField;
        }
        set
        {
            this.imageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string rank
    {
        get
        {
            return this.rankField;
        }
        set
        {
            this.rankField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
//[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class lfmTopalbumsAlbumArtist
{

    private string nameField;

    private string mbidField;

    private string urlField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string mbid
    {
        get
        {
            return this.mbidField;
        }
        set
        {
            this.mbidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
//[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class lfmTopalbumsAlbumImage
{

    private string sizeField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string size
    {
        get
        {
            return this.sizeField;
        }
        set
        {
            this.sizeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
//[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class NewDataSet
{

    private lfm[] itemsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("lfm")]
    public lfm[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }
}