---
status: planted
dg-publish: true
tags:
  - content/video/youtube
creation_date: 2024-05-20 16:31
definition: Getting Started with Event Sourcing in .NET
ms-learn-url: undefined
url: https://www.youtube.com/watch?v=n_o-xuuVtmw
author: Nick Chapas
---


| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Author   | `VIEW[{author}][text(renderMarkdown)]`          |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |

- [ ] Review Getting Started with Event Sourcing in .NET

## Video
`$= "Made by [[" + dv.current().author+"]]"`
Open player in Obsidian:
```timestamp-url 
 https://www.youtube.com/watch?v=n_o-xuuVtmw
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

hello everybody I'm Nick and in this video I'm going to get you started with event sourcing in software engineering

```timestamp
 0:05
```

and this is not a net specific tutorial even though I'm a net Channel and I will

```timestamp
 0:10
```

be showing things using net and cop it doesn't matter what your background is what I'm going to do here is break down

```timestamp
 0:17
```

the topic in so simple terms and such simple code that even if you're doing Java or python or JavaScript or anything

```timestamp
 0:24
```

you'll be able to take this video and adapt it to your own language event sourcing when being taught tends to be

```timestamp
 0:30
```

presented in a very complicated way when at its core it's a very simple topic but

```timestamp
 0:35
```

I think because it's a lot of fancy terminology people tend to get confused by it so in this video I'm going to

```timestamp
 0:40
```

ditch all that and I'm going to just explain it in plain English and just build on top of basically nothing and

```timestamp
 0:47
```

you will understand when the terminology comes in once you learn the concept now this video is sponsored by AWS and if

```timestamp
 0:53
```

you want to find out how you can get $25 worth of free credits on WS check the description down below if you like our

```timestamp
 1:00
```

content and you want to see more make sure you subscribe for more training check out my courses on do train.com okay so let me see what I have here and

```timestamp
 1:06
```

as you can see all I have is a conso application with zero dependencies and literally nothing that's why I said you

```timestamp
 1:12
```

can actually take this and adapt it to any language we won't complicate things the topic is fairly easy to understand

```timestamp
 1:20
```

if you bring the terminology in later and the main idea around event sourcing is that state in our application is not

```timestamp
 1:27
```

just a row in a database but every time something happens I store that action I

```timestamp
 1:34
```

store that thing I store that event in the data base in an append only fashion

```timestamp
 1:39
```

I never go and say update this thing that happened in the past because that thing happened in the past and in a

```timestamp
 1:45
```

> [!NOTE]
> given moment in time it was true so what I'll be doing is if I want to reverse
> 
> ```timestamp
>  1:51
> ```
> 
> that in the future then I'll go back and have a [[reversal event]] but that thing

```timestamp
 1:56
```

still happened the great way to explain this is if you pull up your phone and you go into your bank account and you

```timestamp
 2:02
```

see that you have $10 then those $10 are not just $10 it was Zero when you open

```timestamp
 2:09
```

the bank account someone sent you 100 so at the time it was 100 then you paid for

```timestamp
 2:15
```

I don't know something that cost $50 so your bank account was 50 and then 10 was added so 60 then 50 was removed and

```timestamp
 2:22
```

you're back at 10 so these are all events in a given moment in time where you got money or you spent money and a

```timestamp
 2:29
```

great example of reversing things is what if someone gives you a refund for a

```timestamp
 2:34
```

product well if you pay $50 and you have a take out $50 then eventually that refund will replenish those $50 and to

```timestamp
 2:42
```

get the final number all you have to do is say okay what are all my transactions in my bank account oh I have these 10

```timestamp
 2:49
```

transactions let's go ahead and add on remove all that money from whatever it

```timestamp
 2:54
```

> [!NOTE]
> was in the beginning of the balance let's say zero now if that sounds inefficient to do every single time in a
> 
> ```timestamp
>  3:00
> ```
> 
> real application they're all way around it but the fundamental concept is that things happen and you build State out of

```timestamp
 3:08
```

the things that happened let's go straight into the code because there's no better way to explain this than

```timestamp
 3:14
```

actually showing you code so I'm going to go ahead and create an inmemory database to store my events I'm going to

```timestamp
 3:20
```

call that student database and I'm going to use doome train my platform as an example here so let's say a user is

```timestamp
 3:27
```

created so a student is created then they can update their profile maybe they can enroll into a course or maybe they

```timestamp
 3:33
```

can unenroll from the course or I can unenroll them and to store those events

```timestamp
 3:39
```

what I'm going to do is I'm going to create a new directory and call that events and I'm going to create a very

```timestamp
 3:45
```

simple class here an abstract class called event and what this class will

```timestamp
 3:51
