versh, components = [], []
matrix = [[0,2,0,0,0,0,0,1],
          [1,0,0,0,0,0,0,1],
          [0,0,0,1,0,1,0,0],
          [0,0,1,0,0,1,0,0],
          [0,0,0,0,0,0,0,1],
          [0,0,1,1,0,0,0,0],
          [0,0,0,0,0,0,0,1],
          [1,1,0,0,1,0,1,0]]   
 
for i in range(len(matrix)): versh.append(i)

while len(versh) > 0:
    components.append([versh[0]]), versh.remove(versh[0])
    for k in range(len(matrix)):
        i = components[-1][-1]
        for j in range(len(matrix[i])):
            if matrix[i][j] == 1 and versh.count(j) != 0:
                components[-1].append(versh.pop(versh.index(j)))
    
print(components)



