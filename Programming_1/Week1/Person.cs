using System;

public class Person
{

    private string name;
    private int age;

	public Person(string name, int age)
	{
        this.name = name;
        this.age = age;
	}

    public string getName()
    {
        return this.name;
    }

    public int getAge()
    {
        return this.age;
    }

    public static void main(String[] args)
    {

        Person dewi = new Person("Dewi", 19);

        Console.WriteLine("Dewi's age is: " + dewi.getAge);


    }
}
