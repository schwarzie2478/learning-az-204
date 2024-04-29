---
tags:
  - azure
type: term
definition: Azure Powershell
ms-learn-url: https://learn.microsoft.com/en-us/powershell/azure/context-persistence?view=azps-11.5.0
---
##  Install
Get-Module -Name Az -ListAvailable
Install-Module -Name Az -Repository PSGallery -Force

Update-Module Az

Connect-AZAccount


Keep login:  Azure PowerShell uses Azure PowerShell context objects (Azure contexts) to hold subscription and authentication information.    
 
Clear-AZContext to remove all stored credentials  
Save-AZContext -Path .local/schwarzie2478_context.json to save context to a file  
Import-AZContext to load context back in the session  

Autosaving:   Enable-AZContextAutoSave / Disable-AZContextAutoSave 

## Looking up an command

Neat little trick to find the comman you are looking for

  get-command *WebApp*



## AZureRM deprecated!
[Back to Index](Index.md)
