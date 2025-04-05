#Флойд
from prettytable import PrettyTable
Matrix = [[0,10,18,8,1000,1000],
          [10,0,16,9,21,1000],
          [1000,16,0,1000,1000,15],
          [7, 9, 1000, 0, 1000, 12],
          [1000,1000,1000,1000,0,23],
          [1000,1000,15,100,23,0]]

def makeNewMatrix(matrix):
    nMatrix = [[0 for j in range(len(matrix[0]))] for i in range(len(matrix))]
    for  k in range(len(matrix)):
        for i in range(len(matrix)):
            for j in range(len(matrix[i])):
                nMatrix[i][j] = min(matrix[i][k]+matrix[k][j], matrix[i][j])
        matrix = nMatrix        
    return nMatrix

def printMartrix(Matrix):
    table = PrettyTable()
    table_feild = ['/']
    for i in range(len(Matrix)): table_feild.append(i) 
    table.field_names = table_feild
  
    for i in range(len(Matrix)):
        table.add_row([f'{i} ', *Matrix[i]])
    print(table)    
            

printMartrix(makeNewMatrix(Matrix))