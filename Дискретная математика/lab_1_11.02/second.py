matrix = [[0,1,0,0,0,0,0,1],
          [1,0,0,0,0,0,0,1],
          [0,0,0,1,0,1,0,0],
          [0,0,1,0,0,1,0,0],
          [0,0,0,0,0,0,0,1],
          [0,0,1,1,0,0,0,0],
          [0,0,0,0,0,0,0,1],
          [1,1,0,0,1,0,1,0]]   
versh, components = [i for i in range(len(matrix))], []

def update_all(i, current):
    global components, matrix
    for j in range(len(matrix[i])):
        if matrix[i][j] == 1 and len(components) > j:
            components[j] = [j, current]

def components_count():
    global components
    u_comp = set()
    for i in range(len(components)):
        u_comp.add(components[i][1])
    return len(u_comp)

cmp, current = 0, 0
components.append([versh[0], cmp])

for i in range(1, len(versh)):
    cmp+=1
    components.append([versh[i], cmp])
        
    for j in range(len(matrix[i])):
        if matrix[i][j] == 1 and len(components) > j:
            cp = components[-1][0]
            current = min(components[j][1], components[-1][1])
            components[-1] = [cp, current]
            cmp-=1
            break

    update_all(i, current)  

print(f"Количество компонент: {components_count()}")











