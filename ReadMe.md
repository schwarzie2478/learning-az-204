# Study Notes AZ-204

## Starting

Udemy learning path with  workspaces to try out stuff

Login: [Credentials](Credentials.md)

Demo resource group: Regroup_2sCSVyw

## Day 1 Notes:


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


