---
status: planted
dg-publish: true
tags:
  - content/video/youtube
creation_date: 2024-05-23 09:17
definition: Don’t Build a Distributed Monolith - Jonathan Tower - NDC London 2023
ms-learn-url: undefined
url: https://www.youtube.com/watch?v=p2GlRToY5HI
author: Jonathan "J." Tower
---


| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Author   | `VIEW[{author}][text(renderMarkdown)]`          |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |

- [x] Review Don’t Build a Distributed Monolith - Jonathan Tower - NDC London 2023

## Video
`$= "Made by [[" + dv.current().author+"]]"`
Open player in Obsidian:
```timestamp-url 
 https://www.youtube.com/watch?v=p2GlRToY5HI
 ```

`$= "![video](" + dv.current().url + ")"`

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

## Transcript

```timestamp
 0:01
```

all right good afternoon everybody how's the conference going so far everybody

```timestamp
 0:06
```

having fun uh hopefully you've learned something by

```timestamp
 0:11
```

now uh and uh hopefully you're here to learn something more about microservices and also hopefully you didn't eat too

```timestamp
 0:18
```

many carbs at lunch so you won't fall asleep on me uh but it's nice to see all of you as you can tell from my accent

```timestamp
 0:25
```

I'm not from around here so I'll try and translate anything I need to in my talk

```timestamp
 0:30
```

if I talk about lorries or lifts or anything like that I'll make sure I translate it for you my name is Jay

```timestamp
 0:36
```

short for Jonathan Tower we're going to be talking about not building a

```timestamp
 0:42
```

distributed monolith how to avoid doing microservices completely wrong so I'm going to start with a little bit

```timestamp
 0:48
```

of a story a couple years ago a client of ours came to us at my company

```timestamp
 0:53
```

Trailhead and said we're just about finished building this

```timestamp
 0:58
```

micro Services project that we've built internally and we'd love to have someone take a look at it

```timestamp
 1:04
```

and maybe you can help us out there's just a few little performance problems I can see some Smiles on your faces

```timestamp
 1:11
```

already you know where this story is going maybe from personal experience there's just a few little performance

```timestamp
 1:17
```

problems with it if you could take a look and figure out uh why these you know a few endpoints in our apis are

```timestamp
 1:23
```

slow and help us just really quick before launch so we said sure uh we're a consulting

```timestamp
 1:28
```

company that's what we do so we said sure we'll take a look at that it only took a very short amount of time looking

```timestamp
 1:33
```

at their code to realize that this was not a small problem but this is a problem with their whole application and

```timestamp
 1:39
```

it was going to affect all of their endpoints once they launched and it wasn't uh a small problem in the

```timestamp
 1:46
```

performance way either it was actually going to be a huge problem because instead of building microservices as

```timestamp
 1:53
```

they had planned to do they had in fact built a distributed monolith

```timestamp
 1:59
```

so this is the bad guy in our story today this is the monster that I'm hoping that I'm going to give you some

```timestamp
 2:04
```

tips today to make sure that you avoid building one of these in fact I want to give you 10 of the most common mistakes

```timestamp
 2:11
```

that I see as a software consultant I work with a lot of different companies many of whom have tried lots of

```timestamp
 2:17
```

different architectures including microservices architectures and these are the 10 most common

```timestamp
 2:23
```

mistakes I see them making and I'm hoping that you can take these 10 things and avoid these pitfalls in your own

```timestamp
 2:29
```

projects uh before we get started as a attendee or a Watcher Online of this session you

```timestamp
 2:37
```

are lucky enough that you get a free offer if you have any questions about the topics we're talking about today

```timestamp
 2:43
```

microservices software development in general like I

```timestamp
 2:48
```

said I'm owner of a Trailhead of Trailhead technology Partners we're a software consulting company I've got

```timestamp
 2:54
```

this free offer for you here you can scan that code I'll show this again at the end and I've also got some brochures

```timestamp
 3:00
```

here if you're old school and you like it on paper um but uh that's basically for a free

```timestamp
 3:06
```

30-minute consultation if you have any problems that you would like someone to take a look at I'd be happy to talk to you and you can

```timestamp
 3:14
```

check that out there a little bit about me besides owning Trailhead I also am a

```timestamp
 3:19
```

Microsoft MVP if you're not familiar with that Microsoft MVPs are awarded for their expertise in software and also

```timestamp
 3:26
```

sharing that expertise like we're doing right now in the community I've just was awarded that back in the summer for the

```timestamp
 3:34
```

eighth year in a row I also have some contact info here if you want to get a hold of me and finally at the bottom

```timestamp
 3:41
```

I've got a GitHub link where you can get all of these slides afterwards so with that out of the way let's start

```timestamp
 3:47
```

with some definitions make sure we're all on the same page about what we're talking about with monoliths and

```timestamp
 3:52
```

microservices and distributed monoliths let's start with the monolith we've all

```timestamp
 3:58
```

been working with these types of software applications for in some cases many decades depending on how long your

```timestamp
 4:04
```

career is these are kind of what you would consider your traditional software architecture this is when the whole

```timestamp
 4:09
```

application is built together and deployed together as a single piece if

```timestamp
 4:14
```

you go change something in one place you can't create the you can't build or

```timestamp
 4:19
```

create the app without all of the pieces being there together so if you're maintaining a monolith you

```timestamp
 4:28
```

might be familiar with this problem but in a monolith sometimes you might have something like a button that has

```timestamp
 4:35
```

the wrong name on it and you need to make a change to that button that should be a very simple change right one line

```timestamp
 4:40
```

maybe not even code one line of UI and if you have a monolith you still have to

```timestamp
 4:47
```

do an entire deployment of the application right and a monolith goes all together or it goes not at all so

```timestamp
 4:54
```

that's kind of the idea behind a monolith um some of the advantages of a monolith it's much easier to build than a

```timestamp
 5:01
```

microservices architecture also typically has better what's called Data throughput so don't confuse that with

```timestamp
 5:08
```

performance performance is actually can be in a well architected microservice can be better

```timestamp
 5:13
```

we'll talk about that what I mean by data throughput is that when somebody types something in and submits it on a

```timestamp
 5:19
```

form in the application from that moment to the moment that the entire application knows about that updated

```timestamp
 5:24
```

piece of data that is kind of considered data throughput so in a monolith typically you're going to have one

```timestamp
 5:30
```

database you're going to have everything compiled together looking at that same database so the moment you've updated

```timestamp
 5:36
```

the table where that data goes the whole application knows about it you can do it in a transaction so that no one else

```timestamp
 5:42
```

accesses out of out of date data but it's getting the most up-to-date data all the time so

```timestamp
 5:49
```

that's one of the advantages of a monolith another Advantage is that it is scalable so you might be thinking well

```timestamp
 5:56
```

I'm here in this talk to learn about microservices because I heard that those are more scalable and I'll say that I

```timestamp
 6:02
```

can confirm that microservices are more scalable if they're done correctly but that doesn't mean monoliths are not

```timestamp
 6:08
```

scalable right there's still things like load balancing and data sharding that we can talk about

```timestamp
 6:13
```

uh there's also fewer cross-cutting concerns when you're building a monolith

```timestamp
 6:19
```

versus microservices we'll talk a little bit more about that as we're getting into the details here today

```timestamp
 6:24
```

> [!NOTE]
> and the most important difference in my opinion is something called immediate consistency anybody ever heard of the
> 
> 6:31
> 

term eventual consistency when it comes to microservices oh good okay so about half of us so this is I think the most

```timestamp
 6:39
```

important point I'm going to hit this several times throughout the talk but this is a really big difference between

```timestamp
 6:44
```

monoliths and microservices there are disadvantages of course every software

```timestamp
 6:49
```

technology architecture that you can pick has its advantages and disadvantages

```timestamp
 6:55
```

> [!NOTE]
> I already mentioned one of them which is if you want to even make a very small change to your monolithic application you have to rebuild and deploy the whole
> 
> 7:02
> 
> thing tight coupling is much easier to do in an application I just met a

```timestamp
 7:07
```

gentleman whose team has a four 400 project Visual Studio project solution and uh

```timestamp
 7:16
```

you know it's really easy to do that when you're building a monolith to have too much code that all relies very

```timestamp
 7:22
```

