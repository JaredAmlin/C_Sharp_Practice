using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LINQ : MonoBehaviour
{
    public string[] names = { "Angela", "Jared", "Soli", "Michael", "Jon", "JoAnn" };
    public string[] duplicateNames = { "Name1", "Name1", "Name2", "Name3", "Name3", "Name4" };
    public int[] quizGrades = { 35, 98, 72, 85, 26, 100, 2 };

    //create array of int value quiz grades between 0 - 100
    //create new collection of only passing grades, above 69

    //check if item 3 exists and print out bool
    //print out all items with buff greater than 20
    //calculate average of buff stats

    public List<Item> linqItems;

    // Specify the data source.
    int[] scores = { 97, 92, 81, 60 };

// Start is called before the first frame update
void Start()
    {
        var nameFound = names.Any(name => name == "Jared");
        Debug.Log("name found is " + nameFound);

        var doesAngelaExist = names.Contains("Angela");
        Debug.Log("Angela Exists " + doesAngelaExist);

        var uniqueNames = duplicateNames.Distinct();
        foreach (var name in uniqueNames)
        {
            Debug.Log("Unique Names are " + name);
        }

        var longNames = names.Where(longName => longName.Length >= 5);
        foreach (var name in longNames)
        {
            Debug.Log("Long Names are " + name);
        }

        var shortNames = names.Where(shortNames => shortNames.Length < 5);
        foreach (var name in shortNames)
        {
            Debug.Log("Short Names are " + name);
        }

        var passingGrades = quizGrades.Where(passingGrades => passingGrades > 69);
        foreach (var grade in passingGrades)
        {
            Debug.Log("Passing Grades are " + grade);
        }

        var orderGrades = quizGrades.Where(orderGrades => orderGrades > 69).OrderByDescending(grade => grade).Reverse();
        foreach (var grade in orderGrades)
        {
            Debug.Log("Ordered Passing Grades are " + grade);
        }

        var failingGrades = quizGrades.Where(failingGrades => failingGrades <= 69);
        foreach (var grade in failingGrades)
        {
            Debug.Log("Failing Grades are " + grade);
        }

        var doesItem3Exist = linqItems.Any(linqItems => linqItems.itemID == 3);
        Debug.Log("Does Item 3 exist " + doesItem3Exist + " and the name is " + linqItems[2].itemName);

        var highBuffItems = linqItems.Where(linqItems => linqItems.buffValue > 20);
        foreach (var item in highBuffItems)
        {
            Debug.Log("The " + item.itemName + " is a high buff item. The Buff Value is " + item.buffValue);
        }

        var buffAverage = linqItems.Average(linqItems => linqItems.buffValue);
        Debug.Log("The buff value average is " + buffAverage);

        // Define the query expression.
        IEnumerable<int> scoreQuery =
            from score in scores
            where score > 80
            select score;

        var scoreQueryMethod = scores.Where(scores => scores > 80); 
        foreach (var score in scoreQueryMethod)
        {
            Debug.Log("Scores greater than 80 are " + score);
        }

        // Execute the query.
        foreach (int i in scoreQuery)
        {
            //Console.Write(i + " ");
        }

        // Output: 97 92 81

        foreach (string name in names)
        {
            if (name == "Jared")
            {
                Debug.Log("Jared exists!");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
