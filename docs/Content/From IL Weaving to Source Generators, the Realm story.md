---
status: stone
dg-publish: true
tags:
  - content/video/youtube
creation_date: 2024-05-06 13:11
definition: undefined
ms-learn-url: undefined
url: https://www.youtube.com/watch?v=yvKEScPzwiE
author: Ferdinando Papale
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Author   | `VIEW[{author}][text(renderMarkdown)]`          |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |



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


so hello everybody and given the hour also good morning so my name is

Ferdinando papal and I am a mostly net developer at [[MongoDB]] in in Copenhagen

and the reason why I'm here is that I would like to tell you a little bit about why we decide to move away from

[[IL weaving]] and we started using [[source generators]] in the uhet dec of Realm so

who has heard about [[Realm]] before one person amazing so I will

tell you more about it later but realm is an [[object-oriented database]] that is

mostly targeting mobile so just to set up the context we are going to talk

about [[code generation]]. net this because both Isle weaving and sord generators

are two different techniques that can be used to generate code in net and we are talking about the stupid type of code

generation not AI code generation or something like that so just normal code generation let's say so in particular

we're going to see how these were used in the in the reals dek and how uh

and why we decide to move from one approach from the other and what we what we got from it so before going into

this part though we have to you have to get an introduction about what is il weaving and what are s

generators okay first of all so what is il weaving so when you compile C

code it gets compiled first to something called ilil that stands for Intermediate Language that is a sort of highlevel um

high level assembly then depending on your configuration it either gets compiled to machine code at runtime if

you're using [[Just In Time]] or ahead of time if you're using [[ahead of time]] the but there is always this

intermediate step with the with the IL and if you ever work with Java this is a very similar idea to bite code so

this is a platform independent code that then gets converted to machine code when it's
 
necessary so IL weaving essentially is the process of modifying the I code in

some way to do something it almost feels like magic because you can modify

everything with weaving you can add classes change the behavioral methods

change attributes and so on one important thing to remember is that Isle weaving happens after compilation so the

code already needs to be in a compilable state before the is weaving is doing um

is doing anything and another thing to remember is that this is not visible to the user this happening after the code

is compiled so the user doesn't know that anything has happened so why is this is useful well

> [!NOTE]
> it's useful to generate repetitive or  optimized code

just to give you an

example about how I code looks like so if you have a a property like the one

you see on the left with the the string name property what you have on the right is the getter and Setter in

ilil it's not important that you understand what is happening here but it's just to give an idea about how I code looks like and as you can see it's

not really easy to understand what is happening if you don't have experience with it okay now to give you

an idea about a library that is using I weaving and maybe you have used or that could be interesting there is

property change. [[fody]] so if you ever worked with any [[Model View Viewmodel]] framework like uh

[[Maui]] [[Xamarin]] [[avalonia]] [[Uno]] and so on then you know that if you want to

bind something to the UI you need to implement I notified property change the only thing that is on this property is

this event called sorry on this property on this interface is this property change event and the contract

here is that if you're implementing this interface then every time one of the

properties that that are in the object are changing you should raise this event with the name of the property

that is change so this is used by this framework so that they get these notifications and the UI gets

updated now if if you have to do this yourself then from a class like what

you see here on the left you all to do what you see here on the right so essentially what is happening is that

you need to have a baking field for all the properties and then every time a property changes you need to check if

it's if the new value is equal to the previous one then you need to set the Bing field and then you need to call you

need to invoke this event that inside that in this case it's inside this on property change method that you see on

the bottom as you can imagine this is a lot of code to for doing not much and

it's so it's repetitive and it's also error prone for example if you have dependent properties for example if you

have a full name that is dependent on the first name and the C name so in this case you need to you need to take

care of these two so what property change f is doing essentially is going

into your dll after it has been compiled finding classes that are declared implementing this I notified

property change interface and change the IL so that the notifications are raised

uh correctly when the properties are changed one important thing to know is that all of this is invisible to the

user so if you if you have this this library in your code you will still be able to see what you have here on the

left what you have here on the right it's not visible at least in the in

the ID but we'll see a second how you can see it so now okay how do you see um

