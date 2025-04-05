#Волновой алгоритм
'''
0 --- Старт
-2 --- Финиш
-1 --- Камень
1000 --- Не посещенно  
'''
from prettytable import PrettyTable
matrix = [
    [-1, -1, -1, -1, -1, -1, -1],
    [-1, 1000, 1000, 1000, -1, -1, -1],
    [-1, 1000, -1, 1000, 1000, 1000, -1],
    [-1, 1000, -1, 1000, -1, 1000, -1],
    [-1, 1000, 0, 1000, -1, -2, -1],
    [-1, 1000,1000,1000,-1,1000, -1],
    [-1, -1, -1, -1, -1, -1, -1],
   ]
ans = 0


def findNextPos(cords):
    global matrix
    global ans
    newCords = []
    for i in range(len(cords)):
        x, y = cords[i] 
        if (matrix[x-1][y] != -1) and (matrix[x-1][y] > matrix[x][y] + 1): 
            matrix[x-1][y] = matrix[x][y] + 1 
            newCords.append([x-1, y])

        if (matrix[x+1][y] != -1) and (matrix[x+1][y] > matrix[x][y] + 1):
            matrix[x+1][y] = matrix[x][y] + 1
            newCords.append([x+1, y])

        if (matrix[x][y-1] != -1) and (matrix[x][y-1] > matrix[x][y] + 1):
            matrix[x][y-1] = matrix[x][y] + 1
            newCords.append([x, y-1])

        if (matrix[x][y+1] != -1) and (matrix[x][y+1] > matrix[x][y] + 1):
            matrix[x][y+1] = matrix[x][y] + 1
            newCords.append([x, y+1])

        if (matrix[x-1][y] != -1) and (matrix[x-1][y] == -2): ans = matrix[x][y] + 1
        if (matrix[x+1][y] != -1) and (matrix[x+1][y] == -2): ans = matrix[x][y] + 1
        if (matrix[x][y-1] != -1) and (matrix[x][y-1] == -2): ans = matrix[x][y] + 1
        if (matrix[x][y+1] != -1) and (matrix[x][y+1] == -2): ans = matrix[x][y] + 1

    #print(newCords) 
    if len(newCords) != 0:   
        return findNextPos(newCords)

def printMartrix(Matrix):
    table = PrettyTable()
    table_feild = ['/']
    for i in range(len(Matrix)): table_feild.append(i) 
    table.field_names = table_feild
  
    for i in range(len(Matrix)):
        table.add_row([f'{i} ', *Matrix[i]])
    print(table)        

findNextPos([[4, 2]])    
printMartrix(matrix)
if ans  == 0:
    print('До точки нет пути')
else:    
    print(f"Длина пути: {ans}")