```

have is two things first events are things that happen in a given moment in

```timestamp
 3:56
```

> [!NOTE]
> time so I need a way to store a timestamp so I'm going to say day time

```timestamp
 4:02
```

and I can say created at the normal terminology is timestamp I'm going to

```timestamp
 4:07
```

> [!NOTE]
> use created at UTC here and then I need a way to correlate a bunch of events

```timestamp
 4:15
```

because let's say that something happened for Nick and Nick has id1 in

```timestamp
 4:20
```

the system and then you have John and John has id2 we still need a way to identify those two users things can

```timestamp
 4:27
```

happen within those users but I still have id1 and John still has id2 my stuff

```timestamp
 4:34
```

> [!NOTE]
> my events and John's events will be distinguished by separate streams

```timestamp
 4:39
```

streams of events imagine it as a sequence of events about a given thing

```timestamp
 4:45
```

in your system in this case the student well streams can be identified by stream

```timestamp
 4:50
```

> [!NOTE]
> IDs so all of my events will have a stream ID here so stream ID here we go

```timestamp
 4:57
```

in this case I'm going to use a good to represent My Stream ID that really depends on what you're doing some

```timestamp
 5:03
```

systems use a string it can vary but in this case I'm going to use a stream ID

```timestamp
 5:08
```

and I'm going to remove the setter from here I'm going to turn that into an abstract good so here I have my base

```timestamp
 5:14
```

event now I want to represent first what happens when a user is created a student is created so I'm going to create a

```timestamp
 5:21
```

class called student created note that I don't have a student class this is very

```timestamp
 5:27
```

important so here I'm going to create my model what would a student created have well a student ID of course and you can

```timestamp
 5:33
```

argue this should be ID but because events are a separate sort of thing there's not so much ambiguity in terms

```timestamp
 5:39
```

of what each thing represents so I'm still going to keep it as student ID here then full name email and date of

```timestamp
 5:46
```

birth now this will be extending the event class that I just created and I'm

```timestamp
 5:52
```

going to implement the missing member which is a stream ID so the stream ID in my case will be mapped to the unique

```timestamp
 5:59
```

identified of the thing I want to represent so in my case it is going to be the student ID

```timestamp
 6:06
```

and I'm going to do that and that's that there's nothing else to touch I just say that the stream ID for my student is the

```timestamp
 6:14
```

student ID then all I need to do is add all the other actions so what would I

```timestamp
 6:19
```

have I would have student updated so again this would extend the event and

```timestamp
 6:25
```

what would I have here I would have a student ID and I can only update the full name and the email mail you can't

```timestamp
 6:30
```

really change your date of birth so you shouldn't be able to update it then I'm going to have the student enrolled so

```timestamp
 6:36
```

that would look something like this where I have the student ID and then the course name the course name could be a

```timestamp
 6:41
```

course object itself I want to simplify this so I'm only going to have the course name so when you enroll to a

```timestamp
 6:47
```

course all we do is we stall the name of the course and then I'm going to have the unenroll where someone can say oh I

```timestamp
 6:53
```

want to unenroll from this course maybe to get another one and so on so now I have all of my individual events so now

```timestamp
 7:01
```

I'm going to go to my program.cs and create a student database instance so

```timestamp
 7:07
```

new student database and I want to go ahead and create a student how would

```timestamp
 7:12
```

that look what you would say is that a student has been created so I would have a student created object using the

```timestamp
 7:20
```

student created object I just had now to have some persistence with the IDS I'm going to be using I'm going to hard code

```timestamp
 7:26
```

a good here for the student so I'm going to say student ID ID is that and then I'm going to pass all the other

```timestamp
 7:32
```

properties so email full name and date of birth and that's it and that represents now that the student was

```timestamp
 7:38
```

created and then in my database all I'm going to say is student database do

```timestamp
 7:44
```

append so I'm going to append an event in my database that a student was

```timestamp
 7:50
```

created obviously the append method does not exist so I'm going to go ahead and

```timestamp
 7:56
```

create it but it's not going to be a student created it's going to be an event so any event we'll call that

```timestamp
 8:05
```

append method to be saved in the database now of course I need to store these things in memory so I'm going to

```timestamp
 8:11
```

say private readon and I'm going to store it using a dictionary where the key is a good where the good is a

```timestamp
 8:16
```

student ID and then I'm going to use a sorted list even though it's not necessarily mandatory for this example

```timestamp
 8:23
```

but I want to signify a thing that's very important here and that is the ordering of the event and I have

```timestamp
 8:30
```

intentionally admitted if you're very familiar with event sourcing things like vision from the event maybe that's

```timestamp
 8:36
