N = int(input())
while(N > 0):
    sequence = input()
    sequence_split = sequence.split(' ')
    sequence_zero = sequence_split[0]
    len_sequence_zero = len(sequence_split[0])
    len_sequence_um = len(sequence_split[1])
    sequence_final = sequence_zero[len_sequence_zero - len_sequence_um::]
    if(sequence_final == sequence_split[1]):
        print('encaixa')
    else:
        print('nao encaixa')
    N = N - 1