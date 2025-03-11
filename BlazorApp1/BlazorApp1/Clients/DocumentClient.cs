using BlazorApp1.Models;


namespace BlazorApp1.Clients
{
    public class DocumentClient
    {
        private readonly List<DocumentSummary> documents =
        [
            new(){
                Id =1,
                Name = "Minutes", 
                Price = 69.99M, 
                LastUpdated = new DateOnly(2014, 11, 10), 
                Complete = true,
                Type = "Service Request", 
                DateCreated = new DateOnly(2025,11,3), 
                Customer = "Power Fashion Stores", 
                Site = "Primary Location", 
                User = "Junaid Chetty", 
                Summary = "(Describe your problem here)",  
                Status = "Open",
                SLATimeLeft = 3215, //time in minutes
                Priority = "Medium",
                TimeTaken = 2135, //time in minutes
                Agent = "Kyle Bernardo",
                TicketAge = 0.11f, //age in days
                WorkingHours = "TheBevCo",
                Team = "SS - Desktop",
                LastActionDate = new DateOnly(2025,11,3),
                Category = "Hardware>Printer",
                DateClosed = new DateOnly(2025,11,3),
            },
        ];


        public DocumentSummary[] GetDocs() => [.. documents];

        public void AddDocument(DocumentDetails document)
        {

            var documentSummary = new DocumentSummary
            {
                Id = documents.Count + 1,
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
            };

            documents.Add(documentSummary);
        }
        public DocumentDetails GetDoc(int id)
        {
            DocumentSummary? document = GetDocSummaryById(id);

            return new DocumentDetails
            {
                Id = document.Id,
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

            };

        }


        public void UpdateDocument(DocumentDetails updatedDocument)
        {
            DocumentSummary existingDocument = GetDocSummaryById(updatedDocument.Id);

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
