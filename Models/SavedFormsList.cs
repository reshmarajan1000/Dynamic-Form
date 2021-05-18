using System;
using System.Collections.Generic;

namespace Dynamic_User_Defined_Dashboards.Models
{
    public partial class SavedFormsList
    {
        public int Id { get; set; }
        public string FormName { get; set; }
        public string FormData { get; set; }
        public string CreatedData { get; set; }
    }
}
