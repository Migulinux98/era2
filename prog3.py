

def Divisor(n):

    list=[]

    for i in range (1, n+1):
        if n % i==0:
            list.append(i)

    return list        


a=12
print("The divisor of ", a, "are: ")
print(Divisor(a)) 