//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AstroGearsMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AspectInterpretation
    {
        public int AspectInterpretationId { get; set; }
        public byte AspectInterpretationTypeId1 { get; set; }
        public Nullable<int> CelestialObjectId1 { get; set; }
        public Nullable<byte> AngleId1 { get; set; }
        public byte AspectId { get; set; }
        public byte AspectInterpretationTypeId2 { get; set; }
        public Nullable<int> CelestialObjectId2 { get; set; }
        public Nullable<byte> AngleId2 { get; set; }
        public string Interpretation { get; set; }
        public string CitationUrl { get; set; }
    
        public virtual AspectInterpretationType AspectInterpretationType { get; set; }
        public virtual AspectInterpretationType AspectInterpretationType1 { get; set; }
        public virtual Aspect Aspect { get; set; }
        public virtual CelestialObject CelestialObject { get; set; }
        public virtual CelestialObject CelestialObject1 { get; set; }
        public virtual HouseAngle HouseAngle { get; set; }
        public virtual HouseAngle HouseAngle1 { get; set; }
    }
}