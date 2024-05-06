---
status: planted
dg-publish: true
tags:
  - tool/git/tips
creation_date: 2024-05-06 09:25
definition: undefined
ms-learn-url: undefined
url: undefined
aliases:
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |
## Cause of the problem
Originated from the difference between Windows and other OS about how to handle newlines. Windows uses [[Carriage Return Line Feed|CRLF]] by default. Linux/MacOS use LF

## Autocrlf

Auto CRLF tells [[Git]] to replace all CRLF sequences with LF when you commit, and to replace all LF characters with CRLF sequences when you check out again. After turning that setting on, you might continue getting that warning for a while until any mismatched files have been committed and checked out again.

**How `autocrlf` works**:

```
core.autocrlf=true:      core.autocrlf=input:     core.autocrlf=false:

     repository               repository               repository
      ^      V                 ^      V                 ^      V
     /        \               /        \               /        \
crlf->lf    lf->crlf     crlf->lf       \             /          \
   /            \           /            \           /            \
```

Execute this command tp set it in your .gitconfig file (--global for every repo)
```shell
git config --global core.autocrlf true
```

you can override this setting also withan .gitattributes file in your repo

## SafeCRLF

The next setting that was introduced is `core.safecrlf` which is designed to protect against these cases where Git might change line endings on a file that really should just be left alone.

```shell
git config --global core.safecrlf false
```

- `core.safecrlf = true` - When getting ready to run this operation of replacing `CRLF` with `LF` before writing to the object database, Git will make sure that it can actually successfully back out of the operation. It will verify that the reverse can happen (`LF` to `CRLF`) and if not the operation will be aborted.

## .gitattibutes ( before git v1.7.2)

One final layer on all this is that you can create a file called `.gitattributes` in the root of your repository and add rules for specific files. These rules allow you to control things like `autocrlf` on a per file basis. So you could, for instance, put this in that file to tell Git to always replace `CRLF` with `LF` in txt files:

```
*.txt crlf
```

Or you could do this to tell Git to never replace `CRLF` with `LF` for txt files like this:

```
*.txt -crlf
```

Or you could do this to tell Git to only replace `CRLF` with `LF` when writing, but to read back `LF` when writing the working directory for txt files like this:

```
*.txt crlf=input
```


## The New System

Enter the new system which is available in Git 1.7.2 and above.

The new system moves to defining all of this in the .gitattributes file that you keep with your repository. This means that line endings can be encapsulated entirely within a repository and don’t depend on everyone having the proper global settings.

In the new system you are in charge of telling git which files you would like CRLF to LF replacement to be done on. This is done with a text attribute in your repository’s .gitattributes file. In this case the man page is actually quite helpful. Here are some examples of using the text attribute:

*.txt text Set all files matching the filter *.txt to be text. This means that Git will run CRLF to LF replacement on these files every time they are written to the object database and the reverse replacement will be run when writing out to the working directory.
*.txt -text Unset all files matching the filter. These files will never run through the CRLF to LF replacement.
*.txt text=auto Set all files matching the filter to be converted (CRLF to LF) if those files are determined by Git to be text and not binary. This relies on Git’s built in binary detection heuristics.
If a file is unspecified then Git falls back to the core.autocrlf setting and you are back in the old system. This is how backwards compatibility is maintained, but I would recommend (especially for Windows developers) that you explicitly create a .gitattributes file.>)


Here is an example you might use for a C# project:

```
# These files are text and should be normalized (convert crlf =&gt; lf)
*.cs      text diff=csharp
*.xaml    text
*.csproj  text
*.sln     text
*.tt      text
*.ps1     text
*.cmd     text
*.msbuild text
*.md      text

# Images should be treated as binary
# (binary is a macro for -text -diff)
*.png     binary
*.jepg    binary

*.sdf     binary
```

## Final Note

One final note that the [[man page]] of [[gitattributes]] mentions is that you can tell git to detect _all_ text files and automatically normalize them (convert `CRLF` to `LF`):

```
*       text=auto
```

This is certainly better than requiring everyone to be on the same global setting for `core.autocrlf`, but it means that you really trust Git to do binary detection properly. In my opinion it is better to explicitly specify your text files that you want normalized. Don’t forget if you are going to use this setting that it should be the first line in your .gitattributes file so that subsequent lines can override that setting.
