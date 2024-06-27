using namespace std;
#include <iostream>
#include <list>

int main ()
{
  list < int >numeros;
  for (int i = 0; i < 100; i++)
	{
	  numeros.push_back (random () % 100);
	}

  numeros.sort ();
  for (int num : numeros)
	{
	  cout << num << endl;
	}
	
	auto it = numeros.begin();
	while (it != numeros.end())
	{
	    if (*it % 2 == 0)
	    {
	        it = numeros.erase(it);
	    }
	    else 
	    {
	        it++;
	    }
	}
	
	for (int num : numeros)
	{
	    cout << num << endl;
	}

  return 0;
}
