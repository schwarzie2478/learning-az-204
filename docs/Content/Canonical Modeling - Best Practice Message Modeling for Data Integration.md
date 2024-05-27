---
status: planted
dg-publish: true
tags:
  - content/video/youtube
creation_date: 2024-05-25 11:38
definition: Canonical Modeling - Best Practice Message Modeling for Data Integration
ms-learn-url: undefined
url: https://www.youtube.com/watch?v=mRthhbAtJ7o
author: April Reeve
---


| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Author   | `VIEW[{author}][text(renderMarkdown)]`          |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |

- [ ] Review Canonical Modeling - Best Practice Message Modeling for Data Integration

## Video
`$= "Made by [[" + dv.current().author+"]]"`
Open player in Obsidian:
```timestamp-url 
 https://www.youtube.com/watch?v=mRthhbAtJ7o
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
 0:00
```
so thanks very much for coming down and oh good it works and I don't have to
```timestamp
 0:05
```
stand back there so basically I sort of describe myself and I'm sure a lot of
```timestamp
 0:12
```
you here describe yourselves well you may not describe yourselves in the past this way
```timestamp
 0:17
```
but maybe in the future you will I do data stuff I'm a data stuff person okay
```timestamp
 0:22
```
whatever you want to do with your data I can help you do it so so that's pretty
```timestamp
 0:27
```
much what what I do and I just want to you know so the that you don't have to
```timestamp
 0:34
```
get too settled in and you can leave if you want to I'm not teaching anybody how to do canonical modeling today okay it's
```timestamp
 0:41
```
a 50-minute presentation and all we have time to do is talk about what it is and
```timestamp
 0:46
```
why we why you might want to do it but okay if you expected to come here and learn how to do it unfortunately we
```timestamp
 0:53
```
don't have time so we'd have to request a tutorial so maybe you could write down down as a suggestion you know canonical
```timestamp
 1:00
```
modeling how to do it that might be a really good session for a tutorial or
```timestamp
 1:05
```
workshop for for next time but so I don't want you feel disappointed okay
```timestamp
 1:11
```
we're not doing how to do canonical modeling today so don't get too so I
```timestamp
 1:17
```
hope you don't get too depressed about that but now so why this came up for me
```timestamp
 1:25
```
was kind of for a number of reasons but but what what started with was that we
```timestamp
 1:31
```
sold an engagement a data governance engagement and one of the deliverables was a canonical model okay and my
```timestamp
 1:40
```
colleague who actually you know created this a plan engagement and the client
```timestamp
 1:47
```
had two definitions of what a canonical model were and so you know there was
```timestamp
 1:54
```
there was this little disagreement about it it didn't really cause a big problem
```timestamp
 1:59
```
but I looked up canonical modeling in Wikipedia and interestingly enough
```timestamp
 2:04
```
Wikipedia on the you know the one page had both definitions of canonical
```timestamp
 2:09
```
modeling am i blocking you guys because I can go stand over here so okay oh you could say right so they
```timestamp
 2:21
```
had they had both definitions of canonical modeling in terms of the client and and my colleague in terms in
```timestamp
 2:28
```
terms of this but basically you know canonical comes from the idea of a you
```timestamp
 2:34
```
know Canon write or rule and the way we use canonical I don't know who really
```timestamp
 2:40
```

> [!NOTE]
> uses canonical in English but the way it's come to mean is more like a standard okay so you know we're the

```timestamp
 2:49
```
typical or and and the term that Mike
```timestamp
 2:55
```
Ferguson was using yesterday and dative virtualization was a common model okay
```timestamp
 3:02
```
so there was Betsy alright so that's what what a canonical model the model means is a common models
```timestamp
 3:07
```
you can all leave we're done that so it's the idea that it provides the
```timestamp
 3:13
```

> [!NOTE]
> simplest form to create a standard common view okay so you can see in data
> ```timestamp
>  3:23
> ```

governance which is what the engagement was that I was working on okay what we
```timestamp
 3:29
```

> [!NOTE]
> were talking about was a common view of the business terms and of the

```timestamp
 3:36
```
organization okay which is one of the standard deliverables that in a data
```timestamp
 3:41
```
governance engagement is that you help them to create this this the these
```timestamp
 3:47
```

> [!NOTE]
> common definitions of their of their major business terms in their organization and and creating a common

```timestamp
 3:55
```
definition is hard and and so that's that definition of it but the the where
```timestamp
 4:04
```
it's also used and where I'm also engaged in and so I actually sort of
```timestamp
 4:09
```

> [!NOTE]
> initially assumed that that that what the deliverable meant was in data
> ```timestamp
>  4:16
> ```
> integration and messaging right it's the it's the central hub of all your
> ```timestamp
>  4:23
> ```
> messaging and your and your data integration movement it's the it's the definition of all the

```timestamp
 4:29
```
data in your organization that has to move through this central hub so we'll go through that so so here's the the you
```timestamp
 4:46
```
know here's where so you can kind of see where those two definitions are sort of
```timestamp
 4:53
```

