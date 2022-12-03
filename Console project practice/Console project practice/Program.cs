
using Console_project_practice.Controllers;
using ServiceLayer.Helpers;
using System;


LibraryController libraryController=new ();

while (true)
{
   

    ConsoleColor.Blue.writeConsole("Select one option:");

    
    ConsoleColor.Blue.writeConsole("Library options: 1-create,2-get by id, 3-Delete");
   SelectOption: string option =Console.ReadLine();

    int selectedoption;

    bool IsparseOption=int.TryParse(option, out selectedoption);

    if (IsparseOption)
    {
        switch (selectedoption)
        {
            case 1:
                libraryController.Create();
                break;
            case 2:
                libraryController.GetById();
                break;
            case 3:
                Console.WriteLine("Delete");
                break;
            default:
                Console.WriteLine("Select again true option");
                goto SelectOption;
              
        }
    }
    else
    {
        ConsoleColor.Red.writeConsole("Select again true option");
        goto SelectOption;
        
    }
}