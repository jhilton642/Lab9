using System;
using System.IO;
namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName;
            string command;
            while (true)
            {
                command = Utils.GetInput("enter a command: read, write, or exit: ");
                command = command.ToLower();
                if (command == "write")
                {
                    fileName = Utils.GetInput("enter a file name: ");
                    WriteFile(fileName);
                }
                if (command == "read")
                {
                    fileName = Utils.GetInput("enter a file name: ");
                    ReadFile(fileName);
                }
                if(command == "exit")
                {
                    return;
                }
            }

        }
        static void WriteFile(string fileName)
        {
            //Instantiate a FileStream that will open a file named by the user 
            FileStream stream = new FileStream("C:/Projects/csv/" + fileName, FileMode.Append, FileAccess.Write);
            StreamWriter textFile = new StreamWriter(stream);

            string userInput;
    Console.Write("Enter Text: ");
            userInput = Console.ReadLine();

            //input loop
            while (userInput.Length != 0)
            {
                textFile.WriteLine(userInput);
                userInput = Console.ReadLine();
            }
            textFile.Close();
        } //end WriteFile()
        static void ReadFile(string fileName)
        {
            string line;

            //Instantiate a FileStream that will open a file named by the user 
            FileStream stream = new FileStream("C:/Projects/csv/" + fileName, FileMode.Open, FileAccess.Read);
            StreamReader textFile = new StreamReader(stream);

            // read loop
            while ((line = textFile.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            textFile.Close();
        } //end ReadFile()
    }
}
