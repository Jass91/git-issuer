using System.Collections.Generic;


namespace GitIssuer.Models
{
    public class GitIssue
    {
        public GitUser user { get; set; }
        public GitUser assignee { get; set; }
        public GitUser []assignees { get; set; }
        public string []labels { get; set; }
        public string []milestone { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string closed_at { get; set; }
        public string url { get; set; }
        public string repository_url { get; set; }
        public string labels_url { get; set; }
        public string comments_url { get; set; }
        public string events_url { get; set; }
        public string html_url { get; set; }
        public string title { get; set; }
        public string state { get; set; }
        public string body { get; set; }
        public bool locked { get; set; }
        public int comments { get; set; }
        public int number { get; set; }
        public int id { get; set;}
       
    }
}
