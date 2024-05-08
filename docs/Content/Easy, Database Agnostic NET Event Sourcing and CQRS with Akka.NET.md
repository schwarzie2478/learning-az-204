---
status: tree
dg-publish: true
tags:
  - content/video/youtube
creation_date: 2024-05-08 10:00
definition: Easy, Database Agnostic NET Event Sourcing and CQRS with Akka.NET
ms-learn-url: undefined
url: https://www.youtube.com/watch?v=ysXBz2s5W00
author: Petabridge
---


| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Author   | `VIEW[{author}][text(renderMarkdown)]`          |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |

- [x] Review Easy, Database Agnostic NET Event Sourcing and CQRS with Akka.NET ✅ 2024-05-08

## Video
`$= "Made by [[" + dv.current().author+"]]"`
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


Intro

0:00

hey sorry about that a little bit of technical difficulties with go to webinar there um hello everyone my name

0:06

is [[Aaron Stannard]] I'm the founder and CEO of [[Petabridge]] and today we're going to go ahead and talk a bit about one of the

0:13

features of [[Akka.NET]] .net that I think is really powerful and useful which is our database agnostic event sourcing that

0:20

you can get through oaop persistance so the first thing we're going to talk a bit about today is we're

0:26

going to cover [[Akka.Persistence]] real quickly this is our [[event sourcing]] system that's built into

0:31

a.net um so you know many of you who are joining are probably already using it to one degree or another so we're not going

0:38

to spend an enormous amount of time talking about it what we are going to talk about though in the context of

0:44

aadat persistence is how can you prepare yourself to actually leverage it for [[command query responsibility segregation|cqrs]] being able to do [[command query responsibility segregation]] so what this means in layman's terms is being able to

0:55

take the Event Source that aadap resistance runs on top of and projecting it into read friendly models so you're

1:02

going to see a little example of that today where we're going to take aadat resistance data and then project it into

1:09

uh [[Entity framework]] tables behind the scenes uh next is [[Akka.Persistence.Query]]

1:16

uh this is our technology we're going to use to asynchronously create projections behind the scenes using all the

1:22

previously Event Source data um we're going to talk a bit about what the different query types are and how we

1:28

handle things like material materialized views and error handling that's all going to get covered and then we'll talk

1:33

very briefly about serialization and how to deal with [[versioning events]] and State uh and also how to version your views

1:40

while we're at it as well that's like a concern you need to honestly like if you're trying to figure out how to

1:45

handle versioning down the road like after you've already g into production block at. persistance uh we can still

1:51

adapt to that and still support it but it's a lot simpler if you have a plan ahead of time we're not going to go into

1:57

a giant amount of uh data on that because we have an entire hourlong YouTube video that covers it but we will

2:03

touch on it very briefly and talk about things like [[rematerializing]] okay uh the first thing

Event-Sourcing with Akka.Persistence

2:09

that we'll get into here is event sourcing the whole idea behind Event

2:15

> [!NOTE]
> Event sourcing is basically kind of think of it like being able to compute the total balance of a bank account from the sum of all the debits and credits in The Ledger

the implications of this for

2:26

being able to apply that same model to let's say any business object inside your system is that 

> [!NOTE]
> all state is inherently [[self-auditing]] 

I did some work with a customer in a medical device sort of space a few weeks ago and one of

2:41

their big problems they have to deal with is sarbanes Oxley and other types of like sock 2 compliance that sort of

2:47

thing auditing is a huge component of that having an event Source kind of makes it so things can inherently be

2:53

auditable out of the get-go compared to crud event sourcing is like a Quantum Leap improvement from an audit

2:59

standpoint point the other thing that's kind of important about the auditing facet of event sourcing is that

> [!NOTE]
> in addition to telling you what change it can also explain why things changed 

a

3:11

you audit change log in a tool like SQL Server can't give you the why it can only give you the the what and the when

3:18

basically the other things that are sort of significant about event sourcing is 

> [!NOTE]
> that state can be reverted and restored to a specific point in time

so if you think about let's say an object state

3:29

let's say the object could be an order could be the status of a device if you're doing digital twins it could be a

3:36

you know a transaction that's being executed through an olp system um the

3:42

gist of this is that 

> [!NOTE]
> the current state that objects in any given time is the sum of its events 

it's a it's a product

3:49

basically a DOT product of all the different events uh that belong to that individual entity that means the way

3:55

that state is represented can be set back in time if you need to you can go ahead and pop Events off of your event

4:01

source and revert that object back to a prior State this is really useful for doing things like if you work in finance

4:08

being able to back test a trading algorithm or if you're working on more complex systems being able to do

4:14

[[regression testing]] or simulations uh that's a really useful facet of event sourcing in its own right finally the

4:21

thing I find most useful about it is event sourcing is an [[inherently reversible architectural design]] uh we

4:28

have a video on online couple of videos online in a blog post about high optionality architectures reversibility

4:35

is a big component of that that means that the way 

> [!NOTE]
> your state is represented like in your application that is a derivative of your Event Source at any given time

so if you don't like the way that State's represented you can destroy

4:49

it and then reproject your events into something else um the next thing I want to mention

4:54

here is the way you know kind of [[dovetailing]] with my last point 

> [!NOTE]
> the current State you're looking at is decoupled from the data itself like the the way you represent data inside your actor or the way you represent data

5:07

inside your read model these are all derivative views of the underlying event store that means that they can be

5:12

destroyed and recomputed when your requirements change so event sourcing lends itself very well to reversible

5:19

decisions which is great from a technical debt and from a speed perspective speed meaning how quickly

5:25

your team can iterate on designs there's a little bit more upfront engineering overhead to event sourcing initially

5:32

unless you're using a tool like oaop persistance we're going to talk about but 

> [!NOTE]
> you get a lot of flexibility downstream as your domain inevitably evolves over time

and then the last

5:42

thing we're going to talk about here is [[cqrs projections]] the ability to take our event store and reproject them into new

5:50

forms aad do persistence has been a part of aad doet for 10 years and it is a

5:56

[[database agnostic persistence]] plus recovery mechanism for action fa s it's

6:01

> [!NOTE]
> designed to avoid lots of different potential problems that can happen in highly concurrent database intensive applications 

a good example here is that oad up resistance inherently rate limits the number of actors that that can

6:13

recover their Journal at any given time the idea here is that look if you have a thousand actors all trying to recover at

6:19

once that's going to go ahead and put a lot of contention pressure on the event Journal uh so we only limit by default

6:26

50 to recover at any given time and that's actually going to improve the throughput of the application when we do

6:32

that by constraining the degree of parallelism there uh there's lots of other little things we do too to kind of

6:37

help improve uh throughput and performance from a database perspective we bound the number of open database

6:43