I code how do you see whift code this depends what do you want to do if for

example you're just curious about how I code looks like for something simple for something that you can just copy paste

and so on then you can use something like [[SharpLab]] that is an online.net

playground and that is useful for various different reason but you can go here

and you can write

something like this I could have written before but okay so and then here on the

right you can see the corresponding code for example here you see the getter for the name property and if you select the

body you also have this this gray background and on the left it shows to

which part of the code it corresponds and actually if you go over it will also tell you what are these instructions

doing if you're interested in that okay so this is one possibility that you can

use if you are interested in how the code looks like for your code for your project or you want to see what is the

effect of is weaving then you need to use something like [[ILSpy]] or any

other the compiler so and I have a small example about it here so here I have a

this person property change class that is declared is implementing this I notifi property change and in this

project I've already added property change of F that I have talked about a second ago so as you can see this is

definition of the class I didn't do anything here now if you get IL spy

and then you open the dll after compilation then you can navigate to

your class so you need to find first the name space and then the class

okay you can go here and select ilil and you will be able to see all of this that

is extremely unfriendly so if you want to understand what is happening you can select the C here and you can see

actually the compile code so the way that it works so for example if you

take here the name property as you can see the the both the Setters and Getters

have been changed to do what I've said before so in this case the setter is checking if the new name property is the

same as before if it's not then we set the baking field and then the it calls this onproperty change method that is

also something that has been created by the by the

weaving and all of this is completely invisible to the ID so if you don't know

what the if you have a library using L weaving the only way to really know what is happening is to use a DEC

compiler because otherwise this is invisible to you but anyway regarding this Library you

can imagine that this is particularly useful if you are working in this kind of a MVM framework even though

nowadays there are also alternatives to this that are using also sord generators okay so this was just to give

you an idea about how to look at I

code okay so now you know what is I weaving at least you should have like a

general idea now we need to look at Sur gener ators so s generators were a

compiler feature that was added in in Net 5 and are part of the compilation

pipeline essentially when there are s generators in your project the compilation happens like you see in this

screenshot that I've taken from the documentation so there is a first step of the compilation then there is the uh

thir generator part of the compilation in which the compiler creates something that is called the compilation

object that is passed to the Sur generator with this compilation object the search generator can look into the

uh project code both from a syntactic and a semantic level and then and then

the SAR generator can eventually generate new source code it doesn't need to but it can then these new files

are added to the compilation and the compilation continues so s generator are only useful

to generate new code you cannot modify existing code and this is one of the

biggest difference is with ale weaving with weaving you can modify what's already there and you can add new things

with s genitors you can only add things they are only additive and another big difference is

that s generators are the sord generation is happening during the compilation it's not something that is

happening afterwards so why are they useful well they use they Camp of

applicability let's say it's very similar to the one of of weaving even

though they have some differences so they're very useful to generate repetitive or optimized code for example

if you have ever used 

> [!NOTE]
> system. text. Json then this is using a source generator at least since net 6

if I remember correctly so system. tex.

Json is a library that you can use to serialize and deserialize Json object

and the way that works is that you define your class somewhere in your code

then in the then somewhere else you have this class that is deriving from

Jason serializer context and that is decorated with this attribute that has the type of the

object that this context should be responsible for this class needs to be partial

because s generators are additive so the S generator then is going into your code is generating a lot of other things and

then when you need to serialize some something you need to pass not only the object but also this

context okay but this library has existed much earlier than S genitors

so the reason why they decided to use S genitors now is that 

> [!NOTE]
> traditionally this library was using reflection so there are some issues with reflection

first of all nowadays it's

also getting a little bit of push back because there is a lot of push for

aot so this will be problematic in aot environment and also it's not very

performant because all of the all of this is happening at run time so what

the S generator is doing essentially is analyzing your code looking at the properties looking at the type and then

> [!NOTE]
> generating the serialization already at compiled time so this is much more efficient and according to the [[dotNET benchmark]]
> 

this is at least twice as fast as the as the runtime reflection approach

okay so this was just to give an idea about a another sord generator okay so

