# Flight-Inspection-App
A WPF application that co-responds to a Flight Gear Simulator app.</br>
This app shows the user the real-time flight information and inspects the different parameters of the flight :shipit:.</br> *This app was written in .NET 5.0*


## Getting Started
After downloading the project and the prerequisites, run the application and insert IP and Port in order to connect to the server and then press "Connect". Afterwards, you should pick a csv file (with flight information) and an anomaly detector algorithm (DLL file) to detect the anomalies. As soon as you load the csv file, the flight will begin, and you will see the slider moving according to the csv file lines.


### General Prerequisites

* [Download](https://www.flightgear.org) FlightGear Simulator.
* .NET 5.0
### Prerequisites for Developers
* WPF
* C#
* C++


### Dependencies

* [OxyPlot](https://oxyplot.readthedocs.io/en/latest/getting-started/hello-wpf-xaml.html)
* [HelixToolKit.Wpf](https://www.nuget.org/packages/HelixToolkit.Wpf/)
* [HelixToolKit](https://www.nuget.org/packages/HelixToolkit/)


### Installing
Download the zip for this repository or use git on the termianl. The terminal command is:
```
git clone https://www.github.com/yanirbuznah/Flight-Inspection-App
```
Build the project, go to the Debug folder, navigate to `net5.0-windows` folder and open the `FlightInspectionapp.exe`<br/>
```Path: Flight Inspection App\bin\Debug\net5.0-windows```


### Running The Flight-Inspection-App

<img src = "https://user-images.githubusercontent.com/56928005/114715226-854d5080-9d3b-11eb-8e7a-cde5626cf4f4.png" width="1050" height="450"></br>
After running the .exe file, the home-page screen will show up (as shown above).
There are two blanks you'll need to fill up to connect to the Flight Gear simulator: IP & Port.
After clicking "Connect", press the "Start Now" and wait for the next screen to show up.</br>
<img src="https://user-images.githubusercontent.com/56928005/114501645-0bca3b00-9c33-11eb-9c77-f9df4d203f3c.png" width="1050" height="450"></br>
1. Pick a csv file in order to start your flight. The csv should contain the flight information.
2. Pick a DLL anomaly detector. You have variety of algorithms you can choose, and you can also add more by yourself.
3. By clicking on a specific flight feature, the graphs will show the feature's progress during the flight.
4. The joystick exemplifies the aircraft movement. The left slider represents the throttle value, and the bottom slider represents the rudder value.
5. Anomalies that have been detected will be shown in this box. You will see the name and the timestamp when the anomaly occurred. If you double click the anomaly, the tick on the slide bar will jump to the specific timestamp.


#### Features

* Csv selector: As soon as you pick a csv flight information file, that flight will start reading line by line.
* DLL selector: Option to choose yours/default algorithm that comes with the application, in order to detect anomalies and will be shown upon the main graph.
* Flight-parameters graphs: You can choose a flight parameter and then the graphs (the bottom ones) will present the progression of its value through the flight.
* Joystick: The movement is determined by the `Elevator`(Y-pos) and the `Aileron`(X-pos) values from the CSV column.
* Media-Player tools:
  - Play button: In-case you pressed the `Pause` or `Stop` button, you will have to press the `Play` button in-order to resume or start the flight again.
  - Pause button: Freezes the flight. Stop receiving lines from the csv until the `Play` button is pressed.
  - Stop button: Freezes the flight, but unlike the `Pause` button, by pressing the `Play` button, the flight will start from the beginning.
  - Flight slider: Represents the line progression. You can hold the **Tick** and move it along the slider, and the flight will jump to the correct csv line according to its location upon the slider.
  - Increase speed button: You can speed-up the flight by pressing the `+` button. Each click adds 0.1 to the current speed.
  - Decrease speed button: You can slow-down the flight by pressing the `-` button. Each click decreases 0.1 to the current speed.
 * 3D Model: Shows the state of the plane visually by a three-dimensional model, the model can be replaced by adding a model (obj file) to the 3D planes folder and changing the path in the MultiDimensionalModel.xaml.cs file


#### Implementing your own DLL 

- Make sure your DLL file is inside the Plugin folder.
- Customize your DLL file in a way that the main class there implements the IDetector interface 


### Project Structure
<p align="center">
<img src="https://github.com/yanirbuznah/Flight-Inspection-App/blob/master/UML%20photos/MVVM.jpg?raw=true">
</p>

- Following the MVVM architectural pattern, there's one main View-Model and sub View-Models, one for each user story.
  As shown in the UML diagram above, the main View-Model (called `FGVM`) implements the IViewModel interface, and the sub View-Models (such as `ControlBarVM`, `JoyStickVM`,...) are inheriting from him (as required in our project instructions).
- The Model is created in the MainWindow, and then passed as an argument to the main View-Model's constructor. Later on, the Model is passed to the rest of the sub View-Models.
- Our MainWindow initializes the main View-Model, and the Simulator screen initializes each sub View-Model in his constructor.
- For more UML diagrams and .cd files (supported by Visual Studio) [Click Here](https://github.com/yanirbuznah/Flight-Inspection-App/tree/master/UML%20photos)
### [Explanation video](https://youtu.be/7ZFw2OHoFSc)


### Final Result
<img width="950" alt="Untitled" src="https://user-images.githubusercontent.com/65356872/115159871-012dfc80-a09e-11eb-947e-002cd49eaf6d.PNG">

