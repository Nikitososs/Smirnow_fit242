matrix = [[0,1,1,0],[1,0,0,1],[1,0,0,1],[0,1,1,0]]
versh = [0,1,2,3]

components = []

while len(versh)>0:
    if len(versh)>1:
        components.append(versh.pop(versh[0]))
    else: 
        components.append(versh[0])
        versh = []
    for i in range(len(components)):
        for j in range(len(matrix[components[i]])):
            if matrix[components[i]][j] == 1:
                try:
                    if len(versh)>1:
                        components.append(versh.pop(j))
                    else:
                        components.append(versh[0])
                        versh = []

                except: pass
    
print(components)