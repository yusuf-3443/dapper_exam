using Domain.Models;
using Infrastructure.Services.ClassroomService;
using Infrastructure.Services.ClassService;
using Infrastructure.Services.ClassStudentService;
using Infrastructure.Services.ParentService;
using Infrastructure.Services.SchoolService;
using Infrastructure.Services.StudentParentService;
using Infrastructure.Services.StudentService;
using Infrastructure.Services.SubjectService;
using Infrastructure.Services.TeacherService;

DateTime now = DateTime.UtcNow;

var schoolservice = new SchoolService();
var school1 = new School()
{
  Title  = "school 8",
  LevelCount = 5,
  CreatedAt = DateTime.Now,
  UpdatedAt = DateTime.Now
};
var school2 = new School()
{
  Title  = "school 66",
  LevelCount = 9,
  CreatedAt = DateTime.Now,
  UpdatedAt = DateTime.Now
};
var school3 = new School()
{
  Id = 2,
  Title  = "school 54",
  LevelCount = 7,
  CreatedAt = DateTime.Now,
  UpdatedAt = DateTime.Now
};
// Console.WriteLine(schoolservice.AddSchool(school1));
// Console.WriteLine(schoolservice.AddSchool(school2));
// Console.WriteLine(schoolservice.AddSchool(school3));
// Console.WriteLine(schoolservice.UpdateSchool(school3));
// Console.WriteLine(schoolservice.DeleteSchool(1));
// var result = schoolservice.GetSchoolById(2);
// Console.WriteLine(result.Title + " " + result.LevelCount + " " + result.CreatedAt + " " + result.UpdatedAt);
// var result = schoolservice.GetSchools();
// foreach (var s in result)
// {
//   Console.WriteLine(s.Title + " " + s.LevelCount + " " + s.CreatedAt + " " + s.UpdatedAt);
// }

var studentservice = new StudentService();
var student1 = new Student()
{
  StudentCode = "87445774",
  FullName = "Said Bekov",
  Gender = "Male",
  Email = "said@gmail.com",
  Phone = "455645123",
  SchoolId = 2,
  CreatedAt = DateTime.Now,
  UpdatedAt = DateTime.Now
};
var student2 = new Student()
{
  StudentCode = "8448215",
  FullName = "Saida Bekova",
  Gender = "Female",
  Email = "saida@gmail.com",
  Phone = "8941122156",
  SchoolId = 4,
  CreatedAt = DateTime.Now,
  UpdatedAt = DateTime.Now
};
var student3 = new Student()
{
  Id = 8,
  StudentCode = "8977478452",
  FullName = "Behruz Bekov",
  Gender = "Male",
  Email = "behruz44@gmail.com",
  Phone = "98515465121548",
  SchoolId = 3,
  CreatedAt = DateTime.Now,
  UpdatedAt = DateTime.Now
};

// Console.WriteLine(studentservice.AddStudent(student1));
// Console.WriteLine(studentservice.AddStudent(student2));
// Console.WriteLine(studentservice.AddStudent(student3));
// Console.WriteLine(studentservice.UpdateStudent(student3));
// Console.WriteLine(studentservice.DeleteStudent(1));
// var result = studentservice.GetStudents();
// foreach (var s in result)
// {
//   Console.WriteLine(s.StudentCode + " " + s.FullName + " " + s.CreatedAt + " " + s.UpdatedAt);
// }

var parent1 = new Parent()
{
  ParentCode = "899566",
  FullName = "Xojaev nurbek",
  Email = "nurbek@gmail.com",
  Phone = "98984564231",
  CreatedAt = DateTime.Now,
  UpdatedAt = DateTime.Now
};
var parent2 = new Parent()
{
  ParentCode = "845566",
  FullName = "Saidov nurbek",
  Email = "nurbek3@gmail.com",
  Phone = "9898745614231",
  CreatedAt = DateTime.Now,
  UpdatedAt = DateTime.Now
};
var parent3 = new Parent()
{
  ParentCode = "5421366",
  FullName = "Fojaev nurbek",
  Email = "nurbek6@gmail.com",
  Phone = "12122324231",
  CreatedAt = DateTime.Now,
  UpdatedAt = DateTime.Now
};
var parent4 = new Parent()
{
  Id = 2,
  ParentCode = "8798795646",
  FullName = "Shoev nurbek",
  Email = "7899815@gmail.com",
  Phone = "88485412231",
  CreatedAt = DateTime.Now,
  UpdatedAt = DateTime.Now
};
var parentservice = new ParentService();
// Console.WriteLine(parentservice.AddParent(parent1));
// Console.WriteLine(parentservice.AddParent(parent2));
// Console.WriteLine(parentservice.AddParent(parent3));
// Console.WriteLine(parentservice.AddParent(parent4));
// Console.WriteLine(parentservice.UpdateParent(parent4));
// Console.WriteLine(parentservice.DeleteParent(4));
// var result = parentservice.GetParentById(2);
// Console.WriteLine(result.ParentCode + " " + result.FullName + " " + result.Email + " " + result.Phone);
// var result  = parentservice.GetParents();
// foreach (var r in result)
// {
//   Console.WriteLine(r.Id + " " + r.ParentCode + " " + r.FullName + " " + r.Email + " " + r.Phone);
// }