```

something to explain in a different video but the key here is the daytime when the event happened and then I'm

```timestamp
 8:42
```

going to have the event itself and I'm going to say student events equals new

```timestamp
 8:50
```

and that's that so what this sorted list is supposed to represent is that stream

```timestamp
 8:55
```

per event in this case the student events so what I'm going to say V stream

```timestamp
 9:01
```

equals and I'm going to try to get that stream for that student so I'm going to

```timestamp
 9:07
```

say event. stream ID and if you don't find it return null so if the stream is null

```timestamp
 9:17
```

then take the student events with this stream ID and create a new entry so

```timestamp
 9:25
```

equals new sorted list of this type and that's it and now I've created the stream for that student ID and I can

```timestamp
 9:31
```

start adding things into the stream all I need to say is I want to take that and say add and I'm going to store the

```timestamp
 9:38
```

eventor created at but I'm going to have to set that date as well to daytime UTC

```timestamp
 9:45
```

now so I'm going to store that here and then I'm going to store the event itself

```timestamp
 9:50
```

here we go and that's it all I'm doing is I'm storing it in a sequence in a

```timestamp
 9:56
```

stream I'm saying add this at the bottom of this sorted list based on the date it

```timestamp
 10:03
```

was added so now if I go back to my program.cs that's it that's as if I save

```timestamp
 10:08
```

something in the database now what if something else happens for example what

```timestamp
 10:14
```

if I also want to store that the user was enrolled well I would have something like this where I have that student IDE

```timestamp
 10:19
```

and I say enroll the student in the course from Zero to Hero rest apis in net and then append that and what if the

```timestamp
 10:26
```

student decides to change their email well very easy all I'm going to say is student updated and I'm going to pass

```timestamp
 10:33
```

Nick chapsas doet tr.com and then the full name and student ID and then click

```timestamp
 10:38
```

append and that's it and if I just quickly run this to show you what's happening behind the scenes if I just

```timestamp
 10:43
```

stick a break point here maybe and I say debugged let's take a look at what's happening in fact let's go through every

```timestamp
 10:50
```

single step so first I'm going to go ahead and don't want you go away GNA go ahead and just step over this and step

```timestamp
 10:57
```

into the append method so we're going to try to get the stream the stream is null because there's nothing about the student then I'm going to create it I'm

```timestamp
 11:05
```

going to set that date and then store that event and then if I go to the next thing you can see in here now that in

```timestamp
 11:12
```

the count I have one stream that has one event in it and I can keep going this

```timestamp
 11:19
```

time we had the stream and I'm saying just add it at the bottom because this happened later and this happened later

```timestamp
 11:25
```

so if I go in my database over here and I click stored event and expand that there's a stream for the student and it

```timestamp
 11:32
```

shows what happened in sequence student was created then they enrolled in a course and then they were updated I have

```timestamp
 11:39
```

everything about this student now this stream contains everything about my student and if I needs to know what

```timestamp
 11:46
```

happened with a student I also have a form of auditing by default but what

```timestamp
 11:51
```

happens if I want to represent my student in some way well there's a way to do that as well so I'm going to go

```timestamp
 11:58
```

here and and create a student class so I will have a student class but it's a bit

```timestamp
 12:04
```

different than what you might expect that student class will have all The Usual Suspects so we have an ID we have

```timestamp
 12:10
```

a full name we have an email enrolled courses and then date of birth we have the properties as you would normally

```timestamp
 12:16
```

have but then we're going to have a few methods because what we want to say is that the state of this class should only

```timestamp
 12:22
```

change through these apply methods now I know I have these as Setters so they're

```timestamp
 12:27
```

not really mutable there's a reason for that which comes into the picture later so for now I'm going to leave it as it

```timestamp
 12:32
```

is and what I'm going to say is I'm going to have an apply method per event that can mutate this student class so

```timestamp
 12:40
```

I'm going to say student created for example I'm going to say student created

```timestamp
 12:46
```

and then in the apply method I'll say okay what is this event changing about my student well I'm going to have the ID

```timestamp
 12:53
```

set I'm going to have the full name which is also a part of that event so student created do full name I'm going

```timestamp
 13:01
```

to have the email as well so email is set and I'm also going to have the date

```timestamp
 13:08
```

of birth right so all of those things are set by the created then I have updated which sets again the ID which I

```timestamp
 13:14
```

could skip but I'm not going to do that so the ID the full name and then the email because those are the two things

```timestamp
 13:21
```

we can change yeah we can skip that because we won't really be updating the ID so we can remove that and we do

```timestamp
 13:28
```

expect to have a student didn't created before updated ever comes into picture so there's that and then we also going

```timestamp
 13:34
