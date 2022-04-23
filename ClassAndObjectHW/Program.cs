
using ClassAndObjectHW;

Phone phone = new Phone();

Console.WriteLine("Enter phone brand: ");
phone.Brand = Console.ReadLine();

Console.WriteLine("Enter phone model: ");
phone.Model = Console.ReadLine();

Console.WriteLine("Enter phone hight: ");
string hightTest = Console.ReadLine();
phone.Hight = int.Parse(hightTest);

Console.WriteLine("Enter phone length: ");
string lengthTest = Console.ReadLine();
phone.Length = int.Parse(lengthTest);

Console.WriteLine("Enter phone width: ");
string widthTest = Console.ReadLine();
phone.Width = int.Parse(widthTest);

phone.Calling();

phone.Messaging();


Console.WriteLine();
Console.WriteLine("==========================");
Console.WriteLine();

//2nd exercise


phone.Car = new Car();

Console.WriteLine("Enter Car brand: ");
phone.Car.CarBrand = Console.ReadLine();

Console.WriteLine("Enter Car number: ");
string carNumberText = Console.ReadLine();
phone.Car.CarNumber = int.Parse(carNumberText);

Console.WriteLine("Enter Car current speed: ");
string carSpeedText = Console.ReadLine();
phone.Car.CarSpeed = int.Parse(carSpeedText);

phone.Car.StartCar();
phone.Car.SppedUpF();
phone.Car.StopCar();

Console.WriteLine();
Console.WriteLine("==========================");
Console.WriteLine();

//3rd exercise

phone.Product = new Product(10, 15, 20);

phone.Product.ProductWeight = 3;

phone.Product.ProductSelection();
phone.Product.ProductSetUp();

Console.WriteLine();
Console.WriteLine("==========================");
Console.WriteLine();

//4th exercise

phone.Person = new Person();

Console.WriteLine("Please eneter your name:");
phone.Person.FirstName = Console.ReadLine();

Console.WriteLine("Please eneter your surname:");
phone.Person.LastName = Console.ReadLine();

Console.WriteLine("In what year you were born: ");
string yearString = Console.ReadLine();
phone.Person.Year = int.Parse(yearString);

Console.WriteLine("What is your hobby?");
phone.Person.Hobby = Console.ReadLine();

Console.WriteLine("Please eneter your gender:");
phone.Person.Gender = Console.ReadLine();

phone.Person.PersonGreeting();
phone.Person.PersonAge();

