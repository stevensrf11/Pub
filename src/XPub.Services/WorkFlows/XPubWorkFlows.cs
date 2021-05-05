using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XPub.Interfaces.Models;
using XPub.Models;
using XPub.Models.Services;
using XPub.Resources;

namespace XPub.Services.WorkFlows
{

    public  class XPubWorkFlows 
    {
        #region Fields
        /// <summary>
        /// Array of file record names
        /// </summary>
        /// <value>string</value>
        string[] ReportFiles = new string[] { "Congressional Record", "Federal Register", "Bills" };
        string[] Roles = new string[] { XPubResource.Administration, XPubResource.Supervisor, XPubResource.Employee };
        string[] Departments = new string[] { "Accounting", "Engineering", "Human Resources", "Sales","Information Technology" };

        /// <summary>
        /// Array of file types
        /// </summary>
        /// <value>string</value>
        string[] fileTypes =new string[] { "txt", "docx", "pdf" };
        #endregion

        #region Work flow Services
        
        /// <summary>
        /// GetFileRecordInformationServiceAsync method
        /// Asynchronous method which retrieves  a list of file record information
        /// </summary>
        /// <returns>task which contains a collection of IXPubRecordModel references</returns>
        public async Task<IList<IXPubRecordModel>> GetFileRecordInformationWorkFlowAsync()
        {

            var t =await Task<IList< IXPubRecordModel >>.Factory.StartNew(() => GetFileRecordInformationWorkFlow());
            return t;
        }

        /// <summary>
        /// GetEmployeeInformationWorkFlowAsync method
        /// Asynchronous method which retrieves  a list of employee information
        /// </summary>
        /// <returns>task which contains a collection of IXPubRecordModel references</returns>
        public async Task<IList<IXPubEmployeeModel>> GetEmployeeInformationWorkFlowAsync()
        {

            var t = await Task<IList<IXPubEmployeeModel>>.Factory.StartNew(() => GetEmployeeInformationWorkFlow());
            return t;
        }


        #endregion
        #region Work flow implementation
        /// <summary>
        /// GetFileRecordInformationWorkFlow method
        /// Retrieves a list of file record information
        /// </summary>
        /// <returns>Collection of IXPubRecordModel references</returns>
        public IList<IXPubRecordModel> GetFileRecordInformationWorkFlow()
        {
            var dt = DateTime.Now;
            var retList= new List<IXPubRecordModel>();
            for(int i=0;i<3;i++)
            {
            retList.Add(FileRecordInformation(ReportFiles[i], "File  A", fileTypes[0], dt, 24000));
            retList.Add(FileRecordInformation(ReportFiles[i], "File  B", fileTypes[0], dt, 11000));
            retList.Add(FileRecordInformation(ReportFiles[i], "File  Q", fileTypes[0], dt, 96000));
            retList.Add(FileRecordInformation(ReportFiles[i], "File  Z", fileTypes[0], dt, 54000));
            retList.Add(FileRecordInformation(ReportFiles[i], "File  J", fileTypes[0], dt, 21000));
            retList.Add(FileRecordInformation(ReportFiles[i], "File  F", fileTypes[0], dt, 11000));
            retList.Add(FileRecordInformation(ReportFiles[i], "File  N", fileTypes[0], dt, 68000));
            retList.Add(FileRecordInformation(ReportFiles[i], "File  C", fileTypes[0], dt, 87000));
            }
           return retList;


        }


