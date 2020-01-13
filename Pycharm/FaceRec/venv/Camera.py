import cv2

img_path = 'http://192.168.137.246:8000/stream.mjpg'
cap = cv2.VideoCapture(img_path)
img = cap.read()
cv2.imshow('img', img)