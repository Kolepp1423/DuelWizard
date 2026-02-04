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