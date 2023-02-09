# mini-keyboard-configurator
This is a basic port of the original Windows
Configurator application for Linux, for this macro keyboard:

![image](images/minikeyboard.png)
![image](images/screenshot.png)

## Requirements:
* mono installed (including WinForms)
* python3 and pyusb installed

Due to the lack of libusb support in Mono,
I have used a python script to send the configuration
output to the device.

## Build and run:
```
$ make run
```

Contributions welcome!
