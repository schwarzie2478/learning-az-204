---
status: tree
dg-publish: true
tags:
  - tool/az
  - tool/powershell/az
  - tool/chrome
creation_date: 2024-05-03 16:18
---

While working with [[Azure CLI|az]] or [[AZ Powershell Module|powershell]], suddenly I got an login error.

After the login in the browser ( Chrome and Edge) the browser couldn't redirect to http://localhost:8400

For some reason this can happen if localhost is not exclude from the [[HTTP Strict Transport Security|HSTS]] security rules.
the redirect is changed to https, but the CLI tools can only handle http

--> need to exclude localhost from these rules

How-To:

Go To  chrome://net-internals/#hsts
In the section of Delete domain security policies
fill in localhost as domain and click delete.

After restarting the browser(required!) the login should work again!

