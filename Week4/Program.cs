Warrior warrior = new Warrior("Thorin", 100, 10, 1, 15);
Mage mage = new Mage("Gandalf", 100, 10, 1, 100);

warrior.DisplayStats();
mage.DisplayStats();

warrior.Attack(mage);
mage.CastSpell(warrior);

warrior.DisplayStats();
mage.DisplayStats();