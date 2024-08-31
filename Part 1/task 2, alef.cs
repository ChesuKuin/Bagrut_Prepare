using System;
using System.Collections.Generic;

class Patient
{
    public int Id { get; set; }
    public int Priority { get; set; }

    public Patient(int id, int priority)
    {
        Id = id;
        Priority = priority;
    }
}

class PriorQueue
{
    private List<Patient> q = new List<Patient>();

    public void PriorityInsert(Patient p)
    {
        int i = 0;
        while (i < q.Count && q[i].Priority >= p.Priority)
        {
            i++;
        }
        q.Insert(i, p);
    }

    public void PrintQueue()
    {
        foreach (var patient in q)
        {
            Console.WriteLine($"Patient id = {patient.Id}, priority = {patient.Priority}");
        }
    }
}

class Program
{
    static void Main()
    {
        PriorQueue queue = new PriorQueue();

        queue.PriorityInsert(new Patient(13893, 7));
        queue.PriorityInsert(new Patient(28834, 7));
        queue.PriorityInsert(new Patient(72890, 6));
        queue.PriorityInsert(new Patient(12223, 4));
        queue.PriorityInsert(new Patient(13335, 4));
        queue.PriorityInsert(new Patient(33800, 4));

        Patient newPatient = new Patient(11210, 6);
        queue.PriorityInsert(newPatient);

        queue.PrintQueue();
    }
}
