string userName = "Aybuke";

Console.WriteLine(userName.Length);
Console.WriteLine($"The last letter in your name is {userName[userName.Length - 1]}.");


//a-counter

int counter = 0;

for  (int i = 0; i < userName.Length; i++)
{
    if(userName[i] == 'a')
    {
        counter++; //counter = counter +1 
    }
}

Console.WriteLine($"Your first name has {counter} a-letters.");


//replace 
// a - 4 

string updateUsername = userName.Replace('a', '4').Replace('u', '6');

Console.WriteLine(updateUsername.Length);   
