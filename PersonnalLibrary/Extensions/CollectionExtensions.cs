using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public static class CollectionExtensions
{
    public static T GetRandom<T>(this T[] collection)
    {
        return collection[Random.Range(0, collection.Length)];
    }

    public static T GetRandom<T>(this IList<T> collection)
    {
        return collection[Random.Range(0, collection.Count)];
    }

    public static T GetRandom<T>(this IEnumerable<T> collection)
    {
        return collection.ElementAt(Random.Range(0, collection.Count()));
    }

    public static T[] GetRandoms<T>(this IList<T> collection, int amount)
    {
        if (amount > collection.Count)
        {
            Debug.LogError("GetRandomCollection Caused: source collection items count is less than randoms count");
            return null;
        }

        var randoms = new T[amount];
        var indexes = Enumerable.Range(0, amount).ToList();

        for (var i = 0; i < amount; i++)
        {
            var random = Random.Range(0, indexes.Count);
            randoms[i] = collection[random];
            indexes.RemoveAt(random);
        }

        return randoms;
    }

    public static bool IsNullOrEmpty<T>(this T[] collection)
    {
        if (collection == null) return true;

        return collection.Length == 0;
    }

    public static bool IsNullOrEmpty<T>(this IList<T> collection)
    {
        if (collection == null) return true;

        return collection.Count == 0;
    }

    public static bool IsNullOrEmpty<T>(this IEnumerable<T> collection)
    {
        if (collection == null) return true;

        return !collection.Any();
    }

    public static bool ContentsMatch<T>(this IEnumerable<T> first, IEnumerable<T> second)
    {
        if (first.IsNullOrEmpty() && second.IsNullOrEmpty()) return true;
        if (first.IsNullOrEmpty() || second.IsNullOrEmpty()) return false;

        var firstCount = first.Count();
        var secondCount = second.Count();
        if (firstCount != secondCount) return false;

        foreach (var x1 in first)
        {
            if (!second.Contains(x1)) return false;
        }

        return true;
    }

}