tightly on each other instead of keeping them separated um

```timestamp
 7:27
```

> [!NOTE]
> typically you have to use the same technology stack you might not be thinking of that as a disadvantage you
> 
> 7:33
> 

might have a team that all kind of knows the same technology stack maybe they were hired because of that technology stack now so maybe that's not a problem

```timestamp
 7:40
```

for your team but if you have a large organization with lots of different departments lots of different areas of

```timestamp
 7:45
```

technical expertise then having to use the same technology stack for the entire application can be a downside

```timestamp
 7:51
```

> [!NOTE]
> it's not quite as agile of a process to build a monolith as it can be to to
> 
> 7:57
> 
> build a good healthy micro service and it also doesn't allow you to have small teams that are focused just on very

```timestamp
 8:04
```

specific areas as much as a microservice typical monolith is going to look

```timestamp
 8:09
```

something like this the front end is going to have multiple clients maybe multiple different form factors they're

```timestamp
 8:15
```

going to be hitting some sort of a middle tier it's going to be like a web server an API server and then that

```timestamp
 8:22
```

server is going to be accessing some sort of database store it might be a relational database might be nosql

```timestamp
 8:28
```

database but this is a pretty typical uh monolithic application so when you

```timestamp
 8:33
```

update the application you're basically updating these two parts of the application right

```timestamp
 8:39
```

you can scale these I mentioned uh the number one reason I hear people say that they're building a microservices but

```timestamp
 8:47
```

actually end up building a distributed monolith the thing that started them out down that path is they wanted something

```timestamp
 8:52
```

> [!NOTE]
> scalable so I always wanted to start the stock by saying remember monoliths are
> 
> 8:57
> 
> scalable too you can scale by adding more memory more processor power lots of you know more
> 

```timestamp
 9:05
```

cores lots of different Hardware changes you can make or virtual Hardware changes you can make to that middle tier to make

```timestamp
 9:11
```

it more performant you can also do the same thing at the database tier right if that's your bottleneck you can add more

```timestamp
 9:17
```

performance there by adding more memory that often helps the database adding more processing power that often helps

```timestamp
 9:22
```

the database as well so you can scale this don't forget too that there is other ways to scale

```timestamp
 9:28
```

> [!NOTE]
> a monolith the most common way is something that I'm sure you're familiar
> 
> 9:33
> 
> with it's called load balancing and that's where you just basically make a multiple copies of your application

```timestamp
 9:39
```

tier so here we've got two copies of our mid middle tier and um you know in this case you're going to

```timestamp
 9:46
```

get not quite twice the performance out of your application as you would with

```timestamp
 9:51
```

just the one application server keep in mind it's not quite because there's the overhead of the load

```timestamp
 9:58
```

balancer and so there's some loss there and then also keep in mind that if the

```timestamp
 10:03
```

bottleneck is not your application but is actually your database there that this is going to cause you're still

```timestamp
 10:09
```

going to have performance issues here until you deal with the database layer which is also possible if you're having

```timestamp
 10:15
```

more of your bottleneck in your database layer you can solve that by doing

```timestamp
 10:20
```

something called data sharding right and this is still a very this is something you would also you could also use in a

```timestamp
 10:26
```

microservice but in a monolith you can use this just as well and that's basically where you take your data and

```timestamp
 10:31
```

you split it based off of some key most common way you would do this is if you have a tenant like a multi-tenant

```timestamp
 10:37
```

application so maybe each of these databases is a different client maybe database one has client a b and c and

```timestamp
 10:44
```

maybe client D is a much bigger client they have a lot more data and so you put client B in their own database but

```timestamp
 10:50
```

that's basically the client ID in that case would be your key that's being used to Shard this data so there's lots of

```timestamp
 10:57
```

different options and I want to just remind you that if you're trying to build an application that scales that

```timestamp
 11:02
```

doesn't necessarily mean that you have to build microservices okay so now hopefully we're on the same

```timestamp
 11:09
```

page about what a distributed I'm sorry what a monolith is let's talk now about

```timestamp
 11:14
```

> [!NOTE]
> microservices so this is an architecture that is defined uh where the software is
> 
> 11:21
> 
> composed of small and Loosely coupled services and those Services communicate with each other through some sort of
> 
> 11:26
> 
> well-defined messages on the back end and then typically those are owned by
> 
> 11:32
> 
> small and swell contained teams I'm going to talk about that last point a

```timestamp
 11:37
```

little bit more as we're going today because that's one that surprises a lot of people to actually be in the

```timestamp
 11:42
```

definition of a microservice some of the Hallmarks and advantages of

```timestamp
 11:48
```

a microservice is that you can see these independently deployed right so you can have a button that you need to update

```timestamp
 11:54
```

that's in just one module or some logic that you want to update in one module you can release that module without

```timestamp
 12:01
```

having to even really communicate with any of the teams that are running any of the other modules they're all really

```timestamp
 12:06
```

> [!NOTE]
> totally separate and independent applications and so they can be deployed independently it allows you to do more
> 
> 12:13
> 
> precision scalability I just finished my last Point saying you can scale a monolith but you can also
> 

```timestamp
 12:20
```

scale microservices with a little bit more Precision what do I mean by that if you have your application split up into

```timestamp
 12:26
```

multiple micro services and one of them takes let's say 80 percent of the traffic compared to the others you can

```timestamp
 12:33
```

actually scale that one up you know with its own Hardware to a larger degree than

```timestamp
 12:39
```

what the other ones are scaled up to allow that one to perform better without having to scale up the ones that are

```timestamp
 12:45
```

already performing fine with the lower level of Hardware that they're running on so a little bit more Precision with that high availability is another one if

```timestamp
 12:52
```

you architect uh microservices correctly you can actually take down one of the services and all of the other services

```timestamp
 12:59
```

will be not even aware of the fact that the other service is down we'll just

```timestamp
 13:04
```

continue to work on without any problems so if you imagine if you are writing software for

```timestamp
 13:11
```

a hotel chain and they want to have a reservation service that's up 24 by

```timestamp
 13:16
```

seven you can go ahead and put that into one microservice and now when you have let's

```timestamp
 13:23
```

say the housekeeping module for that Hotel chain when that needs to go down for some maintenance

```timestamp
 13:28
```

it's not going to affect the ability for for that business to take reservations because they're totally separate from

```timestamp
 13:34
```

> [!NOTE]
> each other uh it encourages you to write Loosely coupled code just because your whole application is Loosely coupled and it
> 
> 13:42
> 

> [!NOTE]
> also allows you to do more agile team processes and have teams that are experts on just different areas of your
> 
> 13:49
> 

application so especially useful if you have a very large application not everybody has to understand the whole

```timestamp
 13:54
```

thing they can kind of focus in on different areas and be experts in it typical architecture for a microservices

```timestamp
 14:01
```

project is going to look something like this you're going to have your clients usually they're going to be hitting some

```timestamp
 14:07
```

sort of an API Gateway I'm not going to go into a lot of detail about these but usually these are used to consolidate

```timestamp
 14:15
```

all of your all of your service different microservices together for a

```timestamp
 14:20
```

particular application it might also be doing some things like security some other cross-cutting concerns for your application but that will kind of

```timestamp
 14:27
```

consolidate all the requests and then divvy them out to the various microservices which you see here are in

```timestamp
 14:32
```

each of the different columns now very importantly I want you to notice on this diagram that each of

```timestamp
 14:39
```

these Services has its own application and its own database that's pretty important in a micro

```timestamp
 14:45
```

Services architecture we're going to talk more about that as we go and then the last thing you see on this diagram

```timestamp
 14:50
```

> [!NOTE]
> at the bottom is something called an event bus there's different ways that you can do messaging in microservices application
> 

```timestamp
 14:57
```

this is probably the most common way some sort of a service bus or event bus there's lots of different tools that

```timestamp
 15:03
```

implement this for you I always tell somebody if you're starting out with microservices this is like a really cool

```timestamp
 15:09
```

nerdy problem to solve to try and create your own event bus and you wouldn't believe how many teams maybe you can

```timestamp
 15:16
```

> [!NOTE]
> relate to this maybe you already feel in your heart that it would be really fun to build an event bus don't build your own event bus
> 
> 15:23
> 

it's uh it seems really simple and it is on the surface but there's a lot of complications in there like retries and

