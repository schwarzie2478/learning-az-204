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

```timestamp
 0:00
```
this video is the first video in a
```timestamp
 0:01
```
series in which we'll build a rest API
```timestamp
 0:04
```
completely from scratch throughout the
```timestamp
 0:06
```
series we're going to be following best
```timestamp
 0:07
```
practices and when I say best practices
```timestamp
 0:09
```
I don't mean what is considered to be
```timestamp
 0:12
```
best practice but it's what I actually
```timestamp
 0:15
```
would do if I were building an
```timestamp
 0:16
```
application completely from scratch to
```timestamp
 0:18
```
make sure that the application is
```timestamp
 0:20
```
resilient compliant something that you
```timestamp
 0:22
```
can actually run confidently in
```timestamp
 0:24
```
production we'll also be following the
```timestamp
 0:26
```
latest features that are available from
```timestamp
 0:28
```
asp.net 8 and we aren't necessarily
```timestamp
 0:31
```
going to be using all the features that
```timestamp
 0:33
```
are the latest features but when a
```timestamp
 0:35
```
feature is available that is better than
```timestamp
 0:38
```
what was previously available then we'll
```timestamp
 0:39
```
use that instead for example when we
```timestamp
 0:41
```
talk about global error handling in
```timestamp
 0:43
```
asp.net then there are new features that
```timestamp
 0:46
```
are available in asp.net 8 that weren't
```timestamp
 0:48
```
available as part of asp.net 6 and most
```timestamp
 0:51
```
importantly this will be sort of a
```timestamp
 0:53
```
realworld example and you'll be able to
```timestamp
 0:55
```
start your application simply by using
```timestamp
 0:57
```
darker compos upend that's it lastly
```timestamp
 0:59
```

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

```timestamp
 1:10
```
over here is important is because if
```timestamp
 1:12
```
you're building an application that is
```timestamp
 1:14
```
complex or you're working in a domain
```timestamp
 1:16
```
that is complex or perhaps you have many
```timestamp
 1:18
```
team members that are going to be
```timestamp
 1:19
```
working on this project then you may
```timestamp
 1:21
```
want to start with an architecture that
```timestamp
 1:24
```
sets different foundations to how the
```timestamp
 1:26
```
project will naturally evolve the
```timestamp
 1:28
```
project structure that we're going to be
```timestamp
 1:29
```
working with is perfectly suited for
```timestamp
 1:32
```
welld disciplined teams even for medium
```timestamp
 1:35
```
applications and applications that are a
```timestamp
 1:37
```
bit more complex if you're a d developer
```timestamp
 1:39
```
then I would highly recommend for you to
```timestamp
 1:40
```
watch not only this video but all the
```timestamp
 1:43
```
videos in this series because I'm sure
```timestamp
 1:45
```
you're going to be seeing things that
```timestamp
 1:47
```
you probably aren't doing in your
```timestamp
 1:49
```
production applications today I'll also
```timestamp
 1:51
```
make sure to keep the series suitable
```timestamp
 1:53
```
for beginners not complete beginners in
```timestamp
 1:56
```
software development in general people
```timestamp
 1:58
```

> [!NOTE]
> who have knowledge but also just to
> 2:00
> cover a bit more of the basics from time
> 2:02
> to time so everyone is up to speed on
> 2:04

what we're  doing and why if you're new
```timestamp
 2:06
```
to the channel then welcome my name is
```timestamp
 2:07
```
Amai and in this channel I talk about
```timestamp
 2:09
```
software architecture design patterns
```timestamp
 2:11
```
various things that you really want to
```timestamp
 2:13
```
be familiar with if you're a software
```timestamp
 2:14
```
engineer so if that sounds interesting
```timestamp
 2:16
```
or you want to stay up to date with the
```timestamp
 2:18
```
episodes as they come out then make sure
```timestamp
 2:20
```
to smash the Subscribe button now
```timestamp
 2:22
```
without further Ado let's Jump Right In
```timestamp
 2:24
```
and start talking about software
```timestamp
 2:25
```
architecture when it comes to building
```timestamp
 2:27
```
an application completely from scratch
```timestamp
 2:28
```

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
```timestamp
 2:39
```
a good structure as you go on but also I
```timestamp
 2:42
```
wouldn't go ahead and start creating
```timestamp
 2:44
```
various projects following clean
```timestamp
 2:46
```
architecture and definitely definitely I
```timestamp
 2:48
```
wouldn't start with microservices what I
```timestamp
 2:51
```
would do is I would use some of the
```timestamp
 2:53
```
principles of clean architecture now you
```timestamp
 2:55
```
don't need to know clean architecture as
```timestamp
 2:57
```
a prerequisite for the series but we we
```timestamp
 3:00
```
talking about specific principles from
```timestamp
 3:02
```
clean architecture we'll see how we can
```timestamp
 3:03
```
integrate them in our application that
```timestamp
 3:05
```
we'll be building but what is important
```timestamp
 3:07
```
is that we're not going to be building
```timestamp
 3:09
```
various projects that are going to have
```timestamp
 3:10
```
references between them and that's how
```timestamp
 3:12
```
our application will be structured but
```timestamp
 3:14
```
we also aren't going to create the
```timestamp
 3:16
```
application completely freestyle and
```timestamp
 3:18
```
hope that things will work out somewhere
```timestamp
 3:20
```
over here there is a sweet spot in which
```timestamp
 3:22
```

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
```timestamp
 3:36
```
to go ahead and structure our project
```timestamp
 3:38
```
now the way this is going to look is
```timestamp
 3:40
```

