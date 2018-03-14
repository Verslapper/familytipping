using System;
using System.Collections.Generic;
using FamilyTipping.Models;
using FamilyTipping.Models.ViewModels;
using FamilyTipping.Services;
using Microsoft.AspNetCore.Mvc;

namespace FamilyTipping.Controllers
{
    public class TipEntryController : Controller
    {
        private TipEntryService _tipService = new TipEntryService();

        public IActionResult Index()
        {
            var matches =
                new List<Match>
                {
                    new Match
                    {
                        Id = 9,
                        Teams =
                            new List<Team>
                            {
                                new Team {Id = 1, Name = "Adelaide"},
                                new Team {Id = 2, Name = "Brisbane"}
                            }
                    }
                };

            var tips = new List<Tip>();
            foreach (var match in matches)
            {
                tips.Add(new Tip { MemberId = 1, MatchId = match.Id});
            }

            var model = new TipEntryViewModel
            {
                Round = new Round
                {
                    Id = 2,
                    LockoutDate = DateTime.Now.AddDays(16),
                    Matches = matches
                },
                Tips = tips
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Enter(int matchId, int prediction, int memberId)
        {
            _tipService.Save(memberId, new Tip {MatchId = matchId, Prediction = (Prediction)prediction});
            return View("Success");
        }
    }
}
