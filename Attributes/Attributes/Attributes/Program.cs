// C# program to display the custom attributes
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

// Defining a Custom attribute class
class NewAttribute : Attribute
{

	// Private fields
	private string title;
	private string description;

	// Parameterised Constructor
	public NewAttribute(string t, string d)
	{
		title = t;
		description = d;
	}

	// Method to show the Fields
	// of the NewAttribute
	// using reflection
	public static void AttributeDisplay(Type classType)
	{
		Console.WriteLine("Methods of class {0}", classType.Name);

		// Array to store all methods of a class
		// to which the attribute may be applied

		MethodInfo[] methods = classType.GetMethods();

		// for loop to read through all methods

		for (int i = 0; i < methods.GetLength(0); i++)
		{

			// Creating object array to receive
			// method attributes returned
			// by the GetCustomAttributes method

			object[] attributesArray = methods[i].GetCustomAttributes(true);

			// foreach loop to read through
			// all attributes of the method
			foreach (Attribute item in attributesArray)
			{
				if (item is NewAttribute)
				{

					// Display the fields of the NewAttribute
					NewAttribute attributeObject = (NewAttribute)item;
					Console.WriteLine("{0} - {1}, {2} ", methods[i].Name,
					attributeObject.title, attributeObject.description);
				}
			}
		}
	}
}

// Class Employer
class Employer
{

	// Fields of Employer
	int id;
	string name;

	// Constructor
	public Employer(int i, string n)
	{
		id = i;
		name = n;
	}

	// Applying the custom attribute
	// NewAttribute to the getId method
	[NewAttribute("Accessor", "Gives value of Employer Id")]
	public int getId()
	{
		return id;
	}

	// Applying the custom attribute
	// NewAttribute to the getName method
	[NewAttribute("Accessor", "Gives value of Employer Name")]
	public string getName()
	{
		return name;
	}
}

// Class Employee
class Employee
{

	// Fields of Employee
	int id;

	[sampleAttribute(Name = "property", Version = 1)]
	public string name { get; set; }

	public Employee(int i, string n)
	{
		id = i;
		name = n;
	}

	// Applying the custom
	// attribute NewAttribute
	// to the getId method
	[sampleAttribute(Name = "DD" , Version = 1)]
	[NewAttribute("Accessor", "Gives value of Employee Id")]
	public int getId()
	{
		return id;
	}

	// Applying the custom attribute
	// NewAttribute to the getName method
	[NewAttribute("Accessor", "Gives value of Employee Name")]
	public string getName()
	{
		return name;
	}
}



[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.All)]
public class sampleAttribute : Attribute
{
	public string Name { get; set; }
	public int Version { get; set; }

	public sampleAttribute()
    {
		
    }
}

[sample(Name = "FFF" , Version = 1)]
public class test
{

	public int IntValue { get; set; }
	public void MethodCustom() {	}

}
class Program
{

	// Main Method
	static void Main(string[] args)
	{

		// Calling the AttributeDisplay
		// method using the class name
		// since it is a static method
		NewAttribute.AttributeDisplay(typeof(Employer));
		Console.WriteLine();


		NewAttribute.AttributeDisplay(typeof(Employee));
		

		Type E =  typeof(Employee);
		MethodInfo[] methods = E.GetMethods();



		//-------------

		var types = from t in Assembly.GetExecutingAssembly().GetTypes()
					where t.GetCustomAttributes<sampleAttribute>().Count() > 0
					select t;
					

		foreach (var t in types)
        {
			Console.WriteLine(t.Name);
			Console.WriteLine(t.FullName);
			var s = t.GetMethods();


        }

		//

		sampleAttribute MyAttribute =
			(sampleAttribute)Attribute.GetCustomAttribute(typeof(test), typeof(sampleAttribute));

		MethodBase method = typeof(Employee).GetMethod("getId");


		var getSpecificMEthodAttribute  = method
				.GetCustomAttributes(true)
				.OfType<sampleAttribute>()
				.FirstOrDefault();


		var getSpecificPropertyAttribute = typeof(Employee)
					  .GetProperty("name")
					  .GetCustomAttributes(true)
					  .OfType<sampleAttribute>()
			          .FirstOrDefault();



		//--------------



		// Using GetType to obtain type information:
		int i = 42;
		Type type = i.GetType();
		Console.WriteLine(type);



		// Using Reflection to get information of an Assembly:
		Assembly info = typeof(int).Assembly;
		Console.WriteLine(info);
	}
}
