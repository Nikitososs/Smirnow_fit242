#Поиск минимального остовного дерева
matrix = [[0,9,0,0,0,4,9],
          [9,0,0,0,2,0,0],
          [0,0,0,8,7,0,0],
          [0,0,8,0,15,1,0],
          [0,2,7,15,0,0,6],
          [4,0,0,1,0,0,0],
          [9,0,0,0,6,0,0],]   
versh = [i for i in range(len(matrix))]

lenght = 0
sd = 0
spisok = []
spisok.append(versh[0]), versh.remove(versh[0])
while len(versh) > 0:
    
    mn = 10000000
    for i in range(len(matrix[spisok[-1-sd]])):
        if matrix[spisok[-1-sd]][i] != 0 and i in versh:
            mn = min(mn, matrix[spisok[-1-sd]][i])
    if mn == 10000000:
        sd+=1
    else:            
        ver = matrix[spisok[-1-sd]].index(mn)
        spisok.append(ver)
        versh.remove(ver)
        lenght += mn

print(f"Вес минимального остовного дерева: {lenght}")
