# Restaurant

C# App that represents a restaurant system. Used for educational purposes and exercising the factory design pattern.

** works in Bulgarian

It contains the following features:
- Menu creation;
- Table destribution based on customer order;
- Creating order with a set of items from the menu;
- Daily profit calculation based on tables and ordered items.

Example for adding things in the menu:
item type, item name, weight, price
салата, Шопска салата, 350, 2.50

Example for orders:
table number, item name 1, item name 2, etc.
1, Шопска салата, Таратор, Мусака

Example output after typing "продажби" or "изход" to see the daily profit:
Общо заети маси през деня: 3
Общо продажби: 15 – 33.30
По категории:
- Салата: 2 – 5.00
- Супа: 2 – 4.50
- Основно ястие: 2 – 9.60
- Десерт: 3 – 8.20
- Напитка: 6 – 6.00
