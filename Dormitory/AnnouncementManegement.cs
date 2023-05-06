using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory
{
    internal class AnnouncementManegement
    {
        Dictionary<int, Announcements> activeAnnouncementsByDormitory = new Dictionary<int, Announcements>();
        Dictionary<int, Applications> activeApplicationsByDormitory = new Dictionary<int, Applications>();
        public void AddAnnouncement(int StudentId, string title, string description)
        {
            using (var context = new MyDbcontext())
            {
                //checking if the title is empty or the description is empty,as it is required to add an announcement
                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description))
                {
                    Console.WriteLine("Title and description are required.");
                    return;
                }
                //first we use the studentId to access the student class and than from there we use studentId to access roomStudent and than use the roomId in the class to access the room
                var studentId = StudentId; // replace with the actual student Id
                var student = context.Students.FirstOrDefault(s => s.Id == studentId);
                if (student != null)
                {

                    var roomStudent = context.RoomStudents.FirstOrDefault(rs => rs.StudentId == studentId);
                    if (roomStudent != null)
                    {
                        var room = context.Rooms.FirstOrDefault(r => r.Id == roomStudent.RoomId);

                        if (room != null)
                        {
                            var dormitory = context.Dormitories.FirstOrDefault(d => d.Id == roomStudent.DormitoryId);
                            if (dormitory != null)
                            {
                                if (activeAnnouncementsByDormitory.ContainsKey(room.Id))
                                {
                                    // there is an active announcement for this dormitory, so display a message
                                    Console.WriteLine($"There is already an active announcement for room {room.Id}");
                                }
                                else
                                {
                                    // there is no active announcement for this dormitory, so add the announcement to the database and the dictionary
                                    var announcement = new Announcements { Title = title, Description = description, PublishedDate = DateTime.Now, IsActive = true };
                                    context.Announcements.Add(announcement);
                                    context.SaveChanges();

                                    // add the announcement to the dictionary
                                    activeAnnouncementsByDormitory[room.Id] = announcement;

                                    Console.WriteLine($"Announcement '{title}' added for room {room.Id}");
                                }
                            }
                        }

                    }
                }


            }
        }
        public void DeactivateAnnouncement(int TargetId)
        {
            bool isDuplicate = false;
            var dormitory = activeAnnouncementsByDormitory.FirstOrDefault(x => x.Value.Any(a => a.Id == announcementId));

            if (dormitory.Value != null)
            {
                // Find the index of the announcement within the list
                var index = dormitory.Value.FindIndex(a => a.Id == announcementId);

                if (index != -1)
                {
                    // Remove the announcement from the list
                    dormitory.Value.RemoveAt(index);
                    Console.WriteLine($"Announcement {TargetId} has been removed from dormitory {dormitory.Key}");
                }
                else
                {
                    Console.WriteLine($"Announcement {TargetId} was not found in dormitory {dormitory.Key}");
                }
            }
            else
            {
                Console.WriteLine($"Announcement {TargetId} was not found in any dormitory");
            }
        }
        public void AddApplication(int announcementId,int sStudentId)
        {
            using (var context = new MyDbcontext())
            {
                bool isDuplicate = false;
                var dormitory = activeAnnouncementsByDormitory.FirstOrDefault(x => x.Value.Any(a => a.Id == announcementId));

                if (dormitory.Value != null)
                {
                    // Find the index of the announcement within the list
                    var index = dormitory.Value.FindIndex(a => a.Id == announcementId);

                    if (index != -1)
                    {

                        var application = new Applications { AnnouncementId = announcementId, StudentId = sStudentId,ApplicationDate = DateTime.Now, IsActive = true };
                        context.Applications.Add(application);
                        context.SaveChanges();
                        // Add Application in the list
                        activeApplicationsByDormitory[announcementId] = application;



                    Console.WriteLine($"Application {announcementId} has been added.");
                    }
                    else
                    {
                        Console.WriteLine($"Announcement {announcementId} was not found in dormitory {dormitory.Key}");
                    }
                }
                else
                {
                    Console.WriteLine($"Announcement {announcementId} was not found in any dormitory");
                }
            }
        }
        public void ListActiveAnnouncements()
        {
            using (var context = new MyDbcontext())
            {
                var activeAnnouncements = context.Announcements.Where(a => a.IsActive).ToList();
                foreach (var announcement in activeAnnouncements)
                {
                    Console.WriteLine($"Announcement ID: {announcement.Id}\nTitle: {announcement.Title}\nDescription: {announcement.Description}\nPublished Date: {announcement.PublishedDate}\n");
                }
            }
        }
        public void ListActiveApplicationsForAGivenDormitory(int targetId)
        {
            using (var context = new MyDbcontext())
            {
                var activeApplications = context.Applications.Where(a => a.AnnouncementId == targetId).ToList();
                foreach (var Applications in activeApplications)
                {
                    Console.WriteLine($"Student Id: {Applications.StudentId},Published Date: {Applications.ApplicationDate}");
                }
            }
        }

    }
}
