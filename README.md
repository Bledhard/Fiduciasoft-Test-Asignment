# Fiduciasoft Test Asignment

Core project contains model and data service for application which organizes teams of people. This is just a starting point. 
Feel free to change them as you need. For simplicity data service uses in-memory data. Keep it like this. We don't need persistent between app runs.


Time limit:
* 90 minutes
* Whatever you can do in 90 minutes is fine. The goal is not having complete solution. The goal is to have extendable and maintainable starting point for further application development.


Your task is to build an app that does following:

```
Given I'm in the app
When I navigate to Home page
Then I see all teams (with team name)
```

```
Given I'm on Home page
When I choose a team
Then I see Team Details (with team name and people belonging to the team)
```

```
Given I'm on Team Details page
When I add person to the team
Then person becomes a member of the team
```
