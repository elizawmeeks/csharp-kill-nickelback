# csharp-kill-nickelback

NSS Exercise

## Instructions

1. Define a List, named ```goodSongs```, that will hold tuples consisting of two strings.

1. Define a HashSet, named allSongs, that contains 7 tuples. Each tuple should contain two string values:

```The name of an artist
A song by that artist
```

```chsarp
// Example
HashSet<(string, string)> songs = new HashSet<(string, string)>();
```
Make sure that some of the songs are from the band Nickelback. You can see a list of their greatest hits on Amazon.

1. Once the set is populated with 7 tuples, iterate over the set of songs, and check if the band name is "Nickelback".

1. If the band is not Nickelback, then add it to the ```goodSongs``` list.

1. Use another foreach loop to print out all the good songs.