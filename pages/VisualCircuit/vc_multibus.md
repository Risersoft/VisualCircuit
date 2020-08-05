---
title: Multi Bus
keywords: Multi Bus
sidebar: viscir_sidebar
permalink: visual-circuit/multi-bus.html
folder: VisualCircuit
hide_sidebar: false
comments: false
---

# Multi Bus

Following two assumptions have been made in the connection model of VisualCircuit:

1.  Within a panel, point-to-point connections depend on physical layout and are hence unimportant in context of electrical schematic.

2.  Between Panels or Between Field Area Devices and Panels, it is important to note which exact device terminal is getting connected to which exact device terminal (point-to-point interconnections).

Hence in the normal course of action, a device terminal is associated with only a bus. However, whenever VisualCircuit encounters a bus that is encompassing panels and devices, it marks the bus as a multi bus. When this is done, we see the following when we assign:

![](/images/multi-bus.png)

In such cases, the point-to-point interconnection is stored.

Further such multi buses are available from the main screen using the “Edit Multi Bus” button.

![](/images/multi-bus-control.png)

In this screen, VisualCircuit shows all buses that have been marked as multi bus. For each bus, connected device terminals are shown. We need to select all point-to-point interconnections that exist between panels and between panels and devices.

The ConnectedTo dropdown contains only “terminal block” terminals. VisualCircuit will check to make sure that if Terminal A is ConnectedTo Terminal B, then Terminal B should also be connected to Terminal A.

If you sometimes find that not all “Multi Bus” are being shown in this screen, you can press the “Relcalculate Multi Bus” on the main screen.
