using System;
using System.Collections.Generic;

#nullable disable

namespace Hello.core.training.Services.ContextDataModel
{
    public partial class CoreTable
    {
        public string ProjName { get; set; }
        public string ProjAim { get; set; }
        public DateTime? ProjStartDate { get; set; }
        public DateTime? ProjEndDate { get; set; }
        public string AssignedBy { get; set; }
        public int ProjId { get; set; }
    }
}
