// change the i variables to make the code rune
// Create a Loop that prints all values from 1-255
for(int i = 1;i <= 255;i++){
    Console.WriteLine(i);
}

int e = 1;
while(e <= 255){
    Console.WriteLine(e);
    e++;
}


// Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both


for(int i = 1;i<=100;i++){
    if(i % 5 == 0){
        Console.WriteLine($"{i} divisible by 5");
    }
    else if (i % 3 == 0 ){
        Console.WriteLine($"{i} divisible by 3");
    }
// dont need this else 
    else{
        Console.WriteLine($"{i} is not divisible by 3 or 5");
    }
}


int i = 1;
while( i <= 100){
    if(i % 5 == 0){
        Console.WriteLine($"{i} divisible by 5");
    }
    else if(i % 3 == 0 ){
        Console.WriteLine($"{i} divisible by 3");
    }
    //else not needed
    else {
        Console.WriteLine($"{i} is not divisible by 3 or 5");
    }
    i++;
}


// Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5


for(int i = 1;i <= 100; i++){
    if(i % 5 == 0 && i % 3 == 0 ){
        Console.WriteLine($"{i} fizzbuzz");
    }
    else if(i % 5 == 0){
        Console.WriteLine($"{i} buzz");
    }
    else if(i % 3 == 0){
        Console.WriteLine($"{i} fizz");
    }
    // else not needed
    else{
        Console.WriteLine(i);
    }
}


int i = 1;
while(i <= 100){
    if(i % 5 == 0 && i % 3 == 0){
        Console.WriteLine($"{i} fizzbuzz");
    }
    else if(i % 5 == 0){
        Console.WriteLine($"{i} buzz");
    }
    else if (i % 3 == 0){
        Console.WriteLine($"{i} fizz");
    }
    //else not needed
    else{
        Console.WriteLine(i);
    }
    i++;
}