```

to have apply methods for enrolled and unenrolled and you might be able to see

```timestamp
 13:39
```

where this is going because those are all private and they should be private

```timestamp
 13:44
```

and there should be only one public apply method in our scenario anyway

```timestamp
 13:50
```

which says that I'm going to accept that event and then I'm going to map it to the right method I'm going to use a

```timestamp
 13:56
```

switch here there's other techniques and there's other approaches some people call this evolve some people call this

```timestamp
 14:02
```

process I'm just going to call it apply and all we're going to say is take that event determine the type of this event

```timestamp
 14:07
```

using a switch and then call the apply method appropriate for that type and now you should be able to see exactly where

```timestamp
 14:14
```

this is going because now I can say that my student if I want to represent my student is a student database. getet

```timestamp
 14:22
```

student which doesn't exist but I can still pass the student ID in here and

```timestamp
 14:28
```

I'm going to go ahead and actually use the student object over here so the right method can be created

```timestamp
 14:35
```

so public student get student get student ID and I'm going to go ahead and show you how easy it is now now first

```timestamp
 14:41
```

and foremost if the student events does not contain key student ID then return

```timestamp
 14:48
```

null because just we don't have a student to return but if we do have

```timestamp
 14:54
```

something then create the Bare Bones of that student object and then get the

```timestamp
 14:59
```

student events using that student ID so now we have the events and we're going

```timestamp
 15:04
```

to say for each student event in student events go ahead and call the student.

```timestamp
 15:11
```

apply method per event and because that is a sorted list I'm going to have to

```timestamp
 15:16
```

call Value and in the end return the student so now I'm going to build the

```timestamp
 15:23
```

state that represents my student on the fight based on those events so let's go

```timestamp
 15:28
```

ahead I'm going to tell this into VAR and let's go ahead and see this again step by step so I'll go ahead and step

```timestamp
 15:36
```

over the database and create my student so created then enrolled then updated

```timestamp
 15:42
```

and then I'll say get my student back so I'm going to step in here does the thing

```timestamp
 15:47
```

contain it yes it does so I'm going to say new student get the events I have three of them they are sorted by the

```timestamp
 15:53
```

date the time that they happened so I'm going to go here and go ahead and apply

```timestamp
 16:00
```

every single one of those events setting the state of that object every step of

```timestamp
 16:06
```

the way and then in the end what I get is a materialized view that represents

```timestamp
 16:11
```

that student there's a few things now that come into picture when it comes to terminology so I have a stream

```timestamp
 16:17
```

containing all the student related things so I have a stream per aggregate to represent that student and then the

```timestamp
 16:23
```

student in this case is also the aggregate root we don't really need to explain that complicated terminology

```timestamp
 16:29
```

that much you understand the functional aspect of things and that's really what matters so I have the ability to append

```timestamp
 16:37
```

only what happens to that student and then build the materialized view to represent that student based on what

```timestamp
 16:44
```

happened now there's a few things that you might immediately think of and the first thing that I would think in this situation is that isn't it a bit costly

```timestamp
 16:52
```

to just go ahead and pull all the events from a stream for this specific aggregate for the student and build it

```timestamp
 16:59
```

every single time wouldn't it be easier to just sort of keep uh the state or a

```timestamp
 17:04
```

snapshot or a materialized view of that thing in the database or maybe in our

```timestamp
 17:10
```

system and then just return that and the answer is yes and that's what's called a

```timestamp
 17:16
```

projection so let me show you I'm going to go ahead in the append method and I'm going to show you how we can build

```timestamp
 17:22
```

what's called a synchronous projection and it's going to be synchronous because we're going to be updating that state as

```timestamp
 17:30
```

we append new events we're still going to append events but we also going to update that state now whether we're

```timestamp
 17:36
```

going to do it synchronously or asynchronously depends on the scenario you are into if you're in a read heavy

```timestamp
 17:43
```

scenario or if you're in a right heavy scenario and also if you can deal with

```timestamp
 17:48
```

some eventual consistency or if you absolutely need strong consistency I don't want to go too in depth into those

```timestamp
 17:55
```

Concepts because I do have a video coming for that as well I I want to keep it simpler so let's go ahead and see how

```timestamp
 18:00
```

we can build a simple projection what I'm going to do is I'm going to create a separate dictionary here I'm going to

```timestamp
 18:07
```

say private read only dictionary good and then student and that will have my

```timestamp
 18:14
```

students in here and then every time an event comes in what I'm going to say

```timestamp
 18:20
```

after I store that event is go ahead and the students dictionary use the stream

```timestamp
 18:25
