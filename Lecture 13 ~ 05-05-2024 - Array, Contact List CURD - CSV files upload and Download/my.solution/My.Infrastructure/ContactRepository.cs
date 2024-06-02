using DomainModels;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace My.Infrastructure
{
	public struct ContactRepository
	{
		private readonly Contact[] _contacts; // intilize
		private int _arrayIndex;

		public ContactRepository()
		{
			_contacts = new Contact[100]; // define 
			_arrayIndex = 0;
		}
		public void ContactCreate()
		{
			Contact contact = new Contact();

			Console.WriteLine("Enter Name of Contact");
			contact.Name = Console.ReadLine();
			Console.WriteLine("Enter email of Contact");
			contact.Email = Console.ReadLine();
			Console.WriteLine("Enter Phone Number of Contact");
			contact.Phone = Console.ReadLine();
			Console.WriteLine("Enter Address of Contact");
			contact.Address = Console.ReadLine();

			_contacts[_arrayIndex] = contact;

			_arrayIndex++;

			Console.WriteLine("Contact Created");

		}
		public void ContactGetAll()
		{
			if (_arrayIndex > 0)
			{
				for (int i = 0; i < _arrayIndex; i++)
				{
					Console.WriteLine($@"---------- Value at {i + 1} ------------------");
					Console.WriteLine($@"Name : {_contacts[i].Name} , Email : {_contacts[i].Email} , Phone : {_contacts[i].Phone} , Address : {_contacts[i].Address}");
					Console.WriteLine("------------------------------------------------");
				}
			}
			else
			{
				Console.WriteLine("no Contact found");
			}
		}
		public void ContactSearch()
		{
			Console.WriteLine("Enter Search Term!");
			var SearchIndex = -1;
			var input = Console.ReadLine();
			if (_arrayIndex > 0)
			{
				for (int i = 0; i < _arrayIndex; i++)
				{
					if (_contacts[i].Name.ToLower().Contains(input.ToLower()))
					{
						SearchIndex = i;
						break;
					}
				}
				if (SearchIndex > -1)
				{
					Console.WriteLine($@"Name : {_contacts[SearchIndex].Name} , Email : {_contacts[SearchIndex].Email} , Phone : {_contacts[SearchIndex].Phone} , Address : {_contacts[SearchIndex].Address}");

				}
				else
				{
					Console.WriteLine("No Contact Found!");
				}
			}
			else
			{
				Console.WriteLine("no Contact found");
			}
		}

		public void UpdateContact()
		{
			Console.WriteLine("Please enter record id");
			int input = int.Parse(Console.ReadLine());
			if (input != null && input < _contacts.Length && Array.IndexOf(_contacts, input) > -1)
			{
				var rselt = _contacts[input];
				Console.WriteLine("Please Update Name");
				rselt.Name = Console.ReadLine();
				Console.WriteLine("Please Update Email");
				rselt.Email = Console.ReadLine();
				Console.WriteLine("Please Update Address");
				rselt.Address = Console.ReadLine();
				Console.WriteLine("Please Update Phone");
				rselt.Phone = Console.ReadLine();

				_contacts[input] = rselt;
			}
			else
			{
				Console.WriteLine("Enter Valid Record");
			}
		}

		//public void RemoveContact()
		//{
		//	Console.WriteLine("Please enter record id");
		//	int input;
		//	if (int.TryParse(Console.ReadLine(), out input)) // Check if the input is a valid integer
		//	{
		//		if (input >= 0 && input < _contacts.Length) // Check if the input is within the array bounds
		//		{
		//			if (_contacts[input] != null) // Check if the element at the specified index is not null
		//			{
		//				_contacts[input] = null; // Set the element at the specified index to null to "remove" it
		//				Console.WriteLine("Contact removed from index " + input);
		//			}
		//			else
		//			{
		//				Console.WriteLine("No contact found at index " + input);
		//			}
		//		}
		//		else
		//		{
		//			Console.WriteLine("Invalid index: " + input);
		//		}
		//	}
		//	else
		//	{
		//		Console.WriteLine("Invalid input. Please enter a valid integer.");
		//	}
		//}


		//public void RemoveContact()
		//{
		//	Console.WriteLine("Please enter record id");
		//	int input = int.Parse(Console.ReadLine());
		//	if (input != null && input < _contacts.Length && Array.IndexOf(_contacts, input) > -1)
		//	{
		//		_contacts[input] = default(Contact);
		//		var rselt = _contacts[input];


		//		_contacts[input] = rselt;

		//		Console.WriteLine("Contact removed from index " + input);
		//	}

		//	else
		//	{
		//		Console.WriteLine("Invalid index: " + input);
		//	}


		// Check if the index is within the bounds of the array

		// Empty the index by assigning default value or null
		// For reference types
		// Or: _contacts[index] = null; // For reference types

		// Optionally, you can shift the elements after the removed index
		// Example of shifting elements:
		// Array.Copy(_contacts, index + 1, _contacts, index, _contacts.Length - index - 1);





		public void DownloadContact()
		{
			if (_arrayIndex > 0)
			{
				//File Path 
				string filePath = @$"C:\Users\Sultan Ali\Downloads\array_data.csv";

				// Create or overwrite the file
				using (StreamWriter writer = new StreamWriter(filePath))
				{
					// Write the CSV headers
					writer.WriteLine("Name,Email,Address,Phone");

					// Write each contact's data in the CSV format
					for (int j = 0; j < _arrayIndex; j++)
					{
						var contact = _contacts[j];
						var data = $"{contact.Name},{contact.Email},{contact.Address},{contact.Phone}";
						writer.WriteLine(data);
					}
					Console.WriteLine("CSV file created successfully.");
				}
			}
			else
			{
				Console.WriteLine("Empty Array found");
			}
		}
		public void UploadContact()
		{
			string filePath = @"C:\Users\Sultan Ali\Downloads\array_load.csv";

			// Check if the file exists
			if (File.Exists(filePath))
			{
				// Open the file for reading
				using (StreamReader reader = new StreamReader(filePath))
				{
					// Skip the header line
					reader.ReadLine();

					// Read each line from the file
					while (!reader.EndOfStream)
					{
						// Read the line
						string line = reader.ReadLine();

						// Split the line into fields
						string[] fields = line.Split(',');

						// Extract contact information from fields
						string name = fields[0];
						string email = fields[1];
						string address = fields[2];
						string phone = fields[3];

						// Create a new contact object and add it to the collection
						Contact contact = new Contact { Name = name, Email = email, Address = address, Phone = phone };
						_contacts[_arrayIndex] = contact;

						// Increment the array index
						_arrayIndex++;
					}
				}

				Console.WriteLine("CSV file uploaded successfully.");
			}
			else
			{
				Console.WriteLine("File not found: " + filePath);
			}
		}

		public void RemoveContact(int v, object arrayIndex)
		{
			throw new NotImplementedException();
		}



		//public void UploadContact()
		//{
		//	string filePath = @"C:\Users\Sultan Ali\Downloads\array_load.csv";

		//	// Create or overwrite the file
		//	using (StreamReader Reader = new StreamReader(filePath))
		//	{
		//		// Write the CSV headers
		//		Reader.ReadLine();

		//		// Write each contact's data in the CSV format
		//		//for (int j = 0; j < _arrayIndex; j++)
		//		//{
		//		var contact = _contacts;
		//		var data = _arrayIndex;
		//		Reader.ReadLine();
		//	}
		//	Console.WriteLine("CSV file uplaod successfully.");
		//}
	}
}



