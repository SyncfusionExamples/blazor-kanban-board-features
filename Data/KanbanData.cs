using System;
using System.Collections.Generic;

namespace Blazor_Kanban_Features.Data
{
    public class KanbanModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Summary { get; set; }
        public string Type { get; set; }
        public string Priority { get; set; }
        public double Estimate { get; set; }
        public string Assignee { get; set; }
        public int RankId { get; set; }
        public string Color { get; set; }

        public List<KanbanModel> GetTaskDetails()
        {
            Random rnd = new Random();
            const int rndMax = 5;
            const int cardCount = 25;
            List<KanbanModel> taskDetails = new List<KanbanModel>();
            var assignees = new string[] { "Steven walker", "Nancy Davloio", "Andrew Fuller", "Janet Leverling", "Robert King" };
            var status = new string[] { "Open", "InProgress", "Close", "Testing", "Close" };
            var types = new string[] { "Story", "Bug", "Story", "Bug", "Story" };
            var priorities = new string[] { "High", "Normal", "Critical", "Release Breaker", "High" };
            var colors = new string[] { "#8b447a", "#27AE60", "#cc0000", "#7d7297", "#6d7492" };
            var summaries = new string[]
            {
                "Analyze the new requirements gathered from the customer.",
                "Arrange a web meeting with the customer to get new requirements.",
                "Test your application in the Mac OS.",
                "Validate the issues reported by the customer.",
                "Stored procedure for initial data binding of the grid."
            };

            for (int colCount = 1; colCount <= cardCount; colCount++)
            {
                taskDetails.Add(new KanbanModel
                {
                    Id = colCount,
                    Title = "Task  - " + colCount,
                    Status = status[rnd.Next(rndMax)],
                    Summary = summaries[rnd.Next(rndMax)],
                    Type = types[rnd.Next(rndMax)],
                    Priority = priorities[rnd.Next(rndMax)],
                    Estimate = RankId = rnd.Next(rndMax),
                    Assignee = assignees[rnd.Next(rndMax)],
                    RankId = rnd.Next(rndMax),
                    Color = colors[rnd.Next(rndMax)]
                });
            }
            return taskDetails;
        }
    }
}
