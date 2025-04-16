
namespace customTest
{
    public class Animal
    {
        public string name;
        private int age;
        public string category;
        public Animal()
        {
            this.name = "default";
            this.age = 0;
            this.category = "default";
        }
        public Animal(string name, int age, string category)
        {
            this.name = name;
            this.age = age;
            this.category = category;
        }
        public void Speak()
        {
            Console.WriteLine("I am an animal.My name is {0},My age is {1}.", name, age);
        }
        public void Eat()
        {
            Console.WriteLine("I am eating.");
        }
    }
}
