---
title: Item Sub Category
keywords: Item Sub Category
sidebar: viscir_sidebar
permalink: visual-circuit/item-sub-category.html
folder: VisualCircuit
hide_sidebar: false
comments: false
---

# Item Sub Category


Sub Category is the second level in the item coding definition hierarchy.


![](/images/item-sub-category.png)


Unit of material is selected at this level. Generally, this can be kept as 5-digit long. Exact length depends upon how many subcategories you will need to define. Since 2 digits of the sub category are in fact the schedule code, you will need 5 digits if no of subcategories in even one schedule can exceed 99.


## Coding System Definition


![](/images/coding-system-definition.png)

In this screen, we define what the rest of the digits in the item code will mean. We first define the no. of groups and then the name of each group and no. of characters in that group.

Optionally we can define a table of values and texts where we can enter meaning of “digit codes”. Sometimes the digits denote just a dimension which is in the item name (for example 6 mm thk = 60) and in that case this translation table is not needed.

VisualCircuit interprets the item coding system defined by you and generates a picture which can be seen in the picture tab.


![](/images/coding-system-definition-code.png)


This picture along with the Remark can be printed from “Generate format Sub Category Definitions” to produce a nicely formatted coding system manual.

Please note that definition and use of coding system Is entirely optional and the generation of other VisualCircuit reports does not depend on it.


## Parameter Definition Screen

![](/images/parameter-definition-screen.png)

These parameters are used to facilitate easy item selection on the document BOM forms. In the item selection grid, the items are displayed along with the parameter values specified here. These can be used to sort and filter the item code grid to facilitate easy identification and selection.



If you have multiple versions in items for this sub category, you can also define parameters for versions

![](/images/parameter-definition-screen-versions.png)

The definition screen for version will ask for values for these parameters. These can be used to help in easy identification of versions.