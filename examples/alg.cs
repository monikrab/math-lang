
\*
Start with any positive integer.

Replace the number by the sum of the squares of its digits.

Repeat the process until the number equals 1 (where it will stay)
Or it loops endlessly in a cycle that does not include 1.

If the number reaches 1, it's a happy number; otherwise, it's not.
*\


int n
nat result = happy(n)

if result == 1:
    std::trace "You have a happy number!"
elif result == 0:
    std::trace "You have a sad number..."

fn is_happy(n) => (n_happy):

	n_arr = Arr.from(n)

	fn sqr(Arr array) => (Arr array^2):

	    for i = 1, array, array^2, dig^2;
	            while i <= size(array) step i++:

	        dig^2 = (array[i])^^2;
	        
		  array^2[i] = dig^2

	ret array^2


	sqr(n_arr)


	fn sum(Arr array) => (Arr S_array):

	    for with i; array; S_array
	    	  while S_array != 1 do i++:

	        S_array = sum(array)

		  if S_array != 1:
		      
			array = sqr(array) 

		  if i == 2^^14: break

	ret S_array

	sum(array^2)

	if S_array == 1: ret 1
	else: ret 0
endf

