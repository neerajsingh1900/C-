using System;

class Question
{
    public string questionText;
    public string optionA;
    public string optionB;
    public string optionC;
    public string optionD;
    public char correctAnswerLetter;
    private static char defaultCorrectAnswerLetter = 'X';

    public Question()
    {
        optionA = null;
        optionB = null;
        optionC = null;
        optionD = null;
        correctAnswerLetter = Question.defaultCorrectAnswerLetter;
    }

    public Question(string questionText)
    {
        this.questionText = questionText;
        optionA = null;
        optionB = null;
        optionC = null;
        optionD = null;
        correctAnswerLetter = Question.defaultCorrectAnswerLetter;
    }

    public Question(string questionText, string optionA, string optionB, string optionC, string optionD, char correctAnswerLetter)
    {

        this.questionText = questionText;
        this.optionA = optionA;
        this.optionB = optionB;
        this.optionC = optionC;
        this.optionD = optionD;

        if (correctAnswerLetter == 'A' || correctAnswerLetter == 'B' || correctAnswerLetter =='C' || correctAnswerLetter == 'D')
        {
            this.correctAnswerLetter = correctAnswerLetter; 
        }
        else
            this.correctAnswerLetter = Question.defaultCorrectAnswerLetter;
    }

    public bool AreOptionsValid()
    {
        
        int count = 0;
        if (optionA != null) { count++; }
        if (optionB != null) { count++; }
        if (optionC != null) { count++; }
        if (optionD != null) { count++; }
        if (count >= 2) return true;
        else  return false;
    }
}

class Program
{
    static void Main()
    {
        Question q = new Question();

        string text = "Choose the Access Modifier which exists from below:";
        Question q1 = new Question(text);
        Question q2 = new Question(text, "Static", "class", "protected internal", "partial", 'C');
        Question q3 = new Question() { questionText =text, optionA = "Static", optionB="class" ,
            optionC="protected internal" ,optionD="partial" };

        //Console.WriteLine($"Question 1: {q.questionText}, Correct Answer: {q.correctAnswerLetter}");

       

    }
}