        /// <summary>
        /// GetEmployeeInformationWorkFlow method
        /// Retrieves a list of file record information
        /// </summary>
        /// <returns>Collection of IXPubRecordModel references</returns>
        public IList<IXPubEmployeeModel> GetEmployeeInformationWorkFlow()
        {
            var dt = DateTime.Now;
            var retList = new List<IXPubEmployeeModel>();
            //Administration
                retList.Add(new XPubEmployeeModel
                {
                    Department = Departments[0],
                    PhoneNumber = "",
                    Role = Roles[0],
                    EmailAddress = "JohnSmith@gamil.com",
                    FirstName = "John",
                    LastName = "Smith",
                    FullName = "John Smith",
                    Id=0,
                    ParentId = 0



                });
                retList.Add(new XPubEmployeeModel
                {
      
                    Department = Departments[1],
                    PhoneNumber = "",
                    Role = Roles[0],
                    EmailAddress = "JaneSmith@gamil.com",
                    FirstName = "Jane",
                    LastName = "Smith",
                    FullName = "Jane Smith",
                    Id = 1,
                    ParentId = 1

                });

                retList.Add(new XPubEmployeeModel
                {
                    Department = Departments[2],
                    PhoneNumber = "",
                    Role = Roles[0],
                    EmailAddress = "BobDenverh@gamil.com",
                    FirstName = "Bob",
                    LastName = "Denver",
                    FullName = "Bob Denver",
                    Id = 2,
                    ParentId = 2

                });

                retList.Add(new XPubEmployeeModel
                {
                    Department = Departments[3],
                    PhoneNumber = "",
                    Role = Roles[0],
                    EmailAddress = "RichardDustin@gamil.com",
                    FirstName = "Richard",
                    LastName = "Dustin",
                    FullName = "Richard Dustin",
                    Id = 3,
                    ParentId = 3
                });
                retList.Add(new XPubEmployeeModel
                {
                    Department = Departments[4],
                    PhoneNumber = "",
                    Role = Roles[0],
                    EmailAddress = "MaryJane@gamil.com",
                    FirstName = "Mary",
                    LastName = "Jane",
                    FullName = "Mary Jane",
                    Id = 4,
                    ParentId = 4
                });


            //Admin 0-Supervisor 0
            retList.Add(new XPubEmployeeModel
            {
      
                Department = Departments[0],
                PhoneNumber = "",
                Role = Roles[1],
                EmailAddress = "PatCougar@gamil.com",
                FullName = "Pat Cougar",
                LastName = "Cougar",
                FirstName = "Pat",
                Id = 5,
                ParentId = 0



            });
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[1],
                PhoneNumber = "",
                Role = Roles[1],
                EmailAddress = "MikePunter@gamil.com",
                FullName = "MikePunter",
                LastName = "Punter",
                FirstName = "Mike",
                Id = 6,
                ParentId = 0
            });

            retList.Add(new XPubEmployeeModel
            {

                Department = Departments[2],
                PhoneNumber = "",
                Role = Roles[1],
                EmailAddress = "JackHunter@gamil.com",
                FullName = "Jack Hunter",
                LastName = "Hunter",
                FirstName = "Jack",
                Id = 7,
                ParentId = 0
            });

