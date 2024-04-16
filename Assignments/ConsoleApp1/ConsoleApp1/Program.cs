using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{

			//employ
			Employ obj = new Employ();

			obj.name = "Imran";
			obj.contact = "+12345";
			obj.email = "imran@gmail.com";
			obj.salary = "1200000";

			Console.WriteLine("Name	" + obj.name);
			Console.WriteLine("Contact " + obj.contact);
			Console.WriteLine("Email " + obj.email);
			Console.WriteLine("Salary " + obj.salary);

		
			//Player
			Player objj = new Player();

			objj.name  = "Babar Azam";
			objj.Shirtnumber  = "56";
			objj.type  = "Batsmen";
			objj.salary = "6200000";

			Console.WriteLine("Name	" + objj.name);   
			Console.WriteLine("Shirt Number" + objj.Shirtnumber);
			Console.WriteLine("Type " + objj.type);
			Console.WriteLine("Salary "+ objj.salary);

			Console.ReadKey();




		}
	}
}