//	public void DownloadContat()
//	{
//		if (_contacts.Length > -1 && _arrayIndex > -1)
//		{
//			var rselt = _contacts[_arrayIndex];
//			// File path to save the CSV file
//			string filePath = @"C:\\Users\\Sultan Ali\\Downloads\array_data.csv";

//			// Create or overwrite the file
//			using (StreamWriter writer = new StreamWriter(filePath))

//				foreach (var rselts in _contacts)
//				{

//					_contacts[_arrayIndex] = rselt;
//					writer.WriteLine(rselts);
//				}
//			Console.WriteLine("CSV file created successfully.");
//		}
//		else
//		{
//			Console.WriteLine("Array is Empty");
//		}
//		// Write each element in the array to the CSV file

//	}


//}


//public void DeletContact()
//{
//	Console.WriteLine("Please enter record id");
//	int input = int.Parse(Console.ReadLine());
//	if (input != null && input < _contacts.Length && Array.IndexOf(_contacts, input) > -1)
//	{
//		var result = RemoveAt(_contacts, input) ;

//		//_contacts = result;


//	}




//Download XML File
//public void DownloadContact()
//{
//    // Example of downloading contacts
//    Contact newContact = new Contact { Name = "John Doe", Email = "john@example.com", Phone = "03125689", Address = "ABC" };
//    Contact.Add(new Contact);
//    WriteContactsToXml("contacts.xml", Contact);
//}
//static void WriteContactsToXml(string filename, List<Contact> contacts)
//{
//    XmlSerializer serializer = new XmlSerializer(typeof(List<Contact>));
//    using (TextWriter writer = new StreamWriter(filename))
//    {
//        serializer.Serialize(writer, contacts);
//    }
//}

//     public void DeleteContact()
//     {
//Console.WriteLine("Enter Search Term!");
//var SearchIndex = -1;
//var input = Console.ReadLine();
//if (_arrayIndex > 0)
//         {

//}
//     }





//public  T[] RemoveAt<T>(this T[] source, int index)
//{
//	T[] dest = new T[source.Length - 1];
//	if (index > 0)
//		Array.Copy(source, 0, dest, 0, index);

//	if (index < source.Length - 1)
//		Array.Copy(source, index + 1, dest, index, source.Length - index - 1);

//	return dest;
//}
