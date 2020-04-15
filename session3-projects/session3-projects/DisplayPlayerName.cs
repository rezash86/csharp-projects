using System;
using System.Collections.Generic;
using System.Text;

namespace session3_projects
{
    class DisplayPlayerName
    {
        delegate int ScoreDelegate(PlayerStates stats);

        void OnGameOver(PlayerStates[] playerStates)
        {
            ScoreDelegate killDelegate = ScoreByKillCount;
            string playermostKilled = GetPlayerNameTopScore(playerStates, killDelegate);
            ScoreDelegate flagCapturedDelegate = ScoreByKillCount;
            string playermostFlagCaptured = GetPlayerNameTopScore(playerStates, flagCapturedDelegate);


            //This part is a bonus
            string playermostKilled1 = GetPlayerNameTopScore(playerStates, stat => stat.kills);
            string playermostFlagCaptured1 = GetPlayerNameTopScore(playerStates, stat => stat.flagCaptured);

        }

        //string GetPlayerNameMostKilled(PlayerStates[] playerStates)
        //{
        //    string name = "";
        //    int bestScore = 0;

        //    foreach (PlayerStates state in playerStates)
        //    {
        //        int score = state.kills;
        //        if (score > bestScore)
        //        {
        //            bestScore = score;
        //            name = state.name;
        //        }
        //    }

        //    return name;
        //}

        //string GetPlayerNameMostFlagCaptured(PlayerStates[] playerStates)
        //{
        //    string name = "";
        //    int bestScore = 0;

        //    foreach (PlayerStates state in playerStates)
        //    {
        //        int score = state.flagCaptured;
        //        if (score > bestScore)
        //        {
        //            bestScore = score;
        //            name = state.name;
        //        }
        //    }

        //    return name;
        //}

        string GetPlayerNameTopScore(PlayerStates[] playerStates, ScoreDelegate scoredelegate)
        {
            string name = "";
            int bestScore = 0;

            foreach (PlayerStates state in playerStates)
            {
                int score = scoredelegate(state);
                if (score > bestScore)
                {
                    bestScore = score;
                    name = state.name;
                }
            }

            return name;
        }

        int ScoreByKillCount(PlayerStates stats)
        {
            return stats.kills;
        }

        int ScoreByFlagCaptured(PlayerStates stats)
        {
            return stats.flagCaptured;
        }

    }

    
}
