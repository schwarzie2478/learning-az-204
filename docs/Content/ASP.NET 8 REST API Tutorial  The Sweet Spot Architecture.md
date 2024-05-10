---
status: planted
dg-publish: true
tags:
  - content/video/youtube
creation_date: 2024-05-09 16:48
definition: ASP.NET 8 REST API Tutorial - The "Sweet Spot" Architecture
ms-learn-url: undefined
url: https://www.youtube.com/watch?v=Ms0dFXx3OMc
author:  Amichai Mantinband
---


| MetaData |                                        |
| -------- | -------------------------------------- |
| Author   | `VIEW[{author}][text(renderMarkdown)]` |
| Homesite | `VIEW[{url}][text(renderMarkdown)]`    |

- [ ] Review ASP.NET 8 [[REST API]] Tutorial - The "Sweet Spot" Architecture
This video is the first in a series of videos in which we'll build a REST API completely from scratch using [[ASP.NET 8]]! In this video we'll set up the project and talk about a sweet spot architecture which is before going for full blown [[Clean Architecture]] or more complex architectures like [[Microservice Architecture]] or [[Modular Monolith Architecture]].
## Video
`$= "Made by [[" + dv.current().author+"]]"`
`$= "![video](" + dv.current().url + ")"`

https://youtu.be/Ms0dFXx3OMc?t=605
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

0:00
this video is the first video in a
0:01
series in which we'll build a rest API
0:04
completely from scratch throughout the
0:06
series we're going to be following best
0:07
practices and when I say best practices
0:09
I don't mean what is considered to be
0:12
best practice but it's what I actually
0:15
would do if I were building an
0:16
application completely from scratch to
0:18
make sure that the application is
0:20
resilient compliant something that you
0:22
can actually run confidently in
0:24
production we'll also be following the
0:26
latest features that are available from
0:28
asp.net 8 and we aren't necessarily
0:31
going to be using all the features that
0:33
are the latest features but when a
0:35
feature is available that is better than
0:38
what was previously available then we'll
0:39
use that instead for example when we
0:41
talk about global error handling in
0:43
asp.net then there are new features that
0:46
are available in asp.net 8 that weren't
0:48
available as part of asp.net 6 and most
0:51
importantly this will be sort of a
0:53
realworld example and you'll be able to
0:55
start your application simply by using
0:57
darker compos upend that's it lastly
0:59

> [!NOTE]
> this is is the architecture and
> 1:01
> structure that I would actually
> 1:02
> recommend for you to use if you're
> 1:04
> building a small to medium fairly simple
> 1:07
> application okay now the reason why this

1:10
over here is important is because if
1:12
you're building an application that is
1:14
complex or you're working in a domain
1:16
that is complex or perhaps you have many
1:18
team members that are going to be
1:19
working on this project then you may
1:21
want to start with an architecture that
1:24
sets different foundations to how the
1:26
project will naturally evolve the
1:28
project structure that we're going to be
1:29
working with is perfectly suited for
1:32
welld disciplined teams even for medium
1:35
applications and applications that are a
1:37
bit more complex if you're a d developer
1:39
then I would highly recommend for you to
1:40
watch not only this video but all the
1:43
videos in this series because I'm sure
1:45
you're going to be seeing things that
1:47
you probably aren't doing in your
1:49
production applications today I'll also
1:51
make sure to keep the series suitable
1:53
for beginners not complete beginners in
1:56
software development in general people
1:58

> [!NOTE]
> who have knowledge but also just to
> 2:00
> cover a bit more of the basics from time
> 2:02
> to time so everyone is up to speed on
> 2:04

what we're  doing and why if you're new
2:06
to the channel then welcome my name is
2:07
Amai and in this channel I talk about
2:09
software architecture design patterns
2:11
various things that you really want to
2:13
be familiar with if you're a software
2:14
engineer so if that sounds interesting
2:16
or you want to stay up to date with the
2:18
episodes as they come out then make sure
2:20
to smash the Subscribe button now
2:22
without further Ado let's Jump Right In
2:24
and start talking about software
2:25
architecture when it comes to building
2:27
an application completely from scratch
2:28

> [!NOTE]
> when we're talking about small to
> 2:30
> mediumsized Applications then I would
> 2:33
> recommend not doing any of the three
> 2:36
> that we currently see so not to start
> 2:37

freestyle and just hope that it'll have
2:39
a good structure as you go on but also I
2:42
wouldn't go ahead and start creating
2:44
various projects following clean
2:46
architecture and definitely definitely I
2:48
wouldn't start with microservices what I
2:51
would do is I would use some of the
2:53
principles of clean architecture now you
2:55
don't need to know clean architecture as
2:57
a prerequisite for the series but we we
3:00
talking about specific principles from
3:02
clean architecture we'll see how we can
3:03
integrate them in our application that
3:05
we'll be building but what is important
3:07
is that we're not going to be building
3:09
various projects that are going to have
3:10
references between them and that's how
3:12
our application will be structured but
3:14
we also aren't going to create the
3:16
application completely freestyle and
3:18
hope that things will work out somewhere
3:20
over here there is a sweet spot in which
3:22

