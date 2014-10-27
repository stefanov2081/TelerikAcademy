using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentException("Grade can not be negative");
        }
        if (minGrade < 0)
        {
            throw new ArgumentException("Min grade can not be negative");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("Max grade can not be less than or equal to min grade");
        }
        if (comments == null || comments == "")
        {
            throw new NullReferenceException("Comment can not be null or empty");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
