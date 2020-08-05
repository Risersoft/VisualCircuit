---
title: Component Terminal Sets
keywords: Component Terminal Sets
sidebar: viscir_sidebar
permalink: visual-circuit/component-terminal-sets.html
folder: VisualCircuit
hide_sidebar: false
comments: false
---

# Component Terminal Sets

This functionality is used to define the terminal types and nos. in each component. Basically a master list of terminal sets is maintained which defines the type of set and the graphical representation of the set including placement information for wire nos. and terminal nos. This terminal set can then be added to any device and nos. assigned for each terminal. VisualCircuit generates a component graphical image by combining graphics of all terminal sets in the component.

VisualCircuit contains several terminal sets by default. You can use these as it is or look at them as an example of how they are defined and then define your own.

## Terminal Sets Master


![](/images/terminal-sets-master.png)

When you add/edit a terminal set, following screen is presented:


![](/images/terminal-sets-master-view.png)

|Description|Description of this terminal set|
|:----------|:-------------------------------|
|No. of Terminals|No. of terminals in this terminal set.  Depending on this, the grid “Terminal Setup and Location” and the image on the right is setup|
|Set Type|This information is shown during work order schematic preparation and helps to get the correct terminal nos.|
|Image|You can use the browse button to get a graphical image and then use the scale factor slider to adjust the size so that its width does not exceed 2-2.5” in general. This is because the wiring diagram report will print 3 columns in A4 page.|
|Do Not Provide White Space|VisualCircuit adds a white space between terminal sets of a component by default. You can select this check box if this is not required.|
|Terminal Setup and Location|Depending on the no. of terminals entered, the grid displays the terminals and their name and alignment.In the image on the upper right, each terminal is represented by WN-x and TN-x where WN=Wire No., TN = Terminal No., and x = Terminal Name from the bottom grid. You can move around the boxes in the image and VisualCircuit will remember their location.During work order schematic preparation, VisualCircuit will generate a new image based on the terminal set, terminal no and the wire no. Alignment of text will be done as per defined in the terminal set.|


## Component Assignment


Now we can add these terminal sets to the component. On the “Component Terminal Sets” tab, if you add/edit, following screen is presented:


![](/images/component-assignment.png)

Once we select the terminal set from the drop down box, the “Enter Values” grid is populated and we can enter the terminal names for this component. The image on the right is generated showing how it looks with the terminal nos. Wire nos. will be added once this component is used in a work order schematic.

If we check the “Use Separate Interconnection cable” check box, a separate interconnection cable will be generated for buses involved with this component. Otherwise all buses from panel A to panel B are grouped in one interconnection cable.

Finally, when you are finished with adding all terminal sets, the component terminal set tab looks like following:

![](/images/component-assignment-control-item.png)

You can use the “move up”, “move down” buttons to sort the terminal sets and get the desired effect.