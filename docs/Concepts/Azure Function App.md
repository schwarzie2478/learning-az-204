---
status: planted
dg-publish: true
tags:
  - concept/SRE/cloud/azure
creation_date: 2024-05-07 21:08
definition: A function app provides an execution context in Azure in which your functions run.
ms-learn-url: undefined
url: undefined
aliases:
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

## What is an Function App

A function app is composed of one or more individual [[Azure Functions]] that are managed, deployed, and scaled together. 

All of the functions in a function app share the same [[Azure App Service Plan]], deployment method, and runtime version. 

> [!summary]
> Think of a function app as a way to organize and collectively manage your functions.


In [[Azure Functions runtime#Functions 2.x|Functions 2.x]] all functions in a function app must be authored in the same language. 
In previous versions of the [[Azure Functions runtime]], this wasn't required.

## Folder structure

### Code
The code for all the functions in a specific function app is located in a root project folder that contains a host configuration file. 
### host.json
The [[host.json]] file contains runtime-specific configurations and is in the root folder of the function app. 
### bin folder

A _bin_ folder contains packages and other library files that the function app requires. 
### language specific folder structures

Specific folder structures required by the function app depend on language:

