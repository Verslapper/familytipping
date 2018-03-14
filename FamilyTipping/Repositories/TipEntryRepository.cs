using System;
using System.Data;
using System.Data.SqlClient;
using FamilyTipping.Models;
using FamilyTipping.Models.DTOs;
using Microsoft.Extensions.Configuration;
using PetaPoco.NetCore;

namespace FamilyTipping.Repositories
{
    public class TipEntryRepository
    {
        private readonly Database _db;

        public TipEntryRepository()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath("c:/familytipping/familytipping")
                .AddJsonFile("appsettings.json")
                .Build();

            IDbConnection dbConnection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
            _db = new Database(dbConnection);
        }

        public void Save(int memberId, Tip tip)
        {
            var dto = _db.FirstOrDefault<TipDTO>("where memberId = @0 and MatchId = @1", memberId, tip.MatchId) ?? new TipDTO();

            dto.MemberId = memberId;
            dto.MatchId = tip.MatchId;
            dto.Prediction = (int)tip.Prediction;

            _db.Save(dto);
        }
    }
}
