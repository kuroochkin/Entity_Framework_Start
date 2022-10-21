using Entity_Framework_Start;
using Entity_Framework_Start.Entity;

using (Context db = new Context())
{
    Person person1 = new Person(1, "Курочкин", "Владислав", 19);
    Person person2 = new Person(2, "Горбатых", "Александр", 18);

    db.Persons.Add(person1);
    db.Persons.Add(person2);

    db.SaveChanges();
}

using (Context db = new Context())
{
    // получаем объекты из бд и выводим на консоль
    var persons = db.Persons.ToList();
    Console.WriteLine("Persons list:");
    foreach (Person item in persons)
    {
        Console.WriteLine($"{item.Id}. {item.Surname} {item.Name} - {item.Age}");
    }
}