> [!NOTE]
> the same definition so in one case you're talking about common business terms and defining them in another case
> ```timestamp
>  5:00
> ```
> you define you're talking about creating a central model for your organization of

```timestamp
 5:05
```
all the things in your organization so that that's going to pass through and wikipedia had both definitions just kind
```timestamp
 5:12
```
of write together they're on the same page and they weren't saying one is a set of common business terms and
```timestamp
 5:18
```
definitions and two is a central hub of messaging for messaging so so so you
```timestamp
 5:26
```
know my colleague wasn't the only person who was who was confused about it so if
```timestamp
 5:32
```

> [!NOTE]
> you're doing an enterprise integration strategy one of the things you you will
> ```timestamp
>  5:38
> ```
> talk about is a hub-and-spoke architecture and there's the hub so so
> ```timestamp
>  5:44
> ```
> you need a canonical model for the hub in your hub and spoke architecture and

```timestamp
 5:50
```

> [!NOTE]
> and that's the second definition of canonical model and the canonical
> ```timestamp
>  5:57
> ```
> business model is the common set of business terms used by an organization

```timestamp
 6:03
```
and you know a it does and you know anybody here have data governance
```timestamp
 6:11
```
activities happening at their organizations or that you know that they're consulting you know so one of
```timestamp
 6:17
```

> [!NOTE]
> the first things that we do is is we try to help to create this set of common
> ```timestamp
>  6:23
> ```
> business terms and definitions because because some of the main metrics for the

```timestamp
 6:29
```
organization can often get really confused because people are using the same term to have different meanings so
```timestamp
 6:36
```
for example how many customers do we have is frequently a problem
```timestamp
 6:42
```
because different parts of the organization or even different people within the same parts of the
```timestamp
 6:47
```
organization are defining the word customer to mean different things I mean certainly if you talk to your marketing
```timestamp
 6:55
```
and sales organizations they're going to include prospects in it this is the traditional explanation of this they're
```timestamp
 7:01
```
going to include prospects in the the count of customers whereas whereas an
```timestamp
 7:08
```
operational part of the organization is going to say no no it's only P it's only people with accounts ok it's a people
```timestamp
 7:15
```
we've already sold to and we have accounts set up for that's those are our customers so counting customers is is
```timestamp
 7:22
```
the easy one because because everybody has this problem different parts of your organization I bet are calling a customer to have
```timestamp
 7:30
```
different meanings ok and and so we this is this is a really important just very
```timestamp
 7:40
```
basic problem that every organization has and and unless you solve this
```timestamp
 7:46
```
problem you're you know there's no report that's going to be right for everybody because the metric is going to
```timestamp
 7:54
```
say number of customers and what were they counting right what was what's the
```timestamp
 8:00
```

> [!NOTE]
> definition of that metric so this is this is a very basic problem and we do
> ```timestamp
>  8:06
> ```
> canonical modeling ie we identify the the business terms in different domains
> ```timestamp
>  8:13
> ```
> and then we define them and we try to create definitions that the entire

```timestamp
 8:19
```

> [!NOTE]
> enterprise can agree on and if you need a definition a special definition then
> ```timestamp
>  8:24
> ```
> you create a special definition for that part of the organization or that subsidy or whatever whatever is necessary but

```timestamp
 8:31
```
but you qualify the definition you know so you'll say you know a marketing
```timestamp
 8:37
```
customer is ok where a prospective customer is so that's a that's what that
```timestamp
 8:45
```
we do it's very basic part of data governance so here as an example I just
```timestamp
 8:52
```
this is this is in the address domain everybody has an address well address is a kind of a cross domain
```timestamp
 8:58
```
kind of domain and these are a bunch of the business terms that we define in
```timestamp
 9:04
```
this domain and this is just this is just address so didn't really think this was something I had to worry about to
```timestamp
 9:13
```
secrecy or anything I think you think you all know you know that these these are the kinds of things that you need to
```timestamp
 9:19
```
define for the organization okay now
```timestamp
 9:25
```

> [!NOTE]
> message modeling is something a little bit different so traditionally when we
> ```timestamp
>  9:34
> ```
> want to pass information from one system to another system okay we you know let's

```timestamp
 9:41
```
say create a file out of system a and we move it over to wherever system B is
```timestamp
 9:47
```
located and then we load it into system B and then you know if have to get data
```timestamp
 9:53
```
going back we do it the other way and maybe you eliminate the actual files and
```timestamp
 9:58
```
you're just passing the data back and forth okay but the way that system a is
```timestamp
 10:04
```
looking at data in the way that system B is looking at data are two different things and so we use transformation of
```timestamp
 10:11
```
the data and ETLs and kind of interesting points like that there's a
```timestamp
 10:16
```
mathematical problem with this that that
```timestamp
 10:22
```
in terms of portfolio management terms of managing your the computer systems in
```timestamp
 10:27
```

> [!NOTE]
> your organization okay and that is that if if that's the way you build interfaces in your organization you will
> ```timestamp
>  10:35
> ```
> very quickly have a complex problem of
> ```timestamp
>  10:41
> ```
> complexity so great that it cannot be managed by anyone okay at a very small
> ```timestamp
>  10:46
> ```
> number of applications so and this is