how do you see s generated code well this really depends on your ID if you're like me and you are using visual studio

for Mach then you're out of luck because you cannot see them if you're using if you're using visual Studio for

Windows the traditional one then you need to go inside your dependencies under the analyzers maybe it's a little

bit confusing and then you can find the libraries that have either an analyzer and the S generator and then if you

expand them you are able to see the generated files and they have this beautiful yellow Banner that tells you

that it's generated so you cannot actually change it actually if you want you one one

important thing also is that these files are visible from your ID but are not visible on your file system if you want

you can change something in the project file to make them to have them Ed on your on your file system but it's not

something that is set on by default and also if you do it you need also to remove them from the compilation

otherwise you have you will get errors just as a as a note okay so now

you have an idea about what is weaving you have an idea about what our s jator now we need to take a look a little bit at realm so 

> [!NOTE]
> realm is a relative-object and an crossplatform database that has been created mostly with Mobile in mind

so with devices with lower

capabilities let's say and it's available for a lot of programming languages like C of course Swift codling

uh typescript and so on and it has a lot of nice features among which device sync

that allows to synchronize automatically objects between multiple devices and

with Atlas so mongodb on the cloud those are not the important features

there are two important things that are that are necessary for the rest of this talk so first of all realm is

objectoriented and this means that when you work with realm there is no translation layer there is no mapping

done there is no irm everything works with objects natively so if you're

using an a library that is wrapping a SQL database then you have a translation

layer that is converting what you get from SQL to your objects this is not happening with realm because everything

is already an object and another important thing is that realm objects are live so this means

that when you get the value of a realm of the property of a realm object this

value is coming directly from the database if you're setting the value of a property you're setting it into the

database so this means that 
the objects that you get from realm the objects the collections and so on always reflect the latest data that is stored in realm this is very different to a database that is using for example SQL

because in that case when you do a query you are getting some data in your

objects and then this data is static if you change something in your data then it's not reflect in the database

and the data that you have there reflect the state of the object in the at the time that you did the query instead with

realm you always get the latest data and you can also do it you can also

freeze let's say the object so they keep the same data but that's another thing and I have a small example actually to

show you how does this look in a in a

project okay so maybe going a little bit line by line so on the top I'm

getting an instance of Realm so an instance of my database then I'm creating a j ID just that I'm using as a

primary key so that I can retrieve the object later then I have this ron. write in

this case right is a the equivalent of a right transaction on in an SQL

database then I'm calling add to add an object and

sorry and I'm adding this person where the ID is the ID I just created the name is Mario and the age is 22 then what I'm

doing here is that I am calling real. fine to find this object in the database

and then passing the primary key and as assigning it to this person one variable and I'm doing this a second

time to assign it to another variable this is just to have two different

objects that are point two different objects in memory that are pointing to the same object in database believe

me when I tell you that find is not using any kind of caching so these are two different C object

okay so what I'm doing is that what I'm doing now is that I have a new right transaction and I'm changing the value

of the age of person one to 40 and then later I'm just printing the age of

person one and the age of person two so if you run

this put let me put it on the side and maybe make it a little bit

bigger okay so I mean not surprisingly the age of person one has become 40

that's not very surprising maybe the surprising thing is that also person two. ages become 40 and is why this is

happening this is happening because even though person one and person two are two different objects they're actually

pointing to the same object in database so when you get the value you're getting it directly from the database that's why

um and that's why realm objects are are live this was just to give you an idea about how it looks

like okay oh so now you have an idea about what

is I weaving you have an idea about what are generator and how realm what is

realm now we need to take a look at why we decided to use these code

generation techniques in the first place and why we decided to move from using one approach to the other so when the

library was created that was before my time they decided to to use um

Isle weaving and they decided to use is weaving behind the the model

definition so what you have here on the left is how developers could write a

model for for for a realm object and I was

discussing about this yesterday with someone in realm your model sorry

your objects are your schema there is no other schema defined anywhere else so the way that you define your objects is

your schema okay so as you can see to in order to

define the realm object you just define a class that is deriving from this realm object then you define the properties

like you will do normally with the Setters and Getters there are also some attributes like primary key because this

