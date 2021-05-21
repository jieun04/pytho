# -*- coding: utf-8 -*-
"""
Created on Fri May 21 15:31:12 2021

@author: Mac_1
"""

import turtle as t
t.shape("turtle")
while True:
    s = t.textinput("", "도형을 입력하세요: ")
    if s =="사각형":
        s = t.textinput("", "가로: ")
        w=int(s)
        s = t.textinput("", "세로: ")
        h=int(s)
        t.forward(w)
        t.left(90)
        t.forward(h)
        t.left(90)
        t.forward(w)
        t.left(90)
        t.forward(h)
    elif s =="삼각형":
        sl = t.textinput("", "길이를 입력하세요")
        l = int(sl)
        t.forward(w)
        t.left(120)
        t.forward(l)
        t.left(120)
        t.forward(l)
    elif s =="원":
        sr = t.textinput("", "반지름을 입력하세요")
        r = int(sr)
        t.circle(r)
    else:
        t.write("사각형, 삼각형, 원 중 도형을 고르세요.")
        
    