var studentparentservice = new StudentParentService();
var studentparent1 = new StudentParent()
{
  StudentId = 7,
  ParentId = 2
};
var studentparent2 = new StudentParent()
{
  StudentId = 8,
  ParentId = 2
};
var studentparent3 = new StudentParent()
{
  StudentId = 1,
  ParentId = 3
};
var studentparent4 = new StudentParent()
{
  Id = 2,
  StudentId = 8,
  ParentId = 1
};
// Console.WriteLine(studentparentservice.AddStudentParent(studentparent1));
// Console.WriteLine(studentparentservice.AddStudentParent(studentparent2));
// Console.WriteLine(studentparentservice.AddStudentParent(studentparent3));
// Console.WriteLine(studentparentservice.AddStudentParent(studentparent4));
// Console.WriteLine(studentparentservice.UpdateStudentParent(studentparent4));
// Console.WriteLine(studentparentservice.DeleteStudentParent(4));
// var result = studentparentservice.GetStudentParentById(2);
// Console.WriteLine(result.StudentId + " " + result.ParentId);
// var result = studentparentservice.GetStudentParents();
// foreach (var r in result)
// {
//   Console.WriteLine("id: " + r.Id + " " + "studentid: " + r.StudentId + " " + "parentid: " + r.ParentId);
// }

var subject1 = new Subject()
{
  Title = "Math",
  SchoolId = 3,
  Stage = 4,
  CreatedAt = DateTime.Now,
  UpdatedAt = DateTime.Now
};
var subject2 = new Subject()
{
  Title = "Ecology",
  SchoolId = 2,
  Stage = 5,
  CreatedAt = DateTime.Now,
  UpdatedAt = DateTime.Now
};
var subject3 = new Subject()
{
  Title = "Chemistry",
  SchoolId = 4,
  Stage = 3,
  CreatedAt = DateTime.Now,
  UpdatedAt = DateTime.Now
};
var subject4 = new Subject()
{
  Id = 3,
  Title = "Biology",
  SchoolId = 2,
  Stage = 10,
  CreatedAt = DateTime.Now,
  UpdatedAt = DateTime.Now
};
var subjectservice = new SubjectService();
// Console.WriteLine(subjectservice.AddSubject(subject1));
// Console.WriteLine(subjectservice.AddSubject(subject2));
// Console.WriteLine(subjectservice.AddSubject(subject3));
// Console.WriteLine(subjectservice.AddSubject(subject4));
// Console.WriteLine(subjectservice.UpdateSubject(subject4));
// Console.WriteLine(subjectservice.DeleteSubject(4));
// var result = subjectservice.GetSubjectById(1);
// Console.WriteLine(result.Title + " " + result.SchoolId);
// var result = subjectservice.GetScubjects();
// foreach (var r in result)
// {
//   Console.WriteLine(r.Title + " " + r.SchoolId);
// }

var teacher1 = new Teacher()
{
  TeacherCode = "5544564",
  FullName = "test testov",
  Gender = "Male",
  Email = "test@gmail.com",
  Phone = "9878456",
  WorkingDays = 5,
  CreatedAt = DateTime.Now,
  UpdatedAt = DateTime.Now
};
var teacher2 = new Teacher()
{
  TeacherCode = "21316564",
  FullName = "Said testov",
  Gender = "Male",
  Email = "trakst@gmail.com",
  Phone = "9987451456",
  WorkingDays = 6,
  CreatedAt = DateTime.Now,
  UpdatedAt = DateTime.Now
};
var teacher3 = new Teacher()
{
  TeacherCode = "987894312",
  FullName = "Saida testov",
  Gender = "Female",
  Email = "test35@gmail.com",
  Phone = "561236",
  WorkingDays = 5,
  CreatedAt = DateTime.Now,
  UpdatedAt = DateTime.Now
};
var teacher4 = new Teacher()
{
  Id = 4,
  TeacherCode = "99798564",
  FullName = "xolbibi testov",
  Gender = "Female",
  Email = "xolbibi@gmail.com",
  Phone = "8746848326",
  WorkingDays = 6,
  CreatedAt = DateTime.Now,
  UpdatedAt = DateTime.Now
};
var teacherservice = new TeacherService();
// Console.WriteLine(teacherservice.AddTeacher(teacher1));
// Console.WriteLine(teacherservice.AddTeacher(teacher2));
// Console.WriteLine(teacherservice.AddTeacher(teacher3));
// Console.WriteLine(teacherservice.AddTeacher(teacher4));
// Console.WriteLine(teacherservice.UpdateTeacher(teacher4));
// Console.WriteLine(teacherservice.DeleteTeacher(4));
// var result = teacherservice.GetTeacherById(2);
// Console.WriteLine(result.Gender + " " + result.FullName);
// var result = teacherservice.GetTeachers();
// foreach (var r in result)
// {
//   Console.WriteLine(r.FullName + " " + r.Gender);
// }