```timestamp
 15:30
```

> [!NOTE]
> stuff that you don't want to have to worry about use one of the ones like Kafka or the ones in Azure or AWS that
> 
> 15:36
> 
> are pre-built for you this is the way though that each of these services are going to communicate with each other
> 

```timestamp
 15:43
```

typically this would be like a publish And subscribe model where each service would say hey I want to know whenever

```timestamp
 15:48
```

this type of an event happens and then when that event gets published by one of the other services they would already be

```timestamp
 15:54
```

subscribed to it and they would get the update from that event so this is typically what uh microservices is going

```timestamp
 16:01
```

to look like let's talk about the bad guy from our story today this is the distributed monolith this is when you start out trying to

```timestamp
 16:08
```

create a microservice so first of all I want to say nobody sets out to create a distributed monolith right not unless

```timestamp
 16:15
```

they're sadistic but if you set out to build microservices

```timestamp
 16:21
```

but you accidentally create it much more coupled because maybe you've got Decades

```timestamp
 16:26
```

of experience building monoliths like I do maybe that's what you know best and you know how to do that and you know all

```timestamp
 16:32
```

the rules I'm not supposed to repeat myself right I'm supposed to have single responsibility principle all these good

```timestamp
 16:38
```

rules that still apply in some ways to microservices but there's little tweaks to how you need to think about them when

```timestamp
 16:45
```

> [!NOTE]
> you set out to build microservices but you have that high coupling in your code between your modules you're going to
> 
> 16:52
> 
> probably end up with a distributed monolith the reason I want to warn you about these and and why the title of this talk

```timestamp
 16:58
```

> [!NOTE]
> is don't build a distributed monolith is that these always perform worse than either the monolith or the microservices
> 
> 17:05
> 

architecture this is what you might call the worst of Both Worlds you're going to get a much more difficult to maintain

```timestamp
 17:12
```

application than it would be if it was just a monolith but it's going to perform worse than

```timestamp
 17:18
```

either the monolith or the microservices would so please don't build this we're trying to avoid that today

```timestamp
 17:25
```

okay so what is a typical architecture for a distributed monolith looks like

```timestamp
 17:31
```

I purposely Drew this this way so that it would be kind of obvious what the problem is here the hand-drawn red

```timestamp
 17:37
```

arrows here all these arrows between the different modules whether it's from the application to the database of a

```timestamp
 17:43
```

different module or application tier to application tier or even database to

```timestamp
 17:48
```

database you could say depending on how you do it could create problems here so

```timestamp
 17:53
```

we really these red arrows are what we want to avoid now I didn't put on this side a an API layer I'm sorry an event

```timestamp
 18:02
```

bus layer but most of the implementations I see for uh that end up

```timestamp
 18:08
```

being a distributed monolith do have an event bus layer and what they've basically done is in addition to using

```timestamp
 18:14
```

that to communicate they've also added these red arrows these red arrows start out as a small exception and you know

```timestamp
 18:21
```

how this goes right you're all Engineers by the time you get to the date of launch all those red arrows are the main

```timestamp
 18:27
```

way that the applications are communicating with each other and the event bus is just used occasionally

```timestamp
 18:32
```

uh so Crossing that line and starting with those red arrows is often where the problem happens

```timestamp
 18:39
```

here's another architecture diagram for a distributed monolith I can tell from

```timestamp
 18:44
```

the looks every time I give this talk I can tell from the looks on people's faces who has this one at work so I

```timestamp
 18:50
```

won't call you out and turn you in uh but this is probably the most common

```timestamp
 18:56
```

distributed monolith architecture that I see and the it starts out very

```timestamp
 19:01
```

innocently uh probably a lot of us have a database person on our team database

```timestamp
 19:07
```

administrator database developer or something like that someone who's basically in charge of the database maybe a whole team that's in charge of

```timestamp
 19:13
```

the database right they've learned for decades they've been taught not to make multiple copies of data to normalize

```timestamp
 19:20
```

data to have one piece of data in one place so that you don't end up with update anomalies all of that good stuff

```timestamp
 19:26
```

about data normalization right they've had that beat into their heads for decades now in in the software industry

```timestamp
 19:33
```

and now here comes you after a conference saying hey database team wouldn't it be fun to make a mom to make

```timestamp
 19:41
```

a micro service by the way that means that we're going to need a ton of different databases that you're going to have to administer

```timestamp
 19:47
```

oh and also we're going to copy data all over the place it's going to be in multiple places it's going to take a

```timestamp
 19:53
```

long time for it to all update it's going to have to propagate throughout the application to get all of the

```timestamp
 19:59
```

different databases updated whenever something changes that's shared between them and most good database teams that

```timestamp
 20:06
```

have been doing monoliths for years are going to say you can do whatever you

```timestamp
 20:11
```

want in that middle tier you can have fun do that cool microservices architecture that you learned at the

```timestamp
 20:17
```

conference but you're not touching my database right and so what ends up happening is the

```timestamp
 20:22
```

application tier people that team will do a microservices architecture but the database team won't allow them to do and

```timestamp
 20:30
```

they might say well we'll just not we'll just make different tables we'll maybe use a schema to separate them so that we

```timestamp
 20:36
```

can kind of tell which schema goes with which database with which application but we'll store them all in the same

```timestamp
 20:41
```

database and it'll still be kind of a micro service but as soon as you do that then these applications can access each

```timestamp
 20:48
```

other's data stores then you start getting coupling between these modules

```timestamp
 20:54
```

> [!NOTE]
> so with those three different types of applications I want to add a fourth one which is called a modular monolith and I
> 
> ```timestamp
>  21:03
> ```
> 

want to differentiate that from the distributed monolith that we were just talking about and a Third Kind which I

```timestamp
 21:10
```

have a high confidence that's that many of us in the room have worked on before which I'm going to call the ball of mud

```timestamp
 21:16
```

monolith and you know you worked on a ball of mud monolith when you go to fix a bug in the

```timestamp
 21:22
```

code you make one simple change and fix that one bug test it everything looks

```timestamp
 21:28
```

good you deploy it and it broke five other things right this is where there's so much coupling in the code

```timestamp
 21:34
```

so much you know bad practices going on that you can't fix everything without

```timestamp
 21:40
```

breaking everything else that's a ball of mud monolith I think usually when you're in one of these microservices talks you hear people talk

```timestamp
 21:47
```

about the monolith it's kind of the bad guy in those stories right because they're saying here's microservices architectures and what they're good at

```timestamp
 21:54
```

and when you're talking about the monolith they'll say here's monoliths and what they're bad at and oftentimes

```timestamp
 22:00
```

you know when you're when you're comparing and contrasting it's helpful to compare and contrast to like the worst case scenario I think often what

```timestamp
 22:06
```

they're talking about is actually that ball of mud monolith there is such a thing as a good monolith that's where

```timestamp
 22:11
```

you've created the code very modularly you can make updates without breaking

```timestamp
 22:16
```

other things it's really easy to read and understand the code new people join the team and they get up to speed fairly

```timestamp
 22:22
```

quickly those are all the types of things that indicate that you've got a modular monolith now you'll notice that those two types

```timestamp
 22:30
```

of monoliths plus the distributed monolith and the true microservices I've graphed here with a couple of axes

```timestamp
 22:37
```

the first axis the vertical one is how physically separated they are so on the bottom we've got a mod you know not

```timestamp
 22:43
```

separated monolithic on the top we've got that they're distributed and then along the bottom I've got how logically

```timestamp
 22:50
```

separated they are so we've got modular I'm sorry monolithic logically meaning

```timestamp
 22:56
```

that the whole application is written in a way where there's High coupling between the modules and then very

```timestamp
 23:03
```

modular on the right hand side so what you notice here is that the ball of mud monolith

```timestamp
 23:09
```

is written in a highly coupled way a monolithic logically application and it's deployed as a single application

```timestamp
 23:16
```

so the problem isn't the fact that it's deployed as a single application necessarily there are some downsides to

```timestamp
 23:23
```

that availability for example but the problem is the fact that it's actually

```timestamp
 23:29
```

monolithic logically right that's what makes the ball of mud bad and the way you fix that if you want

```timestamp
 23:35
```

to leave it as a monolith is to make it a modular Model S refactor the code so that the the different modules within

