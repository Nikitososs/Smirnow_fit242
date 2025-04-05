#Поиск мостов в изначально связанном графе

matrix=[[0, 1, 0, 0, 0, 0, 0, 1],
        [1, 0, 0, 0, 0, 0, 0, 1],
        [0, 0, 0, 0, 0, 1, 0, 0],
        [0, 0, 0, 0, 0, 1, 0, 0],
        [0, 0, 0, 0, 0, 0, 0, 1], 
        [0, 0, 1, 1, 0, 0, 0, 1], 
        [0, 0, 0, 0, 0, 0, 0, 1], 
        [1, 1, 0, 0, 1, 1, 1, 0]]

def connected(versh, cnt):
    can_visit = set()
    for current in versh:
        for i in range(len(matrix[current])):
            if matrix[current][i] != 0:
                can_visit.add(i)   
    for i in versh:
        can_visit.add(i)
    cnt+=1    
    if len(can_visit) >= len(matrix):
        return True
    if cnt >= len(matrix)**2:
        return False
    return connected(can_visit, cnt)

startcount = connected({0}, 0)
mosts = []
for i in range(len(matrix)):
    for j in range(len(matrix[i])):
        if matrix[i][j] != 0:
            matrix[i][j] = 0
            components = []
            if connected({0}, 0) != startcount:
                mosts.append([i,j])
            matrix[i][j] = 1

print(f"Количество рёбер являющихся мостами: {len(mosts)}, \nСписок: {mosts}")