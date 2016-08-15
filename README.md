# git-issuer
Just a small tool to get and create issues on github.

You just need an instance of GitIssuer:
<br>
<br>
var gitIssuer = new GitIssuer(gitUser, gitPassword, gitRepName, gitRepOwner);

// to filter the result<br>
var criterias = new Dictionary<string, string>()
{
  { "state", "open" }
};

// to get a list of issues<br>
var issues = gitIssuer.GetIssues(criterias);

// to create an issue<br>
var labels = new string[]{"my label"};<br>
var assignees = new string[]{"GitUser1", "GitUser2"};<br>

gitIssuer.CreateIssue("Title", "Body", assignees, labels);
