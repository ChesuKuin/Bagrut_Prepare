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

    public bool IsLater(Lesson other)
    {
        if (this.hh > other.hh) return true;
        if (this.hh == other.hh && this.mm > other.mm) return true;
        return false;
    }
}

public class Program
{
    public static void Main()
    {
        Lesson lesson1 = new Lesson(1, 10, 30, 45);
        Lesson lesson2 = new Lesson(2, 9, 45, 30);
        Console.WriteLine(lesson1.IsLater(lesson2));
    }
}
