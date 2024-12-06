using Ex3b;


// Ex 1 Part 1
/* 
A a = new A();
B b = new B();
C c = new C();

a.a();
b.b();
c.c();

// Ex 1 Part 2

c.a();
c.b();
c.c();
*/

// Ex2 Part 1
/*
Person ada = new("Ada Lovelace", "24 Maddox St. London W1S 2QN");
Person esko = new("Esko Ukkonen", "Mannerheimintie 15 00100 Helsinki");

Console.WriteLine(ada.Show());
Console.WriteLine(esko.Show());
*/

// Ex2 Part 2
/*
Student ollie = new("Ollie", "6381 Hollywood Blvd. Los Angeles 90028");
Console.WriteLine(ollie.Show());
Console.WriteLine("  Study credits " + ollie.Credits());
ollie.Study();
Console.WriteLine("  Study credits " + ollie.Credits());
*/

// Ex 2 Part 3
/*
Student ollie = new Student("Ollie", "6381 Hollywood Blvd. Los Angeles 90028");

Console.WriteLine(ollie.Show());
ollie.Study();
Console.WriteLine(ollie.Show());
*/

// Ex 2 Part 4
/*
Teacher ada = new("Ada Lovelace", "24 Maddox St. London W1S 2QN", 1200);
Teacher esko = new("Esko Ukkonen", "Mannerheimintie 15 00100 Helsinki", 5400);

Console.WriteLine(ada.Show());
Console.WriteLine(esko.Show());

Student ollie = new("Ollie", "6381 Hollywood Blvd. Los Angeles 90028");

int i = 0;
while (i < 25)
{
    ollie.Study();
    i++;
}
Console.WriteLine(ollie.Show());
*/

// Ex 2 Part 5

List<Person> persons = new List<Person>();

persons.Add(new Teacher("Ada Lovelace", "24 Maddox St. London W1S 2QN", 1200));
persons.Add(new Student("Ollie", "6381 Hollywood Blvd. Los Angeles 90028"));

PrintPersons(persons);

static void PrintPersons(List<Person> persons)
{
    foreach (var p in persons)
    {
        Console.WriteLine(p.Show());
    }
}