```timestamp
 23:42
```

the code have more healthy relationships with each other the same is true of the distributed monolith and true microservices if you

```timestamp
 23:49
```

set out to build microservices but you couple everything together you're going to end up with a distributed monolith if

```timestamp
 23:55
```

you truly keep things separate that's where you end up with the true microservices

```timestamp
 24:01
```

okay so now we've talked about kind of the definitions hopefully we're on the same page about all of those things if

```timestamp
 24:07
```

you came in here not knowing what I meant by a distributed monolith hopefully you understand now so now I want to talk about the 10

```timestamp
 24:14
```

pitfalls that I see that are the most common uh that cause a microservice to

```timestamp
 24:20
```

accidentally become a distributed monolith monster all right so problem number one I've

```timestamp
 24:26
```

> [!NOTE]
> alluded to this one already a couple times and problem number one is assuming that microservices are always better
> 
> ```timestamp
>  24:32
> ```
> 

now I'm not going to accuse all of you because you look very smart uh I'm not going to accuse you of this but

```timestamp
 24:38
```

> [!NOTE]
> sometimes Engineers can get caught up in the new cool architectures and want to do them on their project whether they're
> 
> ```timestamp
>  24:43
> ```
> 

a good fit for their project or not right none of you I can tell from your faces none of you know what I'm talking

```timestamp
 24:49
```

about but some of the people you work with right who aren't here today do this

```timestamp
 24:55
```

uh this is especially true for smart people like you and I really mean this sincerely who come to a conference and

```timestamp
 25:01
```

want to learn new things right you're here to learn new things you're going to hear probably somebody talk about how great microservices are and I would

```timestamp
 25:07
```

agree with that sentiment microservice is a great architecture for what it's good at but if you don't need

```timestamp
 25:13
```

microservices and you use it it's going to be just like anything else that isn't the right tool for the job if you're

```timestamp
 25:19
```

trying to open a can of soda and you're using a hammer that's not going to be the best tool for

```timestamp
 25:25
```

that job and you're going to make a real mess so my first rule for microservices is

```timestamp
 25:32
```

> [!NOTE]
> don't assume that it's necessarily the right thing for your project unless you have what Sam Newman calls a really good
> 
> ```timestamp
>  25:38
> ```
> 
> reason anybody familiar with Sam Newman Sam Newman in the room he's actually here at the conference with us

```timestamp
 25:44
```

no okay he didn't want to admit it anyway um he is actually talking tomorrow so if

```timestamp
 25:50
```

you uh if you want to learn more about microservices he has a talk tomorrow he's written a lot of really great stuff about microservices so you all are very

```timestamp
 25:56
```

lucky that he's kind of here in your own backyard um having a really good reason though is

```timestamp
 26:03
```

what he says and there's lots of bad reasons there's a few good reasons hopefully by the end of this talk you'll

```timestamp
 26:08
```

be able to tell those apart things I want to underscore here though are that monoliths aren't necessarily

```timestamp
 26:15
```

bad and they are scalable microservices are really hard to do so

```timestamp
 26:20
```

> [!NOTE]
> if you have a whole team of people that are excited to do microservices but nobody on the team has ever built one
> 
> ```timestamp
>  26:26
> ```
> 
> successfully before your chances of success are a bit lower than I would
> 
> ```timestamp
>  26:31
> ```
> 
> like them to be if I was your boss I would say let's not maybe take that big of a risk or let's try and bring

```timestamp
 26:37
```

somebody into the team who has some experience with this so that we don't make lots of mistakes because it is very

```timestamp
 26:42
```

easy to do uh also if you create them for the wrong reason you're going to end up with this

```timestamp
 26:48
```

distributed monolith instead of microservices which I mentioned before is going to be the worst of Both Worlds

```timestamp
 26:56
```

um some good reasons to create microservices another person who's who speaks a lot

```timestamp
 27:02
```

> [!NOTE]
> about microservices is James Lewis and he says that microservices architectures buy you options and what does he mean by
> 
> ```timestamp
>  27:10
> ```
> 
> that well it gives you some options like independent deployability we talked about that already it gives you options

```timestamp
 27:16
```

like scalability that you don't have in a monolith more Precision in your

```timestamp
 27:21
```

scalability however it does it as a trade-off that's what the buy that's why I've highlighted

```timestamp
 27:27
```

the buy word there you have to trade something to get something and uh

```timestamp
 27:33
```

this is what you have to trade if you only remember one thing from The Talk today I hope this is it because this is

```timestamp
 27:39
```

the I think the most important piece of information in here if you've never built microservices before

```timestamp
 27:45
```

> [!NOTE]
> microservices are inherently High availability but they are inherently low
> 
> ```timestamp
>  27:50
> ```
> 
> consistency or or eventual consistency as it's called monoliths are very good at immediate
> 

```timestamp
 27:58
```

consistency which is what I was referring to earlier as data throughput and really bad at

```timestamp
 28:06
```

High availability so if you uh if you have a project that really needs

```timestamp
 28:12
```

immediate consistency and you're trying to make microservice to do it it's probably not going to be a good fit and

```timestamp
 28:18
```

you're going to be going uphill the whole time similarly if you if you need

```timestamp
 28:23
```

a project if you need your project to be highly available if you need to be able to take modules down for maintenance

```timestamp
 28:29
```

while other modules stay online and you build that as a monolith you probably already know if you've built a monolith

```timestamp
 28:34
```

like that before but that's not going to be a very good fit for your needs so this is what I would say is maybe the

```timestamp
 28:41
```

> [!NOTE]
> most important consideration when you're thinking about having a good reason the problem number two I wanted to
> 
> ```timestamp
>  28:46
> ```
> 
> mention is shared data using shared data store or shared data models this is a
> 

```timestamp
 28:52
```

common problem that I see this is basically what happens when

```timestamp
 28:57
```

especially when you're using this particular architectural diagram that I showed earlier where you're sharing the

```timestamp
 29:02
```

database so what happens here is that the first module

```timestamp
 29:08
```

needs to make some sort of a breaking change to one of their tables let's say changing a column type changing a column

```timestamp
 29:15
```

name something like that if that table is shared or if it's available to be shared to other modules

```timestamp
 29:22
```

there's a chance hopefully at the beginning you know you start you set out to not do this but at some point

```timestamp
 29:28
```

somebody over here who doesn't know better or hopes that they get away with it is going to actually write some code

```timestamp
 29:34
```

that accesses that table whether you intend them to or not eventually that will happen at oops at that point that

```timestamp
 29:42
```

person just broke that application or that application just broke unbeknownst to that team when the first team went in

```timestamp
 29:50
```

and changed something so this is how these end up being coupled together just by sharing the

```timestamp
 29:55
```

same data store the same goes for if you're if you're using data models like classes that actually store your data

```timestamp
 30:01
```

and you actually share those so that that you know maybe downloads from your git repository and the same and the

```timestamp
 30:07
```

projects are using the same git repository for that data model the same

```timestamp
 30:12
```

thing happens if someone makes a change to the data model pushes it into that shared git repository now the next time

```timestamp
 30:19
```

um you you download that and try and build your other microservice it is

```timestamp
 30:26
```

going to not work anymore and hopefully you'll get a build error at least in that case but as you can see in this

```timestamp
 30:32
```

case if you actually changing your data store you're not probably going to get any build errors you're just going to get runtime errors

```timestamp
 30:40
```

example using my hotel example from before so if you imagine that you have a

```timestamp
 30:46
```

bunch of different Hotel microservices including reservations maintenance and housekeeping plus a couple others

```timestamp
 30:53
```

if you were doing that in a monolith you would want to store anything that was true about a room in the hotel you'd

```timestamp
 30:59
```

want to store that into a single entity that would probably be in a single model in your code and probably in a single

```timestamp
 31:04
```

database in your I'm sorry in a single table in your database might look something like this where you have a

```timestamp
 31:10
```

Boolean to tell you whether or not the room is currently occupied number of beds that are in that room how long it

```timestamp
 31:17
```

takes to clean that room in minutes maybe some related entities some like child entities like the repair history

```timestamp
 31:23
```

for that room might be in there and that's typically how you would do it in a monolith

```timestamp
 31:28
```

now imagine you're doing that in a shared database and the maintenance I'm sorry the

```timestamp
 31:35
```

