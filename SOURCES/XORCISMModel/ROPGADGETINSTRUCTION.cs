//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XORCISMModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class ROPGADGETINSTRUCTION
    {
        public int ROGGadgetID { get; set; }
        public int InstructionID { get; set; }
        public int InstructionOrder { get; set; }
    
        public virtual INSTRUCTION INSTRUCTION { get; set; }
        public virtual ROPGADGET ROPGADGET { get; set; }
    }
}