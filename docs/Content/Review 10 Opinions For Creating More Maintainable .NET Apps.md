---
status: planted
dg-publish: true
tags:
  - content/video/youtube
creation_date: 2024-05-19 13:56
definition: 10 Opinions For Creating More Maintainable .NET Apps
ms-learn-url: undefined
url: https://www.youtube.com/watch?v=ZqQOm0PK6ME
author: Scott Sauber
---


| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Author   | `VIEW[{author}][text(renderMarkdown)]`          |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |

- [ ] Review 10 Opinions For Creating More Maintainable .NET Apps

## Video
`$= "Made by [[" + dv.current().author+"]]"`
Open player in Obsidian:
```timestamp-url 
 https://www.youtube.com/watch?v=ZqQOm0PK6ME
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
 0:05
```

all right how's the mic can you guys hear me okay all right Perfect all right

```timestamp
 0:10
```

so we're at time here so let's go ahead and get kicked off uh my name is Scott saber and today I'm gonna be talking to

```timestamp
 0:16
```

you about 10 things I do in every single net app that I make um I do have lots

```timestamp
 0:21
```

more than just 10 things in this talk um there's probably like 30 or so tips uh throughout this talk but we'll kind of

```timestamp
 0:26
```

hit on 10 different bucket items um so I've already posted these slides up on my blog just my first and last name

```timestamp
 0:32
```

Scots saber.com and if you want you can follow me on Twitter uh I'm Scott saber there as well and I refuse to call it X

```timestamp
 0:38
```

like that is just uh the dumbest name change I've ever heard of so I'm just going to keep calling it Twitter and

```timestamp
 0:44
```

just being a denial about that all right so you are either here in person or

```timestamp
 0:50
```

watching on YouTube later and so just make sure you're in the right spot I just want to talk about the audience that I had in mind when I built this

```timestamp
 0:56
```

> [!NOTE]
> talk and really I'm targeting net developers uh so if you're not a net Dev there's still some stuff that cross

```timestamp
 1:02
```

applies to pretty much any Tech stack that you're talk that you might be doing but primarily I'm targeting net devs and

```timestamp
 1:08
```

hopefully you are also interested in maintainable apps so hopefully that like

```timestamp
 1:14
```

cross-section of like net devs and people who are interested in maintainable apps is kind of like more of a circle than a vend diagram

```timestamp
 1:20
```

hopefully you're not a net Dev that doesn't care about maintainability like anybody in that boat

```timestamp
 1:25
```

here nobody wants to admit it cool all right so so as I mentioned uh

```timestamp
 1:31
```

we're going to talk about uh lots of different topics here and really this talk is like a series of like three to

```timestamp
 1:37
```

six minute lightning talks I'm not going to talk about all these different or read off all these different topics to

```timestamp
 1:43
```

you you can kind of take a glance at them uh but there's also like a rapid fire bonus at the end where I'm just going to hit on a bunch of different

```timestamp
 1:48
```

topics and give you some uh quick tips along the way so really my goals out of

```timestamp
 1:54
```

this talk uh for you are to give you some exposure to new ideas and then take

```timestamp
 1:59
```

some ideas back to work when you uh go back here at some point uh that you can go Implement

```timestamp
 2:05
```

immediately I really like this quote uh it's from G I think his last name is pronounced Rouch um he's the creator of

```timestamp
 2:12
```

> [!NOTE]
> versel um he had this tweet a while back where he said every system tends towards complexity slow slowness and difficulty
> 
> ```timestamp
>  2:19
> ```
> 
> and saying simple fast and easy to use is a battle that must be fought every day I really like this quote um and it

```timestamp
 2:25
```

> [!NOTE]
> kind of reminds me of another quote that says uh any idiot can build bridge but it takes an engineer to build a bridge
> 
> ```timestamp
>  2:32
> ```
> 
> that barely stands right so like I'm not I'm not a construction engineer but like

```timestamp
 2:37
```

if I just shove enough concrete into something like I'll eventually make a bridge that probably works right but it takes an engineer to build a bridge that

```timestamp
 2:44
```

barely stands and I think uh that's something that I'm really passionate about in software is how do we build

```timestamp
 2:49
```

things uh that's just enough and we don't like over engineer things uh in

```timestamp
 2:55
```

> [!NOTE]
> software so who am I I'm the director of engineering at lean techniques uh we're software Consulting come primarily based

```timestamp
 3:00
```

in Iowa which is kind of like the center of the US that you might fly over when you're going across the coast but we've

```timestamp
 3:06
```

got people roughly 150 people in uh 16 states in the US and we work with like Fortune 100 companies down to startups

```timestamp
 3:13
```

and kind of everything in between help around the Iowa dnet User Group uh Microsoft MVP friend of Redgate and I

```timestamp
 3:19
```

blog as well and again you can C uh these slides up on my blog

```timestamp
 3:25
```

too all right uh so the first one we're going to hit on is fold structure so how

```timestamp
 3:30
```

do we structure the code in our application well by default uh let's say

```timestamp
 3:36
```

you're doing and this really applies to whatever you're doing but let's say you're doing like server side MVC um uh

```timestamp
 3:41
```

server rendered HTML by default if you go like file new project oret new and create a new project you have all these

```timestamp
 3:48
```

folders created for you like you've got controllers you got models you got views uh you've got this ww root folder with

```timestamp
 3:54
```

CSS and JavaScript in it and the problem is every time you need to add a new feature you got to go spray different

```timestamp
 4:00
```

> [!NOTE]
> files across uh all these different folders and this adds a lot of [[navigation friction]] because if you're
> 
> ```timestamp
>  4:06
> ```
> 

kind of just at a glance looking at hey what uh files are are part of this

```timestamp
 4:11
```

feature you end up having to go across to all these different folders and if you have like a models folder or

```timestamp
 4:17
```

something like that there's probably a lot of stuff in it um so it's can be hard at a glance to see kind of what's going where um so you got this scattered

```timestamp
 4:24
```

feature across all these different folders and if you ever have to add EX

```timestamp
 4:30
```

uh or update or delete a feature you have to go touch all these different folders and make these changes so

```timestamp
 4:36
```

> [!NOTE]
> Solution by this is to use [[feature folders]] instead so instead you Group by feature not responsibility so you might
> 
> ```timestamp
>  4:43
> ```
> 

have like a customers folder or an orders folder or something like that instead of controllers models repositories all of those kinds of

```timestamp
 4:49
```

> [!NOTE]
> things and this promotes something called High cohesion which is just a fancy word for saying hey these things
> 
> ```timestamp
>  4:55
> ```
> 

are related and they should remain together so by default let's say you've got like a my profile feature and again[[]]

```timestamp
 5:01
```

let's say you're doing server rendered MVC um you have all these different files sprayed across your application uh

```timestamp
 5:08
```

just to add a new feature and you can imagine as this gets bigger and bigger uh this gets a little bit more untenable

```timestamp
 5:14
```

versus if you do feature folders you can just do something like this where you just got a my profile folder and then you've got like your view your CSS

```timestamp
 5:20
```

JavaScript view model uh and controller right there and actually do this uh in other Stacks too so I've done react off

```timestamp
 5:27
```

and on since like 2017 um and I'll do something like this where I'll have like a my profile component and then the test

```timestamp
 5:33
```

associated with it and like the SAS file um I'll have that all kind of co-located together and then I've also been doing

```timestamp
 5:40
```

blazer off and on as well um so if I have like an alert component I might have the SAS file there and let's say

```timestamp
 5:45
```

I've got like an alert type en say like hey I want to pass like a danger warning or error whatever uh the alert type is

```timestamp
 5:52
```

that model is specific to that component so I'll just collocate that right in the same folder as the component

```timestamp
 5:59
```

now you have some of these people who will be like but what about my layers like what I've got these horizontal

```timestamp
 6:05
```

layers what do I do now well I used to do horizontal CS projects so I used to have like you know the data project the

```timestamp
 6:11
```

business project Services repository common that you just shoved random stuff in uh but now for

```timestamp
 6:19
```

> [!NOTE]
> the most part I just do two projects uh I just have like a core project where most of uh the logic is and then
> 
> ```timestamp
>  6:25
> ```
> 
> whatever the entry point is for my app so it'll be like API or web or console and then of course I'll have like test

```timestamp
 6:31
```

projects associated with those as well um but I'll also slice the folders vertically there too so again I'll have

```timestamp
 6:38
```

like uh my profile or customers or orders or whatever inside of that core project and kind of put things uh that

```timestamp
 6:44
```

are related in there now I will say uh when I say all of this I'm specifically

