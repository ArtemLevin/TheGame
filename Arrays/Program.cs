int [] array = new int [10];

int count = 0;

while (count < array.Length)
{
    array[count] =new Random().Next(1, 10);
    
    Console.Write(array[count] + " " );
    count ++;
    
}