var classroom1 = new Classroom()
{
  Capacity = 48,
  Description = "classroom1",
  CreatedAt = DateTime.Now,
  UpdatedAt = DateTime.Now
};
var classroom2 = new Classroom()
{
  Capacity = 45,
  Description = "classroom2",
  CreatedAt = DateTime.Now,
  UpdatedAt = DateTime.Now
};
var classroom3 = new Classroom()
{
  Capacity = 15,
  Description = "classroom3",
  CreatedAt = DateTime.Now,
  UpdatedAt = DateTime.Now
};
var classroom4 = new Classroom()
{
  Id = 1,
  Capacity = 19,
  Description = "classroom7",
  CreatedAt = DateTime.Now,
  UpdatedAt = DateTime.Now
};
var classroomservice = new ClassroomService();
// Console.WriteLine(classroomservice.AddClassroom(classroom1));
// Console.WriteLine(classroomservice.AddClassroom(classroom2));
// Console.WriteLine(classroomservice.AddClassroom(classroom3));
// Console.WriteLine(classroomservice.AddClassroom(classroom4));
// Console.WriteLine(classroomservice.UpdateClassroom(classroom4));
// Console.WriteLine(classroomservice.DeleteClassroom(4));
// var result = classroomservice.GetClassroomById(3);
// Console.WriteLine(result.Description + " " + result.Capacity);
// var result = classroomservice.GetClassrooms();
// foreach (var r in result)
// {
//   Console.WriteLine(r.Description + " " + r.Capacity);
// }

var class1 = new Class()
{
  ClassName = "Biology",
  SubjectId = 2,
  TeacherId = 3,
  ClassroomId = 1
};
var class2 = new Class()
{
  ClassName = "history",
  SubjectId = 1,
  TeacherId = 3,
  ClassroomId = 1
};
var class3 = new Class()
{
  ClassName = "Math",
  SubjectId = 1,
  TeacherId = 2,
  ClassroomId = 2
};
var class4 = new Class()
{
  Id = 2,
  ClassName = "Geometry",
  SubjectId = 1,
  TeacherId = 3,
  ClassroomId = 1
};
var classservice = new ClassService();
// Console.WriteLine(classservice.AddClass(class1));
// Console.WriteLine(classservice.AddClass(class2));
// Console.WriteLine(classservice.AddClass(class3));
// Console.WriteLine(classservice.AddClass(class4));
// Console.WriteLine(classservice.UpdateClass(class4));
// Console.WriteLine(classservice.DeleteClass(3));
// var result = classservice.GetClassById(1);
// Console.WriteLine(result.Id + " " + result.ClassName + " " + result.ClassroomId + " " + result.SubjectId + " " + result.TeacherId);
// var result = classservice.GetClasses();
// foreach (var r in result)
// {
//   Console.WriteLine(r.Id + " " + r.ClassName + " " + r.SubjectId + " " + r.TeacherId + " " + r.ClassroomId);
// }

var classstudent1 = new ClassStudent()
{
  ClassId = 2,
  StudentId = 7
};
var classstudent2 = new ClassStudent()
{
  ClassId = 4,
  StudentId = 7
};
var classstudent3 = new ClassStudent()
{
  ClassId = 1,
  StudentId = 1
};
var classstudent4 = new ClassStudent()
{
  Id = 3,
  ClassId = 2,
  StudentId = 8
};
var classstudentservice = new ClassStudentService();
// Console.WriteLine(classstudentservice.AddClassStudent(classstudent1));
// Console.WriteLine(classstudentservice.AddClassStudent(classstudent2));
// Console.WriteLine(classstudentservice.AddClassStudent(classstudent3));
// Console.WriteLine(classstudentservice.AddClassStudent(classstudent4));
// Console.WriteLine(classstudentservice.UpdateClassStudent(classstudent4));
// Console.WriteLine(classstudentservice.DeleteClassStudent(1));
// var result = classstudentservice.GetClassStudentById(2);
// Console.WriteLine(result.StudentId + " " + result.ClassId);
var result = classstudentservice.GetClassStudents();
foreach (var r in result)
{
  Console.WriteLine(r.ClassId + " " + r.StudentId);
}