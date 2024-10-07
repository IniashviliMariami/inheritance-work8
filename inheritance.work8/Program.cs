namespace inheritance.work8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new("mari", 100, 500, 20);
            Hero secondHero = new("nino", 100, 300, 15);
            Villan villan = new("nia", 100, 500, 50);
           

            villan.Attack(hero);
            Console.WriteLine($"The villain attacked the hero. helth is: {hero.Health}");
            Console.WriteLine();
            secondHero.Attack(villan);
            Console.WriteLine($"The second hero attacked the villan. helth is:  {villan.Health}");
            Console.WriteLine();
            villan.Attack(secondHero);
            Console.WriteLine($"The villain attacked the second hero. helth is:  {secondHero.Health}");
            Console.WriteLine();
            hero.Help(secondHero);
            Console.WriteLine($"Mari helped nino. {hero.Name} -{hero.LightAbility}({hero.Health}), {secondHero.Name} +{hero.LightAbility}({secondHero.Health})");
            Console.WriteLine();
            secondHero.Help(hero);
            Console.WriteLine($"nino helped mari. {secondHero.Name}-{secondHero.LightAbility}({secondHero.Health}), {hero.Name} +{secondHero.LightAbility}({hero.Health})");
        }
    }
}
