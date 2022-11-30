using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());

            var dic = new Dictionary<string, string>();

            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] piecesInfo = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string piece = piecesInfo[0];
                string composerAndKey = $"{piecesInfo[1]}:{piecesInfo[2]}";

                if (!dic.ContainsKey(piece))
                {
                    dic.Add(piece, composerAndKey);
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] commandInfo = command
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                if (commandInfo[0] == "Add")
                {
                    string piece = commandInfo[1];

                    if (!dic.ContainsKey(piece))
                    {
                        string composer = commandInfo[2];
                        string key = commandInfo[3];
                        dic.Add(piece, $"{composer}:{key}");

                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (commandInfo[0] == "Remove")
                {
                    string piece = commandInfo[1];

                    if (dic.ContainsKey(piece))
                    {

                        dic.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (commandInfo[0] == "ChangeKey")
                {
                    string piece = commandInfo[1];
                    string newKey = commandInfo[2];

                    if (dic.ContainsKey(piece))
                    {
                        string[] composerAndKey = dic[piece].Split(":");
                        string composer = composerAndKey[0];
                        string composerAndKeyNew = $"{composer}:{newKey}";
                        dic[piece] = composerAndKeyNew;

                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
            }

            foreach (var kvp in dic)
            {
                string[] composerAndKey = kvp.Value.Split(":");
                string composer = composerAndKey[0];
                string key = composerAndKey[1];

                Console.WriteLine($"{kvp.Key} -> Composer: {composer}, Key: {key}");
            }
        }
    }
}