using System;
using System.Collections.Generic;

namespace Assignment
{
    class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }

    }
    class Program
    {
        static List<Task> taskList = new List<Task>();
        static void Main()
        {
            bool exit = false;
            while(exit==false)
            {
                Console.WriteLine("Task Operations to Select:");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1. Creat a Task");
                Console.WriteLine("2. Read  Tasks");
                Console.WriteLine("3. Update a Task");
                Console.WriteLine("4. Delete a Task");
                Console.WriteLine("5. Exit!");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Enter Your Option :");
                try
                {
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:                          
                            Console.WriteLine("Please enter Number Of  tasks You wanted to insert :");

                            int num = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < num; i++)
                            {
                                CreateTask();
                            }
                            Console.WriteLine();
                            break;
                        case 2:
                          
                            ReadTasks();
                            Console.WriteLine();
                            break;
                        case 3:                          
                            
                            UpdateTask();
                            Console.WriteLine();
                            break;
                        case 4:                           
                            
                            DeleteTask();
                            break;
                        case 5:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice! Please try again.");
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message + " Please choose Correct Option");
                }

            }
        }
        static void CreateTask()
        {
            Task newTask = new Task();
            Console.WriteLine("Enter task title:");
            newTask.Title = Console.ReadLine();
            Console.WriteLine("Enter task description:");
            newTask.Description = Console.ReadLine();
            taskList.Add(newTask);
            Console.WriteLine("Task created successfully!");
        }

        static void ReadTasks()
        {
            if (taskList.Count == 0)
            {
                Console.WriteLine("No tasks available.");
            }
            else
            {
                Console.WriteLine("Tasks:");
                Console.WriteLine("Here the Total Available Tasks in The Application ");
                Console.WriteLine();
                foreach (var task in taskList)
                {
             
                    Console.WriteLine("Title :" + task.Title);
                    Console.WriteLine();

                    Console.WriteLine("Description :" + task.Description);
                    Console.WriteLine();
                    Console.WriteLine("");
                }
            }
        }

        static void UpdateTask()
        {

            Console.WriteLine("Enter the title of the task to update:");
            string title = Console.ReadLine();
            Task taskToUpdate = taskList.Find(task => task.Title == title);

            if (taskToUpdate != null)
            {
                Console.WriteLine("Enter new title ( Or leave blank to keep current):");
                string newTitle = Console.ReadLine();
                if (!string.IsNullOrEmpty(newTitle))
                {
                    taskToUpdate.Title = newTitle;
                }

                Console.WriteLine("Enter new description ( Or leave blank to keep current):");
                string newDescription = Console.ReadLine();
                if (!string.IsNullOrEmpty(newDescription))
                {
                    taskToUpdate.Description = newDescription;
                }

                Console.WriteLine("Task updated successfully!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Task not found!");
                Console.WriteLine();
            }
        }

        static void DeleteTask()
        {
            Console.WriteLine("Enter the title of the task to delete:");
            string title = Console.ReadLine();
            Task taskToDelete = taskList.Find(task => task.Title == title);
            if (taskToDelete != null)
            {
                taskList.Remove(taskToDelete);
                Console.WriteLine("Task deleted successfully!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Task not found!");
                Console.WriteLine();
            }
        }
    }
}

    

  
