namespace Mentorship.Basics;

internal class RandomNumberGeneration
{
    public static void GenerateRandomQuestion(IEnumerable<string> questions)
    {
        Random rand = new();
        int questionIndex = rand.Next(0,questions.Count());
        WriteLine(questions.ElementAt(questionIndex));
    }
}