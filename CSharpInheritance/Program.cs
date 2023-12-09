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

            //A list of type List<int> initialized with some number
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            int[] numberArray = new int[] { 1, 7, 1, 3 };
            Console.WriteLine("");
            //Call collectionsum() and pass the list to it
            CollectionSum(numbers);
            Console.WriteLine("");
            CollectionSum(numberArray);
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