```timestamp
 6:51
```

targeting when you have like a project that's used just for a single application or a single API or whatever

```timestamp
 6:57
```

> [!NOTE]
> the case is however if you publ like internal Nate packages or even on n.org
> 
> ```timestamp
>  7:02
> ```
> 
> it may make more sense to slice things horizontally and have like a models models project or something in case

```timestamp
 7:08
```

somebody just wants the models uh for let's say getting your responses or things like that so if you do have that

```timestamp
 7:15
```

situation uh then it might make sense to slice horizontally but I find most applications usually have uh don't

```timestamp
 7:21
```

aren't in that situation um so a lot of times I'll just slice vertically so I've got some resources

```timestamp
 7:27
```

here on this um I've got a blog post on how to do this as well as uh that bottom link is to a YouTube video talking about

```timestamp
 7:34
```

[[vertical slice architecture]] but I'll kind of leave you with this last analogy because I still have some people who are

```timestamp
 7:39
```

like H I don't know about this think about the soap in your house or your apartment or wherever you stay right

```timestamp
 7:46
```

like do you just have a closet full of all of your soap like your bath soap your dish soap laundry

```timestamp
 7:51
```

soap uh you know all of those kinds of things no right like most of the time

```timestamp
 7:56
```

your hand soap is by the sink your bath soap is like in the shower uh your

```timestamp
 8:02
```

laundry detergents by the washing machine things like that right so you keep things where they're most likely to

```timestamp
 8:07
```

be used so if you think about that and apply that logic to your code you should keep things that are related together

```timestamp
 8:14
```

and that you're going to use together uh together in the same folder so in case if you're still not convinced or maybe

```timestamp
 8:20
```

> [!NOTE]
> you are convinced and you want to convince some people at work uh that soap analogy I found uh is a good one to

```timestamp
 8:26
```

use all right let's talk about treating warnings as

```timestamp
 8:32
```

errors how many people have ever cracked open a a solution that they've never seen before and built it and then saw

```timestamp
 8:37
```

like hundreds or even thousands of errors or warnings in the compiler output okay like 15 people are brave

```timestamp
 8:46
```

enough to raise their hand the rest of you are just flat out lying that's cool uh because we've all done it or I've

```timestamp
 8:51
```

> [!NOTE]
> I've seen this and so I don't believe in warnings build warnings at all so I think it should either be an error in
> 

```timestamp
 8:58
```

something that I fix or something that I expc explicitly ignore and say yes I know that this is a warning but I'm

```timestamp
 9:04
```

going to choose to opt out of this specific error and so the way you do this is if you just crack open your CSR

```timestamp
 9:10
```

> [!NOTE]
> and just do treat warnings as errors true um that will treat all your warnings as errors now I probably

```timestamp
 9:16
```

wouldn't flip this flag on uh for that project you crack open that has hundreds of errors but maybe new stuff that you

```timestamp
 9:22
```

create um I would start doing uh this right here which as an aside does

```timestamp
 9:27
```

anybody know why some of these say enable and some of these say true that's always bothered me like I

```timestamp
 9:35
```

don't know why some of these are enable and some of them are true um I can't wait for the next one to be like on or

```timestamp
 9:40
```

something like that uh but yeah uh go ahead and flip that treat warnings as errs to true and stop hating your life

```timestamp
 9:47
```

and other people's as well because I find even if you're like oh no I always clean up those warnings like you're

```timestamp
 9:54
```

going to miss one or somebody else will miss one so just flip it on and don't have that happen again

```timestamp
 10:00
```

all right uh so next one we're going to talk about is logging best practices and I have best practices and quotes because

```timestamp
 10:06
```

> [!NOTE]
> I kind of hate the term best practices um I more think of these as like these are just my opinions as of right now um
> 
> ```timestamp
>  10:13
> ```
> 
> but it might change sometime in the future depending on the context but we'll kind of considering this is an

```timestamp
 10:18
```

opinions talk I'll kind of give my general opinions on some of this stuff uh first off use sarog as a logging

```timestamp
 10:25
```

framework um I've used uh nlog and log foret too um but Cog is by far my uh

```timestamp
 10:31
```

favorite so use calog however don't use calog directly like I still see uh some code bases that

```timestamp
 10:38
```

> [!NOTE]
> make this this mistake where they're using serilog directly like the static uh log dot log error and things like that

```timestamp
 10:45
```

um instead you can use the ey loger abstraction that's built into aspd core um so then you only have like 20 or so

```timestamp
 10:51
```

lines of code that's dependent on S log not you know scattered throughout your whole

```timestamp
 10:56
```

> [!NOTE]
> application uh use structure logging too so don't just like when you're doing like logger.log error and then you uh

```timestamp
 11:04
```

you know you might uh pass an account or something like that or who the user is if you do that in a structured way

```timestamp
 11:10
```

versus concatenation then you can actually search for some of these things however just be warned like if you're

```timestamp
 11:15
```

> [!NOTE]
> using Azure log analytics workspaces um those cap at 500 columns and then they

```timestamp
 11:21
```

kind of shove all the rest of the data into uh an additional data uh column so

```timestamp
 11:26
```

just something to be aware of that when you're doing this especially like if you're serializing exceptions and things like that I think that alone will take

```timestamp
 11:33
```

like 200 columns by itself so something to be aware of even if you're not using Azure and you're using other ones a lot

```timestamp
 11:39
```

> [!NOTE]
> of them have limitations uh around that as well as every log should have lots lots of key
> 
> ```timestamp
>  11:45
> ```
> 
> information on it so some common things are like the user ID a correlation ID so you can track where a log went uh
> 

```timestamp
 11:51
```

throughout an entire request like the requesting URL the apps version we'll talk about that in a little bit um but

```timestamp
 11:59
```

> [!NOTE]
> with s log you can just shove that stuff on a log context um so you kind of have it in one spot and then all the other

```timestamp
 12:05
```

consuming logs Downstream will get that so you don't have to explicitly put that on each log so if you're using sah log

```timestamp
 12:11
```

look into the log context um because that will allow you to add some of the stuff in a global faction

```timestamp
 12:18
```

fashion all right uh last thing with logging before we kind of dive into kind

```timestamp
 12:23
```

of the differences between logging metrics and audits is a lot of times when I'm in like a refinement or

```timestamp
 12:29
```

something and we're talking about a particular story somebody might say hey we need to log that and usually that's a

```timestamp
 12:37
```

pretty loaded statement so I want to talk a little bit about logs versus metrics versus Audits and some of the uh

```timestamp
 12:42
```

gotchas with each one of these so when somebody's talking about logs and I find people abuse this too like these should

```timestamp
 12:49
```

> [!NOTE]
> be developer focused things like these should not be things that you're exposing out to uh business people or

```timestamp
 12:55
```

anything like that so some examples like you're logging exception or like let's say you talk to an external API you

```timestamp
 13:02
```

don't control you might want to log like the Response Code things like that but really log should be developer Focus

```timestamp
 13:07
```

> [!NOTE]
> things these shouldn't be things that you're exposing to users or or to uh business people on your side too and I

```timestamp
 13:15
```

> [!NOTE]
> find a lot of people also abuse log levels so I'm going to talk about like what you should be doing for different log levels too um so debug is supposed
> 
> ```timestamp
>  13:22
> ```
> 
> to be like tracing through like step by step like let's say you call like three external apis you might have like a log

```timestamp
 13:29
```

debug statement for each one of those three external apis where you're logging out the status code um the you know

```timestamp
 13:35
```

> [!NOTE]
> maybe the response body things like that but a lot of people choose to use information here when really information
> 
> ```timestamp
>  13:40
> ```
> 
> is supposed to be like a summary of debug log so let's say you call three external apis to like create a new user

```timestamp
 13:46
```

let's say you should probably have a log information at the end that's like hey I created this user um at this time and

```timestamp
 13:52
```

then debug statements that are talking to each one of those apis or uh logging the responses of those apis a lot of

```timestamp
 13:59
```

> [!NOTE]
> people just use information for everything but really that's not really what information's originally intended to be used for and the warning is kind

```timestamp
 14:07
```

of like Hey by itself this isn't a problem but if you see lots of these this could be a problem so like a

```timestamp
 14:12
```

classic example would be things like a user getting locked out of a system like somebody forgets their password all the

```timestamp
 14:17
```

time or whatever the case is so them getting locked out once isn't a problem but let's say they keep getting locked

```timestamp
 14:22
```

out every five minutes uh and there's hundreds of those uh that could be an indicator that something else is going

```timestamp
 14:29
```