connections that can be used at any given time there's lots of multiplexing that can happen inside aaop persistence

6:48

2 to help reduce the number of round trips and that sort of thing it's a very well-built battl tested piece of

6:54

technology by this point we use aaet serialization system to represent all of the events going

7:01

into your event source for each of your entities as binary payloads uh we do this because we already have to use oad

7:07

onit serialization for things like oaop remote so we just dovetail that into idop resistance as well this eliminates

7:15

a really painful category of problem that a lot of handrolled Event Source systems have which is dealing with how

7:21

you version event schema which means having to do let's say [[sparse tables]] and

7:27

oop you know not oop assistance and doing in [[SQL server]] or another uh other types of databases as well the way we

7:34

handle this is we say look your database schemas basically never get a change it's just going to be key Value Plus

7:40

some timestamp data to help do ordering and then it's going to be [[binary payloads]] with serializer metadata all

7:47

the versioning of events and state is all things you can control through C at that point it's not a responsibility of

7:53

the dbms to do it anymore and the trade-off there is that you actually get 

> [!NOTE]
> a high degree of flexibility as a programmer uh for dealing with things like versioning State

uh being able to go ahead and decide how you might want

8:04

to change properties on events in the future uh but the downside of it is that your data is not going to be human

8:09

readable inside your event store um and by the way that human readability component is what makes it so expensive

8:16

to build an Event Source by hand in most systems if you're trying to use let's say a native table schema to represent

8:23

every possible event in your system is going to be problematic what most people do if they handroll a Event Source is

8:29

> [!NOTE]
> used something like Json anyway so we're basically just doing that but doing compressed binary
> 

8:36

instead finally aadap resistance also supports aadap resistance query for doing projections this can also work on

8:43

pretty much any arbitrary database that we support the way the aadat resistance runs and I promise we'll see some code

How it Works

8:49

in just a moment here the way aadat resistance runs is 

> [!NOTE]
> we have a persistent actor that's going to process messages and these messages are going to produce events these events represent State changes for this entity

so if I

9:00

have a chat room history actor in this case each one of these messages might represent someone writing to the chat

9:06

room I am going to persist these events into SQL server in this case in the

9:12

original order that those events occurred when someone wants to communicate with this room message

9:18

history actor we are not talking to the database during read operations this

9:23

actor State exists in memory but it is also mirrored in a persistent durable

9:30

[[Event Journal]] that's in this case represented using SQL Server the implication here is that we

9:36

still get fast in memory message processing with aadat persistence but we also get [[durability]] and [[re-entrancy]] when

9:43

this actor restarts maybe it restarts because we killed the process and rebooted it maybe it thre an exception

9:50

and got rebooted by oad on its supervision system whatever the case may be when this actor starts up it's going

9:56

to send its persistence ID to the aadat persistance uh Journal actor and that

10:02

actor is going to figure out what are all the different events that this actor needs to replay in order to get caught

10:09

up with its most recent State and the actor will go ahead and replay all those events and rebuild its inmemory state

10:16

which it will begin using to process inmemory messages sent by other actors at that point so that's kind of a brief

10:23

recap an oad out persistence here let's take a little bit of a gander the source

Event & State Schema

10:28

code the the first thing we want to take a look at is in a.net persistent 

> [!NOTE] Title
> Contents
actors all need to have a globally unique persistence ID 
no two actors talking to

10:39

the same database can have or should have the same persistence ID the journal

10:45

and aodot persistence can usually detect when there's like two different copies of the same actor the same persistance

10:51

ID talking to the same journal and it'll throw a corruption exception when that happens it can basically tell that

10:56

you're corrupting your right layer when you do it um if you're planning on using aaet and let's say a big distributed

11:03

system and you want to help guarantee that all the entity IDs are unique aaot cluster Shing is the right tool for

11:08

doing that it will structurally guarantee that only one instance of this entity can exist anywhere in the cluster

11:15

any given time even when there's Network partitions so we just released a video on that on our YouTube channel this week

11:21

strongly recommend that you look at it if you want to know how that works but for the time being this is just an important constraint you need to know

11:26

about with oa. persistence this persistence ID is sacred there can only be one of them in the entire system

11:34

that's and only sorry only one instance of this persistance ID running at any given

11:39

time the next thing to learn about aadat persistance is we always try to recover a snapshot of our actor State first

11:47

[[snapshots]] are kind of an optional feature of aadat persistance you don't have to use it and snapshots don't get used in projections so if for when we're

11:55

dealing with cqrs it's only the content the event Journal that we care about but if you have let's say persistent actors

12:01

> [!NOTE]
> that have been alive for a long time and have processed many events you don't want that actor replaying you know hundreds of thousands or millions of events each time it starts up that might take hours to process 

depending on how

12:14

many of them there are so what we try to do in order to accelerate oad up resistance actor recovery is that we

12:21

have the actor periodically take point in time representations of its state otherwise known as a snapshot so the way

12:28

oet up resistance works when recovering is we always recover the most recent snapshot and then we recover any of the

12:35

events that were recorded after that snapshot was taken these recover methods

12:40

inside this persistent actor right here we have to finish fully recovering the actor State before we're allowed to

12:47

process messages from any other actors if the actor can't finish recovering its state for some reason let's say the

12:52

database goes down in the middle of it this actor will kill itself and you'll need to recreate it again that's because

12:59

acop resistance prioritizes [[data consistency over availability]] so that's the trade-off we made and you know the

13:06

idea of a partial recovery is antithetical to the way oaop resistance Works we're going to kill ourselves if

13:12

we can't recover you should recreate the actor and then try again and you know we have we have things like the backoff

13:19

supervisor actor that can help automate some of that inside aaet once recover is complete the actor

13:25

begins working like normal so that was kind of the read side of aadap persistance let's take a look at the

13:31

right side of how we actually save events that we're going to recover and also Replay for the purpose of creating

13:37

projections this is kind of following if you attended my webinar that we did I think last September on pattern oriented

13:44

design with actors this is following that process here where I receive a command I basically have a little

13:50

extension method that does all the processing on it and that response I get back from this process Command right

13:55

here might include between zero to n response events if I have more if I have

14:01

more than let's say zero response events I'm going to call persist all right here

14:07

this will cause me to persist all of the events that are in this you know I inumerable right here this will cause me

14:14

to replay all of them in order to B will cause me to basically persist all of

14:21

them in a single database transaction is what's going to happen so they're all going to be saved automically as one

14:26

unit once that operation succeeds we're going to invoke this little function for

14:32

every single event individually that we just saved there now one thing that's really important to note by default is

14:39

this line right here the actor won't process any messages until this persist all operation completes this actor

14:45

internally is going to use stashing and behavior switching uh kind of behind the scenes that basically make sure this

14:51

actor can't process any messages until we know if this persist operation completes you can disable that if you

