//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Invert911.InvertCommon.DataTypes.DataClasses
{
    using System;
    using System.Collections.Generic;
    
    public partial class i9PropertyFirearm
    {
        public string SerialNumber { get; set; }
        public string FirearmTypeCode { get; set; }
        public string FirearmTypeText { get; set; }
        public string FirearmDescriptionCode { get; set; }
        public string FirearmDescription { get; set; }
        public string FirearmMakeCode { get; set; }
        public string FirearmFinishCode { get; set; }
        public string CaliberCode { get; set; }
        public string BarrelLength { get; set; }
        public string BarrelLengthMeasureCode { get; set; }
        public string COMMENTS { get; set; }
        public System.Guid i9PropertyFirearmID { get; set; }
        public System.Guid i9PropertyID { get; set; }
    
        public virtual i9Property i9Property { get; set; }
    }
}