housekeeping team comes in and says you know we don't really care about uh how many seconds it takes to clean a

```timestamp
 31:43
```

room we're really more just interested in the number of minutes let's go ahead and change that from a float to an INT

```timestamp
 31:48
```

and now if this data model is used by multiple

```timestamp
 31:54
```

microservices within your application now you've just broken the other ones that are also using that so in this case

```timestamp
 32:01
```

the reservations and the maintenance services just broke now hopefully again that's going to

```timestamp
 32:06
```

happen at um at runtime but if you've also changed the data store to match this type so it goes from an into a

```timestamp
 32:12
```

float now that's not going to map from your data store correctly anymore to the maintenance and the reservations

```timestamp
 32:18
```

services and you're going to get a runtime error so either way you're creating some pretty serious coupling

```timestamp
 32:24
```

> [!NOTE]
> between your applications the quote unquote correct way to do this
> 
> ```timestamp
>  32:29
> ```
> 
> in microservices to actually separate those properties out and so that each
> 
> ```timestamp
>  32:35
> ```
> 
> module gets its own properties and that it owns
> 

```timestamp
 32:40
```

as you can see here I've made a nice perfect example that doesn't have any complications with it you notice that

```timestamp
 32:46
```

none of them need to be shared so I created a very nice happy path example here and you might be wondering what

```timestamp
 32:53
```

happens Jay when you do need to share a property between them so imagine that there I've now added an

```timestamp
 33:00
```

admin Service as the second one so that's where you go to create a new room there's been a an addition to the hotel

```timestamp
 33:07
```

and you have some rooms that you need to add so you go into the admin module and you add some new rooms you create those

```timestamp
 33:14
```

in the admin module in its database as a hotel room with a room number

```timestamp
 33:20
```

that room number is something that you're probably going to need in all of the different micro Services right but

```timestamp
 33:26
```

it's going to be owned here by this admin module so what does that look like well in a microservice that's Loosely

```timestamp
 33:33
```

coupled that's going to send an event to the event bus anything that has subscribed to that

```timestamp
 33:40
```

event which let's say all three of these other services have subscribed to the hotel room update event or hotel you

```timestamp
 33:48
```

know create update event they're going to subscribe to that event they're going to get an event notification from the event bus and

```timestamp
 33:54
```

they're going to have a chance to run some of their own code which in this case means that they're probably going to basically add their

```timestamp
 34:01
```

own copy of that hotel room to their data store so that when this hotel room comes up later they now have that in

```timestamp
 34:07
```

there for example the reservations service needs to know about that hotel room so someone can reserve it

```timestamp
 34:13
```

so that's that's kind of the non-happy path if you do need to share something that's what that might look like in a

```timestamp
 34:19
```

> [!NOTE]
> microservice problem number three that I see is microservices that are too big
> 
> ```timestamp
>  34:26
> ```
> 

there's this whole field called domain driven development is anybody familiar with that already okay quite a few of us

```timestamp
 34:35
```

um it's complicated for those that uh that rose raised your hand just now you know this domain driven development is a

```timestamp
 34:41
```

huge topic we could talk for many hours just about this so instead of talking about domain driven development and how

```timestamp
 34:47
```

that applies to microservices here I'll mention a really good book to start with

```timestamp
 34:52
```

which is this domain driven design book if you want to understand how to

```timestamp
 34:58
```

architect a microservices application I highly recommend that you learn about domain driven design or DVD for short

```timestamp
 35:05
```

and that this book is a really good place to to learn that from however if you would like a shortcut version of it

```timestamp
 35:11
```

let me explain what my shortcut version is which is my simple rule instead of

```timestamp
 35:16
```

> [!NOTE]
> all the stuff that you need to know from DDD is that you're trying to create the smallest possible microservices without
> 
> ```timestamp
>  35:23
> ```
> 
> chatty communication between them now smallest and chatty are up for debate
> 
> ```timestamp
>  35:29
> ```
> 

right those are not measurable terms but basically if you think of it as a

```timestamp
 35:36
```

balancing arm on one side you've got how big the service is and on the other side you have how much that service needs to

```timestamp
 35:43
```

send events to other services if that event has to send lots of everything it does it has to send events

```timestamp
 35:50
```

to have other services do things that might be too chatty if

```timestamp
 35:55
```

it's too and it might be too small excuse me it might be too small

```timestamp
 36:00
```

if uh if it's doing that and if it's too big then it's not sending an event ever

```timestamp
 36:06
```

right it's never sending an event to do anything anywhere else it's basically a monolith pretending to be a microservice

```timestamp
 36:14
```

> [!NOTE]
> the opposite problem of that is true as well I see sometimes services that are too small so if you imagine a scenario
> 
> ```timestamp
>  36:21
> ```
> 

where you said okay Jay said not to make the services too

```timestamp
 36:27
```

big it's called microservices right I'm going to make them as micro as I can I'm

```timestamp
 36:32
```

going to take every end point and it's going to be its own service what could possibly go wrong

```timestamp
 36:38
```

well imagine this scenario where you've got some sort of like user maintenance module here and you've got a login and a

```timestamp
 36:44
```

password reset and you've made those two endpoints totally separate services from each other well these are going to have

```timestamp
 36:50
```

to communicate to each other a lot every time you do a password reset that's going to have to communicate to the login service so that the new password

```timestamp
 36:56
```

is there maybe if you have like a lockout password reset after a certain

```timestamp
 37:02
```

number of failures the login service is also going to have to communicate to the password reset module to tell how many

```timestamp
 37:08
```

uh how many attempts there's been there's going to be a lot of communication between these two they're always going to be updating indirectly

```timestamp
 37:15
```

hopefully updating each other's data stores and so this is probably too chatty these

```timestamp
 37:21
```

services are too small so uh

```timestamp
 37:27
```

> [!NOTE]
> the solution in this case would be to combine those obviously into a single user service and to have these be two
> 
> ```timestamp
>  37:33
> ```
> 
> different endpoints in that same service 

> [!NOTE]
> problem number five is starting from scratch
> 
> ```timestamp
>  37:40
> ```
> 
> uh now Engineers always like to start from scratch right who prefers Brownfield
> 
> ```timestamp
>  37:46
> ```
> 
> projects to Greenfield projects okay there's two people who love pain in the

```timestamp
 37:53
```

room um no actually maybe those two people are smarter than the rest of us because

```timestamp
 37:59
```

> [!NOTE]
> actually starting from scratch is much harder in some ways let's talk about how

```timestamp
 38:05
```

so when you're migrating a Brownfield project you have I believe these four advantages if you're trying to migrate a

```timestamp
 38:11
```

> [!NOTE]
> Brownfield project to a microservices architecture the first one is that the code that already exists
> 
> ```timestamp
>  38:18
> ```
> 
> is basically a documentation of all the relationships that exist between the different entities between the different

```timestamp
 38:24
```

modules you can basically go to whoever wrote that code or maybe there's maybe you're

```timestamp
 38:29
```

> [!NOTE]
> the one company out of 100 that has documentation about that code that you could actually read

```timestamp
 38:34
```

but excuse me all of that stuff exists and you can go look at the code you can

```timestamp
 38:40
```

actually look at um like code diagrams and see oh this relates to this entity relates to that

```timestamp
 38:46
```

entity one-to-many relationship all of those types of things are documented in your code in your database and your

```timestamp
 38:51
```

documentation that's a huge Advantage when you're trying to make all of these decisions about where to draw the line

```timestamp
 38:56
```

between different microservices in your application to know this thing and this thing have a ton of relationships to

```timestamp
 39:02
```

each other maybe that means that they should go into the same microservice

```timestamp
 39:07
```

service together number two you have people to talk to that know the system when you're doing a

```timestamp
 39:14
```

> [!NOTE]
> green field project you're often talking to the business right about requirements and what what does this need to do what

```timestamp
 39:19
```

are you trying to do how does this normally work what are your current processes a lot of that stuff as you know you can

```timestamp
 39:26
```

get wrong information there if there's a team that's already built an application even if it's a monolith even if it's a

```timestamp
 39:32
```

ball of mud monolith they have had a lot of those conversations they know what they wish they had done differently in

```timestamp
 39:37
```

the past they know what works and what doesn't work about that monolith that currently exists and you can talk to

