//Sakhawat Adib
//feb 11, 2023   ||   IUT   ||    Bangladesh
 
#include<bits/stdc++.h>
using namespace std;
 
int main()
{
    int n, k, persons, valids;
	scanf("%d %d", &n, &k);

    for (int i = 0; i < n; i++) {
        scanf("%d", &persons);

        if (persons + k <= 5) {
            valids++;
        }
    }

    printf("%d", valids / 3);

    return 0;
}
