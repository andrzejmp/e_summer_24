#Calculated value of PI

def calculate_pi(n):
    Y=[]
    X=[]
    Z=[]
    s = 0
    for i in range(1,n+1):
        s = s + 1.0*(-1)**(i+1)*4/(2*i-1)
        X.append(i)
        Y.append(round(s,2))
        Z.append(3.14)
    return X, Y, Z

#100 iteracji
X, Y, Z = calculate_pi(100)


import matplotlib.pyplot as plt
plt.style.use('Solarize_Light2')

#dark_background, seaborn, ggplt, bmh, Solarize_Light2

fig,ax = plt.subplots()
ax.plot(Y, c='blue')
ax.plot(Z, c='red')

ax.set_title("Aproaching to number PI ", fontsize=12)
ax.set_xlabel('Number of iterations', fontsize=12)
ax.set_ylabel("Calculated value of PI", fontsize=12)
#ax.tick_params(axis='both', which='major', labelsize=12)
plt.show()