on errors uh sure many of you know is used for just logging hey an unhandled

```timestamp
 14:35
```

exception happened and then critical or fatal basically means the app can't boot so let's say you need to go talk to

```timestamp
 14:42
```

Azure key Vault to go grab secrets to connect to a database or whatever the case is and you can't talk to Azure key

```timestamp
 14:47
```

Vault well then your app's probably not going to be able to boot so that's an example of a critical or fatal uh log

```timestamp
 14:53
```

message so again you're probably using information because I find a lot of applications are using information but

```timestamp
 14:59
```

probably meant to use debug um so you can totally uh inside of your app settings files you can say hey

```timestamp
 15:06
```

> [!NOTE]
> for my namespace uh go ahead and log anything debug and then everything else you might want to do like error warning

```timestamp
 15:11
```

> [!NOTE]
> or something like that but really you have to ask yourself like how long does my log store keep

```timestamp
 15:16
```

logs so uh again when we're talking about like when somebody says hey we need to log that information like let's

```timestamp
 15:23
```

say we need a log that hey this user made this change at this time that's really not a good use case for most log

```timestamp
 15:29
```

systems because a lot of log systems might only keep uh the data for like 7 days or 30 days or a year and you might

```timestamp
 15:35
```

> [!NOTE]
> need that information for longer periods of time as well as [[serilog]] under the hood
> 
> ```timestamp
>  15:41
> ```
> 
> uh depending on the sync that you're using uh might not guarantee delivery too so when you call logger.log

```timestamp
 15:47
```

information it's not going to go talk to a Azure log analytics and come back it's going to uh put that on a background

```timestamp
 15:54
```

thread and kind of flush that out uh on a either a Time Cadence or after you get a certain amount of messages so there's

```timestamp
 16:01
```

> [!NOTE]
> some issues with like you don't have some of these guarantees around your logs too so that's why I also say that

```timestamp
 16:08
```

> [!NOTE]
> if you need things like audit records and things like that logs is not the place to do that because there's not a guarantee that that will actually get

```timestamp
 16:16
```

delivered all right uh so quickly hit on metrics uh so really there's two types

```timestamp
 16:21
```

> [!NOTE]
> uh there's application Level metrics like CPU Network memory like Q depth response times timed interactive like
> 
> ```timestamp
>  16:28
> ```
> 
> all those like applicationing type metrics and then there's business type metrics where it's like hey how many
> 
> ```timestamp
>  16:33
> ```
> 
> times did somebody click that button so again you have to kind of have to ask yourself like how long how critical is
> 
> ```timestamp
>  16:39
> ```
> 
> this data how long do I need to keep it around for and does it have any guarantees that I uh might want on it so

```timestamp
 16:46
```

like counting the number of payments or how how much how many payments were made you probably don't want to use something

```timestamp
 16:52
```

like app insights attract some of that because again you might not have guarantees that it matches what's in your real data store um so it may or may

```timestamp
 16:59
```

not be acceptable to miss out on some of that data so again you kind of have to think about like what data store are we

```timestamp
 17:05
```

> [!NOTE]
> using and then finally we've got audits so this is like recording who did what and when in your application so I come

```timestamp
 17:11
```

> [!NOTE]
> from like a HIPPA background where you're dealing with like health insurance and things like that uh so we have to keep that information for like
> 
> ```timestamp
>  17:17
> ```
> 
> seven years to say like Hey Joe Bob viewed Suzie's prescri prescription

```timestamp
 17:23
```

information uh so there's like a legal reason for some of that stuff but you might not even have a legal reason you just might have AA ability like being

```timestamp
 17:29
```

> [!NOTE]
> able to trace who did what and when and in this case losing any data is unacceptable because like the hippo one

```timestamp
 17:35
```

that I just talked about uh we would be legally VI uh liable if we couldn't uh

```timestamp
 17:40
```

prove who did what and when so like that whole like hey I'm just going to shove it in a logger like that might not

```timestamp
 17:45
```

actually end up in your log uh aggregated log system so losing data like that's unacceptable so with this

```timestamp
 17:52
```

> [!NOTE]
> kind of thing this is where you want to use uh some sort of atomic data store like if you're doing SQL Server just

```timestamp
 17:58
```

have a SQL Server audit table or something like that where you're storing it in the same uh store that's being

```timestamp
 18:03
```

audited so you have it in a single transaction you have guarantees that hey that data will end up there so I just

```timestamp
 18:09
```

want to talk about like those differences between logs metrics and audits because I find when somebody says hey we need to log that they usually

```timestamp
 18:16
```

> [!NOTE]
> don't actually mean a log they usually[[]] might mean like an AUD we need to have an audit table or things like that so

```timestamp
 18:21
```

that can be kind of a a loaded term when somebody says hey we need to log

```timestamp
 18:27
```

that all right uh let's move on to the next tip so this is uh using Global

```timestamp
 18:32
```

authorized attribute using a fallback policy so the problem you have by

```timestamp
 18:38
```

default uh let's say you're creating like a new ASP asp.net core app with

```timestamp
 18:44
```

controllers is you have to remember to add this authorized attribute everywhere or you have to remember to inherit like

```timestamp
 18:50
```

let's say you've got some sort of Base controller that's got the authorized attribute you have to remember hey I need to go add this every everywhere and

```timestamp
 18:57
```

if you forget or you don't have like an automated test that proves that all of those controllers do that uh the

```timestamp
 19:03
```

downside is you're open up to the whole wide world which is really bad news so a

```timestamp
 19:08
```

> [!NOTE]
> solution to this is you can use a [[fallback policy]] and a fallback policy is a a policy that gets evaluated if no

```timestamp
 19:15
```

other policy is specified so let's say you've got nothing on a controller or an action in particular it will by default

```timestamp
 19:22
```

> [!NOTE]
> use this fallback policy now if you say hey I've got this authorized attribute with this policy name or I want want to

```timestamp
 19:28
```

do allow Anonymous then this won't take effect at all but by default if you put nothing there it will use this fallback

```timestamp
 19:35
```

policy so the way to add that is just uh override the options for the add authorization call and you can say hey

```timestamp
 19:42
```

> [!NOTE]
> um I'm going to create a new policy in this case there's a few different ways to do it but in this case I'm just going to create a new policy Builder and
> 
> ```timestamp
>  19:48
> ```
> 
> require an authenticated user and do a DOT build but obviously you can put more stuff in there not just an authenticated

```timestamp
 19:54
```

user you could say hey they need to have this permission or this role or what ever the case is um whatever makes sense

```timestamp
 20:01
```

uh for your particular system or this claim uh all those kinds of things but I find a lot of people don't use fallback

```timestamp
 20:07
```

policies enough uh when they're real uh sa uh Savior for when you accidentally

```timestamp
 20:13
```

forget to add authorization to a particular endpoint all right next thing we're

```timestamp
 20:19
```

going to talk about is validation so let's talk about validation here real

```timestamp
 20:25
```

quick so problem is uh We've out of the box with net we've got these things called Data annotations but I find that

```timestamp
 20:32
```

they only really work well for simple scenarios um and anytime you need to make a custom one things get a little

```timestamp
 20:37
```

bit more tricky um as well as they're hard to unit test as well and let's say

```timestamp
 20:43
```

you've got lots of different validation requirements for particular property uh your uh annotations can get tall and you

```timestamp
 20:50
```

have like four or five annotations kind of stacked on top of each other as well as if you're big into solid uh you could

```timestamp
 20:56
```

> [!NOTE]
> argue that the single responsibility principle is violated because you have both your model and your validation

```timestamp
 21:01
```

> [!NOTE]
> combined into one class so an alternative is to use fluent validation

```timestamp
 21:06
```

how many people are using fluent validation here okay like half the room sweet um so

```timestamp
 21:12
```

fluent validation is uh has a fluent interface where you can just kind of chain things on each other as well as

```timestamp
 21:18
```

> [!NOTE]
> the business rules are really easy to read um so I've actually shown this to like a business person who didn't know

```timestamp
 21:24
```

anything about code and said hey here's all the validation rules we have uh for this particular ular uh situation and

```timestamp
 21:31
```

they could actually read what was going on and understand uh which was pretty cool uh they're really easy to test um

```timestamp
 21:37
```

it integrates with model State uh so if you're doing stuff with that currently that'll integrate perfectly fine as of a

```timestamp
 21:43
```

couple days ago it had 372 million downloads so uh it's used by a lot of people and here's the GitHub link uh in

```timestamp
 21:49
```

case you're interested so look at kind of what this looks like so let's say you do like file new project and uh create a

```timestamp
 21:57
```