```timestamp
 10:51
```
this is like you know the biggest improvement for portfolio management
```timestamp
 10:58
```
that I can suggest I'm actually writing a book for Morgan Kaufmann and this is
```timestamp
 11:04
```

> [!NOTE]
> one of the things in terms of hub-and-spoke architecture okay in in if you try to do
> ```timestamp
>  11:11
> ```
> point-to-point integration in your in your organization if you have five
> ```timestamp
>  11:19
> ```
> systems and all of them need to pass data back and forth between each other
> ```timestamp
>  11:24
> ```
> okay that's you will have ten interactions that you that you need to

```timestamp
 11:30
```
build okay and and basically the formula
```timestamp
 11:35
```
for that is is it's it's n minus 1 times
```timestamp
 11:41
```
n divided by 2 okay so that which is kind of um n minus 1
```timestamp
 11:47
```
squared by divided by 2 so you know you're basically you are that that is an
```timestamp
 11:55
```

> [!NOTE]
> exponential problem okay so as the number of Syst applications in your
> ```timestamp
>  12:01
> ```
> application portfolio grows the number of interfaces grows exponentially that's
> ```timestamp
>  12:07
> ```
> why very quickly it becomes insurmountable so at you know at a

```timestamp
 12:14
```

> [!NOTE]
> hundred systems you have 5,000 interfaces at a thousand systems I

```timestamp
 12:22
```
believe it's slightly less than half a million interfaces okay that's a
```timestamp
 12:28
```
thousand systems that's maybe a midsize organization maybe maybe a smaller small
```timestamp
 12:34
```
mid-sized organization okay that's not many so it quickly becomes an insurmountable problem and you know even
```timestamp
 12:42
```
on five systems you can see this is this is a lot of complexity right I mean five
```timestamp
 12:48
```
systems is nothing I think I have five systems running on my PC at home you know to do my personal finance
```timestamp
 12:54
```

> [!NOTE]
> information so so the solution to this is a hub-and-spoke type of architecture
> ```timestamp
>  13:00
> ```
> if instead of having every system interface with every other system and
> ```timestamp
>  13:06
> ```
> you don't necessarily have to do that you simply define a hub to your interfaces and you say okay I will have
> ```timestamp
>  13:14
> ```
> every system interface just with the hub then when when I add an additional

```timestamp
 13:22
```
system to my organization I don't have to interface with the N existing systems
```timestamp
 13:28
```
in the organization I only have to interface with one system the hub so it
```timestamp
 13:33
```

> [!NOTE]
> makes the problem instead of the problem being exponential in terms of interfaces and makes it linear which is a
> ```timestamp
>  13:40
> ```
> significantly different type of complexity problem is everybody cool on

```timestamp
 13:45
```
this at this point right so but what I did was I added one new system and
```timestamp
 13:55
```
that's that one okay and that system has to have a definition of all the data in
```timestamp
 14:04
```
the organization now I'm not storing it all there it's not a data warehouse okay
```timestamp
 14:09
```
but every interface is going to go through that hub and so it need a
```timestamp
 14:16
```
definition of all the data that I'm going to want to share among the organization in that hub and that needs
```timestamp
 14:25
```
a canonical model okay and so you know
```timestamp
 14:30
```
in the data integration world in the ETL world that's what a canonical model is
```timestamp
 14:35
```
it's the definition of that hub and and then you know in terms of transforming
```timestamp
 14:41
```
your data right you only need to define the transformations of the data from
```timestamp
 14:47
```
your system from any system in the organization to the hub and from the hub
```timestamp
 14:52
```
to back to this to any system so this is a very complex data modelling problem
```timestamp
 15:00
```
okay yes yeah
```timestamp
 15:06
```
ah well therein lies the rub but go on yeah well so are you so the question was
```timestamp
 15:22
```
if you have the canonical model then then why not just do the interactions between the system's right okay so so
```timestamp
 15:30
```
there's an implication that you're going to change the systems to be equal to the canonical model okay so so the so why
```timestamp
 15:45
```
not so the response from the systems has to conform to the canonical models yes so but in effect that's what you just
```timestamp
 15:52
```
did was you you have the hub in the middle because because the the systems
```timestamp
 15:58
```
will will change to the format of the canonical model so so yeah it this
```timestamp
 16:05
```
doesn't necessarily have to actually be a system it's just a you know a model
```timestamp
 16:12
```
it's a format that you're going to have to change into and out of from from each
```timestamp
 16:18
```
system
```timestamp
 16:32
```
so we're physically the transformation might happen has to do with what your
```timestamp
 16:37
```
integration with your integration solution is and and so probably kind of
```timestamp
 16:45
```
happens in the ESB or the orchestration software or something like that but you
```timestamp
 16:51
```
know logically and entirely logically to me right it's the central hub that it's
```timestamp
 16:59
```
going through and physically that might not be true yes so so if I want to share
```timestamp
 17:30
```
a citizenship information between these different agencies do I have to share
```timestamp
 17:36
```
the whole definition of citizen between these different agencies I actually will
```timestamp
 17:42
```
address that in a minute and and that's a really good kind of real-life problem
```timestamp
 17:48
```
right because you want it you want to sort of define these messages to be a
```timestamp
 17:54
```
certain length balance a you know balance the length of the messages to
```timestamp
 18:00
```
reality but also you don't want to be passing information that's not needed to
```timestamp
 18:07
```
these different applications yes another question Oh
```timestamp
 18:13
```
oh my goodness do I have like something really special because so everybody likes swedish fish right
```timestamp
 18:20
```
you know okay what's the difference between the canonical data model and the
```timestamp
 18:27
```
enterprise data model so I hope nothing why
```timestamp
 18:33
```
that's you know that's what the enterprise data model really should be
```timestamp
 18:39
```
is this canonical model that can be used you know for this now now the thing is
```timestamp
 18:44
```
here okay this is this canonical data model it's it's not a you know the
```timestamp
 18:53
```
enterprise data model is more of a conceptual concept you're probably pardon the expression it's more of a
```timestamp
 18:58
```
conceptual concept and this canonical model is a physical concept okay we're
```timestamp
 19:04
```
talking about an implementation level model here alright so that if anything
```timestamp
 19:10
```
that should be the only difference I mean the problem that I have with you
```timestamp
 19:17
```
know enterprise data models is that sometimes they get into these levels of abstraction that aren't real you know
```timestamp
 19:25
```
but so it's like so what's a party you know I mean like I've never heard a
```timestamp
 19:30
```
business person who hasn't been taught modeling use the term well except they
```timestamp
 19:36
```
were if they were talking about events or something well you know that so so
```timestamp
 19:51
```
transactional MDM so it is the MDM hub the same thing as the canonical model
```timestamp
 19:57
```