```

ID which I know is a student ID here and set get my student State now to do that

```timestamp
 18:31
```

I'm going to use the get student method and I'm going to pass down the event. ID

```timestamp
 18:37
```

and that is definitely not null at this point because I have at least one event that I just added and then if I want to

```timestamp
 18:43
```

get that view what I can say is public student get student view and then I'm

```timestamp
 18:51
```

going to just return that student so I'm going to say students. get value or

```timestamp
 18:56
```

default I'm going to try to get based on the key otherwise return null and that's

```timestamp
 19:02
```

that this is definitely not null at this point so I'll go here and I'm going to say student and then student from View

```timestamp
 19:10
```

and I'm going to say get student view and I'm going to stick a breakpoint and quickly show you what's happening so I'm

```timestamp
 19:15
```

going to still append everything every step of the way but I'm not writing one thing I'm writing two things every time

```timestamp
 19:23
```

so I build first this state by just going through every single event but I also if I step in here here I can go

```timestamp
 19:29
```

into the students thing that contains all of my materialized views and I can see that I also have stored that and I

```timestamp
 19:35
```

don't need to go and get everything now and then rebuild it I can just go ahead

```timestamp
 19:40
```

and return it from that storage so that's all really really nice and

```timestamp
 19:46
```

fundamentally that covers a big portion of what event sourcing is now the alternative to all that is of course not

```timestamp
 19:54
```

doing this synchronously because remember if you're in a real database scenario you would have to wrap this

```timestamp
 20:00
```

into a transaction because the addition to the database of that event and the

```timestamp
 20:05
```

update of your current state should happen at the exact same time and they should succeed together or fail together

```timestamp
 20:12
```

so it should be Atomic now what I want to do to just give you a better understanding of everything is bring a

```timestamp
 20:18
```

real database into the mix and for that I'm going to use dynamodb I've built event sourcing systems in Dynam DV in

```timestamp
 20:25
```

> [!NOTE]
> the past and Dynamo DB and also things like Cosmos DB as well they are great
> 
> ```timestamp
>  20:30
> ```
> 
> for that sort of thing because of their partitioning strategy and Dynam DB especially because the terminology I

```timestamp
 20:37
```

> [!NOTE]
> think and all the features that it has makes this such an easy experience and if I was to build an [[event sourcing]]
> 
> ```timestamp
>  20:42
> ```
> 
> system I would use something like [[DynamoDB]] I know this librar is like Martin that use postgres to do that I'm more of a

```timestamp
 20:48
```

Dynam person and that's why I'm going to use that here so what I'm going to do is I'm just going to quickly close all the

```timestamp
 20:54
```

tabs and I'm going to add Dynamo DB into the mix the V2 library and that is it

```timestamp
 21:01
```

and I'm going to keep it very very simple I'm not going to complicate at all I'm going to go to the student

```timestamp
 21:07
```

database and I'm going to remove these in memory representations and I'm going to replace with a private read only I

```timestamp
 21:13
```

Amazon Dynam DB and I'm going to say Dynam DB here equals a new client and

```timestamp
 21:21
```

that client will have a region of EU West to because that's where I am and

```timestamp
 21:27
```

I'm also going to say Prime private const string table name and the table name is students for this case now I'm

```timestamp
 21:35
```

just going to quickly show you how easy it is to create the table in Dynamo debut I'm just going to say create table

```timestamp
 21:40
```

I'm going to say students here and then I'm going to set the partition key and the sord key event sourcing and no

```timestamp
 21:46
```

secret databases play very nicely together especially because of the partition key so partition key is not

```timestamp
 21:52
```

necessarily like a primary key in a database because the uniqueness of an item in database is like Dynamo to be is

```timestamp
 22:00
```

the combination of the partition key and then the secondary key in this case the sord key which as you can understand by

```timestamp
 22:06
```

the name it is also sorted by default based on the value so what we're going

```timestamp
 22:11
```

to do here is create a partition key and we're going to call that PK and that's for a reason I will explain later and

```timestamp
 22:17
```

then I'm going to call the S key SK and that's it and I'm not going to customize anything else all I'm going to say is

```timestamp
 22:24
```

create that table and that's it we're going to give it a second but we're not really going to tou it until until we push some data into it and then I'm

```timestamp
 22:30
```

going to start updating this code to use dynamodb so let's go ahead and just

```timestamp
 22:35
```

delete everything from here but still implement the exact same logic so in a pend I just want to save I just want to

```timestamp
 22:42
```

write a thing in the database and that's it now because we're going to be writing a lot in Json and how calization works

```timestamp
 22:48
```

and inheritance works with things like inheritance and generics in cop we're going to have to change the append

```timestamp
 22:53
