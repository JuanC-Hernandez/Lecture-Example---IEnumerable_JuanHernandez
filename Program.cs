namespace Lecture_Example___Interface_and_IEnumerable_JuanHernandez
{
    internal class Program
    {
        // Juan Hernandez
        // IEnumerable
        // 02/23/24
        static void Main(string[] args)
        {
            ClassRoster prog124 = new ClassRoster();

            prog124.AddStudent("Will", "Cram");
            prog124.AddStudent("Anne", "Nguyen");
            prog124.AddStudent("Hannah", "Angel");
            prog124.AddStudent("Dylan", "Register");
            prog124.AddStudent("Kristyn", "Taniguchi");

            // Import Part
            foreach (Student student in prog124)
            {
                Console.WriteLine(student);
            }
            Console.ReadKey();
        }
    }
}
