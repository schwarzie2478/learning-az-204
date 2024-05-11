---
status: planted
dg-publish: true
tags:
  - content/video/youtube
creation_date: 2024-05-09 21:41
definition: What you can learn from an open source project with 300 million downloads
ms-learn-url: undefined
url: https://www.youtube.com/watch?v=EXqV7va2jLI
author: Dennis Doomen
---



| MetaData |                                        |
| -------- | -------------------------------------- |
| Author   | `VIEW[{author}][text(renderMarkdown)]` |
| Homesite | `VIEW[{url}][text(renderMarkdown)]`    |

- [ ] Review What you can learn from an open source project with 300 million downloads

## Video
`$= "Made by [[" + dv.current().author+"]]"`
Open in sideplayer:
```timestamp-url 
 https://www.youtube.com/watch?v=EXqV7va2jLI
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

Transcript
```timestamp 
 01:41
 ```


```timestamp 
 0:05
 ```
um welcome yeah I'm going to be talking about a small open source project um you know the cool thing is
```timestamp 
 0:13
 ```
I've been lucky to be working on an open source project that was reasonably um
```timestamp 
 0:18
 ```
successful because it's also a nice playground you can actually try new things and what's even more cooler is
```timestamp 
 0:24
 ```
that people actually contribute to a popular open source project and you can learn from that as well you know people
```timestamp 
 0:29
 ```
into new technology new tools new features in C that you probably didn't know of and so for me it's like one big
```timestamp 
 0:36
 ```
playground and I'm a consultant so I use that information as well that knowledge as well to uh to help my
```timestamp 
 0:43
 ```
clients so uh the funny thing is with the when you put numbers in a slide like this it will actually increase every
```timestamp 
 0:49
 ```
time you do the talk like it was 250 million last year now it's a 320 million I saw this morning 20 323 I have no clue
```timestamp 
 0:57
 ```
doesn't matter I'm Dennis Duman I'm from the Netherlands you can probably hear that um I'm actually I I'd like to call
```timestamp 
 1:05
 ```
myself a Hands-On architect or a coding architect I've been doing that for 27 years um I basically help my clients
```timestamp 
 1:13
 ```
modernize everything that has to do with soft development so I look at tools architecture uh uh uh uh practices tdd
```timestamp 
 1:21
 ```
event sourcing stuff like that I care about and I basically look at the whole thing from the beginning to the end uh
```timestamp 
 1:27
 ```
usually as as part of a path towards continuous deployment I'm also a Microsoft MVP since a year no clue how I
```timestamp 
 1:34
 ```
got that I have no clue how to stay that uh but it's worth mentioning yeah that's how it work it's just it's a kind of a
```timestamp 
 1:40
 ```
marketing thing but I'm happy with it yeah I'm happy with it um my Twitter Handler is D Duman I call myself The
```timestamp 
 1:47
 ```

> [!NOTE]
> [[Continuous improver]] so I have a couple of things I have a blog post nobody cares about I have actually published C

```timestamp 
 1:52
 ```

> [!NOTE]
> [[CSharp Coding Guidelines|C# coding guidelines]] for the last 20 years you can take them you can Fork them you can change that for your own company

```timestamp 
 1:58
 ```

> [!NOTE]
> which is useful if you care about this kind of stuff uh and somebody else actually created a nice [[Roslyn]] analyzer

```timestamp 
 2:03
 ```
that does that for you I have worked in event sourcing projects I built my own libraries or Frameworks for that I
```timestamp 
 2:09
 ```
maintain this one and maybe and this is kind of the topic who who knows this one
```timestamp 
 2:14
 ```
who's using this who's not using it why not no no just kidding uh this is the
```timestamp 
 2:21
 ```
project that I'm talking about okay oh and if you create a cool picture of the presentation or very sad picture or you
```timestamp 
 2:28
 ```
have something very I don't know profound to say about this presentation you can actually win a
```timestamp 
 2:33
 ```
one-year license for jet brains Ryder um yeah okay and by the way these are all my handles where you can find me and
```timestamp 
 2:40
 ```
talk to me or make fun of me so about the project yeah what is it I probably
```timestamp 
 2:45
 ```
don't know if to explain it's a stupid little library that is supposedly makes your unit test more readable fluent
```timestamp 
 2:51
 ```
there's a couple of things you can use it to verify that a particular action throws an exception or not H it can
```timestamp 
 2:57
 ```
actually do kinds of reflection based you know the dependency tracking uh you can actually compare entire object
```timestamp 
 3:03
 ```
graphs together uh all this stuff is there and again why is it popular is it successful I don't know actually um I
```timestamp 
 3:10
 ```
only realized that when people at some point started to create a plural side training about it and I thought why on
```timestamp 
 3:15
 ```
Earth would you create a PL side training about a unit test Library uh doesn't get it uh but yeah it it it's
```timestamp 
 3:22
 ```
increasing and every time I do this talk I have to update the numbers that's the thing U this is actually the most
```timestamp 
 3:27
 ```
important or the most let's say found point in time when I discovered that Microsoft is actually using it I mean as
```timestamp 
 3:34
 ```
an open source developer it's all free time you you know you spend your free evenings on this and that's pretty cool
```timestamp 
 3:39
 ```
actually and it's used a lot of different repositories why is it I can
```timestamp 
 3:45
 ```
come up with all kinds of cool terms wait wait uh but I have no clue I honestly have no clue this is I think
```timestamp 
 3:51
 ```
why it seems to be successful but I doesn't matter doesn't matter if you know it you're already using it and I
```timestamp 
 3:57
 ```
don't have to explain that so um yeah let's let's just see how it
```timestamp 
 4:03
 ```
starts and I'll take you from the Inception of an idea or a feature request all the way to the release cycle
```timestamp 
 4:08
 ```
and everything we do in between um I'm also a big proponent of GitHub by the way so a lot of stuff is GitHub related
```timestamp 
 4:15
 ```
but you'll figure it out okay so it all starts like okay where is the repository
```timestamp 
 4:21
 ```
uh so we have an organization called [[FluentAssertions]] which is technically just a giup thing there's no money or anything I mean I don't earn any scent
```timestamp 
 4:28
 ```
from this whole project other than I'm here which is cool because this conference has has an awesome location
```timestamp 
 4:34
 ```
and there you find the main project and there's a bunch of other projects which are maintained by other people uh which
```timestamp 
 4:40
 ```
we kind of said like okay you can be part of the organization because they're semiofficial but I don't maintain it not
```timestamp 
 4:45
 ```
neither does my does my colleague yonas do that I have one other guy that's helping me and I've met him twice I
```timestamp 
 4:52
 ```
think one on video One in live and NDC Oslo last year this is where it starts so then people can go there and then you
```timestamp 
 4:58
 ```
know create an issue so the interesting thing is we don't want people to create issues like just like you don't want to
```timestamp 
 5:03
 ```
have that have that uh done in your project you want to have some structure in that issue create you want to
```timestamp 
 5:08
 ```

> [!NOTE]
> understand what's going on so what's really cool is that in github you can actually use templates for issues
> so this is what

```timestamp 
 5:14
 ```
you get if you create if you create an issue if you want to create an issue you you have to choose like is it a bug
```timestamp 
 5:19
 ```
report is it an API suggestion is it a feature or something like that and also references to all kinds of stuff like
```timestamp 
 5:26
 ```
the documentation is here uh ask questions on stack flow nobody's using stack Overflow these days we have ai now
```timestamp 
 5:32
 ```
right unfortunately nobody actually clicks on the sponsor fluent insertion set thing that's a shame but anyway and
```timestamp 
 5:40
 ```
that's actually pretty easy to do in getup so if you're already using giup for your internal projects you can also do that which streams line streamlines
```timestamp 
 5:46
 ```
the whole process the thing is if somebody proposes a feature yeah fluent
```timestamp 
 5:52
 ```
suron is almost like a real project you actually have to think about the impact of that new feature of that new API you
```timestamp 
 5:58
 ```

> [!NOTE]
> need to think about consistency you need to think like do I even want this API and initially we actually had

```timestamp 
 6:04
 ```
people you know spending a lot of time creating a pool request which a nice big feature and then we looked at like yeah
```timestamp 
 6:10
 ```
but we don't want this actually we don't want this and we don't we have actually accepted the pool request that we should
```timestamp 
 6:16
 ```
never have accepted because it introduced so much work or so much maintenance for us but the person behind
```timestamp 
 6:22
 ```
that spends so much time on it you feel almost sorry about that well that is something we try to streamline by having
```timestamp 
 6:27
 ```
this approval process so if somebody proposes something we put a label on it like API suggestion the bottom one and
```timestamp 
 6:33
 ```
then we have a discussion about that and at the end we may either reject it or we need to have some follow-up discussion
```timestamp 
 6:40
 ```
about it until we prove it really like a backlog process where your PO also proposes something same thing it's just
```timestamp 
 6:47
 ```
the giup is becoming better and better at this at and streamlining this process um and then yeah you can see like these
```timestamp 
 6:53
 ```
are a couple of examples where and and actually what we also ask people don't actually create a pool request until
```timestamp 
 6:59
 ```
we've approved the proposal so to save you from some time again some people ignore it we just ignore them as well um
```timestamp 
 7:08
 ```
then design challenges yeah you know the the libraries it was very extensible and I guess most systems most computer
```timestamp 
 7:15
 ```

> [!NOTE]
> systems that you build have some sense of extensibility unless it's a one-off thing and building extensibility is very complicated because you kind of have to predict the future

like how you going to be able to extend that you know
```timestamp 
 7:26
 ```
developers law of abstractions and you know unnecessary comp complexity uh no of course it's it's necessary complexity
```timestamp 
 7:33
 ```
it's not and uh you have to take to account so when somebody proposes something we have to take into account things like do we want this to be in the
```timestamp 
 7:39
 ```
main library or do we may have something does this have to be an extension I just mentioned data sets is anybody still
```timestamp 
 7:45
 ```
using data sets in 2024 no see oh somebody just like this no so we ac
```timestamp 
 7:52
 ```
accepted a huge pool request that added data set support and now we have to rip it out again um and that is something
```timestamp 
 7:58
 ```

> [!NOTE]
> that you have to think about breaking changes is very easy to introduce breaking changes I guess if your

```timestamp 
 8:04
 ```
organization is sufficiently Big you're also building all kinds of reusable libraries or packages or components so
```timestamp 
 8:10
 ```
that you can actually you know uh prevent developers from doing everything twice or a third few times building
```timestamp 
 8:16
 ```
those things is also a a form of extensibility and thinking about Breaking Chains is hard especially if
```timestamp 
 8:23
 ```
you made the wrong choice now you want to fix that that introduce the Breaking Chains now what so we have to think
```timestamp 
 8:29
 ```
about it consistency like this a collection should all satisfy and you can pass in a
```timestamp 
 8:35
 ```
predicate what should happen if the collection is empty does it mean it's actually okay or should it throw an
```timestamp 
 8:41
 ```
exception that's stuff that you have to think of the really you know takes a lot of energy to think about that and again
```timestamp 
 8:46
 ```
it's a side job so if it's a full-time job records tuples how do you deal with that 

> [!NOTE]
> you know C# changes all the time

```timestamp 
 8:53
 ```
async do we want to async post effect on our async stuff or not that can also become almost like a religious debate
```timestamp 
 9:01
 ```
that's what we have to think about so if you actually go to the repository there's a couple of things you will see
```timestamp 
 9:06
 ```
there's a proper re me I actually want all the repos at my client's repositories to have a proper REM me
```timestamp 
 9:13
 ```
explanation how to build it what do you need to be able to build it what do you how do you test things how do you run
```timestamp 
 9:19
 ```
the thing what are the prerequisites and also all these batches like uh what's the code coverage where's the link to
```timestamp 
 9:25
 ```
the build pipeline um this of course is an open source project so we ALS have like statistics downloads and stars and
```timestamp 
 9:32
 ```
contributors which you don't care about in an internal project but I still want to have a proper read me it's is
```timestamp 
 9:37
 ```

> [!NOTE]
> surprising how many repositories I'll find at my clients or my projects that have no description whatsoever and then

```timestamp 
 9:43
 ```
you know I should be able to you know maybe have heard of this thing that you should go into a company bless you go
```timestamp 
 9:49
 ```

> [!NOTE]
> into a company and you should be able to uh clone a repository get it to run within 5 minutes well maybe that's

```timestamp 
 9:55
 ```
idealistic but it's a good a good measurement to be able to see how far you can get with that so I I Tred it
```timestamp 
 10:01
 ```
this is part of it also what does it mean to contribute to that project so I'm a big proponent of [[inner sourcing]] so
```timestamp 
 10:08
 ```
I like the the uh the different teams in an organization to be able to contribute to each other so they should actually go
```timestamp 
 10:14
 ```
into a repository and be able to clone it create a pool request suggest something in the same way as I do it in
```timestamp 
 10:19
 ```

> [!NOTE]
> an open source project because that's a really great way of Distributing knowledge but also to have teams work
> ```timestamp 
>  10:24
> ```
> together and really work together effectively I think this is one of the major things the open source world has
> ```timestamp 
>  10:30
> ```
> contributed to professional software development uh I'm not saying by the way that open source is not professional at

```timestamp 
 10:36
 ```
least not this one uh so we have guidelines what do you expect from you if you want to contribute what do we
```timestamp 
 10:41
 ```
expect from you you know this is a sensitive topic because sometimes people just throw something over the wall and
```timestamp 
 10:46
 ```
then magically expect the open source developer to fix that same internally if you throw something over the wall to
```timestamp 
 10:52
 ```
another team do you expect the other team to fix it do you want to contribute to that then at least you need to understand what is expected from you
```timestamp 
 10:59
 ```
that's what the guidelines do um release notes is also part of that uh we
```timestamp 
 11:04
 ```
actually generate that with documentation all of that is part of the same repo again if you're building
```timestamp 
 11:10
 ```
internal uh components or libraries this is a nice way of doing it so we actually build that website from the source code
```timestamp 
 11:16
 ```

> [!NOTE]
> including functional release notes so you have also technical releas notes I'll show you show you that momentarily

```timestamp 
 11:22
 ```

> [!NOTE]
> uh but but this is important so for this open source project if somebody actually proposes a feature or creates a pool because we expect them to also amend be
> ```timestamp 
>  11:29
> ```
> functional release notes or update documentation and that's pretty cool if you can do that in one pool request
> ```timestamp 
>  11:35
> ```

right because you have the whole package together exactly like I do at my uh client's projects git tools that I work
```timestamp 
 11:41
 ```
with it's cool because you have a repo there's a couple of things I use um Windows terminal in this case uh you
```timestamp 
 11:48
 ```
probably have seen this these screenshots before uh I like Windows terminal because you have different kind of you can use Powershell you can use
```timestamp 
 11:54
 ```
command proms whatever you want uh there's a couple other things I use I use well po shell obviously uh oh my
```timestamp 
 12:01
 ```
porch That's the one that gives you all the colors in your command line um and by the way I'm not actually well then
```timestamp 
 12:08
 ```
next slide uh PS read line which is nice for history features you can actually do up and then complete the last command uh
```timestamp 
 12:15
 ```
again if you use CLI a lot uh some people don't and uh I have a lot of
```timestamp 
 12:20
 ```
aliases get aliases as well and they're beautiful because they allow me to be very productive and for example I can
```timestamp 
 12:26
 ```
use get safe as an extension that just takes whatever I have am I working directly push it to a repository so I
```timestamp 
 12:32
 ```
don't have to think about it instead of creating a commit end of the day or something like that and I just keep
```timestamp 
 12:38
 ```
amending that there's a whole whole set of them and Phil hack has all these things documented in this article uh and
```timestamp 
 12:44
 ```

> [!NOTE]
> the [[Zlocation]] or Z location which is a very smart uh CD command I just type Z

```timestamp 
 12:52
 ```
and then Fu for fluent and it will jump directly to the last directly that has that name so especially if you CI
```timestamp 
 12:58
 ```
commands a lot interestingly enough I don't actually use the CLI only so I'm a
```timestamp 
 13:04
 ```
pragmatic person at least I'd like to think that some of my colleagues don't agree but um so I actually like to combine
```timestamp 
 13:12
 ```
things so you know using command lines is very efficient switching between branches amending the changes pushing
```timestamp 
 13:18
 ```
them through repository but at the same time I need I need to have an overview so I actually use a git UI to be able to
```timestamp 
 13:25
 ```
aggregate my commits and figure out which changes should actually go which commits especially if I want to rebase I
```timestamp 
 13:30
 ```
do a lot of [[interactive rebase]] s and who's doing interactive rebases you nobody's doing interactive
```timestamp 
 13:36
 ```
re who's merging who's creating all these merge lines you know this the big rainbow thing yeah okay cool proud that
```timestamp 
 13:44
 ```
you actually admit that no uh uh this is [[GitKraken]] which
```timestamp 
 13:49
 ```
up to now is my uh my favorite tool I've used Fork I've used sourcer um smartgit
```timestamp 
 13:55
 ```
uh none of them I like this one I still like I know I also use from jet brains it has some pretty strong internal git
```timestamp 
 14:02
 ```
tooling but I still switch back to this one because I like the colors it gives me overview I like to have an overview
```timestamp 
 14:08
 ```
of things so uh patterns and guidelines that we use well who's not using an [[EditorConfig]]
```timestamp 
 14:14
 ```
confli you know the biggest struggle with code reviews if you start you know uh uh I was going to use some word that
```timestamp 
 14:20
 ```
I'm not going to use because this being recorded if you start complaining about people's alignment and stuff Taps versus
```timestamp 
 14:26
 ```

> [!NOTE]
> spaces and stuff like that if you just add a editor config to your repository you can just you know solve all of that

```timestamp 
 14:32
 ```
for you the compiler will automatically detect that and if you use a good C sorry IDE like Visual Studio code or
```timestamp 
 14:39
 ```
writer or something like that you can even comp convert it to completely automatically format all your code and
```timestamp 
 14:44
 ```

> [!NOTE]
> it can also apply the latest changes that c introduces like the new uh array or collection initializers it will just

```timestamp 
 14:51
 ```
automatically fix that up for you so you don't even have to bother talking about that during your code review that's
```timestamp 
 14:57
 ```
that's an important thing this is one of the first things I do with an existing Legacy code base and I love Legacy code
```timestamp 
 15:02
 ```
because I can change it to my own will um Russ analyzes also very useful in the
```timestamp 
 15:08
 ```
net space there's a lot of them uh examples are the [[Roslynator]] the one that
```timestamp 
 15:14
 ```
comes with net the one that I cannot pronounce the [[Meziantou.Analyzer]] I'm still
```timestamp 
 15:19
 ```
not sure whether it's French or another language um the shop guidelines analyzer that's actually one created by Dutch guy
```timestamp 
 15:26
 ```
that uses my coding guidelines as a starting point um and then you use your editor config to to tune the settings
```timestamp 
 15:32
 ```
like which rules do you want which rules should be a warning which one should be suggestion uh and they can do smart
```timestamp 
 15:38
 ```
things you know it can actually check that your XML comment is not actually wrong uh or that you're that you're
```timestamp 
 15:43
 ```
using the wrong link uh syntax because it causes performance issues there's stuff in there that I didn't even know
```timestamp 
 15:49
 ```
because it was introduced a newer version of do 6 uh maybe nested conditional statements you know the
```timestamp 
 15:54
 ```
question mark and then the semicolon and then somebody uses another question mark with another semi callon you know this
```timestamp 
 15:59
 ```
this kind of stuff yeah I mean you shouldn't be doing that so there's a Ros analyzer that will just don't doesn't
```timestamp 
 16:05
 ```
compile that's one way long methods of course it's very subjective but I have set it up on 40 lines if your method is
```timestamp 
 16:12
 ```
longer than 40 lines I actually want to have a good deep conversation with you
```timestamp 
 16:19
 ```
um single type of file uh correct exceptions types who's actually saying throw new exception in C by the way
```timestamp 
 16:26
 ```
who's actually doing do net C most of the people yeah you shouldn't actually do that these are internal types they're
```timestamp 
 16:31
 ```
not supposed to be used there's a Rosland analyzer for you or that you actually await an Asing method or that
```timestamp 
 16:38
 ```
you actually uh dispose an i disposable stuff like that there so many mistakes
```timestamp 
 16:44
 ```
I've seen in production that a simple russal analyzer can fix for you so we use that as well um naming a grouping of unit test
```timestamp 
 16:51
 ```

> [!NOTE]
> I'm a big propon proponent of [[Test Driven Development]] I've been practic practicing it for like last 15 years uh

```timestamp 
 16:58
 ```
I struggled I failed I made lots of mistakes in the first 5 to 10 years now I like to think I found a sweet spot
```timestamp 
 17:05
 ```

> [!NOTE]
> probably not but anyway and I experimented a lot with naming so in the past we used something like when the

```timestamp 
 17:10
 ```
same objects are expected to be the same it should not faill very functional though and yeah it's it's using you know
```timestamp 
 17:18
 ```
combination of snake casing with proper you know the first character's uppercase because it's English um but at some
```timestamp 
 17:24
 ```
point I've tried this for many years I felt like it's a bit long bit foros maybe we can do better so I tried other
```timestamp 
 17:30
 ```
things especially if you have like multiple uh methods or you want to group a couple of different scenarios so you
```timestamp 
 17:36
 ```
don't want to repeat the the context in every test name I started actually using like a nested class this case is the
```timestamp 
 17:43
 ```
reference type specs and oh by the way specs I use specs to emphasize that my test are actually specifications of
```timestamp 
 17:50
 ```
Behavior Uh I group them using a public class and then I don't have to repeat the fact that I'm which API or which
```timestamp 
 17:56
 ```
context I have but I found that still quite a long long so I've been experimenting with all kinds of other versions and eventually we settled on
```timestamp 
 18:03
 ```

> [!NOTE]
> this so really factual short names still functionally correct and the context so
> ```timestamp 
>  18:09
> ```
> the base uh the Base Class the parent class and the uh the top level class together should give you enough context

```timestamp 
 18:15
 ```
to understand the scenario because my test should have functional names because I want to understand what the
```timestamp 
 18:20
 ```
test is supposed to do and then I can actually see if the implementation does what it does so quite often almost
```timestamp 
 18:27
 ```

> [!NOTE]
> always when I review a pool request here or my my professional professional projects I actually look at the test as
> ```timestamp 
>  18:33
> ```
> a first thing because there're specifications they're supposed to give you an indication of what is the scope of something what are the internal

```timestamp 
 18:39
 ```
boundaries of the system and what kind of behavior do you expect from that does that make sense I hope it does um anyway
```timestamp 
 18:46
 ```
that's what we do uh we also document exceptions I'm not sure that's a really good thing I'm still not convinced about
```timestamp 
 18:53
 ```
that uh it's a lot of work maybe a bit too puristic I like to avoid the do ISM
```timestamp 
 18:59
 ```
uh but somebody found it important but I don't do this in my professional projects anymore we tried it for a while
```timestamp 
 19:04
 ```
it's too much too much work and if you really need to understand the except well the thing is you shouldn't actually
```timestamp 
 19:10
 ```
C catch exceptions if exceptions happen either it's a it's a well-known thing but usually it's not the case you throw
```timestamp 
 19:16
 ```
them because something unexpected happened if it's unexpected you shouldn't actually expect it right yeah
```timestamp 
 19:22
 ```
yeah it's a paradox it's a paradox I know uh that's what it looks like of course um there's a especially if you
```timestamp 
 19:29
 ```
have bigger projects there's usually lots of projects within the solution and if you want to have the same settings
```timestamp 
 19:34
 ```

> [!NOTE]
> applied to O your project since a year or two there's something called [[directory.build.props]] which is a
> ```timestamp 
>  19:40
> ```
> generic file you can put it in any folder and there you can put all the reusable elements in there uh I don't

```timestamp 
 19:45
 ```
know if you know that but we use that a lot so you just copy paste this somewhere in the folder and then all the projects underneath will will basically
```timestamp 
 19:52
 ```
honor those settings which is nice in this case I'm actually including all the the the styop analyzer Rosland the C
```timestamp 
 19:58
 ```
coding guidelines the rosinator and then the one that I cannot pronounce will be included automatically and apply to all
```timestamp 
 20:05
 ```
the projects underneath that so that's one way of doing it um what else yeah
```timestamp 
 20:11
 ```
sometimes well most often I use this arrange act assert Syntax for my tests probably you've used that as well but
```timestamp 
 20:18
 ```

> [!NOTE]
> sometimes you have tests which are more complicated more orchestrational and in those cases I
> ```timestamp 
>  20:23
> ```
> like to adopt a more like a [[behavior driven design|BDD]] style way quite often you also have to dispose something at the end of the test and
> ```timestamp 
>  20:30
> ```
> then I use [[chill]] which is one of the the libraries I maintain I didn't create that uh where you can do stuff like um

```timestamp 
 20:36
 ```
um yeah it should try to compare classes and then uh what is it on top you have given when and then the fact is the then
```timestamp 
 20:43
 ```
so you get like given when then which is more bdd style and the nice thing is you can actually have automatically clean up
```timestamp 
 20:49
 ```
stuff so you can override the dispose and this is the base glass but it also can clean up all things for yourself it
```timestamp 
 20:54
 ```
has a built independency injection framework if you're interested in that just go to chill bdd and check out the
```timestamp 
 21:00
 ```
examples it's quite nice I don't use it that often again I don't use anything I don't need but it can be use fold for
```timestamp 
 21:07
 ```
that feeding data to test is also something that happens a lot I don't know if you know but recently or
```timestamp 
 21:12
 ```

> [!NOTE]
> recently I think last year a unit introduced a new mechanism probably you heard of the theory thing that you could
> ```timestamp 
>  21:17
> ```
> use but it's untyped now you have Theory data so you can actually Define a method
> ```timestamp 
>  21:22
> ```
> join using writing style test cases and give it a specific type and then you can
> ```timestamp 
>  21:28
> ```

take dependency on that by saying member data name of this method and then your
```timestamp 
 21:33
 ```
entire test here is completely type safe I only found out because somebody from
```timestamp 
 21:39
 ```
the contributors actually proposed this like oh I didn't know that completely missed that and that's the case you know
```timestamp 
 21:44
 ```
we as a developers we do not know everything and we're not always up to date I mean that's why you're at the conference to learn new things right
```timestamp 
 21:50
 ```

> [!NOTE]
> same for me and being an open source developer is a nice way because you get to see a lot of new
> ```timestamp 
>  21:56
> ```
> things and you get to go to want them for free which is also nice by the way um new C versions yeah there's plenty of

```timestamp 
 22:05
 ```
talks about that I completely rely on my IDE to tell me about that so yeah that's
```timestamp 
 22:11
 ```

> [!NOTE]
> how it works I mean I do read some blog post occasionally but quite often you forget about these things so my IDE is
> ```timestamp 
>  22:16
> ```
> actually telling me hey you can do better than that he's he's right I can do better than that so for example um

```timestamp 
 22:23
 ```
the top one you know what is it doing it's almost unreadable right it says like if the previous character is an ENT
```timestamp 
 22:30
 ```
and the the statement is longer than two characters and the last but two one is a dollar sign and the one before that or
```timestamp 
 22:38
 ```
after that is an is an m% like okay or well this is UN readable right at least
```timestamp 
 22:43
 ```
I hope it is for me now you can do if the previous Char is an m% and the statement looks like a collection with
```timestamp 
 22:50
 ```
those two at the end well that's nice I didn't know that jet brains right actually I I don't have any stakes in
```timestamp 
 22:56
 ```
jet brains by the way it's just that yeah it's a good tool actually did that for me and there's other examples uh I
```timestamp 
 23:01
 ```
mean this one I don't even want to try to explain that it's unreadable this one is a little bit better so if the method
```timestamp 
 23:08
 ```
call expression is not an object with two things then we should be fine you
```timestamp 
 23:14
 ```
could debate whether this actually makes it better I should completely rewrite the code but it will actually the IDE
```timestamp 
 23:19
 ```
resharp does the same thing it will actually suggest you to use [[pattern matching]] which is nice I never
```timestamp 
 23:25
 ```
saw the real value of pattern mat pattern matching but I've changed my mind it's getting better and better and
```timestamp 
 23:30
 ```
if you really really really have to work with [[Regular Expression]] you can actually yeah you
```timestamp 
 23:37
 ```
can actually use an attribute and then the ID in this case will actually uh help you complete the uh and explain
```timestamp 
 23:44
 ```
what the regular expression is doing of course we who's actually using AI tools during during daily development co-pilot
```timestamp 
 23:51
 ```

> [!NOTE]
> AI assistant really so few people man everybody else is going to be so slow

```timestamp 
 23:57
 ```
compared to the five raise their hands so no no you should it's really it Chang it completely changed the way I look at
```timestamp 
 24:03
 ```
stuff and it's made me so much more productive uh which my bus doesn't like because clients charge me we charge them
```timestamp 
 24:09
 ```
by the hour so it's better if I do it very slow of course no um one of the
```timestamp 
 24:16
 ```

> [!NOTE]
> problems that a lot of people have is yeah but you know what we all on an older version of C or net how do we do
> ```timestamp 
>  24:22
> ```
> that well that's really cool it's good that you ask there's a a library an open source Library called  [[PolySharp]] and po

```timestamp 
 24:29
 ```

> [!NOTE]
> Shar will figure out what version you of the compiler you have what language and generate the missing types so a lot of

```timestamp 
 24:36
 ```
these attributes like if you use the newer uh the new compiler versions uh you don't need the new net versions
```timestamp 
 24:42
 ```
usually the net version introduce the attributes but this little Library will figure out like okay you're actually on
```timestamp 
 24:48
 ```
net 4.8 uh as if you actually create your own attribute with the same namespace the compiler will allow you to
```timestamp 
 24:54
 ```
do stuff like the new things like the uh the indexing thing I showed you earlier this will generate it for you you just
```timestamp 
 24:59
 ```
add to the project and suddenly all these new features will light up it's beautiful it's really cool poly sharp I
```timestamp 
 25:07
 ```
don't know anybody using this nobody see you learn something new for me if that's
```timestamp 
 25:12
 ```
the only thing see this is what it actually looks behind and it's using Source generators so that's really cool um so building and testing locally
```timestamp 
 25:21
 ```
um it's I mean even the library is pretty complicated but most projects that I work with are even bigger than
```timestamp 
 25:26
 ```
that uh wouldn't be cool if you can actually build your project and test and everything that you would do on your
```timestamp 
 25:32
 ```
build pipeline also locally is anybody using aops oh I'm I'm sorry about that um but
```timestamp 
 25:41
 ```
the thing is uh you don't and and probably also yaml yo anybody yo yes oh
```timestamp 
 25:47
 ```

> [!NOTE]
> I'm sorry about that um so building and testing locally is actually pretty easy uh one of the things I do is I use [[nuke]]

```timestamp 
 25:55
 ```
not the best term best name for a library these days um but basically it does this it act
```timestamp 
 26:01
 ```

> [!NOTE]
> allows you to and completely encapsulate your build process as a bunch of C
> ```timestamp 
>  26:07
> ```
> targets if you if you used with make in the past or maybe cake or aake which was
> ```timestamp 
>  26:13
> ```

a Powershell version nuke is brilliant um essentially you define all your targets and code and then you know this
```timestamp 
 26:20
 ```
is what it looks like at runtime this you can run the whole build script locally and whether you run it from
```timestamp 
 26:25
 ```
Azure devop pipelines or GI up actions or team City it doesn't matter the effect is the same so you completely
```timestamp 
 26:31
 ```
decouple yourself from the build agent which is nice because I mean fluent to surg is pretty simple compile run some
```timestamp 
 26:38
 ```
test do some code checking uh spell checking and create a nuka package out of that but most projects are much more
```timestamp 
 26:44
 ```
complicated if you also use infrastructure as code using pumi for example you can kick off pumi from nuke
```timestamp 
 26:50
 ```
um again not the best term best name uh and if you run it locally you asked for the questions or you ask what it can do
```timestamp 
 26:57
 ```
you get all the options you can Define parameters you can pass them in a command line or as environment fbls but
```timestamp 
 27:02
 ```
what I really love is being able to get a graph of my build pipeline what does it work this is locally so everything
```timestamp 
 27:08
 ```

> [!NOTE]
> you do can be done locally and that is awesome and it's C which means your
> ```timestamp 
>  27:14
> ```
> build script you can refactor it you can debug it yeah you get intellisense you can you can you can do whatever you want
> ```timestamp 
>  27:20
> ```

to do with your cop code try that with yaml no no exactly so I I'm being
```timestamp 
 27:28
 ```
recorded but I hate yl just for the records I mean except for simple
```timestamp 
 27:35
 ```
confirmation stuff but a build script is not ceration that's that's a lot of things that's also why I don't like
```timestamp 
 27:40
 ```
terao for the same reason uh and this is free you can use it and it's awesome I use it in all my projects everybody that
```timestamp 
 27:47
 ```
used it you know ini she says like what's the big deal it's the build script and then they use it like wow it's so nice like fluent assertion it's
```timestamp 
 27:54
 ```
just nice you know it's not it's not it's not crucial for your development flow but it's a nice small thing and
```timestamp 
 28:00
 ```
this is what it looks like or what it can look like and it's very powerful you can start very simple uh it can create
```timestamp 
 28:06
 ```
some plumbing and starting kit and it's actually project in your solution so everything that applies to C also
```timestamp 
 28:12
 ```
applies here editor convict rosling analyzers whatever you want really cool
```timestamp 
 28:18
 ```
um and everything there's a lot of stuff that it doesn't do or it doesn't support out of the box it can work with any tool
```timestamp 
 28:24
 ```
and that's cool you it work with any tool it can dynamically download new get packet tools you can either call local
```timestamp 
 28:29
 ```
executables all from C in a nice way you don't have to think about Last Exit code and stuff like that so if you have your
```timestamp 
 28:36
 ```
build scripts in bash files or Powershell throw them out of the door and switch to Nuke um another thing we
```timestamp 
 28:43
 ```
you do is because it's an open source library and I don't want to introduce breaking changes just like I want to
```timestamp 
 28:48
 ```
don't want to do with packages we use approval test what does it mean we use a package called [[PublicApiGenerator]]
```timestamp 
 28:55
 ```

> [!NOTE]
> which will generate and I think it's an XML file by the top of my head uh representing the public API of your
> ```timestamp 
>  29:02
> ```
> library of your assembly your project so including internal protected parameters return types and stuff like that then we

```timestamp 
 29:10
 ```

> [!NOTE]
> use another tool called [[verify]] and we have a snapshot of that file stored in Source control so this is just a unit
> ```timestamp 
>  29:16
> ```
> test that runs an automatic test and that will just regenerate the thing so if you create a pool request that

```timestamp 
 29:22
 ```
accidentally breaks the public contract your test will fail and it will actually tell you what you changed oh you changed
```timestamp 
 29:28
 ```
the return type that could be a potential breaking change and then you have the choice of fixing it uh or
```timestamp 
 29:35
 ```
saying I'm accepting the change so I'm going to accept the snapshot put it in Source control and after that it's a
```timestamp 
 29:40
 ```
change we use that in all my all the libraries that we built internally and with big projects you usually have lots
```timestamp 
 29:45
 ```
of small packages that you can reuse by the way I completely lost track of time
```timestamp 
 29:51
 ```
until what time do I have actually until what time yeah half oh 20
```timestamp 
 29:56
 ```
minutes 30 oh 30 minutes okay I have to go faster um because I still have 100
```timestamp 
 30:03
 ```
slides no no just kidding so this is an example of a failing test uh [[dotNET benchmark]] yeah of course it's a
```timestamp 
 30:09
 ```
library it has certain speed characteristics so we use the very
```timestamp 
 30:14
 ```
popular benchmarked it in a build pipeline because that requires the same Hardware
```timestamp 
 30:20
 ```
all the time but we do use it sometimes for performance if somebody complains about the performance we have a couple of these
```timestamp 
 30:26
 ```

> [!NOTE]
> example uh benchmarks scripts that will give us some results and then we can also see if certain
> ```timestamp 
>  30:32
> ```
> changes actually improve the performance it's a very powerful technique if you have dedicated build agents so
> ```timestamp 
>  30:39
> ```
> controlled environments with controlled Hardware packs you can actually use that to get quick early feedback that

```timestamp 
 30:44
 ```
somebody actually broke the performance and that's better to have a Bill by detect that than a client complaining
```timestamp 
 30:50
 ```

> [!NOTE]
> about that right I mean the earlier you find the problem the easi is to detect where the problem came from ideally from
> ```timestamp 
>  30:55
> ```
> a particular pool request and this is some output from that completely unreadable quite difficult to
> ```timestamp 
>  31:02
> ```

decipher but it's very useful again it's a tool that you can use or not uh in
```timestamp 
 31:08
 ```
terms of documentation Yeah we actually have the website um I'm also using these for internal projects to little build
```timestamp 
 31:14
 ```
little documentation SDK kind of websites both for internal teams but sometimes you also build extension
```timestamp 
 31:20
 ```
points that external clients and partners can use this is a nice way of doing it it's a it's a jackal SI it's
```timestamp 
 31:27
 ```

> [!NOTE]
> based this this this case it's buil built based on a a template that I got from the internet [[minimal mistakes]] um

```timestamp 
 31:33
 ```

> [!NOTE]
> you can actually build your website locally you can run it you can test it and make it part of the pool request um

```timestamp 
 31:38
 ```
I use Jackal for that which is a nice structure for that and uh oh yeah uh
```timestamp 
 31:43
 ```

> [!NOTE]
> yeah and to make sure that the website doesn't contain any spelling mistakes neither does my code or the release noes
> ```timestamp 
>  31:49
> ```
> we use [[cspell]] which is an mpm package and like wait what you you're using
> ```timestamp 
>  31:55
> ```

JavaScript in Ault net Library yeah why not I mean it's a great tool you just use it in my build pipeline so the same
```timestamp 
 32:01
 ```
nuke thing that you saw earlier has a step that will dynamically download the right mpm version execute the script
```timestamp 
 32:07
 ```
against the documentation so we get early feedback because it's very annoying if you create a new release and there spelling mistakes in that I mean
```timestamp 
 32:14
 ```

> [!NOTE]
> maybe somebody doesn't care about that but we actually got quite some pull request with spelling mistakes I mean
> ```timestamp 
>  32:20
> ```

it's nice for the person to officially contribute to a project with so many downloads but still I mean uh it's a
```timestamp 
 32:26
 ```
nice enhancement um and you can see it executed as nuke does it the color is
```timestamp 
 32:31
 ```
not that nice but if you want to try you can go to the repo clone it and run the bill script and you see exactly this um
```timestamp 
 32:38
 ```
about merging and reviewing uh yeah that's a big thing uh happens a lot I hope is everybody using
```timestamp 
 32:44
 ```
po quests or are people still merging directly into production yeah you laugh but I've seen
```timestamp 
 32:52
 ```
really strange things in my career professionally I mean um so a
```timestamp 
 32:58
 ```

> [!NOTE]
> really big source of pool request in gitup is the [[dependabot]] I don't know if you know that the pendot is a a tool within
> ```timestamp 
>  33:04
> ```

giup asro defs doesn't have it I don't know I'm not saying you should go away from as devops I'm saying that uh but
```timestamp 
 33:11
 ```

> [!NOTE]
> the pendot actually figures out all your dependencies mpm nugat whatever you're using mayen and will automatically
> ```timestamp 
>  33:17
> ```
> create pool request for you and that is nice because one of the biggest problems I've seen in some of my clients is that

```timestamp 
 33:23
 ```
they don't actually update all the dependencies because nobody cares about them or forget about that the pendot will do that for you and that's
```timestamp 
 33:29
 ```

> [!NOTE]
> important because we have a lot of them it will also detect vulnerabilities you know and provide fixes for that uh that
> ```timestamp 
>  33:36
> ```
> on itself is already worth the money because if that fil ability ends up in production and then somebody runs into

```timestamp 
 33:42
 ```
it or finds it you might actually have to go through certain levels of certain uh channels that are very expensive to
```timestamp 
 33:47
 ```
go through you have to report your clients um there's an example there's a whole bunch of pool requests uh one of
```timestamp 
 33:54
 ```

> [!NOTE]
> the flip sites is that you may actually get too many pool requests so you can tweak that process to only do it once a

```timestamp 
 33:59
 ```
week um you can tweak it completely you can even say that you know what we have if you're using xunit for example action
```timestamp 
 34:06
 ```
is actually three or four packages and of course initially dependabot will say you have this package and then that
```timestamp 
 34:11
 ```
package and then that dependency in aert order you can actually add a configuration file that tell us that you
```timestamp 
 34:17
 ```

> [!NOTE]
> would actually want to have group updates so everything related to xunit every related to nunit is One update

```timestamp 
 34:23
 ```
that updates the whole set the same with asp.net core and all the Microsoft libraries you can can tweak that also
```timestamp 
 34:29
 ```

> [!NOTE]
> and this is not here but um gitup in January introduced a major change where they're now using AI to kind of predict
> ```timestamp 
>  34:36
> ```
> how often you update the packages so you can actually tell it like you know what I don't want you to complain about this package for a while and it will not do

```timestamp 
 34:42
 ```
that or it will also detect that you haven't that you kind of closed certain pool request instead of merging them and
```timestamp 
 34:48
 ```
then it won't it will try to figure out okay that probably means you don't want to up that that package again and not bother you with that well that kind of
```timestamp 
 34:55
 ```

> [!NOTE]
> stuff no other supplier can do that we looked at sneak and all these they're not that far the Pender dependabot is really
> ```timestamp 
>  35:00
> ```
> really good of course it's from the the people behind co-pilot so it's kind of

```timestamp 
 35:06
 ```
expected another thing is which giup offers out of the box is code ql which
```timestamp 
 35:12
 ```
is a vulnerability and also like misuse of certain principles it will do SQL injection detection and stuff like that
```timestamp 
 35:18
 ```

> [!NOTE]
> it will verify that you don't put passwords in your repository and I'm surprised I don't know if you have that but I'm really I've seen my share of

```timestamp 
 35:25
 ```
passwords in GTO Propel stories and asure of suppos stories and in files and all over the place it will detect that
```timestamp 
 35:31
 ```
automatically that on the is quite useful by the way so we have also enabled that get up actions kind of a
```timestamp 
 35:37
 ```
your pipeline stuff like that yeah we use that but again we only use it as a trigger because nuke is the one that's
```timestamp 
 35:43
 ```
doing the real work and it just reports the output you can see that here we have like multiple builds you know we have a
```timestamp 
 35:49
 ```
main build we run the unit test on auntu we run the unit test on Macos to see
```timestamp 
 35:55
 ```
that everything works because we did see some changes here again not as applicable to every project but it works
```timestamp 
 36:02
 ```
we have a nice configuration and actually this is all the ymo that I have and I'm willing to bear with it's really
```timestamp 
 36:08
 ```
a limited thing see this is just getting the net SDK you cannot read this from the far end but it doesn't matter it
```timestamp 
 36:14
 ```
runs on Windows um I'm checking out my um The Source control source code one
```timestamp 
 36:19
 ```
level deep I'm saying I need certain net versions and then I just run build or PS1 and that's doing the real work and
```timestamp 
 36:25
 ```

> [!NOTE]
> the build or PS1 is the one that triggers the whole C build pipeline which is nice um code coverage who has a code

```timestamp 
 36:34
 ```
coverage of more than 90% who has a code coverage of less than
```timestamp 
 36:39
 ```
50% who doesn't know yes that's the case um I don't think code corage by the way
```timestamp 
 36:47
 ```
is um is something that you should really well you have to be careful how your it's very valuable being able to
```timestamp 
 36:53
 ```
understand how much test cence you have and where are the black spots you know that in your Cod base is very useful
```timestamp 
 36:59
 ```

> [!NOTE]
> using it as a metric especially by managers as a kpi it's a bad thing that being said the open source library that

```timestamp 
 37:06
 ```
we have I don't think you can see it has currently 97% Cod coverage that is
```timestamp 
 37:11
 ```

> [!NOTE]
> ridiculous nobody should be doing that it just happens because some of my contributors they were so let's say

```timestamp 
 37:17
 ```

> [!NOTE]
> overzealous that they want to increase the level but it's very dangerous because they can you can also lead to
> ```timestamp 
>  37:23
> ```
> having unit test at the wrong scope and that's even worse that is that can kill kill your whole um uh attempt to
> ```timestamp 
>  37:29
> ```
> introduce test driven development but it's nice to be able to report that in this case it's also open source based so

```timestamp 
 37:36
 ```
you can do that as well if you use sonar cloud or something like that you also get this kind of stuff uh if you use
```timestamp 
 37:41
 ```

> [!NOTE]
> sonar Cloud disable the duplication thing because that duplication thing leads to overuse of dry I don't know if

```timestamp 
 37:48
 ```
you want was in the architecture presentation early on with about the vertical slice architecture that was a
```timestamp 
 37:54
 ```

> [!NOTE]
> really good presentation by the way so we use that um we don't use sonar Cloud we use

```timestamp 
 38:00
 ```

> [!NOTE]
> [[Qodana]] which is from jet bran it's still relatively new uh we were kind of early adopters of it and we also work together

```timestamp 
 38:07
 ```
to get feedback um I haven't made up my mind yet which one is better I think sonar Cloud also has increased uh has
```timestamp 
 38:13
 ```
improved considerably the last last two years or something in my last presentation I actually I was um Bing
```timestamp 
 38:20
 ```
about sonar cloud and I was actually the engineer of Sonic cloud in the in the in the in the group and we had a nice chat
```timestamp 
 38:27
 ```
about it explained my frustrations and he explained that he had the same frustration so we just you know oh I'm
```timestamp 
 38:34
 ```
kidding I'm kidding um this also interesting so some people say I'm am
```timestamp 
 38:39
 ```
very I can be a nitpick and uh they're usually right I can be an AIC I really
```timestamp 
 38:45
 ```

> [!NOTE]
> care about the quality so one of the things that changed the way I do code reviews and I'm going really quick I

```timestamp 
 38:50
 ```

> [!NOTE]
> know that it's a big uh big presentation is I now use emojis before my comment
> ```timestamp 
>  38:56
> ```
> and why is that useful because that emoji forces me to think about how important is this thing that I'm

```timestamp 
 39:01
 ```
actually commenting about is it a nitpick is it something I really want to be changed is it something I want to
```timestamp 
 39:07
 ```
have a discussion about but the person can ignore me they can't um or maybe a seat you know this is something that I
```timestamp 
 39:14
 ```
want you to think about you don't have to fix it right now but I hope it actually sticks in the back of my mind
```timestamp 
 39:19
 ```
like the next time we should actually address that this has has helped me tremendous me yeah this is the pick the
```timestamp 
 39:25
 ```
N nit pick it's a little uh ax or what is it called a pick uh pickaxe
```timestamp 
 39:31
 ```

> [!NOTE]
> um that's nice it's just a small little trick but it helped me really make a difference and every time now I use to
> ```timestamp 
>  39:36
> ```
> pick so that sounds really weird the pickaxe I wonder like okay should I even mention this because I know I'm
> ```timestamp 
>  39:42
> ```
> nitpicking I maybe the first time I do it and then the next time I don't do it anymore because I expect the person the

```timestamp 
 39:48
 ```
next time it's just a cross you know now you have to fix it now but it helped it really helped me and also made my pool
```timestamp 
 39:53
 ```
request more friendly you know I worked with a developer I met him after 12 years or something and he said yeah you
```timestamp 
 39:59
 ```
know what I still remember you like from the last project remember that you and this is really true that you printed out
```timestamp 
 40:05
 ```
the code took a red pencil and started to code with you thing I don't even have
```timestamp 
 40:11
 ```
a memory of that but apparently it happened so yes that's that's me 20
```timestamp 
 40:16
 ```
years ago I'm I'm 50 so I'm probably a bit more professional mature and less
```timestamp 
 40:21
 ```
picky now no I'm not um but anyway this is nice that you can try the other thing
```timestamp 
 40:27
 ```
is and this is with pool reest sometimes you have to say no and I already gave the example earlier about the data set thing we should have never accepted it
```timestamp 
 40:34
 ```

> [!NOTE]
> but we did because we're trying to be friendly especially in the open source Community if you're not friendly you immediately get cancelled so you don't

```timestamp 
 40:41
 ```
want that um but we we have to say no sometimes and that we have to explain
```timestamp 
 40:47
 ```

> [!NOTE]
> you know um uh uh within the in inside projects client project of course we we talk with the tech leads or something or

```timestamp 
 40:53
 ```
figure out like you know what we don't want this let's you know nicely say that in fluent insertions we do back I do
```timestamp 
 40:59
 ```

> [!NOTE]
> back checking with with my other colleague on slack and we have discussions like you know what I'll be the one saying no because he doesn't

```timestamp 
 41:05
 ```

> [!NOTE]
> like that I'm more a red person he's more like a green yellow person if that says anything so I'll just say you know

```timestamp 
 41:12
 ```
we talked about it and we feel that it's not we feel that it's not actually fits in this project so hopefully you
```timestamp 
 41:18
 ```
understand this that we closing your your your pquest right now click this has
```timestamp 
 41:25
 ```
happened and one person actually joined the slack channel to try to convince us and we eventually had to say sorry I we
```timestamp 
 41:32
 ```
get your point it's our project you can Fork it no you can't uh but you can you can build your own um yeah that's the
```timestamp 
 41:39
 ```

> [!NOTE]
> truth it's the same in your real project right if you're an architect or Tech lead you sometimes have to say no you try to explain to people but some

```timestamp 
 41:46
 ```

> [!NOTE]
> developers just don't get it they're so stubborn like me um the other thing is

```timestamp 
 41:52
 ```
yeah I actually discovered that I got less Critical with code reviews but my colleague y is actually has a very keen
```timestamp 
 41:58
 ```
eye he really looks at the details he looks at all the he cross references every change with something in the past
```timestamp 
 42:04
 ```
he tries to keep everything consistent it's really annoying sorry onas um but it's actually really useful because we
```timestamp 
 42:11
 ```

> [!NOTE]
> have different views I actually look at the bigger picture like the the long the direction the vision doesn't fit together and he's the one looking at all
> ```timestamp 
>  42:17
> ```
> the details which is nice because I spent less time on cach reviews and he's doing the hard work so I let him review

```timestamp 
 42:23
 ```
first and if he's happy then I'll come in now but this is good like I actually also in my own internal projects uh we
```timestamp 
 42:29
 ```

> [!NOTE]
> always have two reviewers because you have people with different views different perspectives and they should have that which can be annoying

```timestamp 
 42:36
 ```
sometimes because one person has a comment then it's fixed and the other person has a different comment yeah
```timestamp 
 42:41
 ```
that's that can happen but we try to avoid that by the way there was a a really good presentation Yesterday by I
```timestamp 
 42:46
 ```
forgot her name about reviewing uh if you were not there check it out because there was so much useful information
```timestamp 
 42:52
 ```
there that I also liked about that so I should have mentioned by the way the Emoji thing wasn't there which she's
```timestamp 
 42:58
 ```

> [!NOTE]
> doing that as well uh who cares about a clean Source control history only three the rest doesn't care

```timestamp 
 43:04
 ```
anybody well only four people were doing interactive rebases I really care because it's really complicated if you
```timestamp 
 43:12
 ```
know you have this history with all these lines going in trying to figure out what happened at what point of time
```timestamp 
 43:17
 ```

> [!NOTE]
> I I actually go back into some people call it a a code archaeologist I go back

```timestamp 
 43:22
 ```
in time quite often trying to understand what was the you know the the the the worm in the head of the developer at
```timestamp 
 43:28
 ```
that point in time that they changed that code and the worst example I've seen well not maybe the worst but the
```timestamp 
 43:34
 ```
very bad one is I somebody changed the uh SQL timeout to 60 seconds default is
```timestamp 
 43:41
 ```
15 seconds and net so I was wondering like why did somebody change that why would you do that so I went to Source
```timestamp 
 43:47
 ```

> [!NOTE]
> control you know did blame figured out find found the the pool request you know what it says increase the timeout to 60

```timestamp 
 43:55
 ```
seconds great now I know nothing and that's why I care about this stuff I do
```timestamp 
 44:00
 ```

> [!NOTE]
> a lot so I'm very picky about this stuff I want people to rebase I want people to use fixup commits and I've used that

```timestamp 
 44:06
 ```
before it's very nice I wrote a blog post about that to try to get that clean history because it's really really
```timestamp 
 44:12
 ```
difficult to to figure out what happens in the past especially if you have to solve merge conflicts you have to figure what happened here interactive rebases
```timestamp 
 44:19
 ```
and rebases are a really nice way of preventing that auto merging is a feature that uh GI up introduced last
```timestamp 
 44:25
 ```
year so you basically say a defs already had it by the way although aops is kind of uh in maintenance mode it feels like
```timestamp 
 44:32
 ```
that I hope it is uh you can basically say after all the approvals are done it should be automatically merged really
```timestamp 
 44:39
 ```
not interesting releasing um [[semantic versioning]] I don't know if you know uh
```timestamp 
 44:45
 ```
you have a big number so basically the number means what you can expect if you have a breaking change one should the
```timestamp 
 44:52
 ```
first number should increase if it's a a minor version that adds backwards compatible functionality your buck fixes
```timestamp 
 44:58
 ```
you increase the middle number and the last one you only increment if you're only shipping uh Buck fixes the open
```timestamp 
 45:04
 ```
source library now is on 6.12 we're now working on seven that's when we're going to rip out you know make all fix all the
```timestamp 
 45:11
 ```

> [!NOTE]
> design mistakes because we can but that takes a couple of years we don't do that that often and this is also what I use

```timestamp 
 45:16
 ```
in all my projects um get flow get G flow and GI up flow is
```timestamp 
 45:23
 ```
just a nice standard how you should name your your branches and your um and how
```timestamp 
 45:28
 ```
you should organize them and tools like [[GitVersion]] can actually automatically generate the version number from the
```timestamp 
 45:33
 ```
branch name the L text uh tags on kit number of commits from there I use that in all my projects because I don't want
```timestamp 
 45:40
 ```

> [!NOTE]
> to manually change numbers it should calculate it completely automatically based on the branching strategy and

```timestamp 
 45:45
 ```

> [!NOTE]
> that's a nice way of doing it I even use it for use it for database schemas so you can actually see what's the version

```timestamp 
 45:50
 ```
of the databased schema what is the version that you're running out and they can use that to figure out the differences unless you're using n
```timestamp 
 45:56
 ```
framework but if you're using Oracle these things don't work so that's important to use um this
```timestamp 
 46:03
 ```
is Du Git Version another open source project and this is what it produces uh lots of information but you see major
```timestamp 
 46:10
 ```
minor version it has these really ridiculous long ones informational version you can't read it but it says
```timestamp 
 46:16
 ```
6.2.0 D Anonymous types formating do1 plus 73 Branch plus the whole hash key
```timestamp 
 46:23
 ```
being able to go into production checking out the dll or back seeing the hash key going to GitHub and see exactly
```timestamp 
 46:30
 ```
what committed it can save you can save you a lot of time how much how much time do I have left by the way
```timestamp 
 46:37
 ```
sorry 15 minutes five minutes oh 15 minutes all right um and of course get
```timestamp 
 46:45
 ```

> [!NOTE]
> version you can actually invoke that from your nuke script obviously because it's a tool it does that by the way automatically releasing um yeah a GitHub

```timestamp 
 46:53
 ```

> [!NOTE]
> has release not generators which is awesome a d doesn't have that uh there are some Marketplace things but it's not

```timestamp 
 46:58
 ```
very useful um we use that a lot so every time we create a release we just say this is the number and then we have
```timestamp 
 47:04
 ```
this nice button actually it physically moved recently I saw you say this is the last 6.11 is the last version and it
```timestamp 
 47:11
 ```
will generate the release notes it will look at the pool request give you nice information and it will look like like
```timestamp 
 47:17
 ```
this and you can completely customize that so you can put labels on your pool request like this is a bug fix this is a
```timestamp 
 47:23
 ```
breaking change this is a new feature this is internal code changes and you can like that you get this with the
```timestamp 
 47:28
 ```
names of the people with the number and even like you know new contributors this this release doesn't cost you any time
```timestamp 
 47:35
 ```
you set it up once and you get release noes for nothing that's cool because if you're aure devops it's always a pain to
```timestamp 
 47:41
 ```
get that done uh and you can completely customize that if you want examples go to fluent
```timestamp 
 47:47
 ```
insertions repo and you can extract that from there and it gets better they keep investing also nugat packages if you use
```timestamp 
 47:53
 ```
that on nugat I guess for internal projects you have your own Fe feet but if you do use nugat you can actually say
```timestamp 
 47:59
 ```

> [!NOTE]
> I want a reserved prefix so in this case nobody can create a package called
> ```timestamp 
>  48:04
> ```
> fluent assertions or with a prefix of fluent assertions without approval which is nice because then people cannot
> ```timestamp 
>  48:10
> ```
> pretend they're actually an official package I don't know that's not that relevant for most people but still um

```timestamp 
 48:17
 ```
well there's a lot of things we still need to do because I showed you a lot of little tools and practices that we've
```timestamp 
 48:22
 ```
used in the past and we keep discovering new things we're still not done uh of course we're currently working on the
```timestamp 
 48:28
 ```
next major version V7 um yeah that will probably happen in a couple of months
```timestamp 
 48:33
 ```
depending on how much time and all the other conferences is consuming my time and we didn't we still haven't applied consistent naming so all the the unit
```timestamp 
 48:40
 ```
testing naming things I showed you earlier the codebase is not completely consistent and what I like to do is use
```timestamp 
 48:46
 ```

> [!NOTE]
> the open the the fluent assertion codebase as a kind of example to other people how I think you should be doing

```timestamp 
 48:51
 ```

> [!NOTE]
> it of course it's opinionated but it's also a good reference to my clients so I use fluent as a reference to project

```timestamp 
 48:58
 ```
teams like okay you know this is how you can do that because sometimes yeah they hear me and they say like that sounds
```timestamp 
 49:03
 ```
nice but what does it mean like okay I show you that which is very powerful uh because you know um the fact that I have
```timestamp 
 49:10
 ```

> [!NOTE]
> a library which is relatively popular actually gives me certain level of credits that I can use at client

```timestamp 
 49:15
 ```

> [!NOTE]
> projects because a lot of people ask me like how do you convince your teams to adopt a certain principle practice being
> ```timestamp 
>  49:21
> ```
> an open source developer helps with that for a certain amount of time if you stay for a client a client for 5 years you

```timestamp 
 49:27
 ```

> [!NOTE]
> lose that credibility you lose the consultant Factor but yeah that's fact of life you shouldn't stay that long um

```timestamp 
 49:34
 ```
uh data sets are being extracted want to get rid of that obviously there's probably other features uh design
```timestamp 
 49:40
 ```

> [!NOTE]
> guidelines we have lots of guidelines and as an architect I usually insist that we write down design guidelines we

```timestamp 
 49:45
 ```

> [!NOTE]
> also I insist on writing down decisions architectural decisions because the most

```timestamp 
 49:50
 ```
frustrating part is that when you come into a client's project and you find something you don't expect like you want
```timestamp 
 49:56
 ```
you ask like why did you go that direction why did you adopt to be versus another nosql solution yes
```timestamp 
 50:02
 ```

> [!NOTE]
> somebody decided that like but why did you look at the pros and cons there's a lot of decisions that you make so I

```timestamp 
 50:07
 ```
insist that we start writing them down if you have confidence for example which is a nice place we capture all the
```timestamp 
 50:13
 ```
design design guidelines like who's involved in the discussion the pros and cons the consequence of that decision
```timestamp 
 50:18
 ```
you can use why statements I also want to do that for fluent assertion because we do make a lot of decisions and
```timestamp 
 50:24
 ```
sometimes really complicated things like how do you compare records do you compare record as a value type object or
```timestamp 
 50:30
 ```
do you compare record by properties those were big decisions at least in little my little little bubble and
```timestamp 
 50:36
 ```
sometimes people ask like why do you do that and it doesn't make sense and the rest of the world doesn't do that I want them to refer to the decision that we
```timestamp 
 50:42
 ```
made you know who was involved why did we the the tradeoff because software development is about trade-offs right
```timestamp 
 50:48
 ```

> [!NOTE]
> it's lots of trade-offs and you want to capture that so we want to do that as well uh because it's

```timestamp 
 50:53
 ```

> [!NOTE]
> important the 97% code C we got that through [[mutation testing]] has

```timestamp 
 51:00
 ```

> [!NOTE]
> anybody used [[mutation testing]] before two people mutation testing and a [[Stryker.NET]] is a tool in a do net space that can do

```timestamp 
 51:06
 ```

> [!NOTE]
> that what it will do it will try to change your production code and then run
> ```timestamp 
>  51:12
> ```
> your tests and see if any test fails so for example if you use an Isis operator in your test some in your code somewhere

```timestamp 
 51:19
 ```
it will forcefully revert that so invert the addition make it a not is and then see if a test fails if no test FS it
```timestamp 
 51:27
 ```
means you have a gap in your code coverage right your test coverage and those tools are expensive in the terms
```timestamp 
 51:32
 ```
that they take a lot of time to run takes hours to run but they're extremely useful especially if you have Legacy
```timestamp 
 51:37
 ```
code base and you're wondering like how can I make my code more robust and some of these contributors have been running
```timestamp 
 51:43
 ```
this Tool uh to find the gaps and you know and then create pool request with more unit test for that to solve that
```timestamp 
 51:49
 ```
I've also used this in production system and it's extremely useful because yeah people say oh the quality is very high
```timestamp 
 51:55
 ```
and then you run the tool and everything falls falls apart and say oh look at this this is a nice report also great
```timestamp 
 52:00
 ```
for auditing you can come in drop the tool say oh cool your code base
```timestamp 
 52:05
 ```
crap hire me to fix it yes that's it's a nice uh sales model I think I just came
```timestamp 
 52:12
 ```

> [!NOTE]
> up with now but yeah we want to make it part of the build pipeline uh also looking at [[ArchUnitNET]] I some some other
> ```timestamp 
>  52:18
> ```
> speaker was also talking about it's a free library that allows you to have automatic unit tests that verify that
> ```timestamp 
>  52:24
> ```
> certain projects do not reference each other other or certain name spaces do not reference each other if you have

```timestamp 
 52:29
 ```
like the the vertical slice architecture you can use a tool like Arc unit to make
```timestamp 
 52:34
 ```
sure that the code in one slice does not directly reference code in another slice that you do this properly and the pent
```timestamp 
 52:40
 ```
can also do that but it's very expensive it's a very powerful tool for the record AR unit is free and what do we love free
```timestamp 
 52:48
 ```
tools right yes all right and uh uh yeah exact we we built a whole website using
```timestamp 
 52:54
 ```

> [!NOTE]
> this Jackal thingy apparently there's a nice solution [[docusarus]] which I heard about uh I think in NDC also somebody

```timestamp 
 53:01
 ```
told me about so we're also going to be looking at that um I think there was a lot of content in
```timestamp 
 53:08
 ```
a small time I've been speaking quite fast faster than I usually do no um if
```timestamp 
 53:14
 ```
you have any questions if you have if you want want to see examples you can reach out through all these channels I
```timestamp 
 53:19
 ```
hope there was at least something for everybody here otherwise it would be a waste of time you could have better went to the CFA session or something like
```timestamp 
 53:25
 ```
that I hope you enjoy what is left of the conference maybe I'll see you tonight at the uh at the pbcom I'm
```timestamp 
 53:32
 ```
supposed to be funny not um I will talk about my legacy systems that's always good stories because I've seen some bad
```timestamp 
 53:38
 ```
stuff uh which we'll talk about tonight and um thank you for being here enjoy the rest of the conference and maybe I
```timestamp 
 53:44
 ```
see you next year or somewhere on another