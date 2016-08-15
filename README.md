# git-issuer
Just a small tool to get and create issues on github.

You just need an instance of GitIssuer:
var gitIssuer = new GitIssuer(gitUser, gitPassword, gitRepName, gitRepOwner);

// to filter the result
var criterias = new Dictionary<string, string>()
{
  { "state", "open" }
};

// to get a list of issues
var issues = gitIssuer.GetIssues(criterias);

// to create an issue
var labels = new string[]{"my label"};
var assignees = new string[]{"GitUser1", "GitUser2"};

gitIssuer.CreateIssue("Title", "Body", assignees, labels);