```

method a bit so I'm going to turn this into a generic ttype parameter and I'm going to say where T is event and I'm

```timestamp
 23:01
```

also going to change this to an async task because we're going to be awaiting things so this is now aend async and I'm

```timestamp
 23:09
```

going to do the same for all the other methods but for now I'm just going to delete them now because I'm using

```timestamp
 23:14
```

inheritance in my events I do have to change this event class a bit to let it

```timestamp
 23:20
```

know that it is inherited by some all the classes so the serializer and der

```timestamp
 23:25
```

> [!NOTE]
> serializer of Json knows how to give me the right type back when I say realize
> 
> ```timestamp
>  23:31
> ```
> 
> this event back into a student event to do that first we have to say that this is using [[Json polymorphism]] and then I'm
> 

```timestamp
 23:39
```

going to have to add a Json attribute per type I'm storing and I'm going to have to also specify the name of that

```timestamp
 23:46
```

event so when an event is stored and then it's retrieved the right type is used to serialize it and distalize it

```timestamp
 23:52
```

that would look like this and again if you want to grab any of this code it's in the description down below now since

```timestamp
 23:57
```

I'm going to be using a part partition key and a sort key for everything I'm storing I'm going to need two properties

```timestamp
 24:03
```

in my class so first I'm going to say Json property name and I'm going to say PK and I'm going to create a property

```timestamp
 24:09
```

which is a string because that's what I created in Dynam DB and it's going to be called PK now the PK is getter only and

```timestamp
 24:18
```

it's actually computed based on the stream ID so the string version of the stream ID will be my primary key and

```timestamp
 24:25
```

like I said the uniqueness is the combination of the primary key and the sword key which if you want to get very

```timestamp
 24:33
```

very technical daytime might not be the exact thing you should be using as a sord key you might want to use a long

```timestamp
 24:39
```

time stamp but I don't want to go too in depth in this the idea is that you could have clashes if for some reason you have

```timestamp
 24:47
```

two events with the exact same created ad in the same stream it's an edge case

```timestamp
 24:52
```

but I didn't want to mention it and then the sord key over here is going to be SK

```timestamp
 24:57
```

and SK and it's going to be the created at using the iso format which is also

```timestamp
 25:06
```

string sortable why is that important because everything in that stream now in Dynamo DB will be stored by order and

```timestamp
 25:13
```

then all I need to do is in student database it just say write this event so first I'm going to set the created at

```timestamp
 25:19
```

UTC as UTC now then there's a bit of code to serialize everything down to attribute which is what Dynamo DB

```timestamp
 25:26
```

expects and then I'm going to to create a create item request which is a new put

```timestamp
 25:33
```

item request what we need to pass down is the table name as the table name and

```timestamp
 25:38
```

then we need to pass down the item as attributes which we already have and

```timestamp
 25:44
```

that's it then in the end Amazon Dynam B and put item async create item request

```timestamp
 25:51
```

and just awaited and that's that so let's go back here and update everything

```timestamp
 25:56
```

appending append they snc I wait it I wait it and over here I waited again I'm

```timestamp
 26:04
```

not going to check the students first what I'm going to do is just run this code and show you how easy it is to just

```timestamp
 26:10
```

store everything in that table now so we're going to create the database instance we're going to go ahead and say append and then I'm going to set the

```timestamp
 26:17
```

values turn everything into attributes put item request and then call the put item a sync and I'm going to do that for

```timestamp
 26:24
```

everything and as you can see everything run and now if I go back to Dynamo DB and I click students and I say explore

```timestamp
 26:30
```

table we're going to see three items and they all store the type name of that

```timestamp
 26:35
```

event so student created over here all the details about that event and I can

```timestamp
 26:40
```

go back and see all the individual things in order using that sort key so

```timestamp
 26:46
```

student enrolled and then later as you can see student updated so now it's a

```timestamp
 26:51
```

matter of retrieving it from the database and building that view and this idea of doing it on the Fly sometimes is

```timestamp
 26:56
```

called a live project jection where you don't really store it or synchronously or asynchronously you just calculate it

```timestamp
 27:03
```

on the fly so first let's go here and say create the method for get student a

```timestamp
 27:09
```

sync so we get the student by student ID now Dynam theb is a bit weird when it comes to quering but that's what a query

```timestamp
 27:15
```

would look like so we say we have a key condition in the primary key we pass down the primary key value like this s

```timestamp
 27:21
```

represents a string and our key is a string so we do that then we're going to fire that request to get a response so

```timestamp
 27:27
```

we're going to say I'm Dynam be query async and we're going to say if response

```timestamp
 27:32