is a database and that's it it looks almost like a plain old C object apart

from deriving from this realm object class okay now as I said before realm

objects are live so what we were doing with w is what you see here on the right

essentially we were going into the user code after the compilation and we

modifying the Setters and getter of the properties to call get value and set

value without going too much into details set value and get value are methods that are getting the value from

the database or setting the value in the in the database one important thing here is

that what you see here on the right it's an extremely simplified version of what

is the weer doing this is because the way that the Setters and Getters need to be modified depends on the type of the

property it depends also on the state of the object so if the object has been

already added to database or not because if the object has not been added to database then it works like a normal C

object you there is nothing else happening so what you see here it's a

very simplified version this also gets much more complicated for collections and so on so this was just to give you

an idea so now the question is so why did we decided to do this well we decided to do

this because we want to give developer the best experience so the idea here is that developers when they're working

with realm they're working with something that looks like at least a native c-p object when you're working

realm you don't need to worry about calling get value set value or anything else you just use the object like you

will do another another SE object and then we behind the scenes take care of

changing the Setters and Getters so that they they go directly into the

database so and as I said before this is something that is actually hidden from

developers you could have looked at it if you using a a DEC compiler of

course and just to give you an idea so what you see here on the left is the way

that the getter looks like before weaving and on the right you have the

getter after weaving and this is only for a string property so it gets much

more complicated for other kind of other kind of properties so this is just

to give you an an idea about how it looks like it doesn't really matter to understand everything okay so as I said

before I weaving is is an extremely powerful technique because it allows us to hide a lot of

complexity behind the model definition so that user don't need to worry about how the about how realm

Works internally but it also has some major drawbacks so first of all it's not

> [!NOTE]
> really the code that you produce with I weaving is not really readable I

code is made by a series of instructions that looks almost like assembly so it's

> [!NOTE]
> difficult to work with it and this also means that it's very difficult to xtend this part of our code 

and this is this is obviously part of our code

but this is something that is very limited in scope because this is only about the model definition so when you

have to work with when we had to work with it you need to work on something that is completely different from the rest of your

code and just to give you an idea about how the the code that was doing

the weaving looks like you have it here on the left so as you can see it's a series of insert insert insert then

you're creating these instructions and so on and this is only for a very simple property so this gets much more

complicated because we were also using weaving for some other things okay

another problem with weaving is that the changes are not visible for the final user so this almost feels like magic

developers don't know exactly what is what has happened to their code but it works in a certain way

um there is another problem is 

> [!NOTE]
> that Weavers can interfere with each other

because they can modify everything when you have multiple wers in your code then

you need to take you need to consider the fact that there could be another we wer that could be working on the same

code so you could have some unpredictable effects and that depends essentially on the order of weaving Even

in our case for example this property change of for the library that I've shown you before

this this is a library that is implementing I notified property change but this is also something that we are

doing because we have internal notifications so we had to take care

of this essentially so that we don't do the same thing together and another problem is that the

um 

> [!NOTE]
> the code is not debuggable 

it's not debuggable because your debugger as no

code to jump to so if in this case it's only Setters and Getters so maybe you don't expect to be be able to step into

Setters and Getters but still if even if it was for methods you will not be able to debug it okay and there is another

big problem with weaving and that weaving is not part of the compilation

so when you're working weaving as I said before you are working with something that happens after the compilation has

been done so this means that the code already should be in a compilable state

you cannot have in your code and then wait for the we were to come and fix something for you so what is the problem

well a lot of developers asked us why why if I want to declare a realm object

this needs to derive from the realm object class right why do I need to have a base class why can't I simply have an

interface well essentially this was the reason is because if we had the uh

classes declared this implementing this irm object interface like you have

here then this codes needs to be compiled somehow so you the developers

will need to go and then out toimplement the the this interface maybe with

this not Implement exception for the properties and the methods and this looks extremely ugly so then what we

will do is that we will go into the code and then change the

um essentially change the way that all these properties and this methods are working so we decided not to do this

for a couple of reasons first of all this is extremely ugly can you imagine

doing this for all your for all your objects from your database it's it looks

