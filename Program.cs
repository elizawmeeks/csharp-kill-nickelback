using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {

            // Define a List, named goodSongs, that will hold tuples consisting of two strings.

            // Define a HashSet, named allSongs, that contains 7 tuples. Each tuple should contain two string values:

            // The name of an artist
            // A song by that artist
            // // Example
            // HashSet<(string, string)> songs = new HashSet<(string, string)>();
            // Make sure that some of the songs are from the band Nickelback. You can see a list of their greatest hits on Amazon.

            // Once the set is populated with 7 tuples, iterate over the set of songs, and check if the band name is "Nickelback".

            // If the band is not Nickelback, then add it to the goodSongs list.

            // USe another foreach loop to print out all the good songs.
            Console.WriteLine("Eliza!");
            List<Tuple<string, string>> goodSongs = new List<Tuple<string, string>>{};

            HashSet<Tuple<string, string>> songs = new HashSet<Tuple<string, string>>();
            var lostBoys = Tuple.Create("Lost Boys", "Ruth B");
            var aqua = Tuple.Create("Through an Aquarium", "Eliza Rickman");
            var talks = Tuple.Create("Little Talks", "Of MKonsters and Men");
            var ht = Tuple.Create("Heroes and Thieves", "Vanessa Carlton");
            var dr = Tuple.Create("Diamonds and Rust", "Blackmore's Night");
            var photo = Tuple.Create("Photograph", "Nickelback");
            var hyrm = Tuple.Create("How You Remind Me", "Nickelback");

            songs.Add(lostBoys);
            songs.Add(aqua);
            songs.Add(talks);
            songs.Add(ht);
            songs.Add(dr);
            songs.Add(photo);
            songs.Add(hyrm);

            foreach (Tuple<string, string> thing in songs){
                if (thing.Item2 != "Nickelback"){
                    goodSongs.Add(thing);
                }
            }

            foreach (Tuple<string, string> thing in goodSongs){
                Console.WriteLine($"{thing.Item1} by {thing.Item2}");
            }
            
        }
    }
}
