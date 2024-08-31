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

    public void Update(int id, int pri)
    {
        Patient patient = q.Find(p => p.Id == id);
        if (patient != null)
        {
            q.Remove(patient);
            patient.Priority = pri;
            PriorityInsert(patient);
        }
        else
        {
            Console.WriteLine($"Пациент с id = {id} не найден.");
        }
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

        Console.WriteLine("Очередь до обновления:");
        queue.PrintQueue();

        queue.Update(72890, 8);

        Console.WriteLine("\nОчередь после обновления:");
        queue.PrintQueue();
    }
}