14:57

want to improve throughput and the way you disable It Is by calling persist or persist all a sync at the end of it

15:03

that'll cause the persist operation to basically complete in the background and if you're okay kind of relaxing your

15:09

consistency requirements in the name of reducing latency uh that will that that's how you can go and get around

15:16

doing that but by default I'm just using persist all here so this call back function will get invoked per event now

15:23

the last thing I kind of wanted to point out here is saving snapshots uh what's sort of the right form for doing that

15:30

potentially um one of the things that I'm doing here is this last sequence number property this is basically

15:36

keeping track of the version of this actor State the sequence number increments monotonically meaning that it

15:42

it can only increment it can never go down uh it always increments every time I persist an event so each event is

15:48

basically identified in our aadat persistance Journal using a tuple on the one hand we have the persistence ID on

15:56

the other hand we have the sequence number starting from zero so what I'm doing here is using a little bit of modulus to say every 10 events

16:04

save a snapshot and so when that snapshot successfully gets saved that's going to go ahead and create a new point

16:09

and time representation of our state and we'll use that for recovering this actor the next time it starts that way I can

16:16

kind of constrain how many events does this actor replay any given time when I

16:21

need to recreate it I can limit it to let's say in this case one snapshot plus up to 10 events so I'm never going to be

16:28

recovering let's say thousands of events you know that in one shot here it's

16:33

going to be a snapshot plus whatever this value is that's a fairly healthy pattern for working with snapshots

16:39

inside oad op resistance now the way we configured oad op resistance I'm using aodot hosting

16:45

here which I strongly recommend you use we're using the brand new aodot resistance. SQL plugin that we shipped

16:51

last summer uh we're passing in a connection string so that's normal we're getting that out of app settings uh

16:58

we're BAS specifying that we're using SQL Server 2019 here uh this is using some of the

17:03

link DB settings we're using the tag table that's a more efficient way of querying events on secondary IND indices

17:11

we'll see an example of that in a moment then I'm also adding this thing called a right event adapter here uh we will get

17:17

into some detail on what that does in a moment now messages as effect systems

17:23

this is from my uh presentation on pattern oriented design we did last September but I always organize my sort

17:30

of message taxonomy into three components commands which are inputs into a system and when a command is

17:37

successfully processed that can produce between zero and end events or zero and end effects the events are the effects

17:45

themselves they're historical facts of the systems events really happened so they can't be validated you can't

17:51

validate something that's already occurred uh they can't be validated they just need to be processed and

17:56

incorporated into our state and then finally we have queries which is basically the ability to fetch or

18:02

subscribe to changes in state without actually impacting it directly withad out persistence we are solely concerned

18:10

with persisting events and then if we're taking snapshots persisting our state we

18:15

typically do not persist commands nor do we persist queries that's kind of not really useful unless you need it for

18:23

auditing purposes that would be the only exception where I might consider doing this so event Design This is the section

18:30

of the presentation where we're kind of thinking about how do we get ourselves ready to use aadat persistence

18:36

effectively for cqrs this is also from my sort of you know my presentation I've been

18:42

referencing a bit I really like using these entity specific interfaces where I have a unique key per entity here and in

18:50

this case I'm using a string this could also be a value object if you want to do that it kind of depends on what floats

18:56

your boat but that's not kind of besides the point what's really important is that every event that we're persisting

19:03

has the globally unique identifier for it it's primary key value is built directly into the event I don't need to

19:10

look up some synthetic table in order to do it this will make doing projections a

19:15

million times easier and it's also good for a bunch of other aodot specific reasons such as you actually need this

19:21

in order to work with aodot cluster sharding for instance so this is a really good practice to get into I also

19:27

will use a separate interface to kind of separate events from commands or queries for the same entity type and then

19:34

finally I have a concrete type here as well one thing I mentioned is that order

19:39

dependent events are fine inside oad persistence uh meaning that if I have to

19:44

have a entity receive a create event first before it's considered to be valid

19:49

and then afterwards that entity might receive other events that represent other incremental State changes it's

19:55

fine to have those ordering requirements aad up persistance query by default Works sequentially so you're not really

20:02

doing anything unusual there that's kind of more of a problem that emerges in crud based systems where you don't have

20:09

control over the order in which things are done for specific entities very well

20:14

aa. Net's mailbox system kind of forces you to do everything serially on a per

20:19

entity basis anyway and all the events are going to be persisted serially they will also be replayed serially so

20:26

reasoning about order is actually very simp simple to do in aconet because it's mostly automatic

20:33

already now as for designing your state objects if you're taking snapshots uh this is what I think works

20:39

best is a mutable simple dataon types meaning that your state does not necessarily have methods or other things

20:46

that affect it it's basically just a simple data object now there might be situations where that a simple data

20:54

object is not going to cut it for your actor State um I I could definitely see some scenarios where that might be the

20:59

case in that case what you might want to think about then is taking snapshots of

21:04

your state using a data transfer object that is a simple data type where you can go ahead and repopulate your more

21:11

complex type using that dto and you can also easily convert that complex type into a dto as well that way this is

21:18

what's being represented in your data system even if it is slightly different from the way your state is modeled

21:23

inside your application so that's T that tends to be what I prefer here

Preparing for CQRS

21:29

now to prepare for cqrs we want to think a little bit about the way in which uh

21:35

entities are going to be queried down the stream how do you want to do projections do you want to do

21:42

projections per entity meaning that am I going to have a projector for every single entity that exists in my system

21:49

so this is supported out of the box it's very easy for us to do each entity is going to be queried independently which

21:56

means we're going to have the maximum degree of parallelism possible inside our projection system but it's going to

22:01

put a lot more strain on the database if you have a really large number of entities like we did a blog post I think

22:08

uh end of 2022 beginning of 2023 about how we introduced rate limiting inside

22:13

aad persistance query for SQL Server because we were having users running you know four or 5,000 parallel aadap

22:20

resistance queries on every single node inside their Network which meant that every couple of seconds you were having

22:26

thousands of database connections getting open potentially we've introduced a bunch of rate limiting

22:32

features inside aod resistance query that work pretty much the same way aadat resistance recovery does so you could

22:39

have hundreds of thousands of queries running in parallel and it's not going to tax the database any given time only

22:45

50 might actually be connected to the DB so you're not going to need to worry about connection pool saturation or

22:51

other issues like that these days so this strategy is totally supportable via

22:56

aadit infrastructure but it is going to be using more CPU probably more IO Etc

23:02

but everything is going to be done much lower latencies probably the other strategy which is

23:08

what we're going to use inside this code sample we're about to look at is one projector working on across multiple

23:14

entities all entities of the same type but it's only a single oaop resistance query this typically relies on the

23:21

tagging feature of aad do resistence it is much less intense in

