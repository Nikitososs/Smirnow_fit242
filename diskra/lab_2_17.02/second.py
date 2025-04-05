#Поиск минимального остовного дерева алгоритм Краскала
matrix = [[0,9,0,0,0,4,9],
          [9,0,0,0,2,0,0],
          [0,0,0,8,7,0,0],
          [0,0,8,0,15,1,0],
          [0,2,7,15,0,0,6],
          [4,0,0,1,0,0,0],
          [9,0,0,0,6,0,0]]   
versh, components = [i for i in range(len(matrix))], []

def contains_cycle(visited, st, itr):
    can_visit = set()
    for i in visited:
        for j in range(len(matrix[i[0]])):
            if matrix[i[0]][j] != 0 and j != i[1]: 
                can_visit.add((j, i[0]))
    for i in can_visit:
        if st == i[0]:
            return True
    if itr > len(matrix)**2:
        return False
    itr += 1
    return contains_cycle(can_visit, st, itr)

def check_all():
    for i in range(len(matrix)):
        if contains_cycle({(i, -1)}, i, 0) == True:
            return True
    return False



rebra = []
for i in range(len(matrix)):
    for j in range(i, len(matrix[i])):
        if matrix[i][j] != 0:
            rebra.append([matrix[i][j], (i, j)])
rebra = sorted(rebra, key=lambda x: x[0])

matrix = [[0 for i in range(len(matrix))] for y in range(len(matrix))]

ves_dereva = 0
incl = []
for k in range(len(rebra)):
    i = rebra[k][1][0]
    j = rebra[k][1][1]
    ln = rebra[k][0]
    matrix[i][j] = ln
    matrix[j][i] = ln
    if check_all() == False:
        ves_dereva+=ln
        incl.append((i, j))
    else:
        matrix[i][j] = 0
        matrix[j][i] = 0


print(f"Вес минимального остовного дерева: {ves_dereva}\nРёбра входящие в него: {incl}")