```timestamp
 39:44
```

> [!NOTE]
> those people of course if that's you then there's a different problem I guess right number three is that the system
> 
> ```timestamp
>  39:50
> ```
> 
> already works why is this good it buys you time if you're trying to do something as

```timestamp
 39:55
```

complicated as a microservices architecture and you want to get it right you don't want to be always having your

```timestamp
 40:03
```

boss breathing down your neck saying when is it going to be done when's it going to be done how much greater would it be to have a

```timestamp
 40:09
```

system that's already handling whatever that system does to take some of the pressure off while you work on getting

```timestamp
 40:14
```

the microservices correct that's a huge advantage and then the last one I think is really

```timestamp
 40:20
```

> [!NOTE]
> huge which is having a baseline to compare to so you can actually do you can actually measure some statistics

```timestamp
 40:27
```

on your current monolithic application if you have one already and you can compare those as you launch different

```timestamp
 40:33
```

modules as microservices you can compare them and say what's working better what's working worse are we doing this

```timestamp
 40:40
```

correctly is it actually more highly available than it was before are we

```timestamp
 40:46
```

actually able to independently deploy things uh is the performance any better are we able to scale things more

```timestamp
 40:53
```

precisely all of those questions you can actually measure against something instead of just kind of a rough guess

```timestamp
 40:59
```

like yes this feels good to me or it feels bad to me which is which is the case if you're doing a Greenfield

```timestamp
 41:05
```

project if you are migrating a project you're going to want to think about how you go

```timestamp
 41:12
```

about doing it this is always something that we talk about with our clients what strategy are we going to use to

```timestamp
 41:18
```

> [!NOTE]
> migrate an existing micro monolith to microservice the first one is the Big Bang this is
> 
> ```timestamp
>  41:24
> ```
> 
> where you do it all at once this is usually what this looks like is a bunch
> 

```timestamp
 41:29
```

of developers get locked into a conference room someone slides Pizza under the door occasionally and says don't come out

```timestamp
 41:36
```

until you're done right um this doesn't work very well for any kind

```timestamp
 41:42
```

> [!NOTE]
> of medium or big size project this works really only for small projects and usually small projects don't really need

```timestamp
 41:48
```

to be converted to microservices very much right they're already a small project so I don't really recommend this

```timestamp
 41:54
```

approach but it is one that I have seen done and I've probably seen it fail more than I've seen it succeed the other one

```timestamp
 42:00
```

> [!NOTE]
> is an evolutionary approach you could think of this one as also as waves so this is the approach where you refactor
> 
> ```timestamp
>  42:07
> ```
> 
> your code to be more like microservices which makes the performance worse probably initially and then you refactor
> 

```timestamp
 42:14
```

it again to make it perform better then you say okay that's good now I'm

```timestamp
 42:20
```

going to go back to the original app and pull out some more modules and make the microservices makes the performance

```timestamp
 42:25
```

worse again okay now I'm going to refactor those to make them perform better it gets better and again right so

```timestamp
 42:31
```

you keep doing that until you finished pulling everything out and refactoring it and you kind of get this wave effect

```timestamp
 42:36
```

> [!NOTE]
> of things getting better worse better worse the last one is called the Strangler fig pattern if anybody heard of this one for
> 
> ```timestamp
>  42:43
> ```
> 
> other things yeah okay good so for those that haven't heard of it before it's pretty simple this is where you create
> 
> ```timestamp
>  42:49
> ```
> 
> like a facade layer you could use an API Gateway for this if you're doing microservices and you start refactoring

```timestamp
 42:55
```

things from your legacy app to your modern app in this case it would be from your monolith to your microservices

```timestamp
 43:03
```

and you keep moving things over there as you're moving them over you use that facade layer or the API Gateway to make

```timestamp
 43:10
```

it basically all look exactly the same to the front end so the front end doesn't really have to change at all it's sort of unaware of what's going on

```timestamp
 43:17
```

behind the facade layer and at some point you finish that migration process and everything is now in your modern

```timestamp
 43:24
```

microservices app and theoretically at that point you could get rid of the facade although if it's an API Gateway

```timestamp
 43:30
```

there's other advantages but at that point you finished the pattern now this comes from a Strangler fig plant which

```timestamp
 43:37
```

as I understand actually grows it's dropped by birds and grows starting in

```timestamp
 43:43
```

the limbs of a tree as a Vine it grows down the tree and eventually it gets

```timestamp
 43:48
```

down to the base of the tree and wraps around the roots of the tree underground

```timestamp
 43:53
```

that eventually chokes the life out of that tree the tree dies and it becomes just like a backbone for the vine now

```timestamp
 44:01
```

it's giving the Divine access to the sunlight up high without the vine really having to do any of that work building

```timestamp
 44:07
```

that trunk but the tree is now dead and has basically turned into something new so

```timestamp
 44:14
```

> [!NOTE]
> it's kind of a sounds kind of a nasty little plant if you like trees but it's a great approach for migrating your
> 
> ```timestamp
>  44:21
> ```
> 
> application from one technology to another uh number six now is coupling through

```timestamp
 44:28
```

> [!NOTE]
> cross-cutting concerns there's a lot of cross-cutting concerns in our applications one example of that though
> 
> ```timestamp
>  44:33
> ```
> 
> is logging and I highly recommend that you use logging into microservices along any
> 

```timestamp
 44:39
```

> [!NOTE]
> application but especially in a microservices application because it's so much harder to tell what's happening
> 
> ```timestamp
>  44:44
> ```
> 

in a microservices application if you imagine that you're trying to debug a particular scenario where somebody goes

```timestamp
 44:50
```

in hits one endpoint in microservice a microservice a publishes an event

```timestamp
 44:55
```

microservice B subscribes to that event does some update maybe that's where the bug happens updates its database wrong

```timestamp
 45:02
```

and now all you know is that microservice B has some incorrect data in its data store and you don't really

```timestamp
 45:08
```

know how it happens and it's pretty hard to go back and Trace all of those things that happened so logging is very

```timestamp
 45:15
```

important but also if you write a single logging module and share that into all your applications you actually have the

```timestamp
 45:21
```

potential to create some coupling there for example let's say it's logging to a database to a centralized database let's

```timestamp
 45:27
```

say that database goes down now all your modules just went down right because your logging isn't working another

```timestamp
 45:33
```

example let's say you write it it and I'm a.net guy so let's say you write that logging in the you know the best

```timestamp
 45:40
```

platform available for developers.net but you have another team that wants to build a micro service module in Java or

```timestamp
 45:48
```

something else now they're kind of stuck they can't use your logging because it's only in.net

```timestamp
 45:54
```

right so you've you've coupled the whole team to using a particular Tech stack as well there's a lot of great Solutions out

```timestamp
 46:01
```

there so just be aware of anytime you're doing a cross-cutting concern that you might want to look to see what the best

```timestamp
 46:06
```

practice is I've given you an example here of a good tool to use for logging

```timestamp
 46:11
```

> [!NOTE]
> it's called seek seq and it's inherently
> 
> ```timestamp
>  46:16
> ```
> 
> distributed so it expects to be working as a distributed application it's
> 
> ```timestamp
>  46:22
> ```
> 
> inherently fault tolerant it's got support for basically any platform or language that you've ever heard of

```timestamp
 46:28
```

so it doesn't tie you into a particular Tech stack and it Embraces that eventual

```timestamp
 46:34
```

consistency that is the watchword of microservices

```timestamp
 46:39
```

so be careful when you're doing things like logging make sure you do these things still but make sure that you're

```timestamp
 46:44
```

doing something that is compatible with microservices architecture and doesn't accidentally create coupling

```timestamp
 46:52
```

number seven the use of synchronous communication let's take an example here where you've

```timestamp
 46:57
```

got two modules and orders module and a customers module

```timestamp
 47:03
```

let's say the orders module takes a couple of parameters uh it's a it's

```timestamp
 47:08
```

receiving a new order it's going to get like all the details of the order and then maybe it's going to also get like a customer ID let's say

```timestamp
 47:16
```

it's like an integer or a good or something that just identifies a customer and says this customer is ordering these items in these quantities

```timestamp
 47:24
```

the very first thing that order service is going to have to do is figure out who this customer is now if you've gone and

```timestamp
 47:30
```

