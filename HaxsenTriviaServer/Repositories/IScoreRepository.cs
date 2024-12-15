using HaxsenTriviaServer.Models;
using System.Collections.Generic;

namespace HaxsenTriviaServer.Repositories
{
    public interface IScoreRepository
    {
        IEnumerable<Score> GetScores();
        void AddScore(Score score);
    }
}
