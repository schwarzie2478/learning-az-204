---
status: planted
dg-publish: true
tags:
  - tool/git/tips
creation_date: 2024-05-05 22:53
definition: "The BFG Repo-Cleaner is a simpler, faster alternative to git-filter-branch for cleansing bad data out of your Git repository history:"
ms-learn-url: undefined
url: https://rtyley.github.io/bfg-repo-cleaner/
aliases:
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |
- Removing **Crazy Big Files**
- Removing **Passwords**, **Credentials** & other **Private data**

Get bare repo ( not files, just .git folder)

```
$ git clone --mirror git://example.com/some-big-repo.git
```

Now you can run the BFG to clean your repository up:

```
$ java -jar bfg.jar --strip-blobs-bigger-than 100M some-big-repo.git

```

The BFG will update your commits and all branches and tags so they are clean, but it doesn't physically delete the unwanted stuff.

Clean up reference in git database
```
git reflog expire --expire=now --all && git gc --prune=now --aggressive
```

Finally, once you're happy with the updated state of your repo, push it back up _(note that because your clone command used the `--mirror` flag, this push will update **all** refs on your remote server)_:

```
$ git push
```