> [!NOTE]
> right no the MDM hub isn't the same thing as the canonical model because the MDM hub
> ```timestamp
>  20:03
> ```
> is probably persistent data it's

```timestamp
 20:09
```
probably you know it's probably a big database of data or though it could be implemented as the logical concept in
```timestamp
 20:15
```

> [!NOTE]
> which case it is but the the canonical data model is is is data passing through
> ```timestamp
>  20:21
> ```

it so so there's nothing nothing ever stays there it just goes by okay it's
```timestamp
 20:28
```
like a translator right but but it's the thing that you have to turn insulated into it's the it's the the
```timestamp
 20:33
```
common the common language that everything has to be translated into although it's never it doesn't need to
```timestamp
 20:41
```
persist per se uh lots of questions oh my gosh
```timestamp
 20:50
```
right the canonical model is going to have to deal with anything that you want to pass between between systems so it's
```timestamp
 20:57
```
clearly not just a that you were you use that soon um so you know does the
```timestamp
 21:18
```
canonical model care about the payload well you know the payload issues may be
```timestamp
 21:26
```
performance issues and and things like that but but you don't want candy I
```timestamp
 21:40
```
she'll eat your candy for you okay the canonical model is a bit anyway I
```timestamp
 21:48
```
because I say you know the the canonical model to me it's it's it's not a logical
```timestamp
 21:54
```

> [!NOTE]
> concept it's not a conceptual model this is an implementation model so yes you do care about the payload I believe okay

```timestamp
 22:00
```
now yeah I'm an Operations person what can I say but but I I believe it does so
```timestamp
 22:07
```
there was a couple questions yes yeah
```timestamp
 22:13
```
single hub you end up you want to modularize it okay right right
```timestamp
 22:29
```
it's it cluster clustering of hubs well
```timestamp
 22:34
```
then the hubs have to talk to one another okay but um but you know I just I don't believe any way in ripping down
```timestamp
 22:42
```
what you have because it all has to be the same technology right so you know it's it's like you know build on success
```timestamp
 22:49
```
if you bought if you've got hubs that are working you know build on that right so don't you know don't start ripping
```timestamp
 22:56
```
down solutions just because they feel they ought to be the same technology
```timestamp
 23:06
```
there are definitely there are definitely and and so no I it doesn't
```timestamp
 23:12
```

> [!NOTE]
> have it doesn't have to be one single hub it can be it can be um you know
> ```timestamp
>  23:18
> ```
> regional hubs multiple hubs whatever you know whatever works okay but this is the

```timestamp
 23:23
```
concept and you know where we're actually sorry we've totally got off the topic here okay because the point was
```timestamp
 23:32
```
what's the canonical model alright and and and we've gotten into an area that I
```timestamp
 23:38
```
really like which is you know the whole data integration real-time data integration but but anyway the thing is
```timestamp
 23:44
```
that the canonical model is is this hub-and-spoke it you know allows this
```timestamp
 23:52
```
hub-and-spoke a solution to happen and if you so if you don't have a canonical model this
```timestamp
 24:00
```
becomes a lot less efficient okay and
```timestamp
 24:06
```
and and let me tell you you know if you have there's a big difference between
```timestamp
 24:13
```
something on them you know yeah thousand systems and there's a big difference between managing something on along the
```timestamp
 24:20
```
order of magnitude of a thousand interfaces from something on the order
```timestamp
 24:25
```
of magnitude of half a million interfaces okay so and
```timestamp
 24:30
```
and you it doesn't have to be an all-or-nothing thing you can you can you can you know solve this problem in one
```timestamp
 24:38
```
part and and there's other things that are that are meant to partially solve this problem data warehouses partially
```timestamp
 24:45
```
solve this problem of of the number of interfaces right because it's like alright all these different systems want
```timestamp
 24:51
```
to or people want to use this data so we'll just like put all this data into this hub and then they can use it MDM
```timestamp
 24:58
```
partially helps to solve the problem all these different people want to use this data instead of all systems having to
```timestamp
 25:05
```
pass data to all systems they all come and get it in a certain central place so
```timestamp
 25:10
```

