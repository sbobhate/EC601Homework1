# EC601Homework1
### Contributors: Shantanu Bobhate & Kexuan Cui

# Description

For this homework we created a simple application that uses _color-based segmentation_ in the _HSV_ color-space. One can change the upper and lower thresholds to extract a certain color. We highlight the contours of the detected object. We used an open-source c# wrapper for OpenCV called _EmguCV_. We used C# since it allowed us to create a windows form application. We also added functionality to save the result.

#### Hue values of basic colors:
* Orange 0 - 22
* Yellow 22 - 38
* Green 38 - 75
* Blue 75 - 130
* Violet 130 - 160
* Red 160 - 179

*Note:* Play around with the saturation and value to get a clearer binary image.

# Installation

The installation files folder contains a setup.exe. This can be used to install and run the application on a Windows machine without Visual Studio.

# Images

We have included a screenshot of the trello board.
We have also included screenshots of the results of tracking a blue, green and red object.

![Result of Tracking Blue](https://github.com/sbobhate/EC601Homework1/blob/master/resultOfTrackingBlue.png)

![Result of Tracking Green](https://github.com/sbobhate/EC601Homework1/blob/master/resultOfTrackingGreen.png)

![Result of Tracking Red](https://github.com/sbobhate/EC601Homework1/blob/master/resultOfTrackingRed.png)
