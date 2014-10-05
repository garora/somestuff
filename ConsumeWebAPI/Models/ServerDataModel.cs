using System;
using System.ComponentModel.DataAnnotations;

namespace ConsumeWebAPI.Models
{
    public class ServerDataModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Initial date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime InitialDate { get; set; }
        [Required]
        [Display(Name = "End date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Required]
        [Display(Name = "Order number")]
        public int OrderNumber { get; set; }
        [Required]
        [Display(Name = "Is dirty")]
        public bool IsDirty { get; set; }
        [Required, StringLength(15)]
        [Display(Name = "Data Server IP")]
        [RegularExpression(@"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$",ErrorMessage = "Data Server IP should be in the form of 255.255.255")]
        public string IP { get; set; }

        [Required]
        [Display(Name = "Record data type")]
        [RegularExpression(@"^([1-2])$", ErrorMessage = "Record Data Type should be 1 or 2")]
        public int Type { get; set; }

        [Display(Name = "Record identifier")]
        [RegularExpression(@"^([0-9])$", ErrorMessage = "Record identifier should be between 0 to 9")]
        public int RecordIdentifier { get; set; }
    }
}