23:27

terms of the amount of resources it uses but it's much slower at producing projections and the reason why is it has

23:33

to work sequentially through the event store for all entities at any given time inside the system so there's some

23:39

downsides to it um now that being said there's a lot you can do to potentially influence how quickly this thing works

23:46

if you wanted to um but I think that this approach is generally the most cost

23:52

effective one the other downside of this I should point out is that in extremely busy systems where you're writing let's

23:58

say many thousands of events per second it's possible that this query because it

24:03

kind of relies on polling the database can miss events in extremely busy

24:08

systems um not very frequently but it can happen uh this is just a database

24:14

kind of consistency issue to some extent we're working on some fixes on a couple different plugins for this right now so

24:20

for instance there's a contributor working on using the mongod DB change feed to go ahead and power this in

24:26

that's an example of how we can make it more robust to not miss events uh we're also looking at things like read behinds

24:32

to try to make it easier to not miss these um this projection per entity approach relies on the sequence numbers

24:38

so it can detect gaps in queries automatically this will never miss an event uh but the tagging system might so

24:46

that's just a sort of and by the way when I say extremely busy systems we're talking thousands of events per second

24:52

usually um so again if you don't have that high of a traffic in your system this will be

24:58

fine if you do have very high traffic worth bearing in mind that this can happen uh there's various tuning

25:04

features available in the persistence plugins that can do things like change the read consistency levels to help fix

25:10

this but that being said just wanted to make you aware there is a trade off uh from a u consistency standpoint with

25:17

this approach versus this one nevertheless this approach is what I'm going to be using today just because it's a lot simpler to

Tagging Events in Akka.Persistence

25:25

demonstrate um now tagging events is a super useful feature this is one of the big things that we incorporated into our

25:30

aa. persistent SQL release this is using what's called a iite event adapter and

25:37

aadap resistance this is basically an aspect oriented way of injecting

25:42

additional data about each of the events were persisting into the journal so they can be queried using additional indices

25:49

essentially so by default and I'll show you the table schema for the journal in just a moment but by default all events

25:56

are essentially organized using the um entity's persistence ID and its sequence

26:02

number this gives us another tag another dimension by which we can go ahead and try to query events from across multiple

26:09

entities typically so if I have dozens of different types of entities all writing to the same event Journal these

26:16

tags will allow me to go ahead and say oh get me the stream of all events of type product or get me all the events of

26:23

type sale or give me all the events of type inventory change that's what these tags will let us do here so this little

26:32

message tagger is something that gets configured when we set up the journal and we're going to say you know what all

26:38

the events that implement the i product event interface we want to have the

26:43

message tagger process those before they get persisted to aa. persistence that

26:48

way we can go ahead and enrich that data with some additional dimensions for indexing purposes so that's what we're

26:54

doing with this message tagger here this is what's going to power our ability to query data across multiple disparate

27:01

entities uh inside oad op persistance okay um now I guess the next

Akka.Persistence.Query

27:07

thing we'll take a look at real quick is idop resistance query the idea behind oaop assistance

27:13

query is that it is a streaming query meaning that it runs either until it reaches the end of the stream or it can

27:21

run indefinitely until you shut the program down so this events by persistence ID query is going to hit the

27:28

the event Journal this is what the event Journal uh sort of schema looks like in SQL Server we have an ordering value

27:34

that's set by the database the persistence ID which is set by you the sequence number which is set by the

27:40

persistent actor and then the serializer ID and the Manifest this is the data that the idop persist the aidon

27:46

serialization system uses to figure out how to deserialize this payload in the

27:51

future so what we're going to say here is if I want to query all events by persistence ID entity a I'm going to

27:58

fetch all the values where persistence ID equals this in their SE ascending

28:04

sequence number order so event one and then event two Etc and we will typically do this in batches of up to a 100 events

28:12

at a time and we will stream the values using AA streams to whatever the

28:17

consumer of that stream is typically known as a sync in AA streams that sync will go ahead and process those values

28:24

and every time we finish processing that data uh we will go ahead and grab the next 100 chunks until we reach we're

28:31

caught up with the current state of that entity once we're caught up with the current state of that entity uh by

28:36

default a Perpetual idop resistance query will pull the table for changes once every 3 to five seconds that's a

28:43

configurable value but five is usually the default there's several different

Flavors of Persistent Query

28:49

flavors of oaop resistance query to be aware of uh any query that has the

28:54

current prefix is a finite query it'll get you caught up to the current representation of that entity or the

29:00

current state of that tag and then it'll finish once it reaches the very end of the process queries without the current

29:08

prefix are infinite queries they will not stop they'll keep running indefinitely until you shut them down

29:15

explicitly so this is useful for being able to detect new events that haven't been written yet so if you want to go

29:20

ahead and constantly create new projections on the Fly which is what we're going to do in our code sample you

29:25

want to use the queries that do not have current in front of them so we have events by persistent ID get all the

29:32

events for a single entity events by tag that's what we're going to use today get events from multiple entities that have

29:38

the specific tag all events get everything in the entire journal for all entities I do not recommend using this

29:45

because you can end up getting a bunch of junk if you're not careful and then finally we also have a query for being

29:50

able to learn about persistence IDs as new entities are created we can receive a notification about that uh the very

29:57

first time they've been added to the journal so that's another query type that we also support um typically the

30:02

two big ones that most users use in practice are these two the events by persistance ID and the events by

30:10

tag what the aoda persistance query engine will let us do is we get this continuous stream of events so in this

30:18

case I'm actually using a little diagram from SD cabin 2.0 one of the the products that we're building in house

30:24

here at pbridge and this is from our real sort of architecture diagram whenever someone uploads a package to

30:29

our new get V3 API we upload the package we record an event that this package was

30:35

uploaded into aaop persistance uh we have a projector actor that's going to go ahead and tail all the events from

30:42

aaop persistance and based off the different package publish and update events we're going to go ahead and

30:48

update our little read model that actually Powers all the new get data feeds that people use to restore

30:53

packages from from sdin so that's kind of an example of a raid model design here is that we're using acad up

30:59

resistance query to update rows in like an Entity framework table the primary tool we use for doing

Materialized Views & Error Handling

31:07

this reliably over a long period of time are materialized view actors this is just a type of actor design it's not a

31:14

bass class or anything but these are persistent actors who themselves are

31:20

running aoda persistence query to basically project events from other actors and the thing that they persist

31:26

is their position in the data stream known as an offset so these actors will

31:31

recover their offset position when they start they'll resume their query from their last known offset so they won't

31:37

replay any events they've already successfully projected and they're designed never to replay their own

31:43

persistance activity that's one of the reasons why we don't use the all events query is because we would end up picking

31:48

up our own persistence activity by accident in theory so I'm going to go ahead and hop

