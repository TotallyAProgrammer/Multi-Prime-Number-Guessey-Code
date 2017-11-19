import time
maximum = 10000
numbertotest = 2 

start = time.time()
for num in range(2,maximum):
    prime = True
    for i in range(2,num):
        if (num%i==0):
            prime = False

end = time.time()
print(end - start)