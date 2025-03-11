using BlazorApp1.Models;


namespace BlazorApp1.Clients
{
    public class DocumentClient
    {
        private readonly List<DocumentSummary> documents =
        [
            new(){
                Id =1,
                Brand = "Tertiary",
                Campus = "Rosebank College Pretoria CBD",
                UserName = "Sunnyboy Rasebeka",
                UserEmail = "srasebeka@rosebankcollege.co.za",
                UserContactNumber = "060 582 9269",
                PrimaryContact = true,
                TroubleshooterName = "Sunnyboy Rasebeka",
                TroubleshooterEmail = "srasebeka@rosebankcollege.co.za",
                TroubleshooterContactNumber = "012 320 7270",
                SiteAddress = "239 Southern Life Building Cnr Pretorius and Thabo Sehume Pretoria CBD",
                EquipmentMake = "HP",
                EquipmentModel = "HP 255 G9",
                EquipmentProductNumber = "6Q7Y7ES",
                EquipmentSerialNumber = "CND3131JYG",
                FaultDescription = "Laptop fan is making noise when powered on. Kindly refer to the attached clip.",


                //Name = "Minutes",
                //Price = 69.99M,
                //LastUpdated = new DateOnly(2014, 11, 10),
                //Complete = true,
                //Type = "Service Request", 
                //DateCreated = new DateOnly(2025,11,3), 
                //Customer = "Power Fashion Stores", 
                //Site = "Primary Location", 
                //User = "Junaid Chetty", 
                //Summary = "(Describe your problem here)",  
                //Status = "Open",
                //SLATimeLeft = 3215, //time in minutes
                //Priority = "Medium",
                //TimeTaken = 2135, //time in minutes
                //Agent = "Kyle Bernardo",
                //TicketAge = 0.11f, //age in days
                //WorkingHours = "TheBevCo",
                //Team = "SS - Desktop",
                //LastActionDate = new DateOnly(2025,11,3),
                //Category = "Hardware>Printer",
                //DateClosed = new DateOnly(2025,11,3),
            },
        ];


        public DocumentSummary[] GetDocs() => [.. documents];

        public void AddDocument(DocumentDetails document)
        {

            var documentSummary = new DocumentSummary
            {
                Id = documents.Count + 1,
                Brand = document.Brand,
                Campus = document.Campus,
                UserName = document.UserName,
                UserEmail = document.UserEmail,
                UserContactNumber = document.UserContactNumber,
                PrimaryContact = document.PrimaryContact,
                TroubleshooterName = document.TroubleshooterName,
                TroubleshooterEmail = document.TroubleshooterEmail,
                TroubleshooterContactNumber = document.TroubleshooterContactNumber,
                SiteAddress = document.SiteAddress,
                EquipmentMake = document.EquipmentMake,
                EquipmentModel = document.EquipmentModel,
                EquipmentProductNumber = document.EquipmentProductNumber,
                EquipmentSerialNumber = document.EquipmentSerialNumber,
                FaultDescription = document.FaultDescription,

                /*
                Name = document.Name,
                Price = document.Price,
                LastUpdated = document.LastUpdated,
                Complete = document.Complete,
                Type = document.Type,
                DateCreated = document.DateCreated,
                Customer = document.Customer,
                Site = document.Site,
                User = document.User,
                Summary = document.Summary,
                Status = document.Status,
                SLATimeLeft = document.SLATimeLeft,
                Priority = document.Priority,
                TimeTaken = document.TimeTaken,
                Agent = document.Agent,
                TicketAge = document.TicketAge,
                WorkingHours = document.WorkingHours,
                Team = document.Team,
                LastActionDate = document.LastActionDate,
                Category = document.Category,
                DateClosed = document.DateClosed,
                */
            };

            documents.Add(documentSummary);
        }
        public DocumentDetails GetDoc(int id)
        {
            DocumentSummary? document = GetDocSummaryById(id);

            return new DocumentDetails
            {
                Id = document.Id,
                Brand = document.Brand,
                Campus = document.Campus,
                UserName = document.UserName,
                UserEmail = document.UserEmail,
                UserContactNumber = document.UserContactNumber,
                PrimaryContact = document.PrimaryContact,
                TroubleshooterName = document.TroubleshooterName,
                TroubleshooterEmail = document.TroubleshooterEmail,
                TroubleshooterContactNumber = document.TroubleshooterContactNumber,
                SiteAddress = document.SiteAddress,
                EquipmentMake = document.EquipmentMake,
                EquipmentModel = document.EquipmentModel,
                EquipmentProductNumber = document.EquipmentProductNumber,
                EquipmentSerialNumber = document.EquipmentSerialNumber,
                FaultDescription = document.FaultDescription,

                /*
                Name = document.Name,
                Price = document.Price,
                LastUpdated = document.LastUpdated,
                Complete = true,
                Type = document.Type,
                DateCreated = document.DateCreated,
                Customer = document.Customer,
                Site = document.Site,
                User = document.User,
                Summary = document.Summary,
                Status = document.Status,
                SLATimeLeft = document.SLATimeLeft,
                Priority = document.Priority,
                TimeTaken = document.TimeTaken,
                Agent = document.Agent,
                TicketAge = document.TicketAge,
                WorkingHours = document.WorkingHours,
                Team = document.Team,
                LastActionDate = document.LastActionDate,
                Category = document.Category,
                DateClosed = document.DateClosed
                */
            };

        }


