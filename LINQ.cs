//namespace algorithm
//{
//    internal class LINQ
//    {
//        int[] collection = new int[] { 1, 2, 3, 56, 5 };
//        // Certainly! Here are 50 LINQ query methods along with code examples for each of them.These examples assume you have a collection of objects(e.g., a list) to query.

//        //1. **Where** - Filters elements based on a condition.   
//        var result = collection.Where(item => item.Property == value);


//        //2. **Select** - Projects each element to a new form.   
//        var result = collection.Select(item => item.Property);


//        //3. **OrderBy** - Sorts elements in ascending order.
//        var result = collection.OrderBy(item => item.Property);


//        //4. **OrderByDescending** - Sorts elements in descending order.
//        var result = collection.OrderByDescending(item => item.Property);


//        //5. **ThenBy** - Secondary sorting for `OrderBy`.   
//        var result = collection.OrderBy(item => item.Property1).ThenBy(item => item.Property2);


//        //6. **ThenByDescending** - Secondary sorting for `OrderByDescending`.   
//        var result = collection.OrderByDescending(item => item.Property1).ThenByDescending(item => item.Property2);


//7. **GroupBy** - Groups elements based on a key.


//   var result = collection.GroupBy(item => item.Property);


//8. **Join** - Combines two collections based on a common attribute.


//   var result = collection1.Join(collection2, item1 => item1.Key, item2 => item2.Key, (item1, item2) => new { item1, item2 });


//9. **Concat** - Combines two collections.


//   var result = collection1.Concat(collection2);


//10. **Distinct** - Returns distinct elements from the collection.


//    var result = collection.Distinct();


//11. **Union** - Returns distinct elements from two collections.


//    var result = collection1.Union(collection2);


//12. **Intersect** - Returns common elements between two collections.


//    var result = collection1.Intersect(collection2);


//13. **Except** - Returns elements from the first collection that are not in the second collection.


//    var result = collection1.Except(collection2);


//14. **First** - Returns the first element that satisfies a condition.


//    var result = collection.First(item => item.Property == value);


//15. **FirstOrDefault** - Returns the first element or a default value if no element is found.


//    var result = collection.FirstOrDefault(item => item.Property == value);


//16. **Last** - Returns the last element that satisfies a condition.


//    var result = collection.Last(item => item.Property == value);


//17. **LastOrDefault** - Returns the last element or a default value if no element is found.


//    var result = collection.LastOrDefault(item => item.Property == value);


//18. **Single** - Returns the only element that satisfies a condition.


//    var result = collection.Single(item => item.Property == value);


//19. **SingleOrDefault** - Returns the only element or a default value if no or more than one element is found.


//    var result = collection.SingleOrDefault(item => item.Property == value);


//20. **Take** - Returns a specified number of elements.


//    var result = collection.Take(5);


//21. **Skip** - Skips a specified number of elements.


//    var result = collection.Skip(5);


//22. **SkipWhile** - Skips elements while a condition is true.



//    var result = collection.SkipWhile(item => item.Property == value);


//23. **TakeWhile** - Takes elements while a condition is true.



//    var result = collection.TakeWhile(item => item.Property == value);


//24. **Reverse** - Reverses the order of elements.


//    var result = collection.Reverse();


//25. **Any** - Checks if any element satisfies a condition.


//    var result = collection.Any(item => item.Property == value);


//26. **All** - Checks if all elements satisfy a condition.


//    var result = collection.All(item => item.Property == value);


//27. **Count** - Returns the number of elements.


//    var result = collection.Count();


//28. **Sum** - Calculates the sum of a numeric property.


//    var result = collection.Sum(item => item.Property);


//29. **Min** - Finds the minimum value of a numeric property.


//    var result = collection.Min(item => item.Property);


//30. **Max** - Finds the maximum value of a numeric property.


//    var result = collection.Max(item => item.Property);


//31. **Average** - Calculates the average of a numeric property.


//    var result = collection.Average(item => item.Property);


//32. **Aggregate** - Applies an aggregate function to the elements.


//    var result = collection.Aggregate((accumulator, item) => accumulator + item.Property);


//33. **Distinct** - Returns distinct elements based on a property.


//    var result = collection.DistinctBy(item => item.Property);


//34. **Any** - Checks if any element exists based on a property.


//    var result = collection.Any(item => item.Property == value);


//35. **All** - Checks if all elements satisfy a condition based on a property.


//    var result = collection.All(item => item.Property == value);


//36. **Count** - Returns the count of elements based on a property.


//    var result = collection.Count(item => item.Property == value);


//37. **SelectMany** - Flattens a nested collection.


//    var result = collection.SelectMany(item => item.NestedCollection);


//38. **OfType** - Filters elements of a specific type.


//    var result = collection.OfType<SomeType>();


//39. **Cast** - Casts elements to a specific type.


//    var result = collection.Cast<SomeType>();


//40. **Range** - Generates a sequence of integers.


//    var result = Enumerable.Range(1, 10);


//41. **Repeat** - Generates a repeated element.


//    var result = Enumerable.Repeat("Hello", 3);


//42. **ToDictionary** - Converts a collection to a dictionary.


//    var result = collection.ToDictionary(item => item.Key, item =>

// item.Value);


//43. **ToLookup** - Converts a collection to a lookup.


//    var result = collection.ToLookup(item => item.Key);


//44. **ToHashSet** - Converts a collection to a hash set.


//    var result = collection.ToHashSet();


//45. **Zip** - Combines two collections element-wise.


//    var result = collection1.Zip(collection2, (item1, item2) => new { Item1 = item1, Item2 = item2 });


//46. **DefaultIfEmpty** - Returns a default value if the collection is empty.


//    var result = collection.DefaultIfEmpty(defaultValue);


//47. **ExceptBy** - Returns elements from the first collection that are not in the second collection based on a property.


//    var result = collection1.ExceptBy(collection2, item => item.Property);


//48. **IntersectBy** - Returns common elements between two collections based on a property.


//    var result = collection1.IntersectBy(collection2, item => item.Property);


//49. **UnionBy** - Returns distinct elements from two collections based on a property.


//    var result = collection1.UnionBy(collection2, item => item.Property);


//50. **DistinctBy** - Returns distinct elements from a collection based on a property.


//    var result = collection.DistinctBy(item => item.Property);


//        These examples cover a wide range of LINQ methods, and you can combine them to create more complex queries as needed.LINQ is a powerful tool for querying and transforming data in C#, and understanding these methods will help you work with collections effectively.
//    }
//}