31:55

into a little demo here uh this demo is a ailable let me go ahead and pull up

32:00

our browser this demo is available as open source inside our aa. net code

32:05

samples repository if you scroll down here you'll see there's three samples this brand new one event sourcing with

32:11

cqrs knock. resistence knock. persistance query I have a little read me here that kind of describes how it

32:17

works and what we're trying to do um but without any further Ado let me go ahead and actually fire the sample

32:24

up I'm going to launch SQL Server real quickly and that's going to go ahead and build

32:31

my SQL Server image and try to migrate my Entity framework schema onto it let me go ahead and do

32:37

that in fact while I'm here let me go ahead and get SQL Server management Studio up and

32:45

running which should take hopefully just a second here and let me go ahead and connect to

32:53

here all right if I take a look at our AA database you can see there's an entity framework table this db. products

32:59

this is going to be where our read models are stored I'm going to open up ryer and let

33:05

me take a look at our solution real quick we have four projects we have our

33:12

uh CQR SQL Server front end our backend project and then we have our data model

33:18

our data model is basically where our Entity framework stuff lives that's all that's in there our shared libraries

33:24

were all of our messages and state objects and serializer stuff exists uh that's actually funnily enough only used

33:30

by the backend process and then we have our front-end process right here which is a really simple Blazer UI that uses

33:37

no aa. net whatsoever it only uses this SQL Server context that we're going to

33:43

spin up so let me go ahead and launch our Blazer front end Okie do so we're using mud Blazer

33:51

and right now you can see that there's zero data inside the system no aa. net code at all I don't think this even

33:58

references AA anywhere in fact let me just double check I take a look at dependencies uh packages yeah just mud

34:05

blazor and get a source link cool so pretty simple little frontend project there now if I fire up my backend

34:14

project and I go down here this backend project is going to use the exact same

34:20

Entity framework context that we currently have and it's going to go ahead and use all the code we've

34:25

previously seen the only thing we haven't seen yet is this little bit of code right here where we're actually starting our actors we're g to start

34:31

this little generic child par entity parent actor this actor basically functions the same way uh ocod do

34:38

cluster Shard region would just without sharding enabled so it's doing more or less the same type of work then we have

34:44

this little product totals actor right here a basic persistent actor that's going to process these commands persist

34:51

them we've already seen this code on the slides not doing anything all that spectacular here let me go ahead and

34:58

fire up the backend actor uh the backend process and this backend process is going to use down here it's going to use

35:05

bogus to generate some fake data that should create some fake looking little uh products for us and then we have our

35:11

projector actor right here that we'll talk about in a minute so let me fire up the back

35:17

end all right so I can see a whole bunch of events getting processed let's see what's going on on our front end and lo

35:24

and behold I now have some data records available so I think this thing will only produce maybe up to a 100 products

35:30

uh let's go ahead and flip this around let's see what's our highest price product refine steel ball what's the one

35:37

we've made the most revenue from that's going to change a little bit and let's take a look at our back

35:44

end looks like it is still processing some incoming events there so we're still producing some stuff we're kind of

35:51

saving events sequentially so that's all kind of happening using um basically a bunch of asks internally so that's still

35:58

running here and I think we should probably have reached the end of the event stream now

36:04

yes we have okay so one thing that's worth bearing in mind if I scroll up here

36:11

let's see looks like our projections finished at the very end down here so

36:16

you can see a whole bunch of logs coming from our projections and if I

36:22

um if I go ahead and hit Refresh on here our data is done changing

36:28

so what's going on with our little read model here how is all this working

36:33

exactly well if I go back to PowerPoint um actually hold on a second I'll

36:38

discard my annotations for a moment if we go back to our code and let me pull up our actual projector code

36:45

here product totals projector here we go oh sorry this is it our projector actor

36:51

here's what this particular actor is doing we are taking a service provider injected into our structor using aa.

36:59

Net's di system and we have this materialized view state property right

37:04

here that we're sticking basically as a property of this actor what's going to end up happening is that this actor is

37:11

going to recover its view State uh from the sum of all these different little uh

37:17

events that we processed every time we successfully move through the event stream we are going to update our

37:24

materialized view state so this allows the actor to basically pick up projecting exactly where it left off one

37:30

of the really cool implications of this is that this projector can actually run in a totally separate process from where

37:37

all of your persistent actors are running so the projector could be its own process in theory if I wanted to

37:44

this projector when it starts up is going to remember exactly where it left off and it's going to go ahead and replay all those events uh that it

37:51

hasn't yet had a chance to project I'm overwriting this method right here this on replay success method

37:59

um this is a little piece of like actor sort of uh behavior that gets invoked

38:05

when the actor is done recovering but hasn't started processing any commands yet so what I'm going to do here is call

38:11

persistence query. getet and read journal for SQL read Journal SQL readj journal. identifier every single idop

38:18

persistance plugin we ship has some syntax equivalent of this this allows us to basically just start reading directly

38:25

from the journal for whatever our underlying implement is like we have one of these for mongodb one for Azure table

38:31

storage Etc this is going to produce a aadat

38:37

stream source of type um I think it's going to produce the event envelope yes that's what we're going to do the sync

38:43

in this case is going to be a sync actor ref with act this is basically a back pressure aware sync where you send this

38:51

actor uh a message of a type event envelope every time a new piece of data arrives and we need to rece receive this

38:59

projection act message before we give the actor the next message to process so

39:04

this is basically how we make sure uh acad up resistance query gets back pressured when the actor is doing its

39:09

projections and finally I create my actual projection right here I do events by tag and I pass in the tag we want to

39:16

use and I pass in our previous offset this is what allows the query to basically reproject from its last known

39:23

position in the Stream and this is going to cause it all to go ahead and begin running and then down here my actor is

39:31

going to receive an event envelope and every time we receive one of these i product events I'm going to call this

39:37

little Tri process method right here and in the event that this Tri process method fails we're going to do a little

39:43

bit of exponential back off that's kind of what this code does uh but then if we succeed we call persistent act this is

39:49

going to advance the stream forward so let's take a look at persistent act real quick I'm basically I'm just going to go

39:56

ahead and update my material view state I'm going to persist my change in my

40:01

view state every 10 events I'm going to save a snapshot and then I'm going to tell the cender who's the basically it's

40:06

the AA streams actor in this case I'm going to tell it that we're ready for the next event right here all right all

40:12

looks pretty good now if I scroll back up to our Tri process event this is

40:18

where the actual projections happen so let's go down here this projection is going to this is

40:25

why we passed in a service provider by by the way Entity framework by default is a scoped dependency that's the

40:31

lifetime it uses in microsoft. extensions. di so every time we work with it we're going to go and create a

40:37

brand new scope so we create a scope that's going to give us access to the SQL Server context we are going to