new uh user uh like Say Hey I want to do individual authentication by default

```timestamp
 22:03
```

you'll get like this register view model which says like hey uh the email is required and it's got an email address

```timestamp
 22:09
```

or it needs to be an email address uh password's required and it's got a max length of this and things like that so

```timestamp
 22:14
```

all those different pieces are different validation logic so if you refactor that to fluent validation what that looks

```timestamp
 22:20
```

like is your register view model gets a lot thinner and then you can inherit from this abstract validator of the type

```timestamp
 22:27
```

of the thing you're validating so in this case the register view model and then you can create these different rules so you can say like hey email's

```timestamp
 22:33
```

not empty and here's the message I'm going to give it and you can like localize all the stuff as well as well

```timestamp
 22:39
```

as set like hey anytime I use not empty use this particular error message you can do that in a global way too um but

```timestamp
 22:45
```

you can start chaining on these different rules so it's really easy again I literally gave this to a business person they were able to read

```timestamp
 22:51
```

uh what was going on uh just fine but you can also do a lot more advanced stuff uh with it as well so in this case

```timestamp
 22:59
```

um this is pretty close to uh code that I've seen before is uh in the US you

```timestamp
 23:06
```

can't have a dependent on your health insurance once they get over 25 so you can do like a more complex thing saying

```timestamp
 23:13
```

like hey for the age uh their age has to be less than 26 uh when the mo when they are uh dependent so you're kind of

```timestamp
 23:19
```

chaining on like not only looking at the age property but you're also looking at the are they ad dependent too um so you

```timestamp
 23:25
```

can do a lot more advanced things where reaching out to different parts of the actual

```timestamp
 23:31
```

model so that is fluent validation which sounds like half the room or so is already using which is

```timestamp
 23:38
```

awesome all right uh this is a pretty quick one uh how many people know what the server header is in asp.net

```timestamp
 23:45
```

core handful maybe like 10 or so um so by default uh as core will add a server

```timestamp
 23:52
```

header uh to your application and this will just say uh Kestrel straight up

```timestamp
 23:58
```

does anybody know why they do this why do they add this server header

```timestamp
 24:04
```

that just says

```timestamp
 24:14
```

krol yep yeah so krro is the underlying HP server but why would they put that header out

```timestamp
 24:22
```

> [!NOTE]
> there there's not a good technical reason it's purely for marketing reasons for so they can say like oh how many

```timestamp
 24:27
```

people are using uh ASP anore basically or how many people are using Kestrel like that's the reason why they do it

```timestamp
 24:35
```

> [!NOTE]
> problem is uh to some Bad actors this exposes what you're running so it is better than NET Framework where they'd

```timestamp
 24:41
```

actually say like here's the exact version of asp.net I'm running so you could like uh Target those specific

```timestamp
 24:46
```

vulnerabilities for that specific version so it is better than that but if uh some hackers trying to get to your

```timestamp
 24:52
```

system and you're saying hey I'm running on Kestrel well now they're like well I don't have to run any Java vulnerabilities anymore I just have to

```timestamp
 24:57
```

focus on the asp.net core ones um so it's kind of like security through obscurity in a way um so if you've got

```timestamp
 25:04
```

an issue they're probably going to find it anyway but it makes it a lot easier for them uh at the end of the day so

```timestamp
 25:09
```

> [!NOTE]
> they can just focus on exploting those known uh vulnerabilities that are out there so it's really add easy to add
> 
> ```timestamp
>  25:15
> ```
> 
> this uh you just do Builder web host use kestral and say add server header false so that's all you do in order to add or

```timestamp
 25:22
```

to sorry remove the Ser server header that gets added by default

```timestamp
 25:29
```

> [!NOTE]
> cool uh so this next one is a little controversial um where I'm saying don't use  [[IOptions]] which is kind of a click

```timestamp
 25:36
```

bity title uh I'll talk about that here in a little bit but the problem with eye

```timestamp
 25:41
```

options uh is it's pretty annoying to use to be honest because let's say you're using eye options everywhere is

```timestamp
 25:48
```

now if you have dependent CS proes you got to add Microsoft extensions options as a dependency um in some of your

```timestamp
 25:55
```

nougat and some of your CS proes as well as if you're testing with eye options uh

```timestamp
 26:00
```

you have to do like options. create um which is kind of annoying to do and I'm a big keyboard shortcut junkie so like I

```timestamp
 26:07
```

mean we got primary Constructors now but I would typically do like CTR Tab and like have it create the Constructor and

```timestamp
 26:13
```

then go to the uh Constructor and type like eye options app settings app settings uh control Dot and have it add

```timestamp
 26:19
```

the field but what really I don't want the field I don't want the eye options I want the dot value so then now I got to

```timestamp
 26:26
```

go like manually type this in and it's just really really annoying to work with

```timestamp
 26:32
```

so the issue or so my solution to this is instead of registering or using i options just register your options class

```timestamp
 26:38
```

directly so you can still config call the configure method like you're used to but then in this case I'm just adding a

```timestamp
 26:44
```

Singleton saying like hey grab me the eye options of app settings and register the dot value so now when I need it

```timestamp
 26:51
```

everywhere I just inject in the app settings I don't actually inject in eye options of app settings you can also do

```timestamp
 26:57
```

this with like eye options Monitor and eye options snapshot which uh support like reloading uh settings on the Fly I

```timestamp
 27:05
```

typically don't use that because I'm not usually reaching out to like app settings. Json file on a production

```timestamp
 27:11
```

server and like live changing it because that's kind of dangerous um but you can technically do this as well you just

```timestamp
 27:16
```

have to do add scoped and then do like eye options uh snapshot uh in that case

```timestamp
 27:21
```

so if you want to support that you can still totally do that with this method so I don't use eye options directly um

```timestamp
 27:27
```

minus these two lines of code right here so now I don't need like that nuga

```timestamp
 27:33
```

package installed in all all my csres and now I don't need uh don't have that

```timestamp
 27:38
```

friction when I'm trying to do keyboard shortcuts uh because all I really care about is getting at that

```timestamp
 27:43
```

value is anybody doing this today something

```timestamp
 27:48
```

similar couple okay cool all

```timestamp
 27:54
```

> [!NOTE]
> right let's talk about creating a version and point so what is a version endpoint so

```timestamp
 28:01
```

you might think to yourself oh is this just like the version uh on versioning an API right like putting V1 or V2 in

```timestamp
 28:09
```

> [!NOTE]
> the URL nope that's not what I'm talking about when I say A version endpoint what I'm talking about is what version of
> 
> ```timestamp
>  28:15
> ```
> 
> your app are you running so usually I'll have like an API verion uh endpoint uh

```timestamp
 28:21
```

to have this and I'll have a format that's similar to this where it's like hey the date that the build happened the build number and then the short get Shaw

```timestamp
 28:28
```

so I have some three pieces of information of what version is actually deployed out

```timestamp
 28:33
```

here um and I generate that version inci and unfortunately uh net versions do not

```timestamp
 28:40
```

support uh having uh that level of uh versioning um so I just store it in a

```timestamp
 28:46
```

file and then read it in through the endpoint and usually cach that uh as well and part of the reason why I use a

```timestamp
 28:52
```

file is if I ever need to download the contents of it um I can go inspect and say like hey look at my version.txt

```timestamp
 28:58
```

file and say like hey what version uh was deployed out here this is really useful when you're creating a cicd

```timestamp
 29:04
```

pipeline too because I don't know about you but every time I create a cicd pipeline it's like red red red red red

```timestamp
 29:10
```

red red red green and then you're like wait but did it actually work like do I actually trust this screen or not and so

```timestamp
 29:16
```

> [!NOTE]
> if you have this version endpoint you can have a little bit more confidence that like hey yes this G sha matches our
> 
> ```timestamp
>  29:22
> ```
> 
> latest commit and so I know that the version that's deployed out there uh is the latest

```timestamp
 29:28
```

> [!NOTE]
> what's also nice is as I mentioned earlier putting the version on every single log um so it's nice to be able to

```timestamp
 29:33
```

say like when you're looking at logs saying like hey what version did this come from so let's say you do like a bug fix for something you can kind of

```timestamp
 29:40
```

> [!NOTE]
> compare like okay uh in the previous version uh we had this error now let me search for this error in our latest

```timestamp
 29:46
```

version and see if any exist or not so the version is also super useful to have on all of your different log statements

```timestamp
 29:52
```

> [!NOTE]
> that you've got that's also why I recommend if you do put it into a file to cach it because it will get read on

```timestamp
 30:00
```

