#!/usr/bin/python3
import sys
import usb.core
import usb.util

dev = usb.core.find(idVendor=0x1189, idProduct=0x8840)

try:
    dev.reset()
except Exception as e:
    print( 'reset', e)

if dev.is_kernel_driver_active(0):
    print('detaching kernel driver')
    dev.detach_kernel_driver(0)

endpoint_out = dev[0][(0,0)][1]

import fileinput

for line in fileinput.input():
    data = eval(line)
    #print(str(data))
    data = [0x03] + data[:-1]
    result = endpoint_out.write(data)
    print(str(result))

#print(str(endpoint_out))
#endpoint_out.

#endpoint_out.write( "version".encode() + bytes([0]) )
