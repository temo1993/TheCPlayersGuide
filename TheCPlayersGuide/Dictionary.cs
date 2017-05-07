using System.Collections.Generic;

namespace TheCPlayersGuide
{
        /// <summary>
        /// Represents a dictionary, containing words and their definitions.
        /// </summary>
        internal class Dictionary
        {
            /// <summary>
            /// Stores the list of words. This list works as a parallel array to the
            /// definitions list. That is, the word at a particular index in this
            /// array is linked to the definition at the same index in the
            /// definitions array.
            /// </summary>
            private List<string> words;

            /// <summary>
            /// Stores the definition of words.This list works as a parallel 
            /// array to thedefinitions list. That is, the word at a particular
            /// index in this array is linked to the definition at the same 
            /// index in the definitions array.
            /// </summary>
            private List<string> definitions;

            /// <summary>
            /// Creates a new Dictionary, with no words or definitions initially.
            /// </summary>
            public Dictionary()
            {
                words = new List<string>();
                definitions = new List<string>();
            }

            /// <summary>
            /// An indexer for the dictionary. Pass in a word, and the
            /// matching definition is returned. Alternatively, definitions can
            /// be assigned as well.
            /// </summary>
            /// <param name="word"></param>
            /// <returns></returns>
            public string this[string word]
            {
                get
                {
                    string result = LookupWord(word);
                    if (result == null)
                    {
                        throw new KeyNotFoundException(word);
                    }
                    return result;
                }
                set { AddDefinition(word, value); }
            }

            /// <summary>
            /// Adds a word with a corresponding definition. This provides
            /// an alternative way of adding definitions and words without
            /// using the indexer. (In fact, the indexer uses this method.)
            /// </summary>
            /// <param name="word"></param>
            /// <param name="definition"></param>
            public void AddDefinition(string word, string definition)
            {
                for (int index = 0; index < words.Count; index++)
                {
                    if (words[index] == word)
                    {
                        definitions[index] = definition;
                        return;
                    }
                }

                words.Add(word);
                definitions.Add(definition);
            }

            /// <summary>
            /// Returns the definition for the specified word in the dictionary.
            /// In the event that the word doesn't exist yet in the dictionary,
            /// null is returned instead.
            /// </summary>
            /// <param name="word"></param>
            /// <returns></returns>
            public string LookupWord(string word)
            {
                for (int index = 0; index < words.Count; index++)
                {
                    if (words[index] == word)
                    {
                        return definitions[index];
                    }
                }

                return null;
            }
        }
    }