> [!NOTE]
> that in the top level we'll have the
> 3:41
> source directory and the test directory
> 3:43
> and we'll also have the actual solution
> 3:46

file alongside this we'll also have over
```timestamp
 3:47
```
here the editor config the global Json
```timestamp
 3:50
```
all of these will also sit in the top
```timestamp
 3:53
```
most layer so for this let's go ahead
```timestamp
 3:55
```
and say net new sln and let's give it
```timestamp
 3:58
```
the name one review next let's go ahead
```timestamp
 4:01
```
and create the source and the test
```timestamp
 4:03
```
folders and inside the source folder
```timestamp
 4:07
```
let's go ahead and create the actual
```timestamp
 4:09
```
project now because we're building a
```timestamp
 4:11
```

> [!NOTE]
> rest API then let's go ahead and say
> 4:12
> donet new web API and we'll be calling it
> 4:15

one review so as expected now we have
```timestamp
 4:18
```
under one rw/ source we also have the
```timestamp
 4:21
```
one riew actual source code the last
```timestamp
 4:23
```
thing I want to do back in the root
```timestamp
 4:25
```
directory is to go ahead and say net new
```timestamp
 4:28
```
and create here a new edit editor config
```timestamp
 4:30
```
another thing that I always create in
```timestamp
 4:32
```
every project is a global Json and a g
```timestamp
 4:36
```
ignore okay so overall this over here is
```timestamp
 4:38
```
what we have but the solution file if we
```timestamp
 4:41
```
look at it then we can see it's still
```timestamp
 4:43
```
empty and there are no projects within
```timestamp
 4:45
```
it so what we want us to do is to say
```timestamp
 4:47
```
net sln add and add all the various
```timestamp
 4:49
```
projects to the solution file if you're
```timestamp
 4:52
```
working on Windows then this won't work
```timestamp
 4:54
```
and instead you need to do the following
```timestamp
 4:56
```
in any case let's go ahead and open the
```timestamp
 4:58
```
project in Visual Studio code now real
```timestamp
 5:00
```
quick before we continue I want to let
```timestamp
 5:02
```
you know that I just launched my deep
```timestamp
 5:03
```
dive into domain dra design course in
```timestamp
 5:05
```
which I walk you through the process of
```timestamp
 5:07
```
taking any domain however complex it may
```timestamp
 5:09
```
be breaking it up following domain
```timestamp
 5:11
```
driven design into subdomains and
```timestamp
 5:13
```
defining the [[bounded context]] and finally
```timestamp
 5:15
```
designing the underlying [[Aggregates]]
```timestamp
 5:17
```
which you can take in map one to one to
```timestamp
 5:20
```
the codebase overall I now have four
```timestamp
 5:21
```
courses on dome train getting started
```timestamp
 5:23
```
and deep dive into both clean
```timestamp
 5:24
```
architecture and domainer design so if
```timestamp
 5:26
```
you want a step-by-step guide on how to
```timestamp
 5:28
```
build projects following clean
```timestamp
 5:30
```
architecture and domainer design then
```timestamp
 5:32
```
definitely check out those courses now
```timestamp
 5:34
```
back to the video okay so the very first
```timestamp
 5:36
```
thing I want us to do is to actually get
```timestamp
 5:38
```
rid of everything that we aren't going
```timestamp
 5:39
```
to use so we can go ahead and get rid of
```timestamp
 5:41
```
this HTTP file over here and also inside
```timestamp
 5:44
```
the program CS I'm going to get rid of
```timestamp
 5:47
```
almost almost everything we'll be adding
```timestamp
 5:49
```
the relevant things back as we need them
```timestamp
 5:52
```

> [!NOTE]
> but for now all we're going to need is
> 5:54
> the Builder the app and to start the app
> 5:57