```

do items or do count actually is zero then we just going to return null this

```timestamp
 27:40
```

means there is no event for the student so there's no student basically then we're going to convert the attributes

```timestamp
 27:46
```

which is the item as attributes uh as documents using the from attribute map

```timestamp
 27:52
```

and then we're going to have to convert the documents into the objects by going through a Json Midstate first that would

```timestamp
 27:57
```

look something like this where student events on the documents select Json serializer and then deserialize that as

```timestamp
 28:03
```

an event but now for this to work I actually have to change one thing I'm going to have to pass down some Json

```timestamp
 28:10
```

settings because that type attribute needs to be taken into account and I'm not dealing with the order this is a bit

```timestamp
 28:16
```

of an edge case but I'm going to add it anyway so all I'm saying is these are my Json cizer options and I'm going to pass

```timestamp
 28:22
```

them down over here when I say uh deserialize this object and then in the

```timestamp
 28:28
```

the end I'm going to do the exact same thing so VAR student equals new student

```timestamp
 28:33
```

and then I'm going to loop around everything and everything should be ordered by default already because I

```timestamp
 28:39
```

have that sort key if you don't trust it for some reason you can still have something like U order bu and you can

```timestamp
 28:47
```

say x.c created at UTC so you'd have that

```timestamp
 28:53
```

and then you would say apply that student event and then return the

```timestamp
 28:58
```

student that is not null and that's it so let's go ahead and actually update

```timestamp
 29:06
```

this program and in fact I'm going to delete all the students first so let's go here and say just delete all the

```timestamp
 29:12
```

items and let's go through the flow again so breakpoint the top and let's go and not only create the student and

```timestamp
 29:18
```

retrieve it of course I need some code to actually retrieve it so await a sync

```timestamp
 29:24
```

we have that let's do it so let's go through everything we're going to store all the items as you can see we're

```timestamp
 29:31
```

storing them one two 3 here we go and then in the end let's go in here get the

```timestamp
 29:36
```

request get the response we actually have a count of three because three were the items that we stoed three individual

```timestamp
 29:42
```

events we go back we get the student events and then we loop around them we apply them and as you can see created

```timestamp
 29:49
```

first then we have enrolled and then we have updated and in the end I'm getting

```timestamp
 29:55
```

my student as an on the fly materialized view and that's it and that's really

```timestamp
 30:02
```

cool but what's even cooler is that dynamodb actually supports transactions meaning we can actually store that

```timestamp
 30:09
```

projection that materialized view as we're saving the new events and they can fail together and succeed together so in

```timestamp
 30:16
```

here instead of having this put item request like this I can do the following I can say our

```timestamp
 30:23
```

transaction request equals new write transact

```timestamp
 30:28
```

write items or items request and then I'm going to have transaction items I'm

```timestamp
 30:34
```

going to create that uh list and then first I'm going to write uh the event itself so that is a put so put equals

```timestamp
 30:42
```

new put which contains the table name and you can have cross trable transactions as well in Dynamo DB um so

```timestamp
 30:49
```

if you stored your projections and your events in Separate Tables they could still be part of a transaction and I'm

```timestamp
 30:56
```

going to say that the item is the item as attributes then I'm also going to have the new uh write item and that

```timestamp
 31:04
```

would be still a put on the same table but the items I'm going to store is just

```timestamp
 31:10
```

the student the materialized view so to calculate that what I'm going to do is I'm going to go up here and I'm going to

```timestamp
 31:16
```

say VAR student view equals and I'm going to read to get the current state

```timestamp
 31:22
```

of the student now you can see where there could be performance issues with this approach too but I'm reading from

```timestamp
 31:28
```

the projection and in many cases if you need that synchronous strong consistency

```timestamp
 31:33
```

this is what you're going to have to deal with I'm going to say I wait get student async and don't worry we're

```timestamp
 31:38
```

going to update that get student async method to use the projection instead so I'm going to say event do stream ID

```timestamp
 31:47
```

otherwise return a new student and this is only relevant when we have the first event only but it's still good to have

```timestamp
 31:54
```

and then we're going to say student view. apply and we're going to apply that incoming event so apply that event

```timestamp
 32:01
```

and then serialize everything into Dynam format so that can be done like this to turn everything into an attribute map

```timestamp
 32:07
```

and then in the end I'm just passing it down here and I'm saying await Dynam DB

```timestamp
 32:12
```

transact right items async and pass that request and now if I go ahead and I just

```timestamp
 32:18
```

clear the database again let's refresh and just delete everything here we go bye-bye and then update get student a

```timestamp
 32:25
```

sync to read from that projection so I'm going to say just comment this one out in case anyone wants to grab the code

```timestamp
 32:32