every single log statement so don't go read the file system every single time uh you're uh trying to send a log

```timestamp
 30:08
```

out as a bonus and I feel like this doesn't get talked about enough in Spa development world like a big a big

```timestamp
 30:14
```

problem that kind of gets hidden with Spas is when you do a new deployment and let's say you've got like some sort of

```timestamp
 30:20
```

breaking change like you existing users have already downloaded uh your

```timestamp
 30:25
```

application and are interacting with it and things like that so like if they let's say somebody hits a form and it's

```timestamp
 30:31
```

typing things in and now your API now requires another field but they haven't been notified like hey this new field

```timestamp
 30:37
```

exists in in your UI part of it and they can't like literally complete the form

```timestamp
 30:42
```

> [!NOTE]
> uh now you you've got this version endpoint so you can kind of compare like hey what version do I have locally versus what uh version does the API
> 

```timestamp
 30:48
```

support and then notify saying like hey you got a new version out here do you want to click here to update and download the latest so like there's also

```timestamp
 30:55
```

this use case uh for having uh a version that you're keeping track of in your application as

```timestamp
 31:03
```

well all right let's move on to code

```timestamp
 31:10
```

smells so uh when we're talking about structuring a method what I like to do

```timestamp
 31:15
```

> [!NOTE]
> is I like to always have the [[happy path]] of whatever happens when everything goes right uh at the bottom of a method so I

```timestamp
 31:22
```

don't want to have to look like in the middle of the method of like oh what happens here do I save it to a database do I send an email do I publish a

```timestamp
 31:28
```

message to A Q what happens when everything goes well like I always want the Happy path to be on the bottom so to

```timestamp
 31:34
```

> [!NOTE]
> achieve this use early returns instead of like nested IFL statements we'll take a look at that here in a second um so by

```timestamp
 31:42
```

default like when you create a new project and again this is like creating a new user um this is the default uh

```timestamp
 31:49
```

template code that gets scaffolded out for you so if you look at the center here this is actually the part where

```timestamp
 31:55
```

everything goes well so if the result succeeded then go ahead and log some information uh generate an email

```timestamp
 32:01
```

confirmation send an email and then go ahead and sign them in so it's kind of like in the middle of this method that's

```timestamp
 32:06
```

going on and what's kind of funny too is uh whoever created this template uh put

```timestamp
 32:11
```

a comment here saying if we got this far something bad happened basically which to me is an indicator like if you have

```timestamp
 32:17
```

to put that comment it's not super obvious that something bad happened if you reached uh the end of this method so

```timestamp
 32:25
```

what I would do to refactor this is first I wouldn't have that if if model state is valid check I would invert the

```timestamp
 32:32
```

if and say hey if the model State's not valid go ahead and return the page back out otherwise try and go ahead and

```timestamp
 32:39
```

create them and if that didn't succeed go ahead and add those errors uh to model State and then again return the

```timestamp
 32:45
```

page and then finally there's your happy path at the bottom where again you're logging the person in sending an email

```timestamp
 32:52
```

creating user all that kind of stuff so that's like a super basic refactoring that I would do as part of refactoring

```timestamp
 32:58
```

this method and I think it just leaves a lot cleaner code and it also doesn't violate uh the indentation Proclamation

```timestamp
 33:06
```

> [!NOTE]
> which the indentation Proclamation is the more indented your code is the harder it is to read so if you've got
> 
> ```timestamp
>  33:14
> ```
> 
> like nested ifs NE nested for eaches things like that more than likely the codee's a lot harder to follow um

```timestamp
 33:21
```

judging by how indented your code is and if you Google this uh I made this up so

```timestamp
 33:27
```

uh this is not a thing that exists but I think it's easy to remember the indentation Proclamation there's also

```timestamp
 33:32
```

> [!NOTE]
> like cyclomatic complexity and things like that that kind of measure the same same things but I think it's easy to think about like oh the more indented my

```timestamp
 33:39
```

code is the harder it is to maintain now this does not mean like

```timestamp
 33:44
```

switch to like one space instead of four spaces uh don't do that just to be

```timestamp
 33:51
```

clear so some general code smells um these aren't hard and fast rules just kind of like my warning light goes off

```timestamp
 33:56
```

if I see some of this uh if I see methods that are greater than 20 lines I kind of think about like okay can I

```timestamp
 34:01
```

refactor this a little bit or if I have classes that are greater than 200 lines or heaven forbid if you use a region um

```timestamp
 34:10
```

I really think if you try and use a region our friend clippy should pop up and say like hey I see you're trying to

```timestamp
 34:15
```

use a region did you actually mean to add a new class or a new method instead because most of the time when I've seen

```timestamp
 34:21
```

regions used they should have been uh creating a new method or a new class as

```timestamp
 34:26
```

well so I'm I'm not a big fan of regions uh sorry for anybody I

```timestamp
 34:32
```

offended all right uh so the next thing got like 25 minutes or so here next

```timestamp
 34:39
```

> [!NOTE]
> thing I'm going to talk about real quick is [[HTTP security headers]] which by the way I use chat GPT 4 to generate this image

```timestamp
 34:46
```

and uh you know some of the words don't even make sense it's like Conant security poly and then we've got like

```timestamp
 34:54
```

birds that are also like airplanes or something like that uh so I feel pretty

```timestamp
 34:59
```

good my about my job for at least a little while if this is what AI can do but anyway uh so HP security headers uh

```timestamp
 35:06
```

> [!NOTE]
> what they are is they tell a browser what extra rules to enforce so this can prevent all sorts of different types of

```timestamp
 35:12
```

attacks like man in the middle attacks clickjacking attacks cross site scripting and a bunch of other stuff as

```timestamp
 35:18
```

well however uh you need to be careful when doing HP security headers because

```timestamp
 35:23
```

part of HP security headers is you can say like hey only allow cont content to be loaded for myself so only allow

```timestamp
 35:30
```

myself to load Java or only load JavaScript that comes from uh my URLs

```timestamp
 35:35
```

> [!NOTE]
> right and the problem with that is if you're wrong and you're actually really loading JavaScript from like Google analytics or something it's going to

```timestamp
 35:41
```

block those resources from getting loaded so whenever you're doing HP security headers you just kind of have

```timestamp
 35:47
```

to be careful to make sure you're actually allowing what you should uh what you're application actually does um

```timestamp
 35:53
```

> [!NOTE]
> so just kind of be careful about that as well there's this uh package out there called net
> 
> ```timestamp
>  35:59
> ```
> 
> escapades ASP net core security headers uh so it's written by Andrew Lock which if you've done uh dad development for
> 

```timestamp
 36:06
```

any amount of time you've probably read one of his blog posts um but he maintains this package here to help you

```timestamp
 36:11
```

add them I do have a deep dive on this topic uh that I gave at NDC London in case you're interested um but HP

```timestamp
 36:18
```

> [!NOTE]
> security headers is something I do on every application and honestly if you're getting scanned by like third parties

```timestamp
 36:23
```

and things like that they're going to check for this as well as if you have to like uh past thirdparty audits um some

```timestamp
 36:30
```

thirdparty systems will require you to have security headers on your site

```timestamp
 36:35
```

because it's really easy to check whether or not your uh site has security headers um which if it's public you can

```timestamp
 36:42
```

go to security heads.com and plug in the URL and it'll tell you hey you're you have these security headers or you're

```timestamp
 36:47
```

missing these and things like that but if like this is a whole hourong topic by itself um so if you're interested you

```timestamp
 36:53
```

can check out that uh URL all right um next thing we're going to

```timestamp
 37:00
```

> [!NOTE]
> talk about is build once deploy many times

```timestamp
 37:06
```

> [!NOTE]
> so uh the problem when you don't do this is when you're uh building many times
> 
> ```timestamp
>  37:12
> ```
> 
> and deploying once uh this encourages things like long running branches so if you have environment branches like a Dev

```timestamp
 37:20
```

test production uh type branches I disagree with that philosophy I'm more

```timestamp
 37:25
```

of a only have one branch uh like your main branch and then deploy uh off of

```timestamp
 37:30
```

> [!NOTE]
> that Branch so this encourages something called trunk based development so even if you're using PO requests if you're

```timestamp
 37:36
```

only using a single Branch to deploy from uh that's still considered trunk based development in my view and at

```timestamp
 37:42
```

> [!NOTE]
> Atlassian actually calls gitf flow a legacy workflow as well so if you're trying to convince your team of doing some of this

```timestamp
 37:49
```

stuff if you grab that link and send it to them or if you Google like atlassian gitflow uh that'll show up uh for them

