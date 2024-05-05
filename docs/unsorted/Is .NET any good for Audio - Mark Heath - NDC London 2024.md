---
status: seedling
dg-publish: true
tags:
  - unsorted
  - content/video/youtube
creation_date: 2024-05-05 20:18
definition: undefined
ms-learn-url: undefined
url: https://www.youtube.com/watch?v=xuSWpNsuffA
aliases:
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |


## Video

![link](https://www.youtube.com/watch?v=xuSWpNsuffA)

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


## Transcript

yeah okay well welcome everybody uh this is a talk about C and audio programming

uh it's a real privilege to be speaking on this topic that um maybe it's a little bit of a niche subject but I

certainly find it very interesting um just to give you a little idea of who I am my name is Mark Heath I'm a plural

site author I've created over 20 courses on plural sites including three about audio which hardly anybody watches most

of my courses are about ad microservices that kind of thing because my day job um I'm building digital

evidence Management systems for the criminal justice um system um in Asia

which does get uh me opportunity to do a little bit of audio programming which I'll talk about later but probably the

most relevant thing for this talk is that um I'm the creator of an open source uh audio library for net called n

AIO and so actually this talk is going to be a bit of a story to tell you how I came to create n

um but also I'll be diving into some of the technical details of what it's actually like to try and write audio

code in net and what you can achieve and what some of the big challenges

are um so my story actually starts in the last Millenium how many of you are old enough that you your career began in

the last Millennium um and back in the day we used a variety of languages so um

I was using C and C++ for some things and I was using Python and Visual Basic 6 for other things things and you may

know that the difference between these types of language is that c and C++ they're compiled languages your code

gets compiled directly into machine code whereas python Visual Basic 6 those languages are interpreted your your code

is actually being interpreted at runtime and the general understanding

was if you wanted to do anything that was fast you had to be in the world of C or C++ and with audio you typically do

want your code to run fast because it's often real time also if you wanted to do anything lowlevel so you wanted to call

operating system apis or if you wanted to interact with devices like a sound card I've got a little sound card here

got a little midi keyboard as well which hopefully use later if we have time you want it to be in the world of sea

however it came at a cost and that was complexity it was very easy to shoot yourself in the foot and so we try and

do as much as we could in the interpreted world because even though maybe they were thought of as slow

um the OS was abstracted away it was just easier to work with and you could do what was what we called rapid

application development um but then about the end of the 90s um Java actually came across my

radar and the interesting thing about Java is it didn't fit neatly into either of these two worlds um you may know that

Java compiles you do compile your code but you compile it into bite code which is kind of uh machine code for an

imaginary virtual machine and then the Java virtual machine runs that

um it makes use of what's called a jit compiler which is very fast and efficient to actually convert that b

code into machine code at runtime and it had an Innovative approach to memory management called the

garbage collector which is going to be very relevant for net and in my mind and

I think actually in a lot of people's minds Java was still in the slow category because it wasn't in the compiled world but then I stumbled

across this project in the late 90s it was called Java layer and what they these guys had done they had implemented

a full mp3 decoder in Java and of course in the late 90s MP3s were all the rage

we were all ripping our CD collection to MP3 so we could play it in Winamp and

this this surprised me I wasn't expecting this kind of thing to be done in Java and not only had they done that but they had implemented a player so it

could do it in real time decode your MP3s to we and play it through the sound card and so that blew my mind and it was

actually the first thing thing that I converted to net it's um on it's open source it's actually been Rewritten

twice since I originally did it um however not long after that net came

along and I was very interested in net because I was primarily a Windows programmer and Java wasn't really um

very Windows friendly if you made a a Java app it didn't even look like a Windows application you had this jar

file and people on Windows like how do I run a jar um so net was very interesting to me and one of the Microsoft's

Innovations was they had multiple languages so they had vb.net which was similar to VB but all the VB6

programmers hated it it wasn't actually the same they had visual jsharp which was actually Java for net did anybody

have The Misfortune of using that one other person not many people use that Microsoft got into legal

trouble with it but that was actually the the way I initially ported that Java layer project to um net C which of

course as we is now the flagship language and there was also a thing called managed C++ where the idea was

you could take the Best of Both Worlds you could have the best of um managed

code.net and uh native code although I found it incredibly confusing to use

kind of gave up on it and when net came out in beta I filled in my details so it

could be posted to me um the the beta on four CDs because my modem wasn't fast

enough to download the whole thing um and the first thing I looked for was where is the audio supporting net I read

all of the apis I'm like there must be some audio because Java can do it where's the U net and there was nothing

virtually nothing it was it was useless and so that spawn this idea why don't I

create my own audio library and surely Microsoft will in the next version of

net they'll fill it in and my audio library will then become Obsolete and so I started working my evenings and Spare

Time on making an audio I called it everything in netland was called n something because everything in Java

world was J something um and I had two goals one was I wanted to make it

possible to call any Windows audio API so anything that Windows could do with audio I wanted you to be able to do it

if you a net programmer and I also wanted to make a collection of building blocks um that were commonly used things

that people making audio applications would be able to use to build their own audio applications because really I didn't want to make a library I wanted

make my own Audio Apps and so I worked away on this in a while and I got a few initial things

working I got audio playback and recording I was able to read and write wave files and MIDI files if any of you

are into music production you'll know what a midi file is um and also I really wanted to be able to play MP3 because

that was the most important audio uh file format at the time um but then a few years later I got

a job at a company called nice where I'm still working it's actually almost 20 years so it's a it is a fairly nice

company to work for but they were about to embark on a brand new project um they

were going to build an incident reconstruction application so if something bad has happened and you want

to piece together all of the 999 recordings all of the police radio all of the um CCTV cameras you wanted to put

it together in a timeline and Playback what had happened for an investigation and this was all going to

be done in net and I realized this was this was actually the perfect use case for n audio because um although in my

mind n audio was all about writing music apps because that's kind of what I'm interested in um this is a voice

application but actually many of the things that it needed the same kind of things that I was needing to make um

music applications so it could do so I volunteered and I said let me be the one who writes the code the audio mixing

engine for this application so I implemented things like variable speed playback some basic effects like

automatic game control so if someone's talking too quietly you amplify them had

to deal with things like live streaming so that you're playing audio while it's still being downloaded and sometimes you

have to buffer and and stop um we also had to do audio and video synchronization I don't think anyone's

ever tried to synchronize videos it's really horrible um because if You' got two video players and you say jump to

this time they won't actually jump to the time you've asked they'll go go somewhere rough close and now now

they're out of sync and you got to try and get back in whereas with audio it's actually a little bit easier if you've

got a few bits of audio you don't individually play each bit of audio what you do is you mix it together before you

give it to the sound card and that means that you can always stay in sync and wherever you jump to you will never

drift out of sync from the previous times you played it um and this thing had a mixing engine

to do just that it was a 32-bit floating point mixing engine again any of you who are familiar with um audio production

will know that you typically use 32-bit or use floating Point um samples to do

audio manipulation you want to get out of the integer world but the sample rate

um was a lot lower than you might expect if you know anything about music production sample rate was 16 khz and

that's because for voice applications um the human voice is perfectly intelligible at quite low um example

rates so I worked away on this um I also had to do things like um visualization

of waveforms so some of that is also open source um on the internet of drawing waveforms and doing um Spectrum

analysis that kind of thing and probably the most interesting thing that this application was used for was there was a

big um incident where a plane took off and hit a flock of gulls um and the pilot

made the decision that he couldn't get back to the airport and he needed to land on the river and they did a big

investigation to piece together everything that had been said on air traffic control and I believe this

application was used um for them to listen back and reconstruct what happened and it's uh been turned into a

movie as you can see um now to rewind a little bit um how

many of you have read your employment contract oh my well well done a few of you quite boring probably somewhere in

your contract it says any code that you write while you're employed by us belongs to the company and so I realized

this could be a problem if I just took all my an audio code that I've been doing in my spare time and just stuck it

in a commercial code base I could get into a weird situation so I thought right n audio um at this point although

in my mind it was an open source project what that meant was I had a page on Source Forge anyone remember Source

Forge and I couldn't work out how to use their Version Control so I just occasionally put a zip file with a dll

in it up on there and I thought it need n AIO needs to be a proper open source project and fortunately Microsoft had

just decided they were going to make their own open- source um hosting website called coplex anyone remember

coplex um and this was much better because it was um an open source site

that Windows programmers actually knew how to use so that was brilliant I got my code on coplex and I also needed to

choose a license and Microsoft as they I want to do decided that none of the

existing open source licenses were any good and that they had to invent their own um so they invented their own

Microsoft licenses and I chose the Microsoft public license which is a commercial friendly open source license

so it meant that the N audio code you can use it in a closed Source um application if you need to um I've

actually backed out of that now and it's well not backed out of it being used in close close Source but I'm using MIT MIT

because nobody knows what those Microsoft licenses actually

mean um so let's shift gears now and let's talk a little bit about some of

the challenges that I encountered when trying to implement audio code in net

and the first big challenge is um P invoke I had to do a lot of what's

called platform invoke to call all the windows apis there's hundreds of Windows apis and the way you do this is

basically you get the C++ headers header definitions of every method that you want to convert and then you have to

work out how to convert it into a signature so for example um in the Windows audio OPI there's a method

called waveing get devc caps and that is a method to ask your recording device

what capabilities have you got and this is in the win mm dll which is part of

windows so you you decorate it with a dll import attribute you say what dll

it's in um so you can do this for any dll it doesn't have to be part of Windows and you mark your method as

static xter and then you have to go through every parameter of that method and work

out what the equivalent um net type would be and that actually can be quite

challenging because the C the C++ programmers love their hash defines and so you have to often follow a chain of

hash defines to work out what what actually is a w pram or a dword or whatever and so after a while you get to

learn a dword means it's four bytes so I can use an INT um you know a word is two

bytes so I can use a short uh one of the mistakes I actually made was um when I

was doing this it was in the world of 32-bit operating systems and so a pointer and a dword were the same size

and so often I just used INT in the method signatures however when we went to

64bits pointers are no longer 32 bits long they're 64 so I had to use int

pointer um everywhere and fix that all up so you map all of these parameter

types but also C++ programmers love their structs loads of methods have got

um structures and so this method um has an out parameter of wave in caps too so

in other words when I call this method I'm going to give it a memory location and this non. net code is going to write

into that memory location so we need to define the layout and so you have to do all of this for every structure as well

you can actually doesn't have to be a c struct it can be a class it works just as well you have to mark it with the

struct layout and you have to say that it's layout kind sequential and what

that's basically telling net is you don't have freedom about where you stick these things in memory can't move it

around to be more efficient because something else is EXP expecting the memory layout to be

exactly like this um another thing that you'll know if you've done any C or C++ programming

is that there are many ways to pass strings around you can pass pointers to a string or your structure can just have

an array of memory that may or may not be null terminated and it might be

single bite per character or it might be white wide characters and so whenever you have a string you use this martial

as to say what kind of string marshalling am I make making use

of so I I had to do a lot of this many hours um many getting it wrong and

crashing my uh probably Windows XP or whatever it was back then I was using

um the next challenge I want to talk about though is garbage collection and

in one sense the um the garbage collector in net is really great it's actually one of the points of the

language um I've mostly got nothing bad to say about it it uses a very intelligent algorithm called the

generational Mark and sweep algorithm and basically what happens in net with

garbage collection is your program is running away and running along as normal and at some point not under your control

net will say you're using too much memory I'm going to do a garbage collection and at that point every

single one of your threads stops nothing in your appli at all is running and then it does a bit of a look around it sees

of all the memory that's been allocated is any of it not in use anymore and it frees that up it doesn't necessarily

have to free all of it up sometimes it just does a little bit for performance reasons and then it's also allowed to

move stuff around so after it's freed up some memory if it wants to it can do a bit like a defrag and just sort of move

everything together and this is like I say on the whole brilliant works really well

doesn't cause any problems but for audio programming it causes two very big

problems or it can cause two big problems the first problem is that anytime you're pausing it interferes

with your ability to write low latency code and so what do I mean by low latency well imagine I've got my midi

keyboard and I'm making a synthesizer and so I want when I press my key on the keyboard I want to immediately hear the

sound I don't want to hear the sound um half a second later because that'd be

just un unplayable and so often you're talking about say 10 milliseconds

sometimes less is what you would like and so the way you achieve this is when you're playing audio you give the sound

cards 10 milliseconds of audio and while it's playing that 10 milliseconds of audio you're making the next 10

milliseconds of audio and so as long as you've got your next 10 milliseconds ready everything is fine if you miss

your chance to give that next 10 milliseconds what you'll hear in the audio is crackles and pops and that

doesn't sound good you certainly don't want that in a live context and so there is a big risk that if the garbage

collector jumps in in the middle of your 10 milliseconds and steals some of it hopefully not all of it but you now run

the risk of a Dropout so that's the first big problem the second problem is the compaction problem because we've got

this mixture of net code and native code if I've given native code a pointer to a

b and say you know please soundcard write the audio that you're recording into this bite array and then the

garbage collector just moves it somewhere else you will crash your computer which I did uh many times when

I was initially writing all of this so what are the solutions

well there's there's no solution to the garbage collector running other than

writing allocation free code so not actually um giving the garbage collector

anything that it needs to do and in one sense it's not that hard to do with um audio programming because you can

pre-allocate your buffers so I can make two 10 millisecond buffers of audio and I can give one to the sound card while

I'm filling the other and when the sound card's finished that one I just start filling that one up again rather than keeping on um allocating new memory now

unfortunately your audio code might not be the only code if you're' running a Windows forms or WPF application then

that's allocating memory all over the place and the garbage collector will run at some point

um you can also pin um objects so you can tell the garbage collector you're not allowed to move this or you can say

actually I'm not going to ask net for this memory I'm going to ask the operating system and so the operating system gives me some memory and then

that's not going to move anywhere um so just to show you um how you do that um

in cop there are two very unused keywords or rarely used keywords unsafe and fixed um don't if any of you have

used them the unsafe keyword I think does a very good job of scaring most programmers off using it but if you mark

your method as unsafe then you can get a c style pointer to a bite array and in inside a

what's called a fixed block and in that fix block it is guaranteed that the garbage collector is not going to move

stuff around in memory um however you can't always be in a fixed block um so

sometimes you need to use the GC handle so you can say GC handle Alec and you

tell it give me a pinned um handle to this object and then you can get the uh

pointer to it and then you can give that to the unmanaged code and you can free the handle when you're when you're done

with it um if you want to use native memory

there is um in the Marshall classes a number of useful things including Alec H

Global so you can just say operating system give me a megabyte of memory and then you can get poed to it but now

you've got the problem like if I've got a C structure how do I get copy the

contents of that structure to a native point or vice versa so you have Marshall structure to pointer and the opposite

way around Marshall pointer to structure to copy memory backwards and

forwards one of the other big challenges I faced was making a decision between

porting algorithms um and so by algorithms I'm talking about things like

Digital Signal processing maybe effects resampling or fast FIA transforms that

kind of thing or just doing interrupt wrappers to Native dlls that have

already got them and actually a codex is of course one of the big examples here

where you might have to make this decision and both have got advantages and disadvantages so one of the big

advantages of interrupt to ative code if I've got a dll that's got a codec implementation it's going to be a lot

less work for me to just write P invoke rappers to call that code that dll than try to Port the entire codec into um

C in theory I'm not sure this is necessarily has to be true but in theory ought to run faster because that dll has

been um well optimized and um compiled with all the necessary Flags to run as

fast as possible it's also much easier to keep up to date so if you

if you've ever ported an algorithm from one language to another and then the next week it's like surprise is a new

version of the original code base now you've got to go back and do all the diffs and work out what I have to change

in my ported version whereas with P invoke hopefully it's just a case of dropping in a new version of the

dll also if any of you have done porting um code between one language to another

um it's very easy to make small mistakes and I found this particularly with bit manipulation like there's often really

subtle differences between languages where the same syntax doesn't actually do exactly the same thing um between the

two languages however the big downside to just saying well I'll just um do pinvoke

around a native library is that I now can't run everywhere I can only run on the systems where I've got that dll

available and so the advantage of porting to manage code is of course that it's portable and that you can run in

sandboxed environments now who remers silver light I loved silver light and I wanted to do audio in it but I couldn't

use anything that had pinoke in it because it was a Sandbox it wouldn't let you do that and so that made me start to

want to try and convert some algorithms to C but also I've never used it but um

Unity is a C programming language runs on different platforms and people are like oh can I use an audio and the

answer is well yes yes you can use n audio but you can only use the bits that aren't calling Windows apis because

they're just not there on your target operating system um one of the examples of this

was resampling so resampling you may know that with audio every audio file

has a sample rate and sometimes the sample rate of your file isn't the sample rate um of the sound card and so

you need to change resample the audio um so that you can play it and also so you can mix it together with other files

and at first I thought oh I could probably do this myself you know how hard could it be um actually it turns

out that unless you've got some quite good mathematical and digital signal processing knowledge the resampler you

implement yourself will actually sound terrible um so I then started finding things I

could wrap and windows has no fewer than three apis um all horrible to to wrap um and I

ended up wrapping all three of these because different versions of Windows had different ones if you're on a server

Os or if you on a um Windows XP or something you could only access one or

one of these three um but even having done all three of those it still wasn't universally available everywhere that I

wanted to use it and so I thought well maybe I can find an open sourcery sampler and Port it to

C and one of the problems you run into is virtually all open source audio code

is licensed to GPL or lgpl which is not comp compatible with a closed Source

friendly license um so but eventually I found um company called cockos who make

the reaper digital audio workstation which is the one I use um they had a resampler Whose license look compatible

so I reached out to them and they were okay with me uh porting that so n audio has now got a fully managed um audio

resampler okay let me just check how we're doing for time I think we're doing okay um Windows apis now Windows has got

a number of ways of um providing audio functionality and I've ended up writing

rappers pretty much for all of them um I'm not going to talk about them all but just

briefly um the first one and the one that's been around the longest is Win mm

and this came out in 1991 it's still supported fully supported in Windows um

the multimedia API and the probably most the well-known uh apis in this are wave

in and wave out which allow you to record audio and play audio but there's a bunch of other things for dealing with

codex and M and dealing with your mixer and that kind of stuff

um unfortunately these have I'd call it high latency I've never really got below 50 milliseconds of latency with these

apis um one of the things that um this

API lets you do is when the sound card is finished playing audio it can tell you that it's finished playing audio so

that you need um so you can provide the next buffer of sound and it gives you a

choice of how it tells you and one of the choices was it can call a function I thought that's perfect I'll

give it the address of a fun function and it can call my function when it needs more audio um first of all I

realized you need to pin that function because if you don't it will move around and your app will crash but secondly I

found that you got kinds of horrible Deadlocks if you did the wrong thing in a callback from native code into managed

code um so the next option was you can get it to post a a Windows message to a

a Windows message pump and that works really well apart from it annoyed some users of n audio because it meant you

had to take a dependency on Windows forms you had to kind of have this fake hidden window somewhere that was

receiving uh messages um and so the third option which I wish I'd done from the beginning

um was you can just have a mutex and you can say it will set the mutex and you wait on it and then you provide the

audio and so that's the way I recommend you use it it's slightly weird weirdly named class in an audio called wave out

event but that means you're using the mutex uh for the

callbacks so a mutex is an operating system construct that basically says um

I'm I want to be able to block any other process um from doing anything until I

say I'm ready so one process can if you like hold lock the mutex and another

process can say I'm waiting for that mutex and when the first one says I'm finished then it signals the other one

so it's a way of writing it's a way of writing thread safe code but it can also be used for interprocess uh

Communications yes it's it's a lock essentially a lock is is doing that behind the scenes there's there's a lot

there's a lot of different types there semaphores and so on I don't know what the locks using um actually there's a

lot of locking in an audio because typically you have an audio thread and you have a gooey thread and um you've

got to be very careful um was zappi is an example of an API that is com based

and with com objects you've got to sometimes you can't call them on a different thread from the thread you

created them on and so there's a number of Hoops I had to jump through in an audio try and make it so that you did

you created the com object on the right thread to use it so was zappi um in 2007

Microsoft decided they were going to break everything and change everything with um Windows Vista and one of the

things they did was they completely wrote rewrote the Windows audium audio system

substack and so was wasapp is Windows audio subsystem API and actually in many

ways it's a much better API than the old one it gave you choice of exclusive or shared mode so exclusive means I'm the

only one that's allowed to talk to the sound card um whereas shared mode is you're sharing it with other

applications and so in exclusive mode theoretically you can get much lower latency

um one of the real annoyances was in its initial uh implementation you had no

option but to give it um audio in the sample rate that it was already playing

at so if you had just played a CD you had to give it 44.1 khz if you just

played a DVD you had to give it 48 khz and that was part of the reason why I

needed a resampler so that I could convert your audio to what was appy wanted it in um they have actually um

changed that now so you can tell was zappy I'm giving you audio that's 16 khz

integer um and you just convert it for me which is brilliant so that's now Inn audio uh another great feature that was

zappi had is loot back capture so you could finally record the sound that your

um your uh operating system is playing you can actually with waspp although

I've not got this into n audio yet because it would be a breaking change to the API you can actually record just the

output from a single application now on Windows um and so actually waspp is

probably the best thing to use now I would say I recommend it if you're doing new applications you want to play audio Windows use wasapp it is better than win

mm finally um but then in 2016 Microsoft

introduced another um API as part of the Universal Windows application this was called um

audiograph and I was very excited about this one because this was the first one that was callable immediately from net I

didn't have to do any interrupt rappers for it um you could call all of the apis and it was actually a really nicely

designed API it was a graph based API so you had the concept of input nodes

output nodes and submix nodes and so you built together a graph which we'll talk about in a minute and so I thought

finally this is it n AIO or large parts of n audio don't need to exist anymore because Microsoft have made what we need

however it has one gigantic gaping hole and that is you cannot make a node that

transforms audio or generates audio unless you make a completely separate project that's com

object and you do it in that project and you have to use lots of unsafe code and fixed code to do that you register the

com object in Windows and then your application loads that and so it's very

frustrating but I think hardly anybody I don't know anyone who who uses that API um apart from maybe very simple

applications so the best um Windows audio API is not made by Microsoft it's

uh have any of you heard of AIO any of you who do music production will know about this

um is this was made by Steinberg in 1997 and basically it's ideal for low latency

that's what it's intended for people who are doing recording and Playback so if you bought a nice sound card something like external USB one like I've got here

that will have AO drivers and one of the really nice things about the way it

works is it uses this buffer um swap for record and Playback so Windows thinks of

record and Playback is two completely separate things um whereas AIO you do

both together and so when you get the Callback it's give me more audio to play and here's what I just recorded and the

great thing about that from a music production perspective is that you want to perfectly synchronized if I'm

listening to the backing track and playing my guitar I want what's recorded to be perfectly synchronized to what I

was hearing and AIO makes that um much simpler and AO is also a good example of

the benefits of being an open source project because I don't think I would have known enough to do the pinvoke

rappers for AO but somebody contributed um a really great set of AO rappers and

it basically means now anyone who's doing net can use n audio um for uh

using AIO and doing some quite low-level faster audio

programming okay the next challenge I want to talk about is designing audio apis what makes a good audio API and

I've kind of hinted at this already when we talked about audio graph in um audio

it's very common for you to construct what you might call a signal chain so guitarists love this they plug their

guitar into a pedal and that goes into another pedal and so on all the way to the amplifier and basically n audio copies

this idea you're building up a a graph or a signal chain of audio and of course

it can be a bit more complicated than that you might have multiple things producing sound so you might have the

microphone is recording and you're playing a file and you might be transforming those sounds in different

ways I might put a Reverb effect on the microphone but I might also want to do visualization as the audio is coming

through I might want to show a volume meter or a waveform and then I want to mix the audio together which would mean I need

to get into the same sample rate if it wasn't already and then I might actually send it to multiple places I might play

it out the sound card and save it to a file and so any audio has got a couple

of interfaces that U support this the two most important ones and the lowest

level are the wave provider and the sample provider um The Wave provider basically is all it's saying is I'm

something that can give you audio and so it has a wave format property that tells you this is the sample rate is it mono

or stereo how many bits is it might even be compressed and then a read method

which um if any of you have used streams will look very um familiar you're saying

I want to read some audio into my buffer and I want this many bites and it will tell me how many bites of audio it

read and this is great it's very flexible but if you're writing audio code it's very annoying because um what

you really want is samples you want access to the individual samples you don't want bites so there's also I sample provider

which is exactly the same thing but you're getting floating Point samples and so in N audio there's lots of helper

methods that try to get you to sample provider as quickly as possible so once you're at sample provider you can change

the volume you can mix things together you can visualize you can do fast through transforms whatever you want to

do with the audio samples however going from bite array to

float array is actually not as easy as you might think because if you declare a

bite array and then try and cast it to a float array that will not compile um so

what do you do if you've got B array that has got your audio in but you actually know that inside there are

floating Point samples well one option is the unsafe

and fixed keywords that I just talked about um so that will let you cast between you put it in a fixed block you

can then cast between a bite array and a float array however that wasn't great for n audio because then I would

basically Force unsafe code on everybody and lots of coders are not comfortable

working in that world couple of other options I just copy it okay I've got a bite array I'll have

another float array and I'll just copy copy stuff into the float array and there are some helpers that will do that

buffer. block copy will copy everything in a bite array into a float array if you want but of course it's an

unnecessary copy and so I was kind of stuck and then the same guy actually

that contributed the AO rappers gave me this almost mad genius feature called

The Wave buffer and what wave buffer does is it takes advantage of a capability in um C of dealing with

unions and in C++ a union is basically a structure that says at this memory location there might be this there might

be that or there might be something else and because you need to be able to call unions or methods with unions in C the

struct layout layout kind explicit lets you do that so what can do is I can say at memory address four there might be a

bite array there might be a float array there might be a short array and what that means you can do is

you can write into one and read out of the other and when I first saw this I thought that is madness that will never

work it works absolutely perfectly it's worked for 20 years across every version of net the only weird thing is don't try

asking the float buffer what IT sizes because it's confused about what IT sizes but you can read write into one

and read out of the other so that gave us casting however if only there was a

feature in net called span of tea wouldn't that be lovely and of course that came in net 3.1 um so had an audio

been written many years later I would have used span of bite and span of float

and span has got for those of you who are not familiar with it it's got a number of benefits one benefit is a span

can be backed by managed or unmanaged memory it means you don't have to care whether you asked the operating system

for the memory or you asked net which is fantastic span also knows how long it is

so you don't need the length parameter anymore and spans can be sliced so you

can just say I'm just show me this window if you like of the memory so you don't need that offset parameter either

so it just makes everything uh a lot simpler and of course as I just mentioned they can be cast so you give

me a span of bites I can say actually I know there's floating Point numbers in there so will use memory marshall. cast

and turn my span of bites into a span of floats read in or out um really super

convenient and I actually ma made a branch of n audio that converted everything to span um it's in the GitHub

repo and it kind of got stalled partly because the VB people complained that you can't use spans in vb.net which

surprised me because I thought you could do anything that you can do in C um but also um it's quite a big change to n

audio and so I'd either need to support old and new methods or write lots of adapters or lots of documentation so

it's kind of parked unfortunately um some other great things

that have happened I I call this recent by recent I mean things that have happened since um n audio began 20 years

ago so one of the greatest things was net core coming along now just.net

suddenly n AIO becomes crossplatform however as I have to keep pointing out

and GitHub issues just because it's crossplatform doesn't mean that on Linux windows apis will appear um so you can't

use the bits of n audio that call um Windows apis if you're not on Windows but I love the focus on high

performance that has gone into it that's really important obviously for any audio applications that are real time um

there's also been a lot more low-level stuff added to C you can better support for function pointers better control

over the actual um I instructions that you compile um

which is useful for some com based things and there's even now code generation for pinvoke to make pinoke

much faster um again something probably if I was redoing an audio I would be um

looking to do looking to make use of so can you use uhet for n audio

hopefully I've persuaded you the answer is that yes you can it's not NE perfect

but there's an awful lot you can achieve um in net I've built the N audio um

toolkit I've got a fully managed MP3 decoder in net um all of this is open

source I even made an application that could transform your voice in real time

um over Skype so it intercepted the audio and put silly robot effects on sadly that doesn't work anymore because

of a breaking API change um I made applications that converted midi drum

grooves from one drum sampler to another um and I've actually used n audio in a

number of quite large commercial products um for all kinds particularly

telepan related and I know of a lot of companies that are using n audio in telephony relate and radio related um

use cases so there is a lot that can be done um with net um before we get onto a

demo because I've got a short demo um for us at the end um I wanted to give a little status

update on the audio project and I think this is actually an issue that we're

seeing a lot of in the open source world at the moment and that is the fact that many of the open source projects that we

um know and use were just started by enthusiasts like me in their spare time working with in their evenings just

having fun making stuff and sharing it with the world um and essentially you're

just kind of offering your efforts for free but over time um you know that was 20 years ago other things have happened

in life I've got children my time for working on it n audio has become uh

greatly limited and so essentially what I find myself I'm kind of maintaining n

AIO um I'm usually answering people's questions almost every day but in terms

of adding new features to it or doing sort of big changes like converting to span of tea that's really not happening

and so I'd say it's no longer under active development and so I am interested actually if anybody does want

to join the project and got enthusiasm for it maybe that's why you're here um I

am open to new maintainers um but unfortunately not a lot is happening in

terms of new features of n audio partly because I'm not using it in my day job anymore um that that helped a lot when I

was using in my day job it inspired me to add a lot new features okay so I've got some links

where you can find out more probably most relevant one is where n audio is on GitHub um but I thought we'd end with a

very short demo um so I just give you a moment to if you did want to take a

photo of that shouldn't be too hard to find on the internet anyway just with a search but we're going to jump into

visual studio and don't worry that you can't

see the code because we're not really looking at the code but this is a very simple application um that if I start it

up um so when I start this application up it's going to let me choose which sound

card I'm going to play sound out of I'm going to choose my focus right device

and what it's going to do it's going to scan for all midi devices and these little keyboards are called midi devices

midi is the protocol that tells you what notes you're pressing and it's going to listen out

for notes being pressed on the keyboard and then what it's going to do is when it hears a note it's going to use a syn

a software synthesizer all written in C to play the sound and it's going to use a file format called sound font which

essentially takes recordings of real instruments and tries to map them to notes on the keyboard so if I play some

notes as if this is working we will see it is playing the sounds I'm also

printing out the midi noteon events how hard they pressed each note if I press

the these pads um those pads are sending midi on

channel 10 which in MIDI means but um that's the drum channel so it's playing

drum sounds um and then the final thing is that um

and I didn't I didn't actually write this but somebody else wrote this a midi sequencer so a midi file essentially

records What notes you hit on the keyboard at what times you hit them and then you can then play that back so the

midi sequencer will then try to play back the same notes at the same times so I've got a key here and if I press this

it's going to load a midi file it's going to sequence it play it back

through the sound font and I think this would have actually blown my mind this demo when I first started in audio I

didn't believe that net would be able to do something like this in real time but um maybe this won't be impressive to you

but this is going to play a midi file if it works

[Music] okay

so that is that that is the end of my talk and I'm happy to take any questions

in the last few minutes

[Applause]

Engels (automatisch gegenereerd)