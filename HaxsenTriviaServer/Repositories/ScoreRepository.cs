using HaxsenTriviaServer.Data;
using HaxsenTriviaServer.Models;
using HaxsenTriviaServer.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace HaxsenTriviaServer.Repositories
{
    public class ScoreRepository : IScoreRepository
    {
        private readonly TriviaDbContext _context;

        public ScoreRepository(TriviaDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Score> GetScores()
        {
            return _context.Scores.ToList();
        }

        public void AddScore(Score score)
        {
            _context.Scores.Add(score);
            _context.SaveChanges();
        }
    }
}
