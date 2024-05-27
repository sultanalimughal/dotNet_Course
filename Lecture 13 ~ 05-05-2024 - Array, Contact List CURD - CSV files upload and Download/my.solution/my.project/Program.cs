using DomainModels;
using Microsoft.VisualBasic;
using My.Infrastructure;
using System.Globalization;

Console.WriteLine("");


bool isTerminate = false;
ContactRepository contactRepository = new ContactRepository();
do
{

    Console.WriteLine("1) Create Contact 2) View Contacts 3) Search Contacts 4) Update Contact 5) Remove Contact 6) Download Contact 7) Upload Contact");

    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.Clear();
            contactRepository.ContactCreate();
            SendNotification("abc786", "Contact List Updated!");
            break;
        case "2":
            Console.Clear();
            contactRepository.ContactGetAll();
            SendNotification("abc786", "Viewing Contact List!");
            break;
        case "3":
            Console.Clear();
            contactRepository.ContactSearch();
            SendNotification("abc786", "Search Contact In List!");
            break;        
        case "4":
            contactRepository.UpdateContact();
            SendNotification("abc786", "Updated Contact List!");
            break;           
        //case "5":
        //    contactRepository.RemoveContact();
        //    SendNotification("abc786", "Remove Contact List!");
        //    break;        
        case "6":
            contactRepository.DownloadContact();
            SendNotification("abc786", "Download Contact List!");
            break;        
        case "7":
            contactRepository.UploadContact();
            SendNotification("abc786", "Updated Contact List!");
            break;
        default:
            break;
    }


} while (!isTerminate);


//Access Modifire 
//Return type 
//unique name 
//params
string SendNotification(string _deviceId , string _notification)
{
    // logic to send notificaition =
    return "Notificaiton Sent!";
}
