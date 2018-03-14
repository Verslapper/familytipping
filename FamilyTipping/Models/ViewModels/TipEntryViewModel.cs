using System.Collections.Generic;

namespace FamilyTipping.Models.ViewModels
{
    public class TipEntryViewModel
    {
        public Round Round { get; set; }
        public List<Tip> Tips { get; set; }
    }
}