> [!NOTE]
> so it's not an all-or-nothing thing but this really brings down the levels of
> ```timestamp
>  25:16
> ```
> complexity tremendously in terms of this problem and that's what the canonical model is getting actually the point so

```timestamp
 25:24
```
so you have this one additional hub I'm sorry was there anything else that okay
```timestamp
 25:41
```
I'm not going to like solve anybody's problems I am you know that the point of
```timestamp
 25:51
```
this all I have time to get into here right is you know what is the canonical
```timestamp
 25:56
```
model and why do we use it okay so I'm not going to not going to get it you
```timestamp
 26:02
```
know and I'm going to try to not get all involved in data integration issues too
```timestamp
 26:19
```
so so alright so the question is if you
```timestamp
 26:25
```
know if you're never going to persist the data in the hub do you ever actually store those messages and where do you do
```timestamp
 26:33
```
that well there's Hadoop I mean that's a
```timestamp
 26:38
```
big data problem okay because that's a lot of data and I actually worked at
```timestamp
 26:44
```
Citibank at a point where they said they were going to store all of that okay that's just a huge problem
```timestamp
 26:51
```
so that's a big data problem it certainly is actually solvable you can
```timestamp
 26:56
```
store all those messages if you want to and and and you know any in practice right there's probably persisting
```timestamp
 27:03
```
somewhere on the ESB and log and stuff like that but yes
```timestamp
 27:39
```
so the question is does the canonical model require some sort of key to the
```timestamp
 27:45
```
messages that are coming in and out of this and in order to find your way so
```timestamp
 27:50
```
well you know what finds your way is you know this is actually implemented
```timestamp
 27:56
```
usually in an enterprise service bus that handles the orchestration of the
```timestamp
 28:01
```
requests and the subscriptions and the responses to the to the different
```timestamp
 28:07
```
systems so Eaton yes you know the the messages have all kinds of you know
```timestamp
 28:13
```
interesting things in their headers and stuff that that keeps track of that but
```timestamp
 28:19
```
the what I was showing whoopsie what I was actually showing here right is that
```timestamp
 28:25
```
I'm a big believer that if possible you should be you should be having applications talk to applications not
```timestamp
 28:32
```
directly to the underlying data stores okay so it's kind of the difference between enterprise application
```timestamp
 28:39
```
integration and enterprise information integration okay and I think that if
```timestamp
 28:45
```

> [!NOTE]
> possible enterprise application integration as the way should go as opposed to directly talking to those data stores but um but that's that's

```timestamp
 29:00
```
okay what the hub you know what the hub looks like is it looks like your enterprise data model looks like your
```timestamp
 29:06
```
your XML message definitions it looks like your object data services so it
```timestamp
 29:16
```
looks it's an implementation well looks like your relational database you know design okay but it it it it's a it's in
```timestamp
 29:28
```

> [!NOTE]
> it's a design principle not an implementation right so you use whatever
> ```timestamp
>  29:33
> ```
> tools that you're using just to solve the the integration problem and that's

```timestamp
 29:39
```
where you design okay well well it
```timestamp
 29:50
```
depends you know what your you know how you're implementing your your your
```timestamp
 29:55
```
happen so how do you turn your enterprise data model into something useful well depend you know you have to
```timestamp
 30:02
```
have a date well you have to have a data
```timestamp
 30:10
```
you know you have to have a data integration strategy and and and then you know a data integration
```timestamp
 30:16
```
implementation and it's going to be defined in whatever you defined your data integration implementation it like
```timestamp
 30:24
```
XML for example I know at one point I used to say yes do you like Swedish Fish I used to I used to say yes do you like
```timestamp
 30:31
```
Swedish Fish and and at one point I you know I used to say well of course this
```timestamp
 30:37
```
is going to be an XML but then in you know I've found well it's actually not
```timestamp
 30:43
```
always an XML in fact I've seen more cases where it's not an XML so I don't say that anymore
```timestamp
 30:50
```
well I'll I'll give you a couple in a second so that's good
```timestamp
 30:57
```
we've actually implemented this well hopefully a lot of people have right I
```timestamp
 31:03
```
mean yeah yeah services that go to our I
```timestamp
 31:45
```
way EA I integration of and then from application well that has to be kind of
```timestamp
 31:58
```

> [!NOTE]
> the de facto standard I mean it that you know so you've defined the canonical model the hub in in Irwin and then and
> ```timestamp
>  32:08
> ```
> then you the output from that is an XML model and then you you translate that
> ```timestamp
>  32:13
> ```
> into web services and that's it that's exactly you know the defect you