40:44

dispose of it once this method exits and depending on what type of event we received I have a slightly different

40:50

method for how we're doing the projection so if I go down here update our product definition uh if we

40:57

basically don't have a product definition we will go ahead and add a new one and save those changes I suppose

41:03

I can make this do an upsert as well that if we already had a product definition I could attach it and change it which is what I'm doing here for

41:10

things like products sold I'm going to go ahead and take the sold units and add the additional value that we received

41:17

from this event right here and we're going to update our total revenue this is actually kind of a

41:22

little bit of an important trait by the way which is that you should have all the information you need in your event

41:29

to be able to find the row in let's say your SQL projection that you're doing or to find the key in a key value or

41:37

document based projection that you're doing you don't want to have a bunch of crazy lookup tables and other junk like

41:42

that when you're trying to do your projections you want to try to keep things nice and linear like how we're

41:48

doing here so we're using a really simple Key System where we just look up the product ID in this table we'll

41:54

update some values and then we'll go ahead and save that that back using eny framework and we do the same thing for

42:00

this update product inventory right here and that's basically the full extent of

42:06

our projection process for this particular sample now for larger systems

42:11

where you have a lot more entities that all need to be processed and you're worried about basically this design

42:17

being a little bit too slow one thing you can do if you're able to relax some of your ordering requirements is you can

42:24

either go ahead and pull more events all in one go you can do that using AA streams to specify it and then you can

42:31

have a projection actor per entity if you want to that's particularly useful if you need to take one entity and

42:38

project it into multiple different read models if you're using let's say denormalization to try to optimize your

42:44

read models for lots of different queries you might be supporting in your system it's a good example if you have a

42:49

pretty extensive reporting dashboard you need to support for one of your users you might want to take events that are

42:55

affect that are being produced by some of your entities and project them into all those different report structures

43:00

that you need to support in your dashboard you might want to have one actor that owns that for each individual

43:06

entity inside your system and in fact that's actually what we go ahead and do for things like uh SDK bin behind the

43:13

scenes uh for every single product and there might be dozens of products inside our system they each get their own

43:19

projection actor because they have to update a combination of let's say feed metadata product utilization data and

43:27

license utilization data all of which are different sort of domains in our system that all key off the same events

43:34

to do different domain specific things so you can have an individual actor do that rather than having all that built

43:40

directly into the projector itself that's just a design decision I kept this as simple as possible mostly so you

43:47

had one easy to kind of wrap your arms around code sample to look at for getting started doing this uh moving

43:53

down field to doing let's say an actor per let's say entity that manages all

43:59

the different projections it does that's a lot closer to what a real production grade system would probably look like

44:04

but we wanted to keep it simple for this sample here so let me go and shut this down real

44:09

quick um okay now going back to I don't know why it keeps pulling up my cluster

44:14

sharding presentation uh going back to this thinking a bit about future proofing and

Future Proofing with Versioning

44:21

by the way I've seen some folks writing some questions in chat I'm going to get to those as soon as we are done with the

44:27

presentation which is probably about 5 minutes away from finishing so let's talk a bit about future proofing uh

44:33

[[extend only design]] is something you've seen me talk about uh in our YouTube and in some of my conference presentations

44:40

it's also in the video that we're going to recommend on versioning State and messages extended only design is the

44:46

safest approach for versioning state and messages it's even in the Google [[Protobuf]] documentation as the Blessed

44:53

way you are supposed to evolve your messages and events in protoo um we strongly

44:59

recommend once you start getting serious about using aidet in production schema based serialization is probably the way

45:06

to go not [[reflection based serialization]] so [[Hyperion]] and [[Newtonsoft.Json]] and

45:12

even system. text. Json are all reflection based tools ultimately they have their purpose they're very low Co

45:19

total cost of ownership and easy to get up and running but they don't support version tolerance inherently well uh

45:24

Json is not a good fit for version tolerance protuff is that's one of the

45:30

reasons why we strongly recommend it this will save you a lot of pain and Agony the earlier you adopt it the other

45:37

sort of things to bear in mind about extend design we never rename remove or

45:42

repurpose existing Properties or types uh you can always add new stuff you can't get rid of or IR irrevocably

45:50

change old things once they've been introduced that's the whole point of extend only design is that once things

45:55

are deployed there's safe they can stop getting used eventually once those features and functionality are

46:01

deprecated but you don't really want to go through and remove and refactor them that's just going to inject risk

46:07

overhead and complications into your system and yeah like you said you can always extend what's there you can

46:13

always add new Properties or new types all new properties should be treated as optional and have safe defaults so good

46:19

example in net parlance all new properties should be nullable meaning that basically they may not need to be

46:25

populated if you're replaying a older version of an event from your event store it's not going to have properties

46:32

that didn't exist at the time it was saved Therefore your code should sort of factor that into its design it's not as

46:38

hard as it looks it's more of just like a habit you want to get into in order to make sure things are done safely over a

46:45

long period of time in your software from a versioning strategy standpoint uh separating your wire types

46:52

from your application types is one way of going about it so Define your wire types and protobot have your application types defined in C

46:59

and F U maybe compress the number of unique wire types that you have so these are the types being saved as you know

47:05

records and knock it out persistence um and then basically create an explicit serialization and mapping layer between

47:11

the two this is something that we cover in our video on how to do versioning uh if you've been following some of our

47:16

community standups you've seen a little pre a demo that Gregorius gave maybe about six months ago we are planning on

47:23

automating a lot of this stuff so it's not nearly as much drudgery as it is today so we are planning on making this

47:28

easier in the future still a good idea to go ahead and try doing it on your own

47:34

today you will get a lot of benefit from it both from a performance a security and a versioning sort of standpoint a

47:40

lot of good reasons to do it you basically have to pay a little bit of overhead from a development engineering

47:46

standpoint once and it pays for itself very quickly I promise now the last thing I kind of

47:52

want to touch on is changing the way you do read models changing the way you produce

47:58

one of the big things you want to bear in mind I get asked sometimes about let's say storage costs when it comes to

48:05

uh storing data and knock it up resistance if data storage is a is a

48:10

problem let's say if you're writing such a huge volume of events that it's going to start imposing like high costs on

48:17

your database platform there's a good solution for that which is 

> [!NOTE]
> use a cheaper data store for write-side events
> there's

48:23

a reason why 

> [!NOTE]
> I like using Azure table storage by my default for most of these things that's because data is dirt cheap
> 

48:30

on there and all of ocod persistance queries work just fine my read models that need to be cached and need to be

48:36

included in maybe let's say uh 

> [!NOTE]
> joins and other sorts of you know reports or whatever that can all live in SQL Azure

48:43

if I'm deploying on on Azure uh but if I'm going to go ahead and basically have just my event store which is primarily

