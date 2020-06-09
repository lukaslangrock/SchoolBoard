using System;
using System.Collections.Generic;
using SchoolBoard.Models;

namespace SchoolBoard.Services
{
    // This service creates example data used for debugging and to display the public demo webapp.
    // If you would like to use your own data source, please create a custom service and swap it with the DemoService in the Pages/Index.cshtml.cs file.
    // You can use the naming scheme and structure from this service to create your own. 

    public class DemoService
    {
        public Alerts GetAlerts()
        {
            Alerts alerts = new Alerts();
            List<AlertMessage> alertMessages = new List<AlertMessage>();
            alerts.alertMessages = alertMessages;

            alertMessages.Add(
                new AlertMessage()
                {
                    message = "Die Stufensprecher für die Jahrgangsstufe EF stehen fest! Ihr könnt heute ab jetzt Liste am Stufenboard ansehen.",
                    type = "primary"
                }
            );
            alertMessages.Add(
                new AlertMessage()
                {
                    message = "Aufgrund von Wetterbedingungen potenziell apokalyptischen Ausmaßes fällt die Exkursion nach Aperture Science der Q1 aus. Wir bitten um Verständnis.",
                    type = "danger"
                }
            );

            return alerts;
        }

        public Exams GetExams()
        {
            Exams exams = new Exams();
            List<ExamTable> examTables = new List<ExamTable>();
            List<ExamClass> examClasses = new List<ExamClass>();
            exams.examTables = examTables;

            examTables.Add(
                new ExamTable()
                {
                    block = "JSt EF GK-Block 01",
                    classes = examClasses // examTables.classes = List<ExamClass> examClasses
                }
            );

            int demoExamCount = 4; // create 5 demo exams

            for (int i = 0; i < demoExamCount; i++)
            {
                int count = i + 1;
                Random rnd = new Random();
                examClasses.Add(
                    new ExamClass()
                    {
                        name = "K" + count + "G" + count,
                        teacher = "FL" + count,
                        count = rnd.Next(1, 30),
                        room = "A" + rnd.Next(1, 3) + "." + rnd.Next(0, 3) + rnd.Next(1, 3)
                    }
                );
            }

            return exams;
        }

        public Representations GetRepresentations()
        {
            Representations representations = new Representations();
            List<TeacherTable> teacherTables = new List<TeacherTable>();
            representations.teacherTables = teacherTables;

            int demoTeacherCount = 4;
            int demoHourCount = 3;

            for (int i = 0; i < demoTeacherCount; i++)
            {
                int teacherCounter = i + 1;
                TeacherTable teacherTable = new TeacherTable();
                teacherTables.Add(teacherTable);
                List<TeacherHour> teacherHours = new List<TeacherHour>();
                teacherTable.hours = teacherHours;
                teacherTable.name = "Lehrer " + teacherCounter;
                for (int j = 0; j < demoHourCount; j++)
                {
                    int hourCounter = j + 1;
                    Random rnd = new Random();
                    teacherHours.Add(
                        new TeacherHour()
                        {
                            hour = hourCounter,
                            className = "KURS" + hourCounter,
                            representingTeacherName = "/",
                            room = "A" + rnd.Next(1, 3) + "." + rnd.Next(0, 3) + rnd.Next(1, 3),
                            note = "EVA"
                        }
                    );
                }
            }

            return representations;
        }
    }
}
