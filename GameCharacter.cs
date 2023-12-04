
namespace Bossfight
{
    internal class GameCharacter
    {
        public string Name;
        public int Health;
        public int Strength;
        public int Stamina;

        public GameCharacter(string name, int health, int strength, int stamina)
        {
            Name = name;
            Health = health;
            Strength = strength;
            Stamina = stamina;
        }

        public void Fight(GameCharacter attacker, GameCharacter defender)
        {
            defender.Health -= attacker.Strength;
            attacker.Stamina -= 10;
        }

        public  void Recharge(int number)
        {
            Stamina += 10 * number;
        }
    }
}
