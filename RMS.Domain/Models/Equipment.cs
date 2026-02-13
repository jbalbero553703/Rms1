using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RMS.Domain.Models
{ 
    public class Equipment
    {
        [Key]

        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public string Model { get; set; }
        public enum Categories
        {
            Computer,
            Printer,
            Router,
            Switch,
            Other
        }
        public Categories Category { get; set; }
        public enum LoanStatus
        {
            Available,
            Loaned,
            Maintenance
        }
        public LoanStatus Status { get; set; }
        public enum Condition
        {
            New,
            Good,
            Fair,
            Poor,
            UnderRepair,
            Broken
        }
        public Condition EquipmentCondition { get; set; }
    }
}