            //Administration 1
            retList.Add(new XPubEmployeeModel
            {

                Department = Departments[0],
                PhoneNumber = "",
                Role = Roles[1],
                EmailAddress = "MaryRodgers@gamil.com",
                FullName = "Mary Rodgers",
                LastName = "Rodgers",
                FirstName = "Mary",
                Id = 8,
                ParentId = 1
            });
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[1],
                PhoneNumber = "",
                Role = Roles[1],
                EmailAddress = "SallySouth@gamil.com",
                FullName = "Sally South",
                LastName = "South",
                FirstName = "Sally",
                Id = 9,
                ParentId = 1
            });

            //admin Supervisor 2
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[0],
                PhoneNumber = "",
                Role = Roles[1],
                EmailAddress = "ScottNorths@gamil.com",
                FullName = "Scott Norths",
                LastName = "Norths",
                FirstName = "Scott",
                Id = 10,
                ParentId = 2
            });
            retList.Add(new XPubEmployeeModel
            {
 
                Department = Departments[1],
                PhoneNumber = "",
                Role = Roles[1],
                EmailAddress = "GeorgeBurns@gamil.com",
                FullName = "George Burns",
                LastName = "Burns",
                FirstName = "George",
                Id = 11,
                ParentId = 2
            });


            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[2],
                PhoneNumber = "",
                Role = Roles[1],
                EmailAddress = "DavidRoth@gamil.com",
                FullName = "David Roth",
                LastName = "Roth",
                FirstName = "David",
                Id = 12,
                ParentId = 2
            });
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[3],
                PhoneNumber = "",
                Role = Roles[1],
                EmailAddress = "MaybellLeen@gamil.com",
                FullName = "Maybell Leen",
                LastName = "Leen",
                FirstName = "Maybell",
                Id = 13,
                ParentId = 2
            });
            //admin Supervisor 3

            //admin Supervisor 4
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[0],
                PhoneNumber = "",
                Role = Roles[1],
                EmailAddress = "DonKnocks@gamil.com",
                FullName = "Don Knocks",
                LastName = "Knocks",
                FirstName = "Don",
                Id = 14,
                ParentId = 4
            });
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[1],
                PhoneNumber = "",
                Role = Roles[1],
                EmailAddress = "SueAllen@gamil.com",
                FullName = "Sue Allen",
                LastName = "Allen",
                FirstName = "Sue",
                Id = 15,
                ParentId = 4
            });


            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[2],
                PhoneNumber = "",
                Role = Roles[1],
                EmailAddress = "HankAaron@gamil.com",
                FullName = "Hank Aaron",
                LastName = "Aaron",
                FirstName = "Hank",
                Id = 16,
                ParentId = 4
            });
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[3],
                PhoneNumber = "",
                Role = Roles[1],
                EmailAddress = "BabeRuth@gamil.com",
                FullName = "Babe Ruth",
                LastName = "Babe",
                FirstName = "Ruth",
                Id = 17,
                ParentId = 4

            });

            //Administration 0 super 5 employees
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[0],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "JohnnyCarson@gamil.com",
                FullName = "Johnny Carson",
                LastName = "Carson",
                FirstName = "Johnny",
                Id = 20,
                ParentId = 5
            });


            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[0],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "DickCabboth@gamil.com",
                FullName = "Dick Cabboth",
                LastName = "Dick",
                FirstName = "Cabboth",
                Id = 21,
                ParentId = 5
            });
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[0],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "DonnaSummer@gamil.com",
                FullName = "Donna Summer",
                LastName = "Summer",
                FirstName = "Donna",
                Id = 22,
                ParentId = 5
            });

            //Administration 0 super 6 employees

            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[1],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "BillPennock@gamil.com",
                FullName = "Bill Pennock",
                LastName = "Bill",
                FirstName = "Pennock",
                Id = 30,
                ParentId = 6
            });


            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[1],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "AbbyReader@gamil.com",
                FullName = "Abby Reader",
                LastName = "Abby",
                FirstName = "Reader",
                Id = 31,
                ParentId = 6
            });
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[1],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "JoeBlack@gamil.com",
                FullName = "Joe Black",
                LastName = "Joe",
                FirstName = "Black",
                Id = 32,
                ParentId = 6
            });


            //Administration 0 super 7 employees

            //Administration 1 super 8 employees

            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[0],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "MayWest@gamil.com",
                FullName = "May West",
                LastName = "West",
                FirstName = "May",
                Id = 40,
                ParentId = 8
            });


            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[0],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "MickJackson@gamil.com",
                FullName = "Mick Jackson",
                LastName = "Jackson",
                FirstName = "Mick",
                Id = 41,
                ParentId = 8
            });
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[0],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "ElvisPressly@gamil.com",
                FullName = "Elvis Pressly",
                LastName = "Pressly",
                FirstName = "Elvis",
                Id = 42,
                ParentId = 8
            });

            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[0],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "MickMouse@gamil.com",
                FullName = "Mick Mouse",
                LastName = "Mouse",
                FirstName = "Mick",
                Id = 43,
                ParentId = 8
            });

            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[0],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "MinMouse@gamil.com",
                FullName = "Min Mouse",
                LastName = "Mouse",
                FirstName = "Min",
                Id = 44,
                ParentId = 8
            });

            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[0],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "TomSpeedy@gamil.com",
                FullName = "Tom Speedy",
                LastName = "Speedy",
                FirstName = "Tom",
                Id = 45,
                ParentId = 8
            });



            //Administration 1 super 9 employees

            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[1],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "JoeDeezer@gamil.com",
                FullName = "Joe Deezer",
                LastName = "Joe",
                FirstName = "Deezer",
                Id = 50,
                ParentId =9
            });


            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[1],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "MickeDresler@gamil.com",
                FullName = "Micke Dresler",
                LastName = "Micke",
                FirstName = "Dresler",
                Id = 51,
                ParentId = 9
            });

            //admin 2 Supervisor 10
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[0],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "JimPluto@gamil.com",
                FullName = "Jim Pluto",
                LastName = "Pluto",
                FirstName = "Jim",
                Id = 60,
                ParentId = 10
            });

            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[0],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "SteveMars@gamil.com",
                FullName = "Steve Mars",
                LastName = "Mars",
                FirstName = "Steve",
                Id = 61,
                ParentId = 10
            });

            

            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[0],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "DebbieVenus@gamil.com",
                FullName = "Debbie Venus",
                LastName = "Venus",
                FirstName = "Debbie",
                Id = 62,
                ParentId = 10
            });

            //admin 2 Supervisor 11
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[1],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "JackBenny@gamil.com",
                FullName = "Jack Benny",
                LastName = "Benny",
                FirstName = "Jack",
                Id = 70,
                ParentId = 11
            });

            //admin 2 Supervisor 12
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[2],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "MickeDresler@gamil.com",
                FullName = "Micke Dresler",
                LastName = "Micke",
                FirstName = "Dresler",
                Id = 80,
                ParentId = 12
            });

            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[2],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "SteveGarvey@gamil.com",
                FullName = "Steve Garvey",
                LastName = "Garvey",
                FirstName = "Steve",
                Id = 81,
                ParentId = 12

            });

            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[2],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "MikeCey@gamil.com",
                FullName = "MikeCey",
                LastName = "Cey",
                FirstName = "Mike",
                Id = 82,
                ParentId = 12
            });

            //admin 2 Supervisor 13
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[3],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "ElmerFudd@gamil.com",
                FullName = "Elmer Fudd",
                LastName = "Fudd",
                FirstName = "Elmer",
                Id = 90,
                ParentId = 13
            });

            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[3],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "DaffyDuck@gamil.com",
                FullName = "Daffy Duck",
                LastName = "Duck",
                FirstName = "Daffy",
                Id = 91,
                ParentId = 13
            });

            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[3],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "BugsBunny@gamil.com",
                FullName = "Bugs Bunny",
                LastName = "Bunny",
                FirstName = "Bugs",
                Id = 92,
                ParentId = 13
            });

            //admin4 Supervisor 14

            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[0],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "AndyGriffith@gamil.com",
                FullName = "Andy Griffith",
                LastName = "Griffith",
                FirstName = "Andy",
                Id = 100,
                ParentId = 14
            });

            //admin 4 Supervisor 15
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[1],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "AngelaAndy@gamil.com",
                FullName = "Angela Andy",
                LastName = "Andy",
                FirstName = "Angela",
                Id = 110,
                ParentId = 15
            });

            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[1],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "PeterJaun@gamil.com",
                FullName = "Peter Jaun",
                LastName = "Jaun",
                FirstName = "Peter",
                Id = 111,
                ParentId = 15
            });
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[1],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "AntonioTexash@gamil.com",
                FullName = "Antonio Texash",
                LastName = "Texash",
                FirstName = "Antonio",
                Id = 112,
                ParentId = 15
            });
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[1],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "DallasTexas@gamil.com",
                FullName = "Dallas Texas",
                LastName = "Texas",
                FirstName = "Dallas",
                Id = 113,
                ParentId = 15
            });
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[1],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "NickyMonday@gamil.com",
                FullName = "Nicky Monday",
                LastName = "Monday",
                FirstName = "Nicky",
                Id = 114,
                ParentId = 15
            });
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[1],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "ShellyTuesday@gamil.com",
                FullName = "Shelly Tuesday",
                LastName = "Tuesday",
                FirstName = "Shelly",
                Id = 115,
                ParentId = 15
            });
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[1],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "JoeFirday@gamil.com",
                FullName = "Joe Firday",
                LastName = "Firday",
                FirstName = "Joe",
                Id = 116,
                ParentId = 15
            });
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[1],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "LemontSanford@gamil.com",
                FullName = "Lemont Sanford",
                LastName = "Sanford",
                FirstName = "Lemont",
                Id = 117,
                ParentId = 15
            });
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[1],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "RedFoxx@gamil.com",
                FullName = "Red Foxx",
                LastName = "Foxx",
                FirstName = "Red",
                Id = 118,
                ParentId = 15
            });

            //admin 4 Supervisor 16
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[2],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "LACalif@gamil.com",
                FullName = "LA Calif",
                LastName = "Calif",
                FirstName = "LA",
                Id = 120,
                ParentId = 16
            });
            retList.Add(new XPubEmployeeModel
            {
                Department = Departments[2],
                PhoneNumber = "",
                Role = Roles[2],
                EmailAddress = "NYCYork@gamil.com",
                FullName = "NYC York",
                LastName = "York",
                FirstName = "NYC",
                Id = 121,
                ParentId = 16
            });

            //admin 4 Supervisor 17
            return retList;
        }

    

        #endregion

        #region Utility Methods
        /// <summary>
        ///  FileRecordInformation method
        ///  Creates a record file object from the given input object
        /// </summary>
        /// <param name="filegroup">Group file belongs to</param>
        /// <param name="fileName">Name of file</param>
        /// <param name="fileType">Type of file</param>
        /// <param name="dateReceived">Date file received</param>
        /// <param name="fileSize">Length of file</param>
        /// <returns>IXPubRecordModel reference</returns>
        private IXPubRecordModel FileRecordInformation( string filegroup
             , string fileName 
            , string fileType
          , DateTimeOffset? dateReceived
            ,long? fileSize
            
            )
        {
            var xpub=new XPubRecordModel
            {
                FileName= fileName,
                DateReceived=dateReceived,
                FileSize=fileSize,
                FileType=fileType,
                IDString=filegroup

            } ;
            return xpub as IXPubRecordModel;
        }
        #endregion



    }
}
