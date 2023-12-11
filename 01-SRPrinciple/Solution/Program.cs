namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var report = new CourseReport();
            var saver = new FileSaver();

            report.AddEntry(new CourseReportEntry { Name = "Design Pattern", Students = 9000, Rating = 5 });
            report.AddEntry(new CourseReportEntry { Name = "Flutter", Students = 900, Rating = 4.5 });

            saver.SaveToFile(@"Reports", "WorkReport.txt", report);

            Console.WriteLine(report.ToString());
            Console.ReadLine();
        }
    }
}