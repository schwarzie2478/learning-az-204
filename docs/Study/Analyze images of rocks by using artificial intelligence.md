---
status: stored
dg-publish: true
tags:
  - study/visualstudiocodechallenge
creation_date: 2024-05-10 11:11
definition: undefined
ms-learn-url: undefined
url: undefined
aliases:
---

| MetaData   |                                              |
| ---------- | -------------------------------------------- |
| Definition | `VIEW[{definition}][text(renderMarkdown)]`   |
| Homesite   | `VIEW[{url}][text(renderMarkdown)]`          |
| MS Learn   | `VIEW[{ms-learn-url}][text(renderMarkdown)]` |
## Learning objectives

> [!attention]
> Lesson is missing images

In this module, you will:

- Import AI libraries
- Download and import data to use with an AI program
- Learn how to clean and separate data
- Discover how computers read photos as images by using binary format
- Use code to read an image and assign the correct rock type

Follow along with video [[Use Artificial Intelligence to Classify Space Rocks Learn with Dr G]]


## Install [[Anaconda]]
### install environment
```shell
conda create -n myenv python=3.7 pandas jupyter seaborn scikit-learn keras pytorch pillow

conda activate myenv

```

pandas jupyter seaborn scikit-learn keras pytorch pillow are all channels for retrieving packages
### Install [[torchvision]] package
```
conda install -c pytorch torchvision
```

Retrieve torchvision from library pytorch (also channel?)

## Learning objectives

In this module, you will:

- Get an introduction to AI
- See how humans classify objects
- See how machines classify objects
- Learn about AI libraries
- Install AI libraries

## Moon rocks: Dissect the Moon

In this lesson, we'll use two types to classify rocks: _basalt_ and _highland_ (also known as _crustal_). Both of these rock types are found on the Earth. But for our study, we'll look only at the lunar variants; that is, rocks from the Moon.

### Basalt rock: Dig into a Moon crater

Basalt is a dark rock. Scientists believe basalt comes from ancient volcanic eruptions on the Earth's Moon.

### Highland rock: Brush the Moon's crust

Highland rock is lighter than basalt rock because basalt is made of heavier elements like iron and magnesium.

# Classify space rocks like a human



To build an AI model to detect rock types, we need to consider how humans classify things.

In this section, we'll outline a common thought process that humans follow for examining and classifying data. Later, we'll use these steps to form a model for our computer to do the same tasks.

### Step 0: Get data

We want to collect as many rock images as possible. 
### Step 1: Extract features

First, our brain tries to extract patterns from each image.

This is our human [[feature extraction]] engine
### Step 2: Find relationships

Next, we try to find the relationships between the features and the type of rock that's shown in a photo of a rock.

we come up with some rules.

### Step 3: Classify types

Last, we try to use these relationships between known items to determine how to classify a new item.

Then, our brain uses the associations we already made to determine what type of rock it is.


## Common Python libraries for AI projects

The libraries are free and are commonly used in real-life AI projects.

## [[Matplotlib]]

The Matplotlib library is primarily used to visualize data in Python. You can use Matplotlib to create static, animated, and interactive visualizations in Python. Matplotlib is useful for displaying your data in a more visual way.

## [[NumPy]]

The NumPy library, short for _Numerical Python_, is a popular option that's used to organize and store data in Python. You can use NumPy to create structures to hold sets of data called _arrays_. Like lists, arrays store many types of data. NumPy has many functions that are helpful for manipulating data in arrays.

## [[PyTorch]]

The PyTorch library is a machine-learning library. It has many built-in functions to help accelerate building projects. PyTorch primarily is used to modify data in an existing machine-learning program.

There are many other libraries that you can use to create an AI model. To learn about other common AI libraries and what they do, see [Top 8 Python libraries for machine learning and artificial intelligence](https://hackernoon.com/top-8-python-libraries-for-machine-learning-and-artificial-intelligence-y08id3031).


## Collect Data
https://curator.jsc.nasa.gov/lunar/samplecatalog/

## Clean data

To clean our data, we need to make sure it's complete and uniform. In our rock example, many image files have different sizes. For a clean set, we need to resize every image file so they're all same size. We might have to fill in cells where data is missing, and delete rows with incorrect data.

## Separate data

To program AI, first we give the computer lots of data and tell it what the data represents. This process is called _training_.

