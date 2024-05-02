---
dg-publish: true
tags:
  - concept/SRE/cloud
---


From https://www.getambassador.io/blog/7-rest-api-design-best-practices
## Utilise the Recommended Endpoint Naming Conventions
## Use the Appropriate HTTP Method
## Manage REST API Requests and Responses Effectively
## Use the Appropriate Request Headers for Authentication
## Know When to use Parameters vs. Query Parameters
## Provide Informative and Actionable Error Messages
## Create an API Documentation and Version your REST APIs
## Adopt These Performance Optimization Techniques
1. Use caching mechanisms to store frequently accessed data and reduce the load on the server. This can significantly improve response times when sending data between client and server and also reduce network traffic.
2. Implement pagination to retrieve large datasets in smaller and more manageable chunks to ensure an optimized API design. By returning a limited number of results per page and providing navigation links, APIs can efficiently handle large amounts of data.
3. Apply compression techniques, such as gzip, to reduce the size of data transferred between the client and server. This will improve response times for bandwidth-constrained environments and your application specific architectural constraints.
4. Leverage rate limiting and throttling mechanisms to control the number of requests allowed from a particular client within a specific timeframe. This will prevent abuse and ensure fair usage of your REST API resources.
## Apply These Security Best Practices
1. Properly validate and sanitize user inputs received on the server side. Also, encode the API responses to prevent malicious code execution. Following this will protect your REST APIs against vulnerabilities like SQL injection and cross-site scripting (XSS).
2. Implement foolproof authentication and RBAC (Role-Based Access Control) mechanisms to protect your database resources from being accessed by unauthorized users. Your REST APIs are a [gateway](https://www.getambassador.io/docs/edge-stack/latest/topics/using/gateway-api/) to your database, and you should ensure that all of your data is only accessed by users who are allowed to access it.
3. Employ tools like Edge Stack as an API gateway solution for additional security features. It acts as a centralized entry point for all [API traffic](https://www.getambassador.io/products/edge-stack/api-gateway/traffic-management), enabling traffic encryption through SSL/TLS and offering protection against common attacks like DDoS (Distributed Denial-of-Service).