```timestamp
 37:57
```

as well so by having a single main branch where basically you're going to compile have

```timestamp
 38:03
```

> [!NOTE]
> your CI build server and you're going to compile it once and then deploy those dlls to each environment many times uh
> 
> ```timestamp
>  38:10
> ```
> 
> this en encourages continuous integration which is more of the practice than the server so I'm a big
> 

```timestamp
 38:16
```

fan of continuous integration uh is more of a philosophy than like a build server

```timestamp
 38:22
```

> [!NOTE]
> like yes the build server is super important but if you are like on your own world on your own Branch for like
> 
> ```timestamp
>  38:28
> ```
> 
> days or weeks or months at a time you're not really doing continuous integration where you're continuously integrating
> 

```timestamp
 38:34
```

your code with everybody else's code so if you find yourself getting a lot of merge conflicts basically every merge

```timestamp
 38:39
```

conflict is an indicator like oops I didn't integrate my code uh fast enough so I think continuous integration is

```timestamp
 38:45
```

something you do not something that you have so it's more of a practice than anything else and then you're going to have

```timestamp
 38:52
```

> [!NOTE]
> environmental differences so like configuration or secrets and those should live in the environment themselves
> 

```timestamp
 38:57
```

um so again if you have a single like main branch where you're deploying everything from uh then you're not uh

```timestamp
 39:05
```

you don't have like these differences where like oh you have to do some get Fu where it's like oh I did a hot fix to

```timestamp
 39:11
```

like the main branch so then I gota like backported to the dev branch and the test branch and all sorts of other git

```timestamp
 39:16
```

> [!NOTE]
> Shenanigans like if you're just doing trunk-based development I find you don't actually need to know much git at

```timestamp
 39:22
```

all so that's another tip is to build once and deploy many times

```timestamp
 39:28
```

all right the next thing we're going to talk about is validate on build which I don't see happen too

```timestamp
 39:33
```

> [!NOTE]
> often so the reason behind validate on build is singletons can only depend on
> 
> ```timestamp
>  39:39
> ```
> 
> singletons which makes sense if you think about it because if a Singleton depends on a scoped or a transient it

```timestamp
 39:46
```

can't really be a Singleton because you're depending on something get that gets reconstructed uh lots of different times

```timestamp
 39:53
```

so this leads to What's called the captive dependency problem so by default if you accidentally have a

```timestamp
 40:00
```

Singleton that depends on let's say like a DB context or something like that uh aspon core will catch this uh when

```timestamp
 40:06
```

you're running in development but not other environments so let's say you have a custom environment name called like

```timestamp
 40:11
```

local for your local development basically you will never catch this problem until uh you might deploy to Dev

```timestamp
 40:18
```

and if your environment's development there then you would catch this problem so the way to fix this is so

```timestamp
 40:25
```

again the problem here is let's say you have an ad single with a Singleton thing and add scope to the scope thing and

```timestamp
 40:30
```

> [!NOTE]
> then your Singleton thing depends on the scope thing this is what's called a [[captive dependency problem]] where

```timestamp
 40:36
```

> [!NOTE]
> basically that scope thing is effectively a Singleton which is not what you intended for it to be and so

```timestamp
 40:42
```

you'll get this nice little error thing here that says like hey I tried to uh consume a scope service from a Singleton

```timestamp
 40:49
```

uh something bad happened but again this only gets this only gets checked when you're running uh in development so to

```timestamp
 40:55
```

flip this on all the time for every environment basically you just override the used default service provider and

```timestamp
 41:02
```

> [!NOTE]
> say hey [[ValidateOnBuild]] true because ultimately at the end of the day I never want to deploy this out to production
> 
> ```timestamp
>  41:09
> ```
> 

like I understand why the net team did it where they only enforced it in development because they thought of this after the fact and they didn't want to

```timestamp
 41:15
```

break existing applications however you might see weird Behavior if your scoped or transient Service never actually uh

```timestamp
 41:23
```

gets disposed of and recreated right so this all enforce it uh to happen in

```timestamp
 41:28
```

every environment how many people were doing this today or knew that this option

```timestamp
 41:34
```

existed F this is a pretty obscure one okay nobody

```timestamp
 41:40
```

cool all right um let's talk about automated tests here real quick um so

```timestamp
 41:46
```

hopefully this isn't a debate uh but you should be writing automated tests uh there's lots of different value uh ads

```timestamp
 41:53
```

from doing this it's proven to be faster long term with multiple studies you can can catch uh regression uh regression uh

```timestamp
 42:00
```

failures sooner as well as if a test is hard to write it might expose that your

```timestamp
 42:05
```

uh design is wrong as well um I don't really care what you use uh whether it's xunit or nunit just not

```timestamp
 42:12
```

> [!NOTE]
> Ms test uh because ironically like theet team doesn't even use Ms test uh they use xunit which is kind of funny uh to

```timestamp
 42:20
```

me um but one problem I have with some of these uh testing Frameworks is out of

```timestamp
 42:26
```

the box the assertion libraries kind of annoy me where you have like assert do equal and then it's like value value I'm

```timestamp
 42:32
```

like uh I can't remember which is which um now xunit does ship analyzers to help

```timestamp
 42:37
```

you remember that hey expected is the first one and actual is the second one however um I find like sometimes I'll

```timestamp
 42:44
```

screwed up and like you have some funky assertion failures if you flip them too so I like using fluent assertions uh

```timestamp
 42:51
```

which Dennis doen who created this is I think given a talk right now as well um

```timestamp
 42:56
```

but he's here and so what that looks like is it adds a should extension method to object so it'll just be

```timestamp
 43:03
```

result. should dob zero uh versus assert equal Zer comma result which I think

```timestamp
 43:08
```

> [!NOTE]
> doesn't read As Nice was curious how many people are using [[FluentAssertions]] today or shley any of by using shley yep

```timestamp
 43:16
```

that shle is perfectly fine too so i' say probably like half the room or so um the fluent assertions also has like the

```timestamp
 43:22
```

should be equivalent to which does like a deep value comparison of different things and you can actually compare like a customer object with like a customer

```timestamp
 43:29
```

dto and kind of match up those things uh which is pretty cool as of a couple days ago I had over 300 million downloads um

```timestamp
 43:36
```

so it's used by a lot of people and again if you guys are using shle uh it's perfectly fine

```timestamp
 43:42
```

too um but to talk real quick about a tip when it comes to testing I kind of

```timestamp
 43:48
```

> [!NOTE]
> want to go back to the 1800s and this guy named [[Anton Chekhov]] who is a Russian

```timestamp
 43:54
```

playwright and I swear I'll tie this back to testing here in a sec but he had this quote where he said remove

```timestamp
 44:00
```

> [!NOTE]
> everything that has no relevance to the story so basically if a rifle is hanging on a wall uh in act number one it should
> 
> ```timestamp
>  44:08
> ```
> 
> get fired in a later act otherwise it shouldn't have been hanging on the wall in the first place so really everything
> 
> ```timestamp
>  44:13
> ```
> 
> should have a purpose at the end of the day which uh yeah if you're a Game of Thrones fan uh you know that doesn't

```timestamp
 44:19
```

always actually happen that where everything actually has a purpose however we can apply this to our uh

```timestamp
 44:25
```

testing as well so if you look at this test here this is a pretty simple one of hey just checking to make sure uh when

```timestamp
 44:32
```

last name's empty that we get back an error message so really the only relevant part of this is the last name

```timestamp
 44:39
```

here and everything else is just kind of extra fluff and so a way to refactor this is you could say like hey I want to

```timestamp
 44:45
```

create a valid customer like you have a factory or something or private method and then go ahead and tweak the last

```timestamp
 44:50
```

name to be empty so there's a little less verocity there but you can go further so this is usually what I do is

```timestamp
 44:56
```

I'll I'll create like a field for this and have the uh customer get initialized to a valid value and then I'm just

```timestamp
 45:03
```

tweaking that sad path afterwards uh so again you're kind of

```timestamp
 45:08
```

applying check offs gun where everything should be relevant to the story at the end of the day so every every line of code should be relevant to your test so

```timestamp
 45:14
```

if you find you've got a lot of setup you might consider moving some of that setup up to the Constructor like your

```timestamp
 45:20
```

setup or before each or whatever the case is so this concept applies to any any text stack but you notice I'm also

```timestamp
 45:27
```

KN up a customer validator here so like let's say I've got some dependencies that end up here too now I'll have to

```timestamp
 45:32
```

fix all of these tests and I'm repeating myself in each one of those tests as well so usually I'll rip that out into

```timestamp
 45:38
```

