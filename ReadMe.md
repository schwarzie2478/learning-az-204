# Study Notes AZ-204

## Starting

Registered for Certificate  [Azure Developer Aspirant](https://learn.microsoft.com/en-us/credentials/certifications/azure-developer/?practice-assessment-type=certification)

Udemy learning path with  workspaces to try out stuff

Login: [Credentials](.local/Credentials.md) (not uploaded)

Demo resource group: Regroup_2sCSVyw

## Day 1 Notes:

Azure CLI [link](https://learn.microsoft.com/en-us/cli/azure/)

Azure Cloud shell


### [Lab 01](Labs/Lab%2001/ReadMe.md)




## Side Notes

### Azure CLI uses python packages for extentions

Ref: [link](https://github.com/Azure/azure-cli/tree/master)  
Notable python package wheel ( *.whl)

Format:
  chardet-3.0.4-py2.py3-none-any.whl  
You can break this down into its tags:

* chardet is the package name.
* 3.0.4 is the package version of chardet.
* py2.py3 is the Python tag, meaning the wheel supports Python 2 and 3 with any Python implementation.
* none is the ABI tag, meaning the ABI isn’t a factor. ABI stands for application binary interface.
* any is the platform. This wheel will work on virtually any platform.



Usage:  
az version  
az upgrade  
az extension update --name azure-devops --verbose


## Generate index.md

$list = gci '*.md' -Recurse | ?{ $_.Name -ne "ReadMe.md"}| Resolve-Path -Relative 
$list | set-content index.md 

TODO: Add step to provide back reference to index.md 

[Back to Index](Index.md)
