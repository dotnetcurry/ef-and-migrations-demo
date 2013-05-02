using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC40_Code_First_Attribute_Based.Models
{
    /// <summary>
    /// The Doctor Class has the 'DoctorId' property is applied with 'Key' attribute
    /// used for Uniquely Identify the record.
    /// </summary>
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Specialization { get; set; }

    }

    /// <summary>
    /// The Patient class has the 'PatientId' property is applied with 'Key' attribute
    /// used for Uniquely Identify the record. The 'ForeignKey' attribute is applied 
    /// on Doctor Object. This specifies that the "Doctor" is related with patient
    /// </summary>
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string Gendar { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int? DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public virtual Doctor Doctor { get; set; }
    }

}