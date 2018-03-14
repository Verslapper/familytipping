using FamilyTipping.Models;
using FamilyTipping.Repositories;

namespace FamilyTipping.Services
{
    public class TipEntryService
    {
        private readonly TipEntryRepository _tipEntryRepository = new TipEntryRepository();

        public void Save(int memberId, Tip tip)
        {
            _tipEntryRepository.Save(memberId, tip);
        }
    }
}