> [!NOTE]
> we can build applications that are well
> 3:25
> structured but without the added
> 3:27
> complexity and boiler plate that come
> 3:30
> with starting off directly with clean
> 3:32
> architecture okay so currently we don't
> 3:33

have anything and what I want to do is
3:36
to go ahead and structure our project
3:38
now the way this is going to look is
3:40

> [!NOTE]
> that in the top level we'll have the
> 3:41
> source directory and the test directory
> 3:43
> and we'll also have the actual solution
> 3:46

file alongside this we'll also have over
3:47
here the editor config the global Json
3:50
all of these will also sit in the top
3:53
most layer so for this let's go ahead
3:55
and say net new sln and let's give it
3:58
the name one review next let's go ahead
4:01
and create the source and the test
4:03
folders and inside the source folder
4:07
let's go ahead and create the actual
4:09
project now because we're building a
4:11

> [!NOTE]
> rest API then let's go ahead and say
> 4:12
> donet new web API and we'll be calling it
> 4:15

one review so as expected now we have
4:18
under one rw/ source we also have the
4:21
one riew actual source code the last
4:23
thing I want to do back in the root
4:25
directory is to go ahead and say net new
4:28
and create here a new edit editor config
4:30
another thing that I always create in
4:32
every project is a global Json and a g
4:36
ignore okay so overall this over here is
4:38
what we have but the solution file if we
4:41
look at it then we can see it's still
4:43
empty and there are no projects within
4:45
it so what we want us to do is to say
4:47
net sln add and add all the various
4:49
projects to the solution file if you're
4:52
working on Windows then this won't work
4:54
and instead you need to do the following
4:56
in any case let's go ahead and open the
4:58
project in Visual Studio code now real
5:00
quick before we continue I want to let
5:02
you know that I just launched my deep
5:03
dive into domain dra design course in
5:05
which I walk you through the process of
5:07
taking any domain however complex it may
5:09
be breaking it up following domain
5:11
driven design into subdomains and
5:13
defining the bounded context and finally
5:15
designing the underlying Aggregates
5:17
which you can take in map one to one to
5:20
the codebase overall I now have four
5:21
courses on dome train getting started
5:23
and deep dive into both clean
5:24
architecture and domainer design so if
5:26
you want a step-by-step guide on how to
5:28
build projects following clean
5:30
architecture and domainer design then
5:32
definitely check out those courses now
5:34
back to the video okay so the very first
5:36
thing I want us to do is to actually get
5:38
rid of everything that we aren't going
5:39
to use so we can go ahead and get rid of
5:41
this HTTP file over here and also inside
5:44
the program CS I'm going to get rid of
5:47
almost almost everything we'll be adding
5:49
the relevant things back as we need them
5:52

> [!NOTE]
> but for now all we're going to need is
> 5:54
> the Builder the app and to start the app
> 5:57

okay now if you're not familiar with
5:58
what's going on over here then you
6:00
really don't need to know at this point
6:02
all you need to know is that over here
6:04

> [!NOTE]
> we can go ahead and configure all the
> 6:07
> various services so this is the
> 6:09
> dependency injection configurations Etc

6:11
and over here we can go ahead and
6:13

> [!NOTE]
> configure the request Pipeline and of
> 6:15

course there are other things as well
6:16
that you can do over here and over here
6:18
if you're lacking knowledge on what we
6:19
have currently on the screen then I'll
6:21
put some thumbnails of videos of mine on
6:23
the screen and check out those videos
6:25
they'll give you some context into
6:27
what's going on here for now all I want
6:28
us to do is to just clean things up so
6:30
we don't have anything we don't need so
6:32
likewise in the Cs Pro then I'm going to
6:34

> [!NOTE]
> get rid of the open API Swagger related

6:37
things and basically I'm going to leave
6:39
us with nothing so overall what we have
6:42

> [!NOTE]
> we're using net 8 and we're using the
> 6:45
> web SDK which includes in it all the
> 6:47
> various assemblies that will allow us to

6:50
use the Net Framework and ecosystem that
6:52
we have for writing Rest apis or web
6:55
apis in general okay now that we have
6:56
this let's talk about the structure that
6:58
we're going to have so over here we're
6:59

> [!NOTE]
> going to have a folder called
> 7:00
> controllers and I'll make this a bit

7:02
bigger so you can see what's going on
7:04
and this folder as you would expect is
7:05
where the controllers will sit other
7:07
than this we're also going to have a
7:09

