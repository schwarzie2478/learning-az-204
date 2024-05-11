---
status: planted
dg-publish: true
tags:
  - study/visualstudiocodechallenge
creation_date: 2024-05-10 14:23
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

In this module, you'll learn:

- Common data exploration and analysis tasks.
- How to use Python packages like NumPy, Pandas, and Matplotlib to analyze data.

After decades of open-source development, Python provides extensive functionality with powerful statistical and numerical libraries:

- [[NumPy]] and [[Pandas]] simplify analyzing and manipulating data
- [[Matplotlib]] provides attractive [[data visualization]]
- [[Scikit-learn]] offers simple and effective [[predictive data analysis]]
- [[TensorFlow]] and [[PyTorch]] supply machine learning and [[deep learning]] capabilities

We'll use [[Jupyter notebooks]]

> [!NOTE]
> Data exploration and analysis is typically an _iterative_ process, in which the data scientist takes a sample of data and performs the following kinds of tasks to analyze it and test hypotheses:
![[03-real-world-data.ipynb]]
- **<span style="background:rgba(240, 200, 0, 0.2)">Clean data</span>** to handle errors, missing values, and other issues.
- <span style="background:rgba(240, 200, 0, 0.2)">Apply statistical techniques</span> to better understand the data and how the sample might be expected to represent the real-world population of data, allowing for random variation.
- <span style="background:rgba(240, 200, 0, 0.2)">Visualize data</span> to determine <span style="background:rgba(240, 200, 0, 0.2)">relationships</span> between variables, and in the case of a machine learning project, identify <span style="background:rgba(240, 200, 0, 0.2)">_features_</span> that are potentially predictive of the _label_.
- <span style="background:rgba(240, 200, 0, 0.2)">Revise the hypothesis</span> and repeat the process.

Sample flow

![[01-numpy-and-pandas.ipynb]]

![[02-visualize-data.ipynb]]

## Further Reading

To learn more about the Python packages you explored in this notebook, see the following documentation:

- [NumPy](https://numpy.org/doc/stable/)
- [Pandas](https://pandas.pydata.org/pandas-docs/stable/)
- [Matplotlib](https://matplotlib.org/contents.html)


[[Real-world data ]]will always have issues, but data scientists can often overcome these issues by:

- Checking for missing values and badly recorded data.
- Considering removing obvious outliers.
- Examining what real-world factors might affect their analysis and determining if their dataset size is large enough to reduce the impact of these factors.
- Checking for biased raw data and considering their options to fix the bias, if found.

![[03-real-world-data.ipynb]]


- [ ] Challenge https://github.com/MicrosoftDocs/ml-basics/blob/master/challenges/01%20-%20Flights%20Challenge.ipynb