```timestamp
 32:18
```
know this that's probably what it looks like right for anybody but there's other ways that it can look like yes
```timestamp
 32:48
```
well I'd like to hear what he has to say but that's okay we could talk about this for a long time right I mean this is
```timestamp
 32:55
```
good okay so Oh David what time do you start drinking
```timestamp
 33:05
```
what does that do I have until 4:00 ten is that when this is supposed to be everything all right so this is a this
```timestamp
 33:13
```
is just this is a little bit kind of object D okay you know so you have types
```timestamp
 33:23
```
you know you have types of contact information so you have it you know you have an inheritance concept of of types
```timestamp
 33:31
```
and then you know within the types you
```timestamp
 33:36
```
you have components or breaking down the you know an email address into its
```timestamp
 33:42
```
component parts so so you know and this is this is just kind of a type of
```timestamp
 33:49
```
approach to let's say to to to modeling that you that you might do right you can
```timestamp
 33:56
```
do it relational this kind of a you know an object type of breakdown of in terms
```timestamp
 34:01
```
of defining your stuff so and you know if you if you're implementing this so
```timestamp
 34:08
```
you could you could do this in a relational modeling tool or in a UML
```timestamp
 34:15
```
modeling tool or an XML modeling tool I
```timestamp
 34:21
```
you know it's it sort of doesn't doesn't matter I think that you should use the
```timestamp
 34:27
```
modeling tool that's relevant to your implementation because that's most most
```timestamp
 34:32
```
useful okay that's my opinion
```timestamp
 34:37
```
so so what hat so recently what's actually kind of come up for me
```timestamp
 34:43
```

> [!NOTE]
> was the fact that actually defining a canonical model is really important for
> ```timestamp
>  34:49
> ```
> object development and web services especially for so defining data services

```timestamp
 34:56
```

> [!NOTE]
> reusable data services is a very big important step in terms of trying to get
> ```timestamp
>  35:03
> ```
> reuse out of your object models right out of your out of your object out of

```timestamp
 35:09
```
your your services and isn't that that's like the holy grail of Viso a is is
```timestamp
 35:16
```
reused right but if you not if you don't have reusable data services you're just
```timestamp
 35:22
```
going to really be a mess because well for all kinds of reasons anybody need me to go through what those reasons would
```timestamp
 35:29
```
be so anyway so I came across this interesting article I actually had this
```timestamp
 35:36
```
experience where this is true where it was like you know if we weren't defining
```timestamp
 35:41
```
data services in a canonical way we were just it was just turning into into a
```timestamp
 35:47
```

> [!NOTE]
> real mess and the client actually asked us to explain to the the programmers why
> ```timestamp
>  35:54
> ```
> they needed to approach this in more of a reuse you know using a canonical model

```timestamp
 36:00
```
common definitions for the for the data structures way and and I found this
```timestamp
 36:06
```
article from Forrester Research that said that that it seems like in in peope
```timestamp
 36:13
```

> [!NOTE]
> you know conferences about canonical modeling it seems like more of the users
> ```timestamp
>  36:20
> ```
> of canonical modeling now are using it for for this for you know reusable
> ```timestamp
>  36:25
> ```
> object development and and services than they are for the whole data integration

```timestamp
 36:31
```
hub-and-spoke type of solution so this is actually a really big area of use for
```timestamp
 36:37
```

> [!NOTE]
> canonical modeling it's you know achieving that reuse out of your objects out of your data services that that
> ```timestamp
>  36:43
> ```
> that's that's always promised in that area okay

```timestamp
 36:52
```

> [!NOTE]
> so just a couple little pieces of advice all right yeah you know using industry standards
> ```timestamp
>  36:59
> ```

always a good idea but industry standards tend to be about passing
```timestamp
 37:07
```
information between organizations as opposed to passing information within
```timestamp
 37:13
```
your organization okay and the way that that canonical model is going to look is
```timestamp
 37:18
```
a little bit different because of that not like a huge amount I was trying today to think of an example of this okay many years the
```timestamp
 37:27
```
financial services industry and we use a swift messaging for passing messages
```timestamp
 37:33
```
between banks okay but then I was thinking you know in securities
```timestamp
 37:40
```
processing you have balances people's like balances or that you know either
```timestamp
 37:46
```
their securities balance or that let's say they're checking bounce or savings event you have the balance and you and
```timestamp
 37:51
```
you have the transactions right and it really aren't Swift messages for the
```timestamp
 37:58
```
balances but we frequently have to pass balance information between systems
```timestamp
 38:04
```
right in order to check what someone's balances and then update their balance
```timestamp
 38:09
```
and and there's you know reports or statements and Swift messages but not
```timestamp
 38:15
```
really passing people's balances I can't think of one anyway so so that's the
```timestamp
 38:21
```

> [!NOTE]
> thing so so industry standards good place to start but but you probably need
> ```timestamp
>  38:27
> ```
> to build on top of that in terms of getting your whole organizational model

