import time
maximum = 10000
numbertotest = 2 

start = time.time()
for numbertotest in range(2,maximum):
    for foo in range(numbertotest//2, 2, -1):
        if (numbertotest%foo==0):
            break

end = time.time()
print(end - start)
