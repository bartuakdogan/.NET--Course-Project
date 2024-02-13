// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, Bartu!");

// string firstFriend = "       Bartu     ";
// firstFriend = firstFriend.Trim();

// string secondFriend = "      Melis     ";
// secondFriend = secondFriend.Trim();

// Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

// Console.WriteLine("My friends are " + firstFriend + " and " + secondFriend);  // same things


// string sayHello = "Hello World!";
// Console.WriteLine(sayHello);
// sayHello = sayHello.Replace("Hello", "Greetings");
// Console.WriteLine(sayHello);


// for loop

using System;
using Bartu_Workbench.DataAccess.Concretes;
using Bartu_Workbench.Entities;
using Bartu_Workbench.Operation_Methods;
using Bartu_Workbench.DataAccess.Concretes;

// string[] loans = {"Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6"};
//
// for (int i = 0; i < loans.Length; i++)
// {
//     Console.WriteLine(loans[i]);
// };


// Object Oriented Programming


CourseManager courseManager = new(new CourseDal());
List<Course> courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++)
{
     Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "56478965412";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "12345678987";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "654779";
customer4.TaxNumber = "12345678985";

                             //101      //102       //103       //104 --> reference num
BaseCustomer[] customers = {customer1, customer2, customer3, customer4};

// polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}

// individual olanların isimlerini yazdırdık!!!
foreach (BaseCustomer customer in customers)
{
    if (customer is IndividualCustomer)
    {
        Console.WriteLine(((IndividualCustomer)customer).FirstName);
    }
}

