using System;
using System.Collections.Generic;

namespace Classes
{
    public class PlayerCharacter
    {

        public int Health { get; set; }
        public string Name { get; private set; }
        public string NickName { get; set; }
        public bool IsNoob { get; set; }
        public List<String> Weapons { get; set; }

        public PlayerCharacter()
        {
            Name = GenerateName();
            IsNoob = true;
            CreateStartingWeapons();
        }

        public void Sleep()
        {
            var rnd = new Random();

            var healthIncrease = rnd.Next(1, 101);
            Health += healthIncrease;
        }
        public void TakeDamage(int damage)
        {
            Health = Math.Max(1, Health -= damage);
        }

        private string GenerateName()
        {
            var names = new[] {
                "MAD",
                "Reichtangle",
                "Mastermindzh"
            };

            return names[new Random().Next(0, names.Length)];
        }

        private void CreateStartingWeapons()
        {
            Weapons = new List<string> {
                "Bow",
                "Broadsword",
                "Staff",
                "Sword"
            };
        }



    }
}
