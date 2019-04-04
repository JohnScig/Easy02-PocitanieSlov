using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounting
{
    static class WordCount
    {
        private static Dictionary<string, int> WordDictionary = new Dictionary<string, int>();

        public static Dictionary<string, int> CountWords(string text)
        {
            text = RemoveDiacritics(text);
            string[] parsedText = ParseText(text);
            string[] nonWords = { "pre", "ten", "pri","jej","bol","bola","bolo","boli"};

            parsedText = RemoveNonWords(parsedText, nonWords);
            char[] unwantedChars = { ',', '.', '!', '?', ';', ':', '(', ')' };

            parsedText = CleanUpWords(parsedText, unwantedChars);

            foreach (string word in parsedText)
            {
                if (WordDictionary.Keys.Contains(word))
                {
                    WordDictionary[word]++;
                }
                else
                {
                    WordDictionary.Add(key: word, value: 1);
                }
            }

            return WordDictionary;
        }

        public static string[] ParseText(string text)
        {
            return text.Split(' ');
        }

        public static void ClearDictionary()
        {
            WordDictionary.Clear();
        }

        public static string[] CleanUpWords(string[] words, char[] unwantedChars)

        {
            string[] cleanedWords = new string[words.Length];
            int i = 0;
            foreach (string word in words)
            {
                cleanedWords[i++] = word.Trim(unwantedChars);


            }

            return cleanedWords;
        }

        public static string RemoveDiacritics(string text)
        {
            string normalizedString = text.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in normalizedString)
            {
                UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        public static string[] RemoveNonWords (string [] text, string [] nonWords)
        {
            List<string> goodWords = text.ToList();
            foreach (string nonWord in nonWords)
            {
                foreach (string word in text)
                {
                    if (word.Length <= 2)
                    {
                        goodWords.Remove(word);
                    }
                }
                foreach (string word in text)
                {
                    if (word == nonWord)
                    {
                        goodWords.Remove(word);
                    }
                }
            }

            return goodWords.ToArray();

        }
    }
}
