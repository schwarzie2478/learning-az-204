---
status: planted
dg-publish: true
tags:
  - concept/SRE
definition: Git is a free and open source distributed version control system designed to handle everything from small to very large projects with speed and efficiency.
url: https://git-scm.com/
creation_date: 2024-05-02 16:53

---
Type of [[Source Control]]

Versioning in Git:  [[GitVersion]]
## Usage
### Typical commands:
```shell
git init
git clone repo-url
git checkout -b feature/myfeature
git checkout master
git merge feature/myfeature
git add .
git commit -m"message"
git push -u origin HEAD
git pull
```

### git aliases
```shell
[alias]
	co = checkout
	com = checkout master
	cof = "!git checkout -B feature/$1 && echo Created feature branch "
	cob = "!git checkout -B bugfix/$1 && echo Created bugfix branch "c
	pushh = push origin head
	list = branch -l
	undo = reset --soft HEAD~1
	diff-words = diff --color-words='[^[:space:]]|([[:alnum:]]|UTF_8_GUARD)+'
	lol = log --graph --decorate --pretty=oneline --abbrev-commit
    lola = log --graph --decorate --pretty=oneline --abbrev-commit --all
```
