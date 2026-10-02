using System;
using System.Collections;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // declare an empty courses array
        string[] courses = new string[0];
        // declare an empty list assignments
        List<string> assignments = new List<string>();
        // declare an empty dictionary assignmentDetails
        Dictionary<string, string> assignmentDetails = new Dictionary<string, string>();
        bool running = true;
        while (running)
        {
            // print main menu
            Console.WriteLine("\nASSIGNMENT TRACKER");
            Console.WriteLine("1. Create Course (Array)");
            Console.WriteLine("2. Update Course");
            Console.WriteLine("3. Add Assignment (List)");
            Console.WriteLine("4. Update Assignment");
            Console.WriteLine("5. Remove Assignment");
            Console.WriteLine("6. Add or Update Assignment Details (Dictionary)");
            Console.WriteLine("7. Remove Assignment by Name");
            Console.WriteLine("8. Exit ");
            Console.WriteLine("Please choose:");
            int choice = Convert.ToInt16(Console.ReadLine());
            if (choice == 1)
            {
               
                // Ask for the number of courses;
                Console.WriteLine("How many courses you are taking?");
                int numberOfCourses = Convert.ToInt16(Console.ReadLine());

                // create string[numberOfCourses];
                courses = new string[numberOfCourses];

                // use a for loop to capture each course name;
                for (int i = 0; i < courses.Length; i++)
                {
                    Console.Write($"Course {i}: ");
                    courses[i] = Console.ReadLine(); // value assignment
                }
                Console.WriteLine("\nCurrent Course Array:");
                // display index and value of the array.
                for (int i = 0; i < courses.Length; i++)
                {
                    Console.WriteLine($"Course {i}: {courses[i]}");
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Current Course Array: ");
                for (int i = 0; i < courses.Length; i++)
                {
                    Console.WriteLine($"Course {i}: {courses[i]}");
                }
                Console.WriteLine("Which course index do you want to update?");
                int courseIndex = Convert.ToInt16(Console.ReadLine());

                if(courseIndex >= 0 && courseIndex < courses.Length)
                {
                    Console.WriteLine("Enter the new course name:");
                    courses[courseIndex] = Console.ReadLine();

                    Console.WriteLine("Updated course array: ");

                    for (int i = 0; i < courses.Length; i++)
                    {
                        Console.WriteLine($"Course {i}: {courses[i]}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid course index.");
                }
            }
            else if (choice == 3)
            {
                // option 3 codes go here
                //Display current assignments.
                Console.WriteLine("\nCurrent assignment list:");
                if (assignments.Count == 0)
                {
                    Console.WriteLine("No assignment found.");
                }
                else
                {
                    for (int i = 0; i < assignments.Count; i++)
                    {
                        Console.WriteLine($"{i}: {assignments[i]}");
                    }
                }
                string enterMore = "y";
                while (enterMore == "y")
                {
                    //Repeatedly request a name and call Add()
                    //while the user enters y.
                    Console.WriteLine("Please enter an assignment name:");
                    string name = Console.ReadLine();
                    assignments.Add(name); // add to the list
                    Console.WriteLine("Do you want to add another assignment? (y/n):");
                    enterMore = Console.ReadLine().ToLower();
                }
                //Display the final List.
                Console.WriteLine("\nCurrent assignment list:");
                if (assignments.Count == 0)
                {
                    Console.WriteLine("No assignment found.");
                }
                else
                {
                    for (int i = 0; i < assignments.Count; i++)
                    {
                        Console.WriteLine($"{i}: {assignments[i]}");
                    }
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("Current assignment list: ");

                for (int i = 0; i < assignmentDetails.Count; i++)
                {
                    Console.WriteLine($"{i}: {assignments[i]}");
                }
                Console.WriteLine("Please enter the assignment index you want to update: ");
                int assignmentIndex = Convert.ToInt16(Console.ReadLine());
                if (assignmentIndex >= 0 && assignmentIndex < assignments.Count)
                {
                    string oldName = assignments[assignmentIndex];

                    Console.WriteLine("Please enter the new assignment name:");
                    string newName = Console.ReadLine();

                    assignments[assignmentIndex] = newName;
                    if(assignmentDetails.ContainsKey(oldName))
                    {
                        string oldDetails = assignmentDetails[oldName];
                        assignmentDetails.Remove(oldName);
                        assignmentDetails[newName] = oldDetails;
                    }
                    for (int i = 0; i < assignments.Count; i++)
                    {
                        Console.WriteLine($"{i}: {assignments[i]}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid assignment index."); 
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("Current assignment list: ");

                for (int i = 0; i < assignments.Count; i++)
                {
                    Console.WriteLine($"{i}: {assignments[i]}");
                }

                Console.WriteLine("Please enter the assignment index you want to remove:");
                int removeIndex = Convert.ToInt16(Console.ReadLine());

                if (removeIndex >= 0 && removeIndex < assignments.Count)
                {
                    assignments.RemoveAt(removeIndex);
                    Console.WriteLine("Updated assignment list:");

                    for (int i = 0; i < assignments.Count; i++)
                    {
                        Console.WriteLine($"{i}: {assignments[i]}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid assignment index.");
                }


            }
            else if (choice == 6)
            {
                //Display current details;
                Console.WriteLine("Current Dictionay:");
                foreach (KeyValuePair<string, string> item in assignmentDetails)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
                //request assignment name, description, and status;
                Console.WriteLine("Please enter assignment name (key):");
                string assignmentName = Console.ReadLine();
                Console.WriteLine("Please enter assignment description:");
                string description = Console.ReadLine();
                Console.WriteLine("Please enter assignment status:");
                string status = Console.ReadLine();
                //store description +" - " + status as value and
                string assignmentValue = description + " - " + status;
                //the assignment name as key;
                // add/update the dictionary
                assignmentDetails[assignmentName] = assignmentValue;
                // if assignmentName is existed in the dict: update the value
                // if assignmentName is NOT existed in the dict:
                // add the key-value pair into the dict.
                //display the updated assignment details.
                Console.WriteLine("The Updated Dictionay:");
                foreach (KeyValuePair<string, string> item in assignmentDetails)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            else if (choice == 7)
            {
                Console.WriteLine("Current assignment list:");

                for (int i = 0; i < assignments.Count; i++)
                {
                    Console.WriteLine($"{i}: {assignments[i]}");
                }

                Console.WriteLine("Please enter the assignment name you want to remove:");
                string removeName = Console.ReadLine();

                bool removed = assignments.Remove(removeName); 

                if (removed)
                {
                    Console.WriteLine("Assignment removed.");
                }
                else
                {
                    Console.WriteLine("Assignment not found");
                }

                Console.WriteLine("Updated assignment list: ");

                for (int i = 0; i < assignments.Count; i++)
                {
                    Console.WriteLine($"{i}: {assignments[i]}");
                }

                Console.WriteLine("Do you also want to remove it from the dictionary? (y/n):");
                string removeDictionary = Console.ReadLine().ToLower();

                if (removeDictionary == "y")
                {
                    Console.WriteLine("Please enter the assignment name:");
                    string keyToRemove = Console.ReadLine();

                    if (assignmentDetails.ContainsKey(keyToRemove))
                    {
                        assignmentDetails.Remove(keyToRemove);

                        Console.WriteLine("Dictionary entry removed.");
                    }
                    else
                    {
                        Console.WriteLine("Dictionary key not found.");
                    }

                    Console.WriteLine("Updated Dictionary:");

                    foreach (KeyValuePair<string, string> item in assignmentDetails)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }
                }
            }
            else if (choice == 8)
            {
                // option 8 codes go here
                Console.WriteLine("Good Work!");
                running = false;
            }
            else
            {
                // invalid choice message
                Console.WriteLine("Invalid choice. Please choose between 1-8.");
            }
        }
    }
}