using System;

public class Lesson
{
    private int id;
    private int hh;
    private int mm;
    private int duration;

    public Lesson(int id, int hh, int mm, int duration)
    {
        this.id = id;
        this.hh = hh;
        this.mm = mm;
        this.duration = duration;
    }

    public int GetId() => id;
    public int GetHH() => hh;
    public int GetMM() => mm;
    public int GetDuration() => duration;

    public static int SumDuration(Lesson[] arr, int id)
    {
        int sum = 0;

        foreach (Lesson lesson in arr)
        {
            if (lesson.GetId() == id)
            {
                sum += lesson.GetDuration();
            }
        }

        return sum;
    }

    public static int Longest(Lesson[] arr)
    {
        int maxDuration = 0;
        int maxId = -1;

        foreach (Lesson lesson in arr)
        {
            int currentId = lesson.GetId();
            int currentDuration = SumDuration(arr, currentId);

            if (currentDuration > maxDuration)
            {
                maxDuration = currentDuration;
                maxId = currentId;
            }
        }

        return maxId;
    }
}

public class Program
{
    public static void Main()
    {
        Lesson[] lessons = new Lesson[]
        {
            new Lesson(1, 8, 30, 45),
            new Lesson(1, 10, 0, 60),
            new Lesson(2, 9, 15, 30),
            new Lesson(3, 11, 0, 90)
        };

        Console.WriteLine("Id with longest total duration: " + Lesson.Longest(lessons)); 
    }
}

