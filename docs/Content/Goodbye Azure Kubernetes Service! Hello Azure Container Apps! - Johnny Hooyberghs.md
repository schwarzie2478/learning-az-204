---
status: stone
dg-publish: true
tags:
  - content/video/youtube
creation_date: 2024-05-04 20:57
definition: ACA or Azure Container Apps are Microsoft Azure's new serverless container offering, built as an abstraction on top of AKS, and could be the solution to your question!
ms-learn-url: undefined
url: https://www.youtube.com/watch?v=yGrE_yKWo58
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |

![View](https://www.youtube.com/watch?v=yGrE_yKWo58)
## Callouts View
```dataviewjs
const regex = new RegExp(">\\s\\[\\![a-z]*\\]\\s(.+?)(\\n>\\s.*?)*\\n", "gi")
let page = dv.current()
const content = await dv.io.load(page.file.path)
const rows = []
for(const callout of content.match(regex)|| [])
{
	rows.push(callout)
}
dv.list(rows)
```

## Transcription

 [[Azure Container Apps]] 
 
  No professional experience with [[Azure kubernetes service]] 
  
![[Containers#Why we need containers and why we are using containers today]]

### Azure Service

there's a lot of services we can already used today that have support for containers in  we have the web application just your service app or your web app 
you can also deploy that as a container so you can containerize your application
and that can run in whatever technology doesn't need to be .net or can be whatever you want basically that's the concept of a container and you can deploy that to your web app and that will also work but that's just running one container in one web app that has  a web UI for example or or a web API

next we have the function app or the serverless offering 

> [!quote]
> For function apps in in Azure this also has support for containers 

you can put your function app inside of a container and deploy the container to a function app in Azure so
the services we all know you want want to do some orchestration you want to have multiple containers working together you maybe have a distributed application or a microservices application that consists out of multiple of these containers and they need to work together 

> [!quote]
> well the first step Microsoft did was doing the [[Azure Container Instance]] which is still only running one container in one container instance service

 but then  we also now have container apps and container apps is a little bit like container instance but 

> [!quote]
>  now you have multiple containers that can run within a single container app 

 and you can have multiple container apps working together to build your distributed application and then  course on the on the right hand side 
 

> [!quote]
>  we have [[Azure kubernetes service]] where [[Kubernetes]] is your [[orchestrator]] 

 
it will orchestrate all of your containers they  will work together  and this is also availablein Azure and actually

Azure container  Services was first Microsoft implemented a managed version
of azure   of kubernetes  the [[Azure kubernetes service]]

> [!quote] 
> they basically saw that developers don't want to care about all of the infrastrure that isthat is needed to work with kubernetes so they basically built an abstraction layer on top of kubernetes and that is called [[Azure container apps]]

to make it easier for us developers to work with the complexities of container orchestration so again this talk is not like an kubernetes versus container apps  

> [!quote]
> the container apps is an option it works in a very similar way to Azure  kubernetes service

unfortunately the namings are a little bit different sometimes so I will explain the differences but 

> [!quote]
> kubernetes can still be a very valid option for you if you really want to have the full flexibility on how you do your  container landscape and which open source tools you want to use in combination with 

that so again kubernetes is still a viable
options but also container apps so what is container apps of course it is
there for you to deploy your distributed or microservices application so if your
application exists out of multiple components that need to work together container apps can really be a solution
for you it is serverless if needed which means that for example in in
kubernetes you need to specify the virtual machine nodes that are available
for you to run your containers on that is not lless because you need to
specify before you run any containers what your nodes are and what the size of
your nodes is and how many nodes you have in container apps you can go full fully server serverless which means that
Microsoft Azure will do that for you it will basically scale your applications for you and you don't need to worry
about how many how many nodes you need to actually make that work and
it says if needed and I will show you  in the demo later you can still
specify the notes if you really need to in Azure container apps but by default you don't have to so you have both
optionsof course it it's it'sit's a very good  service to run your
Cloud native apps because you put them in containers and they will just work and it's also built on top of Open
Source software components so all of the software that lives inside of that abstraction layer that is azure
container apps is built on open  softare  open source software components and 
I have listed a couple of them in the bottom for example 

> [!quote]
> it is built on top of kubernetes so Azure container apps is just kubernetes 

it's just that layer of abstraction on top of kubernetes 

> [!quote]
> it uses [[Kubernetes Event-driven Autoscaling|KEDA]]  it  gives you the opportunity to autoscale your application 

based on the
Keda open- Source software tool that helps you with that 

> [!quote]
> it also has support by default for [[Dapr]] 

[[Dapr]] is the 
distributed application runtime and I will talk about that  in the end of my presentation which   and then 

> [!quote]
> finally  using [[Envoy]]  for your [[service Discovery Ingress]]

 and stuff like that so these components in kubernetes you can basically choose them in kubernetes if you want to use something different you can 

> [!quote]
>  in  container apps you're basically stuck with these because they are used by the Microsoft teams to build our container app as that layer of abstraction 
> but they are open source so  with that you can actually  find a lot of docentation

find a lot of help and
find a lot of  components with thatthat will make your applications  work
as I already told you it scales dynamically and it can even scale to zero so if you're going completely
serverless and you don't specify your nodes you can scale your application to zero if needed which means that if
there's no usage if there's no HTTP requests for example you can completely scale down to zero and you don't pay
anything  which is nice if you of course in kubernetes select an amount of nodes you pay for the virtual machines
that run your nodes  and you will pay for them always even if you don't have any  resource usage  for Azure
container apps this is different which is coolso what can you build on
azure container apps make sense you're distributed the microservices application as I told you you have multiple containers working together they can talk HTTP to each other but also just web applications because 

> [!quote]
> Azure container apps has [[Ingress]] availability by default

so you can just enable it and now you can reach your
application from the outside world so you can create a web application for your users you can also do event driven
processing applications you can make your container apps work together with other Azure services like   like 
[[Azure Service Bus]] for example you can do message messaging processing from service bus works perfectly fine and
of course background processing applications will also workI'm not
going to explain what kubernetes looks like this is just a diagram of what a
kubernetes cluster can look like and the reason I'm showing you here is because I want to talk to you about the
differences between kubernetes and Azure container apps so if I look at it
very high level a kubernetes cluster exists out of multiple nodes so a node
is a virtual machine a virtual machine that can run your applications that is
your kubernetes cluster existing out of multiple nodes these nodes are called worker nodesand these worker nodes
they contain your containers but not directly your containers they contain pods it's what they call it a pod and
inside of your pod lives your application within a containeryou can scale your application by creating
multiple replicas of this pod within a specific node or spread among multiple
 of these nodes so you have kubernetes cluster you have nodes you haveyour
 pods which can be replicated which can be dynamically scaled running your
 containers now in the container app we have kind of the same
architecture on the outside here in greenis the container app
environment so your environment in container apps is actually a little bit like your kubernetes name spaceso
your kubernetes cluster can have multiple name spaces to basically make sure that one application cannot touch the other application so you can have multiple applications within the same kubernetes cluster 

> [!quote]
> you can do the same thing in container apps by creating a [[Azure Container App Environment]] and your container app environment is basically virtual Network and everything that you put inside of your container app environment can talk to each other on the on the private virtual network
> 

but they can't they can't communicate or the outside world cannot communicate with them inside of your environment you
can create one or more container apps one or multiple container apps again
when you deploy multiple of these container apps within the same environment those container apps live in the same virtual Network and they can talk to each other which is nice which is of of course what you want for a distributed application or a
microservices application then 

> [!quote]
> inside of your container app you can build multiple revisions

that I don't really know  if that exists in kubernetes but I will show you in a demo and it becomes very clear what
a revision is basically when you deploy a first version that is your first revision and if you want to deploy a newer version it creates a new revision for you and it keeps all the older revisions deactivated for you so if you
make an oopsie and you deploy something that doesn't really work work you can very quickly and easily go back to a
previous revision that is still available in Azure so you can basically  fix thatso it will keep your
older revisions and then within your revisions we have the replicas we know from  kubernetes so 

> [!quote]
> you can scale your application horizontally 

by having multiple replicas of the same the same container image and these will
also live in that revision so this is the architecture for container apps
so let's stop boring you with some slides and just show you some Azure stuffif you want to create a new
container app is this readable for everyone in the
back yes and and maybe let me try to make it a little bit
bigger just to make to be
sure maybe that's going to be a little bit too big we'll
see so when you create a container app you search in the marketplace for
container app
obviously so if this is your first container app within your subscription
 you're also going to need to create the environment the  container app environment I already have an
environment so I'm just going to reuse that one but again just remember that this is one container app and you can
create multiple of these container app services within the same environment for those to be able to talk to each other
but if you want to have a completely separate application from this one you can create a second or a third and so on
 environment and then they will be completely separate of course you give your container app a name for example
example 01  API let's say this is an API and you put that in a region and
within that region you will find the list of all your already created container app environments so I have a
CAE which stands for container app environment for NDC London in The Next
Step you  specify your container so your containers will come from a
container registry that can be a public registry or a private registry in my case I've pushed my container images on
a private container regist from Azure itself so an Azure container registry
with the name NDC london. aure cr. and this one has all of my examples
so I'm going to use the example one API container image the latest version and
here you can select a workload profile as I told you before

> [!quote]
> you have the option to do serverless or dedicated  workload profiles

and this is
actually the the the the the nodes that I was talking about in kubernetes so 

> [!quote]
> I'm going to use consumption which is the serverless offering which means I don't really care how many nodes that I have

I'm just going to put this  container app in the consption which means that I can use for one single container app
up to four virtual CPUs and 8 GB of memoryand you can specify in
different steps how much resources this specific container app  can use so I'm
just going to use the minim one so a quarter of CPU and half a gigabyte of memoryin my container app this is an
API it's an API that just returns a message to me  and this message has
what I call a version and that version is configurable configurable by using
environment variables so the environment variable version can for example be
NDCin the next step you can enable or disable Ingress 

> [!quote]
> Ingress means can I talk via HTTP to this container yes or no

and when you enable this if it's a
web application for example you still have two options or three options even you can limit it you can limit it to The
Container app environment which means that all the other containers within the same environment can talk to this container app or you can open it up to
traffic from everywhere if you want to have a public facing websitethis will create thatreverse proxy for
you of course you can do HTTP or TC CP I'm just going to ignore everything and
I'm going to put the Target Port so my application my container application is
listening on port 8080 by the way if you don't know since
net version 8 by default your container Port is 8080 before version 8 of net the
default was Port 80so this is something that  actually took me a while to figure
outand I I think that's all we
need this shouldn't take too long and if it takes longer than 30 seconds I will
just show you the one that I already created beforehand
let's go so I have this one also so if it's
createdyou basically see your container app serviceand here are three
interesting things revisions containers and scale and replicaslet's first go
to scale and replicas this is a web application that I've just deployed soAzure container
apps will see that I've deployed  a web app application with an Ingressconfigured so it will automatically put
my scale rule setting to 0 to 10 which means a minim of zero a maxim of 10
 replicas so horizontally scaling myapplication and by default it's using
the HTTP scaler and 

> [!quote]
> the [[HTTP scaler]] is part of [[Kubernetes Event-driven Autoscaling|KEDA]]

that K open source  tool that
kubernetes event drivenautoscaler  platform and you can actually scale on
different things by default it's going to do HTTP which means if there are more than 10 concurrent requests at a certain
amount at a certain given time it will actually scale up automatically it will add in a new replicaand then if it
it has 10 concurrent requests for all the replicas it will go to a third replica and so on until it reaches the
maxim that I said to be 10 if there is no request for some time it will scale
down to zero it will basically kill your running application until the first request comes in it hits your reverse
proxy your reverse proxy will basically wake up the autoscaler the autoscaler will add one more  will add the First
new replica and then it will handle yourrequest there's also scalers for CPU
memorythere's scalers for all the things we know in Azure for you can do for example scaling based on messages on
a queue so if there's a lot of messages on your queue you can automatically scale up to basically process all of
those messages in parallel and you can create your own custom scalers so you can have your own custom scaler added as
a component in K and you can then use that hereas your scale rule 

> [!quote]
> if you want to change anything like your scaling you basically need to create a new revision

so 
you can do edit and deploy and you
can change a couple of things you can change the the container itself with all of the  values that we've seen before
where does the container come from what is the version of your container imagewhat is the CPU cores and memory that
you want to use for this specific  container app and what are the environment variables you can also
change the scaling rules of course  here so it's just dragging these around
and by the way I'm showing you all of this in the portal of course you're not going to do this in the portal when you're doing professional development
you're going to use thethe  the the tools like  arm templates or bicep
to basically do this a automated in your cicd pipelinesbut I just wanted to show you in the portal to give you a
little bit more context you basically drag these sliders around  and you can say I have a minim of
zero and a maxim of 300 replicas you can never go above 300 hereand if
you do createit will actually create a new revision for
you so if I go to 
revisions you can now see that I have myold revision still running and I have
my new revision that I've just created that hashere the total nber of replicas currentlyactivated and this
one is still activatingso your application will not go down it will basically spin up your new replica and
then when your new replica is ready to receivetraffic it willshut down
the oldrevision so if I refresh this they should now be switched so you can see that now my new
revision is running and my old revision is de-provisioning so it's basically getting put to the side you can also see
that the traffic is 100 here per here and 0% here so this is youryour 
your scaling this is basically your  reverse proxy that says all that traffic needs to be forwarded to that specific
 revision when your application is scaling you can see the total replicas
going up here so if you create an application that gets a lot ofHTTP requests you will see this nber going
up of course following rules that you specified in my case from 0 to
300 now if I want toshow you how multiple of thesecontainer apps are
working together I'm just very quickly going to show you some code just to show you or give you an idea of of what
simple example that I'm that I'm actually using here so I've created the API which is the one that I've deployed
 just now and this only has one endpoint called status so this just says
hello from  version on an environment. machine name in a specific time so this
is a very simple API and I didn't actually show you but if I go to my newly deployed application
01 which is not here refresh here it
is because I enabled Ingress and I enabled it to be available from the outside world I have an application URL
and if you click that application URL and you have some patience it
seems a lot of
patience all right then I have a status
endpoint and this will give me hello from version NDC which is the environment variable that I've set on
example 01- api-- random nber nbers so the random nbers are basically 
identifying yourrevision and identifying your specific replicaso
I only have one replica available because I'm not scaling or at least it's not necessary to scaleso I'll always
get the same the same one backso that that is the what the API does now
if I go back to my code I also have a worker application so a worker service which is a background servicewhich
has a worker background worker class this runs continuously and actually
calls my calls the using the HTTP client myAPI and the cool thing with 
Envoy is that you have automaticservice Discovery so in order to talk
via HTTP to your other container apps the only thing you need is the name of the container app so if I deploy this
application and I'm not going to do it I'm just going tojust going to take
the existing one this worker if you click on your
containers and then your environment variables here the status endpoint
environment variable is the one that I'm using to do my HTTP call so this is my my address that I'm actually calling and
the value for this address is HTTP D-SL example one- API status so the DNS
name just like your services in kubernetes is just the name of the service in this case the name of the 
of the  container app but this also works for scaling so if I have multiple
replicas running for example one- API it will actually hit my scaler and it will
get assigned one of the replicas automatically I don't need to worry about that it will just work out of the box but of course you need to do that
configuration you need to know in your code what the name of your your micros service or whatever is in order to be
ableto call it now if you look at  the Lo Stream So 

> [!quote]
> the [[log stream]] is a live stream of your console log for your application 

you can actually see that every second it is actually getting hello from version Alpha this is the one that I deployed earlier so this is not
the NDC onemessage every second  within that worker so it's actually
working now if you start to scale your
applicationyou can actually do that manually or
again with the tools that you know from code or from infrastructure as
code so let's go to the  API you can of course just fix your
nber of replicas if you do edit and then scale you can put these sliders
wherever you want so I can go 12 minim 12 maxim which means always 12 never
less never more this is a bit fiddly the UIso let's say it's
1212 now if you do this with the same running application which is the one that I've prepared beforehand example
two and you look at the worker so example two uses two different 
replicas you will see
two different  replicas so if you look very carefully you can actually see here the name of the replica X5 5 W so these
are my two replicas and it's going to switch randomly between those two 
it's not a round robbing mechanism it's just a random mechanism which makes sure that if you have two replicas 50% of
your traffic will hit the first 50% of your traffic will hit  the second so that's the that's the idea and again
just works out of the boxthe only thing you need to do is change your  scaling settings and you don't really
need to worry about URLs yourservice Discovery will just workout of the
box and Things become interesting when you look at replicas I'm sorry
revisions so with revisionsI told youif you create a new revision all
the old revisions they will be kept for when you do a mistake you can easily go back to a previousrevision but 

> [!quote]
> you can also change your revision mode into [[multiple revision mode]]

and if you do that you basically change your 
container app to be able to run multiple revisions at the same time and this is very nice if you want to do ab testing
for example 

> [!quote]
> you can deploy the new version of your application under a new revision but keep the old revision active and just split your traffic

so if
you do this and you basically create a new revision based on an older
revision let's let's do
that and if you wait a little bit of time you will get two of these active revisions running simultaneously and you
can change these traffic  nbers so you can actually change it for example to 80% of the traffic needs to go to my
old version and 20% needs to go to my newer versionand if something goes
wrong only 20% of your request gets  hit by that problem and hopefully not
too many of your users will notice and then you can fix your problems beforehand and then you can try again
and if everything looks to be working you can increase 20 to 30 to 40 to 50%
and if everything seems fine you can just switch over 100% the new revision 0%the old
revision again I'm I'm doing doing this all in thein the UI right now you
can do this from your pipelines automatically obviouslywith all of the tools you
know so in this case I can't change it I'm not sure whyso I'm going to go
to my third example because this one should
work this one has 20% for one and 80% for the other so you can just change
those nbers to whatever you want of course between zero and 100but that's the idea you can have three four
five six revisions running at the same time whatever you want again to me this
looks like a more managed way of of of doing these kinds of applications of doing these kinds of things in
kubernetesthese things will look  will also work but you need to do a lot of manual work  to make that actually
work here it works out of the box thanks to the the concepts of revisions and
 replicas all right back to the
slides if I can find them I close
them how do you present F5 thank
you perfect all right sobefore I go a little bit
deeper into  what else you can do with container apps I'm going to talk about two things that's [[dotnet Aspire]]  which is
quite new since November last year I'm very quickly going to discuss what it is and how you can use that in conjunction
with container apps and I'm also going to talk about Dapper because Dapper is a an integral part of container apps I
will show you a couple of examples on why you can use depper but you don't have to use depperit's the same forecast

> [!quote]
> [[dotnet Aspire]] is a new tool from Microsoft that looks a little bit like [[Dapr]] and it's basically your distributed application orchestrator 

so you have multiple running services
that need to work together in your distributed application or microservice application and you're going to compose
your entire application out of these components so it's for your app composition basicallyyou also have
the service Discovery where I was talking aboutand you have support
for components for commonly used services so the idea of aspire is that you as a developer don't need to worry
about the whole landscape for your distributed application you have your own services that need to talk to each
other but you don't want to care about how do they need to talk to each other how what is the U how do I need to
secure that URIbut also when you talk to external components you don't want to manage those external components
when you're developing locallyyou just want that to work out of the boxso Microsoft tries to make that whole
development work workflow easier for you the developerby using these tools 
for example D net as Aspireso what happens with net
Aspire if you do file new project in visual studioyou can actually find the Aspire template and that will create
a demo application for you to show you what the power of aspire is and what it
creates is something similar than the example that I did it creates an API service in the top and a webite
a web application in the bottom and the web application will call the API service the API service is very simple
and it's thethe the example that you probably all all know aboutit's the
one with the weather forecast so it's an API which gets a bunch of random weather
forecasts very simple and then because Microsoft is trying to push Blazer of course a Blazer applicationwhere
your  weather page will basically call this API weather API and get the weather
 asynchronously now with Aspire it creates an additional project called the
application host and it puts this project as a startup application and this is for people who are hardcore C
developers and don't care about infrastructure don't care about Cloud they just want to do cpy stuff 
because the apphost will basically tie all of these things together if you look at the program CSclass it tells you
I'm going to build a distributed application with the distributed application Builder  maybe I need to
use this so distributed application. create Builder we know about the web application Builder and the host
application Builder now we have also the distributed application Builder now with this Builder I can build the whole
landscape of my distributed application for example I am going to need a redis cache I'm going to do some caching and
I'm going to use redis for this cacheand the only thing I need to do is put
the extension method at redis container with the name cache and basically Aspire
will download a redis container image to your system locally and it will also run
it in your local Docker environment  so that you can actually use it from your application without the Need For
You installing it manuallythen you're going to Define your own services
for your  the ones that you are basically writing yourself so we have the API service which comes from your
projects because it's in your  solution Explorer with this name and then you're going to add a second
project which is the web application which is called web frontend and it's going to have a reference to the cache
because it's going to use the cache and it's also having a reference to the API service because it's using the API service so with this little file you
basically wrote in C what your landscape looks like I have three services my web
API my web application and my red cach the web API and the web application I wrote myself they are part of this 
solution and then the redis is an external  dependency basically that
I'm going to use and if I just play press play and I open my 
Docker you can actually see in my running containers automatically getting me the
reddest latest imageso this image is now a running container on my local system and it will just work and if I
look what happen when I when I started my host application I now have an Aspire
dashboard so I have a dashboard that shows me my whole application landscape which runs my API service with a link to
that endpoint this is my weather forecast if I refresh I get the random
weather forecasts it's a little bit like the weather in Belgi and probably here alsoand then I have my second link
to my web frontend which is my blazer application that gets the same weather but if I refresh this this page I get
the same weather all over again instead of the random weather because there is the redish scache in between and the red
cach is not one of my projects it's actually a running container which is this one and the cool thing about the
Aspire dashboard is that you can also look at your logs from this one single dashboard I can click project I can see
my console logs for my API service I can see my console locks for my web front end and I can see my console locks for
my containers that are that are also running as part of my application again this will help you as a developer to run
your distributed or microservices application locally with all of those dependencies that you have by just
pressing play in visual studio and it should work I don't work for Microsoft it should
worknow 

> [!quote]
> if you want to deploy this to to Azure container apps they made it very simple so you have a command line tool called a the a [[Azure developer CLI]]

not the Azure CLI but the Azure developer CLI and it has a couple of things you can use for example if you
create your aspire application just in the way that I did you can do azd in it
to initialize your application to be able to be deployed to Azureand if
you do azd in it it will ask you some questions it will look at your code and it will tell you oh this looks like an
Aspire application  which projects do you want to include in is deployment and
now you can specify okay I want my API service I want my web front endyou just check them it will ask you a couple
of more questions like what you want your resource Group in Azure to be named it will create all of the bicep  files
for you and then when you do ASD up or ASD deployit will basically deploy
all of that to your subscription so it will then ask you to authenticate towards yourAzure subscription and
then it will start running all of those bicep  scripts to actually deploy that application and that's exactly what I
did so if you look atit actually it created a separate
  Resource Group this
one there we go it actually deployed a container environment and within that
container environment the API service in the bottom the web front end and then the cache also so the cache is not the
application that I wrote It's just getting the reddis image  container image from the public repository and
just also putting that into my  whole container app environment so now my application also runs in the cloud just
like it runs locally and I didn't really need to do any  any work for that 
everything happens automatically for me so I think this is cool for your smaller applications  and for your developer
experience you can of course combine that with writing your own pipelines and doing like the the the the the
deployment to the cloud thing you can fully customize but still use aspire to run things locally very easily without
the need to link to exist existing environments for example just run everythinglocally which I think is
is is pretty cool  this is still in preview of course the the the team at Microsoft is still working on this 
it's going to be it's going to get better and better over time and additional components will be added to
it so right now I'm using redis there's also support for SQL Server there's support for postgressand other tools
 and this this list of this Market or this Marketplace of components that you can use together with Aspire will of
course grow  over time and I hope that maybe some of you  will also work with
that and will create new components for the communityto
use now back to my slides next to  Aspire something very
similar is called Dapperwho has who has never heard about depper everyone
has heard about deer okayso deer is is a part of  container apps you don't
have to use it but you can use itit is available for youso basically
daer is the distributed application runtime and again you can use that for your microservices or distributed
applicationsthe cool thing about deer is it allows you to create a
distributed application where every component or every service is written in their own technology or language or
whatever that's of course something that always works with containers but sometimes when you want
one technology to talk to another technologyyou can of course use HTTP because that is supported everywhere but
if you if you use something very specific things become harder how how is service a going to talk to service B if
they don't know the same protocol well depper can help you with that because 

> [!quote]
> Dapr is going to try and abstract away the cloud infrastructure 

so how do I talk from one service to the other and also the configuration where is my other
service located what is the connection string what is the secret whatever that I need to be able to talk to another
service so that you as a developer can focus on your application code and not so much on configurationand of
course this also enables application portability because if you have one component and you want to switch it out for another component which is the 
old saying like if you're a developer you need to make abstra ractions everywhere because someday you want to
switch out your database for something elsethat's also the thing that that deertries to do  and how it does
that is very cool so when you run a container within a kubernetes pod or
within an Azure container app you can actually put containers next to it within the same container app or 

> [!quote]
> within the same pod and Dapr adds containers are called sidecar containers so it's like a helper container to your application

container and this is exactly what Dapper does so Dapper will deploy for you a side car and when you do service
to service communication between your services you're not going to directly talk from your service to the other
service you're going to ask Dapper Dapper could you please call my other service and then deer will call from its
side car to your other applications side car they will communicate to each other
with resiliency and I will show you an example in just a moment and then that side car will talk to your service and
this is what I was talking about when you have let's say the service a on the left hand side is in written in Java
with some very obscure protocol and then service B on the right hand side is written in net with another obscure
protocol they can't talk to each other but they can talk to the side car the side cars can talk to each other and
this way your applications can talk to each other you don't need to worry about configuration because you have the
concept of components in Dapper Dapper has a whole list of whole Marketplace of components and depper can talk to an
HTTP service a [[grpc]] service WCF service it can talk to external services like a
redis cache or a SQL database stuff like that so as you can see you can also
communicate with those external services or components by following that Arrow
straight up now what kind of dapper components are out there well you have the input
output bindings which is basically communication inside into your service
or out your service like HTTP communication grpc communication there are multiple of these bindings available
there is  support for State stores where do you want to store your state in a SQL database in a docent database in
a in a cache a redish cache for example these are your state stores your secret stores Dapper has support for Azure key
Vol for example to store your secret so you don't need to worry about the connection strings from your application
you just ask depper I want this secret and depper will fetch you for you depending on which components you
activated configuration stores to get your configuration pops up to do your  service bus messaging or whatever 
middlewares if you want if you want to   work with your  request pipeline
for example you want to  work with the requests that come in you want to to make some changes there there's also
support for thatlet's show you a little demo so I've created an
application the Dapper example so the only thing you need to do as a
developerinstead of calling from your service to another serviceor
talking to an external service if you if you're using Dapper you just need to 
install the depper client and with the deer client you can do some fun things
so if you look at the workerthe one that is calling my API and you look at
the configuration you need to addthis is the wrong one
sorry this one you need to add the depper client to your dependency injectionso services. add deer
client will basically allow you to inject the depper client into your 
classes where you need them and the depper client can do everything for you so if you want to talk to your state store the deer client can do that for
you if you want to talk to another service the deer client can do that for you so everything becomes depper client so that will be your abstraction in code
and in your code you don't need to worry about configuration or  Technologies
or communication protocols you just use Dapper  and inside of your worker
instead of using the HTTP client you're going to use the Dapper clients the one that you just configured inde dependency
injection and there's different kinds of methods that you can call to talk to States or State Stores or to talk to
configuration or secret stores or toinvoke a method over an HTTP connection
so in this case I'm doing invoke method which is going to be an a get method and
you just specify the name of your or the ID of your application so when you have
multiple containers running in a container environmentyou can enable depper on those containers and 

> [!quote]
> you need to specify an app ID for all of your container apps and this app ID is the only thing you need to be able to talk to these services

so this for example example 6- API is the depper application
ID for my API and I'm going to call the status endpoint and this call will do
the HTTP call for me the cool thing about this is that 

> [!quote]
> this also has resiliency built in 

so if this call
fails for some reason you can configure okay if it fails with a 500 exception just try again try again try again try
again for a maxim of 100 times do an incremental back off all of that thing can be configured within Dapper and not
within your code so the side cars will take care of all of that hard stuff you as a developer focus on your  code and
not the technology to talk to another service by the way mymy API that
I've deployed also uses the deer clientand it actually uses the deer client
to use a redish cache so I've  created a redish cache on Azure so whenever I
call the API instead of generating a new message it's first going to check on the deer client if there is a state
available in a component in  Dapper called redis with the key message and if
it's available it would return this if it's not available it will create a new message and store it in that state store
how do you deploy thisin the same way as you  if as it in
the same way you deployed the other  applications so let's go back to my NDC launch
Resource Group then it should be example six and the only thing you need to do
extra is click on the Dapper and enable depper for thiscontainer app so you
deploy your container image to this container app and 

> [!quote]
> when you enable [[Dapr]] it will install the Dapr [[Sidecar Container]] next to your container automatically

so again you don't need to do thatyou need to specify your app ID which is example 6-
API so this will also be your ser Discoverywhen you want to do a call
you need to specify your application Port so for my application I am listening to 8080 so my depper side car
now knows that if it needs to communicate with my application port 8080 is the one to callyou can
specify the protocol HTTP or grpcand you can add some API logging so the
sitecore will also show you what is actually happening and if you look atthe Lo
stream for example you have your container that is running and
listening but 

> [!quote]
> In the log stream you also have the Dapper sidecar container listening

if you want to work with these  Dapper components so if you click
depper in the bottom you can actually see a list of all the components in
Dapper that you are using so this API is using the redis componentso if you
want to manage that you can actually go to your your container environment and 

> [!quote]
> You can add Dapr components to your [[Azure Container App Environment]]  and you can do [[Azure Dapr components]] or generic components 

Azure components are very specific to
Azure so Azure has a couple of these components created for you do you want to communicate with Azure reddis that's
what I did you want to communicate with Azure Secrets  Azure key fold you can add it here and now your depper depper
is available to talk to your  key Vol so again you basically shift these
things out from your code of course you need to do them somewhere so in this case you need to configure it here again
you can configure it in the portal but you can also configure it in your pipelines as part as your infrastructure
as code and that will also work  perfectly fineI have five minutes left so
there's one more thing that I want to show you in example seven which is yourresiliency it's
also a part of dapper so in this case you don't really
need to use the Dapper client you can justif if you look at my depper
second depper example my worker does the exact same thingit's using the HTTP
client to talk to myAPI so it's not using depper I'm not using the deer
client and I made one little change to my API I basically in 50% of the time
I'm just going to throw an exception so my API call Will Fail  50% of the
time now if you deploy this to Azure container apps and you
enable resiliency 
you can enable resiliency in
this case for example for HTTP retries which means if you get a 500 something
you can retry for a maxim of 100 times with an initial delay of 100 milliseconds it it will do an
incremental back off but no no more than one second and if you save this again out of the
box this will just work if you go to yourto your URL and you call your
status
endpoint it will always work you can keep refreshing this you will never see the exception because the Dapper side
car that calls the API will basically retry that for you  if that fails for
a maxim of 100 times of course if you play around with these  with these nbers like if if I put instead
of 100 milliseconds like 5 Seconds you can actually see that happening because when you refresh and it immediately
refreshes you know that it worked if it if it waits for 5 seconds you know that it failed it's waiting for 5 seconds to
retryso again this works out of the box you don't need to add anything to your codethis is part ofAzure
container apps and then finallybecause this
was basically all that I wanted to talk aboutmany many years ago it's it's almost 10 years ago I've I've created an
application while I was still teachingpeople to to write  programs in C
it was a very basic C  course and I was bored of always writing
console applications with my students so I created a little game and this game
 the students could use to learn to write C code and the C code would actually make a robot do some fighting
like a visualized  battle and this is the thing that I actually deployed into
kubernetes at first which worked perfectly fine but then in  container apps and the cool thing about container
apps was I I  deployed it it just worked I didn't really have to do
anything so this is called [[CSharp Wars Code]] this is actually Four container
apps within the same con  container envir environment and maybe I I'll need to show it first so if I go toweb. c
wars.com
 you can actually play this by  creating a new robot a virtual robot
giving it some health and stamina and then writing some C to to do something so these are templates that you can
choose  from a dropdown to make it  very easily to show you but my students should write this code themselvesso
this is how to learn how an if Works how you declare variables and when they run this they can actually immediately see a
result instead of a boring  console application so that that was the idea please go
awayso if you view the battle arena it will show you a 3D
representation of all these robots fighting fightingon here so this is
publicly available you can play around if you wantevery once in a while I just remove all the robots because for
some reason people always use profanity in their namingsbut what but
whatever but I deployed this to Azure container appsbecause I'm I create I
made it into an Orleans cluster I don't know if you know orans orans is the Microsoft thing for creating [[Actor model]] based
applications So based on the actor model and this is pretty cool because basically everything that happens all
the logic in the back end like for the robots for what the robots do for the arena everything is an actor and all
these actors work together and the cool thing about actors is they can be easily scaled because each little thing in your
application is a single actor and a single actor can be and your all of your actors can besharded over multiple
nodes and this is exactly what you have with container apps so if you look at 
these four container apps you basically have the web API which is just the web API that Unity users to call it's a
website the website that you just  saw and then two Orleanshost
applications The [[Orleans]] host application hosts your actors and Orleans has a dashboardso I can do
orleans. CWS .com which basically shows you all of your different actors
so I have 14 actors running somewhere they're they're processing now 15 they're processing something I think
some people are actually deploying robots no