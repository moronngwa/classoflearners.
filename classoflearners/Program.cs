using classoflearners;

class Program
{
    static void Main(string[] args)
    {
        Learners learner1 = new Learners("Morongwa", "Mathipa", "Female", 30, 'M');
        Console.WriteLine(learner1.firstname + "" + learner1.lastname + "" + learner1.gender + "" + learner1.age + "" + learner1.initals);
    }
}