```

and get the previous version the signature will be the same but the code in it will be different now the way I'm

```timestamp
 32:37
```

going to write this is a bit interesting so what I'm going to do is I'm going to say that I have the get item request so

```timestamp
 32:43
```

we not listing anymore we're not querying we're just getting a point read for a single item which is very very

```timestamp
 32:48
```

efficient and then I'm passing partition key and sord key because that's what uniqueness is and the S key and the

```timestamp
 32:53
```

partition key student ID and then this underscore view or you can say projection or you can say state or

```timestamp
 32:59
```

current it's completely up to you what you want to say I don't want to confuse you with terminology I just want to show you how you can do it conceptually so

```timestamp
 33:07
```

now that means that I can do a very efficient Point read get that response using the get item a sync method and

```timestamp
 33:15
```

then if there is nothing then just return null otherwise do this conversion

```timestamp
 33:20
```

D and return everything back as a student and that's it now as you can

```timestamp
 33:27
```

understand here this means that I have to also add in the students object that partition key and sort key logic because

```timestamp
 33:33
```

this will also now need to be stored in dyb same thing as before the only difference is that I have to add this

```timestamp
 33:41
```

view suffix to prevent it from being in the same stream as everything else to make it even more efficient so you don't

```timestamp
 33:47
```

have to read and ignore a file and once I have that in place again my database

```timestamp
 33:52
```

is clear so I'm going to say go ahead and just run it step over everything and I'm going to say create an pend that

```timestamp
 33:58
```

first event and I'm going to go to Dynam DB at this point so if I refresh that you see two items here one of them is

```timestamp
 34:05
```

the view the other one is the event so the first event student created and then the second thing is the view that shows

```timestamp
 34:12
```

me the current state of that student so date of birth email and Ro costes and so

```timestamp
 34:18
```

on then if I go and I say step over the enrolled event what's going to happen is

```timestamp
 34:24
```

I have now three items The View and the new enrolled event so that exists but

```timestamp
 34:30
```

also my view was updated and I have that enrolled courses over here and then I can keep going and going and eventually

```timestamp
 34:37
```

read that item and you can see I have everything but this is now coming from dynamodb from that projection from that

```timestamp
 34:44
```

view that state and that's how you can do it synchronously with a synchronous projection but you can also have an

```timestamp
 34:50
```

asynchronous projection and Dynam be is excellent for that because it has a CDC

```timestamp
 34:56
```

mechanism or a change data capture mechanism built in and the idea is that every time you change something in the

```timestamp
 35:03
```

database in a table you can get a notification an event that contains that information you take that and then you

```timestamp
 35:10
```

do anything you want with it so if you didn't have this transaction what you could have is you can have a new Lambda

```timestamp
 35:16
```

over here I'm going to go to the bottom and say that I want a new simple Dynam DB function and I'm going to say event

```timestamp
 35:22
```

sourcing tutorial. Lambda and what this Lambda can do is every time a document is

```timestamp
 35:30
```

updated in that table then I get a notification and this function Handler method is triggered and I have the

```timestamp
 35:37
```

records that were updated or changed or deleted or whatever so what I would do is I would say record Dot and I would

```timestamp
 35:44
```

get the Dynamo theb stream record and then I can get both the old image and the new image I'm going to get the new

```timestamp
 35:50
```

image over here and I can say to Jason in fact I can go ahead and update this

```timestamp
 35:56
```

client and these events to be able to do that here we go and I should be able to

```timestamp
 36:02
```

say to Jason and then convert that into whatever I want and then update my projection using that asynchronous flow

```timestamp
 36:09
```

and that's how you'd have an asynchronous projection to create that state and that's it fundamentally that

```timestamp
 36:15
```

is the concept you just keep appending events of things that happened and then you can create that state and the great

```timestamp
 36:21
```

thing with this is if you use case changes in the future and you need a different way to represent that data

```timestamp
 36:27
```

then you can just recalculate that projection based on the new requirements

```timestamp
 36:32
```

there's no data lost you can always go back in time and see exactly what happened and it's a very very nice way

```timestamp
 36:38
```

to build software I hope this was easy to understand please leave a comment down below if you want to learn more about this topic because these are

```timestamp
 36:44
```

things I've done quite extensively in the past but I just tend to not talk about it because I don't know how

```timestamp
 36:50
```

interesting it would be for everyone but if you think that's interesting to you leave a comment down below let me know and I'll make more but now I want from

```timestamp
 36:56
```

you what do you think about all this and is event sourcing now easier to understand leave a comment down below

```timestamp
 37:01
```

let me know well that's all I had for you for this video thank you very much for watching and as always keep coding