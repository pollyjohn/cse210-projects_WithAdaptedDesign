using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {   
        List<string> entriesW = new List<string>();
        
        string text = "";
        string dateText = "";   
        string choice;
        
        
        string[] lines = null;
       DateTime now = DateTime.Now;
       dateText = now.ToShortDateString();
       entriesW.Add(dateText);
       do{ do
        {
            
            Prompts question = new Prompts();
            Prompts prompts = new Prompts();
            Write write = new Write();
            choice = prompts.prompt();
            if(choice == "1")
            {
            question.question();
            text = write.write();
            entriesW.Add(text);
            }
        }while (choice == "1");
        
        if (choice == "2")
        {
            Save save = new Save();
            save.save(entriesW);
        }
        else if (choice == "3")
        {
            Read read = new Read();
            
            lines = read.read(entriesW);
        }
        else if (choice == "4")
        {   
        Display display = new Display();
        display.display(lines);}
    
    } while (choice != "5");    
    
}
}
/* Prompts prompt = new Prompts(); 
        prompt.question();
        Write write = new Write();
        (string text, string dateText) = write.write();
        Save save = new Save();
        save.save(text, dateText);
        Read read = new Read();
        string[] myFile = read.read();
        Display display = new Display();
        display.display(myFile);*/