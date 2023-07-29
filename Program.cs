using System;


namespace New_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double characterFraction, characterHealth, characterArmor, characterDamage, enemyFraction, evilEnemyArmor, evilEnemyHealth, evilEnemyDamage, direEnemyArmor, direEnemyHealth, direEnemyDamage, neutralEnemyArmor, neutralEnemyDamage, neutralEnemyHealth;
            string info;
            bool berserkMod;


            #region direEnemy
            direEnemyArmor = 70;
            direEnemyDamage = 15;
            direEnemyHealth = 150;
            #endregion

            #region evilEnemy
            evilEnemyArmor = 25;
            evilEnemyDamage = 75;
            evilEnemyHealth = 80;
            #endregion

            #region neutralEnemy
            neutralEnemyArmor = 35;
            neutralEnemyDamage = 45;
            neutralEnemyHealth = 100;
            #endregion

            do
            {
                Console.Write("Введите начальное значение вашего урона ");
                info = Console.ReadLine();

            } while (double.TryParse(info, out characterDamage) == false);

            Console.WriteLine("Прекрасно");


            do
            {
                Console.Write("Введите начальное значение вашей защиты ");
                info = Console.ReadLine();

            } while (double.TryParse(info, out characterArmor) == false);


            do
            {
                Console.Write("Введите начальное значение вашего здоровья ");
                info = Console.ReadLine();

            } while (double.TryParse(info, out characterHealth) == false);


            do
            {

                Console.WriteLine();
                Console.WriteLine("Ваши фракции");
                Console.WriteLine();
                Console.WriteLine("1 - Добро (* ^ ω ^)");
                Console.WriteLine("2 - Зло ╭[☉﹏☉]╮");
                Console.WriteLine("3 - Нейтралитет (─‿‿─)♡");
                Console.Write("Выберете фракцию ");
                info = Console.ReadLine();

            } while (double.TryParse(info, out characterFraction) == false);

            Console.WriteLine("Прекрасно");


            do
            {
                Console.WriteLine("Прекрасно");

                Console.WriteLine();
                Console.WriteLine("Фракции противников");
                Console.WriteLine();
                Console.WriteLine("1 - Добро (* ^ ω ^)");
                Console.WriteLine("2 - Зло ╭[☉﹏☉]╮");
                Console.WriteLine("3 - Нейтралитет (─‿‿─)♡");
                Console.Write("Выберете фракцию притивников ");
                info = Console.ReadLine();

            } while (double.TryParse(info, out enemyFraction) == false);

            double enemyDamage = 0.0, enemyArmor = 0.0, enemyHealth = 0.0;

            switch (enemyFraction)
            {
                case 2.0:
                    enemyDamage = evilEnemyDamage;
                    enemyArmor = evilEnemyArmor;
                    enemyHealth = evilEnemyHealth;
                    break;

                case 1.0:

                    enemyDamage = direEnemyDamage;
                    enemyArmor = direEnemyArmor;
                    enemyHealth = direEnemyHealth;
                    break;

                case 3.0:

                    enemyDamage = neutralEnemyDamage;
                    enemyArmor = neutralEnemyArmor;
                    enemyHealth = neutralEnemyHealth;
                    break;
            }

            Console.WriteLine("Прекрасно");


            Console.WriteLine("Сейчас вам предстоит бой! ");
            Console.WriteLine();
            Console.WriteLine("В игре есть РЕЖИМ БЕРСЕРКА, который увеличивает вашу силу, но уменьшает вашу защиту");
            Console.WriteLine("1 - ДА");
            Console.WriteLine("0 - НЕТ");
            Console.WriteLine();
            Console.Write("желаете использовать РЕЖИМ БЕРСЕРКА? ");
            berserkMod = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));

            if (berserkMod == true)
            {
                characterDamage *= 2;
                characterArmor -= characterArmor * 0.8;


            }

            switch (characterFraction)
            {
                case 1.0:
                    if (characterFraction == 1.0)
                    {
                        characterDamage /= 2.0;
                        enemyDamage /= 2.0;
                    }
                    if (characterFraction == 2.0)
                    {
                        characterDamage *= 2.0;
                        enemyDamage *= 2.0;
                    }
                    break;
                case 2.0:
                    if (characterFraction == 2.0)
                    {
                        characterDamage /= 2.0;
                        enemyDamage /= 2.0;
                    }
                    if (characterFraction == 1.0)
                    {
                        characterDamage *= 2.0;
                        enemyDamage *= 2.0;
                    }
                    break;

            }
            double damageForCharacter = enemyDamage - (100 - characterArmor) / 100;
            double damageFornEnemy = characterDamage - (100 - enemyArmor) / 100;
            
           
            while (enemyHealth > 0.0 || characterHealth > 0.0)
            {
                Console.WriteLine($"Вы нанесли {damageFornEnemy} у противника было {enemyHealth}. У противника осталось {enemyHealth - damageFornEnemy}");
                Console.WriteLine($"Вам нанесли {damageForCharacter} у вас было {characterHealth}. У вас осталось {characterHealth - damageForCharacter}");


                enemyHealth -= damageFornEnemy;
                characterHealth -= damageForCharacter;

                Console.WriteLine("ударить еще?");
                Console.ReadLine();
            }
                


            





            

        }
    }
}   