48:48

used for powering uh my actor state recovery and for powering my projections

48:54

you can just stick that in Azure table storage no problem so if you don't delete any of your

48:59

events you get a lot more flexibility and freedom with creating new read models later if you go through and

49:04

delete stuff that you might need that's going to become a little problematic potentially for doing projections down

49:10

the road so this is a domain specific thing you're going to need to consider uh in terms of how you deal with

49:16

historical data if you know for certain you're never going to need those events again because maybe your domain is

49:22

highly perishable then not a problem you can go through and delete that but if you might want that data for being able

49:28

to do back testing or projections or whatever in the future basically design it so your event store can just grow

49:35

indefinitely and kind of plan for that in your infrastructure that's why having a really cheap right side event store

49:41

that's simple like a key value system is probably the way to go for that now if you want to go ahead and add

49:47

additional materialized views there's a couple ways you can go about this one is creating an additional materialized view

49:53

actor that queries the exact same data but has a different persistence ID

49:58

meaning that its offset isn't the same as the older persistent actor that had basically if we have if I go back to my

50:05

source code here uh this Pro product projector actor

50:11

I can create a second one of these with a different persistence ID that queries the exact same events and updates

50:16

totally different Entity framework tables with it that's a really easy way to create additional read models that

50:22

didn't exist before you just run those two projections in parallel doesn't cost that much uh this will let you go ahead

50:28

and easily add new projections if you want uh the other thing you can potentially do is Rerun a query and by

50:34

rerunning a query here's what I mean go back to uh our source code if I want to

50:41

go ahead and rerun my projection I can just change the persistence ID here or I can go ahead and delete uh the most

50:49

recent snapshot and all the events that belong to this persistence ID here and this will cause this actor to rerun all

50:55

of its projections all over over again that could be really useful in the event that let's say you aren't happy with

51:01

your read models that you currently have and you want to redo all of them well you can just go ahead and reproject them

51:07

from scratch this way um the other thing that you might want to think about at the design of how you do your read

51:12

models down below here is trying to make all these operations item potent uh

51:17

update you know all these different little Entity framework updates we're doing most of these already are somewhat item potent although not really now not

51:25

with the way we're kind of computing uh these changes in inventory and revenue that's not really item potent so if we

51:31

end up reprocessing all the events multiple times these totals are going to get thrown off so that's something you

51:36

kind of want to be aware of is ideally you should try to model this item potently that gives you even more flexibility but with like the types of

51:43

reporting we're doing here not really all that feasible I would need to basically drop this table and rebuild it

51:48

from scratch if I really wanted to fundamentally alter it in some significant way and I think that's cool

51:53

about cqrs and oid oper assistance query is very inexpensive to do that so you

51:59

have the freedom to do that without losing any business value the reason being is that you your events are your

52:05

source of Truth and they haven't been deleted yet so that's the end of my presentation um thank you very much for

52:12

attending I'm going to go ahead and answer a few questions that were left by uh members of the audience um but if you

52:20

enjoyed this presentation today and you want some help figuring out how to get this type of cqrs design uh implemented

52:27

in your own applications please feel free to go ahead and contact us about a support plan this is exactly the sort of

52:32

thing that we do to help lots and lots of customers so strongly recommend you take a look at that uh you can go to

52:38

pge.com servicesupport and also if you are a current support customer we have

52:43

OA do cluster sharding trainings next week where we'll touch on how to deal with let's say the distribution of a lot

52:49

of these entities across many nodes in the cluster now that being said let me go through my set of questions here

Viewer Questions & Conclusion

52:57

and try to answer some of these okay uh let's

53:02

see uh oh let's see chat hand out questions there we go

53:10

okay all right okay set priority we'll go ahead

53:17

and handle this question okay the first question I have here is from I don't know how to show these on screen so I

53:23

apologize but I'm going to do my best to answer them the first question I have here is from Richard Harding uh what

53:29

about any side effects calls to other systems as a result of replaying events during recovery that is a great question

53:36

you should not do side effects during recovery um what the right place to handle that Richard if I pull up my

53:43

source code here to deal with a side effect after you're done recovering would be if I go back to my product

53:49

totals actor actually I'll do it in my projector actor the right place to deal with that is on replay success right

53:57

here this is sort of where you can you can go ahead and deal with side effects as you're done recovering that's the

54:02

right place to do it um the idea behind recovery is it's supposed to be quick and it's supposed to just get you back

54:08

to your original state and not really meant to produce side effects uh but you can do that in the on replay success

54:14

right here you could do things like inspect your current state and maybe change I don't know um maybe you could

54:20

potentially change the um Behavior your actor starts in or maybe this can cause

54:26

actor to do things like oh I have a JWT that's been expired I need to go get another one before I start processing

54:33

messages that's the sort of place where you might want to do that uh next question would you use an immutable

54:39

State for the persistent actor even though message processing is thread safe doesn't it allocate a bunch of garbage

54:44

in the process in theory yes um I like to use a mutable State just because it allows me

54:51

to model all of my transform functions as pure which makes them really easy to test and also has a couple of other

54:57

benefits uh such as being able to go ahead and repurpose them for things like simulations and that sort of stuff the

55:03

garbage collection overhead of modifying things like records is pretty negligible to be honest even if you had millions of

55:09

actors all processing them at once so I wouldn't get too worried about it but if

55:15

you did notice that start to become a bit of a performance concern then maybe moving towards a mutable model might be

55:20

better the other reason why you kind of want to have an immutable representation of your actor State when you're saving

55:26

it off for snapshots is if that state gets modified while it's being persisted

55:31

you can get some really brutal looking exceptions while that happens because technically the snapshot is actually

55:36

being processed by another actor who is not you it's happening asynchronously behind the scenes so yeah in hindsight

55:42

you really do need to make the snapshots immutable um so even if your actor state is mutable whatever you send to be

55:48

persisted that does need to be immutable okay question from Jason petties it was mentioned that the

55:55

quering polls data storage every 3 to 5 Seconds it seems like the queries could subscribe somehow to the persistence

56:01

infrastructure uh to know automatically that new journal entries have been added without polling apparently there's

56:06

something wrong with that idea could you explain why AA poll instead of tapping into aaop persistance uh to react

56:12

instead of pull yes uh I can explain that we originally built oaop resistance to do this in fact and we had to get rid

56:19

of it um the reason being for that is oad up resistance is distributed across multiple nodes in the cluster if you

56:25

have no a b c and d node a even if it subscribes to basically node A's Journal

56:31

won't be notified about events happening on Journal d uh so that's kind of what drives some of that functionality there

56:38

uh now what we could do potentially to try to make querying happen uh more

56:44

efficiently I guess is we could have some way of let's say painting a query where we know that this query's been

56:52