```timestamp
 38:32
```
and the enterprise data model that's what you know it should be your canonical model should be your
```timestamp
 38:38
```

> [!NOTE]
> enterprise data model instantiated top-down modeling yes
> ```timestamp
>  38:44
> ```
> you know I absolutely domain design you know coming down starting with master
> ```timestamp
>  38:51
> ```
> data always a good place to start but
> 

> [!NOTE]
> but entry but if you try to do it one
> 
> ```timestamp
>  39:00
> ```
> layer at a time I just don't really believe that you're going to end up with something useful so

```timestamp
 39:05
```
I kind of believe in tops down bottoms up modeling so actually you know you
```timestamp
 39:10
```
have a problem you need to solve you have an interface you need to build like we'll build the interface and then and
```timestamp
 39:17
```
then you know and then add to your your top-down model and then build the next interface add to your top-down model so
```timestamp
 39:24
```
solve real problems and and build real interfaces or or real objects not don't
```timestamp
 39:32
```
try to do it you know one layer of the entire organization at it that takes a year and then the next layer of the you
```timestamp
 39:39
```
know and then and then you'll retire and you know and it'll just be shelf where
```timestamp
 39:47
```
what did I have to say that metamodeling I have no idea um so like I'm saying so
```timestamp
 39:54
```
you know you're trying to prac practical use with with it with a overall design
```timestamp
 40:01
```

> [!NOTE]
> okay so I you know at one place where you know and it's like they built the
> ```timestamp
>  40:09
> ```
> logical model and then they stopped that's like well it doesn't on its own really have a whole lot of value you

```timestamp
 40:17
```
actually have to use it for something even if it's just to have conversations I suppose but but in this sense you know
```timestamp
 40:25
```
Kanaan this canonical modeling for for you know object reuse and for and for hub-and-spoke architecture these are
```timestamp
 40:32
```
things that are that you really need to be implemented um
```timestamp
 40:37
```
and the you know and just there's a lot of governance around this okay as in
```timestamp
 40:45
```
with everything just you know this is the sort of fine print on the you know there's a lot of governance this doesn't
```timestamp
 40:51
```
happen by itself you need to do design patterns and and and standards and then
```timestamp
 40:57
```
you know after the fact or registry of reusable objects or whatever you're building you know to to actually be able
```timestamp
 41:06
```
to get this done in training and and communications and all those things
```timestamp
 41:11
```

> [!NOTE]
> so just you know have to say that it's hard how do you reward reuse right I

```timestamp
 41:19
```

> [!NOTE]
> don't know how do you discover it discourage single-use I mean there's

```timestamp
 41:24
```

> [!NOTE]
> ways but there you know I it's very hard reuse is hard anybody well maybe

```timestamp
 41:33
```
somebody somebody will talk about reuse sometimes how they were successful it make it at making reuse happen yeah
```timestamp
 41:43
```
and just kind of a little kind of a little side note I think this is
```timestamp
 41:49
```
practically my last slide so then you then we can have we have five minutes of questions it you know which is you know
```timestamp
 41:58
```

> [!NOTE]
> how is canonical modeling like relational modeling a canonical model
> ```timestamp
>  42:04
> ```
> modeling is a little bit more hierarchical you know I believe I mean
> ```timestamp
>  42:11
> ```
> XML is a little bit more higher goal to me than then relational modeling and yet

```timestamp
 42:17
```
when I look at the we at the real implementations somehow in somehow the
```timestamp
 42:24
```
canonical modeling is more is maybe more relational because like what I always
```timestamp
 42:31
```
set C for you know for mailing addresses right is that you get you know you have
```timestamp
 42:37
```
address line one address linked to out of sign late three unless instead of you know a relationship to zero
```timestamp
 42:45
```
well one two too many address lines it's always implemented with something like
```timestamp
 42:51
```
this and you know in in in XML you don't have to do it that way you know the you
```timestamp
 42:58
```
can you can just give as many address lines as as there really is so so is
```timestamp
 43:04
```

> [!NOTE]
> does that mean that that you know the XML model is actually more relational than the denormalized relational model

