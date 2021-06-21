using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;


//File.ReadAllBytes("");
//File.ReadAllBytesAsync("");

//var lines = File.ReadAllLines("TextFile1.txt");      //Blocking Programming        Blocking IO

//foreach (var line in lines)
//{
//    Console.WriteLine(line);
//}
//Accessing local files is very very fast


//Async Read all line returns TASK<STRING[]>
//Task are corner stone the foundation of async programming in c sharp
//Task is too important...its  a basic principle...
//Cars in a  parking lot...check if xxyyzz license plated car is there in that lot?...ill try to find out and come back....it will take forever
// untill we get to know that there is car or not
//THIS is blocking programming
//Giving this task to a thread ...maybe u r a thread in thread pool .ill give task and do my other work
/// <summary>
/// what is i want lot of car...2nd 3rd 6th license plate...one thread....one stud to search for lot car
/// so somehow manage and give list of enquiries and once you are done and u say i take something from list and give next one to you
/// 
/// Task is not a concrete algo ,its not complete processing,,its just a request . REPRESENTING task that i can start 
/// i can start 20 tasks...40 tasks which are light weight
/// strating 20 threads  is horrible ...starting 20 task is not a problem  because task is just a request.
/// there can be many task,,when we are idle pick next task 
/// </summary>
//var tasks=File.ReadAllLinesAsync("TextFile1.txt"); //Asynchronous Programming NonBlocking IO


//Console.WriteLine("\n\nTask Status:");
//Console.WriteLine(tasks.Status);
////Thread.Sleep(1);
//Console.WriteLine(tasks.Status);
//Console.WriteLine(tasks.Status);
//Console.WriteLine(tasks.Status);
//Console.WriteLine(tasks.Status);
//Console.WriteLine(tasks.Status);
//Console.WriteLine(tasks.Status);
//Console.WriteLine(tasks.Status);
//Console.WriteLine(tasks.Status);//here we get RanToCompletion
//Console.WriteLine(tasks.Status);
//Console.WriteLine(tasks.Status);//here we get RanToCompletion
//Console.WriteLine(tasks.Status);
//Console.WriteLine(tasks.Status);
//Console.WriteLine(tasks.Status);

//Console.WriteLine(tasks.Status);
//tasks.Wait();//Async + wait is same as BLOCKING
//Console.WriteLine(tasks.Status);

//Console.WriteLine(tasks.Status);
//var result =tasks.Result;//Accessing result like this will again be BLOCKING call so still not good
//Console.WriteLine(tasks.Status);



//Console.WriteLine("op:");

//var tasks = File.ReadAllLinesAsync("TextFie1.txt")
//    .ContinueWith(t =>
//    {
//        //Task will be completed
//        if (t.IsFaulted)
//        {
//            Console.WriteLine(t.Exception);
//            return;
//        }
//        var line = t.Result;
//        foreach (var l in lines)
//        {

//            Console.WriteLine(l);
//        }
//    });//Allows us to schedule a job/Action->its a delegate which returns which datatype

//Now instead of above complex we can use now async await

Console.WriteLine("io");

async Task ReadFile()
{

    //var lines = File.ReadAllLinesAsync ("TextFile1.txt").Result;//this result will BLOCK the CPU..it does wait
    var lines = await File.ReadAllLinesAsync("TextFile1.txt");

    foreach (var line in lines) 
    {
        Console.WriteLine(line);
    }
}
await ReadFile();
static async Task<int> GetDataFromNetworkAsync()
{
    //Simulate a network call
    await Task.Delay(150);
    var result = 42;
    return result;
}
var netRes=await GetDataFromNetworkAsync();

Func<Task<int>> getDataFromNetworkViaLambda = async () =>
{
    await Task.Delay(150);
    var result = 42;
    return result;
};
var x=await getDataFromNetworkViaLambda();
Console.ReadKey();


//use this task  object to know whether it is already completed.
//Status: waiting to run, RUNNING, COmpleted , FAULTED
//After task compltetion we have a result
//for us it is content of file
//

//Console.WriteLine(lines);
//File.ReadAllText("");
//File.ReadAllTextAsync("");

//which is preferred WAY for IO?
//->Async...99/100 cases Async methods are used
