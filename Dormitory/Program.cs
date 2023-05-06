using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Dormitory;

internal class Program
{
    static void Main(string[] args)
    { 
        StudentManagement studentManager = new StudentManagement();
        Console.WriteLine("Please enter your student id: ");
        string SstudentId = Console.ReadLine();
        bool isInteger;
        isInteger = int.TryParse(SstudentId, out int studentId);
        if (isInteger)
        {
            if (studentManager.StudentCheck(studentId))
            {
                AnnouncementManegement announcerManager = new AnnouncementManegement();
                Console.WriteLine("- New announcement (AA)");
                Console.WriteLine("-Edit announcement(EA)");
                Console.WriteLine("New Application (AAPP)");
                Console.WriteLine("- Listing Existing Anouncements (LEA)");
                Console.WriteLine("Listing applications (LA)");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "AA":
                        Console.WriteLine("Please provide a title for your announcement: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Please provide a description for your announcement: ");
                        string description = Console.ReadLine();
                        Console.WriteLine("Please provide your studentId: ");
                        announcerManager.AddAnnouncement(studentId, title, description);
                        break;
                    case "EA":
                        Console.WriteLine("Editing the announcement");
                        break;
                    case "AAPP":
                        Console.WriteLine("Please provide an announcementid: ");

                        //announcerManager.AddApplication();
                        break;
                    case "LEA":
                        Console.WriteLine("Listing exiting announcements");
                        break;
                    case "LA":
                        Console.WriteLine("Listing applications");
                        break;

                }

            }
            else
            {
                Console.WriteLine("I am sorry but you are not a valid student!!!");
            }
            
        }

      




        /*static void AddAnnouncement(string title, string description, int roomId)
        {
            using (var context = new MyDbcontext())
            {
                var roomId = 1; // Replace with the actual RoomId
                var room = context.Rooms.FirstOrDefault(r => r.Id == roomId);
                if (room != null)
                {
                    var hasActiveAnnouncement = context.Announcements.Any(a => a.IsActive && context.Rooms.Any(r => r.DormitoryId == room.DormitoryId && r.Id == a.RoomId));

                    if (hasActiveAnnouncement)
                    {
                        Console.WriteLine("There is already an active announcement for this dormitory.");
                        return;
                    }

                    // Create a new announcement
                    var announcement = new Announcement
                    {
                        Title = title,
                        Description = description,
                        RoomId = roomId,
                        IsActive = true
                    };

                    // Add the announcement to the database
                    context.Announcements.Add(announcement);
                    context.SaveChanges();

                    Console.WriteLine("Announcement added successfully.");
                }
            }
        }*/

    }
  }