affected by something that happened locally on the Node and we could nudge it to go ahead and run now rather than 5 Seconds that is something we could in

56:58

theory do probably the best compromise here is something like what we're trying to do at the mongodb plug-in which is

57:06

using things like the mongodb change feed where rather than polling for changes we get actively notified about

57:11

it the biggest problem with like why we have to do polling is databases like SQL

57:18

server in theory support like it's being able to subscribe the change notifications I think it's the SQL Server um service broker that lets you

57:25

do that in SQL server but that feature isn't Exposed on things like most additions of SQL Azure for instance so

57:31

we can't really rely on that and then other databases like Azure table storage don't expose anything like that at all

57:38

so the reason why the polling structure largely exists is mostly due to what the lowest common denominator of the

57:44

database will actually support um platforms that do support something at their sort of Base tier that allows us

57:51

to receive notifications about specific documents changing that is something

57:56

that we're that we are interested in exploring because that'll help get rid of this sort of like need to pull in the

58:02

first place and will help reduce latency and will help improve uh consistency as well particularly for really high

58:08

Traffic Systems so that's why we do that it kind of comes down to what does the ecosystem

58:13

support uh next question from Mike does acad up resistance support event archival to keep the journal size in

58:20

check and minimize indexing overhead will it start quering events uh from the sequence numers stored in the latest

58:26

snapshot uh yes we do query events stored from the latest snapshot the way to go ahead and do archival um well in

58:33

this case we're not really doing archival so much as deletion is that when we save a snapshot I go ahead and I

58:39

delete all the older messages and I delete all the older snapshots here so I'm keeping the actor State compressed

58:44

at any given time in theory you could go ahead and run an archival process and say hey go ahead and grab these ranges

58:51

of data and move them into Cold Storage if you wanted to um I could up systems

58:56

probably won't ever support that right out of the gate because it's somewhat database specific how we would go about

59:02

even doing that but we do support things like being able to do sliding window deletions like

59:08

this um let's see Malcolm can you speak how a databases change data capture

59:14

functionality might alleviate the occasional issue of missed events when querying tags uh yes U so like I

59:20

mentioned mongodb's uh change data feed functionality will do that the reason being is I could basically subscribe to

59:26

specific document indices and look for specific events that show up in there in

59:32

order to uh use that to kind of Drive the query forward what that basically does it kind of inverts the model from

59:38

the client blindly querying the database to the database notifying the client when things are happening that's sort of

59:44

how it would alleviate that issue so the problem is that because the client's polling and kind of guessing when things

59:49

changed that's when we might have let's say uh a a section of rows in OA do in

59:56

aaop persistance SQL for instance where we're typically doing I think uh is it

1:00:01

read committed I think is the normal consistency level we're using is potential there could be an uncommitted

1:00:07

row sitting in the middle of that that SQL Server just hasn't had time to process yet um and that's where events

1:00:13

get missed typically is through those sort of consistency problems like that well if we're doing a change data

1:00:18

capture feed and we're kind of working sequentially through all the different rows that are being committed we can as

1:00:23

long as we can order that um then we're going to be able to go ahead and use that to basically make sure their cursor

1:00:29

is kind of advancing sequentially now if that didn't work for some reason um then we're kind of back to square one and

1:00:35

looking at things like read behind mechanisms and doing Gap detect trying to do Gap detection stuff like that so

1:00:42

these are all let's say like quasi database engineering sort of

1:00:47

questions that we have to address but hey it affects real users so that's why we invest time looking into it last two

1:00:54

questions both from Alex B is aod assistance query the right tool to implement [[saga design pattern]] s and process managers

1:01:01

um you could certainly do that um with aod persistance query depending on B I

1:01:07

guess how you're looking for completion events if you send a bunch of data off to entity actors and you want to use a

1:01:13

query to verify they persisted the right event you could definitely trigger a saga to do it that way I tend to prefer

1:01:19

in memory messaging for sagas because I tend to want to um have things talking

1:01:24

to I want to have the Saga talking directly to the actors doing the work so rather than doing it indirectly through

1:01:31

a tailing events those actors are producing so I probably wouldn't wouldn't be my first inclination but

1:01:36

there's nothing wrong with doing it though lastly can I read the events of

1:01:42

multiple tags to build a projection uh yes absolutely you can do that um you can do that using uh basically if I go

1:01:50

to my persistence syntax right here what you could do is basic kick off

1:01:56

multiple events by tag and then combine them into a single stream that way the projector is seeing all the different

1:02:02

events showing up now if you're worried about debouncing or multiple events all showing up you could use things like the

1:02:08

group within stage and maybe do a little bit of sequence number or ordering ID filtering inside the stream graph here

1:02:14

to eliminate duplicates where one event might be show up in multiple tags

1:02:21

potentially okay um

1:02:26

I see a question here this is a duplicate of a question that is on our a.net GitHub discussion thing I will

1:02:33

answer that question there uh last question how hard is it to use a.net in

1:02:39

an existing application for instance how to use it with custom DB context implementations that is a good question

1:02:46

and probably going to be the subject of one of our next webinars I have it on my whiteboard actually is something that we

1:02:51

need to need to do um it shouldn't be that hard I the first thing I wouldn't

1:02:56

do if I wanted to introduce a.net into an existing app is I probably would not start using aa. cluster and all the big

1:03:02

distributed systems features I would probably start by using actors to kind of do things in the background uh behind

1:03:08

the scenes um so that might involve doing things like creating a I don't

1:03:14

know uh a simple persistent actor for keeping track of scheduled jobs and then maybe using um you know oop persistence

1:03:21

St reminders to go ahead and execute them behind the scenes kind of think of that like a a light weight implementation of something like quartz

1:03:28

potentially so there's a lot of different ways to get start out of it I don't think I can do that do justice to that on a quick Q&A here uh last

1:03:35

question I'll go ahead and take is does acad up resistance support [[sharded databases]] if the database driver can

1:03:42

support it we can support it so for instance I know a few years back we modified um we went ahead and modify the

1:03:50

reddis plugin to support [[redis clustering]] which is their Charing implementation and we know that the Mong

1:03:55

DB plug-in gets used with sharded instances quite a bit as well so it definitely does support it there's

1:04:02

nothing explicit in any of the database drivers we use that would prevent that I think so I guess long and short the

1:04:09

answer to that question should be yes okay well thank you very much everybody I really appreciate your time and

1:04:15

attention today if you have any additional questions about anything you saw uh please feel free to email us at

1:04:20

high pb.com or you can also drop me a message in the aidon at Discord so thank you thank you very much for your time

1:04:26

today really appreciate it and you should get a recording sent out to you later today all right thank you very

1:04:32

much

Engels (automatisch gegenereerd)

AlleVan PetabridgeGerelateerdVoor jouRecent geüploadBekeken