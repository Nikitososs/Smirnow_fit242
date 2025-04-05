#Форд беллман
#Стартовую вершину указать тут
startversh = 0

#То, что приняно за бесконечность
inf = 1000

matrix=[[inf, 1, inf, inf, 3],
        [inf, inf, 8, 7, 1],
        [inf, inf, inf, 1, -5],
        [inf, inf, 2, inf, inf],
        [inf, inf, inf, 4, inf]]

lambdas = []
lambda0 = [inf for x in range(len(matrix))]
lambda0[startversh] = 0
lambdas.append(lambda0)
for k in range(1, len(matrix)):
    lambda_i = []
    for i in range(len(matrix)):
        mins = []
        if i == startversh:
            mins.append(0)
        for j in range(len(matrix)):
            mins.append(lambdas[k-1][j]+matrix[j][i])
        lambda_i.append(min(mins))
    lambdas.append(lambda_i)
print(f'Последняя лямбда: {lambdas[-1]}')