okay now if you're not familiar with
```timestamp
 5:58
```
what's going on over here then you
```timestamp
 6:00
```
really don't need to know at this point
```timestamp
 6:02
```
all you need to know is that over here
```timestamp
 6:04
```

> [!NOTE]
> we can go ahead and configure all the
> 6:07
> various services so this is the
> 6:09
> dependency injection configurations Etc

```timestamp
 6:11
```
and over here we can go ahead and
```timestamp
 6:13
```

> [!NOTE]
> configure the request Pipeline and of
> 6:15

course there are other things as well
```timestamp
 6:16
```
that you can do over here and over here
```timestamp
 6:18
```
if you're lacking knowledge on what we
```timestamp
 6:19
```
have currently on the screen then I'll
```timestamp
 6:21
```
put some thumbnails of videos of mine on
```timestamp
 6:23
```
the screen and check out those videos
```timestamp
 6:25
```
they'll give you some context into
```timestamp
 6:27
```
what's going on here for now all I want
```timestamp
 6:28
```
us to do is to just clean things up so
```timestamp
 6:30
```
we don't have anything we don't need so
```timestamp
 6:32
```
likewise in the Cs Pro then I'm going to
```timestamp
 6:34
```

> [!NOTE]
> get rid of the open API Swagger related

```timestamp
 6:37
```
things and basically I'm going to leave
```timestamp
 6:39
```
us with nothing so overall what we have
```timestamp
 6:42
```

> [!NOTE]
> we're using net 8 and we're using the
> 6:45
> web SDK which includes in it all the
> 6:47
> various assemblies that will allow us to

```timestamp
 6:50
```
use the Net Framework and ecosystem that
```timestamp
 6:52
```
we have for writing Rest apis or web
```timestamp
 6:55
```
apis in general okay now that we have
```timestamp
 6:56
```
this let's talk about the structure that
```timestamp
 6:58
```
we're going to have so over here we're
```timestamp
 6:59
```

> [!NOTE]
> going to have a folder called
> 7:00
> controllers and I'll make this a bit

```timestamp
 7:02
```
bigger so you can see what's going on
```timestamp
 7:04
```
and this folder as you would expect is
```timestamp
 7:05
```
where the controllers will sit other
```timestamp
 7:07
```
than this we're also going to have a
```timestamp
 7:09
```

> [!NOTE]
> folder called services and a folder
> 7:11
> called domain and the last highlevel

```timestamp
 7:14
```
folder that we're going to be talking
```timestamp
 7:15
```

> [!NOTE]
> about for now is the persistence folder

```timestamp
 7:18
```
as well okay so again all we have is one
```timestamp
 7:21
```
single project and in this project we
```timestamp
 7:23
```

> [!NOTE]
> have the controllers this is how users
> 7:25
> will be interacting with our application

```timestamp
 7:27
```

> [!NOTE]
> the controllers will be interacting
> 7:29
> acting directly with the various
> 7:31
> services in the services folder and the

```timestamp
 7:34
```

> [!NOTE]
> services will go ahead and orchestrate
> 7:36
> the operation that's taking place the

```timestamp
 7:39
```
use case the underlying flow that we're
```timestamp
 7:41
```
trying to run to do this they may go
```timestamp
 7:42
```
ahead and interact with various web
```timestamp
 7:44
```
clients or with the database and they'll
```timestamp
 7:47
```
orchestrate whatever needs to be done
```timestamp
 7:49
```
and finally they'll return a result to
```timestamp
 7:51
```

> [!NOTE]
> the controller which will return a
> 7:52
> result back to the client the

```timestamp
 7:54
```

> [!NOTE]
> persistence is where we're going to have
> 7:56
> anything database related and the domain

```timestamp
 7:58
```
is where we're going to have the
```timestamp
 8:00
```

> [!NOTE]
> underlying domain objects domain logic

```timestamp
 8:02
```
and anything that has to do with
```timestamp
 8:04
```
business decisions or business logic or
```timestamp
 8:07
```
terms in general now either next week or
```timestamp
 8:09
```
the week after that then there'll be a
```timestamp
 8:11
```

> [!NOTE]
> video regarding application logic versus
> 8:13
> domain logic versus presentation logic