> [!NOTE]
> folder called services and a folder
> 7:11
> called domain and the last highlevel

7:14
folder that we're going to be talking
7:15

> [!NOTE]
> about for now is the persistence folder

7:18
as well okay so again all we have is one
7:21
single project and in this project we
7:23

> [!NOTE]
> have the controllers this is how users
> 7:25
> will be interacting with our application

7:27

> [!NOTE]
> the controllers will be interacting
> 7:29
> acting directly with the various
> 7:31
> services in the services folder and the

7:34

> [!NOTE]
> services will go ahead and orchestrate
> 7:36
> the operation that's taking place the

7:39
use case the underlying flow that we're
7:41
trying to run to do this they may go
7:42
ahead and interact with various web
7:44
clients or with the database and they'll
7:47
orchestrate whatever needs to be done
7:49
and finally they'll return a result to
7:51

> [!NOTE]
> the controller which will return a
> 7:52
> result back to the client the

7:54

> [!NOTE]
> persistence is where we're going to have
> 7:56
> anything database related and the domain

7:58
is where we're going to have the
8:00

> [!NOTE]
> underlying domain objects domain logic

8:02
and anything that has to do with
8:04
business decisions or business logic or
8:07
terms in general now either next week or
8:09
the week after that then there'll be a
8:11

> [!NOTE]
> video regarding application logic versus
> 8:13
> domain logic versus presentation logic

8:15
in which we'll talk about exactly what
8:17
sits in which layer so if this doesn't
8:19
make too much sense yet then this should
8:21
make more sense as you see more examples
8:23
and we talk about the specifics and the
8:25
classification of each one of these
8:28
logical components in our codebase so
8:30
like we said there's a sweet spot where
8:32
you don't go ahead and just do whatever
8:34
you want or you go ahead and create
8:36
multiple projects doesn't have to be
8:37
clean architecture but just in
8:39
architecture where you have multiple
8:41
projects and references between them
8:43
which many times is an Overkill from a
8:45
borderer plate and just the the time
8:48
consumption of building and structuring
8:50

> [!NOTE]
> such a project then there's this sweet
> 8:53
> spot where you have the best of both
> 8:55
> worlds you work within one assembly but
> 8:58
> you still have the structure to put the
> 9:00
> different logical components in the

9:02
corresponding project and of course as
9:05
we start building the project and we add
9:06
more and more features then this will
9:08
become larger and larger and we'll have
9:11
various decisions that we'll need to
9:12
make but this is the initial structure
9:15

> [!NOTE]
> that I think is perfectly suited for any
> 9:18
> small to medium pretty simple
> 9:20
> application as you're just starting out

9:22
now of course you won't 100% of the time
9:25
start out your project like this it
9:26
depends on the domain it depends on the
9:28
problem space you will probably know if
9:31
this is suitable for you or if you need
9:33
something a bit more advanced depending
9:35
on the environment and the domain that
9:37
you're working in and when I say
9:39
environment I'm talking specifically
9:40
about the teams that'll be working on
9:42
who are the people how many teams what
9:44
are the relationship between the teams
9:45
how often can you SN with them all these
9:47
will guide you to whether or not this
9:50
structure can work for you but from my
9:52
experience most of the time something
9:54
like this just to get the product up and
9:57
running until it reaches some scale SC
9:59
then this is a great place to start out
10:02
this is only the starting point if you
10:04
see that you start having many
10:05
controllers many services you have a lot
10:08
of logic in your domain folder and you
10:11
start noticing that you're losing the
10:13
cohesion that you originally had then
10:15
this is a good time to stop and say okay
10:18
maybe perhaps what I should do is I
10:20
should refactor the architecture and
10:22
what will happen if this application
10:23
actually grows and morphs and starts
10:26
becoming a bit more of a mess is that
10:27
you'll take each one of the folders and
10:30
this will likely turn into its own
10:33
project and it will interact with
10:35
another project which was previously a
10:37
folder okay so I want you to have in
10:38
mind the sort of evolution that you can
10:40
go through where a folder will turn into
10:43
its entire layer and sometime in the
10:45
future then slices of each one of the
10:49
layers something like this all of these
10:51
will go ahead and become its own project
10:54
inside a microservice or modular
10:56
monolith architecture and in the end the
10:58
archit cure the project the codebase is
11:01
a life thing things always change and
11:03
every once in a while we hit this sort
11:04
of threshold where we need to pause
11:06
rethink what we currently have and
11:08
refactor if necessary in the upcoming
11:10
videos we'll talk about our domain how
11:12
to structure our rest API how to build
11:14
the actual endpoints what parts of logic
11:18
sit in which part of the application
11:20
logging error handling and much much
11:22
more so definitely smash the Subscribe
11:23
button if you don't want to miss out on
11:25
that and of course smash the like button
11:26
because why not and I'll see you in the
11:28
next one