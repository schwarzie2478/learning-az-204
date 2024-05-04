---
status: seedling
dg-publish: true
definition: An extracted list from the commandline tools for reference
tags:
  - concept/SRE/cloud/azure
creation_date: 2024-05-02 18:40

---
```powershell
Get-AzLocation | 
	select DisplayName, Location,GeographyGroup,PhysicalLocation | 
	%{ 
		"| " + $_.DisplayName + 
		" | " + $_.Location + 
		" | " + $_.GeographyGroup + 
		" | " + $_.PhysicalLocation + 
		" |"
	   }
 
```

Listing of possible [[Azure Location]]:

| DisplayName          | Location           | GeographyGroup | PhysicalLocation |
| -------------------- | ------------------ | -------------- | ---------------- |
| Asia                 | asia               |                |                  |
| Asia Pacific         | asiapacific        |                |                  |
| Australia            | australia          |                |                  |
| Australia Central    | australiacentral   | Asia Pacific   | Canberra         |
| Australia Central 2  | australiacentral2  | Asia Pacific   | Canberra         |
| Australia East       | australiaeast      | Asia Pacific   | New South Wales  |
| Australia Southeast  | australiasoutheast | Asia Pacific   | Victoria         |
| Brazil               | brazil             |                |                  |
| Brazil South         | brazilsouth        | South America  | Sao Paulo State  |
| Brazil Southeast     | brazilsoutheast    | South America  | Rio              |
| Canada               | canada             |                |                  |
| Canada Central       | canadacentral      | Canada         | Toronto          |
| Canada East          | canadaeast         | Canada         | Quebec           |
| Central India        | centralindia       | Asia Pacific   | Pune             |
| Central US           | centralus          | US             | Iowa             |
| Central US EUAP      | centraluseuap      | US             |                  |
| East Asia            | eastasia           | Asia Pacific   | Hong Kong        |
| East US              | eastus             | US             | Virginia         |
| East US 2            | eastus2            | US             | Virginia         |
| East US 2 EUAP       | eastus2euap        | US             |                  |
| Europe               | europe             |                |                  |
| France               | france             |                |                  |
| France Central       | francecentral      | Europe         | Paris            |
| France South         | francesouth        | Europe         | Marseille        |
| Germany              | germany            |                |                  |
| Germany North        | germanynorth       | Europe         | Berlin           |
| Germany West Central | germanywestcentral | Europe         | Frankfurt        |
| Global               | global             |                |                  |
| India                | india              |                |                  |
| Israel Central       | israelcentral      | Middle East    | Israel           |
| Italy North          | italynorth         | Europe         | Milan            |
| Japan                | japan              |                |                  |
| Japan East           | japaneast          | Asia Pacific   | Tokyo, Saitama   |
| Japan West           | japanwest          | Asia Pacific   | Osaka            |
| Korea                | korea              |                |                  |
| Korea Central        | koreacentral       | Asia Pacific   | Seoul            |
| Korea South          | koreasouth         | Asia Pacific   | Busan            |
| Mexico Central       | mexicocentral      | Mexico         | Querétaro State  |
| North Central US     | northcentralus     | US             | Illinois         |
| North Europe         | northeurope        | Europe         | Ireland          |
| Norway               | norway             |                |                  |
| Norway East          | norwayeast         | Europe         | Norway           |
| Norway West          | norwaywest         | Europe         | Norway           |
| Poland Central       | polandcentral      | Europe         | Warsaw           |
| Qatar Central        | qatarcentral       | Middle East    | Doha             |
| Singapore            | singapore          |                |                  |
| South Africa         | southafrica        |                |                  |
| South Africa North   | southafricanorth   | Africa         | Johannesburg     |
| South Africa West    | southafricawest    | Africa         | Cape Town        |
| South Central US     | southcentralus     | US             | Texas            |
| South India          | southindia         | Asia Pacific   | Chennai          |
| Southeast Asia       | southeastasia      | Asia Pacific   | Singapore        |
| Sweden               | sweden             |                |                  |
| Sweden Central       | swedencentral      | Europe         | Gävle            |
| Switzerland          | switzerland        |                |                  |
| Switzerland North    | switzerlandnorth   | Europe         | Zurich           |
| Switzerland West     | switzerlandwest    | Europe         | Geneva           |
| UAE Central          | uaecentral         | Middle East    | Abu Dhabi        |
| UAE North            | uaenorth           | Middle East    | Dubai            |
| UK South             | uksouth            | Europe         | London           |
| UK West              | ukwest             | Europe         | Cardiff          |
| United States        | unitedstates       |                |                  |
| West Central US      | westcentralus      | US             | Wyoming          |
| West Europe          | westeurope         | Europe         | Netherlands      |
| West India           | westindia          | Asia Pacific   | Mumbai           |
| West US              | westus             | US             | California       |
| West US 2            | westus2            | US             | Washington       |
| West US 3            | westus3            | US             | Phoenix          |