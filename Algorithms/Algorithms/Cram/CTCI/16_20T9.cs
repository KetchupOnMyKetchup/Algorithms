using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Algorithms.Cram.CTCI
{
    /// <summary>
    /// T9: On old cell phones, users typed on a numeric keypad and the phone would provide a list of
    /// words that matched these numbers.Each digit mapped to a set of 0 - 4 letters.Implement an algorithm
    /// to return a list of matching words, given a sequence of digits.You are provided a list of valid
    /// words(provided in whatever data structure you'd like).
    /// 
    /// https://leetcode.com/articles/implement-trie-prefix-tree/
    /// </summary>
    class _16_20T9
    {
        private char[][] charMap = new char[][] 
        {
            new char[]{ 'a', 'b', 'c' },//2
            new char[]{ 'd', 'e', 'f' }, 
            new char[]{ 'g', 'h', 'i' }, 
            new char[]{ 'j', 'k', 'l' }, 
            new char[]{ 'm', 'n', 'o' }, 
            new char[]{ 'p', 'q', 'r', 's' },
            new char[]{ 't', 'u', 'v' },
            new char[]{ 'w', 'x', 'y', 'z' },
        };

        static List<string> Solve(int input, Trie trie)
        {
            // R- way trie should be used for T9



            char[] charArray = input.ToString().ToCharArray();

            SearchT9Trie(trie.root, charArray, 0);

            return new List<string>();
        }

        private static void SearchT9Trie(TrieNode trieNode, char[] charArray, int curr)
        {
            var currChar = charArray[curr];
            var length = charArray.Length;

            switch (currChar)
            {
                case '1':
                case '2':
                case '3':
                    if (trieNode.containsKey('d'))
                    {
                    }
                    if (trieNode.containsKey('e'))
                    {
                        SearchT9Trie(trieNode.get('e'), charArray, curr + 1);
                        if (trieNode.isEnd)
                        {

                            break;
                        }
                    }
                    if (trieNode.containsKey('f'))
                    {
                    }
                    break;
                case '4':
                case '5':
                case '6':
                case '7':
                    if (trieNode.containsKey('p'))
                    {

                    }
                    if (trieNode.containsKey('q'))
                    {
                    }
                    if (trieNode.containsKey('r'))
                    {
                        SearchT9Trie(trieNode.get('r'), charArray, curr + 1);
                    }
                    if (trieNode.containsKey('s'))
                    {
                    }
                    break;
                case '8':
                    if (trieNode.containsKey('t'))
                    {
                        SearchT9Trie(trieNode.get('t'), charArray, curr + 1);
                    }
                    if (trieNode.containsKey('u'))
                    {
                    }
                    if (trieNode.containsKey('v'))
                    {
                    }
                    break;
                case '9':
                default:
                    break;
            }
        }



        class TrieNode
        {
            // R links to node children
            public TrieNode[] links;

            private readonly int R = 26; // 26 letters in alphabet

            public bool isEnd;

            public TrieNode()
            {
                links = new TrieNode[R];
            }

            public bool containsKey(char ch)
            {
                return links[ch - 'a'] != null;
            }
            public TrieNode get(char ch)
            {
                return links[ch - 'a'];
            }
            public void put(char ch, TrieNode node)
            {
                links[ch - 'a'] = node;
            }
            public void setEnd()
            {
                isEnd = true;
            }
        }

        class Trie
        {
            public TrieNode root;
            public Trie()
            {
                root = new TrieNode();
            }

            // Inserts a word into the trie.
            public void insert(String word)
            {
                TrieNode node = root;
                for (int i = 0; i < word.Length; i++)
                {
                    char currentChar = word[i];
                    if (!node.containsKey(currentChar))
                    {
                        node.put(currentChar, new TrieNode());
                    }
                    node = node.get(currentChar);
                }
                node.setEnd();
            }

            // search a prefix or whole key in trie and
            // returns the node where search ends
            public TrieNode searchPrefix(String word)
            {
                TrieNode node = root;
                for (int i = 0; i < word.Length; i++)
                {
                    char curLetter = word[i];
                    if (node.containsKey(curLetter))
                    {
                        node = node.get(curLetter);
                    }
                    else
                    {
                        return null;
                    }
                }
                return node;
            }

            // Returns if the word is in the trie.
            public bool search(String word)
            {
                TrieNode node = searchPrefix(word);
                return node != null && node.isEnd;
            }

            public bool startsWith(String prefix)
            {
                TrieNode node = searchPrefix(prefix);
                return node != null;
            }

            //static void Main()
            //{
            //    // Setup trie
            //    Trie trie = new Trie();
            //    trie.insert("turn");
            //    trie.insert("tree");
            //    trie.insert("used");
            //    trie.insert("torn");
            //    trie.insert("cats");
            //    trie.insert("tots");
            //    trie.insert("very");

            //    // Setup input
            //    int input = 8733;
            //    var listWords = Solve(input, trie);

            //    // Print
            //    foreach (var item in listWords)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    Console.ReadLine();
            //}
        }
    }
}
