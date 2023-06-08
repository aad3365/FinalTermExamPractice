// See https://aka.ms/new-console-template for more information

using Collection;

Person[] personList = new Person[]
{
    new Person("Kim", "SeungHyun"),
    new Person("Park", "JongWon"),
    new Person("Jo", "MinJee"),
};

People people = new People(personList);

foreach (Person p in people)
{
    Console.WriteLine("{0} {1}", p.firstName, p.lastName);
}

// Dictionary

Dictionary<string, double> dictionary = new Dictionary<string, double>();

dictionary.Add("pi", 3.141);
dictionary.Add("e", 2.718);
dictionary.Add("kong", 2);

foreach (KeyValuePair<string, double> kvp in dictionary)
{
    Console.WriteLine("{0} {1}", kvp.Key, kvp.Value);
}

// Collection Methods

int[] digits = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
IEnumerable<int> enumerator = digits.Where<int>(i => i % 2 == 0);
enumerator.ToList<int>().ForEach(Console.Write);

int number = Array.Find<int>(digits, i => i > 8);
Console.WriteLine(number);

Console.WriteLine(digits.Sum<int>(i => i > 4 ? i : 0));

