---
title: Adding / Editing Control Items in Panels
keywords: Adding / Editing Control Items in Panels
sidebar: viscir_sidebar
permalink: visual-circuit/adding-editing-control-items-in-panels.html
folder: VisualCircuit
hide_sidebar: false
comments: false
---


# Adding / Editing Control Items in Panels


If you add/edit a control item in this screen, following screen is presented:

![](/images/control-item-schema.png)

When the select button is pressed, following is presented:

![](/images/select-control-item.png)

This is the same control item browser but with irrelevant information removed. You can choose a category on the left and then select the item or do it in the full list view.

Anyhow when the item is selected and you press OK, following is presented:

![](/images/control-item-schema2.png)

All read-only fields are populated from the control items database.  If terminal information has been defined, the quantity is 1 and read-only, otherwise the quantity field is editable.

The “Item is Current” marker shows that control item has not been marked as old.

|Name|Description|
|:---|:----------|
|Legend|Legend of this item as being used in the sceme|
|Description Prefix|Description to be prefixed in the material list|
|Description Suffix|Description to be suffixed in the material list|
|GA Use|This field can use to generate BOM for customer GA drawing. VisualCircuit groups the items using “GA Name” and “GA Use” fields. All previously entered values are available in the drop down box and you can enter a new one as well.|
|Device is used for paralleling between similar panels|Sometimes, a device (frequently a terminal block) is used to parallel control schemes of sister units. In such cases, the information won’t be present in the wiring diagram.  But if we check this box, VisualCircuit will generate a cable for this purpose.|

Mounting Guide

![](/images/mounting-guide-add-edit-item.png)

This is fetched from the control item database and shown for reference.
