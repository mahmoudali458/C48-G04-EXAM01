namespace OOP0FP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subj = new Subject(101, "Neural network");
            Console.WriteLine($"course id : {subj.SubjectId1}");
            Console.WriteLine($"course name : {subj.SubjectName1}");

            Console.WriteLine("====Examination system====");
            Console.WriteLine();

            subj.CreatExam();
            Console.WriteLine("press any key to start ");
            Console.ReadKey();
            
            if(subj.Exam!=null)
            {
                subj.Exam.ShowExam();
            }


        }
    }
}
