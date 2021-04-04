using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = {"join", "lemon", "ice", "fantastic", "rustic", "economic", "available", "verdict", "representative", "genius", "blessed", "jazzy", "desk", "informat",
            "applejuice", "nightime", "collections", "headboard", "pepper", "music", "hungry", "nice", "basketball", "football", "track", "soccer", "volleyball", "synthesizer", "randomized", "destined", "honeymoon", "grandmother" };

    public static string GetRandomWord ()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

            return randomWord;
    }
}
