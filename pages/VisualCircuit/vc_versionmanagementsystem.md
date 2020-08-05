---
title: Version Management System
keywords: Version Management System
sidebar: viscir_sidebar
permalink: visual-circuit/version-management-system.html
folder: VisualCircuit
hide_sidebar: false
comments: false
---

# Version Management System

![](/images/version-management-system.png)

Control Schematics reporting frequently involves preparation of material lists. This means that detailed specifications needed for ordering also need to be part of the output generated. Version Management system is a facility to do just that. It works at three levels –



1.  Provides a way to manage item specifications

a.  Make

b.  Supplier Spec

Make and Supplier Spec are generally inter-related.

c.  Our Specs

Additional things specified by you the customer.

d.  Packing Spec

e.  Standard Spec

A list of standards can be maintained and selected for each item.

2.  Provides Spec Number and Revision Number

An item in VisualCircuit can have multiple specs and each spec can have multiple revisions. If you use the “Add Spec” button, the spec number will be increased and if you use the “Add Revision No.”, the revision number will be increased. This will be appended to the item code in the form SxRy where x is spec no. and y is rev no.



3.  In Control items, a component is frequently made up of smaller unit components. For example, a contactor assembly can be made up of a base contactor and an add-on block. While the control circuit needs to work in terms of assembly, the material ordering should specify the constituent base units as well.

![](/images/version-management-system-item-vms.png)

In this case, the spec summary can be used to specify the description appearing in material lists.

![](/images/version-management-system-item.png)

## Editing

![](/images/editing-epics.png)

You can enter the specs as desired. Spec Summary is used in case you want to have a different description in the material list.

Standards can be selected from the list on the left. If you click on the add button, following screen is presented:

![](/images/standard-specs.png)

The WriteAs field is used by VisualCircuit to generate standard list for the specification. Other fields are for information only for easy identification and maintenance.

In the bill of material tab, you can choose versions and specify quantity.

![](/images/spec-bill-of-material.png)

VisualCircuit currently supports nesting upto 1 level. This is due to the face that printing of material list will print only the immediate children of the versions applicable


