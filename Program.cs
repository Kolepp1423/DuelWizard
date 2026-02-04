using DuelWizard;

namespace DuelWizard
{
    class Wizard
    {
        public string Name;
        public int Energy;
        public int Damage;

        public Wizard(string name, int damage)
        {
            Name = name;
            Energy = 100;
            Damage = damage;
        }

        public void Attack(Wizard enemy)
        {
            enemy.Energy -= Damage;

            if (enemy.Energy < 0)
            {
                enemy.Energy = 0;
            }

            Console.WriteLine($"{Name} menyerang {enemy.Name}");
            Console.WriteLine($"Energi {enemy.Name} tersisa: {enemy.Energy}");
            Console.WriteLine();
        }

        public void ShowStats()
        {
            Console.WriteLine($"Wizard: {Name} | Energy: {Energy}");
        }
    }
}

class Program
{
    static void Main()
    {
        Wizard wizard1 = new Wizard("Gandalf", 20);
        Wizard wizard2 = new Wizard("Saruman", 15);

        wizard1.ShowStats();
        wizard2.ShowStats();
        System.Console.WriteLine();

        wizard1.Attack(wizard2);
        wizard2.Attack(wizard1);
        wizard1.Attack(wizard2);

        wizard1.ShowStats();
        wizard2.ShowStats();

        System.Console.ReadLine();
    }
}