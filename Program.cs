using EntityFrameWorkExample;
TraningDbContext traningDbContext = new TraningDbContext();
/*
Student student = new Student();
student.Name = "Kuash";
student.Cgpa =2.7;
student.DateOfBirth = new DateTime(1992,2,3);
//ading studen i row
traningDbContext.Students.Add(student);
//modifi data or update
Student oldStudent = traningDbContext.Students.Where(x=>x.Name.Contains("nimur")).FirstOrDefault();
oldStudent.Cgpa = 5.0;
//delete
Student oldStudentDelete = traningDbContext.Students.Where(x =>x.Id==2).FirstOrDefault();
traningDbContext.Students.Remove(oldStudentDelete);

traningDbContext.SaveChanges();
Console.WriteLine("update data");
*/
Course course = new Course();
course.Fees = 3000;
course.Title = "PHP";
course.Topics = new List<Topic>();
course.Topics.Add(new Topic() 
{ 
    Description="Geating Started"
} 
);
course.Topics.Add(new Topic() { Description="Basic Syntax"});
traningDbContext.Courses.Add(course);
traningDbContext.SaveChanges();