import serial 
import binascii

ser = serial.Serial(port="COM3",baudrate=115200,timeout=1,parity=serial.PARITY_NONE,stopbits=serial.STOPBITS_ONE,bytesize=serial.EIGHTBITS)
ser.write("\x09\x10\x03\xE8\x00\x03\x06\x00\x00\x00\x00\x00\x00\x73\x30")