really bad and also this is really this really this gives a really bad

experience because you have all these methods that seemingly are just doing

exception all the way then you run the code and your code is working as a normal so it feels very strange another problem

with this is that if we had to do this this means that all these properties all these methods we will

need to weave them we'll need to do them in the Weaver and as I said before working with the Weaver is extremely

annoying so instead with the approach that we had with having a base class all these

methods or at least the majority of them were implementing in the base class that was in our project so it was much easier

to to manage but this is in the end it's a matter of

developer experience we decided to not go this way because it looks

extremely bad and it gives overall a bad feeling about working with the with the

library okay then at some point I with Net 5

S generators came along and after I think after one year and something we

decided to to give it a go because they were giving more more and more tractions and we decided to move our

approach from using ale weaving to use third generators and in this time we

also had the possibility of doing some changes related to how realm Works

internally so we also had to change the way that the model definition was uh

how the model could be defined so what you see what you have here on the left in this classic Model this is the way

that developers could Define their classes before with weaving so you have your class you have your properties and

then you have your class deriving from real object what you have here on the right is the new model definition so the

one with the S generator approach the CL the properties looks the same the

attributes looks the same the two major differences are that the class is

partial and that the instead of having a base class now we can finally have this

interface why does it 

> [!NOTE]
> why does it need to be partial
> because what is happening with the source generator is that we are looking at
> your code during compilation 

have another file with a the rest of the definition of this class that is essentially implementing these IR

object interface so we are doing all the imple all the things that I mean we are

doing all the implementation for you so all the things that before were in

this realm object class now are in your code base and are implementing by

this irm object interface and as you can see essentially the moving from

the previous approach to the new approach doesn't require too much time you just need to really change two words

in your models and then this is essentially works in the same way for um

for developers there is no other difference in the behavior so it's

just a matter of convenience let's say okay so just to give you an idea this

is part of the code that gets generated for a class for a person class with one

uh string property and there is actually much more happening underneath and so this was just to give you an idea uh

maybe something that forgot to to mention before is that if you want to take a look at any of this 

> [!NOTE]
> this realm is open source
> 

and is free to use at least in the for the local version so you can

go and take a look if you're curious about how all of this is all of this is implemented

okay so as I said third generation for us has a lot of has 

> [!NOTE]
> a lot of advantages over a weaving first of all the code that we are generating is essentially readable and and debuggable
> 

you can even even developers

can go and take a look at what kind of code we are generating also it's a bable

because essentially now there is code that then the buer can jump

to and because you are working with C code that you already should know how it

looks like then it's much easier to understand what is happening and it's much easier to at this

code this this meant also that we had the possibility of working in a much

easier way on some new features that were regarding the model definition and

that was something that was very difficult to do before because imagine that you have to add a new type to your

database then if you had to do it with weaving it's really a pain with surge

generators it's still a little pain but it's much much better and another important thing is

that this is part of the compilation pipeline you don't have problem with interference between s generators and

this is something that the ecosystem is pushing to so this something that will

get is get I mean already has a lot of attention but will get more and more attention there are also some problems

with S generators one smaller thing maybe is the fact is that you're generating text and in the end it

doesn't really matter how your code looks like as long as it's compiles but if you want to be nice and you want your

code to be readable by developers then you need to take care of it because there are no

um no internal features that allows you for example to do to fix the

formatting so you need to do it yourself I I admit this is a smaller problem um

then performance so with weaving the the modifications are happening after

compilation so once you compile this is done once with sear generators this is

something that is happening while you're tying your code and as a developer of a sord generator you have no control over

when this happens this needs to be like this because for example sord generators

can Implement interface so if the sord generator does run you don't have the implementation of the interface and you

will have an error so it makes sense but you need to take care that your sord generator is not doing unne work there

are also approaches that allows you to like incremental generator that

allows you to improve on this but this something for example is only available from net 6 onwards and there is also

another problem the biggest problem for us about s genitors is that they're only additive they can only add new

things they cannot modify what is already there and this means that I can't lie to

you because 

> [!NOTE]
> we didn't completely remove IL weaving we only reduced it so and

