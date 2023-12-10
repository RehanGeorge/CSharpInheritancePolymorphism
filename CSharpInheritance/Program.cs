namespace CSharpInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Radio myRadio = new Radio(true, "Sony");
            myRadio.ListenToRadio();

            TV myTV = new TV(false, "Samsung");
            myTV.WatchTV();
            myTV.SwitchOn();
            myTV.WatchTV();
            */

            /*
            Dog myDog = new Dog("Fido", 3, true);
            myDog.MakeSound();
            myDog.Eat();
            myDog.Play();
            */

            /*
            Post post1 = new Post("Thanks for the birthday wishes", true, "John Doe");
            Console.WriteLine(post1.ToString());
            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "John Doe", "https://images.com/shoes", true);
            Console.WriteLine(imagePost1.ToString());
            */

            /*
            VideoPost videoPost1 = new VideoPost("My video", "John Doe", "https://videos.com/myvideo", true, 10);
            Console.WriteLine(videoPost1.ToString());
            videoPost1.Play();
            Console.ReadKey();
            videoPost1.Stop();
            */

            /*
            Employee employee1 = new Employee("John", "Doe", 2000);
            Boss boss1 = new Boss("Jane", "Doe", 4000, "BMW");
            Trainees trainee1 = new Trainees("Max", "Mustermann", 1000, 10, 5);
            employee1.Work();
            boss1.Work();
            boss1.Lead();
            trainee1.Work();
            trainee1.Learn();
            */

            /*
            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(10);
            Console.WriteLine(t2.Equals(t1));
            */

            /*
            //Creating two objects of type chair
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            //Creating a new object of type car
            Car damagedCar = new Car(80f, "Blue");

            //Adding the two chairs to the list of destroyables
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            damagedCar.Destroy();
            */

            /*
            DogShelter shelter = new DogShelter();

            foreach (DogEnumeratorExample dog in shelter)
            {
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }
            */

            /*
            //A list of type List<int> initialized with some number
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            int[] numberArray = new int[] { 1, 7, 1, 3 };
            Console.WriteLine("");
            //Call collectionsum() and pass the list to it
            CollectionSum(numbers);
            Console.WriteLine("");
            CollectionSum(numberArray);
            */

            /*
            CarPoly myCar = new CarPoly(200, "Red");
            myCar.ShowDetails();
            myCar.Repair();

            BMWPoly myBMW = new BMWPoly(200, "Blue", "M3");
            myBMW.ShowDetails();
            myBMW.Repair();

            AudiPoly myAudi = new AudiPoly(200, "Green", "A4");
            myAudi.ShowDetails();
            myAudi.Repair();
            */

            /*
            var cars = new List<CarPoly>
            {
                new AudiPoly(200, "Green", "A4"),
                new BMWPoly(200, "Blue", "M3"),
            };

            foreach (var car in cars)
            {
                car.ShowDetails();
                car.Repair();
            }

            M3 myM3 = new M3(200, "Blue", "M3");
            //myM3.Repair();
            CarPoly myCarPoly = new CarPoly(200, "Red");

            myM3.SetCarIDInfo(1234, "Rehan George");
            myM3.GetCarIDInfo();
            myCarPoly.SetCarIDInfo(1235, "Rehan George");
            myCarPoly.GetCarIDInfo();
            */

            /*
            Shape[] shapes = { new Cube(3), new Sphere(5) };

            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine($"{shape.Name}: Volume is {shape.Volume()}");

                Cube iceCube = shape as Cube;
                if (iceCube == null)
                {
                    Console.WriteLine("This shape is not a cube");
                }

                if (shape is Cube)
                {
                    Console.WriteLine("This shape is a cube");
                }

                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;

                Console.WriteLine($"{cube2.Name}: Volume is {cube2.Volume()}");
            }
            */

            //Read and Write to a file
            /*
            string text = System.IO.File.ReadAllText(@"C:\Users\Rehan George\source\repos\CSharpInheritance\ReadFile.txt");
            Console.WriteLine(text);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Rehan George\source\repos\CSharpInheritance\ReadFile.txt");
            
            foreach(string line in lines)
            {
                Console.WriteLine($"\t{line}");
            }
            */

            /*
            //Method 1
            string[] lines = { "First 250", "Second 242", "Third 240" };
            string[] highScores = { "15", "30", "60" };

            File.WriteAllLines(@"C:\Users\Rehan George\source\repos\CSharpInheritance\ReadFile.txt", highScores);

            //Method 2
            Console.WriteLine("What is the File Name?");
            string fileName = Console.ReadLine();
            Console.WriteLine("What is the score?");
            string input = Console.ReadLine();

            File.WriteAllText($@"C:\Users\Rehan George\source\repos\CSharpInheritance\{fileName}.txt", input);

            //Method 3
            using (StreamWriter file = new StreamWriter(@"C:\Users\Rehan George\source\repos\CSharpInheritance\myText.txt"))
            {
                foreach (string line in lines)
                {
                    if(line.Contains("2"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(@"C:\Users\Rehan George\source\repos\CSharpInheritance\myText.txt", true))
            {
                file.WriteLine("Additional Line");
            }
            */

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Rehan George\source\repos\CSharpInheritance\input.txt");
            foreach (string line in lines)
            {
                if (line.Contains("split"))
                {
                    string[] strings = line.Split(" ");
                    Console.WriteLine(strings[4]);
                }
            }    

        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            //sum variable to store the sum of the numbers in the collection
            int sum = 0;

            //iterate through the collection and add each number to the sum
            foreach (int num in anyCollection)
            {
                sum += num;
            }

            //print the sum to the console
            Console.WriteLine($"The sum of the collection is {sum}");
        }
    }
}
