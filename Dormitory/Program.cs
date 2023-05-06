using Dormitory.DAL;

namespace Dormitory;

internal class Program
{
    static void Main(string[] args)
    {
        //using dormitorycontext
        //te dhenat merren nga perdoruesi

        using var context = new DormitoryContext();

        Console.WriteLine("Enter announcement title: ");
        var announcementTitle = Console.ReadLine();

        Console.WriteLine("Enter announcement description: ");
        var announcementDescription = Console.ReadLine();

        //vejme _ sepse sna duhet response qe na kthen ky kod thjesht 
        //
        _ = context.Announcements.Add(new Announcement
        {
            Title = announcementTitle,
            Description = announcementDescription,
            PublishedDate = DateTime.Now,
            IsActive = true
        });

        _ = context.SaveChanges();

    }

}