why is that well what you have here on the left this is the model definition with weaving you have your class

deriving from real object you have your properties with Setters and Getters now if we had to go to a 100% s generated

approach then it will need to look like what you have here in the middle and why

is that well if you have your properties already defined then we cannot go into

your into your code and define properties with the same name that you cannot do so we will need to use a

different approach so for example you will need to declare your properties as

fields and then we will go into your code look this fields and then generate properties with the same

name this is something that is used for example by if you're working with ma with Zar Son by mvvm toolkit that is

that inside also has the as some features to allow you to implement

automatically I notify property change so what they do is that they look at these private fields and then they

implement the properties that are using these baking fields for to to to

implement I notifi property change okay so why we decided to go against this

well one reason is that this is that moving from the previous approach to

this approach will require more work because now all the properties need to

be filled so you will need to change some something in your code first of all

um second of all this feels kind of wrong because at least with mvvm tool

kit these fields are used by the by the code that is being generated because these are the baking fields of your

properties with realm these fields are only a blueprint and have no use at

least for example when the object is coming from the database because we don't really use the biging fields of

properties so this will just be there and we'll have no use they were and it

looks confusing so overall in order to keep the developer experience the same we

decided not to go for a 100% for a 100% sord generated approach and we

decide to go for the approach that I've shown you before so this one that I have here on the on the right so essentially

the the proper definition is the is the same so you don't need to worry

about fields and then the difference is that you have a [[keyword partial|partial]] class and

then you have a a property ah and another problem another time remember uh

another problem with the the approach here in the middle is that with what we

allow is that your properties can be of any accessibility so your properties can

be public private protected they are still managed by the database let's

say if we had to do something like this then we will need to maybe add other

attributes so that you can specify how you want your properties to be generated and it looks even worse so this just to

give an idea okay but in the end we decided for this mixed approach in

which we greatly reduce the amount of of surg generation that we are doing

okay now what exactly are we doing with SE generators now so we are doing

what you see here on the right we are still modifying the Setters and Getters but now instead of calling a method we

are calling a we are a essentially getting and setting the value on a

property with the same name on something called the accessor and I'm not going to go too

much into details but the accessor is something that we are also um

generating so the I know that this this one on on the right I think it looks

very similar to this one that I've shown in the beginning that was being done by

weaving but this one this is an extreme simplified version of what is happening this is just from the very high level

instead what we have now with with the weaving this is 100% what the

weaving is doing so this is the same for all properties this is the same independently from the object State this

is the same in any case so this is very few lines to do in Isle

weaving so what did we do instead so all the complexity did that before we had in the

weiver now it's in the accessor but this is much much better for us because

the accessory is something that we are search generating so instead of needing to write IL code to do all these checks

all these for the property types and so on then all these checks are done inside the accessor so it's much easier for us

to modify the the way that the Setters and Getters works so we still

have weaving but but it's at it's very limited to compar to what we had

before so we worked on this we started working on this about maybe two

years ago and now I'm really bad with dates and we worked on this for about six months six months was not I mean

this time it's from the from the beginning till the end and so it also

regards other kind of work and it also includes the fact that we

had to modify a lot of things that were happening inside the I mean the internals of real because for example we

moved from a base class to an interface and we published this the

first version of the realm s generator in November 2022 so one year and

something ago and by the way in in the beginning the round. sord generator was

a separate package that was getting picked up with you are getting realm now instead it's inside

realm and so the classic Model definition so the word with weaving with

the base class it's still supported if you want to use it but we are really pushing Developers for for adopting

the new the new Sur generated classes and so the fact that we move to

Sur generators also allowed us to add some features that we wanted to implement for some time but it would

have been a pain to do with with weaving for example the support for

nullability in the model definition that was something that was requested by us we are also planning to add

> [!NOTE]
> [[incremental generator]] that is a a sord generator that is caching some parts so
> 

it's not so performance hungry as a normal sord generator but we still

didn't start with this also because generally real is

something that is used in mobile applications and normally you don't have

you the projects are not huge and the you don't have like a huge amount of

models so so far we didn't have any complaints regarding performance of the