just left that customer data only in your customer service you might be really tempted to do something like this where maybe you do like a rest API call

```timestamp
 47:37
```

from your orders service over to your customers service and say why don't you

```timestamp
 47:44
```

just give me customer ID one two three four five and while that's processing this order

```timestamp
 47:50
```

service right these are this is a synchronous call it's a rest API uh it's waiting for that data to come back over

```timestamp
 47:57
```

here from the customer's data store while that's waiting the order service

```timestamp
 48:02
```

is also waiting right now in the best case scenario that data

```timestamp
 48:07
```

comes back and says here's the details about that customer and the orders processing can continue uh with you know

```timestamp
 48:13
```

the mailing address and whatever it needed from the customer now imagine that the customer service

```timestamp
 48:19
```

goes down for maintenance and your order comes in with an order the order details

```timestamp
 48:25
```

and the customer ID now this call basically fails immediately it gets a maybe a 500 or some other kind of you

```timestamp
 48:32
```

know response that indicates that it's not available and now your order service actually went

```timestamp
 48:38
```

down as well or imagine another scenario where the customer service is under heavy load

```timestamp
 48:44
```

maybe somebody's going through and creating a bunch of new customers maybe that's a process that happens every

```timestamp
 48:50
```

month or every year or something there's a bunch of load going on in this application now when this order service

```timestamp
 48:57
```

gets a new order in it's not under any load or maybe it's just under its normal load everything is processing pretty

```timestamp
 49:03
```

normally but now it has to wait three times as long four times as long for the or for the customer service to respond

```timestamp
 49:10
```

now your order service just got slow because your customer service was low so are those really decoupled are those

```timestamp
 49:16
```

independent from each other are you able to Precision scale them not really because if the customer service slow the

```timestamp
 49:23
```

order service is slow now that story I told you at the beginning of this talk about a customer that asked us to help

```timestamp
 49:28
```

with their application they had hundreds of these in between every microservice and every other microservice basically

```timestamp
 49:36
```

> [!NOTE]
> making it a very slow monolith right every time anything happened instead of just executing the code from that other
> 
> ```timestamp
>  49:43
> ```
> 
> module that needed to be executed they made a rest HTTP call now you all

```timestamp
 49:48
```

probably know there's a lot more overhead with that than just executing in this case it was net c-sharp code

```timestamp
 49:55
```

there's a lot more overhead in that than just making a procedure call in a programming language like c-sharp and so

```timestamp
 50:02
```

their whole application got very slow furthermore because these arrows were between every module and every other module what would end up happening is

```timestamp
 50:09
```

one module would get slowed due to actual load which would cause the three that called it to get slow which would

```timestamp
 50:15
```

cause those three to slow down the nine that modules that called it and it only

```timestamp
 50:21
```

> [!NOTE]
> took about a minute every time one module got slow for the whole application to get slow
> 
> ```timestamp
>  50:27
> ```
> 
> uh and so this is a very dangerous one that you definitely want to avoid number eight is breaking changes to event
> 
> ```timestamp
>  50:34
> ```
> 
> contracts you if you haven't done event uh events before if you haven't done microservices before you might have

```timestamp
 50:40
```

already been thinking boy those events kind of end up being like a coupling between the modules right and that's

```timestamp
 50:46
```

true which means you have to have some rules uh and you have to probably do some thinking and maybe even some

```timestamp
 50:52
```

communicating between different teams to figure out what these rules are going to be and make sure everyone's doing the

```timestamp
 50:57
```

same thing in the different service applications uh these are some rules that I suggest

```timestamp
 51:04
```

> [!NOTE]
> just as a starting point and then obviously you need to have this discussion with all the different teams but number one is that no new required
> 
> ```timestamp
>  51:11
> ```
> 
> Fields only optional Fields with documented default values well what do you do when you need to do

```timestamp
 51:17
```

> [!NOTE]
> that um we'll talk about that in Rule Number Four rule number two is that any unrecognized
> 
> ```timestamp
>  51:24
> ```
> 
> field will just be ignored but forwarded right so if you have a service that is going to process some event subscribing

```timestamp
 51:31
```

to some event it sees a new field that it's never seen before it should just ignore that it apparently that's a new

```timestamp
 51:37
```

field that it didn't need to know about right because it didn't exist when it was created but it should forward it in

```timestamp
 51:43
```

other words if it actually publishes an event of its own after it does something it should forward that information on to

```timestamp
 51:49
```

anyone else that might be subscribed because there might be some other microservice that does know what that is that needs it and so ignore but forward

```timestamp
 51:57
```

> [!NOTE]
> rule number three consumers of optional Fields use default values when they're missing right so if
> 

```timestamp
 52:04
```

you are subscribing to an event and someone is publishing that event that doesn't know about a field that you need

```timestamp
 52:09
```

there has to be some sort of a default value for that field and that's what you should assume the value is

```timestamp
 52:15
```

> [!NOTE]
> and then number four is if you can't do these first three then you need to create a whole new event type so you
> 
> ```timestamp
>  52:21
> ```
> 
> might have this isn't the naming convention I would suggest but if you started with a

```timestamp
 52:27
```

to use our example from before if you started with a room updated event you might make this your room updated event

```timestamp
 52:34
```

too right like you actually have to create a new event for this to make breaking changes and now any service

```timestamp
 52:41
```

that publishes the event too is also going to have to publish the original event for anybody that's still

```timestamp
 52:47
```

> [!NOTE]
> subscribed to that problem number nine that I see is not
> 
> ```timestamp
>  52:52
> ```
> 
> automating builds and releases I'm sure none of you are doing this but I've seen a lot of our clients who you know still

```timestamp
 52:59
```

haven't gotten into the whole automated CI CD devops thing and they come to us

```timestamp
 53:04
```

and say hey we heard about microservices we think it might be a good fit for our application we'd like to do those one of

```timestamp
 53:11
```

the very first questions I well the very first question I ask them is why microservices why is that a good fit for

```timestamp
 53:17
```

your project just to try and hear if I hear any of the false things that I've been talking about with you all today or

```timestamp
 53:23
```

if I hear any of the true good reasons you mentioned in there but then maybe the second thing I will ask them is do

```timestamp
 53:29
```

you already have automated devops continuous integration continuous deployment in your in your application

```timestamp
 53:35
```

or not the reason is because the whole point one of the whole points of microservices is high availability and

```timestamp
 53:42
```

uh and the ability to independently deploy so the idea is that you might want to be

```timestamp
 53:48
```

able to deploy pretty frequently and if you're doing that manually that's obviously

```timestamp
 53:54
```

very time consuming very prone to error so I always say as a prerequisite if you

```timestamp
 54:00
```

haven't um if you haven't done cicd already as an automated process

```timestamp
 54:07
```

please consider doing this first before you start doing microservices you'll thank me later

```timestamp
 54:12
```

number 10 is unencapsulated services this is really just another way of

```timestamp
 54:18
```

saying um is talking about coupling loose coupling versus

```timestamp
 54:24
```

too high coupling so you might have heard this analogy before that a well-defined defined

```timestamp
 54:30
```

> [!NOTE]
> service is kind of like an iceberg you know that old saying that ninety percent of an iceberg is below the water line
> 
> ```timestamp
>  54:37
> ```
> 
> and only 10 of it is above the same kind of goes for your API as a well-designed API whether it's for
> 

```timestamp
 54:43
```

microservices or not is going to have a very small surface area that is above

```timestamp
 54:48
```

the water line and a much larger implementation what's great about this is that you can make you can make

```timestamp
 54:55
```

changes to the implementation layer you can refactor things all you want you can

```timestamp
 55:02
```

change how you're storing things you can change what events you're publishing all of that stuff can change pretty

```timestamp
 55:07
```

frequently and you're not breaking anything from that API this also I would say

```timestamp
 55:13
```

applies to events to the events that you publish as well now if you lower that water line

```timestamp
 55:20
```

you can imagine that now anytime you make a change in the back end it's likely that you're going to have to make

```timestamp
 55:25
```

a change in the front end too so simple single purpose apis that just do one

```timestamp
 55:30
```

thing that are very unlikely to have their signatures change is going to make your life a lot easier whether that's an

```timestamp
 55:38
```

event or whether that's like a rest API whatever it is if you're doing microservices designing those API as

