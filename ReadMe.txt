Problem statement of the project
	Create a project which will calculate team's velocity for the specified sprint.

Branching Strategy
	- we will be having master and dev branches as deafult branches.
	- every new branch should be created from dev branch and merged into dev branch.
	- Once dev is safe and ready all changes should go in master branch.

Naming a branch
	- Branch name should be same as issue name along with its issue number.
	- Point to consider is, branch name should be issue number followed by issue name.
	- E.g : #issueNumber-issueName

Creating a PR
	- Developed pull request should target none other than dev branch
	- Pull request name should be same as issue name
	- E.g (PullRequestName) : #issueNumber-issueName