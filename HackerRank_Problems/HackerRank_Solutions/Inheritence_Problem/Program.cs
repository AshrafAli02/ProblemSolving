using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_Problem
{
    class Program
    {
        static void Main()
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }
}



class Person
{
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person() { }
    public Person(string firstName, string lastName, int identification)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }
    public void printPerson()
    {
        Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
    }
}

class Student : Person
{
    private int[] testScores;

    public Student(string firstname, string lastname, int id, int[] scores)
    {
        this.firstName = firstname;
        this.lastName = lastname;
        this.id = id;
        testScores = scores;
    }

    public char Calculate()
    {
        int n = testScores.Length;
        int sum = testScores.Sum();
        int Result = (int)(sum / n);
        if (Result >= 90 && Result <= 100)
        {
            return 'O';
        }
        else if (Result >= 80 && Result <= 90)
        {
            return 'E';
        }
        else if (Result >= 70 && Result <= 80)
        {
            return 'A';
        }
        else if (Result >= 55 && Result <= 70)
        {
            return 'P';
        }
        else if (Result >= 40 && Result <= 55)
        {
            return 'D';
        }
        else if (Result < 40)
        {
            return 'T';
        }

        return ' ';
    }
}
