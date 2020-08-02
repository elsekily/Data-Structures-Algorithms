using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms
{
    public class Trie
    {
        private Node root;
        public Trie()
        {
            root = new Node(' ');
        }
        class Node
        {
            public char letter { get; set; }
            public Dictionary<char, Node> Children { get; set; }
            public bool EndOfWord { get; set; }
            public Node(char value)
            {
                letter = value;
                Children = new Dictionary<char, Node>();
            }
            public override string ToString()
            {
                return letter.ToString();
            }
        }
        public void Insert(string word)
        {
            var current = root;
            foreach (var letter in word)
            {
                if (!current.Children.ContainsKey(letter))
                    current.Children.Add(letter, new Node(letter));

                current = current.Children.GetValueOrDefault(letter);
            }
            current.EndOfWord = true;
        }
        public bool Contains(string word)
        {
            if (word == null)
                return false;
            var current = root;
            foreach (var letter in word)
            {
                if (!current.Children.ContainsKey(letter))
                    return false;

                current = current.Children.GetValueOrDefault(letter);
            }
            if (!current.EndOfWord)
                return false;

            return true;
        }

        public void Delete(string word)
        {
            if (word == null)
                return;
            DeleteNode(root, word, 0);
        }
        private void DeleteNode(Node node, string word, int index)
        {
            if (index == word.Length)
            {
                node.EndOfWord = false;
                return;
            }

            try
            {
                var child = node.Children.GetValueOrDefault(word[index]);

                DeleteNode(child, word, index + 1);

                if (child.Children.Count == 0)
                    node.Children.Remove(word[index]);
            }
            catch (Exception)
            {
                Console.WriteLine("Not Found");
            }
        }

        public List<string> AutoComplete(string prefix)
        {
            var current = root;
            foreach (var letter in prefix)
                current = current.Children.GetValueOrDefault(letter);

            var words = new List<string>();
            PrintChildern(current, words, prefix);
            return words;
        }
        private void PrintChildern(Node node, List<string> words, string word)
        {
            if (node.EndOfWord)
                words.Add(word);
            foreach (var child in node.Children)
                PrintChildern(child.Value, words, word + child.Value.letter);
        }
    }
}