the Constructor as well and new that up in one spot as well so if we look at kind of the comparison of the before and

```timestamp
 45:43
```

after um applying check Ops gun to testing you notice like about half lines of code are gone uh so again you should

```timestamp
 45:50
```

consider like hey is this actually relevant to the test I'm doing so like let's say you're setting up a mock or

```timestamp
 45:55
```

> [!NOTE]
> something like that and you're setting up the exact same values in each one of your tests uh shove that up to the
> 
> ```timestamp
>  46:00
> ```
> 
> Constructor because it's actually not relevant to your particular situation so again when you're writing these tests uh

```timestamp
 46:07
```

think of check off's gun and think like hey is this actually relevant to this particular test because everything in

```timestamp
 46:13
```

your rrange step should be relevant to that particular test all right about 14 minutes left I

```timestamp
 46:20
```

> [!NOTE]
> we bang through some of these uh how many people are using Central package management

```timestamp
 46:25
```

today only only a handful that has been my experience as well not enough people know about

```timestamp
 46:30
```

this so the problem that Central package management solves is let's say you've got the same package in multiple

```timestamp
 46:36
```

projects across your entire solution where you've got like nty framework in multiple spots or let's say you've got like uh multiple test projects you've

```timestamp
 46:42
```

> [!NOTE]
> got xunit multiple spots or n substitute or Mach Q one of those um it's pretty annoying to keep some of these versions
> 
> ```timestamp
>  46:49
> ```
> 
> in sync and especially when you're doing like a net upgrade and you're like oh I need to move from uh you know version

```timestamp
 46:54
```

seven to version eight uh that uh we had to do recently and now I got to go update uh these in all these different

```timestamp
 47:01
```

spots it can be really annoying to keep those versions in sync and like I mentioned earlier especially test projects but like like I said too uh I

```timestamp
 47:08
```

find most people I talk to maybe like one out of 10 maybe actually know that there's a solution to this problem

```timestamp
 47:15
```

called Central package management so this actually got added in doet 6 so back in

```timestamp
 47:20
```

> [!NOTE]
> 2022 um and basically what you do is you can create a [[directory.packages.props]] at the root and Define all of your
> 
> ```timestamp
>  47:26
> ```
> 

packages and all your versions there as well you can technically not put it at the root you can put it like lower too

```timestamp
 47:32
```

if you have like certain projects that you want kind of want to group together as long basically it'll kind of Traverse up your tree until it finds one of these

```timestamp
 47:39
```

and then use that one so it'll just use one uh at the top but I find most applications you just need one at the

```timestamp
 47:44
```

root and then basically what this looks like is then you can just omit the version attribute in the package reference which we'll take a look at

```timestamp
 47:50
```

demo here in a sec um and then all packages uh will'll have to emit that

```timestamp
 47:56
```

version attrib so you can't say oh I only want to manage this package uh using Central package management you

```timestamp
 48:02
```

> [!NOTE]
> kind of have to Define all of them up front you can technically override this and say version override attribute and

```timestamp
 48:08
```

say like hey nope I know my central package man management says it should be this version but I want to override it and use this particular version you can

```timestamp
 48:15
```

technically use a version override attribute uh to do that so what that looks like is in your D directory

```timestamp
 48:21
```

packages props uh you have this property group thing and say Hey I want to manage package version centrally true again

```timestamp
 48:27
```

we've got true back like we were talking about earlier some of these are enabled some of these are true I have no clue why but this one is true and then you

```timestamp
 48:34
```

can say hey I've got an item group and here's all the different packages I'm um going to reference here so I only have

```timestamp
 48:40
```

one with xunit but you can imagine you've got a dozens of projects within here and then in your CS proes you just

```timestamp
 48:47
```

say package reference include xunit and you emit the version entirely and I'll just implicitly use uh the one you've

```timestamp
 48:53
```

defined in your directory packages props again you could put version override there and override that version uh if

```timestamp
 48:59
```

you so choose okay now we're kind of on to the bonus topics so let's talk about some

```timestamp
 49:07
```

bonus tips here the last 10 minutes so if you've ever wondered what SQL queries EF is making under the hood

```timestamp
 49:15
```

> [!NOTE]
> it's pretty easy to find out you can just switch the log level of [[Microsoft.EntityFrameworkCore.Database.Command]] to

```timestamp
 49:21
```

information and boom you will get that information however don't do this for any any environment other than local

```timestamp
 49:28
```

because in production you don't really need to see like all the SQL queries that are getting generated more than likely like you probably just need this

```timestamp
 49:36
```

for local Dev like when you hit this mend point it returns this and kind of see what's being generated so that looks like it's kind

```timestamp
 49:43
```

of hard to see um but in your app set Json you just do a logging log level and

```timestamp
 49:48
```

say hey I'm targeting this particular namespace and you framewor core database command information and then down below

```timestamp
 49:54
```

here you can see like there's like an insert state and select statement you can actually see what SQL queries get

```timestamp
 50:00
```

generated so if you ever have a slow running query or you're wondering what it gets generated under the hood or a

```timestamp
 50:05
```

DBA is bothering you because they say oh EF can't be performant you can literally flip this on and say nope here's my SQL

```timestamp
 50:12
```

query uh what would you do different and the answer is probably nothing in my experience so uh that is uh logging out

```timestamp
 50:20
```

any framework uh queries um so some more bonus tips uh cicd Pipelines you should

```timestamp
 50:27
```

be doing them uh if you're not doing them today uh it's really usually not

```timestamp
 50:32
```

that hard to do at least for sure the CI part of it but you should be creating cicd pipelines do automated builds and

```timestamp
 50:38
```

deployments but something I don't see a lot of people do so when people say CD there's kind of that's kind of a loaded

```timestamp
 50:44
```

term because it can mean continuous delivery which means basically I click a button to deploy to production or you

```timestamp
 50:50
```

doing continuous deployment which basically means as long as the build's green it's going to deploy all the way

```timestamp
 50:56
```

> [!NOTE]
> to production and so we try and promote continuous deployment as much as possible and what

```timestamp
 51:01
```

I want you to think about because I find nine out of 10 companies aren't doing this is think about how you get to

```timestamp
 51:08
```

> [!NOTE]
> confident green and what I mean by confident green is when the build pipeline's green why aren't you
> 
> ```timestamp
>  51:14
> ```
> 
> confident to deploy to production and I find a lot of times it's like oh well we've got this one thing I want to test

```timestamp
 51:20
```

manually or you know uh whatever the case is and you can kind of go through

```timestamp
 51:26
```

this Loop of like oh I've got this one thing I want to test manually it's like cool write an automated test for that now it's your reason for why you don't

```timestamp
 51:33
```

want to deploy to production and kind of keep on that continuous loop and usually the answer is write more tests to give

```timestamp
 51:38
```

you that confidence that everything works adding health checks uh zero downtime deployments all of that kind of

```timestamp
 51:44
```

stuff also feeds into a lot of this but some people will be like oh what do I do

```timestamp
 51:50
```

though like uh you decid to use trunk based development but like how do I make sure these features that are kind of

```timestamp
 51:55
```

inlight don't show up for users and uh the solution to that is using something

```timestamp
 52:01
```

> [!NOTE]
> called [[feature toggles]] which is essentially just a fancy word for an if statement so you can say like hey when
> 
> ```timestamp
>  52:06
> ```
> 

I'm in uh production go ahead and don't turn this feature on or when I'm uh when

```timestamp
 52:11
```

I'm in a lower environment turn this feature uh turn this feature on whatever the case is or for this particular user

```timestamp
 52:17
```

these particular groups of people you can Target all sorts of different things and so if you're using feature toggles

```timestamp
 52:22
```

religiously and that's kind of baked into the mindset of your team uh you can get some of these things where you're

```timestamp
 52:27
```

deploying continuously uh all the time and actually have a family member who works at Amazon and Amazon forces them

```timestamp
 52:34
```

to do continuous deployment so if the build is green it's going to prod so it kind of forces you to write really good

```timestamp
 52:40
```

> [!NOTE]
> tests and also usually forces you to have conversations with users sooner um both of which in my opinion are very

```timestamp
 52:47
```

> [!NOTE]
> good things also work in small batches uh so try and figure out like hey can I split

```timestamp
 52:53
```

> [!NOTE]
> this up into multiple uh deliverables uh versus like showing up with a PR with

```timestamp
 52:58
```

like 200 files change because nobody likes that again you should be deploying frequently ideally daily or even more

```timestamp
 53:05
```

frequently um and this might be controversial to some people but let's say you've got a backend API like a

