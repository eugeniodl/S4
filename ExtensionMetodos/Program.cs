var people = new Person[]
{
    new Person { Name = "Leticia", Age = 30 },
    new Person { Name = "Rodrigo", Age = 18 },
    new Person { Name = "Ernesto", Age = 17 },
    new Person { Name = "Tania", Age = 24 },
    new Person { Name = "Pedro", Age = 21 }
};
var adults = people.FilterByAge(21);

foreach (Person person in adults)
{
    Console.WriteLine($"{person.Name}, Age: {person.Age}");
}