```timestamp
 8:15
```
in which we'll talk about exactly what
```timestamp
 8:17
```
sits in which layer so if this doesn't
```timestamp
 8:19
```
make too much sense yet then this should
```timestamp
 8:21
```
make more sense as you see more examples
```timestamp
 8:23
```
and we talk about the specifics and the
```timestamp
 8:25
```
classification of each one of these
```timestamp
 8:28
```
logical components in our codebase so
```timestamp
 8:30
```
like we said there's a sweet spot where
```timestamp
 8:32
```
you don't go ahead and just do whatever
```timestamp
 8:34
```
you want or you go ahead and create
```timestamp
 8:36
```
multiple projects doesn't have to be
```timestamp
 8:37
```
clean architecture but just in
```timestamp
 8:39
```
architecture where you have multiple
```timestamp
 8:41
```
projects and references between them
```timestamp
 8:43
```
which many times is an Overkill from a
```timestamp
 8:45
```
borderer plate and just the the time
```timestamp
 8:48
```
consumption of building and structuring
```timestamp
 8:50
```

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

```timestamp
 9:02
```
corresponding project and of course as
```timestamp
 9:05
```
we start building the project and we add
```timestamp
 9:06
```
more and more features then this will
```timestamp
 9:08
```
become larger and larger and we'll have
```timestamp
 9:11
```
various decisions that we'll need to
```timestamp
 9:12
```
make but this is the initial structure
```timestamp
 9:15
```

> [!NOTE]
> that I think is perfectly suited for any
> 9:18
> small to medium pretty simple
> 9:20
> application as you're just starting out

```timestamp
 9:22
```
now of course you won't 100% of the time
```timestamp
 9:25
```
start out your project like this it
```timestamp
 9:26
```
depends on the domain it depends on the
```timestamp
 9:28
```
problem space you will probably know if
```timestamp
 9:31
```
this is suitable for you or if you need
```timestamp
 9:33
```
something a bit more advanced depending
```timestamp
 9:35
```
on the environment and the domain that
```timestamp
 9:37
```
you're working in and when I say
```timestamp
 9:39
```
environment I'm talking specifically
```timestamp
 9:40
```
about the teams that'll be working on
```timestamp
 9:42
```
who are the people how many teams what
```timestamp
 9:44
```
are the relationship between the teams
```timestamp
 9:45
```
how often can you SN with them all these
```timestamp
 9:47
```
will guide you to whether or not this
```timestamp
 9:50
```
structure can work for you but from my
```timestamp
 9:52
```
experience most of the time something
```timestamp
 9:54
```
like this just to get the product up and
```timestamp
 9:57
```
running until it reaches some scale SC
```timestamp
 9:59
```
then this is a great place to start out
```timestamp
 10:02
```
this is only the starting point if you
```timestamp
 10:04
```
see that you start having many
```timestamp
 10:05
```
controllers many services you have a lot
```timestamp
 10:08
```
of logic in your domain folder and you
```timestamp
 10:11
```
start noticing that you're losing the
```timestamp
 10:13
```
cohesion that you originally had then
```timestamp
 10:15
```
this is a good time to stop and say okay
```timestamp
 10:18
```
maybe perhaps what I should do is I
```timestamp
 10:20
```
should refactor the architecture and
```timestamp
 10:22
```
what will happen if this application
```timestamp
 10:23
```
actually grows and morphs and starts
```timestamp
 10:26
```
becoming a bit more of a mess is that
```timestamp
 10:27
```
you'll take each one of the folders and
```timestamp
 10:30
```
this will likely turn into its own
```timestamp
 10:33
```
project and it will interact with
```timestamp
 10:35
```
another project which was previously a
```timestamp
 10:37
```
folder okay so I want you to have in
```timestamp
 10:38
```
mind the sort of evolution that you can
```timestamp
 10:40
```
go through where a folder will turn into
```timestamp
 10:43
```
its entire layer and sometime in the
```timestamp
 10:45
```
future then slices of each one of the
```timestamp
 10:49
```
layers something like this all of these
```timestamp
 10:51
```
will go ahead and become its own project
```timestamp
 10:54
```
inside a microservice or modular
```timestamp
 10:56
```
monolith architecture and in the end the
```timestamp
 10:58
```
archit cure the project the codebase is
```timestamp
 11:01
```
a life thing things always change and
```timestamp
 11:03
```
every once in a while we hit this sort
```timestamp
 11:04
```
of threshold where we need to pause
```timestamp
 11:06
```
rethink what we currently have and
```timestamp
 11:08
```
refactor if necessary in the upcoming
```timestamp
 11:10
```
videos we'll talk about our domain how
```timestamp
 11:12
```
to structure our rest API how to build
```timestamp
 11:14
```
the actual endpoints what parts of logic
```timestamp
 11:18
```
sit in which part of the application
```timestamp
 11:20
```
logging error handling and much much
```timestamp
 11:22
```
more so definitely smash the Subscribe
```timestamp
 11:23
```
button if you don't want to miss out on
```timestamp
 11:25
```
that and of course smash the like button
```timestamp
 11:26
```
because why not and I'll see you in the
```timestamp
 11:28
```
next one