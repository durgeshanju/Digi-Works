//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeType
    {
        public EmployeeType()
        {
            this.Employees = new HashSet<Employee>();
        }

        [Key]
        public int TypeId { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
