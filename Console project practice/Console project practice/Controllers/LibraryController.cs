using Domain.Entities;
using ServiceLayer.Helpers;
using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_project_practice.Controllers
{
    public class LibraryController
    {
        public readonly LibraryService _libraryService;
        public LibraryController()
        {
            _libraryService=new LibraryService();
        }
        public void Create()
        {
            try
            {
                ConsoleColor.DarkMagenta.writeConsole("Add library name");

                string name = Console.ReadLine();

                ConsoleColor.DarkMagenta.writeConsole("Add library seat count");

            SeatCount: string seatCountStr = Console.ReadLine();

                int seatCount;

                bool isParseSeatCount = int.TryParse(seatCountStr, out seatCount);


                if (isParseSeatCount)
                {
                    Library library = new()
                    {
                        Name = name,
                        SeatCount = seatCount,
                    };

                    
                    var result = _libraryService.Create(library);
                    ConsoleColor.Green.writeConsole($"{result.Name} {result.SeatCount}");
                }
                else
                {
                    ConsoleColor.Red.writeConsole("please add correct seat count");
                    goto SeatCount;
                }
            }
            catch (Exception ex)
            {

                ConsoleColor.Red.writeConsole(ex.Message); 
            }
           
            
        }

        public void GetById()
        {
            try
            {

                ConsoleColor.DarkMagenta.writeConsole("Add library id:");

              Id: string idstr = Console.ReadLine();

                int id;

                bool isParseId=int.TryParse(idstr, out id);

                if (isParseId)
                {
                    var result=_libraryService.GetById(id);
                    if(result is null)
                    {
                        ConsoleColor.Red.writeConsole("Notfound,please try again");
                        goto Id;
                    }
                    ConsoleColor.Green.writeConsole($"{result.Name} {result.SeatCount}");

                }
                else
                {
                    ConsoleColor.Red.writeConsole("please add correct Id");
                    goto Id;
                }




            }
            catch (Exception ex)
            {
                ConsoleColor.Red.writeConsole(ex.Message;

            }
        }
    }
}
