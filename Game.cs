

namespace Bossfight
{
    internal class Game
    {


        public void Run(GameCharacter hero, GameCharacter boss)
        {
            while (boss.Health > 0 && hero.Health > 0)
            {
                boss.Strength = randomNumber();
                if (hero.Stamina == 0)
                {
                    hero.Recharge(4);
                    Console.WriteLine("Out of stamina\n");
                    Pause();
                }
                else
                {
                    hero.Fight(hero, boss);
                    AttackBossText(hero, boss);
                    Pause();
                }
                
                if (boss.Stamina == 0)
                {
                    boss.Recharge(1);
                    Console.WriteLine("Boss is reloading\n");
                    Pause();
                }
                else
                {
                    hero.Fight(boss, hero);
                    RecieveDamageText(hero, boss);
                    Pause();
                }

            }
            Pause();
            CheckIfGameOver(hero, boss);
        }

        int randomNumber()
        {
            var rand = new Random();
            var BossStrength = rand.Next(0, 31);
            return BossStrength;
        }

        void Pause()
        {
            Thread.Sleep(1000);
        }
        

        private void CheckIfGameOver(GameCharacter hero, GameCharacter boss)
        {
            if (boss.Health <= 0)
            {
                Console.WriteLine("De gode vant!");
            }
            else if (hero.Health <= 0)
            {
                Console.WriteLine("Helten tapte, boo-fucking-hoo...");
            }
        }

        void AttackBossText(GameCharacter hero, GameCharacter boss)
        {
            Console.WriteLine($"Du denga bossen med {hero.Strength} damage, han har {boss.Health} HP igjen.\n");
        }

        void RecieveDamageText(GameCharacter hero, GameCharacter boss)
        {
            Console.WriteLine($"Bossen gjorde {boss.Strength} skade på helten, som har {hero.Health} igjen.\n");
        }



    }
}
