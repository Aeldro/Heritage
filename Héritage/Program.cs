namespace Héritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Biped> bipeds = new List<Biped>();
            List<Quadruped> quadrupeds = new List<Quadruped>();

            bipeds.Add(new Human("Roberto"));
            bipeds.Add(new Monkey("Philippe"));

            quadrupeds.Add(new Elephant("Biguy"));
            quadrupeds.Add(new Turtle("Carapuce"));
            quadrupeds.Add(new Lizard("Salamèche"));

            bipeds[0].Move();
            bipeds[0].Eat();
            bipeds[1].Move();
            bipeds[1].Eat();

            quadrupeds[0].Move();
            quadrupeds[0].Eat();
            quadrupeds[1].Move();
            quadrupeds[1].Eat();
            quadrupeds[2].Move();
            quadrupeds[2].Eat();



        }
    }
}
