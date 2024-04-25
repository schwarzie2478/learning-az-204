# Azure Virtual Machine

Not required for Certicate


VM are Infrastructure as a service (IAAS)
    * must have network access configured
## Create VM

### Availibilty Options

Ref: [link](https://learn.microsoft.com/en-us/azure/virtual-machines/availability)

How much redundancy do you need?

Availibility Set -> resources for availibility that shouldn't be grouped together
Availibility Zone -> separate within the same zone ( or in the same datacenter but separate infrastructure)
Virtual Machine scale Set => scales based of demand mostly

Azure Spot Instance:  request a machine with reduced prizing, but will run when a machine is availible to run it


### Size options

B series are the cheapest general purposes
(Burstable)
B2ms popular option

Azure Hybrid Benefit: re-use windows license to reduce cost of VM
--> check if you have licenses free before adding this

### Encryption of disk

the disks are encrypted by default

You can provide a customer key, if you need to make sure Microsoft can't access your VM
Provided through Azure Key Vault

Even double encryption is possible ( MS + customer key)

### Data Disks

Attach a existing disk with data already present, idependant from VM

### networking

open the ports you need ( f.e.:  80,443,8080,22,3389)

### Boot settings

best disable boot diagnostics

auto shutdown good for development instances

disaster recovery -> provide an image to be launched in other region

provision script/data/


Azure Dedicated Host
reserve your own machine if you want to be separate from other azure clients

reserve capacity: hold reserved resources, but you pay continuously for them

proximity group: try to place the resources closes together

### tags

metadata to provide additional information about your resources



## Connect to vm

### RDP ( windows only)

Download rdp file from azure portal

### ssh

during creation azure can generate adm_user.pem file for you to store locally to connect to VM

use this to connect:

ssh -i C:\Users\Stijn\.ssh\adm-supervisuer.pem azureuser@68.219.185.1042

## Back-up configuration

Back-up are stored an recovery service vault
Default option does the following :
* Back-up once a day
* 1-5 day operational tier

## Stopping the VM

check if you need the public ip reserved or not