```timestamp
 55:45
```

well is going to make a big difference so think about that and maybe take a little extra time as you're designing

```timestamp
 55:50
```

them bonus problem we made it through the 10 that I promised you and now you're

```timestamp
 55:55
```

getting a free one totally free of charge extra which is mismatched teams

```timestamp
 56:03
```

so remember you got a free bonus Pitfall here when you're rating it with the cards on your way out okay

```timestamp
 56:09
```

that moves you up one card I think is the rule so what do I mean by small teams or mismatched teams

```timestamp
 56:19
```

> [!NOTE]
> there we go there's a law called Conway's law that you may have heard before it's often talked about in
> 
> ```timestamp
>  56:26
> ```
> 
> engineering it says that any organization that designs a system will produce a design
> 
> ```timestamp
>  56:32
> ```
> 
> whose structures a copy of the organization organization's communication structure what does that mean basically it means that whatever

```timestamp
 56:40
```

> [!NOTE]
> your team builds is going to look like your org chart right so the common example that's given

```timestamp
 56:46
```

of that is if you give a team of Engineers if you get four teams of Engineers the job to build a compiler

```timestamp
 56:53
```

they're going to create a four pass compiler what does that mean that basically means that there's going to be

```timestamp
 56:59
```

four unique steps because there's no team that's going to basically say oh our contribution to this compiler is

```timestamp
 57:05
```

actually handled perfectly by the other three teams so just ignore us just throw away what we built right every team is

```timestamp
 57:12
```

going to say no ours is important to make sure that you do that so you're going to end up with four steps to that

```timestamp
 57:18
```

process how does that apply to microservices well if you have a single team that's

```timestamp
 57:23
```

working on multiple microservices uh and everyone kind of swatched swapped

```timestamp
 57:28
```

around to all of those as needed you're probably going to end up with a product

```timestamp
 57:35
```

that looks an awful lot like that team you're probably going to end up with a more monolithic product because everyone

```timestamp
 57:40
```

knows everything else it's going to be more tempting for a team member who used

```timestamp
 57:45
```

to be working on module a but it's now working on module B to know that module

```timestamp
 57:50
```

a has some data that they want and to be tempted to go straight and get that data Maybe to copy and paste some code maybe

```timestamp
 57:57
```

to make some of the decisions about the tech Stacks that are used on these different services so that people can be

```timestamp
 58:03
```

swapped in and out of them basically it's going to cause your application to Veer in the direction of a monolith

```timestamp
 58:11
```

so instead of having a single team that works on all your microservices an ideal setup would be to have one team work on

```timestamp
 58:18
```

each micro service if these if you have a huge application complicated business

```timestamp
 58:23
```

this can actually be really ideal because each of these teams can be an expert in each particular module in each

```timestamp
 58:30
```

part of your business they don't really have to care about what's happening in the other parts as long as those teams

```timestamp
 58:35
```

are working but um obviously this isn't totally practical you may not even have this

```timestamp
 58:41
```

many people on your team so you know I don't think it's super important that it'd be a hundred percent

```timestamp
 58:48
```

but just keep in mind that if you go 100 this way

```timestamp
 58:55
```

that it's going to probably bump your application more into the monolithic Direction than you intend

```timestamp
 59:02
```

but if you do something like this where you share uh one team maybe shares a couple different modules that's not

```timestamp
 59:08
```

going to be the end of the world especially if they're always working on those two modules

```timestamp
 59:13
```

all right so to sum up a little bit uh we talked about for lightweight applications that have a single team a

```timestamp
 59:21
```

monolithic system might suit you better or more complex and evolving applications with clear different

```timestamp
 59:27
```

domains between them to use the DVD terminology and if you want to use separate teams

```timestamp
 59:33
```

that are experts in those different areas then microservices might be the best best the best bet

```timestamp
 59:38
```

> [!NOTE]
> don't do microservices unless you have a really good reason to do it because

```timestamp
 59:44
```

monoliths can be good too especially if they're a good fit for your project and then finally to avoid those 10 plus

```timestamp
 59:51
```

1 free pitfalls that we just talked about so some further reading

```timestamp
 59:58
```

if you're interested in learning more uh these three books here is where I would

```timestamp
 1:00:04
```

start a couple of these are by Sam who I think writes the best stuff about microservices and then we also have this

```timestamp
 1:00:12
```

one by Chris Richardson which is a good starting point uh then I would also recommend these

```timestamp
 1:00:19
```

books as well Cloud native architectures and the Dao of microservices

```timestamp
 1:00:24
```

so we defined monoliths microservices and distributed monoliths talked about those 10 Common pitfalls plus the bonus

```timestamp
 1:00:31
```

one give you some further reading now I've just got a few minutes if anybody has

```timestamp
 1:00:36
```

any questions they'd like to ask any burning questions in the room

```timestamp
 1:00:42
```

yes

```timestamp
 1:00:48
```

is

```timestamp
 1:00:55
```

um yeah yeah so the question if I understood correctly is uh I talked a little bit about the migration patterns

```timestamp
 1:01:02
```

and how do you do that at the database level is that correct uh so one of the things that hopefully

```timestamp
 1:01:07
```

you noticed in the talk was that you're going to end up with some repeated data into different modules if you end up

```timestamp
 1:01:13
```

going in the micro Services Direction so one of the options that you have is when you do kind of cut over to your first

```timestamp
 1:01:19
```

microservice going live is that you're probably going to have to do a data migration project of some kind to get

```timestamp
 1:01:25
```

that data initially loaded in there or you could use the event bus to just very

```timestamp
 1:01:30
```

busily for a little while load data in there either way works obviously one is

```timestamp
 1:01:36
```

faster than the other but at some point you're going to have duplicated data anyway so you're really going to start

```timestamp
 1:01:42
```

out by duplicating some data into there that you need you'll also have to think through if in the in between this is

```timestamp
 1:01:49
```

another question I commonly get that's kind of related to your question which is in that in between stage when you start going from a monolith to a

```timestamp
 1:01:56
```

microservice aren't you basically creating a distributed monolith and the answer is yes I think that's unavoidable

```timestamp
 1:02:01
```

just you know be careful of stopping there but hopefully that answers your question about databases did it

```timestamp
 1:02:08
```

cool other questions yes in the front here yeah you mentioned

```timestamp
 1:02:14
```

that there is a problem if you add more experience to events can you elaborate sure sure yeah so the question is about

```timestamp
 1:02:21
```

changing your event signatures specifically adding Fields so adding Fields isn't necessarily a problem as

```timestamp
 1:02:29
```

long as you write all of your event handling code to expect event uh expect

```timestamp
 1:02:35
```

properties to be added to your events the big problem is if you remove one change the name of one change the type

```timestamp
 1:02:42
```

of one right any breaking change like that that's the really big thing adding is okay as long as you kind of look at

```timestamp
 1:02:47
```

those rules that I listed before the four rules if you assume that a property

```timestamp
 1:02:54
```

is that's not there is a default value you have a particular default value all the new properties you

```timestamp
 1:03:00
```

add have to be optional because obviously they may not be there for everything anything that breaks those rules that

```timestamp
 1:03:07
```

needs to have a new property there or needs to change the name of a property that's just a new event type

```timestamp
 1:03:14
```

yep yeah

```timestamp
 1:03:24
```

there should be a UK religion as well right I mean because they're very similar in the position for the

```timestamp
 1:03:30
```

distributed monolith you're saying okay so if I understood the question correctly it's uh there's a use case for

```timestamp
 1:03:36
```

the monolith there's a use case for the microservice is there a use case for the distributed monolith the way I'm

```timestamp
 1:03:42
```

defining it at least in this talk the distributed monolith is kind of the worst of Both Worlds of each and so no

```timestamp
 1:03:49
```

there really isn't long term thank you very much we're out of time but I'm happy to answer any questions if

```timestamp
 1:03:55
```

you want to come up afterwards and uh appreciate your time thank you

Engels (automatisch gegenereerd)

![](https://yt3.ggpht.com/v4LGpL0em9zmZdjLb9-m7SAnk0eqWygGA_OUR9bmhWCGCXCaYR9JeFoxwvH6uTYUTSkSXnswtA=w1060-fcrop64=1,00005a57ffffa5a8-k-c0xffffffff-no-nd-rj)