        public void UpdateDocument(DocumentDetails updatedDocument)
        {
            DocumentSummary existingDocument = GetDocSummaryById(updatedDocument.Id);

            existingDocument.Brand = updatedDocument.Brand;
            existingDocument.Campus = updatedDocument.Campus;
            existingDocument.UserName = updatedDocument.UserName;
            existingDocument.UserEmail = updatedDocument.UserEmail;
            existingDocument.UserContactNumber = updatedDocument.UserContactNumber;
            existingDocument.PrimaryContact = updatedDocument.PrimaryContact;
            existingDocument.TroubleshooterName = updatedDocument.TroubleshooterName;
            existingDocument.TroubleshooterEmail = updatedDocument.TroubleshooterEmail;
            existingDocument.TroubleshooterContactNumber = updatedDocument.TroubleshooterContactNumber;
            existingDocument.SiteAddress = updatedDocument.SiteAddress;
            existingDocument.EquipmentMake = updatedDocument.EquipmentMake;
            existingDocument.EquipmentModel = updatedDocument.EquipmentModel;
            existingDocument.EquipmentProductNumber = updatedDocument.EquipmentProductNumber;
            existingDocument.EquipmentSerialNumber = updatedDocument.EquipmentSerialNumber;
            existingDocument.FaultDescription = updatedDocument.FaultDescription;



            /*
            existingDocument.Name = updatedDocument.Name;
            existingDocument.Price = updatedDocument.Price;
            existingDocument.LastUpdated = updatedDocument.LastUpdated;
            existingDocument.Complete = updatedDocument.Complete;
            existingDocument.Type = updatedDocument.Type;
            existingDocument.DateCreated = updatedDocument.DateCreated;
            existingDocument.Customer = updatedDocument.Customer;
            existingDocument.Site = updatedDocument.Site;
            existingDocument.User = updatedDocument.User;
            existingDocument.Summary = updatedDocument.Summary;
            existingDocument.Status = updatedDocument.Status;
            existingDocument.SLATimeLeft = updatedDocument.SLATimeLeft;
            existingDocument.Priority = updatedDocument.Priority;
            existingDocument.TimeTaken = updatedDocument.TimeTaken;
            existingDocument.Agent = updatedDocument.Agent;
            existingDocument.TicketAge = updatedDocument.TicketAge;
            existingDocument.WorkingHours = updatedDocument.WorkingHours;
            existingDocument.Team = updatedDocument.Team;
            existingDocument.LastActionDate = updatedDocument.LastActionDate;
            existingDocument.Category = updatedDocument.Category;
            existingDocument.DateClosed = updatedDocument.DateClosed;
            */


        }

        public void DeleteDocument(int id)
        {
            DocumentSummary document = GetDocSummaryById(id);
            documents.Remove(document);
        }

        //HELPER METHODS


        private DocumentSummary GetDocSummaryById(int id)
        {
            DocumentSummary? document = documents.Find(document => document.Id == id);
            ArgumentNullException.ThrowIfNull(document);
            return document;
        }
    }

}
