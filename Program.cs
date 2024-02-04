using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a dictionary
        Dictionary<int, string> myDictionary = new Dictionary<int, string>();

        // Adding key-value pairs
        myDictionary.Add(1, "One");
        myDictionary.Add(2, "Two");
        myDictionary[3] = "Three"; // Another way to add key-value pairs

        // Accessing values using keys
        Console.WriteLine("Value at key 1: " + myDictionary[1]);

        // Checking if a key exists
        if (myDictionary.ContainsKey(2))
        {
            Console.WriteLine("Key 2 exists.");
        }

        // Removing a key-value pair
        myDictionary.Remove(3);

        // Iterating through key-value pairs
        foreach (var kvp in myDictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        // Clearing the dictionary
        myDictionary.Clear();

        // Checking if the dictionary is empty
        Console.WriteLine("Is the dictionary empty? " + (myDictionary.Count == 0));
    }
}