```timestamp
 53:12
```

backend for front end scenario where that API is specific to a particular front end uh don't split that into

```timestamp
 53:18
```

separate repos and have like a front-end repo and then a backend repo because often times you like have to make

```timestamp
 53:24
```

changes to both and then you submit two PRS and kind of like all right let's merge them one two 3 Let's merge them

```timestamp
 53:29
```

both at the same time and you just run into this weird scenario so instead I'd rather have it in the same repo have a

```timestamp
 53:34
```

single PR kind of see everything at a glance and then it can be part of the same pipeline as well also if you got

```timestamp
 53:41
```

> [!NOTE]
> infrastructure as code also don't put that in the same in another repo unless you have infrastructure that's like
> 
> ```timestamp
>  53:46
> ```
> 
> shared like networking or things like that but if it's specific to your application don't put it in the same in

```timestamp
 53:52
```

another repo put it in the same repo for all the reasons I just mentioned you can tie it to same cicd pipeline um and all

```timestamp
 53:58
```

of that kind of stuff so uh some real benefits of doing

```timestamp
 54:04
```

some of these practices uh one company we work with uh went from deploying to prod 12 times a year and about half the

```timestamp
 54:11
```

time they rolled back those deployments to we started deploying over 2,000 times in a year and we roll back less than 1%

```timestamp
 54:18
```

> [!NOTE]
> of those and again a lot of this comes down to having confidence writing tests
> 
> ```timestamp
>  54:24
> ```
> 
> cscd pipelines uh checks all that kind of stuff um as well as just writing

```timestamp
 54:30
```

> [!NOTE]
> maintainable code that's easy for people to extend because you can't deploy 2,000 times a year if you're dealing with a big Legacy uh ball of mud

```timestamp
 54:38
```

usually and at the end of the day uh the only reason why any of us in this room are employed is because we deliver value

```timestamp
 54:44
```

> [!NOTE]
> to users so at the end of the day this gets more uh faster uh value to users and more reliably so we're not rolling

```timestamp
 54:50
```

back uh nearly as much um so with that we got about five

```timestamp
 54:56
```

minutes for any questions um again I have posted these slides up on my blog uh just Scots sober.com and I left it

```timestamp
 55:02
```

intentionally detailed so you knew kind of the gist of what I was saying uh in case so you don't have to go rewatch the

```timestamp
 55:08
```

video

```timestamp
 55:16
```

yeah

```timestamp
 55:22
```

yep oh okay good good call uh so is more of a statement then question is more why do

```timestamp
 55:29
```

some have true and some have enable uh so the enable ones have more options than just an onoff default now that you

```timestamp
 55:34
```

say that I I do remember seeing seeing that uh in some cases but usually I'm just pure binary but yeah makes sense go

```timestamp
 55:40
```

call out any other questions

```timestamp
 55:51
```

yeah yep uh so yeah just repeat the question validate on build does that validate anything else uh just does the

```timestamp
 55:57
```

captive dependency problem so making sure your Singleton don't depend on Scopes and transients so it's kind of a

```timestamp
 56:03
```

> [!NOTE]
> a bad name in my opinion because you might think validate on build means like when you build your project but it actually means when it builds like uh
> 
> ```timestamp
>  56:11
> ```
> 
> the ioc container basically um so yeah it just validates

```timestamp
 56:18
```

that any other

```timestamp
 56:24
```

questions what did people not agree with

```timestamp
 56:30
```

nobody wants to be brave

```timestamp
 56:39
```

yeah um what tools do you suggest for um the other two yeah so question uh know

```timestamp
 56:47
```

we only got part of the question a question was like we talked about logs metrics audits I talked about s log using for logs but what do I use for

```timestamp
 56:53
```

metrics and audits um so the audits one I use whatever database I'm using so if it's postgress or SQL Server like I'll

```timestamp
 57:00
```

just uh use that particular database for those for metrics um it's kind of a

```timestamp
 57:06
```

loaded question so for like application style metrics I'll lean on something like uh New Relic or Azure app insights

```timestamp
 57:12
```

to give me like response times and CPU and memory and things like that when it comes to actual like business metrics

```timestamp
 57:18
```

usually I end up using the same data store uh that I'm using so like SQL server postgress or whatever the case is

```timestamp
 57:24
```

um if I need to like if the if the metric is actually valuable to the business long term and I need to like

```timestamp
 57:30
```

Trend it over like a year or whatever the case is

```timestamp
 57:35
```

so another

```timestamp
 57:41
```

question yep yep so yeah the question was do you put code in uh do you put

```timestamp
 57:46
```

code that says like hey save this metric and yep yep that's what I would do

```timestamp
 57:52
```

yeah uh just building on what you said about uh auditing with SQL Server um are

```timestamp
 57:59
```

you talking about making bespoke tables or are you talking about like temporal tables yes uh I guess it kind of depends

```timestamp
 58:09
```

um so I know like EF fairly recently got support for temporal tables um you could write your own stuff too um I've

```timestamp
 58:17
```

traditionally used more audit bespoke tables um I've only used temporal tables once um but I mean whatever gets the job

```timestamp
 58:24
```

done and the team agrees with is perfectly fine by

```timestamp
 58:32
```

me any other questions or disagreements we haven't had

```timestamp
 58:37
```

disagreement yet that kind of makes me sad

```timestamp
 58:45
```

yeah the um only having a single branch in git like I'm not going to argue with

```timestamp
 58:50
```

you but that was the one that raised my eyebrows the most yep so I was more of a surprise though

```timestamp
 58:57
```

disagreement yep thanks for being brave the the so sole Brave one who's going to uh bring

```timestamp
 59:05
```

some something up it definitely is a big shift going from environment branches or

```timestamp
 59:11
```

get flow to something else for sure even continuous deployment when I first heard about it I was like how can this

```timestamp
 59:17
```

possibly work uh how is this safe to do and then once I started doing it I find I didn't want to get rid of it too so a

```timestamp
 59:24
```

tip to when you're creating a new project is like put that stuff in early and I find you don't want to take it out

```timestamp
 59:30
```

later once you once you actually start getting users um because honestly what's the harm of going to proda uh when you

```timestamp
 59:36
```

don't have users probably very little just don't expose your database

```timestamp
 59:42
```

with on off C be out

```timestamp
 59:47
```

[Music] yeah so question was why s log over nlog

```timestamp
 59:54
```

or log foret um um to be honest I I just like the API a little bit better with

```timestamp
 1:00:00
```

Sarah log um my experience with log foret hasn't been for a while but I have

```timestamp
 1:00:05
```

uh memories of like changing XML XML files to do things and I like sahog you

```timestamp
 1:00:11
```

can configure it through code um log from net might be able to do that now I know nlog can um just I find the sarog

```timestamp
 1:00:18
```

community is more vibrant too um so I know there's like uh an nlog I hit this

```timestamp
 1:00:24
```

at a client they're using nlog and they need to call a bespoke HPM point and the

```timestamp
 1:00:29
```

HP Target they were using uh was like an unmaintained package that was two years old that had like a socket exhaustion

```timestamp
 1:00:36
```

problem uh the reason why HP client Factory exists and in Sarah log I haven't had that experience where it

```timestamp
 1:00:42
```

seems like a lot of the packages are maintaining the community around it so that could be because there's technically kind of a company around it

```timestamp
 1:00:48
```

uh as well but that's one of the reasons why one of a few reasons why I like s log

```timestamp
 1:01:00
```

go for it got a disagreement

```timestamp
 1:01:16
```

yed yep sorry uh so yeah why add in a

```timestamp
 1:01:23
```

global fallback requiring an authorized user user if allow if allow uh Anonymous

```timestamp
 1:01:29
```

is opt in instead of implicit are you talking for minimal apis or you talking

```timestamp
 1:01:36
```

for uh uh even MVC okay in yeah for the

```timestamp
 1:01:41
```

last couple of releases of aspnet core um you have to explicitly say that you

```timestamp
 1:01:46
```

want to allow Anonymous on say a given action or controller so like requiring

```timestamp
 1:01:53
```

authorization is is implicit the whole way through so why

```timestamp
 1:01:58
```

have a global fallback um I guess in that case like let's say let's say you have like a

```timestamp
 1:02:04
```

claim or custom claim or something that you want to be enforced um that could be a reason um or certain role or something

```timestamp
 1:02:10
```

like that but yep that could be a reason all right I know we're like two minutes

```timestamp
 1:02:16
```

over um so thanks everybody for coming and again if you want the slides uh they're up on my blog so thanks

```timestamp
 1:02:21
```

everybody