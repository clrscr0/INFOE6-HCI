# Fork the class repository and clone it:
1. In Github, click the fork button on the upper-right part of the repository. A copy of the repository will be added to your list of repositories.
2. On you computer, right-click on the folder where you want to clone the repository.
3. Open Git Bash and go to the folder in Step 2 via the Git Bash terminal.
4. Type `git clone https://github.com/<change-to-your-username>/INFOE6-HCI.git` in Git Bash. Wait for the cloning process to complete.
5. To go inside the project folder, type `cd INFOE6-HCI`

# Create your branch:
1. In Git Bash, type `git checkout -b <LastName-Firstname>`
2. Save your work in the "Class Output\<Path-to-Assignment-Or-Project>" folder. Submitted file should have a filename of LastName-FirstName.
3. Type `git status`. This will show the changes you made in red text.
4. Type `git add "Class Output"`.
5. Type `git commit -m "<Your comment>"`. Ex. `git commit -m "Added my donut assignment"`
6. (Optional) Repeat Step 3-5 if you have additional changes.
7. To push changes to the remote repository on GitHub, type `git push`
   * If using `git push` on the branch for the first time, type `git push origin HEAD` instead. If prompted to log in, select **Sign-In Using Browser** and input username and password on the browser opened by GitHub. 
		
# Pull request changes on GitHub:
1. Go to https://github.com/<your-username>/INFOE6-HCI.git
2. Click on **Pull Requests** tab.
3. Click on the **New pull request** button.
3. Make sure **compare** in **head** is pointing to the branch you created. 
4. Click **Create pull request**
5. Add reviewer
	![image](https://github.com/clrscr0/INFOE6-HCI/assets/2803908/690d1c65-0b6c-408f-9935-91b6956d6233)
