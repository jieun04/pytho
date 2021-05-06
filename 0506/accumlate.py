''''
hap = 0
i = 1
while i <= 100:
    hap = hap + i
    i = i + 1

print("합 = %d" % hap)

evenhap = 0
oddHap = 0
i = 1
while i <= 100:
    if i % 2 == 0 :
        evenhap = evenhap + i
    i = i + 1
    else:
        oddHap = oddHap + i
    i = i + 1 

print("짝수 합 = %d" % evenhap)
print("홀수 합 = %d" % evenhap)
''''

''''
sevenHap = 0
i = 1
while i <= 100:
    if i % 7 == 0 :
        sevenHap = sevenHap + i
    i = i + 1

print("1-100 7의 배수 합 = %d" % sevenHap)

'''''

'''''
hap = 0
i = 1
while i <= 100:
    hap = hap + i
    if hap >= 1000:
        break
    i = i + 1

print("1-100 합 중에 처음으로 1000을 넘는 수 %d와 합 = %d" % (i, hap))

'''''

hap = 0
i = 0
while i <= 100:
    i = i + 1
    if i % 7 == 0:
        continue
    hap = hap + i

print("1-100 합 중에 7의 배수를 생략한 합 = %d" % hap)



