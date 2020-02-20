# Employee_smart_door_sys

This project name **Employee_smart_door_sys**,target to built an employee manage system include AI demo **smart system**,which could recognize human face and judge if who belong to your company,and auto open door for them.

## Main Model

The main model is from facenet,which could consult **face_recognition**:
https://github.com/ageitgey/face_recognition

## Web structure
Web service is built by flask,Front end built by C# MVC,which inside Employee_smart_door_sys folder.
The Employee_smart_door_sys web,have a function to call a plug-in tool(an exe file,made by AutoIT)
then the tool would wake up an Flask(python base)web,and take a picture,and real time recognize the people in frond of the camera,
then judgement if it should to open the door.(not done yet.)

The Flask API endpoint structure for now as below
- To take picture: 
   localhost:5000/hello/"your name"
- To open a real time face recognize service:
   localhost:5000/whois
## IOT Side
The IOT Side would choice node MCU,not done yet.

## How to Run
After the module ready(see as notice below),make the flask web server running,

- Check the server is running,entering localhost:5000 in browser :
```
![](/smart_door/people_i_know/hello_flask.png)
```
- Take pic by entering hello + name: localhost:5000/hello/"yourname" in browser
```
![](smart_door/people_i_know/tk_pic.png)
```

- Face recognize,entering localhost:5000/whois in browser
```
![](smart_door/people_i_know/Who_am_i.jpg)
```

## Notice:
>The project didn't provide facenet,In order  to run facenet project,suggest following step: 
--------------------------------------------------

- Install anaconda(highly recommend)
- Create a new virtual env name facerec in anaconda:
   conda create --name facerec python=3.6
- Activate facrec  :
   conda activate facerec
-You should see below:
  (facerec)>
 -Install dlib:
  download the latest version from https://pypi.org/simple/dlib/
  install as below:
 (facerec)> pip install dlib-19.8.1-cp36-cp36m-win_amd64.whl
-Install opencv:
 (facerec)> pip install opencv-contrib-python
-Install face_recognition:
 (facerec)> pip install face_recognition
- After that,you could try to run this project
