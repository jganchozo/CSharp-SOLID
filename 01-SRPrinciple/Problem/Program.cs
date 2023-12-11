namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var report = new CourseReport();

            report.AddEntry(new CourseReportEntry { Name = "Design Pattern", Students = 9000, Rating = 5 });
            report.AddEntry(new CourseReportEntry { Name = "Flutter", Students = 1900, Rating = 4.5 });

            report.SaveToFile(@"Reports", "WorkReport.txt");

            Console.WriteLine(report.ToString());
            Console.ReadLine();
        }
    }
}