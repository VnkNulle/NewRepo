using System;
using System.Collections.Generic;

public interface ITestpaper
{
    string Subject { get; }
    string[] MarkScheme { get; }
    string PassMark { get; }
}

public interface IStudent
{
    string[] TestsTaken { get; }
    void TakeTest(ITestpaper paper, string[] answers);
}

public class Testpaper : ITestpaper
{
    public string Subject { get; }
    public string[] MarkScheme { get; }
    public string PassMark { get; }

    public Testpaper(string subject, string[] markScheme, string passMark)
    {
        Subject = subject;
        MarkScheme = markScheme;
        PassMark = passMark;
    }
}

public class Student : IStudent
{
    private List<string> testsTaken = new List<string>();

    public string[] TestsTaken => testsTaken.Count == 0 ? new string[] { "No tests taken" } : testsTaken.ToArray();

    public void TakeTest(ITestpaper paper, string[] answers)
    {
        int correctAnswers = 0;
        for (int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == paper.MarkScheme[i])
            {
                correctAnswers++;
            }
        }

        double percentage = (correctAnswers / (double)answers.Length) * 100;

        string result = $"{paper.Subject}: {(percentage >= double.Parse(paper.PassMark.Trim('%')) ? "Passed" : "Failed")}! ({percentage.ToString("0.#")}%)";
        testsTaken.Add(result);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Testpaper paper1 = new Testpaper("Maths", new string[] { "1A", "2C", "3D", "4A", "5A" }, "60%");
        Testpaper paper2 = new Testpaper("Chemistry", new string[] { "1C", "2C", "3D", "4A" }, "75%");
        Testpaper paper3 = new Testpaper("Computing", new string[] { "1D", "2C", "3C", "4B", "5D", "6C", "7A" }, "75%");

        Student student1 = new Student();
        Student student2 = new Student();

        Console.WriteLine(string.Join(", ", student1.TestsTaken));
        student1.TakeTest(paper1, new string[] { "1A", "2D", "3D", "4A", "5A" });
        Console.WriteLine(string.Join(", ", student1.TestsTaken));

        student2.TakeTest(paper2, new string[] { "1C", "2D", "3A", "4C" });
        student2.TakeTest(paper3, new string[] { "1A", "2C", "3A", "4C", "5D", "6C", "7B" });
        Console.WriteLine(string.Join(", ", student2.TestsTaken));
    }
}
