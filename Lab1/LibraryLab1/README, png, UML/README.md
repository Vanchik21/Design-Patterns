# Опис проекту: Система управління зоопарком

## Вступне слово
В даній лабораторній роботі було виконано варіант створення зоопарку та класів для його обліку. Всі класи розділено на групи: тварини, їжа, клітки, персонал та інвентар.

## Використані принципи

### DRY (Don't Repeat Yourself)
- Код, що може повторюватись, винесено в окремий абстрактний клас [Animal](https://github.com/Vanchik21/Design-Patterns/blob/main/Lab1/LibraryLab1/LibraryLab1/Animal.cs).

### KISS (Keep It Simple, Stupid)
- Всі методи подрібнені, щоб кожен виконував лише одну функцію, що полегшує читання і розуміння коду. Приклади: [ShowAnimalInventory](https://github.com/Vanchik21/Design-Patterns/blob/7011f1bcbb618439910320771f8488bd84cb75de/Lab1/LibraryLab1/LibraryLab1/Inventory.cs#L22C8-L29C10), [ShowFeedStock](https://github.com/Vanchik21/Design-Patterns/blob/7011f1bcbb618439910320771f8488bd84cb75de/Lab1/LibraryLab1/LibraryLab1/Inventory.cs#L36C1-L39C10), [ShowStaffsInventory](https://github.com/Vanchik21/Design-Patterns/blob/7011f1bcbb618439910320771f8488bd84cb75de/Lab1/LibraryLab1/LibraryLab1/Inventory.cs#L31C2-L34C10).

### SRP (Single Responsibility Principle)
- Кожен клас реалізовує щось одне по суті. Наприклад, класи тварин створюють тварин та визначають їх можливості, а клас [Inventory](https://github.com/Vanchik21/Design-Patterns/blob/main/Lab1/LibraryLab1/LibraryLab1/Inventory.cs) обліковує тварин, персонал та їжу.

### OCP (Open/Closed Principle)
- Клас [Animal](https://github.com/Vanchik21/Design-Patterns/blob/main/Lab1/LibraryLab1/LibraryLab1/Animal.cs) є абстрактним, і методи в наслідуваних класах ([Bird](https://github.com/Vanchik21/Design-Patterns/blob/main/Lab1/LibraryLab1/LibraryLab1/Bird.cs), [Mammal](https://github.com/Vanchik21/Design-Patterns/blob/main/Lab1/LibraryLab1/LibraryLab1/Mammal.cs), [Reptile](https://github.com/Vanchik21/Design-Patterns/blob/main/Lab1/LibraryLab1/LibraryLab1/Reptile.cs)) можна переписати під певні вимоги щодо інших тварин. Наприклад, метод [CanFly()](https://github.com/Vanchik21/Design-Patterns/blob/7011f1bcbb618439910320771f8488bd84cb75de/Lab1/LibraryLab1/LibraryLab1/Animal.cs#L20C8-L20C39) реалізовано по-різному в кожному з цих класів.

### DIP (Dependency Inversion Principle)
- У класах, таких як [Aviary](https://github.com/Vanchik21/Design-Patterns/blob/main/Lab1/LibraryLab1/LibraryLab1/Aviary.cs) і [Terrarium](https://github.com/Vanchik21/Design-Patterns/blob/main/Lab1/LibraryLab1/LibraryLab1/Terrarium.cs), використовуються абстракції ([Animal](https://github.com/Vanchik21/Design-Patterns/blob/main/Lab1/LibraryLab1/LibraryLab1/Animal.cs)), а не конкретні види тварин.

Проект є прикладом реалізації обліку зоопарку з дотриманням основних принципів об'єктно-орієнтованого програмування (ООП), що забезпечує його гнучкість, розширюваність і підтримуваність.