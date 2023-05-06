using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Dormitory
{
    internal class Announcements
    {
        public int Id { get; set; }
        //public int RoomId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime PublishedDate { get; set; }

        public bool IsActive { get; set; }

      

        /*public void AddAnnouncement(int StudentId,string title,string description)
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
                                    activeAnnouncementsByDormitory[room.Id] = new List<Announcements> { announcement };

                                    Console.WriteLine($"Announcement '{title}' added for room {room.Id}");
                                }
                            }
                        }

                    }
                }


            }
        }*/
        


    }
}
