﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace TempProject.Models
{
    public partial class PhoneType
    {
        public PhoneType()
        {
            ContactDevices = new HashSet<ContactDevices>();
        }

        public int PhoneTypeIdenitfier { get; set; }
        public string PhoneTypeDescription { get; set; }

        public virtual ICollection<ContactDevices> ContactDevices { get; set; }
    }
}