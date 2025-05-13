using System;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioWithBincom.Controllers
{
    public class CVController : Controller
    {
        public IActionResult Index()
        {
            var cv = new CVModel
            {
                Name = "Goodness Omokayode",
                Email = "goodnessomokayode@gmail.com",
                LinkedIn = "https://www.linkedin.com/in/goodness-omokayode-219615215/",
                Summary = "Apiring full-stack developer with a diversified professional background spanning several sectors such as " +
                "hospitality, charity and technology. Possessing exceptional client-service, collaboration and problem solving skills," +
                " I am able to adapt to any task, role and environment.",
                Skills = new List<SkillsModel>
                {
                    new SkillsModel
                    {
                    TechnicalSkills = "Java, SQL, C#, .NET, Azure, GitHub, Microsoft Office (Word, Excel, PowerPoint, Outlook)",
                    SoftSkills = "Client Service, Relationship Management, Problem-Solving, Adaptability, Communication Teamwork & Collaboration",
                    Credentials = "Introduction To Data & SQL (CFG), Leadership & Management (Institute of Leadership and Management) " +
                    "Introduction To Child Protection (NSPCC)"
                    }
                },
                Education = new List<EducationModel>
                {
                    new EducationModel
                    {
                        SchoolName = "University of St Andrews",
                        SchoolSummary = "Key Modules: Object-Oriented Programming, Programming with Data",
                        DurationStudied = "2023 - 2028"
                    },
                    new EducationModel{
                        SchoolName = "Brampton Manor Academy",
                        SchoolSummary = "A Level: Mathematics(A), Psychology(A*), Biology(A)",
                        DurationStudied = "2021 - 2023"
                    },
                    new EducationModel
                    {
                        SchoolName = "Harris Rainham Academy",
                        SchoolSummary = "GCSE: 99999999 including Mathematics(9), English Literature(9) and English Language(9)",
                        DurationStudied = "2019 - 2021"
                    },
                    
                },
                TechnicalExp = new List<ExperienceModel>
                {
                    new ExperienceModel
                    {
                        JobTitle = "Incoming Engineer Intern",
                        Duration = "June 2025 - August 2025",
                        CompanyName = "OODLE CAR FINANCE",
                        Description = new List<string> {
                            "Intern engineer utilising Java & SQL under the guidance of Oodle's Java Senior Dev"
                        }
                    },
                    new ExperienceModel
                    {
                        JobTitle = "C# Trainee Developer",
                        Duration = "April 2025 - Present",
                        CompanyName = "BINCOM GLOBAL",
                        Description = new List<string> {
                            "Training in real world C# and .Net Development.",
                            "Utilised technologies such as Microsoft Azure and GitHub for version control and deployment."
                        }
                    }
                },
                NonTechnicalExp = new List<ExperienceModel>
                {
                    new ExperienceModel
                    {
                        JobTitle = "Corporate Partnerships Intern",
                        Duration = "July 2024 - August 2024",
                        CompanyName = "ERNST & YOUNG FOUNDATION",
                        Description = new List<string>
                        {
                            "Assisted in managing scheduling, email correspondence, " +
                            "and document preparation to support corporate partnership initiatives.",
                            "Conducted industry research to identify potential sectors for partnership opportunities, " +
                            "providing insights for business development.",
                            "Created and re-developed marketing materials and reports to support engagement with current and prospective partners.",
                            "Provided administrative and operational support to team members, ensuring smooth execution of partnership activities."
                        }
                    },
                    new ExperienceModel
                    {
                        JobTitle = "Private Tutor",
                        Duration = "May 2024 - September 2024",
                        CompanyName = "THE NATIONAL LEARNING GROUP",
                        Description = new List<string>
                        {
                            "Designed and delivered structured lesson plans tailored to individual student needs in mathematics and sciences.",
                            "Maintained detailed records of student progress, regularly communicating with families to ensure continued " +
                            "engagement and improvement.",
                            "Developed strong organisational and time-management skills by balancing multiple student schedules."
                        }
                    },
                    new ExperienceModel
                    {
                        JobTitle = "Resort Associate",
                        Duration = "November 2023 - May 2024",
                        CompanyName = "OLD COURSE HOTEL",
                        Description = new List<string>
                        {
                            "Provided high-quality guest service, ensuring a seamless dining and event experience",
                            "Assisted with event setup and breakdown, including table arrangement and coordination with catering teams.",
                            "Facilitated smooth food service through communication between kitchen staff and servers."
                        }
                    },
                    new ExperienceModel
                    {
                        JobTitle = "Hospitality Staff",
                        Duration = "September 2022 - August 2023",
                        CompanyName = "TIGER RECRUITMENT",
                        Description = new List<string>
                        {
                            "Worked in various hospitality roles, including waitress, receptionist, kitchen porter, and barista.",
                            "Managed customer orders, facilitated transactions, and ensured smooth service in high-paced environments.",
                            "Developed strong multitasking abilities and attention to detail while handling customer inquiries."
                        }
                    }
                }
            };

            return View(cv);
        }
    }
}