```timestamp
 43:11
```
you know it's it seems like yes sorry George
```timestamp
 43:21
```
okay whatever it why it makes sense
```timestamp
 43:35
```
right now um that's that's true there's
```timestamp
 43:45
```
an interaction yes okay
```timestamp
 44:04
```
you have to get rid of that so maybe
```timestamp
 44:25
```
canonical modeling right some canonical
```timestamp
 44:31
```
modeling was really more relational than relational modeling at some point sorry
```timestamp
 44:38
```
okay yes okay
```timestamp
 44:54
```
yeah we all have parties so all right so
```timestamp
 45:05
```
so so levels of abstraction and industry model right and so what do you do with that it so it was that what you're
```timestamp
 45:12
```
saying or okay so I'll out answer that
```timestamp
 45:23
```
one because it's an easy answer how do you how do you implement party so which do you want okay chocolate okay so the
```timestamp
 45:35
```
the so well how do you implement party in a relational database is the answer
```timestamp
 45:40
```
okay there right it's it's it's the way it's the same answer all right so it's
```timestamp
 45:46
```
like you can either implement each type of party as a separate table or you can
```timestamp
 45:52
```
implement a party in general or you know and in object modeling you would you
```timestamp
 45:57
```
know you'd have inheritance so you'd have a party table and then and then you'd have inheritance for the thing you
```timestamp
 46:03
```
know for people and organizations would would have you know inheritance of the common stuff and then the things that
```timestamp
 46:09
```
are specific to a people into an organization so so it's an easy that's
```timestamp
 46:14
```
an easy answer but because the answer is the same it's like at some point you have to implement that level of
```timestamp
 46:20
```
abstraction right and it's the same answer well how do you implement that level of abstractions so am i
```timestamp
 46:30
```
contextualizing it as i'm implementing it well choices have to be made for implementation so it's this it's the
```timestamp
 46:37
```
same choices that you make for implementing it in a relational database I mean different tools allow you to do
```timestamp
 46:44
```
different things or different technologies so here's this this
```timestamp
 46:50
```
question here's this thing about the sizes of these so you current what I'm
```timestamp
 46:59
```
working on right client has a like five thousand attributes okay
```timestamp
 47:05
```

> [!NOTE]
> so I'm not going to ask to anybody who wants client information 5,000 attributes but you but

```timestamp
 47:12
```

> [!NOTE]
> you you do what they're calling topics within the client which would be the the

```timestamp
 47:20
```
the attributes or the fields that are relevant to a particular kind of thing
```timestamp
 47:25
```
that you would need to be that would need to be done okay or they that probably you know a certain kind of
```timestamp
 47:33
```
application would probably be interested in these attributes about the client and
```timestamp
 47:39
```

> [!NOTE]
> not these other attributes about the client so you kind of break it down into sort of subgroups of topics I'm sure

```timestamp
 47:47
```
there's a better definition to that than topic yes so the cannot where is the
```timestamp
 48:05
```

> [!NOTE]
> mapping kept all right canonical model does not necessarily have a mapping to a relational database that depends on what

```timestamp
 48:12
```
the systems are that you're talking to so if if you know if you have to talk to
```timestamp
 48:18
```
if one of the applications that you're connecting is it has relational
```timestamp
 48:24
```

> [!NOTE]
> databases potentially your mapping to those relational databases but what's preferable is that you're talking to the
> ```timestamp
>  48:31
> ```
> API of the application not to the relational database so it depends on

```timestamp
 48:37
```
what you have available in terms the application you're talking to and you
```timestamp
 48:44
```
know this isn't probably at some point you're you know you are talking to a relational database because it doesn't
```timestamp
 48:50
```
have an API but um but the where is the
```timestamp
 48:57
```

> [!NOTE]
> mapping well you know that's in the you know the orchestration enterprise
> ```timestamp
>  49:02
> ```
> service bus orchestration software and there's a reg repository and that's

```timestamp
 49:08
```
where the mapping is and for doing that yeah yes
```timestamp
 49:18
```
the good one or the bad one there their
```timestamp
 49:26
```
semantics in each one of them and the semantics aren't always going to be the
```timestamp
 49:31
```
same so I'm presuming that the semantics in your in your canonical model is going to be a superset yes basically the
```timestamp
 49:45
```
semantics in the canonical model assuming it's the superset of the well
```timestamp
 50:25
```

> [!NOTE]
> yeah right I mean the the the the users
> ```timestamp
>  50:32
> ```
> of the canonical model are the applications you're trying to integrate so if if one application needs some
> ```timestamp
>  50:39
> ```
> information but the canonical model doesn't have that information then you have to change the canonical model to

```timestamp
 50:46
```
support that need and identify where you are going to be able to get that
```timestamp
 50:51
```
information from yes sorry yes
```timestamp
 51:03
```
philosophy information needed by one
```timestamp
 51:21
```
what we did it's more like rather than a two percent I would call it almost common denominator approach you have to
```timestamp
 51:29
```
design the canonical message okay let me
```timestamp
 51:38
```
interrupt you because I don't agree okay no least common denominator isn't going to solve this problem
```timestamp
 51:43
```
it's a superset not a subset not a not a common subset because because that you
```timestamp
 51:50
```
need to solve the problem of all the system that the full problem of the integration not just what's what's what
```timestamp
 51:56
```
they what comes together okay a
```timestamp
 52:09
```
different way well if this claim system is only using
```timestamp
 52:17
```
this one piece of information then we might create a smaller message yes and
```timestamp
 52:26
```
say yeah you might you you might you might create messages that are only used
```timestamp
 52:34
```
by one application okay I should certainly could certainly see that that's the case however you know if only
```timestamp
 52:41
```

> [!NOTE]
> one application needs information that it doesn't have to be shared with anybody else then you don't have to put
> ```timestamp
>  52:47
> ```
> it in the canonical model so but if you if you need to pass information between

```timestamp
 52:55
```
systems it has to be the full set of requirements for that integration okay
```timestamp
 53:03
```
so um kind of a nebulous topic but I really enjoyed the questions and thank
```timestamp
 53:10
```
you very much and this is my contact information if if anybody's interested in