
using PatikaWeek5PracticeClosure;

List<Car> cars = new List<Car>(); // Creating a new list    

bool isValidInput = false; // setting false for do-while loop



do // loop 
{

  FirstQuestion:

    Console.WriteLine("Araba üretmek ister misin?(e / h): "); // Asking user if she/he wants to create a car
    string firstAnswer = Console.ReadLine().ToLower().Trim();

    if (firstAnswer == "e") // Condition "e"
    {       

        Car newCar = new Car(); // Getting an instance of Car object

        Console.WriteLine("Arabanız markası ne olsun?"); // Setting properties by user
        newCar.Brand = Console.ReadLine();

        Console.WriteLine("Arabanın modeli ne olsun?");
        newCar.Model = Console.ReadLine();

        Console.WriteLine("Arabanız rengi ne olsun?");
        newCar.Colour = Console.ReadLine();

        Console.WriteLine("Arabanız için bir seri numarası giriniz.");
        newCar.SerialNumber = Convert.ToInt32(Console.ReadLine());


    GateQuestion: // If user answer is wrong formation 

        try // try block
        {
            Console.WriteLine("Arabanızın kapı sayısı kaç olsun?");
            newCar.GateCount = Convert.ToInt32(Console.ReadLine());
        }

        catch (FormatException ex) // Checking user answer formation
        {
            Console.WriteLine("Yanlış formatta veri girdiniz, lütfen tekrar deneyiniz");
            goto GateQuestion; // If user answer is wrong formation going to ask again
        }
        catch (GateCountException ex)
        {
            goto GateQuestion;
        }

        Console.WriteLine("Arabanız üretildi...");
        cars.Add(newCar); // Adding the car element to the list created before

    }
    else if (firstAnswer == "h") // If user answer is no the program will be shutdown
    {
        Console.WriteLine("Peki, program sonlandırılıyor...");
        break;
    }
    else
    {
        Console.WriteLine("Geçersiz bir cevap verdiniz, lütfen tekrar deneyiniz.");
        goto FirstQuestion;
    }

AnotherCar:

    Console.WriteLine("Başka bir araba daha üretmek ister misiniz?(e / h)");
    string secondAnswer = Console.ReadLine().ToLower().Trim();
    if (secondAnswer == "e")
    {
        isValidInput = true;
    }
    else if (secondAnswer == "h")
    {
        isValidInput = false;
    }
    else
    {
        Console.WriteLine("Yalnızca e veya h olarak cevaplayınız..");
        goto AnotherCar;
    }

} while (isValidInput);




foreach (var car in cars)
{
    Console.WriteLine("Ürettiğiniz arabalar şunlardır:");
    car.DisplayInfo();
}
