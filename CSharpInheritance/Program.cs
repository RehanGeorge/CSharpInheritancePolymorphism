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

            VideoPost videoPost1 = new VideoPost("My video", "John Doe", "https://videos.com/myvideo", true, 10);
            Console.WriteLine(videoPost1.ToString());
            videoPost1.Play();
            Console.ReadKey();
            videoPost1.Stop();
        }
    }
}
