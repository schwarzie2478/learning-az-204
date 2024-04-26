# Azure Key Vault

Storage of secrets and certificates to be used by your resources

Create certificate service principle

## Create a service principal storing the certificate in Azure Key Vault
az ad sp create-for-rbac --name myServicePrincipalName \
                         --role roleName \
                         --scopes /subscriptions/mySubscriptionID/resourceGroups/myResourceGroupName \
                         --create-cert \
                         --cert myCertificateName \
                         --keyvault myVaultName


## Retrieve certificate
az keyvault secret download --file /path/to/cert.pfx \
                            --vault-name VaultName \
                            --name CertName \
                            --encoding base64
openssl pkcs12 -in cert.pfx -passin pass: -out cert.pem -nodes

## use certificate
az login --service-principal \
         --username myServicePrincipalID \
         --tenant myOwnerOrganizationId \
         --password /path/to/cert
