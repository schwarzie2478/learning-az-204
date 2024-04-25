# Az Posershell Module


##  Install
Get-Module -Name Az -ListAvailable
Install-Module -Name Az -Repository PSGallery -Force

Update-Module Az

Connect-AZAccount


Keep login:  Azure PowerShell uses Azure PowerShell context objects (Azure contexts) to hold subscription and authentication information.    
  Ref: [link](https://learn.microsoft.com/en-us/powershell/azure/context-persistence?view=azps-11.5.0)
 
Clear-AZContext to remove all stored credentials  
Save-AZContext -Path .local/schwarzie2478_context.json to save context to a file  
Import-AZContext to load context back in the session  

Autosaving:   Enable-AZContextAutoSave / Disable-AZContextAutoSave  

## AZureRM deprecated!
[Back to Index](Index.md)
