//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XWINDOWSModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class WINDOWSKERNELHOOK
    {
        public int WindowsKernelHookID { get; set; }
        public string Digital_Signature_Hooking { get; set; }
        public Nullable<int> DigitalSignatureInfoHookingID { get; set; }
        public string Digital_Signature_Hooked { get; set; }
        public Nullable<int> DigitalSignatureInfoHookedID { get; set; }
        public Nullable<int> Hooking_Address { get; set; }
        public string Hook_Description { get; set; }
        public string Hooked_Function { get; set; }
        public Nullable<int> FunctionHookedID { get; set; }
        public string Hooked_Module { get; set; }
        public Nullable<int> ModuleHookedID { get; set; }
        public string Hooking_Module { get; set; }
        public Nullable<int> KernelHookID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
        public Nullable<int> ConfidenceLevelID { get; set; }
        public Nullable<int> CollectionMethodID { get; set; }
        public Nullable<int> DetectionMethodID { get; set; }
    }
}