


#include <time.h>

void arrayofdbls1();
void arrayofdbls2();
void arrayofdbls3();

int main()
{	
	
	int counter = 0;	
	int maxcalls = 100;
	int msec;	
	
	clock_t start = clock(), end;
	while(counter < maxcalls)
	{
		arrayofdbls1();
		counter++;
	}	
	end = clock() - start;
	msec = end * 1000 / CLOCKS_PER_SEC;
	printf("Time taken: %d milliseconds", msec%1000);

	return 0;	
}

void arrayofdbls1()
{
	double dblnums[10000];
	int i;
	for (i = 0; i < 9999; i++ )
	{
		dblnums[i] = i;
	}
}

 void arrayofdbls2()
{
	/* Declares an array of 10000 integers*/
	static double dblnum2[10000];	
	int i;
	for (i = 0; i < 9999; i++)
	{
		dblnum2[i] = i;
	}
}
void arrayofdbls3()
{	
	/* Declares an array of 10000 integers*/
	double* dblnum3 = (double*) malloc(sizeof(double) * 10000);
	int i;
	if(dblnum3)
	{
		for(i = 0; i < 9999; i++)
		{
			dblnum3[i]= i;
		}
	}

}

