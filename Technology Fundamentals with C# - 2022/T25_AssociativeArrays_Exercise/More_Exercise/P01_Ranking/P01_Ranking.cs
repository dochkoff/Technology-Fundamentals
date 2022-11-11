using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            var submissions = new Dictionary<string, Dictionary<string, int>>();

            string contest;
            string password;
            string contestsInput;
            while ((contestsInput = Console.ReadLine()) != "end of contests")
            {
                string[] contestsInfo = contestsInput
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);

                contest = contestsInfo[0];
                password = contestsInfo[1];

                contests[contest] = password;
            }

            string submmissionInput;
            while ((submmissionInput = Console.ReadLine()) != "end of submissions")
            {
                string[] submissionInfo = submmissionInput
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);

                contest = submissionInfo[0];
                password = submissionInfo[1];
                string user = submissionInfo[2];
                int points = int.Parse(submissionInfo[3]);

                foreach (var kvp in contests)
                {
                    if (kvp.Key == contest && kvp.Value == password)
                    {
                        if (!submissions.ContainsKey(user))
                        {
                            submissions[user] = new Dictionary<string, int>();
                        }
                        else
                        {
                            if (!submissions[user].ContainsKey(contest))
                            {
                                submissions[user].Add(contest, points);
                            }
                            else
                            {
                                submissions[user].

                                foreach (var keyValuePair in submissions[user])
                                {
                                    if (keyValuePair.Key == contest && keyValuePair.Value < points)
                                    {
                                        submissions[user].
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
