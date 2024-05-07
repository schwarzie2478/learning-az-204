---
status: tree
dg-publish: true
tags:
  - tool/npm
creation_date: 2024-05-07 23:53
definition: After installing Node 20 I got this error
ms-learn-url: undefined
url: undefined
aliases:
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |
## Problem

After installing Node 20 I got this error:

```
C:\Users\Stijn\AppData\Roaming\npm/node_modules/npm/bin/npm-cli.js
node:internal/modules/cjs/loader:1148
  throw err;
  ^

Error: Cannot find module 'C:\Users\Stijn\AppData\Roaming\npm\node_modules\npm\bin\npm-cli.js'
    at Module._resolveFilename (node:internal/modules/cjs/loader:1145:15)
    at Module._load (node:internal/modules/cjs/loader:986:27)
    at Function.executeUserEntryPoint [as runMain] (node:internal/modules/run_main:174:12)
    at node:internal/main/run_main_module:28:49 {
  code: 'MODULE_NOT_FOUND',
  requireStack: []
}
```

Uninstalling didn't work 
Cleaning up the PATH variable work

## Solution

Finally I discoved that this was only a problem when working in powershell -> node.ps1 gives issues when finding the folder for npm.

so apparently the node.cmd was working fine

Solution found on [StackOverflow](https://www.reddit.com/r/node/comments/1cfe2ub/comment/l1uiziw/?utm_source=share&utm_medium=web3x&utm_name=web3xcss&utm_term=1&utm_content=share_button)

To fix it for powershell again:

```
npm.cmd i -g npm
```



