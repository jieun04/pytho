# -*- coding: utf-8 -*-
"""
Created on Fri May 21 13:31:00 2021

@author: Mac_1
"""
import turtle as t
t.shape('turtle')
t.clear()
n = int(input("몇 각형을 그리시겠습니까(3-6)?"))

for i in range(n):
    t.forward(100)
    t.left(360//n)
    
    