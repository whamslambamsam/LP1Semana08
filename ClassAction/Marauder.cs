using System;
using System.Security.Cryptography.X509Certificates;

namespace ClassAction
{
    public abstract class Marauder : Character
    {
        public Marauder(Character name, Character health, Character damage, Character strength)
        {
        }

        public override void Attack()
        {
            base.Attack();
            Console.Write(" Earthquake!");
        }
    }
}