um of the surgery return that we have but and yes and going forward anyway we

would like to move completely to the developers anyway to this surger

approach and our idea is to try to add as little as possible to

the weed classes okay so this is our Dream

completely remove a weaving but this is not something that we can do in an easy way if we want to

keep the developer experience the same and if we want to keep the model definition the same the way that we

could do it is that if the language would allow partial properties as

you can see from this issue on GitHub there is a lot of request for this and actually this screenshot is coming

from I think 3 four months ago I checked yesterday there the numbers are higher so if we had partial properties then

we wouldn't need to have the weing because then we can go and generate the implementation of the Setters and the Getters for you so this is not something

that we have control on but if you want it just go and vote it and

um and this is something that is getting getting more and more attention also because s generators are getting more

and more attention especially now that Native aot is getting is getting

all attractions and you and you are and developers are trying to go away from

using reflection serg generation doesn't do the same thing that reflection can do but it can offer an help in that

direction and recently this is a slide that actually just added there's

also been a talk about [[interceptors]] so interceptors have been added in uh

net six as an experimental feature the idea with interceptors is

that in somewhere in your code you have an Interceptor method that is

intercepting this me another method that is as this path at this row sorry this

line and at this column and the idea that when that method is called instead

of that method being called you have this method so essentially you're doing code

substitution the thing here is that this allows a sar gener s generators to be

they're still only additive but this allows SAR generator to modify code that already

exists so unfortunately first of all this is still an experimental feature so

we don't know if it will change if it will go away probably not because it's

already used by EF by [[Entity framework]] so I really doubt that they will remove

it the biggest problem is that there is no property support so for now this

works only with with methods so it doesn't work with

properties another problem is that but it's a it's another I would say it's a different level of problem is that our s

generator will do much more work because now our search generator is only looking for the model classes and generating

something if this was working with properties then we need to look at all your code and find all the way all the

places that you're using the properties and then probably have 200 lines of intercept location to change the Setters

and Getters this is obviously if the Interceptor will work in the same way for properties that obviously I don't

know and another problem is that

um so our SDK is a library that is used by different developers so we need to

support multiple SDK and C versions so if this is something available for the

latest.net version then maybe we could make this available but then we'll need to find something to support also

developers that cannot use interceptors so I know that there was a lot of negativity but it's a possibility for

now it's just a yeah it's just a possibility so I don't think we're going to go this way

for for some time because of all these problems but it looks promising because

anyway as I said there is a lot of push for S generators to be much more than only

additive so to to wrap up so Cod generation has been an extremely uh

> [!NOTE]
> useful technique for us because it allowed to to hide the complexity of
> the realm SDK essentially behind the model definition developers can use realm objects
> 

as they would use C

object without needing to worry about set value get value type of the property and any other things in the beginning we

were using I weaving that is extremely powerful because it allows to modify the code in any way but it's

also very difficult to use and gives a I would say a bad experience both to us

and developers but I would say mostly for us that had to ride the the weaving this is the reason why we

decided to move to Sur generator that are a more modern alternative and that

are also what the whole ecosystem is pushing forward so both of these

approaches have their own pros and cons their own quick and limitations

but overall we think that the switch was worth it and already with the move to S

generators 

> [!NOTE]
> we were able to add the for example support for nullability
> 

and also now we're adding 

> [!NOTE]
> another feature to help with the serialization and the serialization of objects if for example you are working also with mongodb
> 

Atlas directly instead of trell so it's another thing so we think

that this was a overall the switch was worth it and the so far we didn't get many complaint

we didn't get any complaints actually regarding this so we we think that it was a a good idea because in the end it

mostly simplified our life when we have to work with this so we think that it was definitely work worth

it so this was was what I had to say if you're curious about realm about Sur

generators weaving and some other things that I've talked about there are some links here and another thing that

I have to say is that so I've use the name realm all the time but now there is

a sort of rebranding happening so maybe if you go on the documentation you will see that in some parts it says Atlas

device sync SDK so don't worry about it but we're still talking about the same thing I decided to use this name because

this has been the name so far so I think it's still it's still there and also