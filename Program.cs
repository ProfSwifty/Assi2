using Assi2;
using System.Collections.Generic;
using System;

/*
 * Name: Logan McCallum Student Number: 1152955 Section: 2
 * Name: Spencer Martin Student Number: 1040415 Section: 2
 * Name: Ashley Burley-Denis Student Number: 0908968 Section: 1
 */

class Program
{
    static void Main(string[] args)
    {
        List<PostProxy> Posts = new List<PostProxy> { new PostProxy(0), new PostProxy(1), new PostProxy(2) };

        Console.WriteLine("Welcome to the Social Network!\nEnter a command to get started, or 'help' to see a list of commands:");
        string command = "";

        while (command != "quit")
        {
            command = Console.ReadLine();
            string[] commandArgs = command.Split(":");
            int postNum = -1;

            if (commandArgs.Length > 1 && int.TryParse(commandArgs[1], out postNum))
            {
                if (postNum < 0 || postNum >= Posts.Count)
                {
                    Console.WriteLine("Error: Invalid post number specified!");
                    continue;
                }
            }

            switch (commandArgs[0])
            {
                case "help":
                    Console.WriteLine("help\t\t\tDisplay this menu");
                    Console.WriteLine("new\t\t\tCreate a new post.");
                    Console.WriteLine("list\t\t\tList all posts.");
                    Console.WriteLine("download:[id]\t\tDownload a post.");
                    Console.WriteLine("settitle:[id]:[title]\tSet a post's title.");
                    Console.WriteLine("setbody:[id]:[body]\tSet a post's body.");
                    Console.WriteLine("view:[id]\t\tView a post.");
                    Console.WriteLine("quit\t\t\tQuit the application");
                    break;

                case "new":
                    var newPost = new PostProxy(Posts.Count);
                    newPost.InitializePost();
                    Posts.Add(newPost);
                    Console.WriteLine("New post created.");
                    break;

                case "list":
                    for (int i = 0; i < Posts.Count; i++)
                    {
                        Console.WriteLine($"Post {i}: {Posts[i].GetPrintableTitle()}");
                    }
                    break;

                case "download":
                    Posts[postNum].Download();
                    Console.WriteLine("Done.");
                    break;

                case "settitle":
                    if (commandArgs.Length < 3)
                    {
                        Console.WriteLine("Error: Missing title argument.");
                        break;
                    }
                    Posts[postNum].Download();
                    Posts[postNum].SetTitle(commandArgs[2]);
                    Console.WriteLine($"Title set for post {postNum}.");
                    break;

                case "setbody":
                    if (commandArgs.Length < 3)
                    {
                        Console.WriteLine("Error: Missing body argument.");
                        break;
                    }
                    Posts[postNum].Download();
                    Posts[postNum].SetBody(commandArgs[2]);
                    Console.WriteLine($"Body set for post {postNum}.");
                    break;

                case "view":
                    if (commandArgs.Length < 2)
                    {
                        Console.WriteLine("Error: No post number specified!");
                        break;
                    }
                    Posts[postNum].Print();
                    break;

                default:
                    if (!string.IsNullOrEmpty(command))
                    {
                        Console.WriteLine("Invalid command.");
                    }
                    break;
            }
        }
    }
}