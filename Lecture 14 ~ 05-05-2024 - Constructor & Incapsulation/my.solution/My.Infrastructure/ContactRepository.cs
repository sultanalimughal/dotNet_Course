﻿using DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace My.Infrastructure
{
	public struct ContactRepository
	{
		private readonly Contact[] _contacts;
		private int _arrayIndex;

		public ContactRepository()
		{
			_contacts = new Contact[100];
			_arrayIndex = 0;
		}
		public void ContactCreate()
		{
			Console.WriteLine("Please Enter Your Name");
			string NameS = Console.ReadLine();
			Console.WriteLine("Please Enter Your Email");
			string EmailS = Console.ReadLine();

			Contact contact = new Contact(NameS, EmailS)
			{
				Address = "abc",
				//Email = "qalb@gmail.com",
				//Name = "Qalb",
				Phone = "123"
			};
			_contacts[_arrayIndex] = contact;

			_arrayIndex++;

			Console.WriteLine("Contact Created");

		}

		//contact.Name = "";

		//contact.Email = "qalb123@gmail.com";

		//Console.WriteLine("Enter Name of Contact");
		//contact.Name = Console.ReadLine();
		//Console.WriteLine("Enter email of Contact");
		//contact.Email = Console.ReadLine();
		//Console.WriteLine("Enter Phone Number of Contact");
		//contact.Phone = Console.ReadLine();
		//Console.WriteLine("Enter Address of Contact");
		//contact.Address = Console.ReadLine();




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
	}
}
