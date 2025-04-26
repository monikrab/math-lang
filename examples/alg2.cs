int n = 19;  // Example input

nat result = happy(n);

if result == 1:
    std::trace "You have a happy number!"

elif result == 0:
    std::trace "You have a sad number..."


digits_of(int num) => (Arr dig_arr):
    
	dig_arr = Arr.new()
    	
	while num > 0:
        	dig_arr.push(num % 10)
        	num = num / 10
return dig_arr


sqr_digits(Arr arr) => (Arr squared):
    
	squared = Arr.new()
	
	for i = 0; while i <= size(arr) step i++:
        
		squared[i] = arr[i] * arr[i];

return squared;


is_happy(int n) => (nat is_happy):
    
	seen = Set.new();

	while n != 1:

		if seen.contains(n):
            	return 0; 
        		seen.add(n);
        
        
        	digs = digits_of(n);
        	squared = sqr_digits(digs);
        

        	for n = 0, s = 0
		    while squared step
                n += s;
return 1; 
