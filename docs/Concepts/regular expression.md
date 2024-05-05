---
status: tree
dg-publish: true
tags:
  - concept/SRE
creation_date: 2024-05-03 11:40
aliases:
  - regex
url: https://www.regular-expressions.info/
definition: a regular expression is a pattern describing a certain amount of text
---

Regular Expressions match from left to right.

## Name Captering group

```
(?<name>regex)
```

## BackReferences

Backreferences match the same text as previously matched by a capturing group.  \\1

```
(help) or (\1)
matches:
	help or help
```

## Character Classes

[a-z] as a character class

## Negated Character Classes

```
[^a-z] is a negated character class
```
## What are Zero-Length Assertions

Assertions are patterns that are looked for but are not part of the match result.
> [!summary]
> We assert certain patterns around our desired match.

> [!attention] Lookahead
> looking ahead means looking to the right for the included pattern

A lookahead pattern does matching like in a subroutine.
When it returns, the position of the match engine is still at the position where it was when the lookahead was started.

So   (?!u)  means no 'u' may follow after the current position of matching in the string.

So   (?=u)  means a 'u' must follow after the current position of matching in the string.

input:  quit
regex q(?!u)it  -> match: no
regex q(?!i)uit  -> match: yes
regex q(?=u)uit  -> match: yes


> [!summary] Lookahead operator
>  The operator (?     is used for a lookahead)
>  The operator (?!    is used for a negative lookahead
>  The operator (?=   is used for a positive lookahead

> [!attention] Lookbehind
> looking ahead means looking to the left for the included pattern

> [!summary] Lookbehind operator
>  The operator (?<   is used for a lookbehind )
>  The operator (?<!  is used for a negative lookbehind )
>  The operator (?<= is used for a positive lookbehind )

### Negative lookahead example

Negative lookahead is indispensable if you want to match something not followed by something else.

input: quit
regex q(?!u)
-> not match

Resolution:  'q' is matched, but looking ahead we don't want to see a 'u'. In this case quit is not matched

## What does greedy mean 

Greedy matching is the default behavior of regular expressions. 
> [!info] Greedy
> 
It matches as many characters as possible, which can sometimes lead to unexpected results. 

### Example:

input : "a witch and her broom"
regex : /".+"/g

A greedy regular expression would match the entire string `"a witch and her broom"`

## What does ungreedy mean 

Non-greedy matching matches as few characters as possible, ensuring that the desired patterns are found.

To implement non-greedy matching, we can use various non-greedy quantifiers, such as `*?`, `+?`, and `{m,n}?`


> [!summary] non-greedy operator ?
> To implement non-greedy matching we add ? to a quantifier


![[davechild_regular-expressions.pdf]]